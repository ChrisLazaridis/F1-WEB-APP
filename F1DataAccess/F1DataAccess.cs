using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
namespace F1DataAccess
{
    public class F1DataAccess
    {
        private readonly F1DataAccessConfiguration _configuration;

        public F1DataAccess(F1DataAccessConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void YourDatabaseMethod()
        {
            string connectionString = _configuration.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                //TODO: Do stuff with the db 

                connection.Close();
            }
        }
    }
}
