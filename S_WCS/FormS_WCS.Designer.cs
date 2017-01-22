namespace S_WCS
{
    partial class FormS_WCS
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch (System.Exception)
            {
               
            }
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormS_WCS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMNItemFormPointName = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TaskCancel = new System.Windows.Forms.Button();
            this.btn_AlarmReset = new System.Windows.Forms.Button();
            this.btnForceComplete = new System.Windows.Forms.Button();
            this.lbAlert = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.lbSku = new System.Windows.Forms.Label();
            this.lbContainerID = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.lbSourcePlace = new System.Windows.Forms.Label();
            this.lbTaskType = new System.Windows.Forms.Label();
            this.lbWorkMode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUnLock = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.btnEStop = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tB_ToPlace = new System.Windows.Forms.TextBox();
            this.tB_SourcePlace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSRM_XLocation = new System.Windows.Forms.Label();
            this.lbSRM_ZLocation = new System.Windows.Forms.Label();
            this.lbSRM_YLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentState = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGV_Alert = new System.Windows.Forms.DataGridView();
            this.DEVICEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALERTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALERTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmBDevice = new System.Windows.Forms.ComboBox();
            this.btnQuery_Device = new System.Windows.Forms.Button();
            this.dtPickStart_Device = new System.Windows.Forms.DateTimePicker();
            this.dtPickEnd_Device = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Export = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_SSJ3_Alert = new System.Windows.Forms.Label();
            this.lb_SSJ2_Alert = new System.Windows.Forms.Label();
            this.lb_SSJ1_Alert = new System.Windows.Forms.Label();
            this.pic_GoodsPallet = new System.Windows.Forms.PictureBox();
            this.pic_EmptyPallet = new System.Windows.Forms.PictureBox();
            this.pic_SRM = new System.Windows.Forms.PictureBox();
            this.pic_PlatForm = new System.Windows.Forms.PictureBox();
            this.picSSJRight = new System.Windows.Forms.PictureBox();
            this.picSSJLeft = new System.Windows.Forms.PictureBox();
            this.timerHandShake = new System.Windows.Forms.Timer(this.components);
            this.timerCheckAlert = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alert)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GoodsPallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EmptyPallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PlatForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSSJRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSSJLeft)).BeginInit();
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
            this.menuStrip2.Size = new System.Drawing.Size(1008, 40);
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "设备运行状态";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 657);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_TaskCancel);
            this.panel1.Controls.Add(this.btn_AlarmReset);
            this.panel1.Controls.Add(this.btnForceComplete);
            this.panel1.Controls.Add(this.lbAlert);
            this.panel1.Controls.Add(this.lbItemName);
            this.panel1.Controls.Add(this.lbSku);
            this.panel1.Controls.Add(this.lbContainerID);
            this.panel1.Controls.Add(this.lbDestination);
            this.panel1.Controls.Add(this.lbSourcePlace);
            this.panel1.Controls.Add(this.lbTaskType);
            this.panel1.Controls.Add(this.lbWorkMode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbCurrentState);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 322);
            this.panel1.TabIndex = 0;
            // 
            // btn_TaskCancel
            // 
            this.btn_TaskCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_TaskCancel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_TaskCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btn_TaskCancel.Location = new System.Drawing.Point(171, 224);
            this.btn_TaskCancel.Name = "btn_TaskCancel";
            this.btn_TaskCancel.Size = new System.Drawing.Size(236, 32);
            this.btn_TaskCancel.TabIndex = 46;
            this.btn_TaskCancel.Text = "出库任务撤回";
            this.btn_TaskCancel.UseVisualStyleBackColor = true;
            this.btn_TaskCancel.Visible = false;
            this.btn_TaskCancel.Click += new System.EventHandler(this.btn_TaskCancel_Click);
            // 
            // btn_AlarmReset
            // 
            this.btn_AlarmReset.BackColor = System.Drawing.Color.Red;
            this.btn_AlarmReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_AlarmReset.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AlarmReset.ForeColor = System.Drawing.Color.White;
            this.btn_AlarmReset.Location = new System.Drawing.Point(171, 256);
            this.btn_AlarmReset.Name = "btn_AlarmReset";
            this.btn_AlarmReset.Size = new System.Drawing.Size(236, 32);
            this.btn_AlarmReset.TabIndex = 45;
            this.btn_AlarmReset.Text = "解警复位";
            this.btn_AlarmReset.UseVisualStyleBackColor = false;
            this.btn_AlarmReset.Visible = false;
            this.btn_AlarmReset.Click += new System.EventHandler(this.btn_AlarmReset_Click);
            // 
            // btnForceComplete
            // 
            this.btnForceComplete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnForceComplete.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForceComplete.ForeColor = System.Drawing.Color.Maroon;
            this.btnForceComplete.Location = new System.Drawing.Point(171, 288);
            this.btnForceComplete.Name = "btnForceComplete";
            this.btnForceComplete.Size = new System.Drawing.Size(236, 32);
            this.btnForceComplete.TabIndex = 44;
            this.btnForceComplete.Text = "强制任务完成";
            this.btnForceComplete.UseVisualStyleBackColor = true;
            this.btnForceComplete.Visible = false;
            this.btnForceComplete.Click += new System.EventHandler(this.btnForceComplete_Click);
            // 
            // lbAlert
            // 
            this.lbAlert.AutoSize = true;
            this.lbAlert.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAlert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAlert.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbAlert.Location = new System.Drawing.Point(171, 199);
            this.lbAlert.Margin = new System.Windows.Forms.Padding(10);
            this.lbAlert.Name = "lbAlert";
            this.lbAlert.Size = new System.Drawing.Size(40, 20);
            this.lbAlert.TabIndex = 40;
            this.lbAlert.Text = "故障:";
            this.lbAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbItemName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbItemName.Location = new System.Drawing.Point(171, 179);
            this.lbItemName.Margin = new System.Windows.Forms.Padding(10);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(90, 20);
            this.lbItemName.TabIndex = 43;
            this.lbItemName.Text = "物料名称: XX";
            this.lbItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSku
            // 
            this.lbSku.AutoSize = true;
            this.lbSku.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSku.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbSku.Location = new System.Drawing.Point(171, 159);
            this.lbSku.Margin = new System.Windows.Forms.Padding(10);
            this.lbSku.Name = "lbSku";
            this.lbSku.Size = new System.Drawing.Size(76, 20);
            this.lbSku.TabIndex = 42;
            this.lbSku.Text = "物料号: XX";
            this.lbSku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbContainerID
            // 
            this.lbContainerID.AutoSize = true;
            this.lbContainerID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbContainerID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbContainerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbContainerID.Location = new System.Drawing.Point(171, 139);
            this.lbContainerID.Margin = new System.Windows.Forms.Padding(10);
            this.lbContainerID.Name = "lbContainerID";
            this.lbContainerID.Size = new System.Drawing.Size(117, 20);
            this.lbContainerID.TabIndex = 41;
            this.lbContainerID.Text = "托盘号 TPXXXXX";
            this.lbContainerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDestination.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbDestination.Location = new System.Drawing.Point(171, 119);
            this.lbDestination.Margin = new System.Windows.Forms.Padding(10);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(103, 20);
            this.lbDestination.TabIndex = 39;
            this.lbDestination.Text = "目标位: XXXXX";
            this.lbDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSourcePlace
            // 
            this.lbSourcePlace.AutoSize = true;
            this.lbSourcePlace.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSourcePlace.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSourcePlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbSourcePlace.Location = new System.Drawing.Point(171, 99);
            this.lbSourcePlace.Margin = new System.Windows.Forms.Padding(10);
            this.lbSourcePlace.Name = "lbSourcePlace";
            this.lbSourcePlace.Size = new System.Drawing.Size(103, 20);
            this.lbSourcePlace.TabIndex = 38;
            this.lbSourcePlace.Text = "起始位: XXXXX";
            this.lbSourcePlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTaskType
            // 
            this.lbTaskType.AutoSize = true;
            this.lbTaskType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTaskType.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTaskType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbTaskType.Location = new System.Drawing.Point(171, 79);
            this.lbTaskType.Margin = new System.Windows.Forms.Padding(10);
            this.lbTaskType.Name = "lbTaskType";
            this.lbTaskType.Size = new System.Drawing.Size(90, 20);
            this.lbTaskType.TabIndex = 37;
            this.lbTaskType.Text = "作业指令: XX";
            this.lbTaskType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWorkMode
            // 
            this.lbWorkMode.AutoSize = true;
            this.lbWorkMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWorkMode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWorkMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbWorkMode.Location = new System.Drawing.Point(171, 59);
            this.lbWorkMode.Margin = new System.Windows.Forms.Padding(10);
            this.lbWorkMode.Name = "lbWorkMode";
            this.lbWorkMode.Size = new System.Drawing.Size(90, 20);
            this.lbWorkMode.TabIndex = 36;
            this.lbWorkMode.Text = "工作状态: XX";
            this.lbWorkMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(171, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "工作状态";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnUnLock);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.pnlFunction);
            this.panel2.Controls.Add(this.lbSRM_XLocation);
            this.panel2.Controls.Add(this.lbSRM_ZLocation);
            this.panel2.Controls.Add(this.lbSRM_YLocation);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 287);
            this.panel2.TabIndex = 34;
            // 
            // btnUnLock
            // 
            this.btnUnLock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUnLock.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnLock.ForeColor = System.Drawing.Color.Maroon;
            this.btnUnLock.Location = new System.Drawing.Point(0, 203);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(169, 31);
            this.btnUnLock.TabIndex = 40;
            this.btnUnLock.Text = "功能解锁";
            this.btnUnLock.UseVisualStyleBackColor = true;
            this.btnUnLock.Visible = false;
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStop.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(0, 234);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(169, 51);
            this.btnStop.TabIndex = 41;
            this.btnStop.Text = "急停";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlFunction
            // 
            this.pnlFunction.Controls.Add(this.btnEStop);
            this.pnlFunction.Controls.Add(this.btnCancle);
            this.pnlFunction.Controls.Add(this.btnSend);
            this.pnlFunction.Controls.Add(this.tB_ToPlace);
            this.pnlFunction.Controls.Add(this.tB_SourcePlace);
            this.pnlFunction.Controls.Add(this.label8);
            this.pnlFunction.Controls.Add(this.label4);
            this.pnlFunction.Controls.Add(this.label2);
            this.pnlFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFunction.Location = new System.Drawing.Point(0, 86);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(169, 168);
            this.pnlFunction.TabIndex = 39;
            this.pnlFunction.Visible = false;
            // 
            // btnEStop
            // 
            this.btnEStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEStop.Location = new System.Drawing.Point(61, 90);
            this.btnEStop.Name = "btnEStop";
            this.btnEStop.Size = new System.Drawing.Size(45, 23);
            this.btnEStop.TabIndex = 42;
            this.btnEStop.Text = "任务";
            this.btnEStop.UseVisualStyleBackColor = true;
            this.btnEStop.Click += new System.EventHandler(this.btnEStop_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancle.Location = new System.Drawing.Point(117, 90);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(45, 23);
            this.btnCancle.TabIndex = 40;
            this.btnCancle.Text = "删除";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSend.Location = new System.Drawing.Point(7, 90);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(45, 23);
            this.btnSend.TabIndex = 39;
            this.btnSend.Text = "下发";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tB_ToPlace
            // 
            this.tB_ToPlace.Location = new System.Drawing.Point(61, 61);
            this.tB_ToPlace.Name = "tB_ToPlace";
            this.tB_ToPlace.Size = new System.Drawing.Size(71, 21);
            this.tB_ToPlace.TabIndex = 38;
            // 
            // tB_SourcePlace
            // 
            this.tB_SourcePlace.Location = new System.Drawing.Point(61, 28);
            this.tB_SourcePlace.Name = "tB_SourcePlace";
            this.tB_SourcePlace.Size = new System.Drawing.Size(71, 21);
            this.tB_SourcePlace.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.label8.Location = new System.Drawing.Point(8, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "目标位:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "起始位:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "手动指令下发";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSRM_XLocation
            // 
            this.lbSRM_XLocation.AutoSize = true;
            this.lbSRM_XLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSRM_XLocation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSRM_XLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbSRM_XLocation.Location = new System.Drawing.Point(0, 66);
            this.lbSRM_XLocation.Margin = new System.Windows.Forms.Padding(10);
            this.lbSRM_XLocation.Name = "lbSRM_XLocation";
            this.lbSRM_XLocation.Size = new System.Drawing.Size(132, 20);
            this.lbSRM_XLocation.TabIndex = 38;
            this.lbSRM_XLocation.Text = "当前伸叉位置: 0000";
            this.lbSRM_XLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSRM_ZLocation
            // 
            this.lbSRM_ZLocation.AutoSize = true;
            this.lbSRM_ZLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSRM_ZLocation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSRM_ZLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbSRM_ZLocation.Location = new System.Drawing.Point(0, 46);
            this.lbSRM_ZLocation.Margin = new System.Windows.Forms.Padding(10);
            this.lbSRM_ZLocation.Name = "lbSRM_ZLocation";
            this.lbSRM_ZLocation.Size = new System.Drawing.Size(132, 20);
            this.lbSRM_ZLocation.TabIndex = 37;
            this.lbSRM_ZLocation.Text = "当前升降位置: 0000";
            this.lbSRM_ZLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSRM_YLocation
            // 
            this.lbSRM_YLocation.AutoSize = true;
            this.lbSRM_YLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSRM_YLocation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSRM_YLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(98)))));
            this.lbSRM_YLocation.Location = new System.Drawing.Point(0, 26);
            this.lbSRM_YLocation.Margin = new System.Windows.Forms.Padding(10);
            this.lbSRM_YLocation.Name = "lbSRM_YLocation";
            this.lbSRM_YLocation.Size = new System.Drawing.Size(132, 20);
            this.lbSRM_YLocation.TabIndex = 36;
            this.lbSRM_YLocation.Text = "当前行走位置: 0000";
            this.lbSRM_YLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "位置信息";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurrentState
            // 
            this.lbCurrentState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCurrentState.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCurrentState.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCurrentState.ForeColor = System.Drawing.Color.Lime;
            this.lbCurrentState.Location = new System.Drawing.Point(0, 0);
            this.lbCurrentState.Name = "lbCurrentState";
            this.lbCurrentState.Size = new System.Drawing.Size(407, 33);
            this.lbCurrentState.TabIndex = 33;
            this.lbCurrentState.Text = "堆垛机当前信息";
            this.lbCurrentState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dGV_Alert);
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(418, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 322);
            this.panel3.TabIndex = 1;
            // 
            // dGV_Alert
            // 
            this.dGV_Alert.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dGV_Alert.AllowUserToAddRows = false;
            this.dGV_Alert.AllowUserToDeleteRows = false;
            this.dGV_Alert.AllowUserToResizeRows = false;
            this.dGV_Alert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Alert.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Alert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Alert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Alert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEVICEID,
            this.ALERTID,
            this.ALERTNAME,
            this.CREATETIME});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_Alert.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_Alert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Alert.Location = new System.Drawing.Point(0, 59);
            this.dGV_Alert.MultiSelect = false;
            this.dGV_Alert.Name = "dGV_Alert";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Alert.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_Alert.RowHeadersVisible = false;
            this.dGV_Alert.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV_Alert.RowTemplate.Height = 23;
            this.dGV_Alert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Alert.Size = new System.Drawing.Size(585, 261);
            this.dGV_Alert.TabIndex = 36;
            // 
            // DEVICEID
            // 
            this.DEVICEID.DataPropertyName = "DEVICEID";
            this.DEVICEID.FillWeight = 50F;
            this.DEVICEID.HeaderText = "设备号";
            this.DEVICEID.Name = "DEVICEID";
            this.DEVICEID.ReadOnly = true;
            // 
            // ALERTID
            // 
            this.ALERTID.DataPropertyName = "ALERTID";
            this.ALERTID.FillWeight = 50F;
            this.ALERTID.HeaderText = "报警号";
            this.ALERTID.Name = "ALERTID";
            this.ALERTID.ReadOnly = true;
            // 
            // ALERTNAME
            // 
            this.ALERTNAME.DataPropertyName = "ALERTNAME";
            this.ALERTNAME.HeaderText = "报警描述";
            this.ALERTNAME.Name = "ALERTNAME";
            this.ALERTNAME.ReadOnly = true;
            // 
            // CREATETIME
            // 
            this.CREATETIME.DataPropertyName = "CREATETIME";
            this.CREATETIME.HeaderText = "报警时间";
            this.CREATETIME.Name = "CREATETIME";
            this.CREATETIME.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.Controls.Add(this.cmBDevice, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQuery_Device, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtPickStart_Device, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtPickEnd_Device, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Export, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(585, 26);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // cmBDevice
            // 
            this.cmBDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmBDevice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmBDevice.FormattingEnabled = true;
            this.cmBDevice.Items.AddRange(new object[] {
            "堆垛机",
            "输送机1",
            "输送机2",
            "输送机3"});
            this.cmBDevice.Location = new System.Drawing.Point(2, 2);
            this.cmBDevice.Margin = new System.Windows.Forms.Padding(1);
            this.cmBDevice.Name = "cmBDevice";
            this.cmBDevice.Size = new System.Drawing.Size(81, 22);
            this.cmBDevice.TabIndex = 0;
            // 
            // btnQuery_Device
            // 
            this.btnQuery_Device.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuery_Device.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery_Device.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQuery_Device.Location = new System.Drawing.Point(389, 4);
            this.btnQuery_Device.Name = "btnQuery_Device";
            this.btnQuery_Device.Size = new System.Drawing.Size(94, 23);
            this.btnQuery_Device.TabIndex = 1;
            this.btnQuery_Device.Text = "查询";
            this.btnQuery_Device.UseVisualStyleBackColor = true;
            this.btnQuery_Device.Click += new System.EventHandler(this.btnQuery_Device_Click);
            // 
            // dtPickStart_Device
            // 
            this.dtPickStart_Device.Location = new System.Drawing.Point(88, 4);
            this.dtPickStart_Device.Name = "dtPickStart_Device";
            this.dtPickStart_Device.Size = new System.Drawing.Size(119, 21);
            this.dtPickStart_Device.TabIndex = 2;
            // 
            // dtPickEnd_Device
            // 
            this.dtPickEnd_Device.Location = new System.Drawing.Point(249, 4);
            this.dtPickEnd_Device.Name = "dtPickEnd_Device";
            this.dtPickEnd_Device.Size = new System.Drawing.Size(119, 21);
            this.dtPickEnd_Device.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(228, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "~";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Export.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Export.Location = new System.Drawing.Point(490, 4);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(91, 23);
            this.btn_Export.TabIndex = 1;
            this.btn_Export.Text = "导出";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(585, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "设备运行信息记录";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.lb_SSJ3_Alert);
            this.panel4.Controls.Add(this.lb_SSJ2_Alert);
            this.panel4.Controls.Add(this.lb_SSJ1_Alert);
            this.panel4.Controls.Add(this.pic_GoodsPallet);
            this.panel4.Controls.Add(this.pic_EmptyPallet);
            this.panel4.Controls.Add(this.pic_SRM);
            this.panel4.Controls.Add(this.pic_PlatForm);
            this.panel4.Controls.Add(this.picSSJRight);
            this.panel4.Controls.Add(this.picSSJLeft);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1002, 323);
            this.panel4.TabIndex = 2;
            // 
            // lb_SSJ3_Alert
            // 
            this.lb_SSJ3_Alert.AutoSize = true;
            this.lb_SSJ3_Alert.BackColor = System.Drawing.Color.White;
            this.lb_SSJ3_Alert.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SSJ3_Alert.ForeColor = System.Drawing.Color.Lime;
            this.lb_SSJ3_Alert.Location = new System.Drawing.Point(824, 259);
            this.lb_SSJ3_Alert.Name = "lb_SSJ3_Alert";
            this.lb_SSJ3_Alert.Size = new System.Drawing.Size(42, 21);
            this.lb_SSJ3_Alert.TabIndex = 8;
            this.lb_SSJ3_Alert.Text = "正常";
            // 
            // lb_SSJ2_Alert
            // 
            this.lb_SSJ2_Alert.AutoSize = true;
            this.lb_SSJ2_Alert.BackColor = System.Drawing.Color.White;
            this.lb_SSJ2_Alert.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SSJ2_Alert.ForeColor = System.Drawing.Color.Lime;
            this.lb_SSJ2_Alert.Location = new System.Drawing.Point(219, 259);
            this.lb_SSJ2_Alert.Name = "lb_SSJ2_Alert";
            this.lb_SSJ2_Alert.Size = new System.Drawing.Size(42, 21);
            this.lb_SSJ2_Alert.TabIndex = 7;
            this.lb_SSJ2_Alert.Text = "正常";
            // 
            // lb_SSJ1_Alert
            // 
            this.lb_SSJ1_Alert.AutoSize = true;
            this.lb_SSJ1_Alert.BackColor = System.Drawing.Color.White;
            this.lb_SSJ1_Alert.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_SSJ1_Alert.ForeColor = System.Drawing.Color.Lime;
            this.lb_SSJ1_Alert.Location = new System.Drawing.Point(121, 259);
            this.lb_SSJ1_Alert.Name = "lb_SSJ1_Alert";
            this.lb_SSJ1_Alert.Size = new System.Drawing.Size(42, 21);
            this.lb_SSJ1_Alert.TabIndex = 6;
            this.lb_SSJ1_Alert.Text = "正常";
            // 
            // pic_GoodsPallet
            // 
            this.pic_GoodsPallet.Image = ((System.Drawing.Image)(resources.GetObject("pic_GoodsPallet.Image")));
            this.pic_GoodsPallet.Location = new System.Drawing.Point(43, 104);
            this.pic_GoodsPallet.Name = "pic_GoodsPallet";
            this.pic_GoodsPallet.Size = new System.Drawing.Size(39, 39);
            this.pic_GoodsPallet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_GoodsPallet.TabIndex = 5;
            this.pic_GoodsPallet.TabStop = false;
            this.pic_GoodsPallet.Visible = false;
            // 
            // pic_EmptyPallet
            // 
            this.pic_EmptyPallet.Image = ((System.Drawing.Image)(resources.GetObject("pic_EmptyPallet.Image")));
            this.pic_EmptyPallet.Location = new System.Drawing.Point(435, 104);
            this.pic_EmptyPallet.Name = "pic_EmptyPallet";
            this.pic_EmptyPallet.Size = new System.Drawing.Size(39, 39);
            this.pic_EmptyPallet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_EmptyPallet.TabIndex = 4;
            this.pic_EmptyPallet.TabStop = false;
            this.pic_EmptyPallet.Visible = false;
            // 
            // pic_SRM
            // 
            this.pic_SRM.Image = ((System.Drawing.Image)(resources.GetObject("pic_SRM.Image")));
            this.pic_SRM.Location = new System.Drawing.Point(400, 49);
            this.pic_SRM.Name = "pic_SRM";
            this.pic_SRM.Size = new System.Drawing.Size(126, 50);
            this.pic_SRM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SRM.TabIndex = 3;
            this.pic_SRM.TabStop = false;
            // 
            // pic_PlatForm
            // 
            this.pic_PlatForm.Image = ((System.Drawing.Image)(resources.GetObject("pic_PlatForm.Image")));
            this.pic_PlatForm.Location = new System.Drawing.Point(215, 145);
            this.pic_PlatForm.Name = "pic_PlatForm";
            this.pic_PlatForm.Size = new System.Drawing.Size(50, 43);
            this.pic_PlatForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PlatForm.TabIndex = 2;
            this.pic_PlatForm.TabStop = false;
            // 
            // picSSJRight
            // 
            this.picSSJRight.Image = ((System.Drawing.Image)(resources.GetObject("picSSJRight.Image")));
            this.picSSJRight.Location = new System.Drawing.Point(828, 145);
            this.picSSJRight.Name = "picSSJRight";
            this.picSSJRight.Size = new System.Drawing.Size(50, 96);
            this.picSSJRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSSJRight.TabIndex = 1;
            this.picSSJRight.TabStop = false;
            // 
            // picSSJLeft
            // 
            this.picSSJLeft.Image = ((System.Drawing.Image)(resources.GetObject("picSSJLeft.Image")));
            this.picSSJLeft.Location = new System.Drawing.Point(125, 145);
            this.picSSJLeft.Name = "picSSJLeft";
            this.picSSJLeft.Size = new System.Drawing.Size(50, 96);
            this.picSSJLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSSJLeft.TabIndex = 0;
            this.picSSJLeft.TabStop = false;
            // 
            // timerHandShake
            // 
            this.timerHandShake.Enabled = true;
            this.timerHandShake.Interval = 1000;
            this.timerHandShake.Tick += new System.EventHandler(this.timerHandShake_Tick);
            // 
            // timerCheckAlert
            // 
            this.timerCheckAlert.Enabled = true;
            this.timerCheckAlert.Interval = 500;
            // 
            // FormS_WCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormS_WCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备监控";
            this.Load += new System.EventHandler(this.FormS_WCS_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlFunction.ResumeLayout(false);
            this.pnlFunction.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Alert)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GoodsPallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EmptyPallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PlatForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSSJRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSSJLeft)).EndInit();
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
        private System.Windows.Forms.Label lbAlert;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbSourcePlace;
        private System.Windows.Forms.Label lbTaskType;
        private System.Windows.Forms.Label lbWorkMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Button btnEStop;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tB_ToPlace;
        private System.Windows.Forms.TextBox tB_SourcePlace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSRM_XLocation;
        private System.Windows.Forms.Label lbSRM_ZLocation;
        private System.Windows.Forms.Label lbSRM_YLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCurrentState;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dGV_Alert;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEVICEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALERTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALERTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATETIME;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmBDevice;
        private System.Windows.Forms.Button btnQuery_Device;
        private System.Windows.Forms.DateTimePicker dtPickStart_Device;
        private System.Windows.Forms.DateTimePicker dtPickEnd_Device;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pic_GoodsPallet;
        private System.Windows.Forms.PictureBox pic_EmptyPallet;
        private System.Windows.Forms.PictureBox pic_SRM;
        private System.Windows.Forms.PictureBox pic_PlatForm;
        private System.Windows.Forms.PictureBox picSSJRight;
        private System.Windows.Forms.PictureBox picSSJLeft;
        private System.Windows.Forms.Timer timerHandShake;
        private System.Windows.Forms.Timer timerCheckAlert;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label lbSku;
        private System.Windows.Forms.Label lbContainerID;
        private System.Windows.Forms.Button btnForceComplete;
        private System.Windows.Forms.Button btn_AlarmReset;
        private System.Windows.Forms.Button btn_TaskCancel;
        private System.Windows.Forms.Button btnUnLock;
        private System.Windows.Forms.Label lb_SSJ3_Alert;
        private System.Windows.Forms.Label lb_SSJ2_Alert;
        private System.Windows.Forms.Label lb_SSJ1_Alert;
    }
}

