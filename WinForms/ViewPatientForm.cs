using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class ViewPatientForm : Form
    {
        DataTable dt = new DataTable();
        private DbAccessClass dbAccess = new DbAccessClass();

        public ViewPatientForm()
        {
            InitializeComponent();
        }

        private void ViewPatientForm_Load(object sender, System.EventArgs e)
        {
            const string query =
                "SELECT dName as Name, dGender as Gender, dAge as Age,dBloodGroup as [Blood Group], dPhone as Phone, dCity as City FROM DonorTb";
            dt = dbAccess.readDatathroughAdapter(query, dt);
            datagriPatient.DataSource = dt;
        }

        private void txbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var query =
                "SELECT dName as Name, dGender as Gender, dAge as Age,dBloodGroup as [Blood Group], dPhone as Phone, dCity as City FROM DonorTb where dBloodGroup = '" +
                txbxSearch.Text + "' or dName = '" + txbxSearch.Text + "'";
            dt = dbAccess.readDatathroughAdapter(query, dt);
            datagriPatient.DataSource = dt;
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

                datagriPatient.DataSource = ds.Tables["DonorTb"];
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
    }
}