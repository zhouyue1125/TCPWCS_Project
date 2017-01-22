using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASRS_Volvo.ServiceForVolvo;

namespace ASRS_ChangAn.UIFolder.BasisSetting
{
    public partial class FormPlaceMain : Form
    {
        List<PL_Place> lst = null;
        public FormPlaceMain()
        {
            InitializeComponent();
            dGVPlaceInfo.AutoGenerateColumns = false;
        }
        private void filtLocationByRowColumnLayer(string row, string col, string layer)
        {
            try
            {
                using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    List<PL_Place> lisPlaces = srv.PL_PLACE_FiltLocationByRowColumnLayer(row, col, layer).ToList();
                    dGVPlaceInfo.DataSource = null;
                    dGVPlaceInfo.DataSource = lisPlaces;
                }
            }
            catch
            {
            }
        }
        private void btnFind_MouseHover(object sender, EventArgs e)
        {
            AddToolTip(btnFind, "查找");
        }

        private void btn_Edit_MouseHover(object sender, EventArgs e)
        {
            AddToolTip(btn_Edit, "修改");
        }

        private void btn_Delete_MouseHover(object sender, EventArgs e)
        {
            AddToolTip(btn_Delete, "删除");
        }

        private void btn_Export_MouseHover(object sender, EventArgs e)
        {
            AddToolTip(btn_Export, "导出");
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            AddToolTip(btnAdd, "增加");
        }
        /// 添加悬停菜单
        /// </summary>
        /// <param name="control"></param>
        /// <param name="txt"></param>
        private void AddToolTip(Control control, string txt)
        {
            // 创建the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 设置显示样式
            toolTip1.AutoPopDelay = 2000;
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            //  设置伴随的对象.
            toolTip1.SetToolTip(control, txt);
        }


        /// <summary>
        /// 刷新DataGridview数据
        /// </summary>
        private void BindingDGVPlaces()
        {
            dGVPlaceInfo.DataSource = null;
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient())
            {
                try
                {
                    lst = srv.PL_PLACE_GetAll().ToList();
                    dGVPlaceInfo.DataSource = lst;
                }
                catch (Exception)
                {

                    dGVPlaceInfo.DataSource = null;
                }
            }
        }
       

        private void FormPlaceMain_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;

            /**************************************************/
            BindingDGVPlaces();
        }


        private void ddlRows_SelectedValueChanged(object sender, EventArgs e)
        {
            filtLocationByRowColumnLayer
           (
              (ddlRows.SelectedItem == null || ddlRows.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlRows.SelectedItem.ToString(),
              (ddlColumns.SelectedItem == null || ddlColumns.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlColumns.SelectedItem.ToString(),
              (ddlLayers.SelectedItem == null || ddlLayers.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlLayers.SelectedItem.ToString()
           );
        }
        private void ddlColumns_SelectedValueChanged(object sender, EventArgs e)
        {
            filtLocationByRowColumnLayer
          (
             (ddlRows.SelectedItem == null || ddlRows.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlRows.SelectedItem.ToString(),
             (ddlColumns.SelectedItem == null || ddlColumns.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlColumns.SelectedItem.ToString(),
             (ddlLayers.SelectedItem == null || ddlLayers.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlLayers.SelectedItem.ToString()
          );
        }
        private void ddlLayers_SelectedValueChanged(object sender, EventArgs e)
        {
            filtLocationByRowColumnLayer
          (
             (ddlRows.SelectedItem == null || ddlRows.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlRows.SelectedItem.ToString(),
             (ddlColumns.SelectedItem == null || ddlColumns.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlColumns.SelectedItem.ToString(),
             (ddlLayers.SelectedItem == null || ddlLayers.SelectedItem.ToString().Trim() == "") ? string.Empty : ddlLayers.SelectedItem.ToString()
          );
        }


        private void tBKeyWord_SizeChanged(object sender, EventArgs e)
        {
            int height = tBKeyWord.Height;
            btnFind.Height = height;
            ddlColumns.Height = height;
            ddlLayers.Height = height;
            ddlRows.Height = height;
        }

        private void tBKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFind_Click(null, null);
            }
        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = tBKeyWord.Text.Trim();
            BindingDGVPlaces();//刷新lst的数据
            if (lst == null || lst.Count == 0)
                return;
            lst = lst.FindAll(x => x.PLACEID.Contains(keyword) );
            dGVPlaceInfo.DataSource = null;
            dGVPlaceInfo.DataSource = lst;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dGVPlaceInfo.SelectedRows.Count > 0)
            {
                ASRS_Volvo.ServiceForVolvo.PL_Place placeOne = new ASRS_Volvo.ServiceForVolvo.PL_Place();
                using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient())
                {
                    for (int i = 0; i < dGVPlaceInfo.RowCount; i++)
                    {
                        placeOne.PLACEID = dGVPlaceInfo.Rows[i].Cells["PLACEID"].Value.ToString();
                        placeOne = srv.PL_PLACE_GetPlaceInfoByID(placeOne.PLACEID)[0];
                        if (dGVPlaceInfo.Rows[i].Cells["ISLOCK"].Value.ToString() == "1")
                            placeOne.ISLOCK = "1";
                        else
                            placeOne.ISLOCK = "0";
                        srv.PL_PLACE_UpdateNew(placeOne);

                    }

                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                var outPutLst = dGVPlaceInfo.DataSource as List<ASRS_Volvo.ServiceForVolvo.PL_Place>;
                dt = CommonMethod.ToDataTable(outPutLst);
            }
            catch (Exception)
            {

                return;
            }
            DataTable table = new DataTable();
            DataColumn col1 = new DataColumn("库位编号");
            DataColumn col2 = new DataColumn("排");
            DataColumn col3 = new DataColumn("列");
            DataColumn col4 = new DataColumn("层");
            DataColumn col5 = new DataColumn("锁定");
            DataColumn col6 = new DataColumn("绑定托盘");

            table.Columns.Add(col1);
            table.Columns.Add(col3);
            table.Columns.Add(col2);
            table.Columns.Add(col4);
            table.Columns.Add(col5);
            table.Columns.Add(col6);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = table.NewRow();
                dr["库位编号"] = dt.Rows[i]["PLACEID"];
                dr["排"] = dt.Rows[i]["ROWNO"];
                dr["列"] = dt.Rows[i]["COLUMNNO"];
                dr["层"] = dt.Rows[i]["LAYERNO"];
                dr["锁定"] = dt.Rows[i]["ISLOCK"];
                dr["绑定托盘"] = dt.Rows[i]["BINDCONTAINERID"];
                table.Rows.Add(dr);
            }
            CommonMethod.ExcelHelper.DataSetToExcel(table);
        }




    }
}
