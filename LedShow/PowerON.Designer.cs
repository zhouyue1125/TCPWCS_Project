namespace LedShow
{
    partial class PowerON
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tBTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBTaskType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBToPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBFromPlace = new System.Windows.Forms.TextBox();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBSku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContainerId = new System.Windows.Forms.TextBox();
            this.tBTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(386, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "电源开关";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 48);
            this.button2.TabIndex = 36;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBTime
            // 
            this.tBTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBTime.Location = new System.Drawing.Point(102, 192);
            this.tBTime.Name = "tBTime";
            this.tBTime.Size = new System.Drawing.Size(320, 29);
            this.tBTime.TabIndex = 34;
            this.tBTime.Text = "2015-01-19 19:27:34";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(0, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "作业时间:";
            // 
            // tBTaskType
            // 
            this.tBTaskType.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBTaskType.Location = new System.Drawing.Point(322, 66);
            this.tBTaskType.Name = "tBTaskType";
            this.tBTaskType.Size = new System.Drawing.Size(100, 29);
            this.tBTaskType.TabIndex = 32;
            this.tBTaskType.Text = "入库";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(220, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "任务类型:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(239, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "目标位:";
            // 
            // tBToPlace
            // 
            this.tBToPlace.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBToPlace.Location = new System.Drawing.Point(322, 150);
            this.tBToPlace.Name = "tBToPlace";
            this.tBToPlace.Size = new System.Drawing.Size(100, 29);
            this.tBToPlace.TabIndex = 29;
            this.tBToPlace.Text = "20804";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "起始位:";
            // 
            // tBFromPlace
            // 
            this.tBFromPlace.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBFromPlace.Location = new System.Drawing.Point(102, 150);
            this.tBFromPlace.Name = "tBFromPlace";
            this.tBFromPlace.Size = new System.Drawing.Size(100, 29);
            this.tBFromPlace.TabIndex = 27;
            this.tBFromPlace.Text = "11901";
            // 
            // tBDesc
            // 
            this.tBDesc.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBDesc.Location = new System.Drawing.Point(322, 112);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.Size = new System.Drawing.Size(100, 29);
            this.tBDesc.TabIndex = 26;
            this.tBDesc.Text = "前门内外板上支撑（左）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(220, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "物料名称:";
            // 
            // tBSku
            // 
            this.tBSku.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBSku.Location = new System.Drawing.Point(102, 112);
            this.tBSku.Name = "tBSku";
            this.tBSku.Size = new System.Drawing.Size(100, 29);
            this.tBSku.TabIndex = 24;
            this.tBSku.Text = "TVX013-60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "物料号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "托盘号:";
            // 
            // tbContainerId
            // 
            this.tbContainerId.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContainerId.Location = new System.Drawing.Point(102, 66);
            this.tbContainerId.Name = "tbContainerId";
            this.tbContainerId.Size = new System.Drawing.Size(100, 29);
            this.tbContainerId.TabIndex = 21;
            this.tbContainerId.Text = "TP20804";
            // 
            // tBTitle
            // 
            this.tBTitle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBTitle.Location = new System.Drawing.Point(141, 25);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(171, 35);
            this.tBTitle.TabIndex = 20;
            this.tBTitle.Text = "吉利沃尔沃立体库";
            this.tBTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PowerON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tBTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBTaskType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBToPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBFromPlace);
            this.Controls.Add(this.tBDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBSku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContainerId);
            this.Controls.Add(this.tBTitle);
            this.Controls.Add(this.button1);
            this.Name = "PowerON";
            this.Text = "PowerON";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PowerON_FormClosed);
            this.Load += new System.EventHandler(this.PowerON_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tBTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBTaskType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBToPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBFromPlace;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBSku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContainerId;
        private System.Windows.Forms.TextBox tBTitle;
    }
}