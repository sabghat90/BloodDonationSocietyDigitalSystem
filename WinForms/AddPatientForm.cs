using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class AddPatientForm : Form
    {
        private DbAccessClass dbAccess = new DbAccessClass();

        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
        }

        private void txbxPName_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser("^[A-Za-z - ]+$", txbxPName, lblName, "Name");
        }

        private void txbxDPhone_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$", txbxPPhone, lblPhone, "Phone Number");
        }

        private void txbxDCity_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser("[A-Za-z - ]+$", txbxPCity, lblCity, "City");
        }

        private void txbxPAge_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[1-9]+$", txbxPAge, lblAge, "Age");
        }

        private void rtxbxDAddress_TextChanged(object sender, EventArgs e)
        {
            if (rtxbxPAddress.Text.Equals(""))
                lblAddress.Text = @"Empty Filed";
            else if (Regex.Match(rtxbxPAddress.Text, @"^\d+\s[A-z]+\s[A-z]+").Success)
                lblAddress.Text = @"Invalid Address...";
            else
                lblAddress.Text = "";
        }

        private void cbPBloodGroup_TextChanged(object sender, EventArgs e)
        {
            if (!(cbPBloodGroup.Text.Equals("A+") || cbPBloodGroup.Text.Equals("A-") ||
                  cbPBloodGroup.Text.Trim().Equals("B+") || cbPBloodGroup.Text.Equals("B-") ||
                  cbPBloodGroup.Text.Equals("AB+") || cbPBloodGroup.Text.Equals("AB-") ||
                  cbPBloodGroup.Text.Equals("O+") || cbPBloodGroup.Text.Equals("O-")))
                lblBloodGroup.Text = "Invalid";
            else
                lblBloodGroup.Text = "";
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            var query =
                "INSERT INTO PatientTb (dName, dAge, dGender, dCity, dPhone, dBloodGroup, dAddress,email) VALUES ('" +
                txbxPName.Text + "','" + txbxPAge.Text + "','" + cbPGender.Text + "','" + txbxPCity.Text +
                "','" + txbxPPhone.Text + "','" + cbPBloodGroup.Text + "','" + rtxbxPAddress.Text + "','" +
                LoginForm.userEmail + "')";
            var cmd = new SqlCommand(query);

            var rowsEffected = dbAccess.ExecuteQuery(cmd);

            try
            {
                if (rowsEffected == 1)
                    MessageBox.Show("Donor Added Successfully", "Confirmation", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("You are Already Registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You are Already Registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbAccess.CloseConn();
            }
        }
    }
}