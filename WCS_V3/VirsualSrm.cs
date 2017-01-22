using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCS_V3
{
    public static class VirsualSrm
    {
        #region 读取值
        /// <summary>
        /// 工作模式 0：脱机1：自动；2：半自动；3：手动；4：维修。
        /// </summary>
        public static object rWorkMode = 0;
        /// <summary>
        /// 当前任务 0:未完成 1：完成
        /// </summary>
        public static object rTaskFinish=1;
        /// <summary>
        /// 握手值
        /// </summary>
        public static object rHandShake = 0;
        /// <summary>
        /// 工作状态0：空闲，无任务1：定位2：取货3：放货
        /// </summary>
        public static object rWorkStatus=0;
        /// <summary>
        /// 是否故障 0 无故障 不为0 有故障
        /// </summary>
        public static object rIsAlarm=0;
        /// <summary>
        /// 故障码
        /// </summary>
        public static object rAlarmCode=0;
        /// <summary>
        /// 任务号
        /// </summary>
        public static object rTaskId=1;
        /// <summary>
        /// 当前水平坐标
        /// </summary>
        public static object rTravelPos=86;
        /// <summary>
        /// 当前起升坐标
        /// </summary>
        public static object rLiftPos=0;
        /// <summary>
        /// 当前申叉坐标
        /// </summary>
        public static object rForkPos=80;
        /// <summary>
        /// 取货完成
        /// </summary>
        public static object rGetFinish;
        /// <summary>
        /// 放货完成
        /// </summary>
        public static object rPutFinish;
        /// <summary>
        /// 货叉原点
        /// </summary>
        public static object rForkZero;
        /// <summary>
        /// 载货台有货
        /// </summary>
        public static object rLoaded;


        public static int INHightNo;
        #endregion

        #region 写入值
        /// <summary>
        /// 起始排
        /// </summary>
        public static object wSourcePai=0;
        /// <summary>
        /// 起始列
        /// </summary>
        public static object wSourceCol=0;
        /// <summary>
        /// 起始层
        /// </summary>
        public static object wSourceLayer=0;
        /// <summary>
        /// 目标排
        /// </summary>
        public static object wToPai=0;
        /// <summary>
        /// 目标列
        /// </summary>
        public static object wToCol=0;
        /// <summary>
        /// 目标层
        /// </summary>
        public static object wToLayer=0;
        /// <summary>
        /// 新任务下发 0:无;1:新任务
        /// </summary>
        public static object wNewTask=0;
        /// <summary>
        /// 任务号
        /// </summary>
        public static object wTaskID;
        /// <summary>
        /// 任务类型
        /// </summary>
        public static object wOrderType;
        #endregion
        /// <summary>
        /// 设备是否在线
        /// </summary>
       public static bool isOnLine = false;
        /// <summary>
        /// 设备状态描述
        /// </summary>
       public static string statusDescribe = "";

       public static bool needref = false;
    }
}
