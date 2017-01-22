using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ASRS_Volvo.ServiceForVolvo;

namespace ASRS_ChangAn
{
    public partial class FormMain : Form
    {
        Thread tdUserHandShake;
        public static string srmStatus = "";//堆垛机状态
        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UIFolder.BasisSetting.FormEmpSetting fc = null;
            foreach (Form ftemp in this.MdiChildren) //查找当前父表单所有子表单
            {
                if (ftemp is UIFolder.BasisSetting.FormEmpSetting)
                {
                    fc = (UIFolder.BasisSetting.FormEmpSetting)ftemp;
                    break;
                }
            }

            if (fc == null || fc.IsDisposed)
            {
                fc = new UIFolder.BasisSetting.FormEmpSetting();
                fc.MdiParent = this;
            }
            fc.Menu = null;
            fc.WindowState = FormWindowState.Maximized;
            fc.Show();

            fc.Activate();
        }


        /// <summary>
        /// 保持和WCS模块通讯的线程
        /// </summary>
        /// <param name="obj"></param>
        private void SRM_Communicate()
        {
            string duStatus = "";
            int n = 0;
            while (true)
            {
                try
                {
                    using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                    {

                        var srm_1 = srv.DU_Device_GetOneByDeviceId("SRM_1");
                        if (duStatus == srm_1.AISLE) n++;
                        else
                        {
                            n = 0;
                            duStatus = srm_1.AISLE;
                        }

                        if (n > 5)//3次
                        {
                            tSLableWCS.Text = "堆垛机:通讯中断";
                            tSLableWCS.BackColor = Color.Red;
                            tSLableWCS.ForeColor = Color.White;
                            srmStatus = "堆垛机:通讯中断";

                        }
                        else
                        {
                            tSLableWCS.Text = "堆垛机:正常";
                            tSLableWCS.ForeColor = Color.Lime;
                            tSLableWCS.BackColor = Color.Transparent;
                            srmStatus = "堆垛机:正常";
                        }

                    }
                }
                catch (Exception ex)
                {
                    
                }
                Thread.Sleep(800);     
                  
            }
        }
        /// <summary>
        /// 登录者信号握手
        /// </summary>
        private void LoginHandShake()
        {
            int tryCount = 0;
            string oldHandShake = string.Empty;
            while (true)
            {
                Thread.Sleep(2000);
                try
                {
                    using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                    {
                        var user = srv.PW_User_GetOneByUserID(FormLogin.user.ID);

                        if (user.ISLOGININ == "N")//如果不在线
                        {
                            MessageBox.Show("系统已离线！");
                            Environment.Exit(0);
                        }
                        if (oldHandShake != user.HANDSHAKE)
                        {
                            oldHandShake = user.HANDSHAKE;
                            tryCount = 0;
                            tSLabelDataBase.Text = "数据库连接:正常";
                            tSLabelDataBase.ForeColor = Color.Blue;
                            tSLableEmployeeNo.Text = user.ID;
                            tSLabelName.Text = user.USERNAME;
                            SRM_Communicate();
                        }
                        else
                        {
                            tryCount++;
                            tSLabelDataBase.Text = "数据库连接:中断";
                            tSLabelDataBase.ForeColor = Color.Red;
                            if (tryCount > 5)//如果连续五次握手失败则表明断线
                                user.ISLOGININ = "N";
                        }
                        user.HANDSHAKE = Guid.NewGuid().ToString();
                        srv.PW_User_UpdateUserInfo(user);


                    }
                }
                catch (Exception ex)
                {
                   
                }
            }
        }

        /// <summary>
        /// 根据组别来设置UI显示
        /// </summary>
        /// <param name="groupId"></param>
        private void SetUIByGroup(string groupName)
        {
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                var GVF_PW = srv.MODULE_VS_GROUP_GetAllByGroupName(groupName).ToList();//获取该组拥有的权限;

                foreach (ToolStripMenuItem item in menuStripMain.Items)
                {
                    foreach (ToolStripItem one in item.DropDownItems)
                    {
                        foreach (var p in GVF_PW)
                        {
                            one.Enabled = false;
                            if (one.Text == p.MODULE_NAME)
                            {
                                one.Enabled = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient())
            {
                var user = srv.PW_User_GetOneByUserID(FormLogin.user.ID);
                user.ISLOGININ = "N";
                srv.PW_User_UpdateUserInfo(user);

            }
            Environment.Exit(0);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            /*****************************************/

            SetUIByGroup(FormLogin.user.USERGROUP);

            /*****************************************/
            tdUserHandShake = new Thread(LoginHandShake);
            tdUserHandShake.IsBackground = true;
            tdUserHandShake.Start();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UIFolder.Items.FormItemsMain frm = new UIFolder.Items.FormItemsMain();
            ShowSubForm(frm);
        }

        private void miRepaireRecord_Click(object sender, EventArgs e)
        {
            UIFolder.Query.FormAlertQuery frm = new UIFolder.Query.FormAlertQuery();
            ShowSubForm(frm);
        
        }

        private void miInOutRecorder_Click(object sender, EventArgs e)
        {
            UIFolder.Query.FormInOutStockRecorder frm = new UIFolder.Query.FormInOutStockRecorder();
            ShowSubForm(frm);
     
        }

        private void miDeviceAnalysis_Click(object sender, EventArgs e)
        {
            UIFolder.Query.FormDevice frm = new UIFolder.Query.FormDevice();
            ShowSubForm(frm);
            frm.RefreshAll();
         
        }

        private void miOutPut_Click(object sender, EventArgs e)
        {
            UIFolder.WorkCenter.FormUnLoading frm = new UIFolder.WorkCenter.FormUnLoading();
            ShowSubForm(frm);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UIFolder.BasisSetting.FormPlaceMain frm = new UIFolder.BasisSetting.FormPlaceMain();
            ShowSubForm(frm);
            
        }


        private void miInPut_Click(object sender, EventArgs e)
        {
            UIFolder.WorkCenter.FrmLoading frm = new UIFolder.WorkCenter.FrmLoading();
            ShowSubForm(frm);

        }

        private void ShowSubForm(Form form)
        {
            Form fc = null;
            foreach (Form ftemp in this.MdiChildren) //查找当前父表单所有子表单
            {
                if (ftemp.GetType().Name == form.GetType().Name)
                {
                    fc = ftemp;
                    break;
                }
            }

            if (fc == null || fc.IsDisposed)
            {
                fc = Activator.CreateInstance(form.GetType()) as Form;
                fc.MdiParent = this;
            }
            fc.Menu = null;
            fc.WindowState = FormWindowState.Maximized;
            fc.Show();

            fc.Activate();
        }

       
    }
}
