using ASRS_Volvo.ServiceForVolvo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace ASRS_ChangAn.UIFolder.WorkCenter
{
    
    public partial class FrmLoading : Form
    {
        string currentContainer = string.Empty;
        string itemDetails = string.Empty;
        public FrmLoading()
        {
            InitializeComponent();
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            { srv.CommonMethod_GetServerTime(); }
        }

        private void tBSku_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tBSku.Text != "0000")
                {
                    isSkuRight();
                }
                else {
                    frmIn();
                }
                
                   
             }
                  
            
        }


        private bool isSkuRight() {
            string sku = tBSku.Text.Trim();

                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    if (tBContainer.Enabled == true)
                    {
                        MessageBox.Show("请先对托盘号绑定再进行扫码工作");

                        return false;
                    }
                    if (string.IsNullOrEmpty(tBContainer.Text.Trim()))
                    {
                        return true;//无条码则退出
                    }
                    if (sku == "")
                    {
                        return true;
                    }
                    try
                    {
                        var item = srv.IM_Item_GetOneBySku(sku);
                        if (item == null || string.IsNullOrEmpty(item.SKU))
                        {
                            MessageBox.Show("无此物料！");
                            tBSku.Text = "";
                            return false;
                        }
                        if (AlreadyScan.Text.IndexOf(tBSku.Text) != -1) {
                            MessageBox.Show("物料条码不能重复扫描！");
                            tBSku.Text = "";
                            return false;
                        }
                        if (tBSku.Text != "0000" && label4.Visible == false)
                        {
                            label4.Visible = true;
                            AlreadyScan.Visible = true;
                        }
                        
                        if (AlreadyScan.Text == "")
                        {
                            AlreadyScan.Text = tBSku.Text;
                        }
                        else
                        {
                            AlreadyScan.Text += ";\r\n" + tBSku.Text;
                        }
                        // MessageBox.Show(AlreadyScan.Height.ToString());
                        AlreadyScan.Height = 32 * (AlreadyScan.Text.ToString().Split(';').Length);
                        var cvi = new IV_container_vs_item();
                        cvi.ID = Guid.NewGuid().ToString();
                        cvi.ITEMDESC = item.SKUDESC;
                        cvi.ITEMQTY = 1;
                        cvi.ITEMSKU = sku;
                        cvi.UPDATETIME = srv.CommonMethod_GetServerTime().ToString("yyyy-MM-dd HH:mm:ss");
                        cvi.UPDATEUSER = "";
                        cvi.VOID = 0;
                        cvi.CONTAINERID = tBContainer.Text.Trim();

                        srv.Container_Vs_Items_InsertOne(cvi);
                        itemDetails += "" + cvi.ITEMDESC + ":" + cvi.ITEMQTY + "套 " + ";";
                        tBSku.Text = "";
                        tBSku.Focus();
                        return true;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        return false;
                        MessageBox.Show("连接数据库失败!");
                    }
                }
        }

        private void tBGate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tBGate.Text.Trim() != "10001" )
                {
                    MessageBox.Show("入库口不正确");
                    return;
                }
                tBGate.Enabled = false;
                tBSku.Focus();
            }
        }

        private void tBContainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    var container = srv.IM_Container_GetOneByContainerId(tBContainer.Text.Trim());
                    if (container == null || string.IsNullOrEmpty(container.CONTAINERID))
                    {
                        MessageBox.Show("无此托盘信息!");
                        return;
                    }
                    else
                    {
                        tBContainer.Enabled = false;
                        tBGate.Focus();
                    }

                    if (isStoredContainer(container.CONTAINERID)!=0)
                    {
                        MessageBox.Show("托盘已经扫描过或已经在货架上");
                        tBContainer.Enabled = true;
                        tBContainer.SelectAll();
                        tBContainer.Focus();
                        return;
                    }
                }
                //changeImg(1);
            }
        }

        private void img_heibai_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 交替图片 1.入库按钮解锁,其它.锁定
        /// </summary>
        /// <param name="n"></param>
        private void changeImg(int n)
        {
            if (n == 1)
            {
                btn_SrmIn.Enabled = true;
            }
            else
            {
                btn_SrmIn.Enabled = false;
            }
        }
      
        /// <summary>
        /// 检查托盘是否已经在货架上 0：未扫描,1:已扫描未入库，2：已入库
        /// </summary>
        /// <param name="containerId"></param>
        /// <returns>
        /// </returns>
        private int isStoredContainer(string containerId)
        {
           
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                var pvc = srv.Place_Vs_Container_GetRelationshipByContainer(containerId);
                if (pvc != null && pvc.Length>0)
                {
                    if (pvc[0].PLACEID.Contains("TEMP"))
                    {
                        return 1;
                    }
                    else {
                        return 2;
                    }
                   
                }
                else
                {
                   return 0;
                }
            }
        }

        /// <summary>
        /// 插入库位和容器关联表
        /// </summary>
        /// <returns></returns>
        private bool insertToPlace_Vs_Container()
        {
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                IV_place_vs_container plct = new IV_place_vs_container();
                plct.CONTAINERID = currentContainer;
                plct.ID = Guid.NewGuid().ToString();
                plct.PLACEID = "TEMP_RCV";              
                plct.UPDATEUSER = "";
                plct.UPDATETIME = srv.CommonMethod_GetServerTime().ToString("yyyy-MM-dd HH:mm:ss");
                plct.WAREHOUSENO = "端拾器立体库";

                if (srv.Place_Vs_Container_InsertOne(plct))  //插入到库位容器库存表，库位是TEMP_RCV
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 系统等待XX毫秒
        /// </summary>
        /// <param name="Milliseconds"></param>
        public static void wait(int Milliseconds)
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddMilliseconds(Milliseconds) > DateTime.Now);
        }

        /// <summary>
        /// 插入任务表
        /// </summary>
        /// <param name="fromPlace"></param>
        /// <param name="toPlace"></param>
        private bool GreateTask(string fromPlace, string toPlace)
        {
            //string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                string nowTime = srv.CommonMethod_GetServerTime().ToUniversalTime().AddHours(8).ToString("yyyy-MM-dd HH:mm:ss");
                OD_Task taskSRM = new OD_Task();
                taskSRM.TASKID = Guid.NewGuid().ToString();
                taskSRM.TASKNAME = "堆垛机入库" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                taskSRM.TASKTYPE = "SRM_Store_In";    //任务类型
                taskSRM.TASKTYPEDESCRIPTION = "堆垛机入库";
                taskSRM.TASKSTATUS = "In_Intention"; //想要入库
                taskSRM.TASKLEVEL = "Normal";
                taskSRM.TASKCONTENTSTRING = itemDetails;
                taskSRM.DODEVICEID = "SRM_1"; //设备号
                taskSRM.DODEVICENODEID = "000011";  //设备节点号
                taskSRM.DODEVICETYPE = "SRM";  //设备类型
                taskSRM.SOURCEPLACE = fromPlace;
                taskSRM.TOPLACE = toPlace;  //入库口和目标库位
                taskSRM.SENDTIMES = 1;
                taskSRM.RELEASESTATUS = "N";
                taskSRM.HADFINISH = "N";
                taskSRM.ORDERHEADID = "";
                taskSRM.ORDERDETAILSID = "";
                taskSRM.VOID = 0;              
                taskSRM.UPDATEUSER = "";              
                taskSRM.UPDATETIME = nowTime;
                taskSRM.ISCURRENTTASK = "N";
                taskSRM.ISLASTTASK = "N";
                taskSRM.CONTAINERNO = tBContainer.Text.Trim();
                taskSRM.INPUTLOCATIONLEVEL = 1;
                taskSRM.WAREHOUSENO = "端拾器立体库";

                if (srv.Od_Task_InsertOne(taskSRM))
                {
                    itemDetails = string.Empty;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void clearControl()
        {
            tBContainer.Enabled = true;
            tBContainer.Text = "";
            //tBGate.Text = "";
            tBSku.Text = "";
            //tBGate.Enabled = true;
            tBContainer.Focus();
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("非维护时可无需关闭！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
          
        }

        private void lbLogin_ParentChanged(object sender, EventArgs e)
        {

        }
        //入库方法
        private void frmIn()
        {
           
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                var container = srv.IM_Container_GetOneByContainerId(tBContainer.Text.Trim());
                if (container == null || string.IsNullOrEmpty(container.CONTAINERID))
                {
                    MessageBox.Show("无此托盘信息!");
                    return;
                }
                else
                {
                    tBContainer.Enabled = false;
                    tBGate.Focus();
                }

                if (isStoredContainer(container.CONTAINERID) != 0)
                {
                    MessageBox.Show("托盘已经扫描过或已经在货架上");
                    tBContainer.Enabled = true;
                    tBContainer.SelectAll();
                    tBContainer.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(tBContainer.Text.Trim()))
                {
                    return;//无条码则退出
                }

            }
            if (tBSku.Text != "0000") {
                if (isSkuRight() == false)
                {
                    return;
                }
            }
            

            currentContainer = tBContainer.Text.Trim();
            if (currentContainer.Length < 7)
            {
                MessageBox.Show("托盘号格式不正确！");
                return;
            }

            //changeImg(2);
            wait(100);


            string fromPlace = "";
            switch (tBGate.Text.Trim())
            {
                case "10001":
                    fromPlace = "10001";
                    break;
                //case "20001":
                //    fromPlace = "20001";
                //    break;
                //case "11601":
                //    fromPlace = "11601";
                //    break;
                default:
                    MessageBox.Show("入库口错误!");
                    return;
            }
            string toPlace = currentContainer.Substring(2);

            if (!insertToPlace_Vs_Container())
            {
                MessageBox.Show("生成库位信息失败!");
                btnClear_Click(null, null);
                changeImg(1);
                wait(100);
                return;
            }
            bool Licences = true;//入库授权
            //switch (fromPlace)
            //{
            //    case "10501":
            //        Licences = srv.SSJ_Licences(2);
            //        break;
            //    case "10301":
            //        Licences = srv.SSJ_Licences(1);
            //        break;
            //    case "11901":
            //        Licences = srv.SSJ_Licences(3);
            //        break;
            //}
            if (Licences)
            {
                if (GreateTask(fromPlace, toPlace))
                {
                    clearControl();

                }
                else
                {
                    MessageBox.Show("创建入库指令失败!");
                }
            }
            else
            {
                MessageBox.Show("发送入库授权指令失败!");
            }

            AlreadyScan.Text = "";
            label4.Visible = false;
            AlreadyScan.Visible = false;
            AlreadyScan.Height = 32;
        }
        private void btn_SrmIn_Click_1(object sender, EventArgs e)
        {
            frmIn();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AlreadyScan.Text = "";
            label4.Visible = false;
            AlreadyScan.Visible = false;
            AlreadyScan.Height = 32;
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                if (MessageBox.Show("此操作会导致该小车的库存数据被清除,是否继续操作?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var container = srv.IM_Container_GetOneByContainerId(tBContainer.Text.Trim());
                    if (container == null || string.IsNullOrEmpty(container.CONTAINERID))
                    {
                        MessageBox.Show("无此托盘信息!");
                        return;
                    }
                   
                    if (isStoredContainer(container.CONTAINERID)==2)
                    {
                        MessageBox.Show("托盘已经在货架上，若要解除绑定，请进行出库作业！");
                        tBContainer.Enabled = true;
                        tBContainer.SelectAll();
                        tBContainer.Focus();
                        return;
                    }
                    if (tBContainer.Enabled == true){
                        MessageBox.Show("托盘号尚未绑定可直接修改单元格，无需清除数据");
                        return;
                    }
                    try
                    {
                        srv.Place_Vs_Container_DeleteOne(tBContainer.Text.Trim());
                        var itemsIncontainer = srv.Container_Vs_Items_GetItemsByContainerID(tBContainer.Text.Trim()).ToList();
                        foreach (var p in itemsIncontainer)
                        {
                            srv.Container_Vs_Items_DeleteOneByContainerID(p.CONTAINERID);
                        }
                        tBContainer.Text = "";
                        tBSku.Text = "";
                        tBContainer.Enabled = true;
                        changeImg(1);
                        tBContainer.Focus();
                    }
                    catch (Exception)
                    {

                    }
                }

            }
           
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            //using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            //{
            //    srv.CommonMethod_GetServerTime();
            //}
        }
    }
}
