using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class OleDBDatabase : IDatabase
    {
        private IDbConnection _Connection = null;
        private IDbCommand _Command = null;
        public  IDbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OleDBConnectionString"].ConnectionString;
                    _Connection = new OleDbConnection(connectionString);

                }
                return _Connection;
            }

            set => _Connection = value;
        }
        public  IDbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new OleDbCommand();
                    _Command.Connection = (OleDbConnection)Connection;
                }
                return _Command;
            }
            set => _Command = value;
        }
    }
}
