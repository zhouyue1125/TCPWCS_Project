namespace ASRS_ChangAn.UIFolder.BasisSetting
{
    partial class FormEditPeopleInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPeopleInfo));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMNItemFormPointName = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.cmB_Group = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBPassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.tsMNItemFormPointName});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(640, 40);
            this.menuStrip2.TabIndex = 31;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 36);
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tsMNItemFormPointName
            // 
            this.tsMNItemFormPointName.AutoSize = false;
            this.tsMNItemFormPointName.Enabled = false;
            this.tsMNItemFormPointName.ForeColor = System.Drawing.Color.White;
            this.tsMNItemFormPointName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsMNItemFormPointName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMNItemFormPointName.Name = "tsMNItemFormPointName";
            this.tsMNItemFormPointName.Size = new System.Drawing.Size(74, 36);
            this.tsMNItemFormPointName.Text = "   ";
            this.tsMNItemFormPointName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsMNItemFormPointName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsMNItemFormPointName.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 44);
            this.label1.TabIndex = 32;
            this.label1.Text = "人 员 信 息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 394);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.lbResult);
            this.panel1.Controls.Add(this.cmB_Group);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tBPassWord);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tBUserId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(99, 22);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(442, 308);
            this.panel1.TabIndex = 0;
            // 
            // lbResult
            // 
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(0, 290);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(442, 18);
            this.lbResult.TabIndex = 33;
            this.lbResult.Text = " ";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmB_Group
            // 
            this.cmB_Group.ForeColor = System.Drawing.Color.Maroon;
            this.cmB_Group.FormattingEnabled = true;
            this.cmB_Group.Location = new System.Drawing.Point(159, 186);
            this.cmB_Group.Name = "cmB_Group";
            this.cmB_Group.Size = new System.Drawing.Size(226, 20);
            this.cmB_Group.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(56, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "用 户 组:";
            // 
            // tBPassWord
            // 
            this.tBPassWord.ForeColor = System.Drawing.Color.Maroon;
            this.tBPassWord.Location = new System.Drawing.Point(159, 138);
            this.tBPassWord.Name = "tBPassWord";
            this.tBPassWord.PasswordChar = '*';
            this.tBPassWord.Size = new System.Drawing.Size(226, 21);
            this.tBPassWord.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(80, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "密 码:";
            // 
            // tBName
            // 
            this.tBName.ForeColor = System.Drawing.Color.Maroon;
            this.tBName.Location = new System.Drawing.Point(159, 88);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(226, 21);
            this.tBName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(80, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "姓 名:";
            // 
            // tBUserId
            // 
            this.tBUserId.ForeColor = System.Drawing.Color.Maroon;
            this.tBUserId.Location = new System.Drawing.Point(159, 41);
            this.tBUserId.Name = "tBUserId";
            this.tBUserId.Size = new System.Drawing.Size(226, 21);
            this.tBUserId.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(80, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "工 号:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 2);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(99, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(442, 55);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存设置";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormEditPeopleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormEditPeopleInfo";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem tsMNItemFormPointName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ComboBox cmB_Group;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}