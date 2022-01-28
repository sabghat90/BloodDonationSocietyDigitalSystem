using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class AccountSettingForm : Form
    {
        private DbAccessClass dbAccess = new DbAccessClass();

        public AccountSettingForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbxCurrentPassword.Text == LoginForm.userPassword)
                {
                    string query = "UPDATE userTb SET password = '" + txbxCNewPassword.Text + "' WHERE email = '"+LoginForm.userEmail+"'";

                    int rowsAffected = dbAccess.ExecuteQuery(new SqlCommand(query));

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Successfully Changes Password. Back to Login...", "Confiration",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Current Password is Wrong...", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                dbAccess.CloseConn();
            }
            
        }

        private void txbxNewPassword_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[A-Za-z0-9_\-\.]{4,}$",
                txbxNewPassword, lblPassword, "Password");
            if (txbxNewPassword.Text != txbxCNewPassword.Text)
            {
                lblCPassword.Text = "Password Not Matching";
            }
        }
    }
}
