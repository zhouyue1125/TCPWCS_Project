using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ASRS_Volvo.ServiceForVolvo;

namespace ASRS_ChangAn.UIFolder.WorkCenter
{
    public partial class FormUnLoading : Form
    {
        List<Query_Stored> Stored_cache = null;//预读库存,缓存数据
        Thread trStordCache;
        string itemDetails = string.Empty;
        public FormUnLoading()
        {
            InitializeComponent();
            trStordCache = new Thread(Query_Stored_GetAll);
            trStordCache.IsBackground = true;
            trStordCache.Start();
            lsBGate.SelectedIndex = 0;
        }

        public void Query_Stored_GetAll()
        {
            while (true)
            {
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    Stored_cache = srv.Query_Stored_GetAll().ToList();
                }
                Thread.Sleep(2000);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUnLoading_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            dGVItemQuery.AutoGenerateColumns = false;
            dGVUnLoadItems.AutoGenerateColumns = false;
            /***********************************************/

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var keyword = tBKeyWord.Text.Trim();

            if (Stored_cache == null || Stored_cache.Count == 0)
            {
                dGVItemQuery.DataSource = null;                
                return;
            }
            if (keyword != "")
            {
                List<Query_Stored> lst = null;
                try
                {
                    lst = Stored_cache.FindAll(x => ((x.ITEMSKU != null && (x.ITEMSKU.ToLower().Contains(keyword.ToLower())))
                                   || (x.CONTAINERID != null && x.CONTAINERID.Contains(keyword.ToUpper()))
                                   || (x.PLACEID != null && x.PLACEID.Contains(keyword))
                                   || (x.ITEMDESC != null && ((x.ITEMDESC.ToUpper().Contains(keyword.ToUpper()))))));
                }
                catch (Exception ex)
                {

                    throw;
                }

                dGVItemQuery.DataSource = null;
                dGVItemQuery.DataSource = lst;
            }
            else
            {
                dGVItemQuery.DataSource = null;
                dGVItemQuery.DataSource = Stored_cache.Where(x => x.CONTAINERID != "" && !string.IsNullOrEmpty(x.ITEMSKU)).ToList();//获取有货库位;
            }
        }

        private void btnEmptyContainer_Click(object sender, EventArgs e)
        {
            var emptyContainerLst = Stored_cache.Where(x => !string.IsNullOrEmpty(x.CONTAINERID) && string.IsNullOrEmpty(x.ITEMSKU)).ToList();//获取空托盘所在库位
            dGVItemQuery.DataSource = null;
            dGVItemQuery.DataSource = emptyContainerLst;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!FormMain.srmStatus.Contains("正常"))
            {
                MessageBox.Show(this, "堆垛机状态异常，不允许下发指令!");
                return;
            }
            if (dGVItemQuery.SelectedRows.Count == 0)
                return;
            lsBGate.SelectedIndex = 0;
            if (lsBGate.SelectedItem == null)
            {
                MessageBox.Show(this, "请选择出库口!");
                return;
            }
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                //var st1 = srv.DU_Device_GetOneByDeviceId("ST1");
                //if (!st1.WORKINGSTATUS.Contains("正常"))
                //{
                //    MessageBox.Show(this, "升降机有异常!,禁止发货！");
                //    return;
                //}
            }
            if (dGVItemQuery.SelectedRows[0].Cells[1].Value.ToString().Contains("TEMP"))
                return;
            //if (dGVUnLoadItems.Rows.Count >= 1)
            //    return;
            DataGridViewRow oneContainer =CommonMethod.CloneWithValues(dGVItemQuery.SelectedRows[0]);

            if (dGVUnLoadItems.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dGVUnLoadItems.Rows)
                {
                    if (row.Cells[1].Value.ToString() == oneContainer.Cells[1].Value.ToString())
                    {
                        return;
                    }
                }
            }
            oneContainer.Cells[6].Value = lsBGate.SelectedItem.ToString();

            dGVUnLoadItems.Rows.Add(oneContainer);
            dGVUnLoadItems.Refresh();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (dGVUnLoadItems.SelectedRows.Count > 0)
            {
                dGVUnLoadItems.Rows.Remove(dGVUnLoadItems.SelectedRows[0]);
                dGVUnLoadItems.Refresh();
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

        private void getTASKCONTENTSTRING(string CONTAINERID)
        {
            itemDetails = null;
            using(ASRS_ServiceSoapClient srv=new ASRS_ServiceSoapClient())
            {
               var cvis= srv.Container_Vs_Items_GetItemsByContainerID(CONTAINERID);
                foreach(var one in cvis)
                {
                    itemDetails += one.ITEMDESC + ":" + one.ITEMQTY.ToString("0.##")+ "套; ";
                }
            }
        }

        private void btnUnLoad_Click(object sender, EventArgs e)
        {
            
            List<Query_Stored> unLoadLst = new List<Query_Stored>();
            string isEmptyContainer = "N";
            string toPlace = "";
            if (dGVUnLoadItems.Rows.Count == 0)
                return;
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                int count = 0;
                    foreach (DataGridViewRow p in dGVUnLoadItems.Rows)
                    {
                        
                        Query_Stored one = new Query_Stored();
                        one.WAREHOUSENO = p.Cells[0].Value == null ? "" : p.Cells[0].Value.ToString();
                        one.PLACEID = p.Cells[1].Value.ToString();
                        one.CONTAINERID = p.Cells[2].Value.ToString();
                        one.ITEMDESC = p.Cells[4].Value == null ? "" : p.Cells[4].Value.ToString();
                        one.ITEMQTY = decimal.Parse(p.Cells[5].Value == null ? "0" : p.Cells[5].Value.ToString());
                        one.ITEMSKU = p.Cells[3].Value == null ? "" : p.Cells[3].Value.ToString();

                        toPlace = p.Cells[6].Value.ToString();
                        switch (toPlace)
                        {
                            case "出入口10001":
                                toPlace = "10001";
                                break;

                            default:
                                toPlace = "10001";
                                break;
                        }
                        unLoadLst.Add(one);

                        if (unLoadLst.Count < 1)
                            return;
                        else
                        {
                            //foreach (var unLoadOne in unLoadLst)
                            //{
                                OD_Task taskSRM = new OD_Task();
                                //MessageBox.Show(unLoadLst[count].PLACEID);
                                #region newTask
                                taskSRM.TASKID = Guid.NewGuid().ToString();
                                taskSRM.TASKNAME = "堆垛机出库" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                                taskSRM.TASKTYPE = "SRM_Retrieve_Out";    //任务类型
                                taskSRM.TASKTYPEDESCRIPTION = "堆垛机出库";
                                taskSRM.TASKSTATUS = "Out_Intention"; //想要入库
                                taskSRM.TASKLEVEL = "Normal";
                                getTASKCONTENTSTRING(unLoadLst[count].CONTAINERID);
                                taskSRM.TASKCONTENTSTRING = itemDetails;
                                taskSRM.DODEVICEID = "SRM_1"; //设备号
                                taskSRM.DODEVICENODEID = "000011";  //设备节点号
                                taskSRM.DODEVICETYPE = "SRM";  //设备类型
                                taskSRM.SOURCEPLACE = unLoadLst[count].PLACEID;
                                taskSRM.TOPLACE = toPlace;  //出库口
                                taskSRM.SENDTIMES = 1;
                                taskSRM.RELEASESTATUS = "N";
                                taskSRM.HADFINISH = "N";
                                taskSRM.ORDERHEADID = "";
                                taskSRM.ORDERDETAILSID = "";
                                taskSRM.VOID = 0;
                                taskSRM.UPDATEUSER = FormLogin.user.USERNAME;
                                taskSRM.UPDATETIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                taskSRM.ISCURRENTTASK = "N";
                                taskSRM.ISLASTTASK = "N";
                                taskSRM.CONTAINERNO = unLoadLst[count].CONTAINERID;
                                taskSRM.INPUTLOCATIONLEVEL = 1;
                                taskSRM.ISEMPTYCONTAINER = isEmptyContainer;
                                taskSRM.WAREHOUSENO = "端拾器立体库";

                                IV_place_vs_container pvc = new IV_place_vs_container();
                                try
                                {
                                    pvc = srv.Place_Vs_Container_GetRelationshipByContainer(taskSRM.CONTAINERNO)[0];

                                    if (pvc.PLACEID.ToUpper().Contains("TEMP"))
                                    {
                                        MessageBox.Show("托盘:" + taskSRM.CONTAINERNO + "正在出库!");
                                        return;
                                    }

                                }

                                catch (Exception)
                                {
                                    MessageBox.Show("托盘:" + taskSRM.CONTAINERNO + "已出库!");
                                    return;
                                }

                                var undoTask = srv.Od_Task_GetNotFinishedTask_by_deviceID("SRM_1").ToList();
                                undoTask = undoTask.FindAll(x => (x.TOPLACE == "10001" || x.TOPLACE == "11601" || x.TOPLACE == "20001"));
                                var curtsk = srv.Od_Task_GetCurrentTaskByDeviceID("SRM_1");
                                if (curtsk.TOPLACE == "10001")
                                {
                                    undoTask.Add(curtsk);
                                }
                                //foreach (var o in undoTask)//如果任务序列中的任务目标位和未完成任务目标位子冲突,不允许下发
                                //{
                                //    if (taskSRM.TOPLACE == o.TOPLACE)
                                //    {
                                //        MessageBox.Show(taskSRM.CONTAINERNO + "的出库口尚有出库任务执行中,请稍后再执行!");
                                //        return;
                                //    }
                                //}
                                #endregion
                                if (srv.Od_Task_InsertOne(taskSRM))
                                {
                                    ///将库位号改为TEMP_OUT
                                    pvc.PLACEID = "TEMP_OUT";
                                    pvc.UPDATETIME = DateTime.Now.ToString();
                                    pvc.UPDATEUSER = FormLogin.user.USERNAME;
                                    srv.Place_Vs_Container_UpdateOne(pvc);
                                }
                            //}

                        }
                        count++;
                    }
                    count = 0;
                dGVUnLoadItems.Rows.Clear();
                dGVUnLoadItems.Refresh();
                lsBGate.SelectedIndex = -1;
                dGVItemQuery.DataSource = null;
                wait(1500);
                btnFind_Click(null, null);//出库后执行页面刷新
            }
        }

        private void btnTaskSecquent_Click(object sender, EventArgs e)
        {
            FrmOdLst f = new FrmOdLst();
            f.ShowDialog();
        }

  
        
    }
}
