using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class SignUpForm : Form
    {
        private DbAccessClass dbAccess = new DbAccessClass();
        public SignUpForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     this function will validate user information like name, email and password then return a boolean value to SignUp
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var name = txbxName.Text.Trim();
            var email = txbxEmail.Text.Trim();
            var password = txbxPassword.Text.Trim();
            if (ValidateUser())
            {
                const string query = "INSERT INTO userTb (name, email, password) VALUES (@name, @email, @password)";
                var cmd = new SqlCommand(query);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                int rowsEffected = dbAccess.executeQuery(cmd);

                try
                {
                    if (rowsEffected == 1)
                    {
                        MessageBox.Show(@"Registration Successful, Go Back To Login", @"Confirmation", MessageBoxButtons.OK,
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

        /// <summary>
        /// this function creating a connection to database and then insert a data to database table.
        /// </summary>
        /// <param name="query">Query to interact with database.</param>
        private void InsertToDb(SqlCommand sqlCommand)
        {
            const string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sabgh\source\repos\BloodDonationSocietyDigitalSystem\BDSDS_db.mdf;Integrated Security=True;Connect Timeout=30";
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                sqlCommand.Connection = conn;
                var rowsEffected = sqlCommand.ExecuteNonQuery();

                if (rowsEffected == 1)
                {
                    MessageBox.Show(@"Registration Successful, Go Back To Login", @"Confirmation", MessageBoxButtons.OK,
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
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        /// <summary>
        ///     this method validate user name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbxName_Validating(object sender, CancelEventArgs e)
        {
            if (txbxName.Text.Equals(""))
                lblName.Text = @"Name Should Not Be Empty";
            else if (!Regex.Match(txbxName.Text, "^[A-Za-z - ]+$").Success)
                lblName.Text = @"Invalid Name";
            else
                lblName.Text = "";
        }

        /// <summary>
        ///     this function validate user email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txbxEmail.Text.Equals(""))
                lblEmail.Text = @"Email Should Not Be Empty";
            else if (!Regex.Match(txbxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
                lblEmail.Text = @"Invalid Email";
            else
                lblEmail.Text = "";
        }

        /// <summary>
        ///     this function validate user password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbxCPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txbxCPassword.Text.Equals(""))
                lblPassword.Text = @"Password Should Not Be Empty";
            else if (txbxPassword.Text == txbxCPassword.Text)
                lblPassword.Text = @"Password Not Matching";
            else if (!Regex.Match(txbxCPassword.Text,
                         @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8, 20}$").Success
                    )
                lblPassword.Text = @"Invalid Password";
            else
                lblPassword.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}