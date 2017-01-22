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
    public partial class FormAlertQuery : Form
    {
        List<Device_Alert> lst = null;
        public FormAlertQuery()
        {
            InitializeComponent();
            dGVAlertQuery.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingDgv(DateTime startDate, DateTime endDate)
        {

            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                dGVAlertQuery.DataSource = null;
                lst = srv.Device_Alert_GetAllByDate(startDate, endDate, "SRM_1").ToList();
                dGVAlertQuery.DataSource = lst;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = tBKeyWord.Text.Trim();
            if (keyword == "")//如果无关键字则根据日期获取所有警告信息
                bindingDgv(dTime_Start.Value, dTime_End.Value);
            else
            {
                var newLST = new List<Device_Alert>();
                try
                {
                    newLST = dGVAlertQuery.DataSource as List<Device_Alert>;
                }
                catch (Exception)
                {
                    newLST = new List<Device_Alert>();
                }

                newLST = newLST.FindAll(x => x.ALERTNAME.Contains(keyword) || x.ALERTID.Contains(keyword) || x.DEVICEID.Contains(keyword)
                                    || x.CREATETIME.Contains(keyword));
                dGVAlertQuery.DataSource = null;
                dGVAlertQuery.DataSource = newLST;
            }
           
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
                var outPutLst = dGVAlertQuery.DataSource as List<Device_Alert>;
                dt = CommonMethod.ToDataTable(outPutLst);
            }
            catch (Exception)
            {
                return;
            }
            DataTable table = new DataTable();
            DataColumn col1 = new DataColumn("设备号");
            DataColumn col2 = new DataColumn("报警描述");
            DataColumn col3 = new DataColumn("发生时间");
            DataColumn col4 = new DataColumn("完结时间");
            DataColumn col5 = new DataColumn("持续时间(秒)");     
            table.Columns.Add(col1);
            table.Columns.Add(col3);
            table.Columns.Add(col2);
            table.Columns.Add(col4);
            table.Columns.Add(col5);          
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["设备号"] = dt.Rows[i]["DEVICEID"];             
                dr["报警描述"] = dt.Rows[i]["ALERTNAME"];
                dr["发生时间"] = dt.Rows[i]["CREATETIME"];
                dr["完结时间"] = dt.Rows[i]["FINISH_TIME"];
                dr["持续时间(秒)"] = dt.Rows[i]["TIME_OF_DURATION"];
                table.Rows.Add(dr);
            }
            CommonMethod.ExcelHelper.DataSetToExcel(table);
        }

        private void FormAlertQuery_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            /***********************************************/
        }
    }
}
