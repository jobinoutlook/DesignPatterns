using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDB_Click(object sender, EventArgs e)
        {
            IDatabase database;

            DatabaseType databaseType = DatabaseType.SqlServer;

            if (radOle.Checked)
            {
                databaseType = DatabaseType.OleDb;
            }

            database = DatabaseFactory.CreateDatabase(databaseType);

            IDbCommand command = database.Command;
            //command.CommandType = CommandType.Text;
            //command.CommandText = "Select * from Customers";
            //command.Connection.Open();
            //IDataReader reader = command.ExecuteReader();

            //reader.Close();
            //command.Connection.Close();
        }
    }
}
