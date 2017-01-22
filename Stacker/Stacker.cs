using Stacker.OpcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacker
{
    public class Stacker
    {
        public Stacker()
        {
            #region 初始化读取地址列表
            Read_Index = new List<string>();
            Read_Index.Add(READ_HandShake);//0
            Read_Index.Add(READ_Task_Finish);
            Read_Index.Add(READ_WorkMode);
            Read_Index.Add(READ_WorkStatus);
            Read_Index.Add(READ_ALARM);
            Read_Index.Add(READ_ALARM_Code);
            Read_Index.Add(READ_TaskId);
            Read_Index.Add(READ_TravelPos);
            Read_Index.Add(READ_LiftPos);
            Read_Index.Add(READ_ForkPos);
            Read_Index.Add(READ_IsGetFinish);
            Read_Index.Add(READ_IsPutFinish);
            Read_Index.Add(READ_IsLoaded);
            Read_Index.Add(READ_IsForkZero);//13
            Read_Index.Add(READ_CurrentLayer);
            Read_Index.Add(READ_CurrentColumn);

            //16-63 虚拟堆垛机不需要
            Read_Index.Add(Read_SSJ_1_WorkStatus);//16
            Read_Index.Add(Read_SSJ_1_ContainerDetector);
            Read_Index.Add(Read_SSJ_1_CycleDirect);
            Read_Index.Add(Read_SSJ_1_Alarm);
            Read_Index.Add(Read_SSJ_1_Alarm_Code);
            Read_Index.Add(Read_BarCodeReader1_1);
            Read_Index.Add(Read_BarCodeReader1_2);
            Read_Index.Add(Read_BarCodeReader1_3);
            Read_Index.Add(Read_BarCodeReader1_4);
            Read_Index.Add(Read_BarCodeReader1_5);
            Read_Index.Add(Read_BarCodeReader1_6);
            Read_Index.Add(Read_BarCodeReader1_7);
            Read_Index.Add(Read_BarCodeReader1_8);
            Read_Index.Add(Read_BarCodeReader1_9);
            Read_Index.Add(Read_BarCodeReader1_10);
            Read_Index.Add(Read_SSJ_1_IsEmpty);//31

            Read_Index.Add(Read_SSJ_2_WorkStatus);//32
            Read_Index.Add(Read_SSJ_2_ContainerDetector);
            Read_Index.Add(Read_SSJ_2_CycleDirect);
            Read_Index.Add(Read_SSJ_2_Alarm);
            Read_Index.Add(Read_SSJ_2_Alarm_Code);
            Read_Index.Add(Read_BarCodeReader2_1);
            Read_Index.Add(Read_BarCodeReader2_2);
            Read_Index.Add(Read_BarCodeReader2_3);
            Read_Index.Add(Read_BarCodeReader2_4);
            Read_Index.Add(Read_BarCodeReader2_5);
            Read_Index.Add(Read_BarCodeReader2_6);
            Read_Index.Add(Read_BarCodeReader2_7);
            Read_Index.Add(Read_BarCodeReader2_8);
            Read_Index.Add(Read_BarCodeReader2_9);
            Read_Index.Add(Read_BarCodeReader2_10);
            Read_Index.Add(Read_SSJ_2_IsEmpty);//47

            Read_Index.Add(Read_SSJ_3_WorkStatus);//48
            Read_Index.Add(Read_SSJ_3_ContainerDetector);
            Read_Index.Add(Read_SSJ_3_CycleDirect);
            Read_Index.Add(Read_SSJ_3_Alarm);
            Read_Index.Add(Read_SSJ_3_Alarm_Code);
            Read_Index.Add(Read_BarCodeReader3_1);
            Read_Index.Add(Read_BarCodeReader3_2);
            Read_Index.Add(Read_BarCodeReader3_3);
            Read_Index.Add(Read_BarCodeReader3_4);
            Read_Index.Add(Read_BarCodeReader3_5);
            Read_Index.Add(Read_BarCodeReader3_6);
            Read_Index.Add(Read_BarCodeReader3_7);
            Read_Index.Add(Read_BarCodeReader3_8);
            Read_Index.Add(Read_BarCodeReader3_9);
            Read_Index.Add(Read_BarCodeReader3_10);
            Read_Index.Add(Read_SSJ_3_IsEmpty);//63
            #endregion

            #region 初始化写入地址列表
            Write_Index = new List<string>();
            Write_Index.Add(WRITE_HandShake);//0
            Write_Index.Add(WRITE_SourcePai);
            Write_Index.Add(WRITE_SourceCol);
            Write_Index.Add(WRITE_SourceLayer);
            Write_Index.Add(WRITE_DestinationPai);
            Write_Index.Add(WRITE_DestinationCol);
            Write_Index.Add(WRITE_DestinationLayer);
            Write_Index.Add(WRITE_NewTask);
            Write_Index.Add(WRITE_TaskID);//8

            ////以下四条虚拟机使用
            //Write_Index.Add(WRITE_SSJ);
            //Write_Index.Add(WRITE_Cancel_Task);
            //Write_Index.Add(WRITE_Call_Back);
            //Write_Index.Add(WRITE_EStop);

            Write_Index.Add(WRITE_SSJ_1_Allow);//9
            Write_Index.Add(WRITE_SSJ_2_Allow);//
            Write_Index.Add(WRITE_SSJ_3_Allow);//
            Write_Index.Add(WRITE_OrderType);//12
            Write_Index.Add(WRITE_SSJ1_DeleteBarcode);//13
            Write_Index.Add(WRITE_SSJ3_DeleteBarcode);//
            Write_Index.Add(WRITE_SSJ1_BarcodeError);//
            Write_Index.Add(WRITE_SSJ3_BarcodeError);//16
            Write_Index.Add(WRITE_SRM_Reset);//17

            #endregion
        }

        #region 读写地址定义(虚拟堆垛机)
        //private const string LOCALSERVER = "S7:[@LOCALSERVER]";
        //private const string StackerRead = "DB1,";
        //private const string StackerWrite = "DB1,";

        //private string READ_HandShake = LOCALSERVER + StackerRead + "W999";//读取握手信号
        //private string READ_Task_Finish = LOCALSERVER + StackerRead + "X1.2";//DB541.DBX1.2
        //private string READ_WorkMode = LOCALSERVER + StackerRead + "X0.7";///DB541.DBX0.7
        //private string READ_WorkStatus = LOCALSERVER + StackerRead + "W8";//DB541.DBW8
        //private string READ_ALARM = LOCALSERVER + StackerRead + "W90";//DB541.DBX1.0
        //private string READ_ALARM_Code = LOCALSERVER + StackerRead + "W6";//DB541.DBW6
        //private string READ_TaskId = LOCALSERVER + StackerRead + "W20";//DB541.DBW20
        //private string READ_TravelPos = LOCALSERVER + StackerRead + "D10";//DB541.DBD10
        //private string READ_LiftPos = LOCALSERVER + StackerRead + "D14";//DB541.DBD14
        //private string READ_ForkPos = LOCALSERVER + StackerRead + "INT18";//DB541.DBD14
        //private string READ_IsGetFinish = LOCALSERVER + StackerRead + "X0.3";//DB541.DBX0.3
        //private string READ_IsPutFinish = LOCALSERVER + StackerRead + "X0.4";//DB541.DBX0.4
        //private string READ_IsLoaded = LOCALSERVER + StackerRead + "X1.3";//DB541.DBX1.3
        //private string READ_IsForkZero = LOCALSERVER + StackerRead + "X1.4";//DB541.DBX1.4

        //private string WRITE_HandShake = LOCALSERVER + StackerWrite + "W30";//写入握手信号
        //private string WRITE_SourcePai = LOCALSERVER + StackerWrite + "W42";//DB540.DBW12
        //private string WRITE_SourceCol = LOCALSERVER + StackerWrite + "W38";//DB540.DBW8
        //private string WRITE_SourceLayer = LOCALSERVER + StackerWrite + "W40";//DB540.DBW10
        //private string WRITE_DestinationPai = LOCALSERVER + StackerWrite + "W48";//DB540.DBW18
        //private string WRITE_DestinationCol = LOCALSERVER + StackerWrite + "W44";//DB540.DBW14
        //private string WRITE_DestinationLayer = LOCALSERVER + StackerWrite + "W46";//DB540.DBW16
        //private string WRITE_NewTask = LOCALSERVER + StackerWrite + "W52";//DB540.DBW22
        //private string WRITE_TaskID = LOCALSERVER + StackerWrite + "W50";//DB540.DBW20
        //private string WRITE_SSJ = LOCALSERVER + StackerWrite + "W54";//DB540.DBW24
        //private string WRITE_Cancel_Task = LOCALSERVER + StackerWrite + "W34";//DB540.DBW4
        //private string WRITE_Call_Back = LOCALSERVER + StackerWrite + "W32";//DB540.DBW2
        //private string WRITE_EStop = LOCALSERVER + StackerWrite + "W36";//DB540.DBW2 
        #endregion

        #region 读写地址定义(ROBO堆垛机)
        //private const string LOCALSERVER = "S7:[@LOCALSERVER]";
        private const string LOCALSERVER = "S7:[S7 connection_1]";
        private const string StackerRead = "DB541,";
        private const string StackerWrite = "DB540,";

        private string READ_HandShake = LOCALSERVER + StackerRead + "W30";//读取握手信号
        private string READ_Task_Finish = LOCALSERVER + StackerRead + "B8";//任务完成信号 0 未完成 1 完成
        private string READ_WorkMode = LOCALSERVER + StackerRead + "D2";///工作模式 0：脱机；1：自动；2：半自动；3：手动；4：维修
        private string READ_WorkStatus = LOCALSERVER + StackerRead + "B11";//0：空闲 1：定位 2：取货 3：放货
        private string READ_ALARM = LOCALSERVER + StackerRead + "W32";//为0:无故障;不为0:从1开始，每次递增，到达32766时再从1开始
        private string READ_ALARM_Code = LOCALSERVER + StackerRead + "W34";//DB541.DBW30
        private string READ_TaskId = LOCALSERVER + StackerRead + "D26";//当前任务号
        private string READ_TravelPos = LOCALSERVER + StackerRead + "D14";//当前水平坐标
        private string READ_LiftPos = LOCALSERVER + StackerRead + "D18";//当前起升坐标
        private string READ_ForkPos = LOCALSERVER + StackerRead + "D22";//当前伸叉坐标
        private string READ_IsGetFinish = LOCALSERVER + StackerRead + "B6";//是否取货完成 0未完成 1 完成
        private string READ_IsPutFinish = LOCALSERVER + StackerRead + "B7";//是否放货完成 0未完成 1 完成
        private string READ_IsLoaded = LOCALSERVER + StackerRead + "B9";//是否当前有货    0 无货 1 有货
        private string READ_IsForkZero = LOCALSERVER + StackerRead + "B10";//货叉是否原位  0 不在 1 在
        private string READ_CurrentLayer = LOCALSERVER + StackerRead + "B13";//当前层
        private string READ_CurrentColumn = LOCALSERVER + StackerRead + "B12";//当前列
        #region 1#输送机
        private string Read_SSJ_1_WorkStatus = LOCALSERVER + StackerRead + "B36";//工作状态 0:空闲;1:工作;2:故障报警
        private string Read_SSJ_1_ContainerDetector = LOCALSERVER + StackerRead + "B37";//1#输送机托盘检测 0:无货;1:里面有托盘;2:外侧有托盘;3:内测外侧都有托盘
        private string Read_SSJ_1_CycleDirect = LOCALSERVER + StackerRead + "B38";//0:无 1:入库 2:出库
        private string Read_SSJ_1_Alarm = LOCALSERVER + StackerRead + "B39";//0:无 1-32000 序列
        private string Read_SSJ_1_Alarm_Code = LOCALSERVER + StackerRead + "B40";//输送机报警代码
        private string Read_BarCodeReader1_1 = LOCALSERVER + StackerRead + "B41";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_2 = LOCALSERVER + StackerRead + "B42";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_3 = LOCALSERVER + StackerRead + "B43";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_4 = LOCALSERVER + StackerRead + "B44";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_5 = LOCALSERVER + StackerRead + "B45";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_6 = LOCALSERVER + StackerRead + "B46";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_7 = LOCALSERVER + StackerRead + "B47";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_8 = LOCALSERVER + StackerRead + "B48";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_9 = LOCALSERVER + StackerRead + "B49";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader1_10 = LOCALSERVER + StackerRead + "B50";//一号条码阅读器第1-10位字符 ASCII码
        private string Read_SSJ_1_IsEmpty = LOCALSERVER + StackerRead + "B51";//0:空托盘 1:托盘有货 
        #endregion
        #region 2#输送机
        private string Read_SSJ_2_WorkStatus = LOCALSERVER + StackerRead + "B52";//工作状态 0:空闲;1:工作;2:故障报警
        private string Read_SSJ_2_ContainerDetector = LOCALSERVER + StackerRead + "B53";//2#输送机托盘检测 0:无货;1:里面有托盘;2:外侧有托盘;3:内测外侧都有托盘
        private string Read_SSJ_2_CycleDirect = LOCALSERVER + StackerRead + "B54";//0:无 1:入库 2:出库
        private string Read_SSJ_2_Alarm = LOCALSERVER + StackerRead + "B55";//0:无 1-32000 序列
        private string Read_SSJ_2_Alarm_Code = LOCALSERVER + StackerRead + "B56";//输送机报警代码 0:无报警;1:急停;2:变频器报警;3:超重;4:外形报警;5:光栅报警.
        private string Read_BarCodeReader2_1 = LOCALSERVER + StackerRead + "B57";//1号输送机货物高度 1 低 2 中 3 高
        private string Read_BarCodeReader2_2 = LOCALSERVER + StackerRead + "B58";//2号输送机货物高度 1 低 2 中 3 高
        private string Read_BarCodeReader2_3 = LOCALSERVER + StackerRead + "B59";//*
        private string Read_BarCodeReader2_4 = LOCALSERVER + StackerRead + "B60";//*
        private string Read_BarCodeReader2_5 = LOCALSERVER + StackerRead + "B61";//*备用
        private string Read_BarCodeReader2_6 = LOCALSERVER + StackerRead + "B62";//*
        private string Read_BarCodeReader2_7 = LOCALSERVER + StackerRead + "B63";//*
        private string Read_BarCodeReader2_8 = LOCALSERVER + StackerRead + "B64";//*
        private string Read_BarCodeReader2_9 = LOCALSERVER + StackerRead + "B65";//*
        private string Read_BarCodeReader2_10 = LOCALSERVER + StackerRead + "B66";//*
        private string Read_SSJ_2_IsEmpty = LOCALSERVER + StackerRead + "B67";//*
        #endregion
        #region 3#输送机
        private string Read_SSJ_3_WorkStatus = LOCALSERVER + StackerRead + "B68";//工作状态 0:空闲;1:工作;2:故障报警
        private string Read_SSJ_3_ContainerDetector = LOCALSERVER + StackerRead + "B69";//1#输送机托盘检测 0:无货;1:里面有托盘;2:外侧有托盘;3:内测外侧都有托盘
        private string Read_SSJ_3_CycleDirect = LOCALSERVER + StackerRead + "B70";//0:无 1:入库 2:出库
        private string Read_SSJ_3_Alarm = LOCALSERVER + StackerRead + "B71";//0:无 1-32000 序列
        private string Read_SSJ_3_Alarm_Code = LOCALSERVER + StackerRead + "B72";//输送机报警代码
        private string Read_BarCodeReader3_1 = LOCALSERVER + StackerRead + "B73";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_2 = LOCALSERVER + StackerRead + "B74";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_3 = LOCALSERVER + StackerRead + "B75";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_4 = LOCALSERVER + StackerRead + "B76";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_5 = LOCALSERVER + StackerRead + "B77";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_6 = LOCALSERVER + StackerRead + "B78";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_7 = LOCALSERVER + StackerRead + "B79";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_8 = LOCALSERVER + StackerRead + "B80";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_9 = LOCALSERVER + StackerRead + "B81";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_BarCodeReader3_10 = LOCALSERVER + StackerRead + "B82";//3号条码阅读器第1-10位字符 ASCII码
        private string Read_SSJ_3_IsEmpty = LOCALSERVER + StackerRead + "B83";//0:空托盘 1:托盘有货 3:默认
        #endregion

        private string WRITE_HandShake = LOCALSERVER + StackerWrite + "W12";//写入握手信号
        private string WRITE_SourcePai = LOCALSERVER + StackerWrite + "B2";//起始排
        private string WRITE_SourceCol = LOCALSERVER + StackerWrite + "B3";//起始列
        private string WRITE_SourceLayer = LOCALSERVER + StackerWrite + "B4";//起始层
        private string WRITE_DestinationPai = LOCALSERVER + StackerWrite + "B5";//目标排
        private string WRITE_DestinationCol = LOCALSERVER + StackerWrite + "B6";//目标列
        private string WRITE_DestinationLayer = LOCALSERVER + StackerWrite + "B7";//目标层
        private string WRITE_NewTask = LOCALSERVER + StackerWrite + "B16";//下达任务
        private string WRITE_TaskID = LOCALSERVER + StackerWrite + "D8";//任务号
        private string WRITE_SSJ_1_Allow = LOCALSERVER + StackerWrite + "B17";//1号输送机入库许可
        private string WRITE_SSJ_2_Allow = LOCALSERVER + StackerWrite + "B18";//2号输送机入库许可
        private string WRITE_SSJ_3_Allow = LOCALSERVER + StackerWrite + "B19";//3号输送机入库许可      
        private string WRITE_OrderType = LOCALSERVER + StackerWrite + "B1";//0:无 1:入库/出库/移库 2:删除任务 3:急停 4.召回
        private string WRITE_SSJ1_DeleteBarcode = LOCALSERVER + StackerWrite + "B20";
        private string WRITE_SSJ3_DeleteBarcode = LOCALSERVER + StackerWrite + "B21";
        private string WRITE_SSJ1_BarcodeError = LOCALSERVER + StackerWrite + "B22";
        private string WRITE_SSJ3_BarcodeError = LOCALSERVER + StackerWrite + "B23";
        private string WRITE_SRM_Reset = LOCALSERVER + StackerWrite + "B24";//报警复位
        #endregion

        #region 读取地址编号
        /// <summary>
        /// 握手信号
        /// </summary>
        public static int READ_Index_HandShake = 0;
        /// <summary>
        /// 任务完成信号
        /// </summary>
        public static int READ_Index_Task_Finish = 1;
        /// <summary>
        /// 工作模式 1:自动 2:非自动
        /// </summary>
        public static int READ_Index_WorkMode = 2;
        /// <summary>
        /// 工作状态 0:空闲 1:等待 2:定位 3:取货 4:放货 98:维修
        /// </summary>
        public static int READ_Index_WorkStatus = 3;
        /// <summary>
        /// 报警状态指示
        /// </summary>
        public static int READ_Index_ALARM = 4;
        /// <summary>
        /// 报警代码
        /// </summary>
        public static int READ_Index_ALARM_Code = 5;
        /// <summary>
        /// 当前任务号
        /// </summary>
        public static int READ_Index_TaskId = 6;
        /// <summary>
        /// 行走位置
        /// </summary>
        public static int READ_Index_TravelPos = 7;
        /// <summary>
        /// 提升位置
        /// </summary>
        public static int READ_Index_LiftPos = 8;
        /// <summary>
        /// 伸叉位置
        /// </summary>
        public static int READ_Index_ForkPos = 9;
        /// <summary>
        /// 取货完成信号
        /// </summary>
        public static int READ_Index_IsGetFinish = 10;
        /// <summary>
        /// 放货完成信号
        /// </summary>
        public static int READ_Index_IsPutFinish = 11;
        /// <summary>
        /// 载货台有货信号
        /// </summary>
        public static int READ_Index_IsLoaded = 12;
        /// <summary>
        /// 载货台原点信号
        /// </summary>
        public static int READ_Index_IsForkZero = 13;

        public static int Read_Index_CurrentLayer = 14;
        public static int Read_Index_CurrentColumn = 15;

        public static int Read_Index_SSJ_1_WorkStatus = 16;
        public static int Read_Index_SSJ_1_ContainerDetector = 17;//1#输送机托盘检测 0:无货;1:里面有托盘;2:外侧有托盘;3:内测外侧都有托盘
        public static int Read_Index_SSJ_1_CycleDirect = 18;//0:无 1:入库 2:出库
        public static int Read_Index_SSJ_1_Alarm = 19;//0:无 1-32000 序列
        public static int Read_Index_SSJ_1_Alarm_Code = 20;//输送机报警代码 0:无报警;1:急停;2:变频器报警;3:超重;4:外形报警;5:光栅报警.
        public static int Read_Index_BarCodeReader1_1 = 21;//*
        public static int Read_Index_BarCodeReader1_2 = 22;//*
        public static int Read_Index_BarCodeReader1_3 = 23;//*
        public static int Read_Index_BarCodeReader1_4 = 24;//*
        public static int Read_Index_BarCodeReader1_5 = 25;//*备用
        public static int Read_Index_BarCodeReader1_6 = 26;//*
        public static int Read_Index_BarCodeReader1_7 = 27;//*
        public static int Read_Index_BarCodeReader1_8 = 28;//*
        public static int Read_Index_BarCodeReader1_9 = 29;//*
        public static int Read_Index_BarCodeReader1_10 = 30;//*
        public static int Read_Index_SSJ_1_IsEmpty = 31;//*

        public static int Read_Index_SSJ_2_WorkStatus = 32;
        public static int Read_Index_SSJ_2_ContainerDetector = 33;//1#输送机托盘检测 0:无货;1:里面有托盘;2:外侧有托盘;3:内测外侧都有托盘
        public static int Read_Index_SSJ_2_CycleDirect = 34;//0:无 1:入库 2:出库
        public static int Read_Index_SSJ_2_Alarm = 35;//0:无 1-32000 序列
        public static int Read_Index_SSJ_2_Alarm_Code = 36;//输送机报警代码 0:无报警;1:急停;2:变频器报警;3:超重;4:外形报警;5:光栅报警.
        public static int Read_Index_BarCodeReader2_1 = 37;//*
        public static int Read_Index_BarCodeReader2_2 = 38;//*
        public static int Read_Index_BarCodeReader2_3 = 39;//*
        public static int Read_Index_BarCodeReader2_4 = 40;//*
        public static int Read_Index_BarCodeReader2_5 = 41;//*备用
        public static int Read_Index_BarCodeReader2_6 = 42;//*
        public static int Read_Index_BarCodeReader2_7 = 43;//*
        public static int Read_Index_BarCodeReader2_8 = 44;//*
        public static int Read_Index_BarCodeReader2_9 = 45;//*
        public static int Read_Index_BarCodeReader2_10 = 46;//*
        public static int Read_Index_SSJ_2_IsEmpty = 47;//*

        public static int Read_Index_SSJ_3_WorkStatus = 48;
        public static int Read_Index_SSJ_3_ContainerDetector = 49;//1#输送机托盘检测 0:无货;1:里面有托盘;2:外侧有托盘;3:内测外侧都有托盘
        public static int Read_Index_SSJ_3_CycleDirect = 50;//0:无 1:入库 2:出库
        public static int Read_Index_SSJ_3_Alarm = 51;//0:无 1-32000 序列
        public static int Read_Index_SSJ_3_Alarm_Code = 52;//输送机报警代码 0:无报警;1:急停;2:变频器报警;3:超重;4:外形报警;5:光栅报警.
        public static int Read_Index_BarCodeReader3_1 = 53;//*
        public static int Read_Index_BarCodeReader3_2 = 54;//*
        public static int Read_Index_BarCodeReader3_3 = 55;//*
        public static int Read_Index_BarCodeReader3_4 = 56;//*
        public static int Read_Index_BarCodeReader3_5 = 57;//*备用
        public static int Read_Index_BarCodeReader3_6 = 58;//*
        public static int Read_Index_BarCodeReader3_7 = 59;//*
        public static int Read_Index_BarCodeReader3_8 = 60;//*
        public static int Read_Index_BarCodeReader3_9 = 61;//*
        public static int Read_Index_BarCodeReader3_10 = 62;//*
        public static int Read_Index_SSJ_3_IsEmpty = 63;//*

        #endregion

        #region 写入地址编号
        /// <summary>
        /// 写入握手信号
        /// </summary>
        public static int WRITE_Index_HandShake = 0;
        /// <summary>
        /// 起始排
        /// </summary>
        public static int WRITE_Index_SourcePai = 1;
        /// <summary>
        /// 起始列
        /// </summary>
        public static int WRITE_Index_SourceCol = 2;
        /// <summary>
        /// 起始层
        /// </summary>
        public static int WRITE_Index_SourceLayer = 3;
        /// <summary>
        /// 目标排
        /// </summary>
        public static int WRITE_Index_DestinationPai = 4;
        /// <summary>
        /// 目标列
        /// </summary>
        public static int WRITE_Index_DestinationCol = 5;
        /// <summary>
        /// 目标层
        /// </summary>
        public static int WRITE_Index_DestinationLayer = 6;
        /// <summary>
        /// 下达新任务
        /// </summary>
        public static int WRITE_Index_NewTask = 7;
        /// <summary>
        /// 任务号
        /// </summary>
        public static int WRITE_Index_TaskID = 8;
        /// <summary>
        /// 
        /// </summary>
        public static int WRITE_Index_SSJ1_Allow = 9;

        #region 虚拟堆垛机专用
        ///// <summary>
        ///// 删除任务
        ///// </summary>
        //public static int WRITE_Index_Cancel_Task = 10;
        ///// <summary>
        ///// 发送召回
        ///// </summary>
        //public static int WRITE_Index_Call_Back = 11;
        ///// <summary>
        ///// 发送急停
        ///// </summary>
        //public static int WRITE_Index_EStop = 12; 
        #endregion
        public static int WRITE_Index_SSJ2_Allow = 10;
        public static int WRITE_Index_SSJ3_Allow = 11;
        public static int WRITR_Index_OrderType = 12;
        public static int WRITE_Index_SSJ1_DeleteBarcode = 13;
        public static int WRITE_Index_SSJ3_DeleteBarcode = 14;
        public static int WRITR_Index_SSJ1_BarcodeError = 15;
        public static int WRITR_Index_SSJ3_BarcodeError = 16;
        #endregion
        public static int WRITE_Index_Srm_Reset = 17;
        public List<string> Read_Index, Write_Index;


        #region 堆垛机自身属性
        /// <summary>
        /// 工作状态 0:空闲 1:等待 2:定位 3:取货 4:放货 98:维修
        /// </summary>
        public string workMode { get; set; }
        /// <summary>
        /// 水平位置
        /// </summary>
        public int nTravelPos = 0;
        /// <summary>
        /// 货叉位置
        /// </summary>
        public int nForkPos = 105648;
        /// <summary>
        /// 提升位置
        /// </summary>
        public int nLiftPos = 0;
        /// <summary>
        /// 当前状态:正常,报警,断线
        /// </summary>
        public string currentState;

        /// <summary>
        /// 是否有报警
        /// </summary>
        public int isAlert = 0;

        /// <summary>
        /// 堆垛机模式
        /// </summary>
        public int workStatus = 1;
        #endregion


        /// <summary>
        /// 将值写入OPC服务器
        /// </summary>
        /// <param name="ItemName">地址</param>
        /// <param name="itemValues">值</param>
        /// <returns></returns>
        public bool WriteValuePoint(string ItemName, object itemValues)
        {
            object ItemValues = itemValues;
            try
            {
                using (OpcService.ASRS_Service srv = new ASRS_Service())
                {
                    if (srv.OPC_WritePoint(ItemName, ItemValues))
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 读取一个数据块的值
        /// </summary>
        /// <param name="ItemName"></param>
        /// <returns></returns>
        public object ReadValuePoint(string ItemName)
        {
            List<string> ItemNames = new List<string>();
            ItemNames.Add(ItemName);
            try
            {
                using (ASRS_Service srv = new ASRS_Service())
                {
                    return srv.OPC_Read(ItemNames.ToArray())[0];
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 读取数据块集合的值
        /// </summary>
        /// <param name="ItemNames">数据块集合</param>
        /// <returns></returns>
        public List<object> ReadValueSerial(List<string> ItemNames)
        {

            try
            {
                using (ASRS_Service srv = new ASRS_Service())
                {
                    return srv.OPC_Read(ItemNames.ToArray()).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<object>();
            }
        }

        public bool SetTask(string sourcePlace, string toPlace, int taskId)
        {
            if (sourcePlace.Length > 5 || toPlace.Length > 5)
            {
                return false;
            }
            int fromPai, fromCol, fromLayer, toPai, toCol, toLayer;
            try
            {
                fromPai = int.Parse(sourcePlace.Substring(0, 1));
                fromCol = int.Parse(sourcePlace.Substring(1, 2));
                fromLayer = int.Parse(sourcePlace.Substring(3, 2));
                toPai = int.Parse(toPlace.Substring(0, 1));
                toCol = int.Parse(toPlace.Substring(1, 2));
                toLayer = int.Parse(toPlace.Substring(3, 2));
            }
            catch (Exception)
            {
                return false;
            }

            bool v1 = WriteValuePoint(Write_Index[WRITE_Index_SourcePai], fromPai);
            bool v2 = WriteValuePoint(Write_Index[WRITE_Index_SourceCol], fromCol);
            bool v3 = WriteValuePoint(Write_Index[WRITE_Index_SourceLayer], fromLayer);
            bool v4 = WriteValuePoint(Write_Index[WRITE_Index_DestinationPai], toPai);
            bool v5 = WriteValuePoint(Write_Index[WRITE_Index_DestinationCol], toCol);
            bool v6 = WriteValuePoint(Write_Index[WRITE_Index_DestinationLayer], toLayer);
            bool v7 = WriteValuePoint(Write_Index[WRITE_Index_TaskID], taskId);

            if (v1 && v2 && v3 && v4 && v5 && v6 && v7)//如果全部写入成功则下发newTask
            {
                if (WriteValuePoint(Write_Index[WRITR_Index_OrderType], 1) && WriteValuePoint(Write_Index[WRITE_Index_NewTask], 1))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
