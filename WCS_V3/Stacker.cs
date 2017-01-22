using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using WCS_V3.OpcService;
/************************************************* 
作者：王铮
公司：伟本机电(上海)有限公司
说明：对ROBO堆垛机进行类化
创建日期：2015-11
版本号：1.6
**********************************************/

namespace WCS_V3
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
            Write_Index.Add(WRITE_OrderType);//9
            Write_Index.Add(WRITE_SRM_Reset);//10
            Write_Index.Add(WRITE_SRM_Online);//11
            #endregion
        }


        #region 读写地址定义(ROBO堆垛机)
        //private const string LOCALSERVER = "S7:[@LOCALSERVER]";
        private const string LOCALSERVER = "S7:[SRM]";
        private const string StackerRead = "DB541,";
        private const string StackerWrite = "DB540,";
        /// <summary>
        /// 读取握手信号
        /// </summary>
        private static string READ_HandShake = LOCALSERVER + StackerRead + "W30";
        /// <summary>
        /// 任务完成信号 0 未完成 1 完成
        /// </summary>
        private static string READ_Task_Finish = LOCALSERVER + StackerRead + "B8";
        /// <summary>
        /// 工作模式 0：脱机；1：自动；2：半自动；3：手动；4：维修
        /// </summary>
        private static string READ_WorkMode = LOCALSERVER + StackerRead + "D2";
        /// <summary>
        /// 0：空闲 1：定位 2：取货 3：放货
        /// </summary>
        private static string READ_WorkStatus = LOCALSERVER + StackerRead + "B11";
        /// <summary>
        /// 为0:无故障;不为0:从1开始，每次递增，到达32766时再从1开始
        /// </summary>
        private static string READ_ALARM = LOCALSERVER + StackerRead + "W32";
        /// <summary>
        /// 堆垛机故障代码
        /// </summary>
        private static string READ_ALARM_Code = LOCALSERVER + StackerRead + "W34";
        /// <summary>
        /// 当前任务号
        /// </summary>
        private static string READ_TaskId = LOCALSERVER + StackerRead + "D26";
        /// <summary>
        /// 当前水平坐标
        /// </summary>
        private static string READ_TravelPos = LOCALSERVER + StackerRead + "D14";
        /// <summary>
        /// 当前起升坐标
        /// </summary>
        private static string READ_LiftPos = LOCALSERVER + StackerRead + "D18";
        /// <summary>
        /// 当前伸叉坐标
        /// </summary>
        private static string READ_ForkPos = LOCALSERVER + StackerRead + "D22";
        /// <summary>
        /// 是否取货完成 0未完成 1 完成
        /// </summary>
        private static string READ_IsGetFinish = LOCALSERVER + StackerRead + "B6";
        /// <summary>
        /// 是否放货完成 0未完成 1 完成
        /// </summary>
        private static string READ_IsPutFinish = LOCALSERVER + StackerRead + "B7";
        /// <summary>
        /// 是否当前有货  0 无货 1 有货
        /// </summary>
        private static string READ_IsLoaded = LOCALSERVER + StackerRead + "B9";
        /// <summary>
        /// 货叉是否原位  0 不在 1 在
        /// </summary>
        private static string READ_IsForkZero = LOCALSERVER + StackerRead + "B10";
        /// <summary>
        /// 当前层
        /// </summary>
        private static string READ_CurrentLayer = LOCALSERVER + StackerRead + "B13";
        /// <summary>
        /// 当前列
        /// </summary>
        private static string READ_CurrentColumn = LOCALSERVER + StackerRead + "B12";



        private string WRITE_HandShake = LOCALSERVER + StackerWrite + "W12";//写入握手信号
        private string WRITE_SourcePai = LOCALSERVER + StackerWrite + "B2";//起始排
        private string WRITE_SourceCol = LOCALSERVER + StackerWrite + "B3";//起始列
        private string WRITE_SourceLayer = LOCALSERVER + StackerWrite + "B4";//起始层
        private string WRITE_DestinationPai = LOCALSERVER + StackerWrite + "B5";//目标排
        private string WRITE_DestinationCol = LOCALSERVER + StackerWrite + "B6";//目标列
        private string WRITE_DestinationLayer = LOCALSERVER + StackerWrite + "B7";//目标层
        private string WRITE_NewTask = LOCALSERVER + StackerWrite + "B16";//下达任务
        private string WRITE_TaskID = LOCALSERVER + StackerWrite + "D8";//任务号   
        /// <summary>
        /// 0:无 1:入库/出库/移库 2:删除任务 3:急停 4.召回   
        /// </summary>
        private string WRITE_OrderType = LOCALSERVER + StackerWrite + "B1";
        private string WRITE_SRM_Reset = LOCALSERVER + StackerWrite + "B17";//报警复位
        private string WRITE_SRM_Online = LOCALSERVER + StackerWrite + "B18";//请求联机
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

        public static int WRITR_Index_OrderType = 9;
        #endregion
        public static int WRITE_Index_Srm_Reset = 10;
        public static int WRITE_Index_Srm_Online = 11;
        public List<string> Read_Index, Write_Index;


        #region 堆垛机自身属性
        /// <summary>
        /// 心跳值
        /// </summary>
        public static string handShake;
        /// <summary>
        /// 是否任务完成
        /// </summary>
        public static int isTaskFinish;

        /// <summary>
        ///  工作模式 0：脱机；1：自动；2：半自动；3：手动；4：维修
        /// </summary>
        public static int workMode;
        /// <summary>
        /// 工作状态  0：空闲，无任务 1：取货定位 2：请求取货 3：取货中 4：放货定位5：请求放货6：放货中
        /// </summary>
        public static int workStatus { get; set; }
        /// <summary>
        /// 报警ID
        /// </summary>
        public static int alarm;
        /// <summary>
        /// 报警号
        /// </summary>
        public static int alarm_Code;

        /// <summary>
        /// 堆垛机任务号
        /// </summary>
        public static int taskId;
        /// <summary>
        /// 取货结束
        /// </summary>
        public static int isGetFinish;

        /// <summary>
        /// 放货结束
        /// </summary>
        public static int isPutFinish;

        /// <summary>
        /// 是否当前有货
        /// </summary>
        public static int isLoaded;

        /// <summary>
        /// 是否货叉中位
        /// </summary>
        public static int isForkZero;

        /// <summary>
        /// 当前层
        /// </summary>
        public static int currentLayer;

        /// <summary>
        /// 当前列
        /// </summary>
        public static int currentColumn;
        /// <summary>
        /// 水平位置
        /// </summary>
        public static int nTravelPos = 0;
        /// <summary>
        /// 货叉位置
        /// </summary>
        public static int nForkPos = 80;
        /// <summary>
        /// 提升位置
        /// </summary>
        public static int nLiftPos = 0;

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
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
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
            ArrayOfString ItemNames = new ArrayOfString();
            ItemNames.Add(ItemName);
            try
            {
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    return srv.OPC_Read(ItemNames)[0];
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
        public static List<object> ReadValueSerial(List<string> ItemNames)
        {
            ArrayOfString itemNames = new ArrayOfString();
            itemNames.AddRange(ItemNames);
            try
            {
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    return srv.OPC_Read(itemNames);
                }
            }
            catch (Exception ex)
            {
                return new List<object>();
            }
        }

        /// <summary>
        /// 数据块读取
        /// </summary>
        public static void DataRead()
        {
          
                Thread.Sleep(500);
                if (!FormMain.isVirsualMode)
                {
                    List<string> ItemNames = new List<string>();
                    ItemNames.Add(READ_HandShake);//0
                    ItemNames.Add(READ_Task_Finish);//1
                    ItemNames.Add(READ_WorkMode);//2
                    ItemNames.Add(READ_WorkStatus);//3
                    ItemNames.Add(READ_ALARM);//4
                    ItemNames.Add(READ_ALARM_Code);//5
                    ItemNames.Add(READ_TaskId);//6
                    ItemNames.Add(READ_TravelPos);//7
                    ItemNames.Add(READ_LiftPos);//8
                    ItemNames.Add(READ_ForkPos);//9
                    ItemNames.Add(READ_IsGetFinish);//10
                    ItemNames.Add(READ_IsPutFinish);//11
                    ItemNames.Add(READ_IsLoaded);//12
                    ItemNames.Add(READ_IsForkZero);//13
                    ItemNames.Add(READ_CurrentLayer);//14
                    ItemNames.Add(READ_CurrentColumn);//15

                    var rsts = ReadValueSerial(ItemNames);
                    if (rsts[0] != null)
                    {
                        handShake = rsts[0].ToString();
                        isTaskFinish = int.Parse(rsts[1].ToString());
                        workMode = int.Parse(rsts[2].ToString());
                        workStatus = int.Parse(rsts[3].ToString());
                        alarm = int.Parse(rsts[4].ToString());
                        alarm_Code = int.Parse(rsts[5].ToString());
                        taskId = int.Parse(rsts[6].ToString());
                        nTravelPos = int.Parse(rsts[7].ToString());
                        nLiftPos = int.Parse(rsts[8].ToString());
                        nForkPos = int.Parse(rsts[9].ToString());
                        isGetFinish = int.Parse(rsts[10].ToString());
                        isPutFinish = int.Parse(rsts[11].ToString());
                        isLoaded = int.Parse(rsts[12].ToString());
                        isForkZero = int.Parse(rsts[13].ToString());
                        currentLayer = int.Parse(rsts[14].ToString());
                        currentColumn = int.Parse(rsts[15].ToString());
                    }
                }
          
        }

        /// <summary>
        /// 发送入库许可
        /// </summary>
        /// <param name="sourcePlace"></param>
        /// <returns></returns>
        public bool SetInLicense(string sourcePlace)
        {
            switch (sourcePlace)
            {
                case "10001":
                    return WriteValuePoint(LogisticEquipment.Write_InAllowST1, true);
                default:
                    return false;
            }

        }
        /// <summary>
        /// 发送出库许可,升降机接收到出库信号后在堆垛机取货过程中自动升起，提高工作效率
        /// </summary>
        /// <param name="toPlace"></param>
        /// <returns></returns>
        public bool SetOutLicense(string toPlace)
        {
            switch (toPlace)
            {
                case "10001":
                    return WriteValuePoint(LogisticEquipment.Write_OutAllowST1, true);
                default:
                    return false;
            }

        }
        /// <summary>
        /// 向堆垛机下发指令
        /// </summary>
        /// <param name="sourcePlace">起始位</param>
        /// <param name="toPlace">目标位</param>
        /// <param name="taskId">任务号</param>
        /// <returns>是否成功</returns>
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
            if (!FormMain.isVirsualMode)
            {

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
            else
            {
                VirsualSrm.wSourcePai = fromPai;
                VirsualSrm.wSourceCol = fromCol;
                VirsualSrm.wSourceLayer = fromLayer;
                VirsualSrm.wToPai = toPai;
                VirsualSrm.wToLayer = toLayer;
                VirsualSrm.wToCol = toCol;
                VirsualSrm.wTaskID = taskId;
                VirsualSrm.wNewTask = 1;
                VirsualSrm.wOrderType = 1;
                return true;
            }
        }
    }
}
