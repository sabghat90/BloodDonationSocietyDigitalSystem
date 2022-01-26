using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class SignUpForm : Form
    {
        private readonly DbAccessClass dbAccess = new DbAccessClass();

        public SignUpForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     this function will validate user information like userName, email and password then return a boolean value to
        ///     SignUp
        ///     btn click event to make a connection with db and add the user.
        /// </summary>
        /// <returns></returns>
        private bool ValidateUser()
        {
            var isValidUser = false;
            if (!Regex.Match(txbxName.Text, @"^[A-Za-z] + $").Success)
                if (Regex.Match(txbxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
                    if (!Regex.Match(txbxPassword.Text,
                            @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8, 20}$").Success &&
                        txbxPassword.Text == txbxCPassword.Text)
                        isValidUser = true;
            return isValidUser;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var name = txbxName.Text.Trim();
            var email = txbxEmail.Text.Trim();
            var password = txbxPassword.Text.Trim();
            if (ValidateUser())
            {
                const string query =
                    "INSERT INTO userTb (name, email, password) VALUES (@name, @email, @password)";
                var cmd = new SqlCommand(query);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                var rowsEffected = dbAccess.ExecuteQuery(cmd);

                try
                {
                    if (rowsEffected == 1)
                    {
                        MessageBox.Show(@"Registration Successful, Go Back To Login", @"Confirmation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        var frmLoginForm = new LoginForm();
                        frmLoginForm.Show();
                        Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Registration Failed" + ex.Message);
                }
            }
        }

        private void txbxName_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^[A-Za-z - ]+$",txbxName,lblName,"Name");
        }

        private void txbxEmail_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",txbxEmail,lblEmail,"Email");
        }

        private void txbxPassword_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8, 20}$",txbxPassword,lblPassword,"Password");
        }

        private void txbxCPassword_TextChanged(object sender, EventArgs e)
        {
            lblCPassword.Text = txbxPassword.Text != txbxCPassword.Text ? "Password Not Matching" : "";
        }
    }
}