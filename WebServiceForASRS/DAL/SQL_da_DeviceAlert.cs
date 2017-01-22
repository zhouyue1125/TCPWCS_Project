using System;
using System.Collections.Generic;
using DBEntity;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;


namespace WebServiceForASRS.DAL
{
    public class SQL_da_DeviceAlert
    {
        private static List<Device_Alert> DoQuery(string sql_str)
        {
            List<Device_Alert> rtn = new List<Device_Alert>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new Device_Alert();
                        #region 逐个赋值
                        p.ID = DBHelper_SqlServer.GetDataValue<string>(dr, "ID");
                        p.DEVICEID = DBHelper_SqlServer.GetDataValue<string>(dr, "DEVICEID");
                        p.ALERTID = DBHelper_SqlServer.GetDataValue<string>(dr, "ALERTID");
                        p.ALERTNAME = DBHelper_SqlServer.GetDataValue<string>(dr, "ALERTNAME");
                        p.CREATETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "CREATETIME");
                        p.FINISH_TIME = DBHelper_SqlServer.GetDataValue<string>(dr, "FINISH_TIME");
                        p.TIME_OF_DURATION = DBHelper_SqlServer.GetDataValue<string>(dr, "TIME_OF_DURATION");
                        p.SYSTEMFLAG = DBHelper_SqlServer.GetDataValue<string>(dr, "SYSTEMFLAG");
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
        /// 获取所有报警信息
        /// </summary>
        /// <returns></returns>
        public static List<Device_Alert> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  Device_Alert order by CREATETIME ");
            return DoQuery(sb.ToString());
        }

        /// <summary>
        /// 根据日期范围获取所有报警信息
        /// </summary>
        /// <returns></returns>
        public static List<Device_Alert> GetAllByDate(DateTime start,DateTime end,string deviceId)
        {
            string startTime = start.ToString("yyyy-MM-dd");
            string endTime = end.ToString("yyyy-MM-dd");
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  Device_Alert where  convert(varchar(10),Createtime,120) between '" + startTime + "' and '" + endTime + "' order by CREATETIME");
            return DoQuery(sb.ToString());
        }

        /// <summary>
        /// 根据ID获取报警信息
        /// </summary>
        /// <param name="alertId"></param>
        /// <returns></returns>
        public static Device_Alert GetAllByAlertID(string alertId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  Device_Alert where  ID='"+alertId+"' ");
            var rtn = DoQuery(sb.ToString());
            if (rtn != null && rtn.Count > 0)
            {
                return rtn[0];
            }
            else
                return null;
        }
        /// <summary>
        /// 获取最后一次未处理的报警信息
        /// </summary>
        /// <returns></returns>
        public static Device_Alert GetLastAlert()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select Top 1 * from  Device_Alert  Order by  CREATETIME desc");
            var rtn = DoQuery(sb.ToString());
            if (rtn != null && rtn.Count > 0)
            {
                return rtn[0];
            }
            else
                return null;
        }
        /// <summary>
        /// MES获取未读取过的报警信息
        /// </summary>
        /// <param name="alertId"></param>
        /// <returns></returns>
        public static List<Device_Alert> GetUnReadAlarms()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from Device_Alert where Finish_Time is not null and SYSTEMFLAG='0' ");
            var rtn = DoQuery(sb.ToString());
            return rtn;
        }
        /// <summary>
        /// 根据ID号修改FLAG
        /// </summary>
        /// <param name="alarmId">报警序列号</param>
        /// <param name="flag">标记值</param>
        /// <returns></returns>
        public static bool UpdateOneFlagByAlarmId(string alarmId,string flag)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" update DEVICE_ALERT set ");
            sb.Append("SYSTEMFLAG=:SYSTEMFLAG ");
            sb.Append(" where ID=:ID ");
            DbCommand cmd = new SqlCommand();
            cmd.CommandText = sb.ToString();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("SYSTEMFLAG", DbType.String) { Value = flag });
            cmd.Parameters.Add(new SqlParameter("ID", DbType.String) { Value = alarmId });
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
        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(Device_Alert t_new)
        {
            try
            {
                Device_Alert tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into DEVICE_ALERT (  ");
                sb.Append("ID, ");
                sb.Append("DEVICEID, ");
                sb.Append("ALERTID, ");
                sb.Append("ALERTNAME, ");
                sb.Append("CREATETIME, ");
                sb.Append("FINISH_TIME, ");
                sb.Append("TIME_OF_DURATION, ");
                sb.Append("SYSTEMFLAG )");
                sb.Append(" values ( ");
                sb.Append("@ID,");
                sb.Append("@DEVICEID,");
                sb.Append("@ALERTID,");
                sb.Append("@ALERTNAME,");
                sb.Append("@CREATETIME,");
                sb.Append("@FINISH_TIME,");
                sb.Append("@TIME_OF_DURATION,");
                sb.Append(" @SYSTEMFLAG )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                cmd.Parameters.Add(new SqlParameter("@DEVICEID", DbType.String) { Value = tt.DEVICEID });
                cmd.Parameters.Add(new SqlParameter("@ALERTID", DbType.String) { Value = tt.ALERTID });
                cmd.Parameters.Add(new SqlParameter("@ALERTNAME", DbType.String) { Value = tt.ALERTNAME });
                cmd.Parameters.Add(new SqlParameter("@CREATETIME", DbType.String) { Value = tt.CREATETIME });
                cmd.Parameters.Add(new SqlParameter("@FINISH_TIME", DbType.String) { Value = tt.FINISH_TIME });
                cmd.Parameters.Add(new SqlParameter("@TIME_OF_DURATION", DbType.String) { Value = tt.TIME_OF_DURATION });
                cmd.Parameters.Add(new SqlParameter("@SYSTEMFLAG", DbType.String) { Value = tt.SYSTEMFLAG });

                foreach (DbParameter p in cmd.Parameters)
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


        /// <summary>
        /// 更新某条数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool UpdateOne(Device_Alert t_new)
        {
            try
            {
                Device_Alert tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update DEVICE_ALERT set ");
                sb.Append("DEVICEID=@DEVICEID, ");
                sb.Append("ALERTID=@ALERTID, ");
                sb.Append("ALERTNAME=@ALERTNAME, ");
                sb.Append("CREATETIME=@CREATETIME, ");
                sb.Append("FINISH_TIME=@FINISH_TIME, ");
                sb.Append("TIME_OF_DURATION=@TIME_OF_DURATION, ");
                sb.Append("SYSTEMFLAG=@SYSTEMFLAG ");
                sb.Append(" where ID=@ID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@DEVICEID", DbType.String) { Value = tt.DEVICEID });
                cmd.Parameters.Add(new SqlParameter("@ALERTID", DbType.String) { Value = tt.ALERTID });
                cmd.Parameters.Add(new SqlParameter("@ALERTNAME", DbType.String) { Value = tt.ALERTNAME });
                cmd.Parameters.Add(new SqlParameter("@CREATETIME", DbType.String) { Value = tt.CREATETIME });
                cmd.Parameters.Add(new SqlParameter("@FINISH_TIME", DbType.String) { Value = tt.FINISH_TIME });
                cmd.Parameters.Add(new SqlParameter("@TIME_OF_DURATION", DbType.String) { Value = tt.TIME_OF_DURATION });
                cmd.Parameters.Add(new SqlParameter("@SYSTEMFLAG", DbType.String) { Value = tt.SYSTEMFLAG });
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                foreach (DbParameter p in cmd.Parameters)
                {
                    p.IsNullable = true;
                    if (p.Value == null)
                        p.Value = DBNull.Value;
                }
                DBHelper DBHelper_SqlServer = new DBLink();
                int val = DBHelper_SqlServer.ExecuteNonQuery(cmd);
                if (val > 0)
                { return true; }
                else { return false; } 


            }
            catch (Exception ex)
            {

                return false;
            }
        }

        /// <summary>
        /// 按ID号删除报警信息
        /// </summary>
        /// <param name="DevictID"></param>
        /// <returns></returns>
        public static bool DeleteOne(string ID)
        {
            int i = 0;
            string strCMD = "delete from Device_Alert where ID='" + ID + "'";
            DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }
    }
}