using System;
using System.Data;
using System.Windows.Forms;
using BloodDonationSocietyDigitalSystem.WinForms;

namespace BloodDonationSocietyDigitalSystem
{
    public partial class LoginForm : Form
    {
        public static string userName, userEmail, userPassword;

        private readonly DataTable dataTable = new DataTable();

        private readonly DbAccessClass dbAccess = new DbAccessClass();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void TxbxEmail_TextChanged(object sender, EventArgs e)
        {
            UserInputValidating.ValidateUser(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", txbxEmail, lblEmail, "Email");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var singSignUpForm = new SignUpForm();
            Hide();
            singSignUpForm.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var email = txbxEmail.Text;
            var password = txbxPassword.Text;

            var query = "Select * From userTb Where email = '" + email + "'and password = '" + password + "'";

            dbAccess.ReadDataThroughAdapter(query, dataTable);

            try
            {
                // this is the global variables which we use further for the login user...

                userName = dataTable.Rows[0]["name"].ToString();
                userEmail = dataTable.Rows[0]["email"].ToString();
                userPassword = dataTable.Rows[0]["password"].ToString();


                if (dataTable.Rows.Count == 1)
                {
                    Hide();
                    var frm = new HomeParentForm();
                    frm.Show();
                }

                else
                {
                    MessageBox.Show(@"Email or Password is incorrect...", @"Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Incorrect Password", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}