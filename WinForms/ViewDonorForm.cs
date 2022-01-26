using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class ViewDonorForm : Form
    {

        private readonly DbAccessClass dbAccess = new DbAccessClass();
        private SqlDataReader reader;

        public ViewDonorForm()
        {
            InitializeComponent();
        }

        private void ViewDonorForm_Load(object sender, System.EventArgs e)
        {
            const string query = "SELECT * FROM DonorTb";

            reader = dbAccess.ReadDataThroughReader(query);

            try
            {
                while (reader.Read())
                    datagridDonor.Rows.Add(reader["dName"], reader["dAge"], reader["dGender"], reader["dPhone"],
                        reader["dAddress"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went Wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbAccess.CloseConn();
            }
        }

        private void txbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    datagridDonor.Rows.Clear();
                    var query =
                        "SELECT * FROM DonorTb where dBloodGroup = '" +
                        txbxSearch.Text + "' or dName = '" + txbxSearch.Text + "'";

                    reader = dbAccess.ReadDataThroughReader(query);

                    while (reader.Read())
                        datagridDonor.Rows.Add(reader["dName"], reader["dAge"], reader["dGender"], reader["dPhone"],
                            reader["dAddress"]);
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