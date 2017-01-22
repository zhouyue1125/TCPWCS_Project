namespace ASRS_ChangAn
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.muLineOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miOutPut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miInPut = new System.Windows.Forms.ToolStripMenuItem();
            this.muTableQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.miInOutRecorder = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeviceAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.miRepaireRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLableEmployeeNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLabelName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLableWCS = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSLabelDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muLineOperations,
            this.muTableQuery,
            this.toolStripMenuItem1});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 67);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // muLineOperations
            // 
            this.muLineOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.miOutPut,
            this.toolStripSeparator2,
            this.miInPut});
            this.muLineOperations.ForeColor = System.Drawing.Color.Maroon;
            this.muLineOperations.Image = ((System.Drawing.Image)(resources.GetObject("muLineOperations.Image")));
            this.muLineOperations.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.muLineOperations.Name = "muLineOperations";
            this.muLineOperations.Size = new System.Drawing.Size(104, 63);
            this.muLineOperations.Tag = "";
            this.muLineOperations.Text = "作业中心";
            this.muLineOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // miOutPut
            // 
            this.miOutPut.ForeColor = System.Drawing.Color.Maroon;
            this.miOutPut.Image = ((System.Drawing.Image)(resources.GetObject("miOutPut.Image")));
            this.miOutPut.Name = "miOutPut";
            this.miOutPut.Size = new System.Drawing.Size(152, 32);
            this.miOutPut.Tag = "作业中心_出库";
            this.miOutPut.Text = "出库";
            this.miOutPut.Click += new System.EventHandler(this.miOutPut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // miInPut
            // 
            this.miInPut.ForeColor = System.Drawing.Color.Maroon;
            this.miInPut.Name = "miInPut";
            this.miInPut.Size = new System.Drawing.Size(152, 32);
            this.miInPut.Text = "入库";
            this.miInPut.Click += new System.EventHandler(this.miInPut_Click);
            // 
            // muTableQuery
            // 
            this.muTableQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInOutRecorder,
            this.miDeviceAnalysis,
            this.miRepaireRecord});
            this.muTableQuery.ForeColor = System.Drawing.Color.Maroon;
            this.muTableQuery.Image = ((System.Drawing.Image)(resources.GetObject("muTableQuery.Image")));
            this.muTableQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.muTableQuery.Name = "muTableQuery";
            this.muTableQuery.Size = new System.Drawing.Size(104, 63);
            this.muTableQuery.Text = "综合查询";
            this.muTableQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // miInOutRecorder
            // 
            this.miInOutRecorder.ForeColor = System.Drawing.Color.Maroon;
            this.miInOutRecorder.Image = ((System.Drawing.Image)(resources.GetObject("miInOutRecorder.Image")));
            this.miInOutRecorder.Name = "miInOutRecorder";
            this.miInOutRecorder.Size = new System.Drawing.Size(224, 32);
            this.miInOutRecorder.Tag = "综合查询_出入库记录";
            this.miInOutRecorder.Text = "出入库记录查询";
            this.miInOutRecorder.Click += new System.EventHandler(this.miInOutRecorder_Click);
            // 
            // miDeviceAnalysis
            // 
            this.miDeviceAnalysis.ForeColor = System.Drawing.Color.Maroon;
            this.miDeviceAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("miDeviceAnalysis.Image")));
            this.miDeviceAnalysis.Name = "miDeviceAnalysis";
            this.miDeviceAnalysis.Size = new System.Drawing.Size(224, 32);
            this.miDeviceAnalysis.Tag = "综合查询_库房预览";
            this.miDeviceAnalysis.Text = "库房预览";
            this.miDeviceAnalysis.Click += new System.EventHandler(this.miDeviceAnalysis_Click);
            // 
            // miRepaireRecord
            // 
            this.miRepaireRecord.ForeColor = System.Drawing.Color.Maroon;
            this.miRepaireRecord.Image = ((System.Drawing.Image)(resources.GetObject("miRepaireRecord.Image")));
            this.miRepaireRecord.Name = "miRepaireRecord";
            this.miRepaireRecord.Size = new System.Drawing.Size(224, 32);
            this.miRepaireRecord.Tag = "综合查询_故障信息记录";
            this.miRepaireRecord.Text = "故障信息记录";
            this.miRepaireRecord.Click += new System.EventHandler(this.miRepaireRecord_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 63);
            this.toolStripMenuItem1.Text = "基础数据";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(164, 32);
            this.toolStripMenuItem2.Tag = "基础数据_权限管理";
            this.toolStripMenuItem2.Text = "权限管理";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 32);
            this.toolStripMenuItem3.Tag = "基础数据_物料维护";
            this.toolStripMenuItem3.Text = "物料维护";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(164, 32);
            this.toolStripMenuItem4.Tag = "基础数据_托盘维护";
            this.toolStripMenuItem4.Text = "托盘维护";
            this.toolStripMenuItem4.Visible = false;
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(164, 32);
            this.toolStripMenuItem5.Tag = "基础数据_货位设置";
            this.toolStripMenuItem5.Text = "货位设置";
            this.toolStripMenuItem5.Visible = false;
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tSLableEmployeeNo,
            this.toolStripStatusLabel2,
            this.tSLabelName,
            this.toolStripStatusLabel3,
            this.tSLableWCS,
            this.tSLabelDataBase});
            this.statusStripMain.Location = new System.Drawing.Point(0, 536);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(784, 26);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 21);
            this.toolStripStatusLabel1.Text = "工号:";
            // 
            // tSLableEmployeeNo
            // 
            this.tSLableEmployeeNo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tSLableEmployeeNo.ForeColor = System.Drawing.Color.Maroon;
            this.tSLableEmployeeNo.Name = "tSLableEmployeeNo";
            this.tSLableEmployeeNo.Size = new System.Drawing.Size(54, 21);
            this.tSLableEmployeeNo.Text = "000001";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(35, 21);
            this.toolStripStatusLabel2.Text = "姓名:";
            // 
            // tSLabelName
            // 
            this.tSLabelName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tSLabelName.ForeColor = System.Drawing.Color.Maroon;
            this.tSLabelName.Name = "tSLabelName";
            this.tSLabelName.Size = new System.Drawing.Size(36, 21);
            this.tSLabelName.Text = "张三";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(398, 21);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = " ";
            // 
            // tSLableWCS
            // 
            this.tSLableWCS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tSLableWCS.ForeColor = System.Drawing.Color.Red;
            this.tSLableWCS.Name = "tSLableWCS";
            this.tSLableWCS.Size = new System.Drawing.Size(99, 21);
            this.tSLableWCS.Text = "WCS通讯未启动";
            this.tSLableWCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSLabelDataBase
            // 
            this.tSLabelDataBase.ForeColor = System.Drawing.Color.Red;
            this.tSLabelDataBase.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.tSLabelDataBase.Name = "tSLabelDataBase";
            this.tSLabelDataBase.Size = new System.Drawing.Size(92, 21);
            this.tSLabelDataBase.Text = "数据库连接断开";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);

            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMS系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem muLineOperations;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miOutPut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem muTableQuery;
        private System.Windows.Forms.ToolStripMenuItem miInOutRecorder;
        private System.Windows.Forms.ToolStripMenuItem miDeviceAnalysis;
        private System.Windows.Forms.ToolStripMenuItem miRepaireRecord;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tSLableEmployeeNo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tSLabelName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tSLableWCS;
        private System.Windows.Forms.ToolStripStatusLabel tSLabelDataBase;
        private System.Windows.Forms.ToolStripMenuItem miInPut;
    }
}