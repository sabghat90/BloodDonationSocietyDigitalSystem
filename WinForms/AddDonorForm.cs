using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class AddDonorForm : Form
    {
        private readonly DbAccessClass dbAccess = new DbAccessClass();

        public AddDonorForm()
        {
            InitializeComponent();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            var query =
                "INSERT INTO DonorTb (dName, dAge, dGender, dCity, dPhone, dBloodGroup, dAddress,email) VALUES ('" +
                txbxDName.Text + "','" + txbxDAge.Text + "','" + cbDGender.Text + "','" + txbxDCity.Text +
                "','" + txbxDPhone.Text + "','" + cbDBloodGroup.Text + "','" + rtxbxDAddress.Text + "','" +
                LoginForm.email + "')";
            var cmd = new SqlCommand(query);

            var rowsEffected = dbAccess.ExecuteQuery(cmd);

            try
            {
                if (rowsEffected == 1)
                    MessageBox.Show("Donor Added Successfully", "Confirmation", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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

        private void txbxDName_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser("^[A-Za-z - ]+$", txbxDName, lblName, "Name");
        }

        private void txbxDAge_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[1-9]+$", txbxDAge, lblAge, "Age");
        }

        private void txbxDCity_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser("[A-Za-z - ]+$", txbxDCity, lblCity, "City");
        }

        private void txbxDPhone_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$", txbxDPhone, lblPhone, "Phone Number");
        }

        private void cbDBloodGroup_TextChanged(object sender, EventArgs e)
        {
            if (!(cbDBloodGroup.Text.Equals("A+") || cbDBloodGroup.Text.Equals("A-") ||
                  cbDBloodGroup.Text.Trim().Equals("B+") || cbDBloodGroup.Text.Equals("B-") ||
                  cbDBloodGroup.Text.Equals("AB+") || cbDBloodGroup.Text.Equals("AB-") ||
                  cbDBloodGroup.Text.Equals("O+") || cbDBloodGroup.Text.Equals("O-")))
                lblBloodGroup.Text = "Invalid";
            else
                lblBloodGroup.Text = "";
        }

        private void rtxbxDAddress_TextChanged(object sender, EventArgs e)
        {
            if (rtxbxDAddress.Text.Equals(""))
                lblAddress.Text = @"Empty Filed";
            else if (Regex.Match(rtxbxDAddress.Text, @"^\d+\s[A-z]+\s[A-z]+").Success)
                lblAddress.Text = @"Invalid Address...";
            else
                lblAddress.Text = "";
        }
    }
}