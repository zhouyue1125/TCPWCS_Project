namespace WCS_V3
{
    partial class FormWCS_LoginIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWCS_LoginIn));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbLoginPassword = new System.Windows.Forms.Label();
            this.lbLoginName = new System.Windows.Forms.Label();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.pbUserLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(214, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 61);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogin.Location = new System.Drawing.Point(98, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 61);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "确 定";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbLoginPassword
            // 
            this.lbLoginPassword.BackColor = System.Drawing.Color.White;
            this.lbLoginPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLoginPassword.ForeColor = System.Drawing.Color.Maroon;
            this.lbLoginPassword.Location = new System.Drawing.Point(2, 92);
            this.lbLoginPassword.Name = "lbLoginPassword";
            this.lbLoginPassword.Size = new System.Drawing.Size(90, 25);
            this.lbLoginPassword.TabIndex = 37;
            this.lbLoginPassword.Text = "密   码";
            // 
            // lbLoginName
            // 
            this.lbLoginName.BackColor = System.Drawing.Color.White;
            this.lbLoginName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLoginName.ForeColor = System.Drawing.Color.Maroon;
            this.lbLoginName.Location = new System.Drawing.Point(2, 63);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(90, 24);
            this.lbLoginName.TabIndex = 36;
            this.lbLoginName.Text = "账   号";
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoginPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLoginPassword.ForeColor = System.Drawing.Color.Maroon;
            this.tbLoginPassword.Location = new System.Drawing.Point(98, 89);
            this.tbLoginPassword.MaxLength = 20;
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(213, 29);
            this.tbLoginPassword.TabIndex = 35;
            this.tbLoginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoginPassword_KeyPress);
            // 
            // tbLoginName
            // 
            this.tbLoginName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoginName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLoginName.ForeColor = System.Drawing.Color.Maroon;
            this.tbLoginName.Location = new System.Drawing.Point(98, 60);
            this.tbLoginName.MaxLength = 20;
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(213, 29);
            this.tbLoginName.TabIndex = 34;
            // 
            // pbUserLogin
            // 
            this.pbUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUserLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbUserLogin.Image")));
            this.pbUserLogin.Location = new System.Drawing.Point(317, 60);
            this.pbUserLogin.Name = "pbUserLogin";
            this.pbUserLogin.Size = new System.Drawing.Size(156, 142);
            this.pbUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserLogin.TabIndex = 33;
            this.pbUserLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(101, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "重庆长安立库操作系统";
            // 
            // FormWCS_LoginIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbLoginPassword);
            this.Controls.Add(this.lbLoginName);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.pbUserLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWCS_LoginIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FormWCS_LoginIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbLoginPassword;
        private System.Windows.Forms.Label lbLoginName;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.PictureBox pbUserLogin;
        private System.Windows.Forms.Label label1;
    }
}