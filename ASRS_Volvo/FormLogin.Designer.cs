namespace ASRS_ChangAn
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.ckBForce = new System.Windows.Forms.CheckBox();
            this.lbUserLogin = new System.Windows.Forms.Label();
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
            // ckBForce
            // 
            this.ckBForce.AutoSize = true;
            this.ckBForce.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckBForce.ForeColor = System.Drawing.Color.Maroon;
            this.ckBForce.Location = new System.Drawing.Point(102, 174);
            this.ckBForce.Name = "ckBForce";
            this.ckBForce.Size = new System.Drawing.Size(75, 21);
            this.ckBForce.TabIndex = 42;
            this.ckBForce.Text = "强行登录";
            this.ckBForce.UseVisualStyleBackColor = true;
            // 
            // lbUserLogin
            // 
            this.lbUserLogin.AutoSize = true;
            this.lbUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbUserLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUserLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lbUserLogin.Location = new System.Drawing.Point(6, 4);
            this.lbUserLogin.Name = "lbUserLogin";
            this.lbUserLogin.Size = new System.Drawing.Size(172, 22);
            this.lbUserLogin.TabIndex = 40;
            this.lbUserLogin.Text = "WMS系统登录";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(237, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 30);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogin.Location = new System.Drawing.Point(102, 126);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 30);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "登 陆";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbLoginPassword
            // 
            this.lbLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLoginPassword.ForeColor = System.Drawing.Color.Maroon;
            this.lbLoginPassword.Location = new System.Drawing.Point(6, 88);
            this.lbLoginPassword.Name = "lbLoginPassword";
            this.lbLoginPassword.Size = new System.Drawing.Size(90, 25);
            this.lbLoginPassword.TabIndex = 37;
            this.lbLoginPassword.Text = "密   码";
            // 
            // lbLoginName
            // 
            this.lbLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLoginName.ForeColor = System.Drawing.Color.Maroon;
            this.lbLoginName.Location = new System.Drawing.Point(6, 59);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(90, 24);
            this.lbLoginName.TabIndex = 36;
            this.lbLoginName.Text = "用户名";
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoginPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLoginPassword.ForeColor = System.Drawing.Color.Maroon;
            this.tbLoginPassword.Location = new System.Drawing.Point(102, 85);
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
            this.tbLoginName.Location = new System.Drawing.Point(102, 56);
            this.tbLoginName.MaxLength = 20;
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(213, 29);
            this.tbLoginName.TabIndex = 34;
            this.tbLoginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoginName_KeyPress);
            // 
            // pbUserLogin
            // 
            this.pbUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUserLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbUserLogin.Image")));
            this.pbUserLogin.Location = new System.Drawing.Point(360, 143);
            this.pbUserLogin.Name = "pbUserLogin";
            this.pbUserLogin.Size = new System.Drawing.Size(126, 125);
            this.pbUserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserLogin.TabIndex = 33;
            this.pbUserLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(180, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "version:160606W";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Controls.Add(this.ckBForce);
            this.Controls.Add(this.lbUserLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbLoginPassword);
            this.Controls.Add(this.lbLoginName);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.pbUserLogin);
            this.Controls.Add(this.label1);

            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMS登陆";
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckBForce;
        private System.Windows.Forms.Label lbUserLogin;
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