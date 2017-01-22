using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using DBEntity;

namespace WebServiceForASRS.DAL
{
    public class SQL_Da_V_INOUTSTOCK
    {

        private static List<V_INOUTSTOCK> DoQuery(string sql_str)
        {
            List<V_INOUTSTOCK> rtn = new List<V_INOUTSTOCK>();
            DBHelper_Sqlserver DBHelper_Sqlserver = new DBHelper_Sqlserver(); 
            try
            {
                using (IDataReader dr = DBHelper_Sqlserver.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new V_INOUTSTOCK();
                        #region 逐个赋值
                        p.WAREHOUSENO = DBHelper_Sqlserver.GetDataValue<string>(dr, "WAREHOUSENO");
                        p.CONTAINERNO = DBHelper_Sqlserver.GetDataValue<string>(dr, "CONTAINERNO");
                        p.TASKTYPE = DBHelper_Sqlserver.GetDataValue<string>(dr, "TASKTYPE");
                        p.SOURCEPLACE = DBHelper_Sqlserver.GetDataValue<string>(dr, "SOURCEPLACE");
                        p.TOPLACE = DBHelper_Sqlserver.GetDataValue<string>(dr, "TOPLACE");
                        p.UPDATEUSER = DBHelper_Sqlserver.GetDataValue<string>(dr, "UPDATEUSER");
                        p.UPDATETIME = DBHelper_Sqlserver.GetDataValue<string>(dr, "UPDATETIME");
                        p.TASKCONTENTSTRING = DBHelper_Sqlserver.GetDataValue<string>(dr, "TASKCONTENTSTRING");

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


        public static List<V_INOUTSTOCK> GetAllByDate(DateTime start, DateTime end)
        {
            string startDate = start.ToString("yyyy-MM-dd");
            string endDate = end.AddDays(1).ToString("yyyy-MM-dd");
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  V_INOUTSTOCK where UPDATETIME Between '" + startDate + "' and '" + endDate + "'");
            return DoQuery(sb.ToString());
        }
    }
}