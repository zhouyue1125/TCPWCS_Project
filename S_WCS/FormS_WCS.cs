using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using S_WCS.Web_Service;
using System.Diagnostics;


namespace S_WCS
{
    public partial class FormS_WCS : Form
    {
        Thread threadReadLable, threadSRMImg, threadGoodsImg,threadTask,threadSSJ;
        ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient();
        Point goodPoint = new Point();        
        DU_Device srm = new DU_Device();
        Stacker stk = new Stacker();
        OD_Task currentTask = new OD_Task();
        int taskID;
        /// <summary>
        /// 握手号:不重复值
        /// </summary>
        object handShakeValue = "llk";

        public FormS_WCS()
        {
            InitializeComponent();          
            srm.DEVICEID = "SRM_1";
            CheckForIllegalCrossThreadCalls = false;
            goodPoint.Y = pic_SRM.Location.Y + 5;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (threadGoodsImg!=null&&threadGoodsImg.IsAlive)
            //    {
            //        threadGoodsImg.Join(20);
            //        threadGoodsImg.Abort();
            //        threadGoodsImg = null;
            //    }
            //    if (threadSRMImg!=null&& threadSRMImg.IsAlive)
            //    {
            //        threadSRMImg.Join(50);
            //        threadSRMImg.Abort();
            //        threadSRMImg = null;
            //    }
            //    if (threadReadLable!=null&& threadReadLable.IsAlive)
            //    {
            //        threadReadLable.Join(50);
            //        threadReadLable.Abort();
            //        threadReadLable = null;
            //    }
            //    if (threadReadLable!=null&& threadReadLable.IsAlive)
            //    {
            //        threadReadLable.Join(50);
            //        threadReadLable.Abort();
            //        threadReadLable = null;
            //    }
            //    if (threadTask!=null&& threadTask.IsAlive)
            //    {
            //        threadTask.Join(50);
            //        threadTask.Abort();
            //        threadTask = null;
            //    }
                
            //    Application.Exit();
            //}
            //catch (Exception)
            //{               
            //    Close();
            //}
            Close();
        }

        private void FormS_WCS_Load(object sender, EventArgs e)
        {

            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    if (process.MainModule.FileName == current.MainModule.FileName)
                    {
                        Application.Exit();
                        return;
                    }
                }
            }     
            threadReadLable = new Thread(SRMRead_Lable);
            threadReadLable.IsBackground = true;
            threadReadLable.Start();
            threadSRMImg = new Thread(SRM_Img);
            threadSRMImg.IsBackground = true;
            threadSRMImg.Start();
            threadGoodsImg = new Thread(GoodS_Img);
            threadGoodsImg.IsBackground = true;
            threadGoodsImg.Start();
            threadTask = new Thread(Task_Img);
            threadTask.IsBackground = true;
            threadTask.Start();
            threadSSJ = new Thread(SSJ_Alarm);
            threadSSJ.IsBackground = true;
            threadSSJ.Start();
            dGV_Alert.AutoGenerateColumns = false;
            cmBDevice.SelectedIndex = 0;
        }

        private void SSJ_Alarm()
        {
            ArrayOfString ssjAlert = new ArrayOfString();
            ssjAlert.Add(stk.Read_Index[Stacker.Read_Index_SSJ_1_Alarm_Code]);
            ssjAlert.Add(stk.Read_Index[Stacker.Read_Index_SSJ_2_Alarm_Code]);
            ssjAlert.Add(stk.Read_Index[Stacker.Read_Index_SSJ_3_Alarm_Code]);
            while (true)
            {
                var reader = srv.OPC_Read(ssjAlert);
                if (reader[0].ToString() != "0")
                {
                    lb_SSJ1_Alert.Text = TranslateSSJAlertCode(int.Parse(reader[0].ToString()));
                    lb_SSJ1_Alert.ForeColor = Color.Red;
                }
                else
                {
                    lb_SSJ1_Alert.Text = "正常";
                    lb_SSJ1_Alert.ForeColor = Color.Lime;
                }
                if (reader[1].ToString() != "0")
                {
                    lb_SSJ2_Alert.Text = TranslateSSJAlertCode(int.Parse(reader[1].ToString()));
                    lb_SSJ2_Alert.ForeColor = Color.Red;
                }
                else
                {
                    lb_SSJ2_Alert.Text = "正常";
                    lb_SSJ2_Alert.ForeColor = Color.Lime;
                }
                if (reader[2].ToString() != "0")
                {
                    lb_SSJ3_Alert.Text = TranslateSSJAlertCode(int.Parse(reader[2].ToString()));
                    lb_SSJ3_Alert.ForeColor = Color.Red;
                }
                else
                {
                    lb_SSJ3_Alert.Text = "正常";
                    lb_SSJ3_Alert.ForeColor = Color.Lime;
                }
                wait(1000);
            }
        }

        private void Task_Img(object obj)
        {
            while (true)
            {
                if ( stk.workMode!=null&&TanslateWorkMode(int.Parse(stk.workMode)) != "空闲")
                {
                    try
                    {
                        OD_Task currentTask = srv.Od_Task_GetCurrentTaskByDeviceID("SRM_1");
                        lbContainerID.Text = "托盘号:" + currentTask.CONTAINERNO;
                        lbDestination.Text = "目标地址" + currentTask.TOPLACE;
                        lbSourcePlace.Text = "起始地址" + currentTask.SOURCEPLACE;
                        lbItemName.Text = "物料名称:";
                        lbSku.Text = "物料号:";
                        lbTaskType.Text = "作业指令:" + currentTask.TASKTYPEDESCRIPTION;
                        if (currentTask.ISEMPTYCONTAINER == "N")
                        {
                            var itemsLst = srv.Container_Vs_Items_GetItemsByContainerID(currentTask.CONTAINERNO).ToList();
                            foreach (var p in itemsLst)
                            {
                                lbItemName.Text += p.ITEMDESC + "; ";
                                lbSku.Text += p.ITEMSKU + "; ";
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    lbContainerID.Text = "托盘号:" ;
                    lbDestination.Text = "目标地址";
                    lbSourcePlace.Text = "起始地址" ;
                    lbItemName.Text = "物料名称:";
                    lbSku.Text = "物料号:";
                    lbTaskType.Text = "作业指令:" ;
                }
                wait(3000);
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
        /// 将工作模式翻译成中文
        /// </summary>
        /// <param name="workMode"></param>
        /// <returns></returns>
        private string TanslateWorkMode(int workMode)
        {
            string rtn;
            switch (workMode)
            {
                case 0:
                    rtn = "空闲";
                    break;
                case 1:
                    rtn = "定位";
                    break;
                case 2:
                    rtn = "取货";
                    break;
                case 3:
                    rtn = "放货";
                    break;   
                default:
                    rtn = "未知";
                    break;
            }
            return rtn;
        }

        /// <summary>
        /// 堆垛机报警代码解析
        /// </summary>
        /// <param name="alertCode"></param>
        /// <returns></returns>
        private string TranslateAlertCode(int alertCode)
        {
            string alarmCode = "";
            switch (alertCode)
            {
                case 1:
                    alarmCode = "行走极限开关动作";
                    break;
                case 2:
                    alarmCode = "载货台上极限开关动作";
                    break;
                case 3:
                    alarmCode = "载货台下极限开关动作";
                    break;
                case 4:
                    alarmCode = "电气柜门急停开关被按下";
                    break;
                case 5:
                    alarmCode = "外部急停按钮被按下";
                    break;
                case 6:
                    alarmCode = "载货台超速保护装置动作";
                    break;
                case 7:
                    alarmCode = "松绳开关1未正常工作";
                    break;
                case 8:
                    alarmCode = "松绳开关2未正常工作";
                    break;
                case 9:
                    alarmCode = "过载开关1未正常工作";
                    break;
                case 10:
                    alarmCode = "过载开关2未正常工作";
                    break;
                case 11:
                    alarmCode = "相序保护器异常";
                    break;
                case 12:
                    alarmCode = "安全继电器异常";
                    break;
                case 13:
                    alarmCode = "行走变频器故障";
                    break;
                case 14:
                    alarmCode = "起升变频器故障";
                    break;
                case 15:
                    alarmCode = "货叉变频器故障";
                    break;
                case 16:
                    alarmCode = "行走马达保护器故障";
                    break;
                case 17:
                    alarmCode = "起升马达保护器故障";
                    break;
                case 18:
                    alarmCode = "货叉马达保护器故障";
                    break;
                case 19:
                    alarmCode = "行走电机抱闸供电故障";
                    break;
                case 20:
                    alarmCode = "起升电机抱闸供电故障";
                    break;
                case 21:
                    alarmCode = "货叉电机抱闸供电故障";
                    break;
                case 22:
                    alarmCode = "V2供电异常";
                    break;
                case 23:
                    alarmCode = "风扇供电异常";
                    break;
                case 24:
                    alarmCode = "V2输出异常";
                    break;
                case 25:
                    alarmCode = "安全回路供电异常";
                    break;
                case 26:
                    alarmCode = "柜内24V供电异常";
                    break;
                case 27:
                    alarmCode = "载货台24V供电异常";
                    break;
                case 28:
                    alarmCode = "行走电机运行超时";
                    break;
                case 29:
                    alarmCode = "起升电机运行超时";
                    break;
                case 30:
                    alarmCode = "货叉电机运行超时";
                    break;
                case 31:
                    alarmCode = "输送机光栅报警";
                    break;
                case 32:
                    alarmCode = "货叉扭矩检测异常";
                    break;
                case 33:
                    alarmCode = "1#输送机人员非法闯入";
                    break;
                case 34:
                    alarmCode = "2#输送机人员非法闯入";
                    break;
                case 35:
                    alarmCode = "3#输送机人员非法闯入";
                    break;
                case 101:
                    alarmCode = "行走激光丢失";
                    break;
                case 102:
                    alarmCode = "起升激光丢失";
                    break;
                case 103:
                    alarmCode = "货叉信号丢失";
                    break;
                case 104:
                    alarmCode = "Profibus总线通讯故障";
                    break;
                case 105:
                    alarmCode = "行走停准失败";
                    break;
                case 106:
                    alarmCode = "起升停准失败";
                    break;
                case 107:
                    alarmCode = "货叉停准失败";
                    break;
                case 108:
                    alarmCode = "载货台货物左坍塌";
                    break;
                case 109:
                    alarmCode = "载货台货物右坍塌";
                    break;
                case 110:
                    alarmCode = "载货台货物左前超宽";
                    break;
                case 111:
                    alarmCode = "载货台货物左后超差";
                    break;
                case 112:
                    alarmCode = "载货台货物右前超差";
                    break;
                case 113:
                    alarmCode = "载货台货物右后超差";
                    break;
                case 114:
                    alarmCode = "载货台货物左超高";
                    break;
                case 115:
                    alarmCode = "载货台货物右超高";
                    break;
                case 116:
                    alarmCode = "货叉位置错误";
                    break;
                case 117:
                    alarmCode = "货叉左侧极限";
                    break;
                case 118:
                    alarmCode = "货叉右侧极限";
                    break;
                case 119:
                    alarmCode = "上位机下达急停指令";
                    break;
                case 120:
                    alarmCode = "取货后载货台无货";
                    break;
                case 121:
                    alarmCode = "放货时目标货位有货";
                    break;
                case 122:
                    alarmCode = "放货后载货台有货";
                    break;
                case 123:
                    alarmCode = "载货台货物左超高2";
                    break;
                case 124:
                    alarmCode = "载货台货物右超高2";
                    break;
                case 125:
                    alarmCode = "载货台货物左超高3";
                    break;
                case 126:
                    alarmCode = "载货台货物右超高3";
                    break;
                case 201:
                    alarmCode = "放货或取货超时";
                    break;
                case 202:
                    alarmCode = "输送机不允许取货";
                    break;
                case 203:
                    alarmCode = "输送机不允许放货";
                    break;
                case 301:
                    alarmCode = "自动模式下无任务，载货台有货";
                    break;
                case 302:
                    alarmCode = "任务错误,任务地址错误";
                    break;
                case 303:
                    alarmCode = "任务错误,没有卸货任务";
                    break;
                case 304:
                    alarmCode = "任务错误,任务错误,载货台有货,有取货任务";
                    break;
                case 305:
                    alarmCode = "任务错误,任务错误,载货台无货,无取货任务";
                    break;
                case 306:
                    alarmCode = "任务错误,上一任务未完成";
                    break;
                case 307:
                    alarmCode = "堆垛机与小车通讯故障";
                    break;
                default:
                    alarmCode = "获取报警信息失败";
                    break;
            }
            return alarmCode;
        }

        /// <summary>
        /// 输送机报警代码解析
        /// </summary>
        /// <param name="alertCode"></param>
        /// <returns></returns>
        private string TranslateSSJAlertCode(int alertCode)
        {
            string alarmCode = "";
            switch (alertCode)
            {
                case 1:
                    alarmCode = "急停";
                    break;
                case 2:
                    alarmCode = "变频器报警";
                    break;
                case 3:
                    alarmCode = "超重";
                    break;             
                case 4:
                    alarmCode = "外形报警";
                    break;
                case 5:
                    alarmCode = "光栅报警";
                    break;
                case 6:
                    alarmCode = "条码未读到";
                    break;
                case 7:
                    alarmCode = "条码错误";
                    break;
                case 8:
                    alarmCode = "脱机";
                    break;
                case 9:
                    alarmCode = "柜门急停";
                    break;
                case 10:
                    alarmCode = "安全门打开";
                    break;
                case 11:
                    alarmCode = "非法闯入";
                    break;
                default:
                    alarmCode = "获取报警信息失败";
                    break;
            }
            return alarmCode;
        }
        /// <summary>
        /// 后台读取的数据写入lable
        /// </summary>
        private void SRMRead_Lable()
        {
            string itemName;
            while (true)
            {
                if (stk.currentState == "正常")
                {
                    try
                    {
                        itemName = stk.Read_Index[Stacker.READ_Index_TravelPos];
                        stk.nTravelPos = int.Parse(stk.ReadValuePoint(itemName).ToString());
                        lbSRM_YLocation.Text = "当前行走位置:" + stk.nTravelPos.ToString();
                        itemName = stk.Read_Index[Stacker.READ_Index_LiftPos];
                        stk.nLiftPos = int.Parse(stk.ReadValuePoint(itemName).ToString());
                        lbSRM_ZLocation.Text = "当前升降位置:" + stk.nLiftPos.ToString();
                        itemName = stk.Read_Index[Stacker.READ_Index_ForkPos];
                        stk.nForkPos = int.Parse(stk.ReadValuePoint(itemName).ToString());
                        lbSRM_XLocation.Text = "当前伸叉位置:" + stk.nForkPos.ToString();
                        itemName = stk.Read_Index[Stacker.READ_Index_WorkStatus];
                        stk.workMode = stk.ReadValuePoint(itemName).ToString();
                        lbWorkMode.Text = "工作状态:" + TanslateWorkMode(int.Parse(stk.workMode));
                        lbAlert.Text = " 故障:无";
                        lbAlert.BackColor = Color.White;
                        lbAlert.ForeColor = Color.Aqua;
                    }
                    catch (Exception)
                    {

                    }
                }
                else if (stk.currentState == "报警")
                {                    
                    itemName = stk.Read_Index[Stacker.READ_Index_ALARM_Code];
                    object alertCode = stk.ReadValuePoint(itemName);
                    try
                    {
                        string alarmDesc = TranslateAlertCode(int.Parse(alertCode.ToString()));
                        lbAlert.Text = "报警:" + alarmDesc;
                        lbAlert.BackColor = Color.Red;
                        lbAlert.ForeColor = Color.White;                       
                    }
                    catch (Exception)
                    {

                    }
                }
                wait(200);
            }
        }

        private void GoodS_Img(object obj)
        {
            while (true)
            {
                if (stk.workMode == "2" && ((stk.nForkPos <= 103400) || (stk.nForkPos >= 107900)))
                {
                    pic_EmptyPallet.Visible = true;
                }
                else if (stk.workMode == "3" && ((stk.nForkPos <= 103400) || (stk.nForkPos >= 107900)))
                {
                    pic_EmptyPallet.Visible = false;
                }
                goodPoint.X = pic_SRM.Location.X + 35;
                goodPoint.Y = (105648 - stk.nForkPos) / 46 + 54;
                pic_EmptyPallet.Location = goodPoint;
                wait(50);
            }
        }

        /// <summary>
        /// 用后台读取Y坐标数据控制堆垛机图像移动
        /// </summary>
        private void SRM_Img()
        {
            while (true)
            {
                Point srmPoint = new Point();
                srmPoint.Y = pic_SRM.Location.Y;
                srmPoint.X = Convert.ToInt32(((stk.nTravelPos / 64)) - 13);
                pic_SRM.Location = srmPoint;
                wait(50);
            }
        }

       

        private void btnEStop_Click(object sender, EventArgs e)
        {
            //string itemname = stk.Write_Index[Stacker.WRITR_Index_OrderType];
            //if (!stk.WriteValuePoint(itemname, 3))
            //{
            //    MessageBox.Show(this, "发送急停命令失败");
            //}
            Frm_OdLst f = new Frm_OdLst();
            f.ShowDialog();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            string itemname = stk.Write_Index[Stacker.WRITR_Index_OrderType];
            var rst= MessageBox.Show(this, "是否需要删除当前任务!?", "警告", MessageBoxButtons.OKCancel);
            if (rst == DialogResult.OK)
            {
                if (!stk.WriteValuePoint(itemname, 2))
                {
                    MessageBox.Show(this, "发送删除命令失败");
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            taskID = GenerateId();
            var rst = MessageBox.Show(this, "确认当前堆垛机是否空闲并无后续任务!?", "警告", MessageBoxButtons.OKCancel);
            if (rst == DialogResult.OK)
            {
                if (!stk.SetTask(tB_SourcePlace.Text, tB_ToPlace.Text, taskID))
                    MessageBox.Show(this, "下发指令失败!");
            }
        }
        /// <summary>
        /// 获取唯一任务号
        /// </summary>
        /// <returns></returns>
        private int GenerateId()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToUInt16(buffer, 0);
        }

        private void ChangeButtonEnable(bool b_Control)
        {
            //btnStop.Enabled = b_Control;
            //btnCancle.Enabled = b_Control;
            //btnEStop.Enabled = b_Control;
            btnSend.Enabled = b_Control;
            btn_AlarmReset.Visible = !b_Control;
        }

        private void timerHandShake_Tick(object sender, EventArgs e)
        {
            try
            {
                var device = srv.DU_Device_GetOneByDeviceId(srm.DEVICEID);
                if (device.WORKINGSTATUS == "堆垛机:正常")
                {
                    stk.currentState = "正常";
                    lbCurrentState.BackColor = Color.White;
                    lbCurrentState.ForeColor = Color.Lime;
                    lbCurrentState.Text = "堆垛机:正常";
                    ChangeButtonEnable(true);
                }
                else if (device.WORKINGSTATUS == "WCS通讯未启动")
                {
                    stk.currentState = "断线";
                    lbCurrentState.BackColor = Color.Red;
                    lbCurrentState.ForeColor = Color.White;
                    lbCurrentState.Text = "WCS通讯未启动";
                    ChangeButtonEnable(false);
                }
                else if (device.WORKINGSTATUS == "堆垛机:连线中断")
                {
                    stk.currentState = "断线";
                    lbCurrentState.BackColor = Color.Red;
                    lbCurrentState.ForeColor = Color.White;
                    lbCurrentState.Text = "堆垛机:连线中断";
                    ChangeButtonEnable(false);
                }
                else if (device.WORKINGSTATUS == "堆垛机:脱机")
                {
                    stk.currentState = "脱机";
                    lbCurrentState.BackColor = Color.Red;
                    lbCurrentState.ForeColor = Color.White;
                    lbCurrentState.Text = "堆垛机:脱机";
                    ChangeButtonEnable(false);
                }
                else
                {
                    stk.currentState = "报警";
                    lbCurrentState.BackColor = Color.Red;
                    lbCurrentState.ForeColor = Color.White;
                    lbCurrentState.Text = "堆垛机:报警";
                    ChangeButtonEnable(false);
                }
            }
            catch (Exception)
            {
                stk.currentState = "未知";
                lbCurrentState.BackColor = Color.White;
                lbCurrentState.ForeColor = Color.Lime;
                lbCurrentState.Text = "堆垛机:未知";
                ChangeButtonEnable(true);
            }
            ////////////////////////////////////////           
        }

        

        private void btnQuery_Device_Click(object sender, EventArgs e)
        {
            var startTime = dtPickStart_Device.Value;
            var endTime = dtPickEnd_Device.Value;
            string device;

            device = cmBDevice.SelectedItem.ToString();

            if (device == "堆垛机")
                device = "SRM_1";
            else if (device == "输送机1")
                device = "SSJ1";
            else if (device == "输送机2")
                device = "SSJ2";
            else if (device == "输送机3")
                device = "SSJ3";
            else
                device = "SRM_1";
            try
            {
                var lst = srv.Device_Alert_GetAllByDate(startTime, endTime, device);
                dGV_Alert.DataSource = null;
                dGV_Alert.DataSource = lst.ToList();
            }
            catch (Exception)
            {
               
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                var outPutLst = dGV_Alert.DataSource as List<Web_Service.Device_Alert>;
                dt = CommonMethod.ToDataTable(outPutLst);
            }
            catch (Exception)
            {
                return;
            }
            DataTable table = new DataTable();
            DataColumn col1 = new DataColumn("设备号");
            DataColumn col2 = new DataColumn("报警号");
            DataColumn col3 = new DataColumn("报警描述");
            DataColumn col4 = new DataColumn("报警时间");

            table.Columns.Add(col1);
            table.Columns.Add(col3);
            table.Columns.Add(col2);
            table.Columns.Add(col4);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["设备号"] = dt.Rows[i]["DEVICEID"];
                dr["报警号"] = dt.Rows[i]["ALERTID"];
                dr["报警描述"] = dt.Rows[i]["ALERTNAME"];
                dr["报警时间"] = dt.Rows[i]["CREATETIME"];
                table.Rows.Add(dr);
            }
            CommonMethod.OutputExcel(table, "报警信息记录", "");
        }

        private void btnForceComplete_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show(this,"是否要强制完成当前任务?!","警告!",MessageBoxButtons.OKCancel);
            if (drs == DialogResult.OK)
            {               
               // OD_Task currentTask = srv.Od_Task_GetCurrentTaskByDeviceID("SRM_1");
                btnCancle_Click(null, null);//删除堆垛机任务
                //int f = -1;
                //try
                //{
                //    if (currentTask != null && (!string.IsNullOrEmpty(currentTask.TASKID)))
                //    { 
                //        f = 1;
                //        DealWithCurrentTask(currentTask);
                //    }
                //    else
                //    { 
                //        f = 2;
                //        var notFins=srv.Od_Task_GetNotFinishedTask_by_deviceID("SRM_1");
                //        if(notFins.Length>0)
                //        {
                //            if(!string.IsNullOrEmpty( notFins[0].TASKID))
                //            {
                //                srv.Od_Task_deleteOne(notFins[0].TASKID);
                //            }
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("错误码:"+f.ToString());
                //}
            }     
        }
        /// <summary>
        /// 处理当前任务
        /// </summary>
        /// <param name="currentTask"></param>
        /// <returns></returns>
        private bool DealWithCurrentTask(OD_Task currentTask)
        {
            currentTask.ISCURRENTTASK = "N";
            currentTask.HADFINISH = "Y";
            currentTask.ISLASTTASK = "Y";
            bool rtn = false;
            switch (currentTask.TASKTYPE)
            {
                case "SRM_Store_In":
                    rtn = DealFor_Srm_Store_In(currentTask);//入库执行后增加库存
                    break;
                case "SRM_Retrieve_Out":   
                    rtn = DealFor_Srm_Retrieve_Out(currentTask);//出库执行后清除库存
                    break;
                case "SRM_Inventory_Out":
                    break;
                case "SRM_Inventory_In":
                    break;
            }
            return rtn;
        }
        /// <summary>
        /// 处理入库任务
        /// </summary>
        /// <param name="currentTask"></param>
        /// <returns></returns>
        private bool DealFor_Srm_Store_In(OD_Task currentTask)
        {
            List<IV_place_vs_container> placeContnr = new List<IV_place_vs_container>();
            placeContnr = srv.Place_Vs_Container_GetRelationshipByContainer(currentTask.CONTAINERNO).ToList();
            if (placeContnr.Count > 0)
            {
                placeContnr[0].PLACEID = currentTask.TOPLACE;
                srv.Place_Vs_Container_UpdateOne(placeContnr[0]);
            }
            else
            {
                //插入新库位容器记录
                IV_place_vs_container ivp = new IV_place_vs_container();
                ivp.CONTAINERID = currentTask.CONTAINERNO;
                ivp.PC_ID = Guid.NewGuid().ToString();
                ivp.PLACEID = currentTask.TOPLACE;
                ivp.VOID = 0;
                ivp.WAREHOUSENO = currentTask.WAREHOUSENO;
                ivp.INSERTUSER = currentTask.CREATEUSER;
                ivp.UPDATEUSER = currentTask.UPDATEUSER;
                ivp.ISEMPTYCONTAINER = currentTask.ISEMPTYCONTAINER == "Y" ? 1 : 0;
                ivp.UPDATETIME = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ivp.INSERTTIME = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                srv.Place_Vs_Container_InsertOne(ivp);
            }
            bool a = srv.PL_PLACE_UpdateHadTaskDoing(currentTask.TOPLACE, 0);
            currentTask.TASKSTATUS = "In_Finished";
            srv.Od_Task_SetLastTaskVoidByDeviceID(currentTask.DODEVICEID);  // 废除上一次任务的有效性，当完成一个任务时，会先将以前的上一次任务（LastTask）作废，将刚刚完成的任务设置为最新上一次任务          
            bool b = srv.Od_Task_UpdateOne(currentTask);
            return a && b;
        }

        /// <summary>
        /// 处理出库任务
        /// </summary>
        /// <param name="currentTask"></param>
        /// <returns></returns>
        private bool DealFor_Srm_Retrieve_Out(OD_Task currentTask)
        {
            IV_place_vs_container placeContnr = new IV_place_vs_container();
            placeContnr = srv.Place_Vs_Container_GetRelationshipByContainer(currentTask.CONTAINERNO)[0];

            srv.Place_Vs_Container_DeleteOne(placeContnr.CONTAINERID);//清除库存          
            currentTask.TASKSTATUS = "Out_Finished";
            srv.Od_Task_SetLastTaskVoidByDeviceID(currentTask.DODEVICEID);  // 废除上一次任务的有效性，当完成一个任务时，会先将以前的上一次任务（LastTask）作废，将刚刚完成的任务设置为最新上一次任务

            bool b = srv.Od_Task_UpdateOne(currentTask);
            return b;

        }

        private void btn_AlarmReset_Click(object sender, EventArgs e)
        {
            btn_AlarmReset.Enabled = false;
            var itemName = stk.Write_Index[Stacker.WRITE_Index_Srm_Reset];
            srv.OPC_WritePoint(itemName, 1);
            wait(1000);
            btn_AlarmReset.Enabled = true;
        }

        private void btn_TaskCancel_Click(object sender, EventArgs e)
        {
            OD_Task currentTask = srv.Od_Task_GetCurrentTaskByDeviceID("SRM_1");
            if (currentTask.SOURCEPLACE == "10301" || currentTask.SOURCEPLACE == "11901")
            {
                //入库任务无需撤回
                return;
            }

            string placeid = currentTask.SOURCEPLACE;
            string isEmptyContainer=currentTask.ISEMPTYCONTAINER;
            IV_place_vs_container pvc = new IV_place_vs_container();
            pvc.CONTAINERID = currentTask.CONTAINERNO;
            pvc.INSERTTIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            pvc.INSERTUSER = "";
            pvc.ISEMPTYCONTAINER = isEmptyContainer=="Y"?1:0;
            pvc.ISEMPTYPLACE = 0;
            pvc.PC_ID = Guid.NewGuid().ToString();
            pvc.PLACEID = placeid;
            pvc.VOID = 0;
            pvc.UPDATETIME = pvc.INSERTTIME;
            pvc.UPDATEUSER = "";
            pvc.WAREHOUSENO = "吉利沃尔沃立体库";
            if (!srv.Place_Vs_Container_InsertOne(pvc))
            {
                MessageBox.Show(this, "撤回失败!");
                return;
            }
            btnCancle_Click(null,null);//删除堆垛机指令
        }

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            
            f.StartPosition = FormStartPosition.CenterParent;
           
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                pnlFunction.Visible = true;
                btnForceComplete.Visible = true;
            }
            else
            {
                pnlFunction.Visible = false;
                btnForceComplete.Visible = false;
            } 
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string itemname = stk.Write_Index[Stacker.WRITR_Index_OrderType];
            if (!stk.WriteValuePoint(itemname, 3))
            {
                MessageBox.Show(this, "发送急停命令失败");
            }
        }
    }
}
