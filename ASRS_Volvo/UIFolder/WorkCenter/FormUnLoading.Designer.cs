namespace ASRS_ChangAn.UIFolder.WorkCenter
{
    partial class FormUnLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnLoading));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMNItemFormPointName = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dGVUnLoadItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVItemQuery = new System.Windows.Forms.DataGridView();
            this.WAREHOUSENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTAINERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKUDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCC_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GateWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBKeyWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEmptyContainer = new System.Windows.Forms.Button();
            this.lsBGate = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUnLoad = new System.Windows.Forms.Button();
            this.btnTaskSecquent = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUnLoadItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItemQuery)).BeginInit();
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
            this.menuStrip2.Size = new System.Drawing.Size(784, 40);
            this.menuStrip2.TabIndex = 35;
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.dGVUnLoadItems, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dGVItemQuery, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBKeyWord, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFind, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEmptyContainer, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lsBGate, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancle, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnUnLoad, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnTaskSecquent, 3, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 522);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // dGVUnLoadItems
            // 
            this.dGVUnLoadItems.AllowUserToAddRows = false;
            this.dGVUnLoadItems.AllowUserToDeleteRows = false;
            this.dGVUnLoadItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVUnLoadItems.BackgroundColor = System.Drawing.Color.White;
            this.dGVUnLoadItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVUnLoadItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVUnLoadItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUnLoadItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.Gate});
            this.tableLayoutPanel1.SetColumnSpan(this.dGVUnLoadItems, 3);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVUnLoadItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVUnLoadItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVUnLoadItems.EnableHeadersVisualStyles = false;
            this.dGVUnLoadItems.GridColor = System.Drawing.SystemColors.Control;
            this.dGVUnLoadItems.Location = new System.Drawing.Point(1, 339);
            this.dGVUnLoadItems.Margin = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.dGVUnLoadItems.MultiSelect = false;
            this.dGVUnLoadItems.Name = "dGVUnLoadItems";
            this.dGVUnLoadItems.ReadOnly = true;
            this.dGVUnLoadItems.RowHeadersVisible = false;
            this.dGVUnLoadItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableLayoutPanel1.SetRowSpan(this.dGVUnLoadItems, 2);
            this.dGVUnLoadItems.RowTemplate.Height = 23;
            this.dGVUnLoadItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVUnLoadItems.Size = new System.Drawing.Size(663, 173);
            this.dGVUnLoadItems.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "WAREHOUSENO";
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "仓库名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PLACEID";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "库位号";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CONTAINERID";
            this.dataGridViewTextBoxColumn3.FillWeight = 40F;
            this.dataGridViewTextBoxColumn3.HeaderText = "托盘号";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ITEMSKU";
            this.dataGridViewTextBoxColumn5.FillWeight = 40F;
            this.dataGridViewTextBoxColumn5.HeaderText = "端拾器号";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SKUDESC";
            this.dataGridViewTextBoxColumn6.FillWeight = 40F;
            this.dataGridViewTextBoxColumn6.HeaderText = "端拾器名称";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OCC_QTY";
            this.dataGridViewTextBoxColumn8.FillWeight = 30F;
            this.dataGridViewTextBoxColumn8.HeaderText = "库存数量";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 35;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // Gate
            // 
            this.Gate.FillWeight = 25F;
            this.Gate.HeaderText = "出口";
            this.Gate.Name = "Gate";
            this.Gate.ReadOnly = true;
            // 
            // dGVItemQuery
            // 
            this.dGVItemQuery.AllowUserToAddRows = false;
            this.dGVItemQuery.AllowUserToDeleteRows = false;
            this.dGVItemQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVItemQuery.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVItemQuery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVItemQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItemQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WAREHOUSENO,
            this.PLACEID,
            this.CONTAINERID,
            this.ITEMSKU,
            this.SKUDESC,
            this.OCC_QTY,
            this.GateWay});
            this.tableLayoutPanel1.SetColumnSpan(this.dGVItemQuery, 3);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVItemQuery.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVItemQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVItemQuery.EnableHeadersVisualStyles = false;
            this.dGVItemQuery.GridColor = System.Drawing.SystemColors.Control;
            this.dGVItemQuery.Location = new System.Drawing.Point(1, 105);
            this.dGVItemQuery.Margin = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.dGVItemQuery.MultiSelect = false;
            this.dGVItemQuery.Name = "dGVItemQuery";
            this.dGVItemQuery.ReadOnly = true;
            this.dGVItemQuery.RowHeadersVisible = false;
            this.dGVItemQuery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableLayoutPanel1.SetRowSpan(this.dGVItemQuery, 4);
            this.dGVItemQuery.RowTemplate.Height = 23;
            this.dGVItemQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVItemQuery.Size = new System.Drawing.Size(663, 223);
            this.dGVItemQuery.TabIndex = 11;

            // 
            // WAREHOUSENO
            // 
            this.WAREHOUSENO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WAREHOUSENO.DataPropertyName = "WAREHOUSENO";
            this.WAREHOUSENO.FillWeight = 40F;
            this.WAREHOUSENO.Frozen = true;
            this.WAREHOUSENO.HeaderText = "仓库名";
            this.WAREHOUSENO.Name = "WAREHOUSENO";
            this.WAREHOUSENO.ReadOnly = true;
            this.WAREHOUSENO.Width = 70;
            // 
            // PLACEID
            // 
            this.PLACEID.DataPropertyName = "PLACEID";
            this.PLACEID.FillWeight = 40F;
            this.PLACEID.HeaderText = "库位号";
            this.PLACEID.MinimumWidth = 50;
            this.PLACEID.Name = "PLACEID";
            this.PLACEID.ReadOnly = true;
            // 
            // CONTAINERID
            // 
            this.CONTAINERID.DataPropertyName = "CONTAINERID";
            this.CONTAINERID.FillWeight = 40F;
            this.CONTAINERID.HeaderText = "托盘号";
            this.CONTAINERID.MinimumWidth = 50;
            this.CONTAINERID.Name = "CONTAINERID";
            this.CONTAINERID.ReadOnly = true;
            // 
            // ITEMSKU
            // 
            this.ITEMSKU.DataPropertyName = "ITEMSKU";
            this.ITEMSKU.FillWeight = 40F;
            this.ITEMSKU.HeaderText = "端拾器号";
            this.ITEMSKU.MinimumWidth = 60;
            this.ITEMSKU.Name = "ITEMSKU";
            this.ITEMSKU.ReadOnly = true;
            // 
            // SKUDESC
            // 
            this.SKUDESC.DataPropertyName = "ITEMDESC";
            this.SKUDESC.FillWeight = 40F;
            this.SKUDESC.HeaderText = "端拾器名称";
            this.SKUDESC.MinimumWidth = 50;
            this.SKUDESC.Name = "SKUDESC";
            this.SKUDESC.ReadOnly = true;
            // 
            // OCC_QTY
            // 
            this.OCC_QTY.DataPropertyName = "OCC_QTY";
            this.OCC_QTY.FillWeight = 40F;
            this.OCC_QTY.HeaderText = "库存数量";
            this.OCC_QTY.Name = "OCC_QTY";
            this.OCC_QTY.ReadOnly = true;
            this.OCC_QTY.Visible = false;
            // 
            // GateWay
            // 
            this.GateWay.HeaderText = "出口";
            this.GateWay.Name = "GateWay";
            this.GateWay.ReadOnly = true;
            this.GateWay.Visible = false;
            // 
            // tBKeyWord
            // 
            this.tBKeyWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBKeyWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBKeyWord.Location = new System.Drawing.Point(3, 53);
            this.tBKeyWord.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tBKeyWord.Name = "tBKeyWord";
            this.tBKeyWord.Size = new System.Drawing.Size(228, 29);
            this.tBKeyWord.TabIndex = 9;
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
            this.label2.Size = new System.Drawing.Size(782, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "出 库";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.ForeColor = System.Drawing.Color.Maroon;
            this.btnFind.Location = new System.Drawing.Point(235, 53);
            this.btnFind.Margin = new System.Windows.Forms.Padding(1);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(77, 30);
            this.btnFind.TabIndex = 4;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEmptyContainer
            // 
            this.btnEmptyContainer.BackColor = System.Drawing.Color.White;
            this.btnEmptyContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmptyContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmptyContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyContainer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEmptyContainer.ForeColor = System.Drawing.Color.Maroon;
            this.btnEmptyContainer.Location = new System.Drawing.Point(666, 53);
            this.btnEmptyContainer.Margin = new System.Windows.Forms.Padding(1);
            this.btnEmptyContainer.Name = "btnEmptyContainer";
            this.btnEmptyContainer.Size = new System.Drawing.Size(117, 31);
            this.btnEmptyContainer.TabIndex = 10;
            this.btnEmptyContainer.Text = "查找空托盘";
            this.btnEmptyContainer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmptyContainer.UseVisualStyleBackColor = false;
            this.btnEmptyContainer.Click += new System.EventHandler(this.btnEmptyContainer_Click);
            // 
            // lsBGate
            // 
            this.lsBGate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsBGate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsBGate.ForeColor = System.Drawing.Color.Maroon;
            this.lsBGate.FormattingEnabled = true;
            this.lsBGate.ItemHeight = 20;
            this.lsBGate.Items.AddRange(new object[] {
            "出入口10001"});
            this.lsBGate.Location = new System.Drawing.Point(668, 107);
            this.lsBGate.Name = "lsBGate";
            this.lsBGate.Size = new System.Drawing.Size(113, 24);
            this.lsBGate.TabIndex = 12;
            this.lsBGate.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(666, 183);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.White;
            this.btnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancle.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancle.Location = new System.Drawing.Point(666, 222);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(117, 31);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "撤销";
            this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnUnLoad
            // 
            this.btnUnLoad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnLoad.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnLoad.ForeColor = System.Drawing.Color.Maroon;
            this.btnUnLoad.Location = new System.Drawing.Point(666, 427);
            this.btnUnLoad.Margin = new System.Windows.Forms.Padding(1);
            this.btnUnLoad.Name = "btnUnLoad";
            this.btnUnLoad.Size = new System.Drawing.Size(117, 94);
            this.btnUnLoad.TabIndex = 16;
            this.btnUnLoad.Text = "全部下发";
            this.btnUnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUnLoad.UseVisualStyleBackColor = false;
            this.btnUnLoad.Click += new System.EventHandler(this.btnUnLoad_Click);
            // 
            // btnTaskSecquent
            // 
            this.btnTaskSecquent.BackColor = System.Drawing.Color.White;
            this.btnTaskSecquent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaskSecquent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskSecquent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTaskSecquent.ForeColor = System.Drawing.Color.Maroon;
            this.btnTaskSecquent.Location = new System.Drawing.Point(668, 341);
            this.btnTaskSecquent.Name = "btnTaskSecquent";
            this.btnTaskSecquent.Size = new System.Drawing.Size(113, 36);
            this.btnTaskSecquent.TabIndex = 18;
            this.btnTaskSecquent.Text = "任务序列";
            this.btnTaskSecquent.UseVisualStyleBackColor = false;
            this.btnTaskSecquent.Click += new System.EventHandler(this.btnTaskSecquent_Click);
            // 
            // FormUnLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUnLoading";
            this.Text = "FormUnLoading";
            this.Load += new System.EventHandler(this.FormUnLoading_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUnLoadItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItemQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem tsMNItemFormPointName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dGVUnLoadItems;
        private System.Windows.Forms.DataGridView dGVItemQuery;
        private System.Windows.Forms.TextBox tBKeyWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEmptyContainer;
        private System.Windows.Forms.ListBox lsBGate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUnLoad;
        private System.Windows.Forms.Button btnTaskSecquent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAREHOUSENO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTAINERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKUDESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCC_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn GateWay;
    }
}