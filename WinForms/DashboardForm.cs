using System;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = @"Welcome " + LoginForm.name.ToUpper() + @"️ ❤️";
        }
    }
}