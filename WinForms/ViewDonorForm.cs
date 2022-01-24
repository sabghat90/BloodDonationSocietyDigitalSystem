using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class ViewDonorForm : Form
    {
        public ViewDonorForm()
        {
            InitializeComponent();
        }

        private void FillData(string query)
        {
            const string connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sabgh\source\repos\BloodDonationSocietyDigitalSystem\BDSDS_db.mdf;Integrated Security=True;Connect Timeout=30";
            var conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                var adapter = new SqlDataAdapter(cmd);

                var ds = new DataSet();
                adapter.Fill(ds, "DonorTb");

                datagridDonor.DataSource = ds.Tables["DonorTb"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Could not establish connection with database server. Please try again. Error: " +
                                ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void txbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var query =
                    "SELECT dName as Name, dGender as Gender, dAge as Age,dBloodGroup as [Blood Group], dPhone as Phone, dCity as City FROM DonorTb where dBloodGroup = '" +
                    txbxSearch.Text + "' or dName = '" + txbxSearch.Text + "'";
                FillData(query);
            }
        }

        private void ViewDonor_Load(object sender, EventArgs e)
        {
            const string query =
                "SELECT dName as Name, dGender as Gender, dAge as Age,dBloodGroup as [Blood Group], dPhone as Phone, dCity as City FROM DonorTb";
            FillData(query);
        }
    }
}