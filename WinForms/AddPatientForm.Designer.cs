namespace BloodDonationSocietyDigitalSystem.WinForms
{
    partial class AddPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            this.btnAddPatient = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label15 = new System.Windows.Forms.Label();
            this.rtxbxPAddress = new System.Windows.Forms.RichTextBox();
            this.cbPBloodGroup = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbxPName = new System.Windows.Forms.TextBox();
            this.txbxPCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbxPPhone = new System.Windows.Forms.TextBox();
            this.txbxPAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.ActiveBorderThickness = 1;
            this.btnAddPatient.ActiveCornerRadius = 20;
            this.btnAddPatient.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.btnAddPatient.ActiveForecolor = System.Drawing.Color.Black;
            this.btnAddPatient.ActiveLineColor = System.Drawing.Color.Red;
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPatient.BackgroundImage")));
            this.btnAddPatient.ButtonText = "Add Donor";
            this.btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddPatient.IdleBorderThickness = 1;
            this.btnAddPatient.IdleCornerRadius = 20;
            this.btnAddPatient.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddPatient.IdleForecolor = System.Drawing.Color.White;
            this.btnAddPatient.IdleLineColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(558, 365);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(160, 42);
            this.btnAddPatient.TabIndex = 68;
            this.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label15.Location = new System.Drawing.Point(34, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 20);
            this.label15.TabIndex = 77;
            this.label15.Text = "Address";
            // 
            // rtxbxPAddress
            // 
            this.rtxbxPAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rtxbxPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxbxPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbxPAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxbxPAddress.Location = new System.Drawing.Point(132, 314);
            this.rtxbxPAddress.Name = "rtxbxPAddress";
            this.rtxbxPAddress.Size = new System.Drawing.Size(239, 93);
            this.rtxbxPAddress.TabIndex = 67;
            this.rtxbxPAddress.Text = "";
            this.rtxbxPAddress.TextChanged += new System.EventHandler(this.rtxbxDAddress_TextChanged);
            // 
            // cbPBloodGroup
            // 
            this.cbPBloodGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbPBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPBloodGroup.ForeColor = System.Drawing.SystemColors.Window;
            this.cbPBloodGroup.FormattingEnabled = true;
            this.cbPBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbPBloodGroup.Location = new System.Drawing.Point(558, 141);
            this.cbPBloodGroup.Name = "cbPBloodGroup";
            this.cbPBloodGroup.Size = new System.Drawing.Size(160, 26);
            this.cbPBloodGroup.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label14.Location = new System.Drawing.Point(418, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 76;
            this.label14.Text = "Blood Group";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label13.Location = new System.Drawing.Point(32, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 75;
            this.label13.Text = "Name";
            // 
            // txbxPName
            // 
            this.txbxPName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPName.ForeColor = System.Drawing.Color.White;
            this.txbxPName.Location = new System.Drawing.Point(132, 143);
            this.txbxPName.Name = "txbxPName";
            this.txbxPName.Size = new System.Drawing.Size(242, 26);
            this.txbxPName.TabIndex = 65;
            this.txbxPName.TextChanged += new System.EventHandler(this.txbxPName_TextChanged);
            // 
            // txbxPCity
            // 
            this.txbxPCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxPCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPCity.ForeColor = System.Drawing.Color.White;
            this.txbxPCity.Location = new System.Drawing.Point(558, 197);
            this.txbxPCity.Name = "txbxPCity";
            this.txbxPCity.Size = new System.Drawing.Size(160, 26);
            this.txbxPCity.TabIndex = 64;
            this.txbxPCity.TextChanged += new System.EventHandler(this.txbxDCity_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label9.Location = new System.Drawing.Point(418, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 74;
            this.label9.Text = "City";
            // 
            // cbPGender
            // 
            this.cbPGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbPGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPGender.ForeColor = System.Drawing.SystemColors.Window;
            this.cbPGender.FormattingEnabled = true;
            this.cbPGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Custom"});
            this.cbPGender.Location = new System.Drawing.Point(132, 199);
            this.cbPGender.Name = "cbPGender";
            this.cbPGender.Size = new System.Drawing.Size(242, 26);
            this.cbPGender.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(32, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Gender";
            // 
            // txbxPPhone
            // 
            this.txbxPPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxPPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPPhone.ForeColor = System.Drawing.Color.White;
            this.txbxPPhone.Location = new System.Drawing.Point(132, 255);
            this.txbxPPhone.Name = "txbxPPhone";
            this.txbxPPhone.Size = new System.Drawing.Size(242, 26);
            this.txbxPPhone.TabIndex = 61;
            this.txbxPPhone.TextChanged += new System.EventHandler(this.txbxDPhone_TextChanged);
            // 
            // txbxPAge
            // 
            this.txbxPAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxPAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPAge.ForeColor = System.Drawing.Color.White;
            this.txbxPAge.Location = new System.Drawing.Point(558, 253);
            this.txbxPAge.Name = "txbxPAge";
            this.txbxPAge.Size = new System.Drawing.Size(160, 26);
            this.txbxPAge.TabIndex = 62;
            this.txbxPAge.TextChanged += new System.EventHandler(this.txbxPAge_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label8.Location = new System.Drawing.Point(418, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Age";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label10.Location = new System.Drawing.Point(32, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 71;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label11.Location = new System.Drawing.Point(33, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 16);
            this.label11.TabIndex = 70;
            this.label11.Text = "Patient Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.label12.Location = new System.Drawing.Point(33, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 25);
            this.label12.TabIndex = 69;
            this.label12.Text = "Add Patient";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(129, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 78;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.White;
            this.lblBloodGroup.Location = new System.Drawing.Point(555, 170);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(0, 16);
            this.lblBloodGroup.TabIndex = 79;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(129, 228);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 16);
            this.lblGender.TabIndex = 80;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(555, 226);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 16);
            this.lblCity.TabIndex = 81;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(129, 284);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 16);
            this.lblPhone.TabIndex = 82;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(555, 284);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 16);
            this.lblAge.TabIndex = 83;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(129, 410);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 16);
            this.lblAddress.TabIndex = 84;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(742, 464);
            this.ControlBox = false;
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rtxbxPAddress);
            this.Controls.Add(this.cbPBloodGroup);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbxPName);
            this.Controls.Add(this.txbxPCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbxPPhone);
            this.Controls.Add(this.txbxPAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPatientForm";
            this.Text = "Add Patient - Blood Donation Society Digital System";
            this.Load += new System.EventHandler(this.AddPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddPatient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rtxbxPAddress;
        private System.Windows.Forms.ComboBox cbPBloodGroup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbxPName;
        private System.Windows.Forms.TextBox txbxPCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbxPPhone;
        private System.Windows.Forms.TextBox txbxPAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAddress;
    }
}