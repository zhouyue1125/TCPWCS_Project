using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WCS_V3.OpcService;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using HPSocketCS;

namespace WCS_V3
{
    public partial class FormMain : Form
    {


        private AppState appState = AppState.Stoped;

        private delegate void ConnectUpdateUiDelegate();
        private delegate void SetAppStateDelegate(AppState state);
        private delegate void ShowMsg(string msg);
        private ShowMsg AddMsgDelegate;
        TcpClient client = new TcpClient();

        Thread rd;


        Thread threadReadLable,
            threadSRMImg,
            threadGoodsImg,
            threadDataRead,
            threadTaskDealer,
            threadToLED;
        ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient();
        Point goodPoint = new Point();
        DateTime t_alertStart, t_alertFinish;
        OpcService.DU_Device srm = new DU_Device();
        OpcService.DU_Device deviceST = new DU_Device();
        Stacker stk = new Stacker();
        List<IV_place_vs_container> IV_P_V_C = null;
        List<IV_container_vs_item> IV_C_V_I = null;
        Thread td_P_V_C, td_C_V_I;
        int alertSequence = 0;
        /// <summary>
        /// 报警号:GUID
        /// </summary>
        string AlarmId = "";

        /// <summary>
        /// 握手号:不重复值
        /// </summary>
        object handShakeValue = "llk";
        /// <summary>
        /// 断线次数
        /// </summary>
        private static int disconnectCount = 0;

        int taskID;

        public static bool isVirsualMode = true;//是否虚拟模式

        //LED参数设置     
        CLEDSender LEDSender2 = new CLEDSender();
        private const int WM_LED_NOTIFY = 1025;

        private void GetDeviceParam(ref TDeviceParam param)
        {
            param.devType = LEDSender2.DEVICE_TYPE_UDP;
            param.locPort = 8881;
            param.rmtHost = "192.168.0.99";
            param.rmtPort = 6666;
            param.dstAddr = 1;

        }

        public FormMain()
        {
            InitializeComponent();
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                srm = srv.DU_Device_GetOneByDeviceId("SRM_1");
            }

            CheckForIllegalCrossThreadCalls = false;
            goodPoint.Y = picSrm.Location.Y + 5;
        }
        //LED连接设置
        private void GetDeviceParamWithoutStruct(Int32 param_index, Int32 notifymode, Int32 wmhandle, Int32 wmmessage)
        {
            LEDSender2.Do_LED_UDP_SenderParam(param_index, 8881, "192.168.0.99", 6666, 1, notifymode, wmhandle, wmmessage);
        }


        private void FormMain_Load(object sender, EventArgs e)
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

            try
            {
                // 加个委托显示msg,因为on系列都是在工作线程中调用的,ui不允许直接操作
                AddMsgDelegate = new ShowMsg(AddMsg);
                // 设置client事件
                client.OnPrepareConnect += new TcpClientEvent.OnPrepareConnectEventHandler(OnPrepareConnect);
                client.OnConnect += new TcpClientEvent.OnConnectEventHandler(OnConnect);
                client.OnSend += new TcpClientEvent.OnSendEventHandler(OnSend);
                client.OnReceive += new TcpClientEvent.OnReceiveEventHandler(OnReceive);
                client.OnClose += new TcpClientEvent.OnCloseEventHandler(OnClose);
                SetAppState(AppState.Stoped);
            }
            catch (Exception ex)
            {
                SetAppState(AppState.Error);
                AddMsg(ex.Message);
            }
            Connect("192.168.8.121");
            threadReadLable = new Thread(SRMRead_Lable);
            threadReadLable.IsBackground = true;
            threadReadLable.Start();
            #region 图形化线程
            threadSRMImg = new Thread(SRM_Img);
            threadSRMImg.IsBackground = true;
            threadSRMImg.Start();
            threadGoodsImg = new Thread(GoodS_Img);
            threadGoodsImg.IsBackground = true;
            threadGoodsImg.Start();
            #endregion
            threadTaskDealer = new Thread(TaskDealerFunc);//处理出入库任务
            threadTaskDealer.IsBackground = true;
            threadTaskDealer.Start();
            td_C_V_I = new Thread(getCacheForCVI);
            td_C_V_I.IsBackground = true;
            td_C_V_I.Start();
            td_P_V_C = new Thread(getCacheForPVC);
            td_P_V_C.IsBackground = true;
            td_P_V_C.Start();
            threadDataRead = new Thread(GetDeviceData);
            threadDataRead.IsBackground = true;
            threadDataRead.Start();
            System.Windows.Forms.Timer timerForbackUp = new System.Windows.Forms.Timer();
            timerForbackUp.Interval = 7200000;
            timerForbackUp.Tick += timerForbackUp_Tick;
            timerForbackUp.Enabled = true;

            dGV_Alert.AutoGenerateColumns = false;

            cmBDevice.SelectedIndex = 0;
            picPallet.Visible = false;

        }

        private void GetDeviceData(object obj)
        {
            LogisticEquipment le = new LogisticEquipment();
            while (true)
            {
                Stacker.DataRead();
                le.DataRead();
            }

        }

        private void timerForbackUp_Tick(object sender, EventArgs e)
        {
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                srv.CommonMethod_BackUpDB(@"D:\张家口数据库备份.bak");
            }
        }

        /// <summary>
        /// 获取P_V_C缓存
        /// </summary>
        /// <param name="obj"></param>
        private void getCacheForPVC(object obj)
        {
            while (true)
            {
                IV_P_V_C = srv.Place_Vs_Container_GetAll().ToList();
                Thread.Sleep(3000);
            }
        }

        /// <summary>
        /// 获取C_V_I缓存
        /// </summary>
        /// <param name="obj"></param>
        private void getCacheForCVI(object obj)
        {
            while (true)
            {
                IV_C_V_I = srv.Container_Vs_Items_GetAll().ToList();
                Thread.Sleep(3000);
            }
        }

        private void GoodS_Img(object obj)
        {
            int leftLimit = 1093591;   //左限   1093581
            int rightLimit = 821770;    //右限  1095928
            int centerPos = 823480;
            while (true)
            {
                if (!isVirsualMode)
                {
                    if (Stacker.workStatus == 6 && (Stacker.nForkPos <= rightLimit))
                    {
                        picPallet.Visible = false;
                    }
                    else if ((Stacker.workStatus == 3 || Stacker.workStatus == 4 || Stacker.workStatus == 5) && ((Stacker.nForkPos <= rightLimit)))
                    {
                        picPallet.Visible = true;
                    }
                    goodPoint.X = picSrm.Location.X + 36;
                    goodPoint.Y = (Stacker.nForkPos - centerPos) / 29 + 80;
                    picPallet.Location = goodPoint;
                    wait(50);
                }
                else
                {
                    if ((VirsualSrm.rWorkStatus.ToString() == "3" || VirsualSrm.rWorkStatus.ToString() == "4" || VirsualSrm.rWorkStatus.ToString() == "5") && ((int.Parse(VirsualSrm.rForkPos.ToString()) <= 24)))
                    {
                        picPallet.Visible = true;
                    }
                    else if (VirsualSrm.rWorkStatus.ToString() == "6" && ((int.Parse(VirsualSrm.rForkPos.ToString()) <= 24)))
                    {
                        picPallet.Visible = false;
                    }
                    goodPoint.X = picSrm.Location.X + 38;
                    goodPoint.Y = int.Parse(VirsualSrm.rForkPos.ToString());
                    picPallet.Location = goodPoint;
                    wait(50);
                    Thread.Sleep(5);
                }
            }
        }

        /// <summary>
        /// 后台读取的数据写入lable
        /// </summary>
        private void SRMRead_Lable()
        {
            string itemName;

            while (true)
            {

                if (!isVirsualMode)
                {
                    if (Stacker.workMode == 1 && Stacker.alarm == 0)
                    {
                        if (AlarmId != "")//如果之前有alarm
                        {
                            var lastAlert = srv.Device_Alert_GetAllByAlertId(AlarmId);
                            if (lastAlert != null && (lastAlert.FINISH_TIME == "" || lastAlert.FINISH_TIME == null))
                            {
                                lastAlert.FINISH_TIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                t_alertFinish = DateTime.Now;
                                var time_span = t_alertFinish - t_alertStart;
                                var duration = time_span.TotalSeconds.ToString("F");//持续时间
                                lastAlert.TIME_OF_DURATION = duration;
                                lastAlert.SYSTEMFLAG = "0";
                                if (srv.Device_Alert_UpdateOne(lastAlert))//更新alarm的完成时间
                                {
                                    AlarmId = "";
                                }
                            }
                        }

                        lbSRM_YLocation.Text = "当前行走位置:" + Stacker.nTravelPos.ToString();
                        lbSRM_ZLocation.Text = "当前升降位置:" + Stacker.nLiftPos.ToString();
                        lbSRM_XLocation.Text = "当前伸叉位置:" + Stacker.nForkPos.ToString();
                        lbWorkMode.Text = "工作状态:" + TanslateWorkMode(Stacker.workStatus);
                        lbAlert.Text = " 堆垛机故障:无";
                        lbAlert.BackColor = Color.White;
                        lbAlert.ForeColor = Color.Aqua;

                    }
                    else if (Stacker.alarm != 0)
                    {

                        itemName = stk.Read_Index[Stacker.READ_Index_ALARM_Code];
                        object alertCode = stk.ReadValuePoint(itemName);
                        try
                        {
                            string alarmDesc = TranslateAlertCode(int.Parse(alertCode.ToString()));
                            lbAlert.Text = "报警:" + alarmDesc;
                            lbAlert.BackColor = Color.Red;
                            lbAlert.ForeColor = Color.White;
                            RecorderAlarmToDB(alertCode, alarmDesc, "SRM_1");
                        }
                        catch (Exception)
                        {

                        }
                    }
                    List<string> stalarms = new List<string>();
                    lbSt1.Visible = false;

                    var st1 = srv.DU_Device_GetOneByDeviceId("ST1");
                    st1.WORKINGSTATUS = "升降机1：正常";

                    if (LogisticEquipment.IsBiasOutST1)
                    {
                        lbSt1.Visible = true;
                        stalarms.Add("升降机1超差");
                        st1.WORKINGSTATUS = "升降机1：超差";
                    }

                    if (LogisticEquipment.IsHighOutST1)
                    {
                        lbSt1.Visible = true;
                        stalarms.Add("升降机1超高");
                        st1.WORKINGSTATUS = "升降机1:超高";
                    }

                    if (LogisticEquipment.IsWidthOutST1)
                    {
                        lbSt1.Visible = true;
                        stalarms.Add("升降机1超宽");
                        st1.WORKINGSTATUS = "升降机1:超宽";
                    }

                    if (LogisticEquipment.MotorErrorST1)
                    {
                        lbSt1.Visible = true;
                        stalarms.Add("升降机1马达报警");
                        st1.WORKINGSTATUS = "升降机1:马达报警";
                    }

                    if (LogisticEquipment.ProtectErrorST1)
                    {
                        lbSt1.Visible = true;
                        stalarms.Add("升降机1安全报警");
                        st1.WORKINGSTATUS = "升降机1:安全报警";
                    }

                    if (LogisticEquipment.StopByControlBox)
                    {
                        lbSt1.Visible = true;
                        stalarms.Add("控制柜急停");
                        st1.WORKINGSTATUS = "升降机1:控制柜急停";
                    }
                    if (LogisticEquipment.DoorOpen)
                    {
                        lbSt1.Visible = true;
                        stalarms.Add("安全门打开");
                        st1.WORKINGSTATUS = "升降机1:安全门打开";
                    }
                    lbSTAlert.Text = "出入库设备故障：";
                    lbSTAlert.ForeColor = Color.Aqua;
                    lbSTAlert.BackColor = Color.White;
                    //srv.DU_Device_InsertOne(st1);
                    srv.DU_Device_UpdateOne(st1);

                    foreach (var p in stalarms)
                    {
                        lbSTAlert.ForeColor = Color.White;
                        lbSTAlert.BackColor = Color.Red;
                        lbSTAlert.Text += p;
                        lbSTAlert.Text += "，";
                    }
                }
                else
                {
                    //虚拟模式
                    if (VirsualSrm.rIsAlarm.ToString() == "0")
                    {
                        if (AlarmId != "")//如果之前有alarm
                        {
                            var lastAlert = srv.Device_Alert_GetAllByAlertId(AlarmId);
                            if (lastAlert != null && (lastAlert.FINISH_TIME == "" || lastAlert.FINISH_TIME == null))
                            {
                                lastAlert.FINISH_TIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                t_alertFinish = DateTime.Now;
                                var time_span = t_alertFinish - t_alertStart;
                                var duration = time_span.TotalSeconds.ToString("F");//持续时间
                                lastAlert.TIME_OF_DURATION = duration;
                                lastAlert.SYSTEMFLAG = "0";
                                if (srv.Device_Alert_UpdateOne(lastAlert))//更新alarm的完成时间
                                {
                                    AlarmId = "";
                                }
                            }
                        }
                        try
                        {
                            lbSRM_YLocation.Text = "当前行走位置:" + VirsualSrm.rTravelPos.ToString();
                            lbSRM_ZLocation.Text = "当前升降位置:" + VirsualSrm.rLiftPos.ToString();
                            lbSRM_XLocation.Text = "当前伸叉位置:" + VirsualSrm.rForkPos.ToString();

                            lbWorkMode.Text = "工作状态:" + TanslateWorkMode(int.Parse(VirsualSrm.rWorkStatus.ToString()));
                            lbAlert.Text = " 故障:无";
                            lbAlert.BackColor = Color.White;
                            lbAlert.ForeColor = Color.Aqua;
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        object alertCode = VirsualSrm.rAlarmCode;
                        try
                        {
                            string alarmDesc = TranslateAlertCode(int.Parse(alertCode.ToString()));
                            lbAlert.Text = "报警:" + alarmDesc;
                            lbAlert.BackColor = Color.Red;
                            lbAlert.ForeColor = Color.White;
                            RecorderAlarmToDB(alertCode, alarmDesc, "SRM_1");
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                wait(50);
                // Thread.Sleep(50);
            }
        }

        /// <summary>
        /// 记录报警信息到本地缓存
        /// </summary>
        /// <param name="alertCode"></param>
        /// <param name="alarmDesc"></param>
        /// <param name="DeviceID"></param>
        private void RecorderAlarmToDB(object alertCode, string alarmDesc, string DeviceID)
        {
            if (!isVirsualMode)
            {
                if (alertSequence != int.Parse(Stacker.alarm.ToString()) && Stacker.alarm.ToString() != "0")
                {
                    OpcService.Device_Alert alertOne = new OpcService.Device_Alert();
                    AlarmId = Guid.NewGuid().ToString();
                    alertOne.ALERTID = alertCode.ToString();
                    alertOne.ALERTNAME = alarmDesc;
                    alertOne.CREATETIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    t_alertStart = DateTime.Now;
                    alertOne.FINISH_TIME = "";
                    alertOne.DEVICEID = DeviceID;
                    alertOne.ID = AlarmId;
                    alertOne.SYSTEMFLAG = "0";
                    srv.Device_Alert_InsertOne(alertOne);
                    alertSequence = int.Parse(Stacker.alarm.ToString());
                }
            }
            else
            {

                if (alertSequence != int.Parse(VirsualSrm.rIsAlarm.ToString()) && VirsualSrm.rIsAlarm.ToString() != "0")
                {
                    OpcService.Device_Alert alertOne = new OpcService.Device_Alert();
                    AlarmId = Guid.NewGuid().ToString();
                    alertOne.ALERTID = alertCode.ToString();
                    alertOne.ALERTNAME = alarmDesc;
                    alertOne.CREATETIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    t_alertStart = DateTime.Now;
                    alertOne.FINISH_TIME = "";
                    alertOne.DEVICEID = DeviceID;
                    alertOne.ID = AlarmId;
                    alertOne.SYSTEMFLAG = "0";
                    srv.Device_Alert_InsertOne(alertOne);
                    alertSequence = int.Parse(VirsualSrm.rIsAlarm.ToString());
                }
            }

        }

        private string TranslateAlertCode(int alertCode)
        {
            string alarmCode = "";
            string alarmType = "";
            switch (alertCode)
            {
                case 1:
                    alarmCode = "行走极限开关动作";
                    alarmType = "1人为报警";
                    break;
                case 2:
                    alarmCode = "载货台上极限开关动作";
                    alarmType = "1人为报警";
                    break;
                case 3:
                    alarmCode = "载货台下极限开关动作";
                    alarmType = "1人为报警";
                    break;
                case 4:
                    alarmCode = "电气柜门急停开关被按下";
                    alarmType = "1人为报警";
                    break;
                case 5:
                    alarmCode = "外部急停按钮被按下";
                    alarmType = "1人为报警";
                    break;
                case 6:
                    alarmCode = "载货台超速保护装置动作";
                    alarmType = "1人为报警";
                    break;
                case 7:
                    alarmCode = "松绳开关1未正常工作";
                    alarmType = "1人为报警";
                    break;
                case 8:
                    alarmCode = "松绳开关2未正常工作";
                    alarmType = "1人为报警";
                    break;
                case 9:
                    alarmCode = "过载开关1未正常工作";
                    alarmType = "1人为报警";
                    break;
                case 10:
                    alarmCode = "过载开关2未正常工作";
                    alarmType = "1人为报警";
                    break;
                case 11:
                    alarmCode = "相序保护器异常";
                    alarmType = "1人为报警";
                    break;
                case 12:
                    alarmCode = "安全继电器异常";
                    alarmType = "1人为报警";
                    break;
                case 13:
                    alarmCode = "行走变频器故障";
                    alarmType = "0系统故障";
                    break;
                case 14:
                    alarmCode = "起升变频器故障";
                    alarmType = "0系统故障";
                    break;
                case 15:
                    alarmCode = "货叉变频器故障";
                    alarmType = "0系统故障";
                    break;
                case 16:
                    alarmCode = "行走马达保护器故障";
                    alarmType = "0系统故障";
                    break;
                case 17:
                    alarmCode = "起升马达保护器故障";
                    alarmType = "0系统故障";
                    break;
                case 18:
                    alarmCode = "货叉马达保护器故障";
                    alarmType = "0系统故障";
                    break;
                case 19:
                    alarmCode = "行走电机抱闸供电故障";
                    alarmType = "0系统故障";
                    break;
                case 20:
                    alarmCode = "起升电机抱闸供电故障";
                    alarmType = "0系统故障";
                    break;
                case 21:
                    alarmCode = "货叉电机抱闸供电故障";
                    alarmType = "0系统故障";
                    break;
                case 22:
                    alarmCode = "V2供电异常";
                    alarmType = "0系统故障";
                    break;
                case 23:
                    alarmCode = "风扇供电异常";
                    alarmType = "0系统故障";
                    break;
                case 24:
                    alarmCode = "V2输出异常";
                    alarmType = "0系统故障";
                    break;
                case 25:
                    alarmCode = "安全回路供电异常";
                    alarmType = "0系统故障";
                    break;
                case 26:
                    alarmCode = "柜内24V供电异常";
                    alarmType = "0系统故障";
                    break;
                case 27:
                    alarmCode = "载货台24V供电异常";
                    alarmType = "0系统故障";
                    break;
                case 28:
                    alarmCode = "行走电机运行超时";
                    alarmType = "0系统故障";
                    break;
                case 29:
                    alarmCode = "起升电机运行超时";
                    alarmType = "0系统故障";
                    break;
                case 30:
                    alarmCode = "货叉电机运行超时";
                    alarmType = "0系统故障";
                    break;
                case 31:
                    alarmCode = "输送机光栅报警";
                    alarmType = "0系统故障";
                    break;
                case 32:
                    alarmCode = "货叉扭矩检测异常";
                    alarmType = "0系统故障";
                    break;
                case 33:
                    alarmCode = "1#输送机人员非法闯入";
                    alarmType = "1人为报警";

                    break;
                case 34:
                    alarmCode = "2#输送机人员非法闯入";
                    break;
                case 35:
                    alarmCode = "3#输送机人员非法闯入";
                    break;
                case 101:
                    alarmCode = "行走激光丢失";
                    alarmType = "0系统故障";
                    break;
                case 102:
                    alarmCode = "起升激光丢失";
                    alarmType = "0系统故障";
                    break;
                case 103:
                    alarmCode = "货叉信号丢失";
                    alarmType = "0系统故障";
                    break;
                case 104:
                    alarmCode = "Profibus总线通讯故障";
                    alarmType = "0系统故障";
                    break;
                case 105:
                    alarmCode = "行走停准失败";
                    alarmType = "0系统故障";
                    break;
                case 106:
                    alarmCode = "起升停准失败";
                    alarmType = "0系统故障";
                    break;
                case 107:
                    alarmCode = "货叉停准失败";
                    alarmType = "0系统故障";
                    break;
                case 108:
                    alarmCode = "载货台货物左坍塌";
                    alarmType = "1人为报警";
                    break;
                case 109:
                    alarmCode = "载货台货物右坍塌";
                    alarmType = "1人为报警";
                    break;
                case 110:
                    alarmCode = "载货台货物左前超宽";
                    alarmType = "1人为报警";
                    break;
                case 111:
                    alarmCode = "载货台货物左后超差";
                    alarmType = "1人为报警";
                    break;
                case 112:
                    alarmCode = "载货台货物右前超差";
                    alarmType = "1人为报警";
                    break;
                case 113:
                    alarmCode = "载货台货物右后超差";
                    alarmType = "1人为报警";
                    break;
                case 114:
                    alarmCode = "载货台货物左超高";
                    alarmType = "1人为报警";
                    break;
                case 115:
                    alarmCode = "载货台货物右超高";
                    alarmType = "1人为报警";
                    break;
                case 116:
                    alarmCode = "货叉位置错误";
                    alarmType = "1人为报警";
                    break;
                case 117:
                    alarmCode = "货叉左侧极限";
                    alarmType = "1人为报警";
                    break;
                case 118:
                    alarmCode = "货叉右侧极限";
                    alarmType = "1人为报警";
                    break;
                case 119:
                    alarmCode = "上位机下达急停指令";
                    alarmType = "1人为报警";
                    break;
                case 120:
                    alarmCode = "取货后载货台无货";
                    alarmType = "1人为报警";
                    break;
                case 121:
                    alarmCode = "放货时目标货位有货";
                    alarmType = "1人为报警";
                    break;
                case 122:
                    alarmCode = "放货后载货台有货";
                    alarmType = "1人为报警";
                    break;
                case 123:
                    alarmCode = "载货台货物左超高2";
                    alarmType = "1人为报警";
                    break;
                case 124:
                    alarmCode = "载货台货物右超高2";
                    alarmType = "1人为报警";
                    break;
                case 125:
                    alarmCode = "载货台货物右超高3";
                    alarmType = "1人为报警";
                    break;
                case 126:
                    alarmCode = "载货台货物右超高3";
                    alarmType = "1人为报警";
                    break;
                case 201:
                    alarmCode = "放货或取货超时";
                    alarmType = "1人为报警";
                    break;
                case 202:
                    alarmCode = "输送机不允许取货";
                    alarmType = "1人为报警";
                    break;
                case 203:
                    alarmCode = "输送机不允许放货";
                    alarmType = "1人为报警";
                    break;
                case 301:
                    alarmCode = "自动模式下无任务，载货台有货";
                    alarmType = "1人为报警";
                    break;
                case 302:
                    alarmCode = "任务错误,任务地址错误";
                    alarmType = "1人为报警";
                    break;
                case 303:
                    alarmCode = "任务错误,没有卸货任务";
                    alarmType = "1人为报警";
                    break;
                case 304:
                    alarmCode = "任务错误,任务错误,载货台有货,有取货任务";
                    alarmType = "1人为报警";
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
                case 308:
                    alarmCode = "升降机未联机";
                    break;
                default:
                    alarmCode = "获取报警信息失败";
                    break;
            }
            return alarmCode + ":" + alarmType;
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
                    rtn = "取货定位";
                    break;
                case 2:
                    rtn = "请求取货";
                    break;
                case 3:
                    rtn = "取货中";
                    break;
                case 4:
                    rtn = "放货定位";
                    break;
                case 5:
                    rtn = "请求放货";
                    break;
                case 6:
                    rtn = "放货中";
                    break;
                default:
                    rtn = "未知";
                    break;
            }
            return rtn;
        }

        int locationX = 441;
        /// <summary>
        /// 实际升降机行走位置X转为WCS的SRM的位置
        /// </summary>
        /// <param name="staPos">实际升降机X坐标</param>
        /// <returns></returns>
        private int GetSrmLocationX(int currentColumn)
        {
            double perColDistance = 2780.0;
            double perColPic = 56.2;
            double firstCol = 43011.0;
            double lastCol = 1420.0;
            int posX = locationX;
            if (!isVirsualMode)
            {
                switch (currentColumn)
                {
                    case 0:
                        locationX = 85;
                        break;
                    case 1:
                        locationX = 140;
                        break;
                    case 2:
                        locationX = 193;
                        break;
                    case 3:
                        locationX = 251;
                        break;
                    case 4:
                        locationX = 305;
                        break;
                    case 5:
                        locationX = 364;
                        break;
                    case 6:
                        locationX = 420;
                        break;
                    case 7:
                        locationX = 480;
                        break;
                    case 8:
                        locationX = 533;
                        break;
                    case 9:
                        locationX = 590;
                        break;
                    case 10:
                        locationX = 645;
                        break;
                    case 11:
                        locationX = 704;
                        break;
                    case 12:
                        locationX = 760;
                        break;
                }


                return locationX;
            }
            else
            {
                if (currentColumn > lastCol && currentColumn < firstCol)
                {
                    double col = (firstCol - currentColumn) / perColDistance;
                    posX = Convert.ToInt32(col * perColPic + 48);
                    locationX = posX;
                }
                else if (currentColumn >= 45020 && currentColumn <= 46015)
                {
                    posX = -8;
                    locationX = posX;

                }
                else if (currentColumn <= 1420)
                {
                    posX = 891;
                    locationX = posX;
                }
                return posX;
            }
        }

        /// <summary>
        /// 用后台读取Y坐标数据控制堆垛机图像移动
        /// </summary>
        private void SRM_Img()
        {
            /*每一列宽 56.2
              0列堆垛机坐标x= -8
              8列 x=441
             16列 x=891
             */
            if (!isVirsualMode)
            {
                Point srmPoint = new Point();
                while (true)
                {
                    srmPoint.Y = picSrm.Location.Y;
                    srmPoint.X = GetSrmLocationX(Stacker.currentColumn);
                    picSrm.Location = srmPoint;
                    wait(50);
                }
            }
            else
            {
                while (true)
                {
                    Point srmPoint = new Point();
                    srmPoint.Y = picSrm.Location.Y;
                    srmPoint.X = Convert.ToInt32((VirsualSrm.rTravelPos.ToString()));
                    picSrm.Location = srmPoint;
                    wait(50);
                    Thread.Sleep(4);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult rst = MessageBox.Show(this, "请保持软件常开，非必要情况请勿关闭！", "警告！", MessageBoxButtons.YesNo);
            if (rst != DialogResult.Yes)
                return;

            srm.WORKINGSTATUS = "WCS通讯未启动";
            srv.DU_Device_UpdateOne(srm);
            //关闭LED连接
            // LEDSender2.Do_LED_Cleanup();
            if (threadTaskDealer != null && threadTaskDealer.IsAlive)
            {
                threadTaskDealer.Join(20);
                threadTaskDealer.Abort();
                threadTaskDealer = null;
            }
            if (threadReadLable != null && threadReadLable.IsAlive)
            {
                threadReadLable.Join(20);
                threadReadLable.Abort();
                threadReadLable = null;
            }
            if (threadSRMImg != null && threadSRMImg.IsAlive)
            {
                threadSRMImg.Join(20);
                threadSRMImg.Abort();
                threadSRMImg = null;
            }
            if (threadGoodsImg != null && threadGoodsImg.IsAlive)
            {
                threadGoodsImg.Join(20);
                threadGoodsImg.Abort();
                threadGoodsImg = null;
            }
            if (threadDataRead != null && threadDataRead.IsAlive)
            {
                threadDataRead.Join(20);
                threadDataRead.Abort();
                threadDataRead = null;
            }
            if (threadToLED != null && threadToLED.IsAlive)
            {
                threadToLED.Join(20);
                threadToLED.Abort();
                threadToLED = null;
            }
            Close();
        }

        private void btnCallBack_Click(object sender, EventArgs e)
        {
            if (Stacker.workStatus != 0)//堆垛机不空闲
            {
                MessageBox.Show(this, "堆垛机正在执行任务,请稍后再试!");
                return;
            }
            string itemname = stk.Write_Index[Stacker.WRITR_Index_OrderType];
            if (!stk.WriteValuePoint(itemname, 4))
            {
                MessageBox.Show(this, "发送召回命令失败");
            }
        }

        private void btnEStop_Click(object sender, EventArgs e)
        {
            if (!isVirsualMode)
            {
                string itemname = stk.Write_Index[Stacker.WRITR_Index_OrderType];
                if (!stk.WriteValuePoint(itemname, 3))
                {
                    MessageBox.Show(this, "发送急停命令失败");
                }
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

            string itemname = stk.Write_Index[Stacker.WRITR_Index_OrderType];
            if (!stk.WriteValuePoint(itemname, 2))
            {
                MessageBox.Show(this, "发送删除命令失败");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (Stacker.workStatus != 0)//堆垛机不空闲
            {
                MessageBox.Show(this, "堆垛机正在执行任务,请稍后再试!");
                return;
            }
            taskID = GenerateId();
            Stacker.workMode = 1;

            if (!stk.SetTask(tB_SourcePlace.Text, tB_ToPlace.Text, taskID))
                MessageBox.Show(this, "下发指令失败!");

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

        private void timerHandShake_Tick(object sender, EventArgs e)
        {

            if (!isVirsualMode)
            {
                try
                {
                    string itemName = stk.Read_Index[Stacker.READ_Index_HandShake];
                    object newStkHandShake = stk.ReadValuePoint(itemName);
                    Random rd = new Random(DateTime.Now.Millisecond);
                    int hkLift = rd.Next(1, 9999);//生成一个上位机发给升降机的心跳值
                    object newLiftHandShake = hkLift;
                    stk.WriteValuePoint(LogisticEquipment.Write_HandShake, newLiftHandShake);
                    //更新数据库中ST1的状态为正常

                    deviceST = srv.DU_Device_GetOneByDeviceId("ST1");
                    deviceST.WORKINGSTATUS = "正常";
                    srv.DU_Device_UpdateOne(deviceST);

                    if (newStkHandShake == null)
                    {
                        newStkHandShake = handShakeValue;
                    }
                    if (handShakeValue.ToString() != newStkHandShake.ToString())
                    {
                        handShakeValue = newStkHandShake;
                        disconnectCount = 0;
                        srm.ISONLINE = 1;
                        stk.WriteValuePoint(stk.Write_Index[0], handShakeValue);//写入堆垛机心跳

                        if (Stacker.alarm == 0 && Stacker.workMode == 1)
                        {

                            lbCurrentState.BackColor = Color.White;
                            lbCurrentState.ForeColor = Color.Lime;
                            lbCurrentState.Text = "堆垛机:正常";
                            srm.WORKINGSTATUS = lbCurrentState.Text;
                            srm.AISLE = Guid.NewGuid().ToString();
                            srv.DU_Device_UpdateOne(srm);
                            ChangeButtonEnable(true);
                        }
                        else if (Stacker.alarm != 0 && Stacker.workMode == 1)
                        {

                            lbCurrentState.BackColor = Color.Red;
                            lbCurrentState.ForeColor = Color.White;
                            lbCurrentState.Text = "堆垛机:报警";
                            srm.WORKINGSTATUS = "堆垛机:" + lbAlert.Text;
                            srv.DU_Device_UpdateOne(srm);
                            ChangeButtonEnable(false);
                        }
                        else if (Stacker.workMode != 1)
                        {
                            lbCurrentState.BackColor = Color.Red;
                            lbCurrentState.ForeColor = Color.White;
                            lbCurrentState.Text = "堆垛机:脱机";
                            srm.WORKINGSTATUS = "堆垛机:脱机";
                            srv.DU_Device_UpdateOne(srm);
                            ChangeButtonEnable(false);
                        }
                    }
                    else
                    {
                        disconnectCount++;
                        if (disconnectCount > 3)
                        {
                            lbCurrentState.BackColor = Color.Red;
                            lbCurrentState.ForeColor = Color.White;
                            lbCurrentState.Text = "堆垛机:连线中断";
                            srm.ISONLINE = 0;
                            srm.WORKINGSTATUS = lbCurrentState.Text;
                            srv.DU_Device_UpdateOne(srm);
                            ChangeButtonEnable(false);

                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                ///虚拟模式
                object newHandShake = VirsualSrm.rHandShake;
                if (handShakeValue != newHandShake)
                {
                    handShakeValue = newHandShake;
                    disconnectCount = 0;
                    VirsualSrm.isOnLine = true;
                    srm.ISONLINE = 1;

                    if (VirsualSrm.rIsAlarm.ToString() == "0" && VirsualSrm.rWorkMode.ToString() == "1")
                    {
                        lbCurrentState.BackColor = Color.White;
                        lbCurrentState.ForeColor = Color.Lime;
                        lbCurrentState.Text = "堆垛机:正常";
                        VirsualSrm.statusDescribe = lbCurrentState.Text;
                        srm.WORKINGSTATUS = lbCurrentState.Text;
                        srm.AISLE = Guid.NewGuid().ToString();
                        srm.ISONLINE = 1;
                        srm.SOCKETTYPE = "正常";
                        srv.DU_Device_UpdateOne(srm);
                        ChangeButtonEnable(true);
                    }
                    else if (VirsualSrm.rIsAlarm.ToString() != "0" && VirsualSrm.rWorkMode.ToString() == "1")
                    {
                        lbCurrentState.BackColor = Color.Red;
                        lbCurrentState.ForeColor = Color.White;
                        lbCurrentState.Text = "堆垛机:报警";
                        VirsualSrm.statusDescribe = lbCurrentState.Text;
                        srm.WORKINGSTATUS = "堆垛机:" + lbAlert.Text;
                        srm.SOCKETTYPE = "异常";
                        srv.DU_Device_UpdateOne(srm);
                        ChangeButtonEnable(false);
                    }
                    else if (VirsualSrm.rWorkMode.ToString() != "1")
                    {

                        lbCurrentState.BackColor = Color.Red;
                        lbCurrentState.ForeColor = Color.White;
                        lbCurrentState.Text = "堆垛机:脱机";
                        VirsualSrm.statusDescribe = lbCurrentState.Text;
                        srm.WORKINGSTATUS = "堆垛机:脱机";
                        srm.ISONLINE = 0;
                        srm.SOCKETTYPE = "脱机";
                        srv.DU_Device_UpdateOne(srm);
                        ChangeButtonEnable(false);
                    }
                }
                else
                {
                    disconnectCount++;
                    if (disconnectCount > 3)
                    {
                        lbCurrentState.BackColor = Color.Red;
                        lbCurrentState.ForeColor = Color.White;
                        lbCurrentState.Text = "堆垛机:连线中断";
                        VirsualSrm.isOnLine = false;
                        VirsualSrm.statusDescribe = lbCurrentState.Text;
                        srm.ISONLINE = 0;
                        srm.SOCKETTYPE = "断线";
                        srm.WORKINGSTATUS = lbCurrentState.Text;
                        srv.DU_Device_UpdateOne(srm);
                        ChangeButtonEnable(true);
                    }
                }
            }
        }

        private void ChangeButtonEnable(bool b_Control)
        {
            btnCallBack.Enabled = b_Control;
            // btnCancle.Enabled = b_Control;
            btnEStop.Enabled = b_Control;
            btnSend.Enabled = b_Control;
            btnReleaseAlert.Visible = !b_Control;
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
            var lst = srv.Device_Alert_GetAllByDate(startTime, endTime, device);
            dGV_Alert.DataSource = null;
            dGV_Alert.DataSource = lst.ToList();

        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                var outPutLst = dGV_Alert.DataSource as List<OpcService.Device_Alert>;
                dt = CommonMethod.ToDataTable(outPutLst);
            }
            catch (Exception)
            {

                return;
            }
            DataTable table = new DataTable();
            DataColumn col1 = new DataColumn("设备号");

            DataColumn col2 = new DataColumn("报警描述");
            DataColumn col3 = new DataColumn("报警时间");
            DataColumn col4 = new DataColumn("持续时间");
            table.Columns.Add(col1);
            table.Columns.Add(col3);
            table.Columns.Add(col2);
            table.Columns.Add(col4);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["设备号"] = dt.Rows[i]["DEVICEID"];
                dr["报警描述"] = dt.Rows[i]["ALERTNAME"];
                dr["报警时间"] = dt.Rows[i]["CREATETIME"];
                dr["持续时间"] = dt.Rows[i]["TIME_OF_DURATION"];
                table.Rows.Add(dr);
            }
            // CommonMethod.OutputExcel(table, "报警信息记录", "");
            ExcelHelper.DataSetToExcel(table);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

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
                ivp.ID = Guid.NewGuid().ToString();
                ivp.PLACEID = currentTask.TOPLACE;
                ivp.VOID = 0;
                ivp.WAREHOUSENO = currentTask.WAREHOUSENO;

                ivp.UPDATEUSER = currentTask.UPDATEUSER;
                ivp.ISEMPTYCONTAINER = currentTask.ISEMPTYCONTAINER;
                ivp.UPDATETIME = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                srv.Place_Vs_Container_InsertOne(ivp);
            }
            bool a = srv.PL_PLACE_UpdateHadTaskDoing(currentTask.TOPLACE, "Y");
            currentTask.TASKSTATUS = "In_Finished";
            srv.Od_Task_SetLastTaskVoidByDeviceID(currentTask.DODEVICEID);  // 废除上一次任务的有效性，当完成一个任务时，会先将以前的上一次任务（LastTask）作废，将刚刚完成的任务设置为最新上一次任务    

            bool b = srv.Od_Task_UpdateOne(currentTask);
            if (b)
            {
                ////关闭LED电源
                //TSenderParam param = new TSenderParam();
                //GetDeviceParam(ref param.devParam);
                //param.notifyMode = LEDSender2.NOTIFY_EVENT;
                //param.wmHandle = (UInt32)Handle;
                //LEDSender2.Do_LED_SetPower(ref param, 0);

            }
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
            srv.Container_Vs_Items_DeleteOneByContainerID(placeContnr.CONTAINERID);
            currentTask.TASKSTATUS = "Out_Finished";
            srv.Od_Task_SetLastTaskVoidByDeviceID(currentTask.DODEVICEID);  // 废除上一次任务的有效性，当完成一个任务时，会先将以前的上一次任务（LastTask）作废，将刚刚完成的任务设置为最新上一次任务

            bool b = srv.Od_Task_UpdateOne(currentTask);
            //var container = srv.IM_Container_GetOneByContainerId(currentTask.CONTAINERNO);
            //container.VOID = 1;
            //srv.IM_Container_UpdateOne(container);
            if (b)
            {
                ////关闭LED电源
                //TSenderParam param = new TSenderParam();
                //GetDeviceParam(ref param.devParam);
                //param.notifyMode = LEDSender2.NOTIFY_EVENT;
                //param.wmHandle = (UInt32)Handle;
                //LEDSender2.Do_LED_SetPower(ref param, 0);

            }
            return b;

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

        private void TaskDealerFunc(object obj)//处理堆垛机出入库任务发送
        {
            int TaskNo = -111;
            wait(5000);
            while (true)
            {
                if (!isVirsualMode)
                {

                    if (Stacker.workMode != 1 || Stacker.alarm > 0 || disconnectCount > 3)
                        continue;//断线或者报警或非自动时就不处理之后代码直接循环
                    Thread.Sleep(300);
                    if (Stacker.workStatus != 0)//堆垛机不空闲
                    {
                        Thread.Sleep(300);
                        continue;
                    }

                    Thread.Sleep(300);
                    try
                    {
                        string itemname = stk.Read_Index[Stacker.READ_Index_TaskId];
                        int currentTaskId = int.Parse(stk.ReadValuePoint(itemname).ToString());
                        if (currentTaskId == TaskNo)//依旧是当前任务号或者脱机状态
                        {
                            continue;
                        }
                    }
                    catch (Exception)
                    {

                    }
                    Thread.Sleep(1300);
                    if (Stacker.workMode != 1)
                        continue;//再次校验堆垛机工作模式
                    try
                    {
                        OD_Task dtCurrent = srv.Od_Task_GetCurrentTaskByDeviceID(srm.DEVICEID);//当前工作
                        if (!string.IsNullOrEmpty(dtCurrent.TASKID)) //如果有正在执行的任务
                        {
                            DealWithCurrentTask(dtCurrent);
                        }
                        Thread.Sleep(2000);
                        List<OD_Task> odts = srv.Od_Task_GetNotFinishedTask_by_deviceID(srm.DEVICEID).ToList();//获取未完成且未下发的任务
                        if (odts != null && odts.Count > 0)
                        {
                            var thisOrder = odts[0];
                            TaskNo = GenerateId();  //任务号
                            thisOrder.RELEASESTATUS = "Y";
                            thisOrder.ISCURRENTTASK = "Y";
                            if (thisOrder.TASKTYPE == "SRM_Store_In")
                            {
                                if (!LogisticEquipment.IsLoadST1)
                                {
                                    continue;
                                }
                                if (LogisticEquipment.INHightNo1)
                                {
                                    List<PL_Place> pflist = srv.PL_PLACE_GetFreeByHighNO(1).ToList();
                                    if (pflist.Count != 0)
                                    {
                                        thisOrder.TOPLACE = pflist[0].PLACEID;
                                    }
                                    else
                                    {
                                        pflist = srv.PL_PLACE_GetFreeByHighNO(2).ToList();
                                        if (pflist.Count != 0)
                                        {
                                            thisOrder.TOPLACE = pflist[0].PLACEID;
                                        }
                                        else
                                        {
                                            pflist = srv.PL_PLACE_GetFreeByHighNO(3).ToList();
                                            if (pflist.Count != 0)
                                            {
                                                thisOrder.TOPLACE = pflist[0].PLACEID;
                                            }
                                            else
                                            {
                                                stk.WriteValuePoint(LogisticEquipment.Write_HIGH3ERROR, true);
                                                continue;
                                            }
                                        }
                                    }
                                }
                                if (LogisticEquipment.INHightNo2)
                                {
                                    List<PL_Place> pflist = srv.PL_PLACE_GetFreeByHighNO(2).ToList();
                                    if (pflist.Count != 0)
                                    {
                                        thisOrder.TOPLACE = pflist[0].PLACEID;
                                    }
                                    else
                                    {
                                        pflist = srv.PL_PLACE_GetFreeByHighNO(3).ToList();
                                        if (pflist.Count != 0)
                                        {
                                            thisOrder.TOPLACE = pflist[0].PLACEID;
                                        }
                                        else
                                        {
                                            stk.WriteValuePoint(LogisticEquipment.Write_HIGH3ERROR, true);
                                            continue;
                                        }
                                    }
                                }
                                if (LogisticEquipment.INHightNo3)
                                {
                                    List<PL_Place> pflist = srv.PL_PLACE_GetFreeByHighNO(3).ToList();
                                    if (pflist.Count != 0)
                                    {
                                        thisOrder.TOPLACE = pflist[0].PLACEID;
                                    }
                                    else
                                    {
                                        stk.WriteValuePoint(LogisticEquipment.Write_HIGH3ERROR, true);
                                        continue;
                                    }
                                }
                            }


                            if (srv.Od_Task_UpdateOne(thisOrder))//发送出入库任务
                            {


                                stk.SetTask(thisOrder.SOURCEPLACE, thisOrder.TOPLACE, TaskNo);//下发到PLC  
                                if (thisOrder.TASKTYPE == "SRM_Store_In")
                                {
                                    //发送入库确认
                                    stk.SetInLicense(thisOrder.SOURCEPLACE);

                                }
                                else if (thisOrder.TASKTYPE == "SRM_Retrieve_Out")
                                {
                                    //发送出库确认
                                    stk.SetOutLicense(thisOrder.TOPLACE);
                                }
                                try
                                {
                                    sendToLed(thisOrder);
                                }
                                catch (Exception)
                                {

                                }//发送到LED
                                Thread.Sleep(3000);
                                //如果任务发送成功则更新任务为当前执行任务
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    string handshake = "0";
                    Random rdm = new Random();
                    handshake = rdm.Next(0,9).ToString();
                    //SendString(handshake.ToString());
                    Thread.Sleep(1);
                    ///虚拟模式
                    if (VirsualSrm.isOnLine == false || VirsualSrm.rIsAlarm.ToString() != "0" || VirsualSrm.rWorkMode.ToString() != "1")
                        SendString("{"+handshake+"00000000000000000}");
                        Thread.Sleep(300);
                        continue;//断线或者报警或非自动时就不处理之后代码直接循环
                    
                    if (VirsualSrm.rWorkStatus.ToString() != "0")//堆垛机不空闲
                    {
                        Thread.Sleep(300);
                        continue;
                    }
                    try
                    {

                        int currentTaskId = int.Parse(VirsualSrm.rTaskId.ToString());

                        if (currentTaskId == TaskNo)//依旧是当前任务号或者脱机状态
                        {
                            continue;
                        }

                    }
                    catch (Exception)
                    {

                    }
                    Thread.Sleep(300);
                    try
                    {
                        OD_Task dtCurrent = srv.Od_Task_GetCurrentTaskByDeviceID(srm.DEVICEID);//当前工作
                        if (!string.IsNullOrEmpty(dtCurrent.TASKID)) //如果有正在执行的任务
                        {

                            DealWithCurrentTask(dtCurrent);
                        }
                        Thread.Sleep(1000);
                        List<OD_Task> odts = srv.Od_Task_GetNotFinishedTask_by_deviceID(srm.DEVICEID).ToList();//获取未完成且未下发的任务
                        if (odts != null && odts.Count > 0)
                        {
                            var thisOrder = odts[0];
                            TaskNo = GenerateId();  //任务号
                            thisOrder.RELEASESTATUS = "Y";
                            thisOrder.ISCURRENTTASK = "Y";

                            Thread.Sleep(300);
                            //if (thisOrder.TASKTYPE == "SRM_Store_In")
                            //{
                            //    int a = VirsualSrm.INHightNo;
                            //    thisOrder.TOPLACE = "11201";
                            //    VirsualSrm.INHightNo = 0;
                            //}
                            if (srv.Od_Task_UpdateOne(thisOrder))//发送出入库任务
                            {
                                VirsualSrm.wOrderType = 1;
                                stk.SetTask(thisOrder.SOURCEPLACE, thisOrder.TOPLACE, TaskNo);//下发到PLC
                                //开启LED
                                LEDSender2.Do_LED_Startup();
                                TSenderParam param = new TSenderParam();
                                GetDeviceParam(ref param.devParam);
                                param.notifyMode = LEDSender2.NOTIFY_EVENT;
                                param.wmHandle = (UInt32)Handle;
                                LEDSender2.Do_LED_SetPower(ref param, 1);
                                //_thisOrder=thisOrder;
                                sendToLed(thisOrder);//LED显示工作状态
                                Thread.Sleep(500);
                                //如果任务发送成功则更新任务为当前执行任务
                            }

                        }

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

        }
        int sendTimes = 0;
        private void sendToLed(OD_Task thisOrder)
        {

            try
            {
                //开启LED
                LEDSender2.Do_LED_Startup();
                TSenderParam param = new TSenderParam();
                GetDeviceParam(ref param.devParam);
                param.notifyMode = LEDSender2.NOTIFY_EVENT;
                param.wmHandle = (UInt32)Handle;
                LEDSender2.Do_LED_SetPower(ref param, 1);

                string xc, crk, source, to, sku, desc;
                xc = "";
                crk = "";
                source = "";
                to = "";
                sku = "";
                desc = "";

                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {

                    xc = thisOrder.CONTAINERNO;
                    crk = thisOrder.TASKTYPEDESCRIPTION.Replace("堆垛机", "");
                    source = thisOrder.SOURCEPLACE;
                    to = thisOrder.TOPLACE; //获取小车号/出入库类型/起始位/目标位
                    var items = srv.Container_Vs_Items_GetItemsByContainerID(xc);
                    foreach (var p in items)
                    {
                        sku += p.ITEMSKU + ";";
                        desc += p.ITEMDESC + ";"; //根据小车号获取物料号/物料名称
                    }
                }


                Int32 param_index = 0;
                ushort K;

                GetDeviceParamWithoutStruct(param_index, (Int32)LEDSender2.NOTIFY_EVENT, (Int32)Handle, WM_LED_NOTIFY);
                K = (ushort)LEDSender2.Do_MakeRoot(LEDSender2.ROOT_PLAY, LEDSender2.COLOR_MODE_DOUBLE, LEDSender2.SURVIVE_ALWAYS);
                LEDSender2.Do_AddChapter(K, 30000, LEDSender2.WAIT_CHILD);
                LEDSender2.Do_AddRegion(K, 0, 0, 256, 160, 0);


                //添加表头
                LEDSender2.Do_AddLeaf(K, 10000000, LEDSender2.WAIT_CHILD);
                LEDSender2.Do_AddText(K, 0, 1, 256, 16, 1, 0, "端拾器立体库", "宋体", 12, 255, 0, 0, 1, 1, 5, 1, 5, 0, 0, 100000);
                LEDSender2.Do_AddText(K, 10, 26, 110, 16, 1, 0, "小车号:" + xc, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
                LEDSender2.Do_AddText(K, 125, 26, 131, 16, 1, 0, "任务类型:" + crk, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
                LEDSender2.Do_AddText(K, 10, 47, 256, 16, 1, 0, "物料号:" + sku, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
                LEDSender2.Do_AddText(K, 10, 69, 256, 16, 1, 0, "物料名称:" + desc, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
                LEDSender2.Do_AddText(K, 10, 92, 110, 16, 1, 0, "起始位:" + source, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
                LEDSender2.Do_AddText(K, 125, 92, 131, 16, 1, 0, "目标位:" + to, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
                LEDSender2.Do_AddText(K, 10, 116, 256, 16, 1, 0, "作业时间:" + DateTime.Now, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
                LEDSender2.Do_AddText(K, 0, 140, 256, 16, 1, 0, "技术支持:伟本智能机电(上海)股份有限公司", "宋体", 10, 255, 0, 0, 1, 1, 5, 1, 5, 0, 0, 100000);

                int t = LEDSender2.Do_LED_SendToScreen2(param_index, K);
                if (t < 0)
                {
                    sendTimes++;
                    if (sendTimes < 10)
                    {
                        wait(1000);
                        sendToLed(thisOrder);
                    }
                }
                sendTimes = 0;

            }

            catch (Exception)
            {

            }
        }

        private void lbInAlert_Click(object sender, EventArgs e)
        {

        }

        private void 虚拟堆垛机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FakeSrm f = new FakeSrm();
            f.Show();
        }

        private void wMS仓储管理系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"ASRS_Volvo.exe");
        }

        private void btnReleaseAlert_Click(object sender, EventArgs e)
        {
            Stacker stk = new Stacker();
            stk.WriteValuePoint(stk.Write_Index[Stacker.WRITE_Index_Srm_Reset], 1);
        }


        //上位机将堆垛机改成自动模式
        private void btnOnline_Click(object sender, EventArgs e)
        {
            Stacker stk = new Stacker();
            stk.WriteValuePoint(stk.Write_Index[Stacker.WRITE_Index_Srm_Online], 1);
        }


        private void SetAppState(AppState state)
        {
            appState = state;
        }

        private HandleResult OnClose(TcpClient sender, SocketOperation enOperation, int errorCode)
        {
            if (errorCode == 0)
                // 连接关闭了
                AddMsg(string.Format(" > [{0},已关闭]", sender.ConnectionId));
            else
                // 出错了
                AddMsg(string.Format(" > [{0},已关闭] -> OP:{1},CODE:{2}", sender.ConnectionId, enOperation, errorCode));

            // 通知界面,只处理了连接错误,也没进行是不是连接错误的判断,所以有错误就会设置界面
            // 生产环境请自己控制
            this.Invoke(new SetAppStateDelegate(SetAppState), AppState.Stoped);

            return HandleResult.Ok;
        }

        private HandleResult OnReceive(TcpClient sender, byte[] bytes)
        {
            AddMsg(string.Format(" > [{0},收到信息] -> ({1} bytes)", sender.ConnectionId, bytes.Length));
            this.Invoke(new Action(() =>
            {
                if (Stacker.alarm == 0 && Stacker.workMode == 1)
                {

                    lbCurrentState.BackColor = Color.White;
                    lbCurrentState.ForeColor = Color.Lime;
                    lbCurrentState.Text = "堆垛机:正常";
                    srm.WORKINGSTATUS = lbCurrentState.Text;
                    srm.AISLE = Guid.NewGuid().ToString();
                    srv.DU_Device_UpdateOne(srm);
                    ChangeButtonEnable(true);
                }
                lbReceive.Text = Encoding.Default.GetString(bytes);
            }));
            return HandleResult.Ok;
        }

        private HandleResult OnSend(TcpClient sender, byte[] bytes)
        {
            // 客户端发数据了
            AddMsg(string.Format(" > [{0},已连接] -> ({1} bytes)", sender.ConnectionId, bytes.Length));

            return HandleResult.Ok;
        }

        private HandleResult OnConnect(TcpClient sender)
        {
            // 已连接 到达一次
            // 如果是异步联接,更新界面状态

            AddMsg(string.Format(" > [{0},已连接]", sender.ConnectionId));

            return HandleResult.Ok;
        }


        private HandleResult OnPrepareConnect(TcpClient sender, IntPtr socket)
        {
            return HandleResult.Ok;
        }

        private void AddMsg(string msg)
        {
            //if (this.tBMessage.InvokeRequired)
            //{
            //    // 很帅的调自己
            //    this.tBMessage.Invoke(AddMsgDelegate, msg);
            //}
            //else
            //{
            //    if (this.tBMessage.Text.Length > 1000)
            //    {
            //        this.tBMessage.Text = "超出最大接收范围！";
            //    }
            //    this.tBMessage.Text = msg;

            //}
        }

        private void Connect(string ipAddress)
        {
            try
            {
                String ip = ipAddress;
                ushort port = ushort.Parse("10086");//端口号

                // 写在这个位置是上面可能会异常
                SetAppState(AppState.Starting);

                AddMsg(string.Format("客户端开启中... -> ({0}:{1})", ip, port));

                if (client.Connect(ip, port, false))
                {

                    SetAppState(AppState.Started);

                    AddMsg(string.Format("客户端开启 OK -> ({0}:{1})", ip, port));
                }
                else
                {
                    SetAppState(AppState.Stoped);
                    throw new Exception(string.Format("$Client Start Error -> {0}({1})", client.ErrorMessage, client.ErrorCode));
                }
            }
            catch (Exception ex)
            {
                AddMsg(ex.Message);
            }
        }

        private void StopConnect()
        {
            // 停止服务
            AddMsg("与服务器断开连接");
            if (client.Stop())
            {
                SetAppState(AppState.Stoped);
            }
            else
            {
                AddMsg(string.Format("断开时出错 -> {0}({1})", client.ErrorMessage, client.ErrorCode));
            }
        }

        private void SendString(string msg)
        {
            try
            {
                string send = msg;
                if (send.Length == 0)
                {
                    return;
                }

                byte[] bytes = Encoding.Default.GetBytes(send);
                IntPtr connId = client.ConnectionId;

                // 发送
                if (client.Send(bytes, bytes.Length))
                {
                    AddMsg(string.Format("$ ({0}) 发送 OK --> {1}", connId, send));
                }
                else
                {
                    AddMsg(string.Format("$ ({0}) 发送失败 --> {1} ({2})", connId, send, bytes.Length));
                }

            }
            catch (Exception ex)
            {
                AddMsg(string.Format("$ 发送失败 -->  出错信息： ({0})", ex.Message));
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Connect(tbServer.Text.Trim());
        }

        private void sendBw(object sender, EventArgs e)
        {
            SendString("1111111");
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            //if (btnCycle.Text.Contains("循环"))
            //{
            //    if (rd == null || rd.IsAlive == false)
            //    {
            //        rd = null;
            //        rd = new Thread(cycleSend);
            //        rd.IsBackground = true;
            //        rd.Start();
            //        btnCycle.Text = "终止发送";
            //    }
            //}
            //else
            //{
            //    if (rd != null)
            //    {
            //        rd.Join(50);
            //        rd.Abort();
            //        rd = null;
            //        btnCycle.Text = "循环发送";
            //    }
            //}

        }

        private void cycleSend(object obj)
        {
            int i = 1;
            while (true)
            {
                Random rdm = new Random(i);
                i = rdm.Next();
                SendString(i.ToString());
                Thread.Sleep(1);
            }

        }

    }
}
