namespace LedShow
{
    partial class frmLedDemo
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedDemo));
            this.btnOnlineGetList = new System.Windows.Forms.Button();
            this.btnOnlineServerCleanup = new System.Windows.Forms.Button();
            this.btnOnlineServerStartup = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMultiCard = new System.Windows.Forms.Button();
            this.btnBoardParam = new System.Windows.Forms.Button();
            this.btnTimerTest = new System.Windows.Forms.Button();
            this.btnVsqFile2 = new System.Windows.Forms.Button();
            this.btnClock2 = new System.Windows.Forms.Button();
            this.btnPicFile2 = new System.Windows.Forms.Button();
            this.btnDateTime2 = new System.Windows.Forms.Button();
            this.btnString2 = new System.Windows.Forms.Button();
            this.btnDib2 = new System.Windows.Forms.Button();
            this.btnText2 = new System.Windows.Forms.Button();
            this.btnAdjustTime2 = new System.Windows.Forms.Button();
            this.btnGetBright2 = new System.Windows.Forms.Button();
            this.btnSetBright2 = new System.Windows.Forms.Button();
            this.btnPowerOff2 = new System.Windows.Forms.Button();
            this.btnPowerOn2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetTemperature = new System.Windows.Forms.Button();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.btnGetDisplay = new System.Windows.Forms.Button();
            this.btnChapterEx = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnTextNoStruct = new System.Windows.Forms.Button();
            this.btnCountUp = new System.Windows.Forms.Button();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.btnCampaign = new System.Windows.Forms.Button();
            this.btnVsqFile = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnPicFile = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.btnDib = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnAdjustTime = new System.Windows.Forms.Button();
            this.btnGetBright = new System.Windows.Forms.Button();
            this.btnSetBright = new System.Windows.Forms.Button();
            this.btnGetPower = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eLocalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eRemoteHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eCommPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDevType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOnlineGetList
            // 
            this.btnOnlineGetList.Location = new System.Drawing.Point(333, 535);
            this.btnOnlineGetList.Name = "btnOnlineGetList";
            this.btnOnlineGetList.Size = new System.Drawing.Size(140, 23);
            this.btnOnlineGetList.TabIndex = 45;
            this.btnOnlineGetList.Text = "获取在线控制卡列表";
            this.btnOnlineGetList.UseVisualStyleBackColor = true;
            // 
            // btnOnlineServerCleanup
            // 
            this.btnOnlineServerCleanup.Location = new System.Drawing.Point(165, 535);
            this.btnOnlineServerCleanup.Name = "btnOnlineServerCleanup";
            this.btnOnlineServerCleanup.Size = new System.Drawing.Size(162, 23);
            this.btnOnlineServerCleanup.TabIndex = 46;
            this.btnOnlineServerCleanup.Text = "停止在线控制卡监听服务";
            this.btnOnlineServerCleanup.UseVisualStyleBackColor = true;
            // 
            // btnOnlineServerStartup
            // 
            this.btnOnlineServerStartup.Location = new System.Drawing.Point(7, 535);
            this.btnOnlineServerStartup.Name = "btnOnlineServerStartup";
            this.btnOnlineServerStartup.Size = new System.Drawing.Size(152, 23);
            this.btnOnlineServerStartup.TabIndex = 47;
            this.btnOnlineServerStartup.Text = "启动在线控制卡监听服务";
            this.btnOnlineServerStartup.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(408, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(67, 34);
            this.pictureBox.TabIndex = 53;
            this.pictureBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMultiCard);
            this.groupBox4.Controls.Add(this.btnBoardParam);
            this.groupBox4.Controls.Add(this.btnTimerTest);
            this.groupBox4.Controls.Add(this.btnVsqFile2);
            this.groupBox4.Controls.Add(this.btnClock2);
            this.groupBox4.Controls.Add(this.btnPicFile2);
            this.groupBox4.Controls.Add(this.btnDateTime2);
            this.groupBox4.Controls.Add(this.btnString2);
            this.groupBox4.Controls.Add(this.btnDib2);
            this.groupBox4.Controls.Add(this.btnText2);
            this.groupBox4.Controls.Add(this.btnAdjustTime2);
            this.groupBox4.Controls.Add(this.btnGetBright2);
            this.groupBox4.Controls.Add(this.btnSetBright2);
            this.groupBox4.Controls.Add(this.btnPowerOff2);
            this.groupBox4.Controls.Add(this.btnPowerOn2);
            this.groupBox4.Location = new System.Drawing.Point(9, 361);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 168);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "阻塞方式，执行命令函数时，进程阻塞，直到获得应答结果时函数返回";
            // 
            // btnMultiCard
            // 
            this.btnMultiCard.Location = new System.Drawing.Point(293, 136);
            this.btnMultiCard.Name = "btnMultiCard";
            this.btnMultiCard.Size = new System.Drawing.Size(166, 23);
            this.btnMultiCard.TabIndex = 15;
            this.btnMultiCard.Text = "发送级联屏测试";
            this.btnMultiCard.UseVisualStyleBackColor = true;
            // 
            // btnBoardParam
            // 
            this.btnBoardParam.Location = new System.Drawing.Point(239, 107);
            this.btnBoardParam.Name = "btnBoardParam";
            this.btnBoardParam.Size = new System.Drawing.Size(220, 23);
            this.btnBoardParam.TabIndex = 14;
            this.btnBoardParam.Text = "读取/设置控制卡参数";
            this.btnBoardParam.UseVisualStyleBackColor = true;
            // 
            // btnTimerTest
            // 
            this.btnTimerTest.Location = new System.Drawing.Point(7, 107);
            this.btnTimerTest.Name = "btnTimerTest";
            this.btnTimerTest.Size = new System.Drawing.Size(226, 23);
            this.btnTimerTest.TabIndex = 13;
            this.btnTimerTest.Text = "启动定时发送测试";
            this.btnTimerTest.UseVisualStyleBackColor = true;
            // 
            // btnVsqFile2
            // 
            this.btnVsqFile2.Location = new System.Drawing.Point(239, 78);
            this.btnVsqFile2.Name = "btnVsqFile2";
            this.btnVsqFile2.Size = new System.Drawing.Size(106, 23);
            this.btnVsqFile2.TabIndex = 12;
            this.btnVsqFile2.Text = "发送vsq文件";
            this.btnVsqFile2.UseVisualStyleBackColor = true;
            // 
            // btnClock2
            // 
            this.btnClock2.Location = new System.Drawing.Point(123, 78);
            this.btnClock2.Name = "btnClock2";
            this.btnClock2.Size = new System.Drawing.Size(110, 23);
            this.btnClock2.TabIndex = 11;
            this.btnClock2.Text = "发送模拟时钟";
            this.btnClock2.UseVisualStyleBackColor = true;
            // 
            // btnPicFile2
            // 
            this.btnPicFile2.Location = new System.Drawing.Point(239, 49);
            this.btnPicFile2.Name = "btnPicFile2";
            this.btnPicFile2.Size = new System.Drawing.Size(108, 23);
            this.btnPicFile2.TabIndex = 10;
            this.btnPicFile2.Text = "发送图片文件";
            this.btnPicFile2.UseVisualStyleBackColor = true;
            // 
            // btnDateTime2
            // 
            this.btnDateTime2.Location = new System.Drawing.Point(7, 78);
            this.btnDateTime2.Name = "btnDateTime2";
            this.btnDateTime2.Size = new System.Drawing.Size(110, 23);
            this.btnDateTime2.TabIndex = 9;
            this.btnDateTime2.Text = "发送日期时间";
            this.btnDateTime2.UseVisualStyleBackColor = true;
            // 
            // btnString2
            // 
            this.btnString2.Location = new System.Drawing.Point(353, 49);
            this.btnString2.Name = "btnString2";
            this.btnString2.Size = new System.Drawing.Size(107, 23);
            this.btnString2.TabIndex = 8;
            this.btnString2.Text = "发送内码文字";
            this.btnString2.UseVisualStyleBackColor = true;
            // 
            // btnDib2
            // 
            this.btnDib2.Location = new System.Drawing.Point(123, 49);
            this.btnDib2.Name = "btnDib2";
            this.btnDib2.Size = new System.Drawing.Size(110, 23);
            this.btnDib2.TabIndex = 7;
            this.btnDib2.Text = "发送点阵图像";
            this.btnDib2.UseVisualStyleBackColor = true;
            // 
            // btnText2
            // 
            this.btnText2.Location = new System.Drawing.Point(7, 49);
            this.btnText2.Name = "btnText2";
            this.btnText2.Size = new System.Drawing.Size(110, 23);
            this.btnText2.TabIndex = 6;
            this.btnText2.Text = "发送点阵文字";
            this.btnText2.UseVisualStyleBackColor = true;
            // 
            // btnAdjustTime2
            // 
            this.btnAdjustTime2.Location = new System.Drawing.Point(393, 20);
            this.btnAdjustTime2.Name = "btnAdjustTime2";
            this.btnAdjustTime2.Size = new System.Drawing.Size(66, 23);
            this.btnAdjustTime2.TabIndex = 5;
            this.btnAdjustTime2.Text = "校正时间";
            this.btnAdjustTime2.UseVisualStyleBackColor = true;
            // 
            // btnGetBright2
            // 
            this.btnGetBright2.Location = new System.Drawing.Point(321, 20);
            this.btnGetBright2.Name = "btnGetBright2";
            this.btnGetBright2.Size = new System.Drawing.Size(66, 23);
            this.btnGetBright2.TabIndex = 4;
            this.btnGetBright2.Text = "读取亮度";
            this.btnGetBright2.UseVisualStyleBackColor = true;
            // 
            // btnSetBright2
            // 
            this.btnSetBright2.Location = new System.Drawing.Point(249, 20);
            this.btnSetBright2.Name = "btnSetBright2";
            this.btnSetBright2.Size = new System.Drawing.Size(66, 23);
            this.btnSetBright2.TabIndex = 3;
            this.btnSetBright2.Text = "设置亮度";
            this.btnSetBright2.UseVisualStyleBackColor = true;
            // 
            // btnPowerOff2
            // 
            this.btnPowerOff2.Location = new System.Drawing.Point(78, 20);
            this.btnPowerOff2.Name = "btnPowerOff2";
            this.btnPowerOff2.Size = new System.Drawing.Size(66, 23);
            this.btnPowerOff2.TabIndex = 1;
            this.btnPowerOff2.Text = "关闭电源";
            this.btnPowerOff2.UseVisualStyleBackColor = true;
            // 
            // btnPowerOn2
            // 
            this.btnPowerOn2.Location = new System.Drawing.Point(6, 20);
            this.btnPowerOn2.Name = "btnPowerOn2";
            this.btnPowerOn2.Size = new System.Drawing.Size(66, 23);
            this.btnPowerOn2.TabIndex = 0;
            this.btnPowerOn2.Text = "打开电源";
            this.btnPowerOn2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetTemperature);
            this.groupBox3.Controls.Add(this.btnTemperature);
            this.groupBox3.Controls.Add(this.btnGetDisplay);
            this.groupBox3.Controls.Add(this.btnChapterEx);
            this.groupBox3.Controls.Add(this.btnTable);
            this.groupBox3.Controls.Add(this.btnTextNoStruct);
            this.groupBox3.Controls.Add(this.btnCountUp);
            this.groupBox3.Controls.Add(this.btnCountDown);
            this.groupBox3.Controls.Add(this.btnCampaign);
            this.groupBox3.Controls.Add(this.btnVsqFile);
            this.groupBox3.Controls.Add(this.btnClock);
            this.groupBox3.Controls.Add(this.btnPicFile);
            this.groupBox3.Controls.Add(this.btnDateTime);
            this.groupBox3.Controls.Add(this.btnString);
            this.groupBox3.Controls.Add(this.btnDib);
            this.groupBox3.Controls.Add(this.btnText);
            this.groupBox3.Controls.Add(this.btnAdjustTime);
            this.groupBox3.Controls.Add(this.btnGetBright);
            this.groupBox3.Controls.Add(this.btnSetBright);
            this.groupBox3.Controls.Add(this.btnGetPower);
            this.groupBox3.Controls.Add(this.btnPowerOff);
            this.groupBox3.Controls.Add(this.btnPowerOn);
            this.groupBox3.Location = new System.Drawing.Point(9, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 199);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "异步方式，使用窗体消息方式获得命令执行结果";
            // 
            // btnGetTemperature
            // 
            this.btnGetTemperature.Location = new System.Drawing.Point(123, 165);
            this.btnGetTemperature.Name = "btnGetTemperature";
            this.btnGetTemperature.Size = new System.Drawing.Size(143, 23);
            this.btnGetTemperature.TabIndex = 21;
            this.btnGetTemperature.Text = "读取温湿度";
            this.btnGetTemperature.UseVisualStyleBackColor = true;
            // 
            // btnTemperature
            // 
            this.btnTemperature.Location = new System.Drawing.Point(7, 165);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(110, 23);
            this.btnTemperature.TabIndex = 20;
            this.btnTemperature.Text = "发送温湿度";
            this.btnTemperature.UseVisualStyleBackColor = true;
            // 
            // btnGetDisplay
            // 
            this.btnGetDisplay.Location = new System.Drawing.Point(272, 136);
            this.btnGetDisplay.Name = "btnGetDisplay";
            this.btnGetDisplay.Size = new System.Drawing.Size(148, 23);
            this.btnGetDisplay.TabIndex = 19;
            this.btnGetDisplay.Text = "读取控制卡节目示例";
            this.btnGetDisplay.UseVisualStyleBackColor = true;
            // 
            // btnChapterEx
            // 
            this.btnChapterEx.Location = new System.Drawing.Point(123, 136);
            this.btnChapterEx.Name = "btnChapterEx";
            this.btnChapterEx.Size = new System.Drawing.Size(143, 23);
            this.btnChapterEx.TabIndex = 18;
            this.btnChapterEx.Text = "播放节目计划示例";
            this.btnChapterEx.UseVisualStyleBackColor = true;
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(7, 136);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(110, 23);
            this.btnTable.TabIndex = 17;
            this.btnTable.Text = "发送表格";
            this.btnTable.UseVisualStyleBackColor = true;
            // 
            // btnTextNoStruct
            // 
            this.btnTextNoStruct.Location = new System.Drawing.Point(239, 107);
            this.btnTextNoStruct.Name = "btnTextNoStruct";
            this.btnTextNoStruct.Size = new System.Drawing.Size(220, 23);
            this.btnTextNoStruct.TabIndex = 16;
            this.btnTextNoStruct.Text = "发送点阵文字 使用非结构体参数";
            this.btnTextNoStruct.UseVisualStyleBackColor = true;
            // 
            // btnCountUp
            // 
            this.btnCountUp.Location = new System.Drawing.Point(6, 107);
            this.btnCountUp.Name = "btnCountUp";
            this.btnCountUp.Size = new System.Drawing.Size(110, 23);
            this.btnCountUp.TabIndex = 15;
            this.btnCountUp.Text = "发送正计时";
            this.btnCountUp.UseVisualStyleBackColor = true;
            // 
            // btnCountDown
            // 
            this.btnCountDown.Location = new System.Drawing.Point(123, 107);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(110, 23);
            this.btnCountDown.TabIndex = 14;
            this.btnCountDown.Text = "发送倒计时";
            this.btnCountDown.UseVisualStyleBackColor = true;
            // 
            // btnCampaign
            // 
            this.btnCampaign.Location = new System.Drawing.Point(237, 78);
            this.btnCampaign.Name = "btnCampaign";
            this.btnCampaign.Size = new System.Drawing.Size(110, 23);
            this.btnCampaign.TabIndex = 13;
            this.btnCampaign.Text = "发送作战时间";
            this.btnCampaign.UseVisualStyleBackColor = true;
            // 
            // btnVsqFile
            // 
            this.btnVsqFile.Location = new System.Drawing.Point(353, 78);
            this.btnVsqFile.Name = "btnVsqFile";
            this.btnVsqFile.Size = new System.Drawing.Size(106, 23);
            this.btnVsqFile.TabIndex = 12;
            this.btnVsqFile.Text = "发送vsq文件";
            this.btnVsqFile.UseVisualStyleBackColor = true;
            // 
            // btnClock
            // 
            this.btnClock.Location = new System.Drawing.Point(123, 78);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(110, 23);
            this.btnClock.TabIndex = 11;
            this.btnClock.Text = "发送模拟时钟";
            this.btnClock.UseVisualStyleBackColor = true;
            // 
            // btnPicFile
            // 
            this.btnPicFile.Location = new System.Drawing.Point(237, 49);
            this.btnPicFile.Name = "btnPicFile";
            this.btnPicFile.Size = new System.Drawing.Size(110, 23);
            this.btnPicFile.TabIndex = 10;
            this.btnPicFile.Text = "发送图片文件";
            this.btnPicFile.UseVisualStyleBackColor = true;
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(7, 78);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(110, 23);
            this.btnDateTime.TabIndex = 9;
            this.btnDateTime.Text = "发送日期时间";
            this.btnDateTime.UseVisualStyleBackColor = true;
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(353, 49);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(107, 23);
            this.btnString.TabIndex = 8;
            this.btnString.Text = "发送内码文字";
            this.btnString.UseVisualStyleBackColor = true;
            // 
            // btnDib
            // 
            this.btnDib.Location = new System.Drawing.Point(123, 49);
            this.btnDib.Name = "btnDib";
            this.btnDib.Size = new System.Drawing.Size(110, 23);
            this.btnDib.TabIndex = 7;
            this.btnDib.Text = "发送点阵图像";
            this.btnDib.UseVisualStyleBackColor = true;
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(7, 49);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(110, 23);
            this.btnText.TabIndex = 6;
            this.btnText.Text = "发送点阵文字";
            this.btnText.UseVisualStyleBackColor = true;
            // 
            // btnAdjustTime
            // 
            this.btnAdjustTime.Location = new System.Drawing.Point(393, 20);
            this.btnAdjustTime.Name = "btnAdjustTime";
            this.btnAdjustTime.Size = new System.Drawing.Size(66, 23);
            this.btnAdjustTime.TabIndex = 5;
            this.btnAdjustTime.Text = "校正时间";
            this.btnAdjustTime.UseVisualStyleBackColor = true;
            // 
            // btnGetBright
            // 
            this.btnGetBright.Location = new System.Drawing.Point(321, 20);
            this.btnGetBright.Name = "btnGetBright";
            this.btnGetBright.Size = new System.Drawing.Size(66, 23);
            this.btnGetBright.TabIndex = 4;
            this.btnGetBright.Text = "读取亮度";
            this.btnGetBright.UseVisualStyleBackColor = true;
            // 
            // btnSetBright
            // 
            this.btnSetBright.Location = new System.Drawing.Point(249, 20);
            this.btnSetBright.Name = "btnSetBright";
            this.btnSetBright.Size = new System.Drawing.Size(66, 23);
            this.btnSetBright.TabIndex = 3;
            this.btnSetBright.Text = "设置亮度";
            this.btnSetBright.UseVisualStyleBackColor = true;
            // 
            // btnGetPower
            // 
            this.btnGetPower.Location = new System.Drawing.Point(150, 20);
            this.btnGetPower.Name = "btnGetPower";
            this.btnGetPower.Size = new System.Drawing.Size(93, 23);
            this.btnGetPower.TabIndex = 2;
            this.btnGetPower.Text = "读取电源状态";
            this.btnGetPower.UseVisualStyleBackColor = true;
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Location = new System.Drawing.Point(78, 20);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(66, 23);
            this.btnPowerOff.TabIndex = 1;
            this.btnPowerOff.Text = "关闭电源";
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Location = new System.Drawing.Point(6, 20);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(66, 23);
            this.btnPowerOn.TabIndex = 0;
            this.btnPowerOn.Text = "打开电源";
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eLocalPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.eRemoteHost);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(246, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 83);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "网络通讯参数";
            // 
            // eLocalPort
            // 
            this.eLocalPort.Location = new System.Drawing.Point(76, 51);
            this.eLocalPort.Name = "eLocalPort";
            this.eLocalPort.Size = new System.Drawing.Size(132, 21);
            this.eLocalPort.TabIndex = 4;
            this.eLocalPort.Text = "8881";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "本地端口";
            // 
            // eRemoteHost
            // 
            this.eRemoteHost.Location = new System.Drawing.Point(76, 20);
            this.eRemoteHost.Name = "eRemoteHost";
            this.eRemoteHost.Size = new System.Drawing.Size(132, 21);
            this.eRemoteHost.TabIndex = 2;
            this.eRemoteHost.Text = "192.168.0.99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "控制卡IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.eCommPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 83);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口通讯参数";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "57600",
            "38400",
            "19200",
            "9600"});
            this.cmbBaudRate.Location = new System.Drawing.Point(65, 52);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(144, 20);
            this.cmbBaudRate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // eCommPort
            // 
            this.eCommPort.Location = new System.Drawing.Point(64, 20);
            this.eCommPort.Name = "eCommPort";
            this.eCommPort.Size = new System.Drawing.Size(145, 21);
            this.eCommPort.TabIndex = 2;
            this.eCommPort.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号";
            // 
            // cmbDevType
            // 
            this.cmbDevType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevType.FormattingEnabled = true;
            this.cmbDevType.Items.AddRange(new object[] {
            "串口通讯",
            "网络通讯"});
            this.cmbDevType.Location = new System.Drawing.Point(9, 41);
            this.cmbDevType.Name = "cmbDevType";
            this.cmbDevType.Size = new System.Drawing.Size(144, 20);
            this.cmbDevType.TabIndex = 48;
            // 
            // frmLedDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 557);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDevType);
            this.Controls.Add(this.btnOnlineGetList);
            this.Controls.Add(this.btnOnlineServerCleanup);
            this.Controls.Add(this.btnOnlineServerStartup);
            this.Name = "frmLedDemo";
            this.Text = "FrmLedDemo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnlineGetList;
        private System.Windows.Forms.Button btnOnlineServerCleanup;
        private System.Windows.Forms.Button btnOnlineServerStartup;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMultiCard;
        private System.Windows.Forms.Button btnBoardParam;
        private System.Windows.Forms.Button btnTimerTest;
        private System.Windows.Forms.Button btnVsqFile2;
        private System.Windows.Forms.Button btnClock2;
        private System.Windows.Forms.Button btnPicFile2;
        private System.Windows.Forms.Button btnDateTime2;
        private System.Windows.Forms.Button btnString2;
        private System.Windows.Forms.Button btnDib2;
        private System.Windows.Forms.Button btnText2;
        private System.Windows.Forms.Button btnAdjustTime2;
        private System.Windows.Forms.Button btnGetBright2;
        private System.Windows.Forms.Button btnSetBright2;
        private System.Windows.Forms.Button btnPowerOff2;
        private System.Windows.Forms.Button btnPowerOn2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetTemperature;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Button btnGetDisplay;
        private System.Windows.Forms.Button btnChapterEx;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnTextNoStruct;
        private System.Windows.Forms.Button btnCountUp;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.Button btnCampaign;
        private System.Windows.Forms.Button btnVsqFile;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnPicFile;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnDib;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnAdjustTime;
        private System.Windows.Forms.Button btnGetBright;
        private System.Windows.Forms.Button btnSetBright;
        private System.Windows.Forms.Button btnGetPower;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnPowerOn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox eLocalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eRemoteHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eCommPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDevType;
    }
}

