namespace ASRS_ChangAn.UIFolder.BasisSetting
{
    partial class FormPlaceMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaceMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlColumns = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlLayers = new System.Windows.Forms.ComboBox();
            this.ddlRows = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.tBKeyWord = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BINDCONTAINERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISLOCK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dGVPlaceInfo = new System.Windows.Forms.DataGridView();
            this.WAREHOUSENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROWNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLUMNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAYERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMNItemFormPointName = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlaceInfo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "排";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(52, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "列";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ddlColumns
            // 
            this.ddlColumns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ddlColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlColumns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlColumns.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlColumns.ForeColor = System.Drawing.Color.Maroon;
            this.ddlColumns.FormattingEnabled = true;
            this.ddlColumns.Items.AddRange(new object[] {
            " ",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08"});
            this.ddlColumns.Location = new System.Drawing.Point(1, 2);
            this.ddlColumns.Margin = new System.Windows.Forms.Padding(1);
            this.ddlColumns.Name = "ddlColumns";
            this.ddlColumns.Size = new System.Drawing.Size(47, 29);
            this.ddlColumns.TabIndex = 25;
            this.ddlColumns.SelectedValueChanged += new System.EventHandler(this.ddlColumns_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(52, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "层";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ddlLayers
            // 
            this.ddlLayers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ddlLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlLayers.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlLayers.ForeColor = System.Drawing.Color.Maroon;
            this.ddlLayers.FormattingEnabled = true;
            this.ddlLayers.Items.AddRange(new object[] {
            " ",
            "01",
            "02",
            "03",
            "04"});
            this.ddlLayers.Location = new System.Drawing.Point(1, 2);
            this.ddlLayers.Margin = new System.Windows.Forms.Padding(1);
            this.ddlLayers.Name = "ddlLayers";
            this.ddlLayers.Size = new System.Drawing.Size(47, 29);
            this.ddlLayers.TabIndex = 26;
            this.ddlLayers.SelectedValueChanged += new System.EventHandler(this.ddlLayers_SelectedValueChanged);
            // 
            // ddlRows
            // 
            this.ddlRows.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ddlRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRows.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlRows.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddlRows.ForeColor = System.Drawing.Color.Maroon;
            this.ddlRows.FormattingEnabled = true;
            this.ddlRows.Items.AddRange(new object[] {
            " ",
            "1"});
            this.ddlRows.Location = new System.Drawing.Point(1, 2);
            this.ddlRows.Margin = new System.Windows.Forms.Padding(1);
            this.ddlRows.Name = "ddlRows";
            this.ddlRows.Size = new System.Drawing.Size(47, 29);
            this.ddlRows.TabIndex = 24;
            this.ddlRows.SelectedValueChanged += new System.EventHandler(this.ddlRows_SelectedValueChanged);
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
            this.label2.Size = new System.Drawing.Size(766, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "库 位 维 护";
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
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFind, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Edit, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Delete, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Export, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBKeyWord, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(762, 32);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ddlLayers, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(380, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(76, 32);
            this.tableLayoutPanel5.TabIndex = 29;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ddlColumns, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(304, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(76, 32);
            this.tableLayoutPanel4.TabIndex = 28;
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
            this.btnFind.Location = new System.Drawing.Point(153, 2);
            this.btnFind.Margin = new System.Windows.Forms.Padding(1, 1, 10, 1);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 29);
            this.btnFind.TabIndex = 3;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            this.btnFind.MouseHover += new System.EventHandler(this.btnFind_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(459, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = " ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Location = new System.Drawing.Point(535, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(70, 26);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = " ";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            this.btn_Edit.MouseHover += new System.EventHandler(this.btn_Edit_MouseHover);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightGray;
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(611, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(70, 26);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = " ";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.MouseHover += new System.EventHandler(this.btn_Delete_MouseHover);
            // 
            // btn_Export
            // 
            this.btn_Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Export.BackgroundImage")));
            this.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Location = new System.Drawing.Point(687, 3);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(72, 26);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = " ";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            this.btn_Export.MouseHover += new System.EventHandler(this.btn_Export_MouseHover);
            // 
            // tBKeyWord
            // 
            this.tBKeyWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBKeyWord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBKeyWord.Location = new System.Drawing.Point(3, 3);
            this.tBKeyWord.Margin = new System.Windows.Forms.Padding(3, 3, 5, 1);
            this.tBKeyWord.Name = "tBKeyWord";
            this.tBKeyWord.Size = new System.Drawing.Size(144, 29);
            this.tBKeyWord.TabIndex = 8;
            this.tBKeyWord.SizeChanged += new System.EventHandler(this.tBKeyWord_SizeChanged);
            this.tBKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBKeyWord_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Controls.Add(this.ddlRows, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(228, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(76, 32);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // BINDCONTAINERID
            // 
            this.BINDCONTAINERID.DataPropertyName = "BINDCONTAINERID";
            this.BINDCONTAINERID.FillWeight = 30F;
            this.BINDCONTAINERID.HeaderText = "绑定托盘";
            this.BINDCONTAINERID.MinimumWidth = 50;
            this.BINDCONTAINERID.Name = "BINDCONTAINERID";
            // 
            // ISLOCK
            // 
            this.ISLOCK.DataPropertyName = "ISLOCK";
            this.ISLOCK.FalseValue = "0";
            this.ISLOCK.FillWeight = 20F;
            this.ISLOCK.HeaderText = "锁定";
            this.ISLOCK.IndeterminateValue = "-1";
            this.ISLOCK.MinimumWidth = 25;
            this.ISLOCK.Name = "ISLOCK";
            this.ISLOCK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ISLOCK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ISLOCK.TrueValue = "1";
            // 
            // dGVPlaceInfo
            // 
            this.dGVPlaceInfo.AllowUserToAddRows = false;
            this.dGVPlaceInfo.AllowUserToDeleteRows = false;
            this.dGVPlaceInfo.AllowUserToOrderColumns = true;
            this.dGVPlaceInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPlaceInfo.BackgroundColor = System.Drawing.Color.White;
            this.dGVPlaceInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVPlaceInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPlaceInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVPlaceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlaceInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WAREHOUSENO,
            this.PLACEID,
            this.ROWNO,
            this.COLUMNNO,
            this.LAYERNO,
            this.ISLOCK,
            this.BINDCONTAINERID});
            this.tableLayoutPanel1.SetColumnSpan(this.dGVPlaceInfo, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPlaceInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVPlaceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVPlaceInfo.EnableHeadersVisualStyles = false;
            this.dGVPlaceInfo.GridColor = System.Drawing.SystemColors.Control;
            this.dGVPlaceInfo.Location = new System.Drawing.Point(3, 79);
            this.dGVPlaceInfo.MultiSelect = false;
            this.dGVPlaceInfo.Name = "dGVPlaceInfo";
            this.dGVPlaceInfo.RowHeadersVisible = false;
            this.dGVPlaceInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableLayoutPanel1.SetRowSpan(this.dGVPlaceInfo, 2);
            this.dGVPlaceInfo.RowTemplate.Height = 23;
            this.dGVPlaceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPlaceInfo.Size = new System.Drawing.Size(762, 402);
            this.dGVPlaceInfo.TabIndex = 7;
            // 
            // WAREHOUSENO
            // 
            this.WAREHOUSENO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WAREHOUSENO.DataPropertyName = "WAREHOUSENO";
            this.WAREHOUSENO.Frozen = true;
            this.WAREHOUSENO.HeaderText = "仓库名称";
            this.WAREHOUSENO.Name = "WAREHOUSENO";
            this.WAREHOUSENO.ReadOnly = true;
            this.WAREHOUSENO.Width = 110;
            // 
            // PLACEID
            // 
            this.PLACEID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PLACEID.DataPropertyName = "PLACEID";
            this.PLACEID.Frozen = true;
            this.PLACEID.HeaderText = "库位编号";
            this.PLACEID.Name = "PLACEID";
            this.PLACEID.ReadOnly = true;
            // 
            // ROWNO
            // 
            this.ROWNO.DataPropertyName = "ROWNO";
            this.ROWNO.FillWeight = 20F;
            this.ROWNO.HeaderText = "排";
            this.ROWNO.MinimumWidth = 100;
            this.ROWNO.Name = "ROWNO";
            this.ROWNO.ReadOnly = true;
            // 
            // COLUMNNO
            // 
            this.COLUMNNO.DataPropertyName = "COLUMNNO";
            this.COLUMNNO.FillWeight = 20F;
            this.COLUMNNO.HeaderText = "列";
            this.COLUMNNO.MinimumWidth = 100;
            this.COLUMNNO.Name = "COLUMNNO";
            this.COLUMNNO.ReadOnly = true;
            // 
            // LAYERNO
            // 
            this.LAYERNO.DataPropertyName = "LAYERNO";
            this.LAYERNO.FillWeight = 20F;
            this.LAYERNO.HeaderText = "层";
            this.LAYERNO.MinimumWidth = 25;
            this.LAYERNO.Name = "LAYERNO";
            this.LAYERNO.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dGVPlaceInfo, 0, 2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 484);
            this.tableLayoutPanel1.TabIndex = 35;
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
            this.menuStrip2.Size = new System.Drawing.Size(768, 40);
            this.menuStrip2.TabIndex = 34;
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
            // FormPlaceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormPlaceMain";
            this.Text = "库位维护";
            this.Load += new System.EventHandler(this.FormPlaceMain_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlaceInfo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlColumns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlLayers;
        private System.Windows.Forms.ComboBox ddlRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dGVPlaceInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAREHOUSENO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROWNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAYERNO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ISLOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn BINDCONTAINERID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.TextBox tBKeyWord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem tsMNItemFormPointName;
    }
}