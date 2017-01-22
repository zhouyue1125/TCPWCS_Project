using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASRS_Volvo.ServiceForVolvo;

namespace ASRS_ChangAn.UIFolder.Query
{
    public partial class FormInOutStockRecorder : Form
    {
        List<V_INOUTSTOCK> lst = null;
        public FormInOutStockRecorder()
        {
            InitializeComponent();
            dGVInOutStock.AutoGenerateColumns = false;
        }
      

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInOutStockRecorder_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            /***********************************************/
        }

        private void bindingDgv(DateTime startDate, DateTime endDate)
        {

            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                dGVInOutStock.DataSource = null;
                lst = srv.V_INOUTSTOCK_SelectByDate(startDate, endDate).ToList();
                var itemsLst = from items in lst orderby items.UPDATETIME select items;
                lst = itemsLst.ToList();
                if (lst != null && lst.Count > 0)
                {
                    foreach (var p in lst)
                    {
                        if (p.TASKTYPE == "SRM_Retrieve_Out")
                            p.TASKTYPE = "出库";
                        if (p.TASKTYPE == "SRM_Store_In")
                            p.TASKTYPE = "入库";
                    }
                }
                dGVInOutStock.DataSource = lst;
            }
        }

        private void tBKeyWord_SizeChanged(object sender, EventArgs e)
        {
            btnFind.Height = tBKeyWord.Height;
            btn_Query.Height = tBKeyWord.Height;
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            if (dTime_End.Value != null && dTime_Start.Value != null)
                bindingDgv(dTime_Start.Value, dTime_End.Value);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                var outPutLst = dGVInOutStock.DataSource as List<V_INOUTSTOCK>;
                dt = CommonMethod.ToDataTable(outPutLst);
            }
            catch (Exception)
            {
                return;
            }
            DataTable table = new DataTable();
            DataColumn col1 = new DataColumn("仓库号");
            DataColumn col2 = new DataColumn("任务类型");
            DataColumn col3 = new DataColumn("托盘号");
            DataColumn col4 = new DataColumn("描述");
            DataColumn col6 = new DataColumn("起始位");
            DataColumn col7 = new DataColumn("目标位");
            DataColumn col8 = new DataColumn("操作时间");
           
            table.Columns.Add(col1);
            table.Columns.Add(col2);
            table.Columns.Add(col3);
            table.Columns.Add(col4);           
            table.Columns.Add(col6);
            table.Columns.Add(col7);
            table.Columns.Add(col8);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["仓库号"] = dt.Rows[i]["WAREHOUSENO"];
                dr["任务类型"] = dt.Rows[i]["TASKTYPE"];
                dr["托盘号"] = dt.Rows[i]["CONTAINERNO"];
                dr["描述"] = dt.Rows[i]["TASKCONTENTSTRING"];
                dr["起始位"] = dt.Rows[i]["SOURCEPLACE"];
                dr["目标位"] = dt.Rows[i]["TOPLACE"];
                dr["操作时间"] = dt.Rows[i]["UPDATETIME"];
                table.Rows.Add(dr);
            }
            CommonMethod.ExcelHelper.DataSetToExcel(table);
        }

        private void tBKeyWord_Click(object sender, EventArgs e)
        {
            tBKeyWord.ForeColor = Color.Maroon;
            tBKeyWord.Text = "";
            tBKeyWord.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            btn_Query_Click(null, null);
            if (tBKeyWord.Text.Trim() == string.Empty)
            {
                return;
            }
            else
            {
                List<V_INOUTSTOCK> findLst = new List<V_INOUTSTOCK>();
                string keyword = tBKeyWord.Text.Trim();
                btn_Query_Click(null, null);
                findLst = lst;
                if (keyword != "")
                {
                    try
                    {
                        findLst = dGVInOutStock.DataSource as List<V_INOUTSTOCK>;
                    }
                    catch (Exception)
                    {

                        findLst = new List<V_INOUTSTOCK>();
                    }
                }
                if (findLst != null && findLst.Count > 0)
                {
                    findLst = findLst.FindAll(x => (x.CONTAINERNO != null && x.CONTAINERNO.Contains(keyword))
                              || (x.UPDATEUSER != null && x.UPDATEUSER.ToUpper().Contains(keyword.ToUpper())) || (x.TASKCONTENTSTRING != null && x.TASKCONTENTSTRING.ToUpper() == keyword.ToUpper()) ||
                              (x.TASKTYPE != null && x.TASKTYPE.ToUpper().Contains(keyword.ToUpper())) || (x.TASKCONTENTSTRING != null && x.TASKCONTENTSTRING.ToUpper().Contains(keyword.ToUpper())));

                }
                if (findLst != null && findLst.Count > 0)
                {
                    foreach (var p in findLst)
                    {
                        if (p.TASKTYPE == "SRM_Retrieve_Out")
                            p.TASKTYPE = "出库";
                        if (p.TASKTYPE == "SRM_Store_In")
                            p.TASKTYPE = "入库";
                    }
                }
                dGVInOutStock.DataSource = null;
                dGVInOutStock.DataSource = findLst;
            }
        }


    }
}
