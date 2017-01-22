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
    public partial class FormEditPeopleInfo : Form
    {
       PW_User one = null;
        public FormEditPeopleInfo()
        {
            InitializeComponent();
            getGroupToControl();
            tBUserId.Focus();

        }

        public FormEditPeopleInfo(PW_User newone)
        {
            InitializeComponent();
            getGroupToControl();
            one = newone;
            tBUserId.Enabled = false;
            tBUserId.Text = one.ID;
            tBName.Enabled = false;
            tBName.Text = one.USERNAME;
            List<PW_GROUP> ds = cmB_Group.DataSource as List<PW_GROUP>;

            try
            {
                cmB_Group.SelectedIndex = int.Parse(ds.Find(x => x.GROUPNAME == one.USERGROUP).ID);
            }
            catch (Exception)
            {

                cmB_Group.SelectedIndex = 0;
            }
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                tBPassWord.Text = srv.CommonMethod_StringDecoding(one.PASSWORD);
        }

        private void getGroupToControl()
        {
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                var allGroup = srv.PW_Group_GetAll().ToList();
                cmB_Group.DisplayMember = "GROUPNAME";
                cmB_Group.ValueMember = "GROUPNAME";
                cmB_Group.DataSource = allGroup;
            }
        }
       
         

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string peoplenName = tBName.Text.Trim();
            string userid = tBUserId.Text.Trim();
            string Password = tBPassWord.Text.Trim();
            string GroupId = cmB_Group.SelectedValue.ToString();
            if (tBPassWord.Text.Length < 8)
            {
                MessageBox.Show("密码长度小于8位!");
                tBPassWord.SelectAll();
                tBPassWord.Focus();
                return;
            }
            if (tBUserId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("工号不能为空!");
                tBUserId.SelectAll();
                tBUserId.Focus();
                return;
            }
            PW_User wkrs = new PW_User();

            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                srv.PW_User_GetOneByUserID(userid);
                wkrs.PASSWORD = srv.CommonMethod_StringEncoding(Password);//解密
                wkrs.ID = userid;
                wkrs.USERNAME = peoplenName;
                wkrs.USERGROUP = GroupId;           
                if (tBUserId.Enabled == false)
                {
                    if (srv.PW_User_UpdateUserInfo(wkrs))
                    {
                        tBUserId.Clear();
                        tBPassWord.Clear();
                        tBName.Clear();
                        tBUserId.Focus();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("保存失败!");
                        tBUserId.Focus();
                        tBUserId.SelectAll();
                        return;
                    }
                }
                else if (tBUserId.Enabled == true)
                {
                    if (srv.PW_User_InsertOne(wkrs))
                    {
                        tBUserId.Clear();
                        tBPassWord.Clear();
                        tBName.Clear();
                        tBUserId.Focus();

                    }
                    else
                    {
                        MessageBox.Show("保存失败!");
                        tBUserId.Focus();
                        tBUserId.SelectAll();
                        return;
                    }
                }
            }
        }
    }
}
