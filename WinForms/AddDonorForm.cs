using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class AddDonorForm : Form
    {
        public AddDonorForm()
        {
            InitializeComponent();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            var query = "INSERT INTO DonorTb (dName, dAge, dGender, dCity, dPhone, dBloodGroup, dAddress) VALUES ('" +
                        txbxDName.Text + "','" + txbxDAge.Text + "','" + cbDGender.Text + "','" + txbxDCity.Text +
                        "','" + txbxDPhone.Text + "','" + cbDBloodGroup.Text + "','" + rtxbxDAddress.Text + "')";

            InsertToDb(query);
        }

        private void InsertToDb(string query)
        {
            const string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sabgh\source\repos\BloodDonationSocietyDigitalSystem\BDSDS_db.mdf;Integrated Security=True;Connect Timeout=30";
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);

                var rowsEffected = cmd.ExecuteNonQuery();

                if (rowsEffected > 0)
                    MessageBox.Show(@"Donor Added Successfully", @"Confirmation", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Adding Failed");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        private void AddDonor_Load(object sender, EventArgs e)
        {

        }

        private void cbDGender_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void cbDBloodGroup_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(cbDBloodGroup.Text.Equals("A+") || cbDBloodGroup.Text.Equals("A-") || cbDBloodGroup.Text.Trim().Equals("B+") || cbDBloodGroup.Text.Equals("B-") || cbDBloodGroup.Text.Equals("AB+") || cbDBloodGroup.Text.Equals("AB-") || cbDBloodGroup.Text.Equals("O+") || cbDBloodGroup.Text.Equals("O-")))
            {
                lblBloodGroup.Text = "Invalid";
            }
            else
            {
                lblBloodGroup.Text = "";
            }
        }
    }
}