using System;
using System.Collections.Generic;
using DBEntity;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;


namespace WebServiceForASRS.DAL
{
    public class SQL_Da_PW_User
    {
        private static List<PW_User> DoQuery(string sql_str)
        {
            List<PW_User> rtn = new List<PW_User>();
           DBHelper DBHelper_SqlServer = new DBLink();
            try
            {
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new PW_User();
                        p.ID = DBHelper_SqlServer.GetDataValue<string>(dr, "ID");
                        p.USERNAME = DBHelper_SqlServer.GetDataValue<string>(dr, "USERNAME");
                        p.PASSWORD = DBHelper_SqlServer.GetDataValue<string>(dr, "PASSWORD");
                        p.USERGROUP = DBHelper_SqlServer.GetDataValue<string>(dr, "USERGROUP");
                        p.DEPARTMENT = DBHelper_SqlServer.GetDataValue<string>(dr, "DEPARTMENT");
                        p.UPDATETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATETIME");
                        p.PASSWORDUPDATETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "PASSWORDUPDATETIME");
                        p.PASSWORDEXPIRETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "PASSWORDEXPIRETIME");
                        p.LASTLOGINTIME = DBHelper_SqlServer.GetDataValue<string>(dr, "LASTLOGINTIME");
                        p.ISLOGININ = DBHelper_SqlServer.GetDataValue<string>(dr, "ISLOGININ");
                        p.HANDSHAKE = DBHelper_SqlServer.GetDataValue<string>(dr, "HANDSHAKE");
                        p.PW_BACKUP1 = DBHelper_SqlServer.GetDataValue<string>(dr, "PW_BACKUP1");
                        p.PW_BACKUP2 = DBHelper_SqlServer.GetDataValue<string>(dr, "PW_BACKUP2");
                        p.PW_BACKUP3 = DBHelper_SqlServer.GetDataValue<string>(dr, "PW_BACKUP3");
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
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public static List<PW_User> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  PW_User order by UserName ");
            return DoQuery(sb.ToString());
        }

     
        public static List<PW_User> GetAllByGroupName(string GroupName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  PW_User where USERGROUP='"+GroupName+"' order by UserName ");
            return DoQuery(sb.ToString());
        }

        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(PW_User t_new)
        {
            try
            {
                PW_User tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into PW_User (  ");
                sb.Append("ID, ");
                sb.Append("USERNAME, ");
                sb.Append("PASSWORD, ");
                sb.Append("USERGROUP, ");
                sb.Append("DEPARTMENT, ");
                sb.Append("UPDATETIME, ");
                sb.Append("PASSWORDUPDATETIME, ");
                sb.Append("PASSWORDEXPIRETIME, ");
                sb.Append("LASTLOGINTIME, ");
                sb.Append("ISLOGININ, ");
                sb.Append("HANDSHAKE, ");
                sb.Append("PW_BACKUP1, ");
                sb.Append("PW_BACKUP2, ");
                sb.Append("PW_BACKUP3 )");
                sb.Append(" values ( ");
                sb.Append("@ID,");
                sb.Append("@USERNAME,");
                sb.Append("@PASSWORD,");
                sb.Append("@USERGROUP,");
                sb.Append("@DEPARTMENT,");
                sb.Append("@UPDATETIME,");
                sb.Append("@PASSWORDUPDATETIME,");
                sb.Append("@PASSWORDEXPIRETIME,");
                sb.Append("@LASTLOGINTIME,");
                sb.Append("@ISLOGININ,");
                sb.Append("@HANDSHAKE,");
                sb.Append("@PW_BACKUP1,");
                sb.Append("@PW_BACKUP2,");
                sb.Append(" @PW_BACKUP3 )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                cmd.Parameters.Add(new SqlParameter("@USERNAME", DbType.String) { Value = tt.USERNAME });
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", DbType.String) { Value = tt.PASSWORD });
                cmd.Parameters.Add(new SqlParameter("@USERGROUP", DbType.String) { Value = tt.USERGROUP });
                cmd.Parameters.Add(new SqlParameter("@DEPARTMENT", DbType.String) { Value = tt.DEPARTMENT });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@PASSWORDUPDATETIME", DbType.String) { Value = tt.PASSWORDUPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@PASSWORDEXPIRETIME", DbType.String) { Value = tt.PASSWORDEXPIRETIME });
                cmd.Parameters.Add(new SqlParameter("@LASTLOGINTIME", DbType.String) { Value = tt.LASTLOGINTIME });
                cmd.Parameters.Add(new SqlParameter("@ISLOGININ", DbType.String) { Value = tt.ISLOGININ });
                cmd.Parameters.Add(new SqlParameter("@HANDSHAKE", DbType.String) { Value = tt.HANDSHAKE });
                cmd.Parameters.Add(new SqlParameter("@PW_BACKUP1", DbType.String) { Value = tt.PW_BACKUP1 });
                cmd.Parameters.Add(new SqlParameter("@PW_BACKUP2", DbType.String) { Value = tt.PW_BACKUP2 });
                cmd.Parameters.Add(new SqlParameter("@PW_BACKUP3", DbType.String) { Value = tt.PW_BACKUP3 });

                foreach (SqlParameter p in cmd.Parameters)
                {
                    p.IsNullable = true;
                    if (p.Value == null)
                        p.Value = DBNull.Value;
                }
                DBLink DBHelper_SqlServer = new DAL.DBLink();
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
        public static bool UpdateOne(PW_User t_new)
        {
            try
            {
                PW_User tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update PW_User set ");
                sb.Append("USERNAME=@USERNAME, ");
                sb.Append("PASSWORD=@PASSWORD, ");
                sb.Append("USERGROUP=@USERGROUP, ");
                sb.Append("DEPARTMENT=@DEPARTMENT, ");
                sb.Append("UPDATETIME=@UPDATETIME, ");
                sb.Append("PASSWORDUPDATETIME=@PASSWORDUPDATETIME, ");
                sb.Append("PASSWORDEXPIRETIME=@PASSWORDEXPIRETIME, ");
                sb.Append("LASTLOGINTIME=@LASTLOGINTIME, ");
                sb.Append("ISLOGININ=@ISLOGININ, ");
                sb.Append("HANDSHAKE=@HANDSHAKE, ");
                sb.Append("PW_BACKUP1=@PW_BACKUP1, ");
                sb.Append("PW_BACKUP2=@PW_BACKUP2, ");
                sb.Append("PW_BACKUP3=@PW_BACKUP3 ");

                sb.Append(" where ID=@ID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
               
                cmd.Parameters.Add(new SqlParameter("@USERNAME", DbType.String) { Value = tt.USERNAME });
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", DbType.String) { Value = tt.PASSWORD });
                cmd.Parameters.Add(new SqlParameter("@USERGROUP", DbType.String) { Value = tt.USERGROUP });
                cmd.Parameters.Add(new SqlParameter("@DEPARTMENT", DbType.String) { Value = tt.DEPARTMENT });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@PASSWORDUPDATETIME", DbType.String) { Value = tt.PASSWORDUPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@PASSWORDEXPIRETIME", DbType.String) { Value = tt.PASSWORDEXPIRETIME });
                cmd.Parameters.Add(new SqlParameter("@LASTLOGINTIME", DbType.String) { Value = tt.LASTLOGINTIME });
                cmd.Parameters.Add(new SqlParameter("@ISLOGININ", DbType.String) { Value = tt.ISLOGININ });
                cmd.Parameters.Add(new SqlParameter("@HANDSHAKE", DbType.String) { Value = tt.HANDSHAKE });
                cmd.Parameters.Add(new SqlParameter("@PW_BACKUP1", DbType.String) { Value = tt.PW_BACKUP1 });
                cmd.Parameters.Add(new SqlParameter("@PW_BACKUP2", DbType.String) { Value = tt.PW_BACKUP2 });
                cmd.Parameters.Add(new SqlParameter("@PW_BACKUP3", DbType.String) { Value = tt.PW_BACKUP3 });
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                foreach (SqlParameter p in cmd.Parameters)
                {
                    p.IsNullable = true;
                    if (p.Value == null)
                        p.Value = DBNull.Value;
                }
                DBLink DBHelper_SqlServer = new DAL.DBLink();
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
        /// 按UserID删除用户
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public static bool DeleteOne(string UserID)
        {
            int i = 0;
            string strCMD = "delete from PW_User where ID='" + UserID + "'";
            DBLink DBHelper_SqlServer = new DAL.DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 根据ID数组批量删除用户
        /// </summary>
        /// <param name="UserIDs"></param>
        /// <returns></returns>
        public static bool DeleteUsers(string UserIDs)
        {
            int i = 0;
            string[] userIDs = UserIDs.Split(';');
            string sqlPart = "";
            for (int num = 0; num < userIDs.Length; num++) {
                if (sqlPart != "")
                {
                    sqlPart += ",\'" + userIDs[num] + "\'";
                }
                else 
                {
                    sqlPart = "\'" + userIDs[num] + "\'";
                }
            }
            string strCMD = "delete from PW_User where ID in(" + sqlPart + ")";
            DBLink DBHelper_SqlServer = new DAL.DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }
        public static PW_User GetOneByEmpNo(string EmoNo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  PW_User where ID='"+EmoNo+"' order by UserName ");
            var rst = DoQuery(sb.ToString());
            if (rst.Count > 0)
                return rst[0];
            else
                return new PW_User();
        }
    }
}