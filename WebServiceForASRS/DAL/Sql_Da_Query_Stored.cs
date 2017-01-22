using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using DBEntity;

namespace WebServiceForASRS.DAL
{
    public class Sql_Da_Query_Stored
    {
        private static List<Query_Stored> DoQuery(string sql_str)
        {
            List<Query_Stored> rtn = new List<Query_Stored>();
            try
            {
                DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new Query_Stored();
                        #region 逐个赋值
                        p.WAREHOUSENO = DBHelper_SqlServer.GetDataValue<string>(dr, "WAREHOUSENO");
                        p.PLACEID = DBHelper_SqlServer.GetDataValue<string>(dr, "PLACEID");
                        p.CONTAINERID = DBHelper_SqlServer.GetDataValue<string>(dr, "CONTAINERID");
                        p.ITEMSKU = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEMSKU");
                        p.ITEMDESC = DBHelper_SqlServer.GetDataValue<string>(dr, "ITEMDESC");
                        p.ITEMQTY = DBHelper_SqlServer.GetDataValue<decimal>(dr, "ITEMQTY");

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
        /// 获取所有查询信息
        /// </summary>
        /// <returns></returns>
        public static List<Query_Stored> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from Query_Stored ");
            return DoQuery(sb.ToString());
        }


    }
}