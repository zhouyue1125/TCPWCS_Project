using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASRS_Volvo.ServiceForVolvo;

namespace ASRS_ChangAn
{
    public partial class FormLogin : Form
    {
        public static PW_User user = null;
        public FormLogin()
        {
            InitializeComponent();
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

        /// <summary>
        /// 密码校验
        /// </summary>
        /// <param name="EmpNo"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool CheckLoginSuss(string EmpNo, string password)
        {
            user = new PW_User();
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                string cesarPassword = srv.CommonMethod_StringEncoding(password);
                var _user = srv.PW_User_GetUserInfoByEmpno(EmpNo);
             
                if (_user.PASSWORD == cesarPassword)
                {
                    user = _user;
                }
                else
                {
                    user = new PW_User();
                    return false;
                }   
                if (ckBForce.Checked)
                {
                    _user.ISLOGININ = "N";
                    srv.PW_User_UpdateUserInfo(user);
                    wait(1000);
                }
                return true;
            }
           
        
          
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

            bool blogin = CheckLoginSuss(empno, password);  //调用数据库，校验逻辑

            if (!blogin)
            {
                MessageBox.Show(this, "用户名或密码错误！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.tbLoginName.Focus();
                this.tbLoginName.SelectAll();

                return;
            }
            if (user.ISLOGININ == "Y")
            {
                MessageBox.Show(this, "该用户已在别处登录！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.tbLoginName.Focus();
                this.tbLoginName.SelectAll();
                return;
            }

            user.ISLOGININ = "Y";
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                if (!srv.PW_User_UpdateUserInfo(user))
                {
                    MessageBox.Show(this, "登录失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.tbLoginName.Focus();
                    this.tbLoginName.SelectAll();
                    return;
                }
                else
                {
                    FormMain fmain = new FormMain();
                    fmain.Show();
                }
            }
            this.Hide();
        }

        private void tbLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                tbLoginPassword.Focus();
            }
        }

        private void tbLoginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
