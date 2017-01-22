namespace ASRS_ChangAn.UIFolder.WorkCenter
{
    partial class FrmLoading
    {
        /// <summary>
        /// /// 必需的设计器变量。
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tBSku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBGate = new System.Windows.Forms.TextBox();
            this.tBContainer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SrmIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AlreadyScan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 28);
            this.panel1.TabIndex = 43;
            // 
            // lbLogin
            // 
            this.lbLogin.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbLogin.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lbLogin.Location = new System.Drawing.Point(0, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(768, 29);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "入 库 作 业";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBSku
            // 
            this.tBSku.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tBSku.ForeColor = System.Drawing.Color.Maroon;
            this.tBSku.Location = new System.Drawing.Point(198, 108);
            this.tBSku.Name = "tBSku";
            this.tBSku.Size = new System.Drawing.Size(309, 32);
            this.tBSku.TabIndex = 39;
            this.tBSku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBSku_KeyPress_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(89, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "物料号:";
            // 
            // tBGate
            // 
            this.tBGate.Enabled = false;
            this.tBGate.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tBGate.ForeColor = System.Drawing.Color.Maroon;
            this.tBGate.Location = new System.Drawing.Point(198, 70);
            this.tBGate.Name = "tBGate";
            this.tBGate.Size = new System.Drawing.Size(309, 32);
            this.tBGate.TabIndex = 38;
            this.tBGate.Text = "10001";
            // 
            // tBContainer
            // 
            this.tBContainer.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tBContainer.ForeColor = System.Drawing.Color.Maroon;
            this.tBContainer.Location = new System.Drawing.Point(198, 34);
            this.tBContainer.Name = "tBContainer";
            this.tBContainer.Size = new System.Drawing.Size(309, 32);
            this.tBContainer.TabIndex = 37;
            this.tBContainer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBContainer_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(89, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "出入口:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "托盘号:";
            // 
            // btn_SrmIn
            // 
            this.btn_SrmIn.BackColor = System.Drawing.Color.White;
            this.btn_SrmIn.Location = new System.Drawing.Point(118, 203);
            this.btn_SrmIn.Name = "btn_SrmIn";
            this.btn_SrmIn.Size = new System.Drawing.Size(123, 36);
            this.btn_SrmIn.TabIndex = 44;
            this.btn_SrmIn.Text = "入库";
            this.btn_SrmIn.UseVisualStyleBackColor = true;
            this.btn_SrmIn.Click += new System.EventHandler(this.btn_SrmIn_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(385, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 36);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "清除数据";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "已扫物料:";
            this.label4.Visible = false;
            // 
            // AlreadyScan
            // 
            this.AlreadyScan.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyScan.Location = new System.Drawing.Point(598, 108);
            this.AlreadyScan.Multiline = true;
            this.AlreadyScan.Name = "AlreadyScan";
            this.AlreadyScan.ReadOnly = true;
            this.AlreadyScan.Size = new System.Drawing.Size(166, 32);
            this.AlreadyScan.TabIndex = 48;
            this.AlreadyScan.Visible = false;
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 320);
            this.ControlBox = false;
            this.Controls.Add(this.AlreadyScan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_SrmIn);
            this.Controls.Add(this.tBSku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBGate);
            this.Controls.Add(this.tBContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "FrmLoading";
            this.Text = "FrmIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBSku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBGate;
        private System.Windows.Forms.TextBox tBContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SrmIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AlreadyScan;
        private System.Windows.Forms.Label lbLogin;
    }
}