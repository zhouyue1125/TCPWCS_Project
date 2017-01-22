using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Data.Common;

namespace WebServiceForASRS.DAL
{
    public class SQL_Da_IV_place_vs_container
    {

        private static List<IV_place_vs_container> DoQuery(string sql_str)
        {
            List<IV_place_vs_container> rtn = new List<IV_place_vs_container>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {                    
                    while (dr.Read())
                    {
                        var p = new IV_place_vs_container();
                        #region 逐个赋值
                        p.ID = DBHelper_SqlServer.GetDataValue<string>(dr, "ID");
                        p.WAREHOUSENO = DBHelper_SqlServer.GetDataValue<string>(dr, "WAREHOUSENO");
                        p.PLACEID = DBHelper_SqlServer.GetDataValue<string>(dr, "PLACEID");
                        p.CONTAINERID = DBHelper_SqlServer.GetDataValue<string>(dr, "CONTAINERID");
                        p.UPDATETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATETIME");
                        p.UPDATEUSER = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATEUSER");
                        p.VOID = DBHelper_SqlServer.GetDataValue<int>(dr, "VOID");
                        p.ISEMPTYCONTAINER = DBHelper_SqlServer.GetDataValue<string>(dr, "ISEMPTYCONTAINER");
                        p.ISEMPTYPLACE = DBHelper_SqlServer.GetDataValue<string>(dr, "ISEMPTYPLACE");
                        p.PVC_BACKUP1 = DBHelper_SqlServer.GetDataValue<string>(dr, "PVC_BACKUP1");
                        p.PVC_BACKUP2 = DBHelper_SqlServer.GetDataValue<string>(dr, "PVC_BACKUP2");
                        p.PVC_BACKUP3 = DBHelper_SqlServer.GetDataValue<string>(dr, "PVC_BACKUP3");

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
        /// 获取所有库位和托盘的关联
        /// </summary>
        /// <returns></returns>
        public static List<IV_place_vs_container> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  IV_PLACE_VS_CONTAINER ");
            return DoQuery(sb.ToString());
           
        }

        /// <summary>
        /// 获取有货库位
        /// </summary>
        /// <returns></returns>
        public static List<IV_place_vs_container> GetStoredInfo()
        {
            string getstr = "";
            List<IV_place_vs_container> StoredPlace = new List<IV_place_vs_container>();
            StringBuilder sb = new StringBuilder();
          
            sb.Append(" select pvc.* from iv_place_vs_container pvc ");
            sb.Append(" join PL_PLACE p on p.PLACEID=pvc.PLACEID");
            sb.Append(" where P.Islock=0 and Pvc.Isemptycontainer=0");
            getstr = sb.ToString();
            StoredPlace = DoQuery(sb.ToString());
            return StoredPlace;
        }
        /// <summary>
        /// 获取空托盘所在库位
        /// </summary>
        /// <returns></returns>
        public static List<IV_place_vs_container> GetPlaceOfEmptyContainer()
        {
            string getstr = "";
            StringBuilder sb = new StringBuilder();
            sb.Append(" select pvc.* from iv_place_vs_container pvc ");
            sb.Append(" join PL_PLACE p on p.PLACEID=pvc.PLACEID");
            sb.Append(" where P.Islock=0 and Pvc.Isemptycontainer=1");
            getstr = sb.ToString();

            return DoQuery(getstr);
        }
        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(IV_place_vs_container t_new)
        {
            try
            {
                var tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into IV_place_vs_container (  ");
                sb.Append("ID, ");
                sb.Append("WAREHOUSENO, ");
                sb.Append("PLACEID, ");
                sb.Append("CONTAINERID, ");
                sb.Append("UPDATETIME, ");
                sb.Append("UPDATEUSER, ");
                sb.Append("VOID, ");
                sb.Append("ISEMPTYCONTAINER, ");
                sb.Append("ISEMPTYPLACE, ");
                sb.Append("PVC_BACKUP1, ");
                sb.Append("PVC_BACKUP2, ");
                sb.Append("PVC_BACKUP3 )");
                sb.Append(" values ( ");
                sb.Append("@ID,");
                sb.Append("@WAREHOUSENO,");
                sb.Append("@PLACEID,");
                sb.Append("@CONTAINERID,");
                sb.Append("@UPDATETIME,");
                sb.Append("@UPDATEUSER,");
                sb.Append("@VOID,");
                sb.Append("@ISEMPTYCONTAINER,");
                sb.Append("@ISEMPTYPLACE,");
                sb.Append("@PVC_BACKUP1,");
                sb.Append("@PVC_BACKUP2,");
                sb.Append(" @PVC_BACKUP3 )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@ID", DbType.String) { Value = tt.ID });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@PLACEID", DbType.String) { Value = tt.PLACEID });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERID", DbType.String) { Value = tt.CONTAINERID });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@ISEMPTYCONTAINER", DbType.String) { Value = tt.ISEMPTYCONTAINER });
                cmd.Parameters.Add(new SqlParameter("@ISEMPTYPLACE", DbType.String) { Value = tt.ISEMPTYPLACE });
                cmd.Parameters.Add(new SqlParameter("@PVC_BACKUP1", DbType.String) { Value = tt.PVC_BACKUP1 });
                cmd.Parameters.Add(new SqlParameter("@PVC_BACKUP2", DbType.String) { Value = tt.PVC_BACKUP2 });
                cmd.Parameters.Add(new SqlParameter("@PVC_BACKUP3", DbType.String) { Value = tt.PVC_BACKUP3 });

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
        /// 更新某条数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool UpdateOne(IV_place_vs_container t_new)
        {
            try
            {
                var tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update IV_place_vs_container set ");
                sb.Append("WAREHOUSENO=@WAREHOUSENO, ");
                sb.Append("PLACEID=@PLACEID, ");
                sb.Append("CONTAINERID=@CONTAINERID, ");
                sb.Append("UPDATETIME=@UPDATETIME, ");
                sb.Append("UPDATEUSER=@UPDATEUSER, ");
                sb.Append("VOID=@VOID, ");
                sb.Append("ISEMPTYCONTAINER=@ISEMPTYCONTAINER, ");
                sb.Append("ISEMPTYPLACE=@ISEMPTYPLACE, ");
                sb.Append("PVC_BACKUP1=@PVC_BACKUP1, ");
                sb.Append("PVC_BACKUP2=@PVC_BACKUP2, ");
                sb.Append("PVC_BACKUP3=@PVC_BACKUP3 ");
                sb.Append(" where ID=@ID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;               
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@PLACEID", DbType.String) { Value = tt.PLACEID });
                cmd.Parameters.Add(new SqlParameter("@CONTAINERID", DbType.String) { Value = tt.CONTAINERID });
                cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
                cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
                cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
                cmd.Parameters.Add(new SqlParameter("@ISEMPTYCONTAINER", DbType.String) { Value = tt.ISEMPTYCONTAINER });
                cmd.Parameters.Add(new SqlParameter("@ISEMPTYPLACE", DbType.String) { Value = tt.ISEMPTYPLACE });
                cmd.Parameters.Add(new SqlParameter("@PVC_BACKUP1", DbType.String) { Value = tt.PVC_BACKUP1 });
                cmd.Parameters.Add(new SqlParameter("@PVC_BACKUP2", DbType.String) { Value = tt.PVC_BACKUP2 });
                cmd.Parameters.Add(new SqlParameter("@PVC_BACKUP3", DbType.String) { Value = tt.PVC_BACKUP3 });
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
        /// 按托盘号删除托盘信息
        /// </summary>
        /// <param name="ContainerID"></param>
        /// <returns></returns>
        public static bool DeleteOne(string ContainerID)
        {
            int i = 0;
            string strCMD = "delete from IV_place_vs_container where ContainerID='" + ContainerID + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }
        public static List<IV_place_vs_container> GetRelationshipByContainer(string ContainerID)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from iv_place_vs_container where containerID='" + ContainerID + "' ");
            return DoQuery(sb.ToString());
        }

    }
}