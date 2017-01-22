using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace WebServiceForASRS.DAL
{
    public class SQL_Da_MODULE_VS_GROUP
    {
        private static List<MODULE_VS_GROUP> DoQuery(string sql_str)
        {
            List<MODULE_VS_GROUP> rtn = new List<MODULE_VS_GROUP>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new MODULE_VS_GROUP();
                        p.ID = DBHelper_SqlServer.GetDataValue<string>(dr, "ID");
                        p.GROUP_NAME = DBHelper_SqlServer.GetDataValue<string>(dr, "GROUP_NAME");
                        p.GROUP_DESC = DBHelper_SqlServer.GetDataValue<string>(dr, "GROUP_DESC");
                        p.MODULE_ID = DBHelper_SqlServer.GetDataValue<string>(dr, "MODULE_ID");
                        p.MODULE_NAME = DBHelper_SqlServer.GetDataValue<string>(dr, "MODULE_NAME");
                        rtn.Add(p);
                    }
                }
            }
            catch
            {
            }
            return rtn;
        }

        public static List<MODULE_VS_GROUP> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  MODULE_VS_GROUP ");
            return DoQuery(sb.ToString());
        }

        public static List<MODULE_VS_GROUP> GetAllByGroupName(string GroupName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  MODULE_VS_GROUP where GROUP_NAME='" + GroupName + "'");
            return DoQuery(sb.ToString());
        }

        public static bool InsertNew(MODULE_VS_GROUP t_new)
        {
            try
            {
                MODULE_VS_GROUP tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into MODULE_VS_GROUP (  ");
                sb.Append("ID, ");
                sb.Append("GROUP_NAME, ");
                sb.Append("GROUP_DESC, ");
                sb.Append("MODULE_ID, ");
                sb.Append("MODULE_NAME )");
                sb.Append(" values ( ");
                sb.Append("@ID,");
                sb.Append("@GROUP_NAME,");
                sb.Append("@GROUP_DESC,");
                sb.Append("@MODULE_ID,");
                sb.Append(" @MODULE_NAME )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                cmd.Parameters.Add(new SqlParameter("@GROUP_NAME", DbType.String) { Value = tt.GROUP_NAME });
                cmd.Parameters.Add(new SqlParameter("@GROUP_DESC", DbType.String) { Value = tt.GROUP_DESC });
                cmd.Parameters.Add(new SqlParameter("@MODULE_ID", DbType.String) { Value = tt.MODULE_ID });
                cmd.Parameters.Add(new SqlParameter("@MODULE_NAME", DbType.String) { Value = tt.MODULE_NAME });

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

        public static bool UpdateOne(MODULE_VS_GROUP t_new)
        {
            try
            {
                MODULE_VS_GROUP tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update MODULE_VS_GROUP set ");
                sb.Append("GROUP_NAME=@GROUP_NAME, ");
                sb.Append("GROUP_DESC=@GROUP_DESC, ");
                sb.Append("MODULE_ID=@MODULE_ID, ");
                sb.Append("MODULE_NAME=@MODULE_NAME ");

                sb.Append(" where ID=@ID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
              
                cmd.Parameters.Add(new SqlParameter("@GROUP_NAME", DbType.String) { Value = tt.GROUP_NAME });
                cmd.Parameters.Add(new SqlParameter("@GROUP_DESC", DbType.String) { Value = tt.GROUP_DESC });
                cmd.Parameters.Add(new SqlParameter("@MODULE_ID", DbType.String) { Value = tt.MODULE_ID });
                cmd.Parameters.Add(new SqlParameter("@MODULE_NAME", DbType.String) { Value = tt.MODULE_NAME });
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
            string strCMD = "delete from MODULE_VS_GROUP where ID='" + ID + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }
    }
}