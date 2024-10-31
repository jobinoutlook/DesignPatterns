using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SqlServerDatabaseBuilder : IDatabaseBuilder
    {
        private Database _database;

        public SqlServerDatabaseBuilder()
        {
            _database = new SqlServerDatabase();
        }

        public Database Database {  get { return _database; } }

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString;
            _database.Connection = new SqlConnection(connectionString);
        }   
        public void BuildCommand()
        {
            _database.Command = new SqlCommand();
            _database.Command.Connection = _database.Connection;
        }

        public void SetSettings()
        {
            _database.Command.CommandTimeout = 360;
            _database.Command.CommandType = CommandType.Text;
        }
    }
}
