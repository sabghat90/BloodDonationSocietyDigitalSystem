using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class UpdateProfileForm : Form
    {
        private DbAccessClass dbAccess = new DbAccessClass();
        SqlDataReader reader = null;

        public UpdateProfileForm()
        {
            InitializeComponent();
        }

        private void txbxUpdateName_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser("^[A-Za-z - ]+$", txbxUpdateName, lblName, "Name");
        }

        private void cbUpdateBloodGroup_TextChanged(object sender, EventArgs e)
        {
            if (!(cbUpdateBloodGroup.Text.Equals("A+") || cbUpdateBloodGroup.Text.Equals("A-") ||
                  cbUpdateBloodGroup.Text.Equals("B+") || cbUpdateBloodGroup.Text.Equals("B-") ||
                  cbUpdateBloodGroup.Text.Equals("AB+") || cbUpdateBloodGroup.Text.Equals("AB-") ||
                  cbUpdateBloodGroup.Text.Equals("O+") || cbUpdateBloodGroup.Text.Equals("O-")))
                lblBloodGroup.Text = "Invalid";
            else
                lblBloodGroup.Text = "";
        }

        private void cbUpdateGender_TextChanged(object sender, EventArgs e)
        {
            if (cbUpdateGender.Text.Equals(""))
                lblGender.Text = "Empty Field";
            else if (!(cbUpdateGender.Text == "Male" || cbUpdateGender.Text == "Female" ||
                       cbUpdateGender.Text == "Custom"))
                lblGender.Text = "Invalid Gender";
            else
                lblGender.Text = "";
        }

        private void txbxUpdateCity_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser("[A-Za-z - ]+$", txbxUpdateCity, lblCity, "City");
        }

        private void txbxUpdatePhone_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[0][1-9]\d{9}$|^[1-9]\d{9}$", txbxUpdatePhone, lblPhone,
                "Phone Number");
        }

        private void txbxUpdateAge_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[1-9]+$", txbxUpdateAge, lblAge, "Age");
        }

        private void rtxbxUpdateAddress_TextChanged(object sender, EventArgs e)
        {
            if (rtxbxUpdateAddress.Text.Equals(""))
                lblAddress.Text = @"Empty Filed";
            else if (Regex.Match(rtxbxUpdateAddress.Text, @"^\d+\s[A-z]+\s[A-z]+").Success)
                lblAddress.Text = @"Invalid Address...";
            else
                lblAddress.Text = "";
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string query = "UPDATE DonorTb SET dName = '" + txbxUpdateName.Text + "', dAge = '" + txbxUpdateAge.Text +
                           "', dGender = '" + cbUpdateGender.Text + "', dPhone = '" + txbxUpdatePhone.Text + "', dBloodGroup = '" + cbUpdateBloodGroup.Text + "', dAddress = '" + rtxbxUpdateAddress.Text + "' WHERE email = '" + LoginForm.userEmail + "'";
            int rowsEffected = dbAccess.ExecuteQuery(new SqlCommand(query));

            try
            {
                if (rowsEffected == 1)
                {
                    MessageBox.Show("Information Updated Successfully", "Confirmation", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sorry, Something went wrong, please try again.", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Connection not established", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbAccess.CloseConn();
            }
        }

        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DonorTb WHERE email = '" + LoginForm.userEmail + "'";

            reader = dbAccess.ReadDataThroughReader(query);

            try
            {
                if (reader.Read())
                {
                    txbxUpdateName.Text = reader["dName"].ToString();
                    txbxUpdateAge.Text = reader["dAge"].ToString();
                    cbUpdateGender.Text = reader["dGender"].ToString();
                    txbxUpdateCity.Text = reader["dCity"].ToString();
                    txbxUpdatePhone.Text = reader["dPhone"].ToString();
                    cbUpdateBloodGroup.Text = reader["dBloodGroup"].ToString();
                    rtxbxUpdateAddress.Text = reader["dAddress"].ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbAccess.CloseConn();
            }
        }
    }
}