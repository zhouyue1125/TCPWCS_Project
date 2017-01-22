using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace WebServiceForASRS.DAL
{
    public class SQL_Da_PW_GROUP
    {
        private static List<PW_GROUP> DoQuery(string sql_str)
        {
            List<PW_GROUP> rtn = new List<PW_GROUP>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new PW_GROUP();
                        p.ID = DBHelper_SqlServer.GetDataValue<string>(dr, "ID");
                        p.GROUPNAME = DBHelper_SqlServer.GetDataValue<string>(dr, "GROUPNAME");
                        p.GROUPDESCRIBE = DBHelper_SqlServer.GetDataValue<string>(dr, "GROUPDESCRIBE");
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

        public static List<PW_GROUP> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  PW_GROUP ");
            return DoQuery(sb.ToString());
        }

        public static bool InsertNew(PW_GROUP t_new)
        {
           DBHelper DBHelper_SqlServer = new DBLink();
            try
            {
                PW_GROUP tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into PW_GROUP (  ");
                sb.Append("ID, ");
                sb.Append("GROUPNAME, ");
                sb.Append("GROUPDESCRIBE, ");
                sb.Append("STATUS )");
                sb.Append(" values ( ");
                sb.Append("@ID,");
                sb.Append("@GROUPNAME,");
                sb.Append("@GROUPDESCRIBE,");
                sb.Append(" @STATUS )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                cmd.Parameters.Add(new SqlParameter("@GROUPNAME", DbType.String) { Value = tt.GROUPNAME });
                cmd.Parameters.Add(new SqlParameter("@GROUPDESCRIBE", DbType.String) { Value = tt.GROUPDESCRIBE });
                cmd.Parameters.Add(new SqlParameter("@STATUS", DbType.String) { Value = tt.STATUS });
                foreach (SqlParameter p in cmd.Parameters)
                {
                    p.IsNullable = true;
                    if (p.Value == null)
                        p.Value = DBNull.Value;
                }
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

        public static bool UpdateOne(PW_GROUP t_new)
        {
           DBHelper DBHelper_SqlServer = new DBLink();
            try
            {
                PW_GROUP tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update PW_GROUP set ");
                sb.Append("GROUPNAME=@GROUPNAME, ");
                sb.Append("GROUPDESCRIBE=@GROUPDESCRIBE, ");
                sb.Append("STATUS=@STATUS ");

                sb.Append(" where ID=@ID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
              
                cmd.Parameters.Add(new SqlParameter("@GROUPNAME", DbType.String) { Value = tt.GROUPNAME });
                cmd.Parameters.Add(new SqlParameter("@GROUPDESCRIBE", DbType.String) { Value = tt.GROUPDESCRIBE });
                cmd.Parameters.Add(new SqlParameter("@STATUS", DbType.String) { Value = tt.STATUS });
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                foreach (SqlParameter p in cmd.Parameters)
                {
                    p.IsNullable = true;
                    if (p.Value == null)
                        p.Value = DBNull.Value;
                }
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
            string strCMD = "delete from PW_GROUP where ID='" + ID + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }
    }
}