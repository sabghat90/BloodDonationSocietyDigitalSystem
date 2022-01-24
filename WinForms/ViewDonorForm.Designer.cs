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
            this.datagridDonor = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDonor)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridDonor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridDonor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridDonor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridDonor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridDonor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.datagridDonor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridDonor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datagridDonor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagridDonor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridDonor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDonor.DoubleBuffered = true;
            this.datagridDonor.EnableHeadersVisualStyles = false;
            this.datagridDonor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.datagridDonor.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.datagridDonor.HeaderForeColor = System.Drawing.Color.White;
            this.datagridDonor.Location = new System.Drawing.Point(0, 80);
            this.datagridDonor.Name = "datagridDonor";
            this.datagridDonor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridDonor.ShowEditingIcon = false;
            this.datagridDonor.Size = new System.Drawing.Size(763, 325);
            this.datagridDonor.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveBorderThickness = 1;
            this.btnRefresh.ActiveCornerRadius = 20;
            this.btnRefresh.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.btnRefresh.ActiveForecolor = System.Drawing.Color.Black;
            this.btnRefresh.ActiveLineColor = System.Drawing.Color.Red;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.ButtonText = "Refresh";
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.IdleBorderThickness = 1;
            this.btnRefresh.IdleCornerRadius = 20;
            this.btnRefresh.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRefresh.IdleForecolor = System.Drawing.Color.White;
            this.btnRefresh.IdleLineColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(596, 424);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 42);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbxSearch
            // 
            this.txbxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxSearch.ForeColor = System.Drawing.Color.White;
            this.txbxSearch.Location = new System.Drawing.Point(376, 29);
            this.txbxSearch.Name = "txbxSearch";
            this.txbxSearch.Size = new System.Drawing.Size(238, 26);
            this.txbxSearch.TabIndex = 9;
            this.txbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbxSearch_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.label7.Location = new System.Drawing.Point(288, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Search";
            // 
            // ViewDonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(742, 464);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbxSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.datagridDonor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewDonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Donor - Blood Donation Society Digital System";
            this.Load += new System.EventHandler(this.ViewDonor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridDonor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridDonor;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRefresh;
        private System.Windows.Forms.TextBox txbxSearch;
        private System.Windows.Forms.Label label7;
    }
}