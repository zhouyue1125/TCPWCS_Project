using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using WHC.OrderWater.Commons;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ASRS_ChangAn
{
    public class CommonMethod
    {
        /// <summary>
        /// 复制行，然后用原始行中的单元格值填充副本
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static DataGridViewRow CloneWithValues(DataGridViewRow row)
        {
            DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
            for (Int32 index = 0; index < row.Cells.Count; index++)
            {
                clonedRow.Cells[index].Value = row.Cells[index].Value;
            }
            return clonedRow;
        }
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
}
