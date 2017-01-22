using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WebServiceForASRS.DAL
{
    public class Common_Method
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
        /// 打开新的子窗体   
        /// </summary>   
        /// <param name="strName">窗体的类名</param>   
        /// <param name="AssemblyName">窗体所在类库的名称</param>   
        /// <param name="MdiParentForm">父窗体</param>   
        public static Form CreateForm(string strName, string AssemblyName, Form MdiParentForm)
        {
            try
            {
                string path = AssemblyName;//项目的Assembly选项名称   
                string name = strName; //类的名字   
                Form doc = (Form)Assembly.Load(path).CreateInstance(name);
                doc.WindowState = FormWindowState.Maximized;
                doc.MdiParent = MdiParentForm;
                return doc;
            }
            catch (Exception)
            {

                return null;
            }
        }

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串 </returns>
        public static string EncryptDES(string encryptString, string encryptKey)
        {
           
            byte[] Keys = { 0x22, 0x44, 0x86, 0xA8, 0x9A, 0xAF, 0xCD, 0x4F };
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));//转换为字节
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();//实例化数据加密标准
                MemoryStream mStream = new MemoryStream();//实例化内存流
                //将数据流链接到加密转换的流
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString, string decryptKey)
        {
           
            byte[] Keys = { 0x22, 0x44, 0x86, 0xA8, 0x9A, 0xAF, 0xCD, 0x4F };
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        }

        /// <summary>
        /// 路桥的数据库备份
        /// </summary>
        /// <param name="bkFileName"></param>
        /// <returns></returns>
        public static bool BackUpForDB(string bkFileName)
        {
            if (System.IO.File.Exists(bkFileName))
                System.IO.File.Delete(bkFileName);
            string sqltxt = @"BACKUP DATABASE [ASRS_VOLVO] TO Disk='" + bkFileName + "'";
            DBHelper_Sqlserver dbh = new DBHelper_Sqlserver();
            int val= dbh.ExecuteNonQuery(sqltxt);
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
        public static DataTable ToDataTable(IList list)
        {
            DataTable result = new DataTable();
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

            Excel.Application excel;
            Excel._Workbook xBk;
            Excel._Worksheet xSt;

            int rowIndex = 4;
            int colIndex = 1;

            excel = new Excel.ApplicationClass();
            xBk = excel.Workbooks.Add(true);
            xSt = (Excel._Worksheet)xBk.ActiveSheet;

            //取得列标题			
            foreach (DataColumn col in dt.Columns)
            {
                colIndex++;
                excel.Cells[4, colIndex] = col.ColumnName;

                //设置标题格式为居中对齐
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).Font.Bold = true;
                xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[4, colIndex]).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
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
                        xSt.get_Range(excel.Cells[rowIndex, colIndex], excel.Cells[rowIndex, colIndex]).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;//设置日期型的字段格式为居中对齐
                    }
                    else
                        if (col.DataType == System.Type.GetType("System.String"))
                        {
                            excel.Cells[rowIndex, colIndex] = "'" + row[col.ColumnName].ToString();
                            xSt.get_Range(excel.Cells[rowIndex, colIndex], excel.Cells[rowIndex, colIndex]).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;//设置字符型的字段格式为居中对齐
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
            xSt.get_Range(excel.Cells[rowSum, 2], excel.Cells[rowSum, 2]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
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
            xSt.get_Range(excel.Cells[2, 2], excel.Cells[2, colIndex]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenterAcrossSelection;

            //绘制边框			
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, colIndex]).Borders.LineStyle = 1;
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[rowSum, 2]).Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThick;//设置左边线加粗
            xSt.get_Range(excel.Cells[4, 2], excel.Cells[4, colIndex]).Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThick;//设置上边线加粗
            xSt.get_Range(excel.Cells[4, colIndex], excel.Cells[rowSum, colIndex]).Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThick;//设置右边线加粗
            xSt.get_Range(excel.Cells[rowSum, 2], excel.Cells[rowSum, colIndex]).Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThick;//设置下边线加粗



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
                excel.DisplayAlerts = false;
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
    }
}