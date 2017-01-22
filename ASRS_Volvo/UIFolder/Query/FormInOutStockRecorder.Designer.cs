namespace ASRS_ChangAn.UIFolder.Query
{
    partial class FormInOutStockRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInOutStockRecorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMNItemFormPointName = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dGVInOutStock = new System.Windows.Forms.DataGridView();
            this.WAREHOUSENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TASKTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTAINERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOURCEPLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.lbStart = new System.Windows.Forms.Label();
            this.dTime_Start = new System.Windows.Forms.DateTimePicker();
            this.lbEnd = new System.Windows.Forms.Label();
            this.dTime_End = new System.Windows.Forms.DateTimePicker();
            this.btn_Query = new System.Windows.Forms.Button();
            this.tBKeyWord = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInOutStock)).BeginInit();
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
            this.menuStrip2.Size = new System.Drawing.Size(768, 40);
            this.menuStrip2.TabIndex = 36;
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
            this.tableLayoutPanel1.Controls.Add(this.dGVInOutStock, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 484);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // dGVInOutStock
            // 
            this.dGVInOutStock.AllowUserToAddRows = false;
            this.dGVInOutStock.AllowUserToDeleteRows = false;
            this.dGVInOutStock.AllowUserToOrderColumns = true;
            this.dGVInOutStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVInOutStock.BackgroundColor = System.Drawing.Color.White;
            this.dGVInOutStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVInOutStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVInOutStock.ColumnHeadersHeight = 25;
            this.dGVInOutStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVInOutStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WAREHOUSENO,
            this.TASKTYPE,
            this.CONTAINERID,
            this.ITEMDESC,
            this.SOURCEPLACE,
            this.TOPLACE,
            this.UPDATETIME});
            this.tableLayoutPanel1.SetColumnSpan(this.dGVInOutStock, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVInOutStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVInOutStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVInOutStock.EnableHeadersVisualStyles = false;
            this.dGVInOutStock.GridColor = System.Drawing.SystemColors.Control;
            this.dGVInOutStock.Location = new System.Drawing.Point(3, 77);
            this.dGVInOutStock.MultiSelect = false;
            this.dGVInOutStock.Name = "dGVInOutStock";
            this.dGVInOutStock.ReadOnly = true;
            this.dGVInOutStock.RowHeadersVisible = false;
            this.dGVInOutStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableLayoutPanel1.SetRowSpan(this.dGVInOutStock, 2);
            this.dGVInOutStock.RowTemplate.Height = 23;
            this.dGVInOutStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVInOutStock.Size = new System.Drawing.Size(762, 383);
            this.dGVInOutStock.TabIndex = 7;
            // 
            // WAREHOUSENO
            // 
            this.WAREHOUSENO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WAREHOUSENO.DataPropertyName = "WAREHOUSENO";
            this.WAREHOUSENO.FillWeight = 40F;
            this.WAREHOUSENO.Frozen = true;
            this.WAREHOUSENO.HeaderText = "仓库号";
            this.WAREHOUSENO.Name = "WAREHOUSENO";
            this.WAREHOUSENO.ReadOnly = true;
            this.WAREHOUSENO.Width = 70;
            // 
            // TASKTYPE
            // 
            this.TASKTYPE.DataPropertyName = "TASKTYPE";
            this.TASKTYPE.FillWeight = 20F;
            this.TASKTYPE.HeaderText = "任务类型";
            this.TASKTYPE.MinimumWidth = 50;
            this.TASKTYPE.Name = "TASKTYPE";
            this.TASKTYPE.ReadOnly = true;
            // 
            // CONTAINERID
            // 
            this.CONTAINERID.DataPropertyName = "CONTAINERNO";
            this.CONTAINERID.FillWeight = 40F;
            this.CONTAINERID.HeaderText = "托盘号";
            this.CONTAINERID.MinimumWidth = 50;
            this.CONTAINERID.Name = "CONTAINERID";
            this.CONTAINERID.ReadOnly = true;
            // 
            // ITEMDESC
            // 
            this.ITEMDESC.DataPropertyName = "TASKCONTENTSTRING";
            this.ITEMDESC.FillWeight = 40F;
            this.ITEMDESC.HeaderText = "描述";
            this.ITEMDESC.Name = "ITEMDESC";
            this.ITEMDESC.ReadOnly = true;
            // 
            // SOURCEPLACE
            // 
            this.SOURCEPLACE.DataPropertyName = "SOURCEPLACE";
            this.SOURCEPLACE.FillWeight = 30F;
            this.SOURCEPLACE.HeaderText = "起始位";
            this.SOURCEPLACE.Name = "SOURCEPLACE";
            this.SOURCEPLACE.ReadOnly = true;
            // 
            // TOPLACE
            // 
            this.TOPLACE.DataPropertyName = "TOPLACE";
            this.TOPLACE.FillWeight = 30F;
            this.TOPLACE.HeaderText = "目标位";
            this.TOPLACE.Name = "TOPLACE";
            this.TOPLACE.ReadOnly = true;
            // 
            // UPDATETIME
            // 
            this.UPDATETIME.DataPropertyName = "UPDATETIME";
            this.UPDATETIME.FillWeight = 30F;
            this.UPDATETIME.HeaderText = "操作时间";
            this.UPDATETIME.Name = "UPDATETIME";
            this.UPDATETIME.ReadOnly = true;
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
            this.label2.Size = new System.Drawing.Size(766, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "出 入 库 记 录 查 询";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Export, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbStart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dTime_Start, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbEnd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dTime_End, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Query, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBKeyWord, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFind, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(762, 31);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_Export
            // 
            this.btn_Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Export.BackgroundImage")));
            this.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Location = new System.Drawing.Point(687, 3);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(72, 25);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = " ";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // lbStart
            // 
            this.lbStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStart.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(62)))), ((int)(((byte)(48)))));
            this.lbStart.Location = new System.Drawing.Point(3, 8);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(70, 23);
            this.lbStart.TabIndex = 11;
            this.lbStart.Text = "开始日期:";
            this.lbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dTime_Start
            // 
            this.dTime_Start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dTime_Start.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dTime_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTime_Start.Location = new System.Drawing.Point(79, 5);
            this.dTime_Start.Name = "dTime_Start";
            this.dTime_Start.Size = new System.Drawing.Size(93, 23);
            this.dTime_Start.TabIndex = 9;
            // 
            // lbEnd
            // 
            this.lbEnd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbEnd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(62)))), ((int)(((byte)(48)))));
            this.lbEnd.Location = new System.Drawing.Point(178, 8);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(70, 23);
            this.lbEnd.TabIndex = 12;
            this.lbEnd.Text = "截止日期:";
            this.lbEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dTime_End
            // 
            this.dTime_End.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dTime_End.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dTime_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTime_End.Location = new System.Drawing.Point(254, 5);
            this.dTime_End.Name = "dTime_End";
            this.dTime_End.Size = new System.Drawing.Size(93, 23);
            this.dTime_End.TabIndex = 10;
            // 
            // btn_Query
            // 
            this.btn_Query.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Query.BackgroundImage")));
            this.btn_Query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Query.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Query.Location = new System.Drawing.Point(353, 3);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(70, 27);
            this.btn_Query.TabIndex = 6;
            this.btn_Query.Text = " ";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Visible = false;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // tBKeyWord
            // 
            this.tBKeyWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBKeyWord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBKeyWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBKeyWord.ForeColor = System.Drawing.Color.Silver;
            this.tBKeyWord.Location = new System.Drawing.Point(429, 3);
            this.tBKeyWord.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.tBKeyWord.Name = "tBKeyWord";
            this.tBKeyWord.Size = new System.Drawing.Size(146, 29);
            this.tBKeyWord.TabIndex = 8;
            this.tBKeyWord.Click += new System.EventHandler(this.tBKeyWord_Click);
            this.tBKeyWord.SizeChanged += new System.EventHandler(this.tBKeyWord_SizeChanged);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.ForeColor = System.Drawing.Color.Maroon;
            this.btnFind.Location = new System.Drawing.Point(579, 1);
            this.btnFind.Margin = new System.Windows.Forms.Padding(1, 1, 10, 1);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 29);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "查询";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FormInOutStockRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInOutStockRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInOutStockRecorder";
            this.Load += new System.EventHandler(this.FormInOutStockRecorder_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVInOutStock)).EndInit();
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
        private System.Windows.Forms.DataGridView dGVInOutStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.DateTimePicker dTime_Start;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.DateTimePicker dTime_End;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.TextBox tBKeyWord;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAREHOUSENO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TASKTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTAINERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMDESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOURCEPLACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPLACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATETIME;
    }
}