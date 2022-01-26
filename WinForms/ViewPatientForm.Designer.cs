namespace BloodDonationSocietyDigitalSystem.WinForms
{
    partial class ViewPatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatientForm));
            this.datagridPatient = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridPatient
            // 
            this.datagridPatient.AllowUserToAddRows = false;
            this.datagridPatient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.datagridPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datagridPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientName,
            this.patientAge,
            this.patientGender,
            this.patientPhone,
            this.patientAddress});
            this.datagridPatient.DoubleBuffered = true;
            this.datagridPatient.EnableHeadersVisualStyles = false;
            this.datagridPatient.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.datagridPatient.HeaderBgColor = System.Drawing.Color.Transparent;
            this.datagridPatient.HeaderForeColor = System.Drawing.Color.White;
            this.datagridPatient.Location = new System.Drawing.Point(12, 62);
            this.datagridPatient.Name = "datagridPatient";
            this.datagridPatient.ReadOnly = true;
            this.datagridPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridPatient.Size = new System.Drawing.Size(702, 351);
            this.datagridPatient.TabIndex = 15;
            // 
            // txbxSearch
            // 
            this.txbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxSearch.ForeColor = System.Drawing.Color.White;
            this.txbxSearch.Location = new System.Drawing.Point(322, 12);
            this.txbxSearch.Name = "txbxSearch";
            this.txbxSearch.Size = new System.Drawing.Size(242, 26);
            this.txbxSearch.TabIndex = 14;
            this.txbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbxSearch_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(153, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(86, 25);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search";
            // 
            // patientName
            // 
            this.patientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientName.HeaderText = "Name";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            // 
            // patientAge
            // 
            this.patientAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.patientAge.HeaderText = "Age";
            this.patientAge.Name = "patientAge";
            this.patientAge.ReadOnly = true;
            this.patientAge.Width = 5;
            // 
            // patientGender
            // 
            this.patientGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientGender.HeaderText = "Gender";
            this.patientGender.Name = "patientGender";
            this.patientGender.ReadOnly = true;
            // 
            // patientPhone
            // 
            this.patientPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientPhone.HeaderText = "Phone";
            this.patientPhone.Name = "patientPhone";
            this.patientPhone.ReadOnly = true;
            // 
            // patientAddress
            // 
            this.patientAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.patientAddress.HeaderText = "Address";
            this.patientAddress.Name = "patientAddress";
            this.patientAddress.ReadOnly = true;
            this.patientAddress.Width = 5;
            // 
            // ViewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(726, 425);
            this.ControlBox = false;
            this.Controls.Add(this.datagridPatient);
            this.Controls.Add(this.txbxSearch);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDonorForm";
            this.Load += new System.EventHandler(this.ViewPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridPatient;
        private System.Windows.Forms.TextBox txbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAddress;
    }
}