using System;
using System.Drawing;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class HomeParentForm : Form
    {
        public HomeParentForm()
        {
            InitializeComponent();
            BtnActivationLblPosition(btnDashboard);
            LoadFormsToPanel(new DashboardForm());
        }

        private void LoadFormsToPanel(object Form)
        {
            if (ContainerPanel.Controls.Count > 0)
                ContainerPanel.Controls.RemoveAt(0);
            ContainerPanel.Controls.Clear();

            var f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(f);
            ContainerPanel.Tag = f;
            f.Show();
        }

        private void BtnActivationLblPosition(Button b)
        {
            lblBtnPoint.Location = new Point(b.Location.X - lblBtnPoint.Width, b.Location.Y);
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            LoadFormsToPanel(new AddDonorForm());
            BtnActivationLblPosition(btnAddDonor);
        }

        private void btnViewDonor_Click(object sender, EventArgs e)
        {
            LoadFormsToPanel(new ViewDonorForm());
            BtnActivationLblPosition(btnViewDonor);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            LoadFormsToPanel(new AddPatientForm());
            BtnActivationLblPosition(btnAddPatient);
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            LoadFormsToPanel(new ViewPatientForm());
            BtnActivationLblPosition(btnViewPatient);
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            LoadFormsToPanel(new UpdateProfileForm());
            BtnActivationLblPosition(btnUpdateProfile);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            Hide();
            loginForm.Show();
            BtnActivationLblPosition(btnLogout);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            BtnActivationLblPosition(btnDashboard);
            LoadFormsToPanel(new DashboardForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}