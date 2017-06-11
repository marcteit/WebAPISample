using System;
using System.Data;
using Domain;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class SampleDataAccess : ISampleDataAccess
    {
        private readonly ApplicationSettings _ApplicationSettings;

        public SampleDataAccess(IOptions<ApplicationSettings> applicationSettings)
        {
            _ApplicationSettings = applicationSettings.Value;
        }

        public int GetCount()
        {
            string connectionString = _ApplicationSettings.DatabaseConnection.GetConnectionString();
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            try
            {
                dbConnection.Open();
                IDbCommand dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandText = "SELECT 1";
                dbCommand.CommandType = CommandType.Text;
                return Convert.ToInt32(dbCommand.ExecuteScalar());
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
