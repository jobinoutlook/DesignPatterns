using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Builder
{
    public class OleDbDatabaseBuilder : IDatabaseBuilder
    {
        private Database _database;

        public OleDbDatabaseBuilder()
        {
            _database = new OleDbDatabase();
        }

        public Database Database => throw new NotImplementedException();

        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OleDBConnectionString"].ConnectionString;
            _database.Connection = new OleDbConnection(connectionString);
        }
        public void BuildCommand()
        {
            _database.Command = new OleDbCommand();
            _database.Command.Connection = _database.Connection;
        }

        public void SetSettings()
        {
            _database.Command.CommandTimeout = 360;
            _database.Command.CommandType = CommandType.Text;
        }
    }
}
