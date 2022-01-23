namespace BloodDonationSocietyDigitalSystem.WinForms
{
    partial class AddDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDonor));
            this.txbxDName = new System.Windows.Forms.TextBox();
            this.txbxDAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbxDCity = new System.Windows.Forms.TextBox();
            this.txbxDPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDBloodGroup = new System.Windows.Forms.ComboBox();
            this.rtxbxDAddress = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddDonor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txbxDName
            // 
            this.txbxDName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDName.ForeColor = System.Drawing.Color.White;
            this.txbxDName.Location = new System.Drawing.Point(323, 126);
            this.txbxDName.Name = "txbxDName";
            this.txbxDName.Size = new System.Drawing.Size(242, 26);
            this.txbxDName.TabIndex = 0;
            // 
            // txbxDAge
            // 
            this.txbxDAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxDAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDAge.ForeColor = System.Drawing.Color.White;
            this.txbxDAge.Location = new System.Drawing.Point(640, 126);
            this.txbxDAge.Name = "txbxDAge";
            this.txbxDAge.Size = new System.Drawing.Size(71, 26);
            this.txbxDAge.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label8.Location = new System.Drawing.Point(580, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Age";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label10.Location = new System.Drawing.Point(245, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label11.Location = new System.Drawing.Point(244, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Add your self as donor...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label12.Location = new System.Drawing.Point(243, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "Donor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(245, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Gender";
            // 
            // cbDGender
            // 
            this.cbDGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbDGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDGender.ForeColor = System.Drawing.SystemColors.Window;
            this.cbDGender.FormattingEnabled = true;
            this.cbDGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Custom"});
            this.cbDGender.Location = new System.Drawing.Point(323, 176);
            this.cbDGender.Name = "cbDGender";
            this.cbDGender.Size = new System.Drawing.Size(113, 26);
            this.cbDGender.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label9.Location = new System.Drawing.Point(453, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "City";
            // 
            // txbxDCity
            // 
            this.txbxDCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxDCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDCity.ForeColor = System.Drawing.Color.White;
            this.txbxDCity.Location = new System.Drawing.Point(498, 178);
            this.txbxDCity.Name = "txbxDCity";
            this.txbxDCity.Size = new System.Drawing.Size(213, 26);
            this.txbxDCity.TabIndex = 3;
            // 
            // txbxDPhone
            // 
            this.txbxDPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxDPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDPhone.ForeColor = System.Drawing.Color.White;
            this.txbxDPhone.Location = new System.Drawing.Point(323, 233);
            this.txbxDPhone.Name = "txbxDPhone";
            this.txbxDPhone.Size = new System.Drawing.Size(223, 26);
            this.txbxDPhone.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label13.Location = new System.Drawing.Point(245, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label14.Location = new System.Drawing.Point(245, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 57;
            this.label14.Text = "Blood Group";
            // 
            // cbDBloodGroup
            // 
            this.cbDBloodGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbDBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDBloodGroup.ForeColor = System.Drawing.SystemColors.Window;
            this.cbDBloodGroup.FormattingEnabled = true;
            this.cbDBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbDBloodGroup.Location = new System.Drawing.Point(374, 280);
            this.cbDBloodGroup.Name = "cbDBloodGroup";
            this.cbDBloodGroup.Size = new System.Drawing.Size(87, 26);
            this.cbDBloodGroup.TabIndex = 5;
            // 
            // rtxbxDAddress
            // 
            this.rtxbxDAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rtxbxDAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxbxDAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbxDAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxbxDAddress.Location = new System.Drawing.Point(326, 334);
            this.rtxbxDAddress.Name = "rtxbxDAddress";
            this.rtxbxDAddress.Size = new System.Drawing.Size(239, 93);
            this.rtxbxDAddress.TabIndex = 6;
            this.rtxbxDAddress.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label15.Location = new System.Drawing.Point(245, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 20);
            this.label15.TabIndex = 60;
            this.label15.Text = "Address";
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.ActiveBorderThickness = 1;
            this.btnAddDonor.ActiveCornerRadius = 20;
            this.btnAddDonor.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.btnAddDonor.ActiveForecolor = System.Drawing.Color.Black;
            this.btnAddDonor.ActiveLineColor = System.Drawing.Color.Red;
            this.btnAddDonor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddDonor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDonor.BackgroundImage")));
            this.btnAddDonor.ButtonText = "Add Donor";
            this.btnAddDonor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddDonor.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddDonor.IdleBorderThickness = 1;
            this.btnAddDonor.IdleCornerRadius = 20;
            this.btnAddDonor.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddDonor.IdleForecolor = System.Drawing.Color.White;
            this.btnAddDonor.IdleLineColor = System.Drawing.Color.White;
            this.btnAddDonor.Location = new System.Drawing.Point(589, 385);
            this.btnAddDonor.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(122, 42);
            this.btnAddDonor.TabIndex = 7;
            this.btnAddDonor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);
            // 
            // AddDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(742, 464);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddDonor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rtxbxDAddress);
            this.Controls.Add(this.cbDBloodGroup);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbxDPhone);
            this.Controls.Add(this.txbxDCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbxDName);
            this.Controls.Add(this.txbxDAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Donor - Blood Donation Society Digital System";
            this.Load += new System.EventHandler(this.AddDonor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbxDName;
        private System.Windows.Forms.TextBox txbxDAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbxDCity;
        private System.Windows.Forms.TextBox txbxDPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbDBloodGroup;
        private System.Windows.Forms.RichTextBox rtxbxDAddress;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddDonor;
    }
}