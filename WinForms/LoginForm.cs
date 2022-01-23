using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BloodDonationSocietyDigitalSystem.WinForms;

namespace BloodDonationSocietyDigitalSystem
{
    public partial class LoginForm : Form
    {
        public static string id, name, email, password;

        private readonly DataTable dt = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signUpForm = new SignUpForm();
            signUpForm.Show();
            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txbxEmail.Text;
            var password = txbxPassword.Text;

            var query = "Select * From userTb Where email = '" + email + "'and password = '" + password + "'";

            ReadDataThroughAdapter(query, dt);
        }

        private void ReadDataThroughAdapter(string query, DataTable dataTable)
        {
            const string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sabgh\source\repos\BloodDonationSocietyDigitalSystem\BDSDS_db.mdf;Integrated Security=True;Connect Timeout=30";

            var conn = new SqlConnection(connectionString);
            var cmd = new SqlCommand(query, conn);
            var sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataTable);

            try
            {
                conn.Open();

                // this is the global variables which we use further for the login user...

                id = dataTable.Rows[0]["id"].ToString();
                name = dataTable.Rows[0]["name"].ToString();
                email = dataTable.Rows[0]["email"].ToString();
                password = dataTable.Rows[0]["password"].ToString();


                if (dataTable.Rows.Count == 1)
                {
                    Hide();
                    var frm = new HomeParentForm();
                    frm.Show();
                }

                else
                {
                    MessageBox.Show(@"Email or Password is incorrect...", @"Warning", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Fields are Empty", @"Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}