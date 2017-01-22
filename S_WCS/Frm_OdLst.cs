using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S_WCS
{
    public partial class Frm_OdLst : Form
    {
        public Frm_OdLst()
        {
            InitializeComponent();
            lbContainerId.Text = "";
            dgvNoFinOd.AutoGenerateColumns = false;
            dGVReleaseOd.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            using (Web_Service.ASRS_ServiceSoapClient srv = new Web_Service.ASRS_ServiceSoapClient())
            {
                var nofinods= srv.Od_Task_GetNotFinishedTask_by_deviceID("SRM_1").ToList();
                var rlsod= srv.Od_Task_GetCurrentTaskByDeviceID("SRM_1");
                List<Web_Service.OD_Task> rlsods = new List<Web_Service.OD_Task>();
                rlsods.Add(rlsod);
                dgvNoFinOd.DataSource = null;
                dGVReleaseOd.DataSource = null;
                dgvNoFinOd.DataSource = nofinods;
                dGVReleaseOd.DataSource = rlsods;
            }
        }

        private void btnRls_Click(object sender, EventArgs e)
        {
            if (dGVReleaseOd.Rows.Count > 0)
            {
                string containerId = dGVReleaseOd.Rows[0].Cells[3].Value.ToString().Trim();

                using (Web_Service.ASRS_ServiceSoapClient srv = new Web_Service.ASRS_ServiceSoapClient())
                {
                    srv.Place_Vs_Container_DeleteOne(containerId);

                    srv.Od_Task_deleteOne(dGVReleaseOd.Rows[0].Cells[0].Value.ToString().Trim());                    
                }
                btn_Refresh_Click(null, null);
            }
        }

        private void btnNotFin_Click(object sender, EventArgs e)
        {
            if (lbContainerId.Text == "")
            {
                return;
            }
            using (Web_Service.ASRS_ServiceSoapClient srv = new Web_Service.ASRS_ServiceSoapClient())
            {
                srv.Place_Vs_Container_DeleteOne(lbContainerId.Text);

                srv.Od_Task_deleteOne(dgvNoFinOd.SelectedRows[0].Cells[0].Value.ToString().Trim());
            }
            btn_Refresh_Click(null, null);
        }

        private void dgvNoFinOd_SelectionChanged(object sender, EventArgs e)
        {
            lbContainerId.Text = "";
            if (dgvNoFinOd.SelectedRows.Count > 0)
            {
                string containerId = dgvNoFinOd.SelectedRows[0].Cells[3].Value.ToString().Trim();
                lbContainerId.Text = containerId;
            }
        }

        private void Frm_OdLst_Load(object sender, EventArgs e)
        {
            btn_Refresh_Click(null,null);
        }
    }
}
