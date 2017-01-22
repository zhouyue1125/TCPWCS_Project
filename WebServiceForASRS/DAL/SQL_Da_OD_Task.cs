using System;
using System.Collections.Generic;
using DBEntity;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;


namespace WebServiceForASRS.DAL
{
    public class SQL_Da_OD_Task
    {
        private static List<OD_Task> DoQuery(string sql_str)
        {
            List<OD_Task> rtn = new List<OD_Task>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new OD_Task();
                        #region 逐个赋值
                        p.TASKID = DBHelper_SqlServer.GetDataValue<string>(dr, "TASKID");
                        p.TASKNAME = DBHelper_SqlServer.GetDataValue<string>(dr, "TASKNAME");
                        p.DODEVICEID = DBHelper_SqlServer.GetDataValue<string>(dr, "DODEVICEID");
                        p.DODEVICENODEID = DBHelper_SqlServer.GetDataValue<string>(dr, "DODEVICENODEID");
                        p.DODEVICETYPE = DBHelper_SqlServer.GetDataValue<string>(dr, "DODEVICETYPE");
                        p.TASKTYPE = DBHelper_SqlServer.GetDataValue<string>(dr, "TASKTYPE");
                        p.TASKLEVEL = DBHelper_SqlServer.GetDataValue<string>(dr, "TASKLEVEL");
                        p.TASKSTATUS = DBHelper_SqlServer.GetDataValue<string>(dr, "TASKSTATUS");
                        p.TASKCONTENTSTRING = DBHelper_SqlServer.GetDataValue<string>(dr, "TASKCONTENTSTRING");
                        p.TASKTYPEDESCRIPTION = DBHelper_SqlServer.GetDataValue<string>(dr, "TASKTYPEDESCRIPTION");
                        p.CONTAINERNO = DBHelper_SqlServer.GetDataValue<string>(dr, "CONTAINERNO");
                        p.SOURCEPLACE = DBHelper_SqlServer.GetDataValue<string>(dr, "SOURCEPLACE");
                        p.TOPLACE = DBHelper_SqlServer.GetDataValue<string>(dr, "TOPLACE");
                        p.ORDERDETAILSID = DBHelper_SqlServer.GetDataValue<string>(dr, "ORDERDETAILSID");
                        p.ORDERHEADID = DBHelper_SqlServer.GetDataValue<string>(dr, "ORDERHEADID");
                        p.SENDTIMES = DBHelper_SqlServer.GetDataValue<int>(dr, "SENDTIMES");
                        p.RELEASESTATUS = DBHelper_SqlServer.GetDataValue<string>(dr, "RELEASESTATUS");
                        p.HADFINISH = DBHelper_SqlServer.GetDataValue<string>(dr, "HADFINISH");
                        p.VOID = DBHelper_SqlServer.GetDataValue<int>(dr, "VOID");
                        p.UPDATETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATETIME");
                        p.UPDATEUSER = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATEUSER");
                        p.WAREHOUSENO = DBHelper_SqlServer.GetDataValue<string>(dr, "WAREHOUSENO");
                        p.ISCURRENTTASK = DBHelper_SqlServer.GetDataValue<string>(dr, "ISCURRENTTASK");
                        p.INPUTLOCATIONLEVEL = DBHelper_SqlServer.GetDataValue<int>(dr, "INPUTLOCATIONLEVEL");
                        p.ISLASTTASK = DBHelper_SqlServer.GetDataValue<string>(dr, "ISLASTTASK");
                        p.ISEMPTYCONTAINER = DBHelper_SqlServer.GetDataValue<string>(dr, "ISEMPTYCONTAINER");

                        #endregion
                        rtn.Add(p);
                    }
                }
            }
            catch
            {
            }
            return rtn;
        }

        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(OD_Task t_new)
        {
            try
            {
                OD_Task tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into OD_Task (  ");
                sb.Append("TASKID, ");
                sb.Append("TASKNAME, ");
                sb.Append("DODEVICEID, ");
                sb.Append("DODEVICENODEID, ");
                sb.Append("DODEVICETYPE, ");
                sb.Append("TASKTYPE, ");
                sb.Append("TASKLEVEL, ");
                sb.Append("TASKSTATUS, ");
                sb.Append("TASKCONTENTSTRING, ");
                sb.Append("TASKTYPEDESCRIPTION, ");
                sb.Append("CONTAINERNO, ");
                sb.Append("SOURCEPLACE, ");
                sb.Append("TOPLACE, ");
                sb.Append("ORDERDETAILSID, ");
                sb.Append("ORDERHEADID, ");
                sb.Append("SENDTIMES, ");
                sb.Append("RELEASESTATUS, ");
                sb.Append("HADFINISH, ");
                sb.Append("VOID, ");
                sb.Append("UPDATETIME, ");
                sb.Append("UPDATEUSER, ");
                sb.Append("WAREHOUSENO, ");
                sb.Append("ISCURRENTTASK, ");
                sb.Append("INPUTLOCATIONLEVEL, ");
                sb.Append("ISLASTTASK, ");
                sb.Append("ISEMPTYCONTAINER )");
                sb.Append(" values ( ");
                sb.Append("@TASKID,");
                sb.Append("@TASKNAME,");
                sb.Append("@DODEVICEID,");
                sb.Append("@DODEVICENODEID,");
                sb.Append("@DODEVICETYPE,");
                sb.Append("@TASKTYPE,");
                sb.Append("@TASKLEVEL,");
                sb.Append("@TASKSTATUS,");
                sb.Append("@TASKCONTENTSTRING,");
                sb.Append("@TASKTYPEDESCRIPTION,");
                sb.Append("@CONTAINERNO,");
                sb.Append("@SOURCEPLACE,");
                sb.Append("@TOPLACE,");
                sb.Append("@ORDERDETAILSID,");
                sb.Append("@ORDERHEADID,");
                sb.Append("@SENDTIMES,");
                sb.Append("@RELEASESTATUS,");
                sb.Append("@HADFINISH,");
                sb.Append("@VOID,");
                sb.Append("@UPDATETIME,");
                sb.Append("@UPDATEUSER,");
                sb.Append("@WAREHOUSENO,");
                sb.Append("@ISCURRENTTASK,");
                sb.Append("@INPUTLOCATIONLEVEL,");
                sb.Append("@ISLASTTASK,");
                sb.Append(" @ISEMPTYCONTAINER )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@TASKID", DbType.String) { Value = tt.TASKID });
                cmd.Parameters.Add(new SqlParameter("@TASKNAME", DbType.String) { Value = tt.TASKNAME });
                cmd.Parameters.Add(new SqlParameter("@DODEVICEID", DbType.String) { Value = tt.DODEVICEID });
                cmd.Parameters.Add(new SqlParameter("@DODEVICENODEID", DbType.String) { Value = tt.DODEVICENODEID });
                cmd.Parameters.Add(new SqlParameter("@DODEVICETYPE", DbType.String) { Value = tt.DODEVICETYPE });
                cmd.Parameters.Add(new SqlParameter("@TASKTYPE", DbType.String) { Value = tt.TASKTYPE });
                cmd.Parameters.Add(new SqlParameter("@TASKLEVEL", DbType.String) { Value = tt.TASKLEVEL });
                cmd.Parameters.Add(new SqlParameter("@TASKSTATUS", DbType.String) { Value = tt.TASKSTATUS });
                cmd.Parameters.Add(new SqlParameter("@TASKCONTENTSTRING", DbType.String) { Value = tt.TASKCONTENTSTRING });
                cmd.Parameters.Add(new SqlParameter("@TASKTYPEDESCRIPTION", DbType.String) { Value = tt.TASKTYPEDESCRIPTION });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERNO", DbType.String) { Value = tt.CONTAINERNO });
                cmd.Parameters.Add(new SqlParameter("@SOURCEPLACE", DbType.String) { Value = tt.SOURCEPLACE });
                cmd.Parameters.Add(new SqlParameter("@TOPLACE", DbType.String) { Value = tt.TOPLACE });
                cmd.Parameters.Add(new SqlParameter("@ORDERDETAILSID", DbType.String) { Value = tt.ORDERDETAILSID });
                cmd.Parameters.Add(new SqlParameter("@ORDERHEADID", DbType.String) { Value = tt.ORDERHEADID });
                cmd.Parameters.Add(new SqlParameter("@SENDTIMES", DbType.Int32) { Value = tt.SENDTIMES });
                cmd.Parameters.Add(new SqlParameter("@RELEASESTATUS", DbType.String) { Value = tt.RELEASESTATUS });
                cmd.Parameters.Add(new SqlParameter("@HADFINISH", DbType.String) { Value = tt.HADFINISH });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@ISCURRENTTASK", DbType.String) { Value = tt.ISCURRENTTASK });
                cmd.Parameters.Add(new SqlParameter("@INPUTLOCATIONLEVEL", DbType.Int32) { Value = tt.INPUTLOCATIONLEVEL });
                cmd.Parameters.Add(new SqlParameter("@ISLASTTASK", DbType.String) { Value = tt.ISLASTTASK });
                cmd.Parameters.Add(new SqlParameter("@ISEMPTYCONTAINER", DbType.String) { Value = tt.ISEMPTYCONTAINER });

                foreach (SqlParameter p in cmd.Parameters)
                {
                    p.IsNullable = true;
                    if (p.Value == null)
                        p.Value = DBNull.Value;
                }
               DBHelper DBHelper_SqlServer = new DBLink();
                int val = DBHelper_SqlServer.ExecuteNonQuery(cmd);
                if (val > 0)
                { 
                    return true; 
                }
                else 
                { 
                    return false;
                } 
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateOne(OD_Task t_new)
        {
            try
            {
                OD_Task tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update OD_Task set ");
                sb.Append("TASKNAME=@TASKNAME, ");
                sb.Append("DODEVICEID=@DODEVICEID, ");
                sb.Append("DODEVICENODEID=@DODEVICENODEID, ");
                sb.Append("DODEVICETYPE=@DODEVICETYPE, ");
                sb.Append("TASKTYPE=@TASKTYPE, ");
                sb.Append("TASKLEVEL=@TASKLEVEL, ");
                sb.Append("TASKSTATUS=@TASKSTATUS, ");
                sb.Append("TASKCONTENTSTRING=@TASKCONTENTSTRING, ");
                sb.Append("TASKTYPEDESCRIPTION=@TASKTYPEDESCRIPTION, ");
                sb.Append("CONTAINERNO=@CONTAINERNO, ");
                sb.Append("SOURCEPLACE=@SOURCEPLACE, ");
                sb.Append("TOPLACE=@TOPLACE, ");
                sb.Append("ORDERDETAILSID=@ORDERDETAILSID, ");
                sb.Append("ORDERHEADID=@ORDERHEADID, ");
                sb.Append("SENDTIMES=@SENDTIMES, ");
                sb.Append("RELEASESTATUS=@RELEASESTATUS, ");
                sb.Append("HADFINISH=@HADFINISH, ");
                sb.Append("VOID=@VOID, ");
                sb.Append("UPDATETIME=@UPDATETIME, ");
                sb.Append("UPDATEUSER=@UPDATEUSER, ");
                sb.Append("WAREHOUSENO=@WAREHOUSENO, ");
                sb.Append("ISCURRENTTASK=@ISCURRENTTASK, ");
                sb.Append("INPUTLOCATIONLEVEL=@INPUTLOCATIONLEVEL, ");
                sb.Append("ISLASTTASK=@ISLASTTASK, ");
                sb.Append("ISEMPTYCONTAINER=@ISEMPTYCONTAINER ");

                sb.Append(" where TASKID=@TASKID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.Add(new SqlParameter("@TASKNAME", DbType.String) { Value = tt.TASKNAME });
                cmd.Parameters.Add(new SqlParameter("@DODEVICEID", DbType.String) { Value = tt.DODEVICEID });
                cmd.Parameters.Add(new SqlParameter("@DODEVICENODEID", DbType.String) { Value = tt.DODEVICENODEID });
                cmd.Parameters.Add(new SqlParameter("@DODEVICETYPE", DbType.String) { Value = tt.DODEVICETYPE });
                cmd.Parameters.Add(new SqlParameter("@TASKTYPE", DbType.String) { Value = tt.TASKTYPE });
                cmd.Parameters.Add(new SqlParameter("@TASKLEVEL", DbType.String) { Value = tt.TASKLEVEL });
                cmd.Parameters.Add(new SqlParameter("@TASKSTATUS", DbType.String) { Value = tt.TASKSTATUS });
                cmd.Parameters.Add(new SqlParameter("@TASKCONTENTSTRING", DbType.String) { Value = tt.TASKCONTENTSTRING });
                cmd.Parameters.Add(new SqlParameter("@TASKTYPEDESCRIPTION", DbType.String) { Value = tt.TASKTYPEDESCRIPTION });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERNO", DbType.String) { Value = tt.CONTAINERNO });
                cmd.Parameters.Add(new SqlParameter("@SOURCEPLACE", DbType.String) { Value = tt.SOURCEPLACE });
                cmd.Parameters.Add(new SqlParameter("@TOPLACE", DbType.String) { Value = tt.TOPLACE });
                cmd.Parameters.Add(new SqlParameter("@ORDERDETAILSID", DbType.String) { Value = tt.ORDERDETAILSID });
                cmd.Parameters.Add(new SqlParameter("@ORDERHEADID", DbType.String) { Value = tt.ORDERHEADID });
                cmd.Parameters.Add(new SqlParameter("@SENDTIMES", DbType.Int32) { Value = tt.SENDTIMES });
                cmd.Parameters.Add(new SqlParameter("@RELEASESTATUS", DbType.String) { Value = tt.RELEASESTATUS });
                cmd.Parameters.Add(new SqlParameter("@HADFINISH", DbType.String) { Value = tt.HADFINISH });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@ISCURRENTTASK", DbType.String) { Value = tt.ISCURRENTTASK });
                cmd.Parameters.Add(new SqlParameter("@INPUTLOCATIONLEVEL", DbType.Int32) { Value = tt.INPUTLOCATIONLEVEL });
                cmd.Parameters.Add(new SqlParameter("@ISLASTTASK", DbType.String) { Value = tt.ISLASTTASK });
                cmd.Parameters.Add(new SqlParameter("@ISEMPTYCONTAINER", DbType.String) { Value = tt.ISEMPTYCONTAINER });
                cmd.Parameters.Add(new SqlParameter("@TASKID", DbType.String) { Value = tt.TASKID });
                foreach (SqlParameter p in cmd.Parameters)
                {
                    p.IsNullable = true;
                    if (p.Value == null)
                        p.Value = DBNull.Value;
                }
               DBHelper DBHelper_SqlServer = new DBLink();
                int val = DBHelper_SqlServer.ExecuteNonQuery(cmd);
                if (val > 0)
                { 
                    return true;
                }
                else 
                {
                    return false; 
                } 

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        /// <summary>
        /// 按任务号删除任务
        /// </summary>
        /// <param name="DevictID"></param>
        /// <returns></returns>
        public static bool DeleteOne(string TaskID)
        {
            int i = 0;
            string strCMD = "delete from OD_Task where TaskID='" + TaskID + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 根据堆垛机号获取未完成任务
        /// </summary>
        /// <param name="deviceIDNo"></param>
        /// <returns></returns>
        public static List<OD_Task> GetNotFinishedTask_by_deviceID(string deviceIDNo)
        {
            string getstr = string.Format("select * from od_task where DoDeviceID='" + deviceIDNo + "' and void=0 and  HadFinish='N' and ReleaseStatus<>'Y'  order by UPDATETIME asc ");

            return DoQuery(getstr);
        }

        /// <summary>
        /// 获取前100条入库指令
        /// </summary>
        /// <param name="deviceIDNo"></param>
        /// <returns></returns>
        public static List<OD_Task> GetInputTask_by_deviceID(string deviceIDNo)
        {
            string getstr = string.Format("select top 100  * from od_task where DoDeviceID='" + deviceIDNo + "' and void=0 and TaskType='SRM_Store_In' order by UPDATETIME desc ");

            return DoQuery(getstr);
        }
       
       
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<OD_Task> GetIntentionTask()
        {
           
            List<OD_Task> lst = new List<OD_Task>();
            string getstr = string.Format("select * from od_task where TaskStatus='In_Intention' order by UPDATETIME desc ");
            lst = DoQuery(getstr);
            return lst;
        }

        /// <summary>
        /// 废除上一次任务的有效性，当完成一个任务时，会先将以前的上一次任务（LastTask）作废，将刚刚完成的任务设置为最新上一次任务。
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        public static bool SetLastTaskVoidByDeviceID(string DeviceID)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update od_task set IsLastTask='N'  where DoDeviceID='"+DeviceID+"' and  IsLastTask='Y' and HadFinish='Y' ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add(new OracleParameter("@DeviceID",OracleDbType.NVarchar2,100) { Value = DeviceID });
               DBHelper DBHelper_SqlServer = new DBLink();
                int val = DBHelper_SqlServer.ExecuteNonQuery(cmd);

                if (val > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static OD_Task GetLastTaskByDeviceID(string DeviceID)
        {
            OD_Task t = new OD_Task();
            string getstr = string.Format("select * from od_task where DoDeviceID='" + DeviceID + "' and  IsCurrentTask='N' and IsLastTask='Y' and  HadFinish='N' order by UPDATETIME asc ");
            try
            {
                t = DoQuery(getstr)[0];
            }
            catch (Exception)
            {
                
            }
            return t;
        }

        public static OD_Task GetCurrentTaskByDeviceID(string DeviceID)
        {
            OD_Task t = new OD_Task();
            string getstr = string.Format("select * from od_task where DoDeviceID='" + DeviceID + "' and  IsCurrentTask='Y' and HadFinish='N' order by UPDATETIME desc ");
            try
            {
                t = DoQuery(getstr)[0];
            }
            catch (Exception)
            {

            }

            return t;
        }
    }
}