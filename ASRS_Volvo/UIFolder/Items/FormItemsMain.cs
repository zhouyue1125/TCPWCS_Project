using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASRS_Volvo.ServiceForVolvo;

namespace ASRS_ChangAn.UIFolder.Items
{
    public partial class FormItemsMain : Form
    {
        List<IM_Item> lst = null;
        public FormItemsMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = tBKeyWord.Text.Trim();
           List< IM_Item> lst=new List<IM_Item>();
           using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
           {
               lst = srv.IM_Item_GetAll().ToList();
           }
            if (lst == null || lst.Count == 0)
                return;
            List<IM_Item> newLST = new List<IM_Item>();
            newLST = lst.FindAll(x => (x.SKU.ToUpper().Contains(keyword.ToUpper()))||(x.COMPATIBLECODE!=null&&x.COMPATIBLECODE.Contains(keyword)) || (x.ITEMCLASS != null && x.ITEMCLASS.Contains(keyword)) || (x.SKUDESC != null && x.SKUDESC.Contains(keyword)));
            dGVItemInfo.DataSource = null;
            dGVItemInfo.DataSource = newLST;
        }

        private void tBKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnFind_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddItem f = new FormAddItem();
            f.ShowDialog();
            if (f.item != null)
            {
                lst.Add(f.item);
                dGVItemInfo.DataSource = null;
                dGVItemInfo.DataSource = lst;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            if (dGVItemInfo.SelectedRows.Count > 0)
            {
                var i = dGVItemInfo.SelectedRows[0].Cells[0].Value.ToString().Trim();
                if (lst != null && lst.Count > 0)
                {
                    var oneItem = lst.Find(x => x.SKU == i);
                    FormAddItem f = new FormAddItem(oneItem);
                    f.ShowDialog();
                    if (f.item != null)
                    {
                        var editOne = lst.Find(c => c.SKU == f.item.SKU);
                        try
                        {
                            lst.Remove(editOne);
                        }
                        catch (Exception)
                        {

                        }
                        lst.Add(f.item);
                        dGVItemInfo.DataSource = null;
                        dGVItemInfo.DataSource = lst;
                    }
                }
            }
        }
        /// <summary>
        /// 系统等待XX毫秒
        /// </summary>
        /// <param name="Milliseconds"></param>
        public static void wait(int Milliseconds)
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddMilliseconds(Milliseconds) > DateTime.Now);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult rst = MessageBox.Show(this, "是否确定要删除?!", "警告!", MessageBoxButtons.YesNo);
            if (rst == DialogResult.No)
                return;

            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                if (dGVItemInfo.SelectedRows.Count > 0)
                {
                    var i = dGVItemInfo.SelectedRows[0].Cells[0].Value.ToString().Trim();
                    if (lst != null && lst.Count > 0)
                    {
                        var oneItem = lst.Find(x => x.SKU == i);
                        srv.IM_Item_DeleteOne(oneItem.SKU);
                        lst.Remove(oneItem);
                        dGVItemInfo.DataSource = null;
                        dGVItemInfo.DataSource = lst;
                    }
                }
                
            }
           
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                var outPutLst = dGVItemInfo.DataSource as List<IM_Item>;
                dt = CommonMethod.ToDataTable(outPutLst);
            }
            catch (Exception)
            {

                return;
            }
            DataTable table = new DataTable();
            DataColumn col1 = new DataColumn("物料编号");
            DataColumn col2 = new DataColumn("物料名称");           
            DataColumn col3 = new DataColumn("物料类型");
            DataColumn col4 = new DataColumn("零件图号");
            DataColumn col5 = new DataColumn("更新时间");
            DataColumn col6 = new DataColumn("更新人");
            table.Columns.Add(col1);
            table.Columns.Add(col3);
            table.Columns.Add(col2);
            table.Columns.Add(col4);
            table.Columns.Add(col5);
            table.Columns.Add(col6);           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["物料编号"] = dt.Rows[i]["SKU"];
                dr["物料名称"] = dt.Rows[i]["SKUDESC"];             
                dr["物料类型"] = dt.Rows[i]["ITEMCLASS"];
                dr["零件图号"] = dt.Rows[i]["COMPATIBLECODE"];
                dr["更新时间"] = dt.Rows[i]["UPDATETIME"];
                dr["更新人"] = dt.Rows[i]["UPDATEUSER"];
                table.Rows.Add(dr);
            }
           CommonMethod.ExcelHelper.DataSetToExcel(table);
        }

        private void FormItemsMain_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;

            /**************************************************/
            dGVItemInfo.AutoGenerateColumns = false;
            BindingDGVitems();
        }

        private void BindingDGVitems()
        {
            bgWorkLoadAll.RunWorkerAsync();
        }

        private void bgWorkLoadAll_DoWork(object sender, DoWorkEventArgs e)
        {
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                lst = srv.IM_Item_GetAll().ToList();
            }
        }

        private void bgWorkLoadAll_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dGVItemInfo.DataSource = null;
            dGVItemInfo.DataSource = lst;
        }

     }
}
