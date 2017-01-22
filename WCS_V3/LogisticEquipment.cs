using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WCS_V3
{
    public class LogisticEquipment
    {
        #region 读写地址定义
        private const string LOCALSERVER = "S7:[LIFT-Station]";
        private const string EquipmentDB = "DB6,";

        private static string READ_HandShake = LOCALSERVER + EquipmentDB + "W4";//0
        /// <summary>
        /// true 联机 false 手动
        /// </summary>
        private static string READ_WorkMode = LOCALSERVER + EquipmentDB + "X0.1";//1
        /// <summary>
        /// true 有货 false 空闲
        /// </summary>
        private static string READ_IsLoadST1 = LOCALSERVER + EquipmentDB + "X0.2";//2
        /// <summary>
        /// true 工作 false 待机
        /// </summary>
        private static string READ_WorkStatusST1 = LOCALSERVER + EquipmentDB + "X0.3";//3
        /// <summary>
        /// 入库标识
        /// </summary>
        private static string READ_IsInST1 = LOCALSERVER + EquipmentDB + "X0.4";//4
        private static string READ_IsOutST1 = LOCALSERVER + EquipmentDB + "X0.5";//5
        /// <summary>
        /// 下降完成
        /// </summary>
        private static string READ_IsDroped = LOCALSERVER + EquipmentDB + "X0.6";//6
        /// <summary>
        /// 上升完成
        /// </summary>
        private static string READ_IsLifted= LOCALSERVER + EquipmentDB + "X0.7";//7

        /// <summary>
        /// 超高
        /// </summary>
        private static string READ_IsHighOutST1 = LOCALSERVER + EquipmentDB + "X1.1";//9
        /// <summary>
        /// 超宽
        /// </summary>
        private static string READ_IsWideOutST1 = LOCALSERVER + EquipmentDB + "X1.2";//10
        /// <summary>
        /// 超差
        /// </summary>
        private static string READ_IsBiasOutST1 = LOCALSERVER + EquipmentDB + "X1.3";//11
        /// <summary>
        /// 马达超时
        /// </summary>
        private static string READ_MotorRunTimeOutST1 = LOCALSERVER + EquipmentDB + "X1.4";//12
        /// <summary>
        /// 安全防护报警
        /// </summary>
        private static string READ_ProtectErrorST1 = LOCALSERVER + EquipmentDB + "X1.5";//13
       
        private static string READ_StopByControlBox = LOCALSERVER + EquipmentDB + "X1.6";//14
        private static string READ_SaftyGateOpen = LOCALSERVER + EquipmentDB + "X1.7";//15

        /// <summary>
        /// 高度检测1、2、3
        /// </summary>
        private static string READ_GetHighNO1 = LOCALSERVER + EquipmentDB + "X0.0";
        private static string READ_GetHighNO2 = LOCALSERVER + EquipmentDB + "X1.0";
        private static string READ_GetHighNO3 = LOCALSERVER + EquipmentDB + "X2.0";


        public static string Write_HandShake = LOCALSERVER + EquipmentDB + "W6";
        public static string Write_InAllowST1 = LOCALSERVER + EquipmentDB + "X8.0";
        public static string Write_OutAllowST1 = LOCALSERVER + EquipmentDB + "X8.1";
        public static string Write_HIGH3ERROR = LOCALSERVER + EquipmentDB + "X8.4";
        /// <summary>
        /// 高度检测
        /// </summary>
        /// 

        
        #endregion

        public static string HandShake = "";//0
        /// <summary>
        /// true 联机 false 手动
        /// </summary>
        public static bool WorkMode = false;//1
        public static bool IsLoadST1 = false;
        /// <summary>
        /// true 工作 false 待机
        /// </summary>
        public static bool WorkStatusST1 = false;//3
        public static bool IsInST1 = false;//4
        public static bool IsOutST1 = false;//5
        public static bool IsDroped = false;//6
        public static bool IsLifted = false;//7
        public static bool IsOnlyFourLayerST1 = false;//8
        public static bool IsHighOutST1 = false;//9
        public static bool IsWidthOutST1 = false;//10
        public static bool IsBiasOutST1 = false;//11
        public static bool MotorErrorST1 = false;//12
        public static bool ProtectErrorST1 = false;//13

        public static bool StopByControlBox = false;
        public static bool DoorOpen = false;
        public static bool INHightNo1 = false;
        public static bool INHightNo2 = false;
        public static bool INHightNo3 = false;
        public static List<string> ReadItems = null;

        public LogisticEquipment()
        {
            ReadItems = new List<string>();
            ReadItems.Add(READ_HandShake);
            ReadItems.Add(READ_WorkMode);
            ReadItems.Add(READ_IsLoadST1);
            ReadItems.Add(READ_WorkStatusST1);
            ReadItems.Add(READ_IsInST1);
            ReadItems.Add(READ_IsOutST1);
            ReadItems.Add(READ_IsDroped);
            ReadItems.Add(READ_IsLifted);
            ReadItems.Add(READ_IsHighOutST1);
            ReadItems.Add(READ_IsWideOutST1);
            ReadItems.Add(READ_IsBiasOutST1);
            ReadItems.Add(READ_MotorRunTimeOutST1);
            ReadItems.Add(READ_ProtectErrorST1);     
            ReadItems.Add(READ_SaftyGateOpen);
            ReadItems.Add(READ_GetHighNO1);
            ReadItems.Add(READ_GetHighNO2);
            ReadItems.Add(READ_GetHighNO3);
        }


        public void DataRead()
        {

                if (!FormMain.isVirsualMode)
                {
                    Thread.Sleep(500);
                    var lst = Stacker.ReadValueSerial(ReadItems);
                    HandShake = lst[0].ToString();
                    WorkMode = bool.Parse(lst[1].ToString());
                    IsLoadST1 = bool.Parse(lst[2].ToString());
                    WorkStatusST1 = bool.Parse(lst[3].ToString());
                    IsInST1 = bool.Parse(lst[4].ToString());
                    IsOutST1 = bool.Parse(lst[5].ToString());
                    IsDroped = bool.Parse(lst[6].ToString());
                    IsLifted = bool.Parse(lst[7].ToString());
                    
                    IsHighOutST1 = bool.Parse(lst[8].ToString());
                    IsWidthOutST1 = bool.Parse(lst[9].ToString());
                    IsBiasOutST1 = bool.Parse(lst[10].ToString());
                    MotorErrorST1 = bool.Parse(lst[11].ToString());
                    ProtectErrorST1 = bool.Parse(lst[12].ToString());                  
                    DoorOpen = bool.Parse(lst[13].ToString());
                    INHightNo1 = bool.Parse(lst[14].ToString());
                    INHightNo2 = bool.Parse(lst[15].ToString());
                    INHightNo3 = bool.Parse(lst[16].ToString());
                    Stacker sk = new Stacker();
                    Random rd = new Random(DateTime.Now.Millisecond);
                    sk.WriteValuePoint(Write_HandShake, rd.Next(1, 9999));//写入心跳
                }

        }
    }
}
