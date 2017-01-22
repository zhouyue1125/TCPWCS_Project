using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Data.Common;

namespace WebServiceForASRS.DAL
{

    public class SQL_Da_PL_Place
    {
        private static List<PL_Place> DoQuery(string sql_str)
        {
            List<PL_Place> rtn = new List<PL_Place>();
            try
            {
               DBHelper DBHelper_SqlServer = new DBLink();
                using (IDataReader dr = DBHelper_SqlServer.ExecuteReader(sql_str))
                {
                    while (dr.Read())
                    {
                        var p = new PL_Place();
                        #region 逐个赋值
                        p.PLACEID = DBHelper_SqlServer.GetDataValue<string>(dr, "PLACEID");
                        p.PLACENODEID = DBHelper_SqlServer.GetDataValue<string>(dr, "PLACENODEID");
                        p.PLACETYPE = DBHelper_SqlServer.GetDataValue<string>(dr, "PLACETYPE");
                        p.PLACEAREA = DBHelper_SqlServer.GetDataValue<string>(dr, "PLACEAREA");
                        p.ROWNO = DBHelper_SqlServer.GetDataValue<string>(dr, "ROWNO");
                        p.COLUMNNO = DBHelper_SqlServer.GetDataValue<string>(dr, "COLUMNNO");
                        p.LAYERNO = DBHelper_SqlServer.GetDataValue<string>(dr, "LAYERNO");
                        p.DEEPCELLNO = DBHelper_SqlServer.GetDataValue<string>(dr, "DEEPCELLNO");
                        p.AISLE = DBHelper_SqlServer.GetDataValue<string>(dr, "AISLE");
                        p.LINE = DBHelper_SqlServer.GetDataValue<string>(dr, "LINE");
                        p.AISLESIDE = DBHelper_SqlServer.GetDataValue<string>(dr, "AISLESIDE");
                        p.ISLOCK = DBHelper_SqlServer.GetDataValue<string>(dr, "ISLOCK");
                        p.ISFULL = DBHelper_SqlServer.GetDataValue<string>(dr, "ISFULL");
                        p.HASTASKDOING = DBHelper_SqlServer.GetDataValue<string>(dr, "HASTASKDOING");
                        p.WAREHOUSENO = DBHelper_SqlServer.GetDataValue<string>(dr, "WAREHOUSENO");
                        p.POSITIONNO_FOR_SRM = DBHelper_SqlServer.GetDataValue<string>(dr, "POSITIONNO_FOR_SRM");
                        p.X = DBHelper_SqlServer.GetDataValue<string>(dr, "X");
                        p.Y = DBHelper_SqlServer.GetDataValue<string>(dr, "Y");
                        p.Z = DBHelper_SqlServer.GetDataValue<string>(dr, "Z");
                        p.LENGTH = DBHelper_SqlServer.GetDataValue<decimal>(dr, "LENGTH");
                        p.WIDTH = DBHelper_SqlServer.GetDataValue<decimal>(dr, "WIDTH");
                        p.HEIGHT = DBHelper_SqlServer.GetDataValue<decimal>(dr, "HEIGHT");
                        p.MAXWEIGHT = DBHelper_SqlServer.GetDataValue<decimal>(dr, "MAXWEIGHT");
                        p.HEIGHTLEVEL = DBHelper_SqlServer.GetDataValue<string>(dr, "HEIGHTLEVEL");
                        p.PRIORITY = DBHelper_SqlServer.GetDataValue<int>(dr, "PRIORITY");
                        p.AREA_LOGIC = DBHelper_SqlServer.GetDataValue<string>(dr, "AREA_LOGIC");

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
        /// 获取所有库位信息
        /// </summary>
        /// <returns></returns>
        public static List<PL_Place> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from  PL_Place order by PLACEID");
            return DoQuery(sb.ToString());
        }

        /// <summary>
        /// 获取可用库位信息
        /// </summary>
        /// <returns></returns>
        public static List<PL_Place> GetAllByHighNO(int HighNO)
        {
            StringBuilder sb = new StringBuilder();
            if (HighNO == 1) {
                sb.Append(" select * from PL_PLACE A WHERE A.PLACEID NOT IN(SELECT B.PLACEID FROM IV_PLACE_VS_CONTAINER B) AND A.PLACEID LIKE '%01' OR A.PLACEID LIKE '%02'");
            }
            else if (HighNO == 2) {
                sb.Append(" select * from PL_PLACE A WHERE A.PLACEID NOT IN(SELECT B.PLACEID FROM IV_PLACE_VS_CONTAINER B) AND A.PLACEID LIKE '%03' OR A.PLACEID LIKE '%04'");
            }else if(HighNO == 3){
                sb.Append(" select * from PL_PLACE A WHERE A.PLACEID NOT IN(SELECT B.PLACEID FROM IV_PLACE_VS_CONTAINER B) AND A.PLACEID LIKE '%05'");
            }
            
            return DoQuery(sb.ToString());
        }

        /// <summary>
        /// 插入一条数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        public static bool InsertNew(PL_Place t_new)
        {
            try
            {
                PL_Place tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" Insert into PL_PLACE (  ");
                sb.Append("PLACEID, ");
                sb.Append("PLACENODEID, ");
                sb.Append("PLACETYPE, ");
                sb.Append("PLACEAREA, ");
                sb.Append("ROWNO, ");
                sb.Append("COLUMNNO, ");
                sb.Append("LAYERNO, ");
                sb.Append("DEEPCELLNO, ");
                sb.Append("AISLE, ");
                sb.Append("LINE, ");
                sb.Append("AISLESIDE, ");
                sb.Append("ISLOCK, ");
                sb.Append("ISFULL, ");
                sb.Append("HASTASKDOING, ");
                sb.Append("WAREHOUSENO, ");
                sb.Append("POSITIONNO_FOR_SRM, ");
                sb.Append("X, ");
                sb.Append("Y, ");
                sb.Append("Z, ");
                sb.Append("LENGTH, ");
                sb.Append("WIDTH, ");
                sb.Append("HEIGHT, ");
                sb.Append("MAXWEIGHT, ");
                sb.Append("HEIGHTLEVEL, ");
                sb.Append("PRIORITY, ");
                sb.Append("AREA_LOGIC )");
                sb.Append(" values ( ");
                sb.Append("@PLACEID,");
                sb.Append("@PLACENODEID,");
                sb.Append("@PLACETYPE,");
                sb.Append("@PLACEAREA,");
                sb.Append("@ROWNO,");
                sb.Append("@COLUMNNO,");
                sb.Append("@LAYERNO,");
                sb.Append("@DEEPCELLNO,");
                sb.Append("@AISLE,");
                sb.Append("@LINE,");
                sb.Append("@AISLESIDE,");
                sb.Append("@ISLOCK,");
                sb.Append("@ISFULL,");
                sb.Append("@HASTASKDOING,");
                sb.Append("@WAREHOUSENO,");
                sb.Append("@POSITIONNO_FOR_SRM,");
                sb.Append("@X,");
                sb.Append("@Y,");
                sb.Append("@Z,");
                sb.Append("@LENGTH,");
                sb.Append("@WIDTH,");
                sb.Append("@HEIGHT,");
                sb.Append("@MAXWEIGHT,");
                sb.Append("@HEIGHTLEVEL,");
                sb.Append("@PRIORITY,");
                sb.Append(" @AREA_LOGIC )");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@PLACEID", DbType.String) { Value = tt.PLACEID });
                cmd.Parameters.Add(new SqlParameter("@PLACENODEID", DbType.String) { Value = tt.PLACENODEID });
                cmd.Parameters.Add(new SqlParameter("@PLACETYPE", DbType.String) { Value = tt.PLACETYPE });
                cmd.Parameters.Add(new SqlParameter("@PLACEAREA", DbType.String) { Value = tt.PLACEAREA });
                cmd.Parameters.Add(new SqlParameter("@ROWNO", DbType.String) { Value = tt.ROWNO });
                cmd.Parameters.Add(new SqlParameter("@COLUMNNO", DbType.String) { Value = tt.COLUMNNO });
                cmd.Parameters.Add(new SqlParameter("@LAYERNO", DbType.String) { Value = tt.LAYERNO });
                cmd.Parameters.Add(new SqlParameter("@DEEPCELLNO", DbType.String) { Value = tt.DEEPCELLNO });
                cmd.Parameters.Add(new SqlParameter("@AISLE", DbType.String) { Value = tt.AISLE });
                cmd.Parameters.Add(new SqlParameter("@LINE", DbType.String) { Value = tt.LINE });
                cmd.Parameters.Add(new SqlParameter("@AISLESIDE", DbType.String) { Value = tt.AISLESIDE });
                cmd.Parameters.Add(new SqlParameter("@ISLOCK", DbType.String) { Value = tt.ISLOCK });
                cmd.Parameters.Add(new SqlParameter("@ISFULL", DbType.String) { Value = tt.ISFULL });
                cmd.Parameters.Add(new SqlParameter("@HASTASKDOING", DbType.String) { Value = tt.HASTASKDOING });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@POSITIONNO_FOR_SRM", DbType.String) { Value = tt.POSITIONNO_FOR_SRM });
                cmd.Parameters.Add(new SqlParameter("@X", DbType.String) { Value = tt.X });
                cmd.Parameters.Add(new SqlParameter("@Y", DbType.String) { Value = tt.Y });
                cmd.Parameters.Add(new SqlParameter("@Z", DbType.String) { Value = tt.Z });
                cmd.Parameters.Add(new SqlParameter("@LENGTH", DbType.Decimal) { Value = tt.LENGTH });
                cmd.Parameters.Add(new SqlParameter("@WIDTH", DbType.Decimal) { Value = tt.WIDTH });
                cmd.Parameters.Add(new SqlParameter("@HEIGHT", DbType.Decimal) { Value = tt.HEIGHT });
                cmd.Parameters.Add(new SqlParameter("@MAXWEIGHT", DbType.Decimal) { Value = tt.MAXWEIGHT });
                cmd.Parameters.Add(new SqlParameter("@HEIGHTLEVEL", DbType.String) { Value = tt.HEIGHTLEVEL });
                cmd.Parameters.Add(new SqlParameter("@PRIORITY", DbType.Int32) { Value = tt.PRIORITY });
                cmd.Parameters.Add(new SqlParameter("@AREA_LOGIC", DbType.String) { Value = tt.AREA_LOGIC });

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
        public static bool UpdateOne(PL_Place t_new)
        {
            try
            {
                PL_Place tt = t_new;
                StringBuilder sb = new StringBuilder();
                sb.Append(" update PL_PLACE set ");
                sb.Append("PLACENODEID=@PLACENODEID, ");
                sb.Append("PLACETYPE=@PLACETYPE, ");
                sb.Append("PLACEAREA=@PLACEAREA, ");
                sb.Append("ROWNO=@ROWNO, ");
                sb.Append("COLUMNNO=@COLUMNNO, ");
                sb.Append("LAYERNO=@LAYERNO, ");
                sb.Append("DEEPCELLNO=@DEEPCELLNO, ");
                sb.Append("AISLE=@AISLE, ");
                sb.Append("LINE=@LINE, ");
                sb.Append("AISLESIDE=@AISLESIDE, ");
                sb.Append("ISLOCK=@ISLOCK, ");
                sb.Append("ISFULL=@ISFULL, ");
                sb.Append("HASTASKDOING=@HASTASKDOING, ");
                sb.Append("WAREHOUSENO=@WAREHOUSENO, ");
                sb.Append("POSITIONNO_FOR_SRM=@POSITIONNO_FOR_SRM, ");
                sb.Append("X=@X, ");
                sb.Append("Y=@Y, ");
                sb.Append("Z=@Z, ");
                sb.Append("LENGTH=@LENGTH, ");
                sb.Append("WIDTH=@WIDTH, ");
                sb.Append("HEIGHT=@HEIGHT, ");
                sb.Append("MAXWEIGHT=@MAXWEIGHT, ");
                sb.Append("HEIGHTLEVEL=@HEIGHTLEVEL, ");
                sb.Append("PRIORITY=@PRIORITY, ");
                sb.Append("AREA_LOGIC=@AREA_LOGIC ");

                sb.Append(" where PLACEID=@PLACEID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
             
                cmd.Parameters.Add(new SqlParameter("@PLACENODEID", DbType.String) { Value = tt.PLACENODEID });
                cmd.Parameters.Add(new SqlParameter("@PLACETYPE", DbType.String) { Value = tt.PLACETYPE });
                cmd.Parameters.Add(new SqlParameter("@PLACEAREA", DbType.String) { Value = tt.PLACEAREA });
                cmd.Parameters.Add(new SqlParameter("@ROWNO", DbType.String) { Value = tt.ROWNO });
                cmd.Parameters.Add(new SqlParameter("@COLUMNNO", DbType.String) { Value = tt.COLUMNNO });
                cmd.Parameters.Add(new SqlParameter("@LAYERNO", DbType.String) { Value = tt.LAYERNO });
                cmd.Parameters.Add(new SqlParameter("@DEEPCELLNO", DbType.String) { Value = tt.DEEPCELLNO });
                cmd.Parameters.Add(new SqlParameter("@AISLE", DbType.String) { Value = tt.AISLE });
                cmd.Parameters.Add(new SqlParameter("@LINE", DbType.String) { Value = tt.LINE });
                cmd.Parameters.Add(new SqlParameter("@AISLESIDE", DbType.String) { Value = tt.AISLESIDE });
                cmd.Parameters.Add(new SqlParameter("@ISLOCK", DbType.String) { Value = tt.ISLOCK });
                cmd.Parameters.Add(new SqlParameter("@ISFULL", DbType.String) { Value = tt.ISFULL });
                cmd.Parameters.Add(new SqlParameter("@HASTASKDOING", DbType.String) { Value = tt.HASTASKDOING });
                cmd.Parameters.Add(new SqlParameter("@WAREHOUSENO", DbType.String) { Value = tt.WAREHOUSENO });
                cmd.Parameters.Add(new SqlParameter("@POSITIONNO_FOR_SRM", DbType.String) { Value = tt.POSITIONNO_FOR_SRM });
                cmd.Parameters.Add(new SqlParameter("@X", DbType.String) { Value = tt.X });
                cmd.Parameters.Add(new SqlParameter("@Y", DbType.String) { Value = tt.Y });
                cmd.Parameters.Add(new SqlParameter("@Z", DbType.String) { Value = tt.Z });
                cmd.Parameters.Add(new SqlParameter("@LENGTH", DbType.Decimal) { Value = tt.LENGTH });
                cmd.Parameters.Add(new SqlParameter("@WIDTH", DbType.Decimal) { Value = tt.WIDTH });
                cmd.Parameters.Add(new SqlParameter("@HEIGHT", DbType.Decimal) { Value = tt.HEIGHT });
                cmd.Parameters.Add(new SqlParameter("@MAXWEIGHT", DbType.Decimal) { Value = tt.MAXWEIGHT });
                cmd.Parameters.Add(new SqlParameter("@HEIGHTLEVEL", DbType.String) { Value = tt.HEIGHTLEVEL });
                cmd.Parameters.Add(new SqlParameter("@PRIORITY", DbType.Int32) { Value = tt.PRIORITY });
                cmd.Parameters.Add(new SqlParameter("@AREA_LOGIC", DbType.String) { Value = tt.AREA_LOGIC });
                cmd.Parameters.Add(new SqlParameter("@PLACEID", DbType.String) { Value = tt.PLACEID });
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

        public static bool DeleteOne(string PlaceID)
        {
            int i = 0;
            string strCMD = "delete from  PL_Place where PlaceID='" + PlaceID + "'";
           DBHelper DBHelper_SqlServer = new DBLink();
            i = DBHelper_SqlServer.ExecuteNonQuery(strCMD);
            if (i > 0)
                return true;
            else
                return false;
        }

        public static List<PL_Place> GetPlaceInfoByID(string place_id)
        {
            string getstr = string.Format("select * from PL_place where  PlaceID='" + place_id + "'");
            return DoQuery(getstr);
        }
        /// <summary>
        /// 根据绑定的托盘号查找库位信息
        /// </summary>
        /// <param name="BindContainerID"></param>
        /// <returns></returns>
        public static List<PL_Place> GetInputLocationByContainerBind(string BindContainerID)
        {
            string getstr = string.Format("select * from PL_place where  BindContainerID='" + BindContainerID + "'");
            return DoQuery(getstr);
        }
        /// <summary>
        /// 根据高度获取入库可用货位
        /// </summary>
        /// <param name="Height_Level"></param>
        /// <returns></returns>
        public static List<PL_Place> GetInputLocationByHeight(string Height_Level, string logic_area)
        {
            List<PL_Place> lisRtn = new List<PL_Place>();
            try
            {
                string getstr = string.Format("select * from PL_place where  HeightLevel='" + Height_Level + "' and  IsLock=0  and  HasTaskDoing=0 and IsFull =0 ");
                if (logic_area != "")
                {
                    getstr += "and Area_Logic='" + logic_area + "' ";
                }

                getstr += " and PlaceType ='LOCATION' and PlaceID not in (select distinct ToPlace from OD_Task where TaskType='SRM_Store_In' and HadFinish='N') and PlaceID not in( select distinct PlaceID from IV_place_vs_container where void=0 ) order by InPriorage Asc";

                lisRtn = DoQuery(getstr);

            }
            catch
            {
            }
            return lisRtn;
        }

        public static List<PL_Place> GetAllStoreLocation()
        {
            string getstr = string.Format("select * from PL_place where PlaceType='LOCATION'  ");
            return DoQuery(getstr);
        }

        public static List<PL_Place> GetAllByLayer(string layer)
        {
            string getstr = string.Format("select * from PL_place where LAYERNO='" + layer + "' ");
            return DoQuery(getstr);
        }

        public static List<PL_Place> GetByAreaStrLocation(string LogicArae)
        {
            string getstr = string.Format("select * from PL_place where Area_Logic='" + LogicArae + "'  ");
            return DoQuery(getstr);
        }

        public static List<PL_Place> FiltLocationByRowColumnLayer(string rr, string cc, string ll)
        {
            StringBuilder sb =new StringBuilder();
             sb.Append("select * from PL_place where  1=1");  
            if(rr!="")
            sb.Append(" and  RowNo= '" + rr + "'");
            if(cc!="")
                sb.Append(" and  ColumnNo = '" + cc + "'");
            if(ll!="")
                sb.Append(" and LayerNo = '" + ll + "'");
           
            return DoQuery(sb.ToString());
        }
        /// <summary>
        /// 检测货位号是否放置了货物。有，则返回false，无有东西则返回true
        /// </summary>
        /// <param name="placeID"></param>
        /// <returns></returns>
        public static bool CheckPlaceEmpty(string placeID)
        {
            string getstr = string.Format("select * from PL_place where  PlaceID='" + placeID + "'");
            List<PL_Place> lisPlace = DoQuery(getstr);
            if (lisPlace.Count > 0)
            {
                PL_Place p = lisPlace[0];
                if (p.ISFULL == "Y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool UpdateHadTaskDoing(string placeID, string YorN)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(" update PL_place  set ");
                sb.Append(" HASTASKDOING=@HASTASKDOING ");
                sb.Append(" where PLACEID=@PLACEID ");
                DbCommand cmd = new SqlCommand();
                cmd.CommandText = sb.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@HASTASKDOING", DbType.String) { Value = YorN });
                cmd.Parameters.Add(new SqlParameter("PLACEID", DbType.String) { Value = placeID });
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
        /// 获取空库位
        /// </summary>
        /// <returns></returns>
        public static List<string> GetEmptyPlace()
        {
            string getstr = "";
            List<string> emptyplace = new List<string>();
            StringBuilder sb;
            sb = new StringBuilder();
            sb.Append("select PlaceID from PL_PLACE where IsLock !='Y' and PLACEID not in (");
            sb.Append(" select PLACEID from IV_PLACE_VS_CONTAINER)");
           // sb.Append(" and PlaceID not in(select PlaceID from IV_place_vs_container) order by LayerNo,RowNo,ColumnNo");
           DBHelper DBHelper_SqlServer = new DBLink();
            getstr = sb.ToString();
            var rd = DBHelper_SqlServer.ExecuteReader(getstr);
            while (rd.Read())
            {
                emptyplace.Add(rd["PLACEID"].ToString());
            }
            return emptyplace;
        }
       
       
        /// <summary>
        /// 获取被锁定库位
        /// </summary>
        /// <returns></returns>
        public static List<string> GetLockedPlace()
        {
            string getstr = "";
            List<string> LockedPlace = new List<string>();
            StringBuilder sb = new StringBuilder();
            sb.Append(" select distinct placeid from PL_Place where islock='1'");
            getstr = sb.ToString();
           DBHelper DBHelper_SqlServer = new DBLink();
            var rd = DBHelper_SqlServer.ExecuteReader(getstr);
            while (rd.Read())
            {
                LockedPlace.Add(rd["PLACEID"].ToString());
            }
            return LockedPlace;
        }
       
        /// <summary>
        /// 根据绑定的托盘号查找库位 (未锁定和无货的)
        /// </summary>
        /// <param name="containerId"></param>
        /// <returns></returns>
        public static PL_Place GetPlaceByBindingContainer(string containerId)
        {            
            string sql = "select * from PL_Place where BINDCONTAINERID='" + containerId + "' and ISLOCK='N' and ISFULL='N'";
            var rtnLst=DoQuery(sql);
            if (rtnLst.Count > 0)
                return rtnLst[0];
            else
                return new PL_Place();
        }

    }
}