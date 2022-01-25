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

        private void txbxPName_TextChanged(object sender, System.EventArgs e)
        {
            UserInputValidating.ValidateUser("^[A-Za-z - ]+$", txbxPName, lblName, "Name");
        }

        private void txbxDPhone_TextChanged(object sender, System.EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$", txbxDPhone, lblPhone, "Phone Number");
        }

        private void txbxDCity_TextChanged(object sender, System.EventArgs e)
        {
            UserInputValidating.ValidateUser("[A-Za-z - ]+$", txbxDCity, lblCity, "City");
        }

        private void txbxPAge_TextChanged(object sender, System.EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[1-9]+$", txbxPAge, lblAge, "Age");
        }

        private void rtxbxDAddress_TextChanged(object sender, System.EventArgs e)
        {
            if (rtxbxDAddress.Text.Equals(""))
            {
                lblAddress.Text = @"Empty Filed";
            }
            else if (Regex.Match(rtxbxDAddress.Text, @"^\d+\s[A-z]+\s[A-z]+").Success)
            {
                lblAddress.Text = @"Invalid Address...";
            }
            else
            {
                lblAddress.Text = "";
            }
        }
    }
}