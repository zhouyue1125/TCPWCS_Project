using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASRS_Volvo.ServiceForVolvo;

namespace ASRS_ChangAn.UIFolder.WorkCenter
{
    public partial class FrmOdLst : Form
    {
        public FrmOdLst()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                var nofinods = srv.Od_Task_GetNotFinishedTask_by_deviceID("SRM_1").ToList();
                var rlsod = srv.Od_Task_GetCurrentTaskByDeviceID("SRM_1");
                List<OD_Task> rlsods = new List<OD_Task>();
                rlsods.Add(rlsod);
                dgvNoFinOd.DataSource = null;
                dGVReleaseOd.DataSource = null;
                dgvNoFinOd.DataSource = nofinods;
                dGVReleaseOd.DataSource = rlsods;
            }
        }

        private void FrmOdLst_Load(object sender, EventArgs e)
        {
            dgvNoFinOd.AutoGenerateColumns = false;
            dGVReleaseOd.AutoGenerateColumns = false;
            btn_Refresh_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OD_Task tsk = new OD_Task();
            if (dgvNoFinOd.SelectedRows.Count > 0 && dgvNoFinOd.SelectedRows[0].Selected == true)
            {
                int index = dgvNoFinOd.SelectedRows[0].Index;
                tsk = (dgvNoFinOd.DataSource as List<OD_Task>)[index];
            }
            else if (dGVReleaseOd.SelectedRows.Count > 0 && dGVReleaseOd.SelectedRows[0].Selected == true)
            {

                tsk = (dGVReleaseOd.DataSource as List<OD_Task>)[0];
            }
            if (!string.IsNullOrEmpty(tsk.TASKID))
            {
                DeleteTask(tsk);
            }
            btn_Refresh_Click(null, null);
        }

        private void DeleteTask(OD_Task tsk)
        {
            if (tsk.HADFINISH == "N" && tsk.RELEASESTATUS == "Y")
            {
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    string containerID = tsk.CONTAINERNO;
                    if (srv.Od_Task_deleteOne(tsk.TASKID))  //删除当前任务
                    {
                        srv.Place_Vs_Container_DeleteOne(containerID);
                        srv.Container_Vs_Items_DeleteOneByContainerID(containerID);
                        bool bl = srv.OPC_WritePoint("S7:[300]DB540,B1", 2);   //删除堆垛机任务
                        if (bl)
                        {
                            MessageBox.Show("删除成功！");
                        }
                    }
                }
            }
            if (tsk.HADFINISH == "N" && tsk.RELEASESTATUS == "N")
            {
                if (tsk.TASKTYPEDESCRIPTION.Contains("出库"))   //如果出库的话
                {
                    using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                    {
                        string placeId = tsk.SOURCEPLACE;
                        string containerID = tsk.CONTAINERNO;
                        if (srv.Od_Task_deleteOne(tsk.TASKID))
                        {
                            List<IV_place_vs_container> lstPVC = srv.Place_Vs_Container_GetRelationshipByContainer(containerID).ToList();
                            IV_place_vs_container pvc = new IV_place_vs_container();
                            if (lstPVC.Count > 0)
                            {
                                pvc = lstPVC[0];
                                pvc.PLACEID = placeId;
                                srv.Place_Vs_Container_UpdateOne(pvc);
                            }


                        }
                    }
                }
                else if (tsk.TASKTYPEDESCRIPTION.Contains("入库")) //否则入库
                {
                    using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                    {
                        string containerID = tsk.CONTAINERNO;
                        if (srv.Od_Task_deleteOne(tsk.TASKID))
                        {
                            srv.Place_Vs_Container_DeleteOne(containerID);
                            srv.Container_Vs_Items_DeleteOneByContainerID(containerID);
                        }
                    }
                }
            }
        }

    }
}
