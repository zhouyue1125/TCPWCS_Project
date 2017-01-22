using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WCS_V3
{
    public partial class FormWCS_LoginIn : Form
    {
        OpcService.PW_User user = new OpcService.PW_User();
        
        public FormWCS_LoginIn()
        {
            InitializeComponent();
        }

        private void FormWCS_LoginIn_Load(object sender, EventArgs e)
        {

            tbLoginName.Focus();
            this.DialogResult = DialogResult.No;
        }

        /// <summary>
        /// 密码校验
        /// </summary>
        /// <param name="EmpNo"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool CheckLoginSuss(string EmpNo, string password)
        {
            using (OpcService.ASRS_ServiceSoapClient srv = new OpcService.ASRS_ServiceSoapClient())
            {
                string cesarPassword = srv.CommonMethod_StringEncoding(password);
                user = srv.PW_User_GetUserInfoByEmpno(EmpNo);
                if (user.PASSWORD == cesarPassword)
                {
                    return true;
                }
                else
                {
                    user = new OpcService.PW_User();
                    return false;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string empno, password;
            empno = tbLoginName.Text.Trim();
            if (string.Empty == empno)
            {
                MessageBox.Show("请输入用户名！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.tbLoginName.Focus();
                this.tbLoginName.SelectAll();
                return;
            }
            password = tbLoginPassword.Text.Trim();
            try
            {
                bool blogin = CheckLoginSuss(empno, password);   //调用数据库，校验逻辑

                if (!blogin)
                {
                    MessageBox.Show(this, "用户名或密码错误！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.tbLoginName.Focus();
                    this.tbLoginName.SelectAll();                    
                    return;
                }
                else
                {
                    this.Hide();
                    FormMain f = new FormMain();
                    f.ShowDialog();
                    Environment.Exit(0);
                }
                 
            }
            catch 
            {
                MessageBox.Show(this, "校验失败,请重试!");
                this.tbLoginName.Focus();
                this.tbLoginName.SelectAll();                
                return;
            }
        }

        private void tbLoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbLoginName.Clear();
            tbLoginPassword.Clear();
        }
    }
}
