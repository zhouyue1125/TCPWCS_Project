using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WHC.OrderWater.Commons;


namespace WCS_V3
{
    public class CommonMethod
    {
        #region 写日志
      
        #endregion
        #region 写文件
        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="Path">文件路径</param>
        /// <param name="Strings">文件内容</param>
        public static void WriteFile(string Path, string Strings)
        {

            if (!System.IO.File.Exists(Path))
            {
                System.IO.FileStream f = System.IO.File.Create(Path);
                f.Close();
                f.Dispose();
            }
            System.IO.StreamWriter f2 = new System.IO.StreamWriter(Path, true, System.Text.Encoding.UTF8);
            f2.WriteLine(Strings);
            f2.Close();
            f2.Dispose();


        }
        #endregion

        #region 读文件
        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="Path">文件路径</param>
        /// <returns></returns>
        public static string ReadFile(string Path)
        {
            string s = "";
            if (!System.IO.File.Exists(Path))
                s = "";
            else
            {
                StreamReader f2 = new StreamReader(Path, System.Text.Encoding.GetEncoding("gb2312"));
                s = f2.ReadToEnd();
                f2.Close();
                f2.Dispose();
            }

            return s;
        }
        #endregion

        #region 删除文件

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="Path">路径</param>
        public static void FileDel(string Path)
        {
            File.Delete(Path);
        }
        #endregion

        /// <summary>
        /// 获取数字图片
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="StartPath"></param>
        /// <returns></returns>
        public static string GetNumberImagePath(int Number, String StartPath)
        {
            string path = "";
            try
            {
                if (Number <= 10 && Number > 0)
                {
                    path = StartPath + @"\Numbers\numb" + Number + ".gif";
                }
                else if (Number > 10)
                {
                    path = StartPath + @"\Numbers\numbMore.gif";
                }
            }
            catch (Exception)
            {

                path = "";
            }
            return path;
        }


        /// <summary>
        /// 凯撒法加密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string StringEncoding(string pwd)//加密
        {
            char[] arrChar = pwd.ToCharArray();
            string strChar = "";
            for (int i = 0; i < arrChar.Length; i++)
            {
                arrChar[i] = Convert.ToChar(arrChar[i] + 1);
                strChar = strChar + arrChar[i].ToString();
            }
            return strChar;
        }

        /// <summary>
        /// 凯撒法解密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string StringDecoding(string pwd)//解密
        {
            char[] arrChar = pwd.ToCharArray();
            string strChar = "";
            for (int i = 0; i < arrChar.Length; i++)
            {
                arrChar[i] = Convert.ToChar(arrChar[i] - 1);
                strChar = strChar + arrChar[i].ToString();
            }
            return strChar;
        }

        /// <summary>
        /// 去除字符串前的0
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveTheOBeforeString(string str)
        {
            return str.TrimStart('0');
        }



        /// <summary>
        /// 获取某日所处周的第一天的0:00:00
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetFirstDayOfThisWeek(DateTime date)
        {
            DateTime thisDay = date;
            DateTime firstDay = new DateTime();
            switch (thisDay.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    firstDay = thisDay.AddDays(-5);
                    break;
                case DayOfWeek.Monday:
                    firstDay = thisDay.AddDays(-1);
                    break;
                case DayOfWeek.Saturday:
                    firstDay = thisDay.AddDays(-6);
                    break;
                case DayOfWeek.Sunday:
                    firstDay = thisDay;
                    break;
                case DayOfWeek.Thursday:
                    firstDay = thisDay.AddDays(-4);
                    break;
                case DayOfWeek.Tuesday:
                    firstDay = thisDay.AddDays(-2);
                    break;
                case DayOfWeek.Wednesday:
                    firstDay = thisDay.AddDays(-3);
                    break;
                default:
                    firstDay = thisDay;
                    break;
            }
            return new DateTime(firstDay.Year, firstDay.Month, firstDay.Day, 0, 0, 0);
        }
        /// <summary>
        /// 取本周最后一天的23:59:59
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetLastDayOfThisWeek(DateTime date)
        {
            DateTime thisDay = date;
            DateTime lastDay = new DateTime();
            switch (thisDay.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    lastDay = thisDay.AddDays(1);
                    break;
                case DayOfWeek.Monday:
                    lastDay = thisDay.AddDays(5);
                    break;
                case DayOfWeek.Saturday:
                    lastDay = thisDay;
                    break;
                case DayOfWeek.Sunday:
                    lastDay = thisDay.AddDays(6);
                    break;
                case DayOfWeek.Thursday:
                    lastDay = thisDay.AddDays(2);
                    break;
                case DayOfWeek.Tuesday:
                    lastDay = thisDay.AddDays(4);
                    break;
                case DayOfWeek.Wednesday:
                    lastDay = thisDay.AddDays(3);
                    break;
                default:
                    lastDay = thisDay;
                    break;
            }
            return new DateTime(lastDay.Year, lastDay.Month, lastDay.Day, 23, 59, 59);
        }

        #region  清理过时的Excel文件

        private static void ClearFile(string FilePath)
        {
            String[] Files = System.IO.Directory.GetFiles(FilePath);
            if (Files.Length > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        System.IO.File.Delete(Files[i]);
                    }
                    catch
                    {
                    }

                }
            }
        }
        #endregion

        /// <summary>
        /// 将集合类转换成DataTable
        /// </summary>
        /// <param name="list">集合</param>
        public static System.Data.DataTable ToDataTable(IList list)
        {
            System.Data.DataTable result = new System.Data.DataTable();
            if (list != null && list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name, pi.PropertyType);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }

        #region 将DataTable的数据导出显示为报表
        /// <summary>
        /// 将DataTable的数据导出显示为报表
        /// </summary>
        /// <param name="dt">要导出的数据</param>
        /// <param name="strTitle">导出报表的标题</param>
        /// <param name="FilePath">保存文件的路径</param>
        /// <returns></returns>
        public static void OutputExcel(System.Data.DataTable dt, string strTitle, string filePath)
        {

            var beforeTime = DateTime.Now;

            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel._Workbook xBk;
            Microsoft.Office.Interop.Excel._Worksheet xSt;

            int rowIndex = 4;
            int colIndex = 1;

            excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            xBk = excel.Workbooks.Add(true);
            xSt = (Microsoft.Office.Interop.Excel._Worksheet)xBk.ActiveSheet;

            //取得列标题			
            foreach (DataColumn col in dt.Columns)
            {
                colIndex++;
                excel.Cells[4, colIndex] = col.ColumnName;

                //设置标题格式为居中对齐
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).Font.Bold = true;
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).Select();
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).Interior.ColorIndex = 15;//19;//设置为浅黄色，共计有56种
            }


            //取得表格中的数据			
            foreach (DataRow row in dt.Rows)
            {
                rowIndex++;
                colIndex = 1;
                foreach (DataColumn col in dt.Columns)
                {
                    colIndex++;
                    if (col.DataType == System.Type.GetType("System.DateTime"))
                    {
                        excel.Cells[rowIndex, colIndex] = (Convert.ToDateTime(row[col.ColumnName].ToString())).ToString("yyyy-MM-dd");
                        xSt.get_Range(excel.Cells[rowIndex, colIndex], excel.Cells[rowIndex, colIndex]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;//设置日期型的字段格式为居中对齐
                    }
                    else
                        if (col.DataType == System.Type.GetType("System.String"))
                        {
                            excel.Cells[rowIndex, colIndex] = "'" + row[col.ColumnName].ToString();
                            xSt.get_Range(excel.Cells[rowIndex, colIndex], excel.Cells[rowIndex, colIndex]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;//设置字符型的字段格式为居中对齐
                        }
                        else
                        {
                            excel.Cells[rowIndex, colIndex] = row[col.ColumnName].ToString();
                        }
                }
            }

            //加载一个合计行			
            int rowSum = rowIndex + 1;
            int colSum = 2;
            excel.Cells[rowSum, 2] = "合计";
            xSt.get_Range(excel.Cells[rowSum, 2], excel.Cells[rowSum, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //设置选中的部分的颜色			
            xSt.get_Range(excel.Cells[rowSum, colSum], excel.Cells[rowSum, colIndex]).Select();
            //xSt.get_Range(excel.Cells[rowSum,colSum],excel.Cells[rowSum,colIndex]).Interior.ColorIndex =Assistant.GetConfigInt("ColorIndex");// 1;//设置为浅黄色，共计有56种

            //取得整个报表的标题			
            excel.Cells[2, 2] = strTitle;

            //设置整个报表的标题格式			
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, 2]).Font.Bold = true;
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, 2]).Font.Size = 22;

            //设置报表表格为最适应宽度			
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, colIndex]).Select();
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, colIndex]).Columns.AutoFit();

            //设置整个报表的标题为跨列居中			
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, colIndex]).Select();
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, colIndex]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenterAcrossSelection;

            //绘制边框			
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, colIndex]).Borders.LineStyle = 1;
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, 2]).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;//设置左边线加粗
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[4, colIndex]).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;//设置上边线加粗
            xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[rowSum, colIndex]).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;//设置右边线加粗
            xSt.get_Range(excel.Cells[rowSum, 2], excel.Cells[rowSum, colIndex]).Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;//设置下边线加粗



            var afterTime = DateTime.Now;

            //显示效果			
            //excel.Visible = true;
            //excel.Sheets[0] = "sss";

            // ClearFile(FilePath);
            //string filename = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xls";
            //excel.ActiveWorkbook.SaveAs(filePath, Excel.XlFileFormat.xlExcel9795, null, null, false, false, Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);

            //wkbNew.SaveAs strBookName;

            try
            {
                excel.Save();
            }
            catch (Exception)
            {

                return;
            }

            #region  结束Excel进程

            //需要对Excel的DCOM对象进行配置:dcomcnfg


            //excel.Quit();
            //excel=null;            

            xBk.Close(null, null, null);
            excel.Workbooks.Close();
            excel.Quit();


            //注意：这里用到的所有Excel对象都要执行这个操作，否则结束不了Excel进程
            //			if(rng != null)
            //			{
            //				System.Runtime.InteropServices.Marshal.ReleaseComObject(rng);
            //				rng = null;
            //			}
            //			if(tb != null)
            //			{
            //				System.Runtime.InteropServices.Marshal.ReleaseComObject(tb);
            //				tb = null;
            //			}
            if (xSt != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xSt);
                xSt = null;
            }
            if (xBk != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xBk);
                xBk = null;
            }
            if (excel != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                excel = null;
            }
            GC.Collect();//垃圾回收
            #endregion

            return;

        }
        #endregion
        /// <summary>
        /// 将ASCII数组转为字符串
        /// </summary>
        /// <param name="c_Ascii"></param>
        /// <returns></returns>
        public static string AscII_To_String(byte[] c_AscII)
        {
            try
            {
                ASCIIEncoding asc = new ASCIIEncoding();
                return asc.GetString(c_AscII);
            }
            catch (Exception)
            {
                return "";
            }
           
        }

        public static DataTable InputFromExcel(string ExcelFilePath, string TableName)
        {
            if (!System.IO.File.Exists(ExcelFilePath))
            {
                throw new Exception("Excel文件不存在！");
            }

            //如果数据表名不存在，则数据表名为Excel文件的第一个数据表
            ArrayList TableList = new ArrayList();
            TableList = GetExcelTables(ExcelFilePath);

            if (TableName.IndexOf(TableName) < 0)
            {
                TableName = TableList[0].ToString().Trim();
            }

            DataTable table = new DataTable();
            OleDbConnection dbcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ExcelFilePath + ";Extended Properties=Excel 8.0");
            OleDbCommand cmd = new OleDbCommand("select * from [" + TableName + "$]", dbcon);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            try
            {
                if (dbcon.State == ConnectionState.Closed)
                {
                    dbcon.Open();
                }
                adapter.Fill(table);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                if (dbcon.State == ConnectionState.Open)
                {
                    dbcon.Close();
                }
            }
            return table;
        }
        private static ArrayList GetExcelTables(string ExcelFileName)
        {
            DataTable dt = new DataTable();
            ArrayList TablesList = new ArrayList();
            if (System.IO.File.Exists(ExcelFileName))
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + ExcelFileName))
                {
                    try
                    {
                        conn.Open();
                        dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    }
                    catch (Exception exp)
                    {
                        throw exp;
                    }

                    //获取数据表个数
                    int tablecount = dt.Rows.Count;
                    for (int i = 0; i < tablecount; i++)
                    {
                        string tablename = dt.Rows[i][2].ToString().Trim().TrimEnd('$');
                        if (TablesList.IndexOf(tablename) < 0)
                        {
                            TablesList.Add(tablename);
                        }
                    }
                }
            }
            return TablesList;
        }

        
    }

    /*
       1） 本辅助类主要是用来方便实现对Excel的相关操作，不需要调用Office的VBA相关类。 该导出操作是基于XML文件和OleDB格式的，
           因此导出Excel文件不需要客户端安装Excel软件，因此非常方便易用。 
       2） 辅助类可以列出Excel的所有表、列出指定表的所有列、从Excel转换为DataSet对象集合、把DataSet转换保存为Excel文件等操作。
         
   * *************************************
   * 伟本机电
   * 物流自动化
   * 王铮 2015.02.15
   **************************************
     */
    public class ExcelHelper
    {

        /// <summary>
        /// 将dataset导出至Excel
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <param name="filePath">文件名称</param>
        public static void DataSetToExcel(DataSet ds)
        {
            string filePath = FileDialogHelper.SaveExcel();
            WHC.OrderWater.Commons.ExcelHelper.DataSetToExcel(ds, filePath);

        }
        public static void DataSetToExcel(DataTable ds)
        {
            string filePath = FileDialogHelper.SaveExcel();
            WHC.OrderWater.Commons.ExcelHelper.DataSetToExcel(ds, filePath);

        }
        /// <summary>
        /// 将EXCEL转换城DateSet（第一行做列名）
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static DataSet ExcelToDataSet(string filePath)
        {
            DataSet ds = WHC.OrderWater.Commons.ExcelHelper.ExcelToDataSet(filePath, true, WHC.OrderWater.Commons.ExcelHelper.ExcelType.Excel2007);
            return ds;
        }
    }
}

