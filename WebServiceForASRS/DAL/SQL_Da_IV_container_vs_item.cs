using System;
using System.Collections.Generic;
using DBEntity;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;


namespace WebServiceForASRS.DAL
{
    public class SQL_Da_IV_container_vs_item
    {
        private static List<IV_container_vs_item> DoQuery(string sql_str)
        {
            List<IV_container_vs_item> rtn = new List<IV_container_vs_item>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new IV_container_vs_item();
                        p.ID = DBHelper_SqlServer.GetDataValue<string>(dr, "ID");
                        p.CONTAINERID = DBHelper_SqlServer.GetDataValue<string>(dr, "CONTAINERID");
                        p.ITEMSKU = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEMSKU");
                        p.ITEMDESC = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEMDESC");
                        p.ITEMBATCHNO = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEMBATCHNO");
                        p.ITEMSTATUSNO = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEMSTATUSNO");
                        p.ITEMQTY = DBHelper_SqlServer.GetDataValue<decimal>(dr, "ITEMQTY");
                        p.OCC_QTY = DBHelper_SqlServer.GetDataValue<decimal>(dr, "OCC_QTY");
                        p.WITHORDER = DBHelper_SqlServer.GetDataValue<string>(dr, "WITHORDER");
                        p.UPDATETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATETIME");
                        p.UPDATEUSER = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATEUSER");
                        p.VOID = DBHelper_SqlServer.GetDataValue<int>(dr, "VOID");
                        p.EXPIREDAY = DBHelper_SqlServer.GetDataValue<string>(dr, "EXPIREDAY");
                        p.CVI_BACKUP1 = DBHelper_SqlServer.GetDataValue<string>(dr, "CVI_BACKUP1");
                        p.CVI_BACKUP2 = DBHelper_SqlServer.GetDataValue<string>(dr, "CVI_BACKUP2");
                        p.CVI_BACKUP3 = DBHelper_SqlServer.GetDataValue<string>(dr, "CVI_BACKUP3");

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
        /// 新增一个托盘物料关联信息
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(IV_container_vs_item t_new)
        {
            try
            {
                IV_container_vs_item tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into IV_container_vs_item (  ");
                sb.Append("ID, ");
                sb.Append("CONTAINERID, ");
                sb.Append("ITEMSKU, ");
                sb.Append("ITEMDESC, ");
                sb.Append("ITEMBATCHNO, ");
                sb.Append("ITEMSTATUSNO, ");
                sb.Append("ITEMQTY, ");
                sb.Append("OCC_QTY, ");
                sb.Append("WITHORDER, ");
                sb.Append("UPDATETIME, ");
                sb.Append("UPDATEUSER, ");
                sb.Append("VOID, ");
                sb.Append("EXPIREDAY, ");
                sb.Append("CVI_BACKUP1, ");
                sb.Append("CVI_BACKUP2, ");
                sb.Append("CVI_BACKUP3 )");
                sb.Append(" values ( ");
                sb.Append("@ID,");
                sb.Append("@CONTAINERID,");
                sb.Append("@ITEMSKU,");
                sb.Append("@ITEMDESC,");
                sb.Append("@ITEMBATCHNO,");
                sb.Append("@ITEMSTATUSNO,");
                sb.Append("@ITEMQTY,");
                sb.Append("@OCC_QTY,");
                sb.Append("@WITHORDER,");
                sb.Append("@UPDATETIME,");
                sb.Append("@UPDATEUSER,");
                sb.Append("@VOID,");
                sb.Append("@EXPIREDAY,");
                sb.Append("@CVI_BACKUP1,");
                sb.Append("@CVI_BACKUP2,");
                sb.Append(" @CVI_BACKUP3 )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERID", DbType.String) { Value = tt.CONTAINERID });
                cmd.Parameters.Add(new SqlParameter("@ITEMSKU", DbType.String) { Value = tt.ITEMSKU });
                cmd.Parameters.Add(new SqlParameter("@ITEMDESC", DbType.String) { Value = tt.ITEMDESC });
                cmd.Parameters.Add(new SqlParameter("@ITEMBATCHNO", DbType.String) { Value = tt.ITEMBATCHNO });
                cmd.Parameters.Add(new SqlParameter("@ITEMSTATUSNO", DbType.String) { Value = tt.ITEMSTATUSNO });
                cmd.Parameters.Add(new SqlParameter("@ITEMQTY", DbType.Decimal) { Value = tt.ITEMQTY });
                cmd.Parameters.Add(new SqlParameter("@OCC_QTY", DbType.Decimal) { Value = tt.OCC_QTY });
                cmd.Parameters.Add(new SqlParameter("@WITHORDER", DbType.String) { Value = tt.WITHORDER });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@EXPIREDAY", DbType.String) { Value = tt.EXPIREDAY });
                cmd.Parameters.Add(new SqlParameter("@CVI_BACKUP1", DbType.String) { Value = tt.CVI_BACKUP1 });
                cmd.Parameters.Add(new SqlParameter("@CVI_BACKUP2", DbType.String) { Value = tt.CVI_BACKUP2 });
                cmd.Parameters.Add(new SqlParameter("@CVI_BACKUP3", DbType.String) { Value = tt.CVI_BACKUP3 });

                foreach (SqlParameter p in cmd.Parameters)
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
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一个托盘物料关联的信息
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool UpdateOne(IV_container_vs_item t_new)
        {
            try
            {
                IV_container_vs_item tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update IV_container_vs_item set ");
                sb.Append("CONTAINERID=@CONTAINERID, ");
                sb.Append("ITEMSKU=@ITEMSKU, ");
                sb.Append("ITEMDESC=@ITEMDESC, ");
                sb.Append("ITEMBATCHNO=@ITEMBATCHNO, ");
                sb.Append("ITEMSTATUSNO=@ITEMSTATUSNO, ");
                sb.Append("ITEMQTY=@ITEMQTY, ");
                sb.Append("OCC_QTY=@OCC_QTY, ");
                sb.Append("WITHORDER=@WITHORDER, ");
                sb.Append("UPDATETIME=@UPDATETIME, ");
                sb.Append("UPDATEUSER=@UPDATEUSER, ");
                sb.Append("VOID=@VOID, ");
                sb.Append("EXPIREDAY=@EXPIREDAY, ");
                sb.Append("CVI_BACKUP1=@CVI_BACKUP1, ");
                sb.Append("CVI_BACKUP2=@CVI_BACKUP2, ");
                sb.Append("CVI_BACKUP3=@CVI_BACKUP3 ");

                sb.Append(" where ID=@ID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
              
                cmd.Parameters.Add(new SqlParameter("@CONTAINERID", DbType.String) { Value = tt.CONTAINERID });
                cmd.Parameters.Add(new SqlParameter("@ITEMSKU", DbType.String) { Value = tt.ITEMSKU });
                cmd.Parameters.Add(new SqlParameter("@ITEMDESC", DbType.String) { Value = tt.ITEMDESC });
                cmd.Parameters.Add(new SqlParameter("@ITEMBATCHNO", DbType.String) { Value = tt.ITEMBATCHNO });
                cmd.Parameters.Add(new SqlParameter("@ITEMSTATUSNO", DbType.String) { Value = tt.ITEMSTATUSNO });
                cmd.Parameters.Add(new SqlParameter("@ITEMQTY", DbType.Decimal) { Value = tt.ITEMQTY });
                cmd.Parameters.Add(new SqlParameter("@OCC_QTY", DbType.Decimal) { Value = tt.OCC_QTY });
                cmd.Parameters.Add(new SqlParameter("@WITHORDER", DbType.String) { Value = tt.WITHORDER });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@EXPIREDAY", DbType.String) { Value = tt.EXPIREDAY });
                cmd.Parameters.Add(new SqlParameter("@CVI_BACKUP1", DbType.String) { Value = tt.CVI_BACKUP1 });
                cmd.Parameters.Add(new SqlParameter("@CVI_BACKUP2", DbType.String) { Value = tt.CVI_BACKUP2 });
                cmd.Parameters.Add(new SqlParameter("@CVI_BACKUP3", DbType.String) { Value = tt.CVI_BACKUP3 });
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

        /// <summary>
        /// 删除一个托盘物料关联
        /// </summary>
        /// <param name="ContainerID"></param>
        /// <returns></returns>
        public static bool DeleteOneByContainerID(string ContainerID)
        {
            int i = 0;
            string strCMD = "delete from IV_container_vs_item where CONTAINERID='" + ContainerID + "'";
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
                if (i > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {                
              return false;
            }
        }

        /// <summary>
        /// 根据库位号查找库存物资
        /// </summary>
        /// <param name="placeID"></param>
        /// <returns></returns>
        public static List<IV_container_vs_item> GetItemsByPlaceID(string placeID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from IV_container_vs_item a");
            sb.Append(" where exists (select ContainerID from IV_place_vs_container b");
            sb.Append(" where PlaceID='" + placeID + "' and a.ContainerID=b.ContainerID)");
            return DoQuery(sb.ToString());
        }

        public static List<IV_container_vs_item> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from IV_container_vs_item ");
          
            return DoQuery(sb.ToString());
        }

        public static bool DeleteByCI_ID(string CI_ID)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("delete from iv_container_vs_item  ");
                sb.Append(" where CI_ID ='"+CI_ID+"' ");
               DBHelper DBHelper_SqlServer = new DBLink();
                int val = DBHelper_SqlServer.ExecuteNonQuery(sb.ToString());
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
        /// 查看容器是否为空，（在当前库存里查找）
        /// </summary>
        /// <param name="containerID"></param>
        /// <param name="SKUCheck"></param>
        /// <returns>为空返回true,不为空返回false</returns>
        public static bool CheckContainerIsEmpty(string containerID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from iv_container_vs_item where void =0  and ContainerID='" + containerID + "' ");
            List<IV_container_vs_item> lisCI = DoQuery(sb.ToString());
            if (lisCI.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<IV_container_vs_item> GetItemsByContainerID(string containerID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from iv_container_vs_item where void =0 and  ContainerID='" + containerID + "' ");
            return DoQuery(sb.ToString());
        }

        public static List<IV_container_vs_item> GetItemsByProductID(string productID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from iv_container_vs_item aa where aa.void =0 and aa.ITEMSKU  like '%"+productID+"%'");
            return DoQuery(sb.ToString());
        }
    }
}