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
    }
}
