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
    public partial class FrmLogin : Form
    {
       
        public FrmLogin()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbKeyWord.Text == "" || tbName.Text == "")
                return;
            string username = tbName.Text.Trim();
            string password = tbKeyWord.Text.Trim();
            using (Web_Service.ASRS_ServiceSoapClient srv = new Web_Service.ASRS_ServiceSoapClient())
            {
                var userone= srv.PW_User_GetOneByUserID(username);
                if (userone.PASSWORD ==srv.CommonMethod_StringEncoding( password) && (userone.USERGROUP == "管理员"||userone.USERGROUP=="维修员"))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
