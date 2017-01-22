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
    public partial class FormEmpSetting : Form
    {
        List<PW_GROUP> groupLst = new List<PW_GROUP>();
        PW_GROUP oneGroup = new PW_GROUP();
        public FormEmpSetting()
        {
            InitializeComponent();
            dGVPeopleInfo.AutoGenerateColumns = false;           
        }

        /// <summary>
        /// 初始化组列表
        /// </summary>
        private void initalLsV_Group()
        {
            lsV_r_Group.Clear();
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                groupLst = srv.PW_Group_GetAll().ToList();
                int i = groupLst.Count;
                lsV_r_Group.BeginUpdate();
                foreach (var p in groupLst)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = 0;
                    lvi.Text = p.GROUPNAME;
                    lsV_r_Group.Items.Add(lvi);
                }
                lsV_r_Group.EndUpdate();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<PW_User> lst = new List<PW_User>();
            try
            {
                lst = dGVPeopleInfo.DataSource as List<PW_User>;
            }
            catch (Exception ex)
            {
              
                return;
            }
            int index = -1;
            try
            {
                index = dGVPeopleInfo.SelectedRows[0].Index;
            }
            catch
            {
                index = -1;
            }
            if (index > -1)
            {
                PW_User one = lst[index];
                if (one.USERNAME == "001")
                {
                    MessageBox.Show("不允许删除001管理员账号!");
                    return;
                }
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    if (!srv.PW_User_DeleteUser(one.ID))
                    {
                        MessageBox.Show("删除失败!");
                        return;
                    }
                }
                lst.RemoveAt(index);
                dGVPeopleInfo.DataSource = null;
                dGVPeopleInfo.DataSource = lst;
                if (index > 0)
                {
                    index -= 1;
                    dGVPeopleInfo.Rows[index].Selected = true;
                }
            }
        }

        private void FormEmpSetting_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            ShowDGV_User();//显示用户信息
        
            initalLsV_Group();//初始化组列表
            inialGroupVsFunction();//初始化组功能
            initalcmB_PW();//初始化功能下拉框

        }

        private void initalcmB_PW()
        {
            cmB_PW.DataSource = null;
            using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                cmB_PW.DataSource = srv.MODULE_GetAll().ToList();
            }

            cmB_PW.DisplayMember = "MODULE_NAME";
        }

        private void ShowDGV_User()
        {
            List<PW_User> lst = new List<PW_User>();
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                lst = srv.PW_User_GetAll().ToList();
            }

            dGVPeopleInfo.DataSource = null;
            if (lst.Count == 0 || lst == null)//如果获取不到数据就直接退出该函数
            {
                return;
            }
            lst = (from p in lst orderby p.ID select p).ToList();
            dGVPeopleInfo.DataSource = lst;
            dGVPeopleInfo.ForeColor = Color.Maroon;
            Font font = new System.Drawing.Font(new FontFamily("微软雅黑"), 12F, FontStyle.Bold);
            dGVPeopleInfo.Columns[0].DefaultCellStyle.Font = font;
        }

        /// <summary>
        /// 刷新组功能表
        /// </summary>
        private void inialGroupVsFunction()
        {

            List<MODULE_VS_GROUP> lst = new List<MODULE_VS_GROUP>();
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                lst = srv.MODULE_VS_GROUP_GetAllByGroupName(oneGroup.GROUPNAME).ToList();
                lsB_r_PW.DataSource = null;
                if (lst.Count == 0 || lst == null)//如果获取不到数据就直接退出该函数
                    return;
                lsB_r_PW.DataSource = lst;
                lsB_r_PW.DisplayMember = "MODULE_NAME";
            }

        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormEditPeopleInfo f = new FormEditPeopleInfo();
            f.ShowDialog();
            FormEmpSetting_Load(null, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                PW_User one = new PW_User();

                var row = dGVPeopleInfo.SelectedRows[0];

                List<PW_User> lst = dGVPeopleInfo.DataSource as List<PW_User>;

                one.ID = row.Cells["ID"].Value.ToString();
                PW_User findOne = lst.Find(delegate(PW_User user)
                {
                    return user.ID == one.ID;
                });//用Find方法按工号找到此人的密码
                if (findOne.USERNAME == "001")
                {
                    MessageBox.Show("不允许修改001管理员账号!");
                    return;
                }
                one.PASSWORD = findOne.PASSWORD;
                one.USERNAME = row.Cells[1].Value.ToString();
                one.USERGROUP = row.Cells["UserGroup"].Value == null ? "" : row.Cells["UserGroup"].Value.ToString();
                FormEditPeopleInfo f = new FormEditPeopleInfo(one);
                f.ShowDialog();
            }
            FormEmpSetting_Load(null, e);
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = tBFind.Text.Trim();
            List<PW_User> lst = new List<PW_User>();
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                lst = srv.PW_User_GetAll().ToList();
                if (lst == null || lst.Count == 0)
                    return;
                lst = lst.FindAll(x => x.USERNAME.Contains(keyword) || x.ID.Contains(keyword) || x.USERGROUP.Contains(keyword));//筛选关键字
                dGVPeopleInfo.DataSource = null;
                dGVPeopleInfo.DataSource = lst;
            }
        }

        private void groupBox3_SizeChanged(object sender, EventArgs e)
        {
            lsB_r_PW.Height = (int)(groupBox3.Height * 0.72);
        }

        private void groupBox4_SizeChanged(object sender, EventArgs e)
        {
            lsB_r_User.Height = (int)(groupBox4.Height * 0.74);
        }

        private void panel3_SizeChanged(object sender, EventArgs e)
        {
            groupBox1.Height = (int)(panel3.Height * 0.85);
        }

      
        private void tBFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFind_Click(null, null);
            }
        }

      
        private void btn_r_RemoveGroup_Click(object sender, EventArgs e)
        {
            if (lsV_r_Group.Items.Count == 0||lsV_r_Group.SelectedItems.Count==0)
                return;
            string groupname = lsV_r_Group.SelectedItems[0].Text;
            if (groupLst.Count > 0)
            {
                if(groupname=="管理员"){
                    MessageBox.Show("不允许删除管理员角色!");
                    return;
                }
                using (ASRS_Volvo.ServiceForVolvo.ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    srv.PW_Group_DeleteOne(oneGroup.ID);
                    var moduls= srv.MODULE_VS_GROUP_GetAllByGroupName(oneGroup.GROUPNAME);
                    foreach (var p in moduls)
                    {
                        srv.MODULE_VS_GROUP_DeleteOne(p.ID);
                    }
                }
                
                initalLsV_Group();
                tb_r_GroupName.Clear();
                rTB_r_GroupDesc.Clear();
            }
        }

        private void btn_r_AddGroup_Click(object sender, EventArgs e)
        {
            FormAddGroup fg = new FormAddGroup();
            fg.ShowDialog();
            initalLsV_Group();
        }

        private void lsV_r_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            string groupname = "";
            if (lsV_r_Group.SelectedItems.Count == 0)
                return;
            groupname = lsV_r_Group.SelectedItems[0].Text;

            if (groupLst.Count > 0)
            {
                oneGroup = groupLst.Find(x => x.GROUPNAME == groupname);
            }
            tb_r_GroupName.Text = oneGroup.GROUPNAME;
            rTB_r_GroupDesc.Text = oneGroup.GROUPDESCRIBE;
            inialGroupVsFunction();//刷新组功能表
            inial_lsB_r_User();
        }

        /// <summary>
        /// 刷新包含用户列表
        /// </summary>
        private void inial_lsB_r_User()
        {
            lsB_r_User.DataSource = null;
            if (oneGroup == null)
                return;
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                var lst = srv.PW_User_GetAllByUserGroup(oneGroup.GROUPNAME);
                lsB_r_User.DataSource = lst;
                lsB_r_User.DisplayMember = "USERNAME";
            }
        }

        private void btn_r_SaveDesc_Click(object sender, EventArgs e)
        {
            oneGroup.GROUPNAME = tb_r_GroupName.Text;
            oneGroup.GROUPDESCRIBE = rTB_r_GroupDesc.Text;
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                srv.PW_Group_UpadteOne(oneGroup);
            }
            initalLsV_Group();
        }

        private void btn_r_PW_Add_Click(object sender, EventArgs e)
        {
            if (oneGroup.ID == null)
                return;
            var oneFunc = cmB_PW.SelectedItem as MODULE;
            MODULE_VS_GROUP oneGROUPVSFUNCTION = new MODULE_VS_GROUP();
            oneGROUPVSFUNCTION.ID = Guid.NewGuid().ToString();
            oneGROUPVSFUNCTION.MODULE_ID = oneFunc.ID;
            oneGROUPVSFUNCTION.MODULE_NAME = oneFunc.MODULE_NAME;
            oneGROUPVSFUNCTION.GROUP_DESC = oneGroup.GROUPDESCRIBE;
            oneGROUPVSFUNCTION.GROUP_NAME = oneGroup.GROUPNAME;
            List<MODULE_VS_GROUP> tmpList = new List<MODULE_VS_GROUP>();

            tmpList = lsB_r_PW.DataSource as List<MODULE_VS_GROUP>;
            if (tmpList == null)
                tmpList = new List<MODULE_VS_GROUP>();

            var tmp = tmpList.Find(x => x.MODULE_ID == oneGROUPVSFUNCTION.MODULE_ID);
            if (tmp != null)
            {
                MessageBox.Show(this, "已有该功能!");
                return;
            }
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                srv.MODULE_VS_GROUP_InsertOne(oneGROUPVSFUNCTION);
            inialGroupVsFunction();
        }

        private void btn_r_Pw_Remove_Click(object sender, EventArgs e)
        {
            if (lsB_r_PW.SelectedItem == null)
                return;
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                MODULE_VS_GROUP oneGVF = lsB_r_PW.SelectedItem as MODULE_VS_GROUP;
                srv.MODULE_VS_GROUP_DeleteOne(oneGVF.ID);
                inialGroupVsFunction();
            }
        }

        private void btnFind_MouseHover(object sender, EventArgs e)
        {
            AddToolTip(btnFind, "查找");
        }
        /// <summary>
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

        private void tBFind_SizeChanged(object sender, EventArgs e)
        {
            btnFind.Height = tBFind.Height;
        }

        private void FormEmpSetting_Load_1(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            ShowDGV_User();//显示用户信息        
            initalLsV_Group();//初始化组列表
            inialGroupVsFunction();//初始化组功能
            initalcmB_PW();//初始化功能下拉框
        }

        private void lsV_r_Group_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string groupname = "";
            if (lsV_r_Group.SelectedItems.Count == 0)
                return;
            groupname = lsV_r_Group.SelectedItems[0].Text;

            if (groupLst.Count > 0)
            {
                oneGroup = groupLst.Find(x => x.GROUPNAME == groupname);
            }
            tb_r_GroupName.Text = oneGroup.GROUPNAME;
            rTB_r_GroupDesc.Text = oneGroup.GROUPDESCRIBE;
            inialGroupVsFunction();//刷新组功能表
            inial_lsB_r_User();
        }

     
    }
}
