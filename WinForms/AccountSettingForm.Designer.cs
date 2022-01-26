namespace BloodDonationSocietyDigitalSystem.WinForms
{
    partial class AccountSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSettingForm));
            this.txbxNewPassword = new System.Windows.Forms.TextBox();
            this.txbxCurrentPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxCNewPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txbxNewPassword
            // 
            this.txbxNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNewPassword.ForeColor = System.Drawing.Color.White;
            this.txbxNewPassword.Location = new System.Drawing.Point(318, 168);
            this.txbxNewPassword.Name = "txbxNewPassword";
            this.txbxNewPassword.Size = new System.Drawing.Size(242, 26);
            this.txbxNewPassword.TabIndex = 14;
            this.txbxNewPassword.UseSystemPasswordChar = true;
            // 
            // txbxCurrentPassword
            // 
            this.txbxCurrentPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxCurrentPassword.ForeColor = System.Drawing.Color.White;
            this.txbxCurrentPassword.Location = new System.Drawing.Point(318, 88);
            this.txbxCurrentPassword.Name = "txbxCurrentPassword";
            this.txbxCurrentPassword.Size = new System.Drawing.Size(242, 26);
            this.txbxCurrentPassword.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Password";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Change Password";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password";
            // 
            // txbxCNewPassword
            // 
            this.txbxCNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxCNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxCNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxCNewPassword.ForeColor = System.Drawing.Color.White;
            this.txbxCNewPassword.Location = new System.Drawing.Point(318, 248);
            this.txbxCNewPassword.Name = "txbxCNewPassword";
            this.txbxCNewPassword.Size = new System.Drawing.Size(242, 26);
            this.txbxCNewPassword.TabIndex = 17;
            this.txbxCNewPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.Red;
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Update";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.White;
            this.btnLogin.IdleLineColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(438, 320);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 42);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // AccountSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(726, 425);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbxCNewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxNewPassword);
            this.Controls.Add(this.txbxCurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountSettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxNewPassword;
        private System.Windows.Forms.TextBox txbxCurrentPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxCNewPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
    }
}