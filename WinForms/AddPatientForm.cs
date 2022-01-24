using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void AddPatientForm_Load(object sender, System.EventArgs e)
        {

        }

        private void txbxDName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txbxPName.Text.Equals(""))
                lblName.Text = @"Name Should Not Be Empty";
            else if (!Regex.Match(txbxPName.Text, "^[A-Za-z - ]+$").Success)
                lblName.Text = @"Invalid Name";
            else
                lblName.Text = "";
        }

        private void cbDBloodGroup_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            
        }
    }
}