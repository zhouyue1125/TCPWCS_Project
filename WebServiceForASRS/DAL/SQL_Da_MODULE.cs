using DBEntity;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace WebServiceForASRS.DAL
{
    public class SQL_Da_MODULE
    {
        private static List<MODULE> DoQuery(string sql_str)
        {
            List<MODULE> rtn = new List<MODULE>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new MODULE();
                        p.ID = DBHelper_SqlServer.GetDataValue<string>(dr, "ID");
                        p.MODULE_NAME = DBHelper_SqlServer.GetDataValue<string>(dr, "MODULE_NAME");
                        p.MODULE_DESCRIBE = DBHelper_SqlServer.GetDataValue<string>(dr, "MODULE_DESCRIBE");
                        p.TAGNAME = DBHelper_SqlServer.GetDataValue<string>(dr, "TAGNAME");
                        p.STATUS = DBHelper_SqlServer.GetDataValue<string>(dr, "STATUS");
                        rtn.Add(p);
                    }
                }
            }
            catch
            {
            }
            return rtn;
        }

        public static List<MODULE> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  MODULE order by ID");
            return DoQuery(sb.ToString());
        }

        public static bool InsertNew(MODULE t_new)
        {
            try
            {
                MODULE tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into MODULE (  ");
                sb.Append("ID, ");
                sb.Append("MODULE_NAME, ");
                sb.Append("MODULE_DESCRIBE, ");
                sb.Append("TAGNAME, ");
                sb.Append("STATUS )");
                sb.Append(" values ( ");
                sb.Append("@ID,");
                sb.Append("@MODULE_NAME,");
                sb.Append("@MODULE_DESCRIBE,");
                sb.Append("@TAGNAME,");
                sb.Append(" @STATUS )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                cmd.Parameters.Add(new SqlParameter("@MODULE_NAME", DbType.String) { Value = tt.MODULE_NAME });
                cmd.Parameters.Add(new SqlParameter("@MODULE_DESCRIBE", DbType.String) { Value = tt.MODULE_DESCRIBE });
                cmd.Parameters.Add(new SqlParameter("@TAGNAME", DbType.String) { Value = tt.TAGNAME });
                cmd.Parameters.Add(new SqlParameter("@STATUS", DbType.String) { Value = tt.STATUS });

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

        public static bool UpdateOne(MODULE t_new)
        {
            try
            {
                MODULE tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update MODULE set ");
                sb.Append("MODULE_NAME=@MODULE_NAME, ");
                sb.Append("MODULE_DESCRIBE=@MODULE_DESCRIBE, ");
                sb.Append("TAGNAME=@TAGNAME, ");
                sb.Append("STATUS=@STATUS ");

                sb.Append(" where ID=@ID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
               
                cmd.Parameters.Add(new SqlParameter("@MODULE_NAME", DbType.String) { Value = tt.MODULE_NAME });
                cmd.Parameters.Add(new SqlParameter("@MODULE_DESCRIBE", DbType.String) { Value = tt.MODULE_DESCRIBE });
                cmd.Parameters.Add(new SqlParameter("@TAGNAME", DbType.String) { Value = tt.TAGNAME });
                cmd.Parameters.Add(new SqlParameter("@STATUS", DbType.String) { Value = tt.STATUS });
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
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

        public static bool DeleteOne(string ID)
        {
            int i = 0;
            string strCMD = "delete from MODULE where ID='" + ID + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }

    }
}