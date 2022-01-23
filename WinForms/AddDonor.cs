﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    public partial class AddDonor : Form
    {
        public AddDonor()
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

        private void label1_Click(object sender, EventArgs e)
        {
            var homeForm = new DashboardForm();
            homeForm.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var viewDonorForm = new ViewDonor();
            viewDonorForm.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}