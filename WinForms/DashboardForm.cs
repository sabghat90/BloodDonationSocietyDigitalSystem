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

        private void label6_Click(object sender, EventArgs e)
        {
            var addDonorForm = new AddDonor();
            addDonorForm.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var viewDonorForm = new ViewDonor();
            viewDonorForm.Show();
            Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = @"Welcome " + LoginForm.name.ToUpper();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.Show();
        }
    }
}