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
    public partial class FormAddGroup : Form
    {
        public FormAddGroup()
        {
            InitializeComponent();
        }

        private void btn_r_SaveDesc_Click(object sender, EventArgs e)
        {

            if (tb_r_GroupName.Text.Trim() == "")
                return;
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient())
            {
                PW_GROUP newGroup = new PW_GROUP();
                newGroup.ID = Guid.NewGuid().ToString();
                newGroup.GROUPDESCRIBE = rTB_r_GroupDesc.Text;
                newGroup.GROUPNAME = tb_r_GroupName.Text;
                if (srv.PW_Group_InsertOne(newGroup))
                {
                    MessageBox.Show(this, "保存成功!");
                    Close();
                }
                else
                {
                    MessageBox.Show(this, "保存失败!");
                }
            }
        }
    }
}
