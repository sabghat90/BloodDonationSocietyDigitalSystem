namespace BloodDonationSocietyDigitalSystem.WinForms
{
    partial class AddDonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDonorForm));
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
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbxDName
            // 
            this.txbxDName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDName.ForeColor = System.Drawing.Color.White;
            this.txbxDName.Location = new System.Drawing.Point(162, 110);
            this.txbxDName.Name = "txbxDName";
            this.txbxDName.Size = new System.Drawing.Size(242, 26);
            this.txbxDName.TabIndex = 0;
            this.txbxDName.TextChanged += new System.EventHandler(this.txbxDName_TextChanged);
            // 
            // txbxDAge
            // 
            this.txbxDAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxDAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDAge.ForeColor = System.Drawing.Color.White;
            this.txbxDAge.Location = new System.Drawing.Point(525, 110);
            this.txbxDAge.Name = "txbxDAge";
            this.txbxDAge.Size = new System.Drawing.Size(162, 26);
            this.txbxDAge.TabIndex = 1;
            this.txbxDAge.TextChanged += new System.EventHandler(this.txbxDAge_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label8.Location = new System.Drawing.Point(439, 113);
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
            this.label10.Location = new System.Drawing.Point(26, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Your Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label11.Location = new System.Drawing.Point(26, 65);
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
            this.label12.Location = new System.Drawing.Point(26, 20);
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
            this.label7.Location = new System.Drawing.Point(439, 178);
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
            this.cbDGender.Location = new System.Drawing.Point(525, 175);
            this.cbDGender.Name = "cbDGender";
            this.cbDGender.Size = new System.Drawing.Size(162, 26);
            this.cbDGender.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label9.Location = new System.Drawing.Point(26, 181);
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
            this.txbxDCity.Location = new System.Drawing.Point(162, 175);
            this.txbxDCity.Name = "txbxDCity";
            this.txbxDCity.Size = new System.Drawing.Size(242, 26);
            this.txbxDCity.TabIndex = 3;
            this.txbxDCity.TextChanged += new System.EventHandler(this.txbxDCity_TextChanged);
            // 
            // txbxDPhone
            // 
            this.txbxDPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxDPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDPhone.ForeColor = System.Drawing.Color.White;
            this.txbxDPhone.Location = new System.Drawing.Point(162, 239);
            this.txbxDPhone.Name = "txbxDPhone";
            this.txbxDPhone.Size = new System.Drawing.Size(242, 26);
            this.txbxDPhone.TabIndex = 4;
            this.txbxDPhone.TextChanged += new System.EventHandler(this.txbxDPhone_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label13.Location = new System.Drawing.Point(26, 245);
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
            this.label14.Location = new System.Drawing.Point(439, 243);
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
            this.cbDBloodGroup.Location = new System.Drawing.Point(555, 239);
            this.cbDBloodGroup.Name = "cbDBloodGroup";
            this.cbDBloodGroup.Size = new System.Drawing.Size(132, 26);
            this.cbDBloodGroup.TabIndex = 5;
            this.cbDBloodGroup.TextChanged += new System.EventHandler(this.cbDBloodGroup_TextChanged);
            // 
            // rtxbxDAddress
            // 
            this.rtxbxDAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rtxbxDAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxbxDAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbxDAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxbxDAddress.Location = new System.Drawing.Point(162, 311);
            this.rtxbxDAddress.Name = "rtxbxDAddress";
            this.rtxbxDAddress.Size = new System.Drawing.Size(239, 93);
            this.rtxbxDAddress.TabIndex = 6;
            this.rtxbxDAddress.Text = "";
            this.rtxbxDAddress.TextChanged += new System.EventHandler(this.rtxbxDAddress_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label15.Location = new System.Drawing.Point(26, 311);
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
            this.btnAddDonor.Location = new System.Drawing.Point(565, 362);
            this.btnAddDonor.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(122, 42);
            this.btnAddDonor.TabIndex = 7;
            this.btnAddDonor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.White;
            this.lblBloodGroup.Location = new System.Drawing.Point(562, 268);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(0, 16);
            this.lblBloodGroup.TabIndex = 79;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(159, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 80;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(522, 139);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 16);
            this.lblAge.TabIndex = 81;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(160, 204);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 16);
            this.lblCity.TabIndex = 82;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(522, 204);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 16);
            this.lblGender.TabIndex = 83;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(160, 268);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 16);
            this.lblPhone.TabIndex = 84;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(159, 407);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 16);
            this.lblAddress.TabIndex = 85;
            // 
            // AddDonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(742, 464);
            this.ControlBox = false;
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBloodGroup);
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
            this.Name = "AddDonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Donor - Blood Donation Society Digital System";
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
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
    }
}