namespace S_WCS
{
    partial class Frm_OdLst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OdLst));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMNItemFormPointName = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbContainerId = new System.Windows.Forms.Label();
            this.btnNotFin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNoFinOd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVReleaseOd = new System.Windows.Forms.DataGridView();
            this.TASKID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOURCEPLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTAINERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TASKTYPEDESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RELEASESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HADFINISH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoFinOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReleaseOd)).BeginInit();
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
            this.tsMNItemFormPointName,
            this.btn_Refresh});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(784, 40);
            this.menuStrip2.TabIndex = 33;
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
            // btn_Refresh
            // 
            this.btn_Refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(96, 36);
            this.btn_Refresh.Text = "刷新";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvNoFinOd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dGVReleaseOd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 522);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbContainerId);
            this.panel2.Controls.Add(this.btnNotFin);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(630, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 255);
            this.panel2.TabIndex = 17;
            // 
            // lbContainerId
            // 
            this.lbContainerId.AutoSize = true;
            this.lbContainerId.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbContainerId.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbContainerId.ForeColor = System.Drawing.Color.DimGray;
            this.lbContainerId.Location = new System.Drawing.Point(0, 59);
            this.lbContainerId.Name = "lbContainerId";
            this.lbContainerId.Size = new System.Drawing.Size(0, 19);
            this.lbContainerId.TabIndex = 17;
            // 
            // btnNotFin
            // 
            this.btnNotFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotFin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNotFin.ForeColor = System.Drawing.Color.Maroon;
            this.btnNotFin.Location = new System.Drawing.Point(0, 22);
            this.btnNotFin.Name = "btnNotFin";
            this.btnNotFin.Size = new System.Drawing.Size(151, 37);
            this.btnNotFin.TabIndex = 16;
            this.btnNotFin.Text = "删除一条";
            this.btnNotFin.UseVisualStyleBackColor = true;
            this.btnNotFin.Click += new System.EventHandler(this.btnNotFin_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "未执行序列";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNoFinOd
            // 
            this.dgvNoFinOd.AllowUserToAddRows = false;
            this.dgvNoFinOd.AllowUserToDeleteRows = false;
            this.dgvNoFinOd.AllowUserToOrderColumns = true;
            this.dgvNoFinOd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoFinOd.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNoFinOd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNoFinOd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoFinOd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNoFinOd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNoFinOd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoFinOd.EnableHeadersVisualStyles = false;
            this.dgvNoFinOd.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNoFinOd.Location = new System.Drawing.Point(1, 262);
            this.dgvNoFinOd.Margin = new System.Windows.Forms.Padding(1);
            this.dgvNoFinOd.MultiSelect = false;
            this.dgvNoFinOd.Name = "dgvNoFinOd";
            this.dgvNoFinOd.RowHeadersVisible = false;
            this.dgvNoFinOd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvNoFinOd.RowTemplate.Height = 23;
            this.dgvNoFinOd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoFinOd.Size = new System.Drawing.Size(625, 259);
            this.dgvNoFinOd.TabIndex = 14;
            this.dgvNoFinOd.SelectionChanged += new System.EventHandler(this.dgvNoFinOd_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TASKID";
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "任务号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SOURCEPLACE";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "源地址";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TOPLACE";
            this.dataGridViewTextBoxColumn3.FillWeight = 40F;
            this.dataGridViewTextBoxColumn3.HeaderText = "目标位";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CONTAINERNO";
            this.dataGridViewTextBoxColumn4.FillWeight = 40F;
            this.dataGridViewTextBoxColumn4.HeaderText = "托盘号";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TASKTYPEDESCRIPTION";
            this.dataGridViewTextBoxColumn5.FillWeight = 50F;
            this.dataGridViewTextBoxColumn5.HeaderText = "任务类别";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RELEASESTATUS";
            this.dataGridViewTextBoxColumn6.FillWeight = 40F;
            this.dataGridViewTextBoxColumn6.HeaderText = "下发";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HADFINISH";
            this.dataGridViewTextBoxColumn7.FillWeight = 40F;
            this.dataGridViewTextBoxColumn7.HeaderText = "完成";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UPDATETIME";
            this.dataGridViewTextBoxColumn8.FillWeight = 45F;
            this.dataGridViewTextBoxColumn8.HeaderText = "时间";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dGVReleaseOd
            // 
            this.dGVReleaseOd.AllowUserToAddRows = false;
            this.dGVReleaseOd.AllowUserToDeleteRows = false;
            this.dGVReleaseOd.AllowUserToOrderColumns = true;
            this.dGVReleaseOd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVReleaseOd.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVReleaseOd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVReleaseOd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReleaseOd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TASKID,
            this.SOURCEPLACE,
            this.TOPLACE,
            this.CONTAINERNO,
            this.TASKTYPEDESCRIPTION,
            this.RELEASESTATUS,
            this.HADFINISH,
            this.UPDATETIME});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVReleaseOd.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVReleaseOd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVReleaseOd.EnableHeadersVisualStyles = false;
            this.dGVReleaseOd.GridColor = System.Drawing.SystemColors.Control;
            this.dGVReleaseOd.Location = new System.Drawing.Point(1, 1);
            this.dGVReleaseOd.Margin = new System.Windows.Forms.Padding(1);
            this.dGVReleaseOd.MultiSelect = false;
            this.dGVReleaseOd.Name = "dGVReleaseOd";
            this.dGVReleaseOd.RowHeadersVisible = false;
            this.dGVReleaseOd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVReleaseOd.RowTemplate.Height = 23;
            this.dGVReleaseOd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVReleaseOd.Size = new System.Drawing.Size(625, 259);
            this.dGVReleaseOd.TabIndex = 12;
            // 
            // TASKID
            // 
            this.TASKID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TASKID.DataPropertyName = "TASKID";
            this.TASKID.FillWeight = 40F;
            this.TASKID.Frozen = true;
            this.TASKID.HeaderText = "任务号";
            this.TASKID.MinimumWidth = 50;
            this.TASKID.Name = "TASKID";
            this.TASKID.ReadOnly = true;
            // 
            // SOURCEPLACE
            // 
            this.SOURCEPLACE.DataPropertyName = "SOURCEPLACE";
            this.SOURCEPLACE.FillWeight = 40F;
            this.SOURCEPLACE.HeaderText = "源地址";
            this.SOURCEPLACE.MinimumWidth = 50;
            this.SOURCEPLACE.Name = "SOURCEPLACE";
            this.SOURCEPLACE.ReadOnly = true;
            // 
            // TOPLACE
            // 
            this.TOPLACE.DataPropertyName = "TOPLACE";
            this.TOPLACE.FillWeight = 40F;
            this.TOPLACE.HeaderText = "目标位";
            this.TOPLACE.MinimumWidth = 60;
            this.TOPLACE.Name = "TOPLACE";
            this.TOPLACE.ReadOnly = true;
            // 
            // CONTAINERNO
            // 
            this.CONTAINERNO.DataPropertyName = "CONTAINERNO";
            this.CONTAINERNO.FillWeight = 40F;
            this.CONTAINERNO.HeaderText = "托盘号";
            this.CONTAINERNO.MinimumWidth = 50;
            this.CONTAINERNO.Name = "CONTAINERNO";
            this.CONTAINERNO.ReadOnly = true;
            // 
            // TASKTYPEDESCRIPTION
            // 
            this.TASKTYPEDESCRIPTION.DataPropertyName = "TASKTYPEDESCRIPTION";
            this.TASKTYPEDESCRIPTION.FillWeight = 50F;
            this.TASKTYPEDESCRIPTION.HeaderText = "任务类别";
            this.TASKTYPEDESCRIPTION.MinimumWidth = 40;
            this.TASKTYPEDESCRIPTION.Name = "TASKTYPEDESCRIPTION";
            this.TASKTYPEDESCRIPTION.ReadOnly = true;
            // 
            // RELEASESTATUS
            // 
            this.RELEASESTATUS.DataPropertyName = "RELEASESTATUS";
            this.RELEASESTATUS.FillWeight = 40F;
            this.RELEASESTATUS.HeaderText = "下发";
            this.RELEASESTATUS.MinimumWidth = 40;
            this.RELEASESTATUS.Name = "RELEASESTATUS";
            this.RELEASESTATUS.ReadOnly = true;
            // 
            // HADFINISH
            // 
            this.HADFINISH.DataPropertyName = "HADFINISH";
            this.HADFINISH.FillWeight = 40F;
            this.HADFINISH.HeaderText = "完成";
            this.HADFINISH.MinimumWidth = 40;
            this.HADFINISH.Name = "HADFINISH";
            this.HADFINISH.ReadOnly = true;
            // 
            // UPDATETIME
            // 
            this.UPDATETIME.DataPropertyName = "UPDATETIME";
            this.UPDATETIME.FillWeight = 45F;
            this.UPDATETIME.HeaderText = "时间";
            this.UPDATETIME.MinimumWidth = 50;
            this.UPDATETIME.Name = "UPDATETIME";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRls);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(630, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 255);
            this.panel1.TabIndex = 16;
            // 
            // btnRls
            // 
            this.btnRls.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRls.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRls.ForeColor = System.Drawing.Color.Maroon;
            this.btnRls.Location = new System.Drawing.Point(0, 22);
            this.btnRls.Name = "btnRls";
            this.btnRls.Size = new System.Drawing.Size(151, 37);
            this.btnRls.TabIndex = 15;
            this.btnRls.Text = "删除";
            this.btnRls.UseVisualStyleBackColor = true;
            this.btnRls.Click += new System.EventHandler(this.btnRls_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "已下发任务";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_OdLst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_OdLst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务维护";
            this.Load += new System.EventHandler(this.Frm_OdLst_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoFinOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReleaseOd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem tsMNItemFormPointName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem btn_Refresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNoFinOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dGVReleaseOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TASKID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOURCEPLACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPLACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTAINERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TASKTYPEDESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn RELEASESTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HADFINISH;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATETIME;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRls;
        private System.Windows.Forms.Label lbContainerId;
        private System.Windows.Forms.Button btnNotFin;
    }
}