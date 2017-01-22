using System;
using System.Collections.Generic;
using DBEntity;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace WebServiceForASRS.DAL
{

    public class SQL_da_IM_Item
    {
        private static List<IM_Item> DoQuery(string sql_str)
        {
            List<IM_Item> rtn = new List<IM_Item>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                {
                    using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                    {
                        while (dr.Read())
                        {
                            var p = new IM_Item();
                            p.SKU = DBHelper_SqlServer.GetDataValue<string>(dr, "SKU");
                            p.SKUDESC = DBHelper_SqlServer.GetDataValue<string>(dr, "SKUDESC");
                            p.BARCODE = DBHelper_SqlServer.GetDataValue<string>(dr, "BARCODE");
                            p.EANCODE = DBHelper_SqlServer.GetDataValue<string>(dr, "EANCODE");
                            p.COMPATIBLECODE = DBHelper_SqlServer.GetDataValue<string>(dr, "COMPATIBLECODE");
                            p.SPEC = DBHelper_SqlServer.GetDataValue<string>(dr, "SPEC");
                            p.ITEMCLASS = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEMCLASS");
                            p.ABCCLASS = DBHelper_SqlServer.GetDataValue<string>(dr, "ABCCLASS");
                            p.UOM = DBHelper_SqlServer.GetDataValue<string>(dr, "UOM");
                            p.LENGTH = DBHelper_SqlServer.GetDataValue<decimal>(dr, "LENGTH");
                            p.WIDTH = DBHelper_SqlServer.GetDataValue<decimal>(dr, "WIDTH");
                            p.HEIGHT = DBHelper_SqlServer.GetDataValue<decimal>(dr, "HEIGHT");
                            p.WEIGHT = DBHelper_SqlServer.GetDataValue<decimal>(dr, "WEIGHT");
                            p.SAVEQTY = DBHelper_SqlServer.GetDataValue<decimal>(dr, "SAVEQTY");
                            p.STORGELIFE = DBHelper_SqlServer.GetDataValue<string>(dr, "STORGELIFE");
                            p.VOID = DBHelper_SqlServer.GetDataValue<int>(dr, "VOID");
                            p.UPDATETIME = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATETIME");
                            p.UPDATEUSER = DBHelper_SqlServer.GetDataValue<string>(dr, "UPDATEUSER");
                            p.ITEM_BK1 = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEM_BK1");
                            p.ITEM_BK2 = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEM_BK2");
                            p.ITEM_BK3 = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEM_BK3");

                            rtn.Add(p);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return rtn;
        }

        /// <summary>
        /// 获取所有物料
        /// </summary>
        /// <returns></returns>
        public static List<IM_Item> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  IM_Item order by SKU ");
            return DoQuery(sb.ToString());
        }
        public static List<IM_Item> GetAllByContainerID(string containerid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  IM_Item where BINDINGCONTAINER="+containerid+" order by SKU ");
            return DoQuery(sb.ToString());
        }

        public static IM_Item GetOneBySku(string Sku)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  IM_Item where SKU='" + Sku + "' order by SKU ");
            var rtn = DoQuery(sb.ToString());
            if (rtn.Count > 0)
                return rtn[0];
            else
                return null;
        }
         /// <summary>
        /// 新增一个物料
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(IM_Item t_new)
        {
            IM_Item tt = t_new;
            StringBuilder sb = new StringBuilder();
            sb.Append(" Insert into IM_Item (  ");
            sb.Append("SKU, ");
            sb.Append("SKUDESC, ");
            sb.Append("BARCODE, ");
            sb.Append("EANCODE, ");
            sb.Append("COMPATIBLECODE, ");
            sb.Append("SPEC, ");
            sb.Append("ITEMCLASS, ");
            sb.Append("ABCCLASS, ");
            sb.Append("UOM, ");
            sb.Append("LENGTH, ");
            sb.Append("WIDTH, ");
            sb.Append("HEIGHT, ");
            sb.Append("WEIGHT, ");
            sb.Append("SAVEQTY, ");
            sb.Append("STORGELIFE, ");
            sb.Append("VOID, ");
            sb.Append("UPDATETIME, ");
            sb.Append("UPDATEUSER, ");
            sb.Append("ITEM_BK1, ");
            sb.Append("ITEM_BK2, ");
            sb.Append("ITEM_BK3 )");
            sb.Append(" values ( ");
            sb.Append("@SKU,");
            sb.Append("@SKUDESC,");
            sb.Append("@BARCODE,");
            sb.Append("@EANCODE,");
            sb.Append("@COMPATIBLECODE,");
            sb.Append("@SPEC,");
            sb.Append("@ITEMCLASS,");
            sb.Append("@ABCCLASS,");
            sb.Append("@UOM,");
            sb.Append("@LENGTH,");
            sb.Append("@WIDTH,");
            sb.Append("@HEIGHT,");
            sb.Append("@WEIGHT,");
            sb.Append("@SAVEQTY,");
            sb.Append("@STORGELIFE,");
            sb.Append("@VOID,");
            sb.Append("@UPDATETIME,");
            sb.Append("@UPDATEUSER,");
            sb.Append("@ITEM_BK1,");
            sb.Append("@ITEM_BK2,");
            sb.Append(" @ITEM_BK3 )");
            DbCommand cmd = new SqlCommand();
            cmd.CommandText = sb.ToString();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@SKU", DbType.String) { Value = tt.SKU });
            cmd.Parameters.Add(new SqlParameter("@SKUDESC", DbType.String) { Value = tt.SKUDESC });
            cmd.Parameters.Add(new SqlParameter("@BARCODE", DbType.String) { Value = tt.BARCODE });
            cmd.Parameters.Add(new SqlParameter("@EANCODE", DbType.String) { Value = tt.EANCODE });
            cmd.Parameters.Add(new SqlParameter("@COMPATIBLECODE", DbType.String) { Value = tt.COMPATIBLECODE });
            cmd.Parameters.Add(new SqlParameter("@SPEC", DbType.String) { Value = tt.SPEC });
            cmd.Parameters.Add(new SqlParameter("@ITEMCLASS", DbType.String) { Value = tt.ITEMCLASS });
            cmd.Parameters.Add(new SqlParameter("@ABCCLASS", DbType.String) { Value = tt.ABCCLASS });
            cmd.Parameters.Add(new SqlParameter("@UOM", DbType.String) { Value = tt.UOM });
            cmd.Parameters.Add(new SqlParameter("@LENGTH", DbType.Decimal) { Value = tt.LENGTH });
            cmd.Parameters.Add(new SqlParameter("@WIDTH", DbType.Decimal) { Value = tt.WIDTH });
            cmd.Parameters.Add(new SqlParameter("@HEIGHT", DbType.Decimal) { Value = tt.HEIGHT });
            cmd.Parameters.Add(new SqlParameter("@WEIGHT", DbType.Decimal) { Value = tt.WEIGHT });
            cmd.Parameters.Add(new SqlParameter("@SAVEQTY", DbType.Decimal) { Value = tt.SAVEQTY });
            cmd.Parameters.Add(new SqlParameter("@STORGELIFE", DbType.String) { Value = tt.STORGELIFE });
            cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
            cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
            cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
            cmd.Parameters.Add(new SqlParameter("@ITEM_BK1", DbType.String) { Value = tt.ITEM_BK1 });
            cmd.Parameters.Add(new SqlParameter("@ITEM_BK2", DbType.String) { Value = tt.ITEM_BK2 });
            cmd.Parameters.Add(new SqlParameter("@ITEM_BK3", DbType.String) { Value = tt.ITEM_BK3 });

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

        /// <summary>
        /// 更新一个物料信息
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool UpdateOne(IM_Item t_new)
        {
            IM_Item tt = t_new;
            StringBuilder sb = new StringBuilder();
            sb.Append(" update IM_Item set ");
            sb.Append("SKUDESC=@SKUDESC, ");
            sb.Append("BARCODE=@BARCODE, ");
            sb.Append("EANCODE=@EANCODE, ");
            sb.Append("COMPATIBLECODE=@COMPATIBLECODE, ");
            sb.Append("SPEC=@SPEC, ");
            sb.Append("ITEMCLASS=@ITEMCLASS, ");
            sb.Append("ABCCLASS=@ABCCLASS, ");
            sb.Append("UOM=@UOM, ");
            sb.Append("LENGTH=@LENGTH, ");
            sb.Append("WIDTH=@WIDTH, ");
            sb.Append("HEIGHT=@HEIGHT, ");
            sb.Append("WEIGHT=@WEIGHT, ");
            sb.Append("SAVEQTY=@SAVEQTY, ");
            sb.Append("STORGELIFE=@STORGELIFE, ");
            sb.Append("VOID=@VOID, ");
            sb.Append("UPDATETIME=@UPDATETIME, ");
            sb.Append("UPDATEUSER=@UPDATEUSER, ");
            sb.Append("ITEM_BK1=@ITEM_BK1, ");
            sb.Append("ITEM_BK2=@ITEM_BK2, ");
            sb.Append("ITEM_BK3=@ITEM_BK3 ");

            sb.Append(" where SKU=@SKU ");
            DbCommand cmd = new SqlCommand();
            cmd.CommandText = sb.ToString();
            cmd.CommandType = CommandType.Text;
           
            cmd.Parameters.Add(new SqlParameter("@SKUDESC", DbType.String) { Value = tt.SKUDESC });
            cmd.Parameters.Add(new SqlParameter("@BARCODE", DbType.String) { Value = tt.BARCODE });
            cmd.Parameters.Add(new SqlParameter("@EANCODE", DbType.String) { Value = tt.EANCODE });
            cmd.Parameters.Add(new SqlParameter("@COMPATIBLECODE", DbType.String) { Value = tt.COMPATIBLECODE });
            cmd.Parameters.Add(new SqlParameter("@SPEC", DbType.String) { Value = tt.SPEC });
            cmd.Parameters.Add(new SqlParameter("@ITEMCLASS", DbType.String) { Value = tt.ITEMCLASS });
            cmd.Parameters.Add(new SqlParameter("@ABCCLASS", DbType.String) { Value = tt.ABCCLASS });
            cmd.Parameters.Add(new SqlParameter("@UOM", DbType.String) { Value = tt.UOM });
            cmd.Parameters.Add(new SqlParameter("@LENGTH", DbType.Decimal) { Value = tt.LENGTH });
            cmd.Parameters.Add(new SqlParameter("@WIDTH", DbType.Decimal) { Value = tt.WIDTH });
            cmd.Parameters.Add(new SqlParameter("@HEIGHT", DbType.Decimal) { Value = tt.HEIGHT });
            cmd.Parameters.Add(new SqlParameter("@WEIGHT", DbType.Decimal) { Value = tt.WEIGHT });
            cmd.Parameters.Add(new SqlParameter("@SAVEQTY", DbType.Decimal) { Value = tt.SAVEQTY });
            cmd.Parameters.Add(new SqlParameter("@STORGELIFE", DbType.String) { Value = tt.STORGELIFE });
            cmd.Parameters.Add(new SqlParameter("@VOID", DbType.Int32) { Value = tt.VOID });
            cmd.Parameters.Add(new SqlParameter("@UPDATETIME", DbType.String) { Value = tt.UPDATETIME });
            cmd.Parameters.Add(new SqlParameter("@UPDATEUSER", DbType.String) { Value = tt.UPDATEUSER });
            cmd.Parameters.Add(new SqlParameter("@ITEM_BK1", DbType.String) { Value = tt.ITEM_BK1 });
            cmd.Parameters.Add(new SqlParameter("@ITEM_BK2", DbType.String) { Value = tt.ITEM_BK2 });
            cmd.Parameters.Add(new SqlParameter("@ITEM_BK3", DbType.String) { Value = tt.ITEM_BK3 });
            cmd.Parameters.Add(new SqlParameter("@SKU", DbType.String) { Value = tt.SKU });
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

        /// <summary>
        /// 删除一个物料
        /// </summary>
        /// <param name="SKU"></param>
        /// <returns></returns>
        public static bool DeleteOne(string SKU)
        {
            int i = 0;
            string strCMD = "delete from IM_Item where SKU='" + SKU + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }


    }
}