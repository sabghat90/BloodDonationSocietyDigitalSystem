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
            
            if (this.ContainerPanel.Controls.Count > 0)
                this.ContainerPanel.Controls.RemoveAt(0);
            ContainerPanel.Controls.Clear();

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(f);
            this.ContainerPanel.Tag = f;
            f.Show();
        }

        private void BtnActivationLblPosition(Button b)
        {
            lblBtnPoint.Location = new Point(b.Location.X - lblBtnPoint.Width, b.Location.Y);
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            LoadFormsToPanel(new AddDonor());
            BtnActivationLblPosition(btnAddDonor);
        }

        private void btnViewDonor_Click(object sender, EventArgs e)
        {
            LoadFormsToPanel(new ViewDonor());
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
            LoadFormsToPanel(new UpdateProfile());
            BtnActivationLblPosition(btnUpdateProfile);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
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
