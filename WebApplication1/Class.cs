using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public class Connect
    {
        public MySqlConnection Connection;
        private string _host;
        private string _database;
        private string _username;
        private string _password;

        public Connect()
        {
            _host = "localhost";
            _database = "testdb";
            _username = "root";
            _password = "";

            string connectionString = $"Server={_host};Database={_database};Uid={_username};Pwd={_password};";

           Connection = new MySqlConnection(connectionString);
        }
    }
}









