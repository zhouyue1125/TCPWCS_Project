namespace ASRS_ChangAn.UIFolder.Items
{
    partial class FormItemsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItemsMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMNItemFormPointName = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dGVItemInfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.tBKeyWord = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.bgWorkLoadAll = new System.ComponentModel.BackgroundWorker();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKUDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMCLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPATIBLECODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItemInfo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.menuStrip2.Size = new System.Drawing.Size(776, 40);
            this.menuStrip2.TabIndex = 32;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dGVItemInfo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 495);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // dGVItemInfo
            // 
            this.dGVItemInfo.AllowUserToAddRows = false;
            this.dGVItemInfo.AllowUserToDeleteRows = false;
            this.dGVItemInfo.AllowUserToOrderColumns = true;
            this.dGVItemInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVItemInfo.BackgroundColor = System.Drawing.Color.White;
            this.dGVItemInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVItemInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItemInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.SKUDESC,
            this.ITEMCLASS,
            this.COMPATIBLECODE,
            this.UPDATETIME,
            this.UPDATEUSER});
            this.tableLayoutPanel1.SetColumnSpan(this.dGVItemInfo, 2);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVItemInfo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGVItemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVItemInfo.EnableHeadersVisualStyles = false;
            this.dGVItemInfo.GridColor = System.Drawing.SystemColors.Control;
            this.dGVItemInfo.Location = new System.Drawing.Point(3, 81);
            this.dGVItemInfo.MultiSelect = false;
            this.dGVItemInfo.Name = "dGVItemInfo";
            this.dGVItemInfo.ReadOnly = true;
            this.dGVItemInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableLayoutPanel1.SetRowSpan(this.dGVItemInfo, 2);
            this.dGVItemInfo.RowTemplate.Height = 23;
            this.dGVItemInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVItemInfo.Size = new System.Drawing.Size(770, 411);
            this.dGVItemInfo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 4);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(774, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "端 拾 器 维 护";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btnFind, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Export, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBKeyWord, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Edit, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Delete, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 33);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.ForeColor = System.Drawing.Color.Maroon;
            this.btnFind.Location = new System.Drawing.Point(155, 2);
            this.btnFind.Margin = new System.Windows.Forms.Padding(1, 1, 10, 1);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(66, 30);
            this.btnFind.TabIndex = 3;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Export.BackgroundImage")));
            this.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Location = new System.Drawing.Point(696, 3);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(71, 27);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = " ";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // tBKeyWord
            // 
            this.tBKeyWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBKeyWord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBKeyWord.Location = new System.Drawing.Point(3, 3);
            this.tBKeyWord.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.tBKeyWord.Name = "tBKeyWord";
            this.tBKeyWord.Size = new System.Drawing.Size(148, 29);
            this.tBKeyWord.TabIndex = 8;
            this.tBKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBKeyWord_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(388, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = " ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Location = new System.Drawing.Point(465, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(71, 27);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = " ";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(542, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(71, 27);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = " ";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // bgWorkLoadAll
            // 
            this.bgWorkLoadAll.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkLoadAll_DoWork);
            this.bgWorkLoadAll.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkLoadAll_RunWorkerCompleted);
            // 
            // SKU
            // 
            this.SKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SKU.DataPropertyName = "SKU";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SKU.DefaultCellStyle = dataGridViewCellStyle2;
            this.SKU.Frozen = true;
            this.SKU.HeaderText = "端拾器编号 Tolling No.";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 150;
            // 
            // SKUDESC
            // 
            this.SKUDESC.DataPropertyName = "SKUDESC";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SKUDESC.DefaultCellStyle = dataGridViewCellStyle3;
            this.SKUDESC.FillWeight = 35F;
            this.SKUDESC.HeaderText = "端拾器名称 Name of tolling";
            this.SKUDESC.MinimumWidth = 50;
            this.SKUDESC.Name = "SKUDESC";
            this.SKUDESC.ReadOnly = true;
            // 
            // ITEMCLASS
            // 
            this.ITEMCLASS.DataPropertyName = "ITEMCLASS";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ITEMCLASS.DefaultCellStyle = dataGridViewCellStyle4;
            this.ITEMCLASS.FillWeight = 20.02314F;
            this.ITEMCLASS.HeaderText = "存储单元类型 Object storage unit";
            this.ITEMCLASS.Name = "ITEMCLASS";
            this.ITEMCLASS.ReadOnly = true;
            // 
            // COMPATIBLECODE
            // 
            this.COMPATIBLECODE.DataPropertyName = "COMPATIBLECODE";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.COMPATIBLECODE.DefaultCellStyle = dataGridViewCellStyle5;
            this.COMPATIBLECODE.FillWeight = 20.01703F;
            this.COMPATIBLECODE.HeaderText = "零件图号 Part drawing No.";
            this.COMPATIBLECODE.Name = "COMPATIBLECODE";
            this.COMPATIBLECODE.ReadOnly = true;
            // 
            // UPDATETIME
            // 
            this.UPDATETIME.DataPropertyName = "UPDATETIME";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UPDATETIME.DefaultCellStyle = dataGridViewCellStyle6;
            this.UPDATETIME.FillWeight = 20.01203F;
            this.UPDATETIME.HeaderText = "更新时间 Update time";
            this.UPDATETIME.MinimumWidth = 50;
            this.UPDATETIME.Name = "UPDATETIME";
            this.UPDATETIME.ReadOnly = true;
            // 
            // UPDATEUSER
            // 
            this.UPDATEUSER.DataPropertyName = "UPDATEUSER";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UPDATEUSER.DefaultCellStyle = dataGridViewCellStyle7;
            this.UPDATEUSER.FillWeight = 20.00795F;
            this.UPDATEUSER.HeaderText = "更新人 Update person";
            this.UPDATEUSER.MinimumWidth = 30;
            this.UPDATEUSER.Name = "UPDATEUSER";
            this.UPDATEUSER.ReadOnly = true;
            // 
            // FormItemsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormItemsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormItemsMain";
            this.Load += new System.EventHandler(this.FormItemsMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVItemInfo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem tsMNItemFormPointName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dGVItemInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.TextBox tBKeyWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.ComponentModel.BackgroundWorker bgWorkLoadAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKUDESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMCLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPATIBLECODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATEUSER;
    }
}