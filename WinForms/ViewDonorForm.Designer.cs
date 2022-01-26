namespace BloodDonationSocietyDigitalSystem.WinForms
{
    partial class ViewDonorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDonorForm));
            this.txbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.datagridDonor = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.donorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDonor)).BeginInit();
            this.SuspendLayout();
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
            this.txbxSearch.TabIndex = 11;
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
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search";
            // 
            // datagridDonor
            // 
            this.datagridDonor.AllowUserToAddRows = false;
            this.datagridDonor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridDonor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridDonor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.datagridDonor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridDonor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datagridDonor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridDonor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDonor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorName,
            this.donorAge,
            this.donorGender,
            this.donorPhone,
            this.donorAddress});
            this.datagridDonor.DoubleBuffered = true;
            this.datagridDonor.EnableHeadersVisualStyles = false;
            this.datagridDonor.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.datagridDonor.HeaderBgColor = System.Drawing.Color.Gray;
            this.datagridDonor.HeaderForeColor = System.Drawing.Color.White;
            this.datagridDonor.Location = new System.Drawing.Point(12, 62);
            this.datagridDonor.Name = "datagridDonor";
            this.datagridDonor.ReadOnly = true;
            this.datagridDonor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridDonor.Size = new System.Drawing.Size(702, 351);
            this.datagridDonor.TabIndex = 12;
            // 
            // donorName
            // 
            this.donorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donorName.HeaderText = "Name";
            this.donorName.Name = "donorName";
            this.donorName.ReadOnly = true;
            // 
            // donorAge
            // 
            this.donorAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donorAge.HeaderText = "Age";
            this.donorAge.Name = "donorAge";
            this.donorAge.ReadOnly = true;
            // 
            // donorGender
            // 
            this.donorGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donorGender.HeaderText = "Gender";
            this.donorGender.Name = "donorGender";
            this.donorGender.ReadOnly = true;
            // 
            // donorPhone
            // 
            this.donorPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donorPhone.HeaderText = "Phone";
            this.donorPhone.Name = "donorPhone";
            this.donorPhone.ReadOnly = true;
            // 
            // donorAddress
            // 
            this.donorAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.donorAddress.HeaderText = "Address";
            this.donorAddress.Name = "donorAddress";
            this.donorAddress.ReadOnly = true;
            this.donorAddress.Width = 5;
            // 
            // ViewDonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(726, 425);
            this.ControlBox = false;
            this.Controls.Add(this.datagridDonor);
            this.Controls.Add(this.txbxSearch);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewDonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDonorForm";
            this.Load += new System.EventHandler(this.ViewDonorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridDonor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridDonor;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorAddress;
    }
}