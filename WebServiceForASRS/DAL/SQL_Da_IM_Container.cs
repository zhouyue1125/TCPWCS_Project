using System;
using System.Collections.Generic;
using DBEntity;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;


namespace WebServiceForASRS.DAL
{
    public class SQL_Da_IM_Container
    {
        private static List<IM_Container> DoQuery(string sql_str)
        {
            List<IM_Container> rtn = new List<IM_Container>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new IM_Container();
                        p.CONTAINERID = DBHelper_SqlServer.GetDataValue<string>(dr, "CONTAINERID");
                        p.CONTAINERDESC = DBHelper_SqlServer.GetDataValue<string>(dr, "CONTAINERDESC");
                        p.CONTAINERTYPE = DBHelper_SqlServer.GetDataValue<string>(dr, "CONTAINERTYPE");
                        p.LENGTH = DBHelper_SqlServer.GetDataValue<decimal>(dr, "LENGTH");
                        p.WIDTH = DBHelper_SqlServer.GetDataValue<decimal>(dr, "WIDTH");
                        p.HEIGHT = DBHelper_SqlServer.GetDataValue<decimal>(dr, "HEIGHT");
                        p.MAXWEIGHT = DBHelper_SqlServer.GetDataValue<decimal>(dr, "MAXWEIGHT");
                        p.VOID = DBHelper_SqlServer.GetDataValue<int>(dr, "VOID");
                        p.STATUS = DBHelper_SqlServer.GetDataValue<int>(dr, "STATUS");
                        p.WAREHOUSENO = DBHelper_SqlServer.GetDataValue<string>(dr, "WAREHOUSENO");
                        p.ONLINEMODEL = DBHelper_SqlServer.GetDataValue<string>(dr, "ONLINEMODEL");
                        p.UPDATETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATETIME");
                        p.UPDATEUSER = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATEUSER");

                        rtn.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            return rtn;
        }

        /// <summary>
        /// 获取所有托盘
        /// </summary>
        /// <returns></returns>
        public static List<IM_Container> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  IM_Container order by ContainerID ");
            return DoQuery(sb.ToString());
        }

        /// <summary>
        /// 获取未被绑定的托盘
        /// </summary>
        /// <returns></returns>
        public static List<IM_Container> GetUnBindingedContainer()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  IM_Container where ContainerID not in(select BINDINGCONTAINER from IM_ITEM) order by ContainerID ");
            return DoQuery(sb.ToString());
        }

        /// <summary>
        /// 新增一个托盘信息
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(IM_Container t_new)
        {
            try
            {
                IM_Container tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into IM_Container (  ");
                sb.Append("CONTAINERID, ");
                sb.Append("CONTAINERDESC, ");
                sb.Append("CONTAINERTYPE, ");
                sb.Append("LENGTH, ");
                sb.Append("WIDTH, ");
                sb.Append("HEIGHT, ");
                sb.Append("MAXWEIGHT, ");
                sb.Append("VOID, ");
                sb.Append("STATUS, ");
                sb.Append("WAREHOUSENO, ");
                sb.Append("ONLINEMODEL, ");
                sb.Append("UPDATETIME, ");
                sb.Append("UPDATEUSER )");
                sb.Append(" values ( ");
                sb.Append("@CONTAINERID,");
                sb.Append("@CONTAINERDESC,");
                sb.Append("@CONTAINERTYPE,");
                sb.Append("@LENGTH,");
                sb.Append("@WIDTH,");
                sb.Append("@HEIGHT,");
                sb.Append("@MAXWEIGHT,");
                sb.Append("@VOID,");
                sb.Append("@STATUS,");
                sb.Append("@WAREHOUSENO,");
                sb.Append("@ONLINEMODEL,");
                sb.Append("@UPDATETIME,");
                sb.Append(" @UPDATEUSER )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@CONTAINERID", DbType.String) { Value = tt.CONTAINERID });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERDESC", DbType.String) { Value = tt.CONTAINERDESC });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERTYPE", DbType.String) { Value = tt.CONTAINERTYPE });
                cmd.Parameters.Add(new SqlParameter("@LENGTH", DbType.Decimal) { Value = tt.LENGTH });
                cmd.Parameters.Add(new SqlParameter("@WIDTH", DbType.Decimal) { Value = tt.WIDTH });
                cmd.Parameters.Add(new SqlParameter("@HEIGHT", DbType.Decimal) { Value = tt.HEIGHT });
                cmd.Parameters.Add(new SqlParameter("@MAXWEIGHT", DbType.Decimal) { Value = tt.MAXWEIGHT });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@STATUS", DbType.Int32) { Value = tt.STATUS });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@ONLINEMODEL", DbType.String) { Value = tt.ONLINEMODEL });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });

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

        /// <summary>
        /// 更新一个托盘的信息
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool UpdateOne(IM_Container t_new)
        {
            try
            {
                IM_Container tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update IM_Container set ");
                sb.Append("CONTAINERDESC=@CONTAINERDESC, ");
                sb.Append("CONTAINERTYPE=@CONTAINERTYPE, ");
                sb.Append("LENGTH=@LENGTH, ");
                sb.Append("WIDTH=@WIDTH, ");
                sb.Append("HEIGHT=@HEIGHT, ");
                sb.Append("MAXWEIGHT=@MAXWEIGHT, ");
                sb.Append("VOID=@VOID, ");
                sb.Append("STATUS=@STATUS, ");
                sb.Append("WAREHOUSENO=@WAREHOUSENO, ");
                sb.Append("ONLINEMODEL=@ONLINEMODEL, ");
                sb.Append("UPDATETIME=@UPDATETIME, ");
                sb.Append("UPDATEUSER=@UPDATEUSER ");

                sb.Append(" where CONTAINERID=@CONTAINERID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
              
                cmd.Parameters.Add(new SqlParameter("@CONTAINERDESC", DbType.String) { Value = tt.CONTAINERDESC });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERTYPE", DbType.String) { Value = tt.CONTAINERTYPE });
                cmd.Parameters.Add(new SqlParameter("@LENGTH", DbType.Decimal) { Value = tt.LENGTH });
                cmd.Parameters.Add(new SqlParameter("@WIDTH", DbType.Decimal) { Value = tt.WIDTH });
                cmd.Parameters.Add(new SqlParameter("@HEIGHT", DbType.Decimal) { Value = tt.HEIGHT });
                cmd.Parameters.Add(new SqlParameter("@MAXWEIGHT", DbType.Decimal) { Value = tt.MAXWEIGHT });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@STATUS", DbType.Int32) { Value = tt.STATUS });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@ONLINEMODEL", DbType.String) { Value = tt.ONLINEMODEL });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERID", DbType.String) { Value = tt.CONTAINERID });
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
        /// 删除一个托盘
        /// </summary>
        /// <param name="ContainerID"></param>
        /// <returns></returns>
        public static bool DeleteOne(string ContainerID)
        {
            int i = 0;
            string strCMD = "delete from IM_Container where ContainerID='" + ContainerID + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }

        public static IM_Container GetOneByContainerId(string containerid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  IM_Container where ContainerID='" + containerid + "' ");
            var rst = DoQuery(sb.ToString());
            if (rst.Count > 0)
                return rst[0];
            else
                return null;
        }

    }
}