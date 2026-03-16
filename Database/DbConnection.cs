using MySql.Data.MySqlClient;

namespace WarehouseManagementSystem.Database
{
    public class DbConnection
    {
        private readonly string connectionString =
            "server=localhost;database=WarehouseManagementSystem;uid=root;pwd=root1234;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}