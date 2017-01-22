namespace ASRS_ChangAn.UIFolder.BasisSetting
{
    partial class FormAddGroup
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_r_SaveDesc = new System.Windows.Forms.Button();
            this.rTB_r_GroupDesc = new System.Windows.Forms.RichTextBox();
            this.tb_r_GroupName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_r_SaveDesc);
            this.groupBox2.Controls.Add(this.rTB_r_GroupDesc);
            this.groupBox2.Controls.Add(this.tb_r_GroupName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 199);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "角色详细信息";
            // 
            // btn_r_SaveDesc
            // 
            this.btn_r_SaveDesc.ForeColor = System.Drawing.Color.Maroon;
            this.btn_r_SaveDesc.Location = new System.Drawing.Point(222, 136);
            this.btn_r_SaveDesc.Name = "btn_r_SaveDesc";
            this.btn_r_SaveDesc.Size = new System.Drawing.Size(67, 30);
            this.btn_r_SaveDesc.TabIndex = 4;
            this.btn_r_SaveDesc.Text = "保存";
            this.btn_r_SaveDesc.UseVisualStyleBackColor = true;
            this.btn_r_SaveDesc.Click += new System.EventHandler(this.btn_r_SaveDesc_Click);
            // 
            // rTB_r_GroupDesc
            // 
            this.rTB_r_GroupDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB_r_GroupDesc.ForeColor = System.Drawing.Color.Maroon;
            this.rTB_r_GroupDesc.Location = new System.Drawing.Point(56, 61);
            this.rTB_r_GroupDesc.Name = "rTB_r_GroupDesc";
            this.rTB_r_GroupDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rTB_r_GroupDesc.Size = new System.Drawing.Size(233, 64);
            this.rTB_r_GroupDesc.TabIndex = 3;
            this.rTB_r_GroupDesc.Text = "";
            // 
            // tb_r_GroupName
            // 
            this.tb_r_GroupName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_r_GroupName.ForeColor = System.Drawing.Color.Maroon;
            this.tb_r_GroupName.Location = new System.Drawing.Point(56, 24);
            this.tb_r_GroupName.Name = "tb_r_GroupName";
            this.tb_r_GroupName.Size = new System.Drawing.Size(233, 21);
            this.tb_r_GroupName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "描述:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "名称:";
            // 
            // FormAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 199);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAddGroup";
            this.Text = "添加用户组";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_r_SaveDesc;
        private System.Windows.Forms.RichTextBox rTB_r_GroupDesc;
        private System.Windows.Forms.TextBox tb_r_GroupName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}