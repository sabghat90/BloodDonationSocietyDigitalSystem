using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class ViewPatientForm : Form
    {
        private readonly DbAccessClass dbAccess = new DbAccessClass();
        private SqlDataReader reader;

        public ViewPatientForm()
        {
            InitializeComponent();
        }

        private void ViewPatientForm_Load(object sender, EventArgs e)
        {
            const string query = "SELECT * FROM PatientTb";

            reader = dbAccess.ReadDataThroughReader(query);

            try
            {
                while (reader.Read())
                    datagridPatient.Rows.Add(reader["pName"], reader["pAge"], reader["pGender"], reader["pPhone"],
                        reader["pAddress"]);
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
                    datagridPatient.Rows.Clear();
                    var query =
                        "SELECT * FROM DonorTb where dBloodGroup = '" +
                        txbxSearch.Text + "' or dName = '" + txbxSearch.Text + "'";

                    reader = dbAccess.ReadDataThroughReader(query);

                    while (reader.Read())
                        datagridPatient.Rows.Add(reader["dName"], reader["dAge"], reader["dGender"], reader["dPhone"],
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