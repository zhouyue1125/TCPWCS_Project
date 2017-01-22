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
    public partial class FormAddItem : Form
    {
        public IM_Item item = null;
        public FormAddItem()
        {
            InitializeComponent();
        }

        public FormAddItem(IM_Item Item)
        {
            InitializeComponent();
            item = Item;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBSku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tBDesc.Focus();
        }

        private void tBDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tbCMCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tBSku.Text.Trim() == string.Empty)
            {
                return;
            }
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                if (item == null || item.SKU == "")
                {
                    item = new IM_Item();
                }
                else
                {
                    srv.IM_Item_DeleteOne(item.SKU);
                }
                item.ABCCLASS = "A区";
                item.COMPATIBLECODE = tbCMCode.Text.Trim();
                item.SKU = tBSku.Text.Trim();
                item.SKUDESC = tBDesc.Text.Trim();
                item.ITEMCLASS = ddlItemClass.SelectedItem.ToString();
                item.UPDATETIME = DateTime.Now.ToString("yyyy-MM-dd");
                item.UPDATEUSER = FormLogin.user.USERNAME;
                bool val = srv.IM_Item_InsertOne(item);
                if (val)
                {
                    Close();
                }
                else
                {
                    item = null;
                    MessageBox.Show(this, "保存失败!");                    
                }
            }
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
            if (item != null && item.SKU != "")
            {
                tBSku.Text = item.SKU;
                tBDesc.Text = item.SKUDESC;
                ddlItemClass.SelectedItem = item.ITEMCLASS;
                tbCMCode.Text = item.COMPATIBLECODE;
            }
            ddlItemClass.SelectedIndex = 0;
        }
    }
}
