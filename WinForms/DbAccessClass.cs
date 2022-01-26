using System;
using System.Data;
using System.Data.SqlClient;

namespace BloodDonationSocietyDigitalSystem.WinForms
{
    internal class DbAccessClass
    {
        private static readonly SqlConnection connection = new SqlConnection();
        private static readonly SqlCommand command = new SqlCommand();
        private static SqlDataReader DbReader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        private static readonly string strConnString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sabgh\source\repos\BloodDonationSocietyDigitalSystem\BDSDS_db.mdf;Integrated Security=True;Connect Timeout=30";

        public SqlTransaction DbTran;


        private void CreateConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void CloseConn()
        {
            connection.Close();
        }


        public int ExecuteDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (connection.State == 0) CreateConn();

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                var dbCommandBuilder = new SqlCommandBuilder(adapter);


                var insert = dbCommandBuilder.GetInsertCommand().CommandText;
                var update = dbCommandBuilder.GetUpdateCommand().CommandText;
                var delete = dbCommandBuilder.GetDeleteCommand().CommandText;


                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable ReadDataThroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) CreateConn();

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
                return tblName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SqlDataReader ReadDataThroughReader(string query)
        {
            //DataReader used to sequentially read data from a data source

            try
            {
                if (connection.State == ConnectionState.Closed) CreateConn();

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                var reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int ExecuteQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0) CreateConn();

                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;


                return dbCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}