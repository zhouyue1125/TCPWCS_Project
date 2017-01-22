using System;
using System.Collections.Generic;
using DBEntity;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;


namespace WebServiceForASRS.DAL
{
    public class SQL_da_DU_Device
    {
        private static List<DU_Device> DoQuery(string sql_str)
        {
            List<DU_Device> rtn = new List<DU_Device>();
            try
            {
                DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new DU_Device();
                        #region 逐个赋值
                        p.DEVICEID = DBHelper_SqlServer.GetDataValue<string>(dr, "DEVICEID");
                        p.DEVICENODEID = DBHelper_SqlServer.GetDataValue<string>(dr, "DEVICENODEID");
                        p.DEVICESERVICEID = DBHelper_SqlServer.GetDataValue<string>(dr, "DEVICESERVICEID");
                        p.DEVICENAME = DBHelper_SqlServer.GetDataValue<string>(dr, "DEVICENAME");
                        p.DEVICETYPE = DBHelper_SqlServer.GetDataValue<string>(dr, "DEVICETYPE");
                        p.VOID = DBHelper_SqlServer.GetDataValue<int>(dr, "VOID");
                        p.WAREHOUSENO = DBHelper_SqlServer.GetDataValue<string>(dr, "WAREHOUSENO");
                        p.AISLE = DBHelper_SqlServer.GetDataValue<string>(dr, "AISLE");
                        p.LINE = DBHelper_SqlServer.GetDataValue<string>(dr, "LINE");
                        p.SERVERIPADDRESS = DBHelper_SqlServer.GetDataValue<string>(dr, "SERVERIPADDRESS");
                        p.SERVERPORTNO = DBHelper_SqlServer.GetDataValue<string>(dr, "SERVERPORTNO");
                        p.IPADDRESS = DBHelper_SqlServer.GetDataValue<string>(dr, "IPADDRESS");
                        p.PORTNO = DBHelper_SqlServer.GetDataValue<int>(dr, "PORTNO");
                        p.SOCKETTYPE = DBHelper_SqlServer.GetDataValue<string>(dr, "SOCKETTYPE");
                        p.LOCALIPADDRESS = DBHelper_SqlServer.GetDataValue<string>(dr, "LOCALIPADDRESS");
                        p.LOCALPORTNO = DBHelper_SqlServer.GetDataValue<int>(dr, "LOCALPORTNO");
                        p.REMOTEIPADDRESS = DBHelper_SqlServer.GetDataValue<string>(dr, "REMOTEIPADDRESS");
                        p.REMOTEPORTNO = DBHelper_SqlServer.GetDataValue<int>(dr, "REMOTEPORTNO");
                        p.ISONLINE = DBHelper_SqlServer.GetDataValue<int>(dr, "ISONLINE");
                        p.WORKINGSTATUS = DBHelper_SqlServer.GetDataValue<string>(dr, "WORKINGSTATUS");

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
        /// 获取所有设备
        /// </summary>
        /// <returns></returns>
        public static List<DU_Device> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  DU_Device ");
            return DoQuery(sb.ToString());
        }
        /// <summary>
        /// 根据设备号获取设备信息
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        public static DU_Device GetOneByDeviceID(string DeviceID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from DU_Device where DEVICEID='"+DeviceID+"'");
                return DoQuery(sb.ToString())[0];
        }

        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(DU_Device t_new)
        {
            try
            {
                DU_Device tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into DU_Device (  ");
                sb.Append("DEVICEID, ");
                sb.Append("DEVICENODEID, ");
                sb.Append("DEVICESERVICEID, ");
                sb.Append("DEVICENAME, ");
                sb.Append("DEVICETYPE, ");
                sb.Append("VOID, ");
                sb.Append("WAREHOUSENO, ");
                sb.Append("AISLE, ");
                sb.Append("LINE, ");
                sb.Append("SERVERIPADDRESS, ");
                sb.Append("SERVERPORTNO, ");
                sb.Append("IPADDRESS, ");
                sb.Append("PORTNO, ");
                sb.Append("SOCKETTYPE, ");
                sb.Append("LOCALIPADDRESS, ");
                sb.Append("LOCALPORTNO, ");
                sb.Append("REMOTEIPADDRESS, ");
                sb.Append("REMOTEPORTNO, ");
                sb.Append("ISONLINE, ");
                sb.Append("WORKINGSTATUS )");
                sb.Append(" values ( ");
                sb.Append("@DEVICEID,");
                sb.Append("@DEVICENODEID,");
                sb.Append("@DEVICESERVICEID,");
                sb.Append("@DEVICENAME,");
                sb.Append("@DEVICETYPE,");
                sb.Append("@VOID,");
                sb.Append("@WAREHOUSENO,");
                sb.Append("@AISLE,");
                sb.Append("@LINE,");
                sb.Append("@SERVERIPADDRESS,");
                sb.Append("@SERVERPORTNO,");
                sb.Append("@IPADDRESS,");
                sb.Append("@PORTNO,");
                sb.Append("@SOCKETTYPE,");
                sb.Append("@LOCALIPADDRESS,");
                sb.Append("@LOCALPORTNO,");
                sb.Append("@REMOTEIPADDRESS,");
                sb.Append("@REMOTEPORTNO,");
                sb.Append("@ISONLINE,");
                sb.Append(" @WORKINGSTATUS )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@DEVICEID", DbType.String) { Value = tt.DEVICEID });
                cmd.Parameters.Add(new SqlParameter("@DEVICENODEID", DbType.String) { Value = tt.DEVICENODEID });
                cmd.Parameters.Add(new SqlParameter("@DEVICESERVICEID", DbType.String) { Value = tt.DEVICESERVICEID });
                cmd.Parameters.Add(new SqlParameter("@DEVICENAME", DbType.String) { Value = tt.DEVICENAME });
                cmd.Parameters.Add(new SqlParameter("@DEVICETYPE", DbType.String) { Value = tt.DEVICETYPE });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@AISLE", DbType.String) { Value = tt.AISLE });
                cmd.Parameters.Add(new SqlParameter("@LINE", DbType.String) { Value = tt.LINE });
                cmd.Parameters.Add(new SqlParameter("@SERVERIPADDRESS", DbType.String) { Value = tt.SERVERIPADDRESS });
                cmd.Parameters.Add(new SqlParameter("@SERVERPORTNO", DbType.String) { Value = tt.SERVERPORTNO });
                cmd.Parameters.Add(new SqlParameter("@IPADDRESS", DbType.String) { Value = tt.IPADDRESS });
                cmd.Parameters.Add(new SqlParameter("@PORTNO", DbType.Int32) { Value = tt.PORTNO });
                cmd.Parameters.Add(new SqlParameter("@SOCKETTYPE", DbType.String) { Value = tt.SOCKETTYPE });
                cmd.Parameters.Add(new SqlParameter("@LOCALIPADDRESS", DbType.String) { Value = tt.LOCALIPADDRESS });
                cmd.Parameters.Add(new SqlParameter("@LOCALPORTNO", DbType.Int32) { Value = tt.LOCALPORTNO });
                cmd.Parameters.Add(new SqlParameter("@REMOTEIPADDRESS", DbType.String) { Value = tt.REMOTEIPADDRESS });
                cmd.Parameters.Add(new SqlParameter("@REMOTEPORTNO", DbType.Int32) { Value = tt.REMOTEPORTNO });
                cmd.Parameters.Add(new SqlParameter("@ISONLINE", DbType.Int32) { Value = tt.ISONLINE });
                cmd.Parameters.Add(new SqlParameter("@WORKINGSTATUS", DbType.String) { Value = tt.WORKINGSTATUS });

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
        public static bool UpdateOne(DU_Device t_new)
        {
            try
            {
                DU_Device tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update DU_Device set ");
                sb.Append("DEVICENODEID=@DEVICENODEID, ");
                sb.Append("DEVICESERVICEID=@DEVICESERVICEID, ");
                sb.Append("DEVICENAME=@DEVICENAME, ");
                sb.Append("DEVICETYPE=@DEVICETYPE, ");
                sb.Append("VOID=@VOID, ");
                sb.Append("WAREHOUSENO=@WAREHOUSENO, ");
                sb.Append("AISLE=@AISLE, ");
                sb.Append("LINE=@LINE, ");
                sb.Append("SERVERIPADDRESS=@SERVERIPADDRESS, ");
                sb.Append("SERVERPORTNO=@SERVERPORTNO, ");
                sb.Append("IPADDRESS=@IPADDRESS, ");
                sb.Append("PORTNO=@PORTNO, ");
                sb.Append("SOCKETTYPE=@SOCKETTYPE, ");
                sb.Append("LOCALIPADDRESS=@LOCALIPADDRESS, ");
                sb.Append("LOCALPORTNO=@LOCALPORTNO, ");
                sb.Append("REMOTEIPADDRESS=@REMOTEIPADDRESS, ");
                sb.Append("REMOTEPORTNO=@REMOTEPORTNO, ");
                sb.Append("ISONLINE=@ISONLINE, ");
                sb.Append("WORKINGSTATUS=@WORKINGSTATUS ");

                sb.Append(" where DEVICEID=@DEVICEID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
              
                cmd.Parameters.Add(new SqlParameter("@DEVICENODEID", DbType.String) { Value = tt.DEVICENODEID });
                cmd.Parameters.Add(new SqlParameter("@DEVICESERVICEID", DbType.String) { Value = tt.DEVICESERVICEID });
                cmd.Parameters.Add(new SqlParameter("@DEVICENAME", DbType.String) { Value = tt.DEVICENAME });
                cmd.Parameters.Add(new SqlParameter("@DEVICETYPE", DbType.String) { Value = tt.DEVICETYPE });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@AISLE", DbType.String) { Value = tt.AISLE });
                cmd.Parameters.Add(new SqlParameter("@LINE", DbType.String) { Value = tt.LINE });
                cmd.Parameters.Add(new SqlParameter("@SERVERIPADDRESS", DbType.String) { Value = tt.SERVERIPADDRESS });
                cmd.Parameters.Add(new SqlParameter("@SERVERPORTNO", DbType.String) { Value = tt.SERVERPORTNO });
                cmd.Parameters.Add(new SqlParameter("@IPADDRESS", DbType.String) { Value = tt.IPADDRESS });
                cmd.Parameters.Add(new SqlParameter("@PORTNO", DbType.Int32) { Value = tt.PORTNO });
                cmd.Parameters.Add(new SqlParameter("@SOCKETTYPE", DbType.String) { Value = tt.SOCKETTYPE });
                cmd.Parameters.Add(new SqlParameter("@LOCALIPADDRESS", DbType.String) { Value = tt.LOCALIPADDRESS });
                cmd.Parameters.Add(new SqlParameter("@LOCALPORTNO", DbType.Int32) { Value = tt.LOCALPORTNO });
                cmd.Parameters.Add(new SqlParameter("@REMOTEIPADDRESS", DbType.String) { Value = tt.REMOTEIPADDRESS });
                cmd.Parameters.Add(new SqlParameter("@REMOTEPORTNO", DbType.Int32) { Value = tt.REMOTEPORTNO });
                cmd.Parameters.Add(new SqlParameter("@ISONLINE", DbType.Int32) { Value = tt.ISONLINE });
                cmd.Parameters.Add(new SqlParameter("@WORKINGSTATUS", DbType.String) { Value = tt.WORKINGSTATUS });
                cmd.Parameters.Add(new SqlParameter("@DEVICEID", DbType.String) { Value = tt.DEVICEID });
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
            catch (Exception ex)
            {

                return false;
            }
        }

        /// <summary>
        /// 按设备号删除设备
        /// </summary>
        /// <param name="DevictID"></param>
        /// <returns></returns>
        public static bool DeleteOne(string DevictID)
        {
            int i = 0;
            string strCMD = "delete from DU_Device where DeviceID='" + DevictID + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }

      

    }
}