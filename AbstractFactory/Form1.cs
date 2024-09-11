using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDB_Click(object sender, EventArgs e)
        {
            Database database;

            if (radSQL.Checked)
            {
                database = new SqlServerDatabase();
            }
            else if(radOle.Checked) 
            {
                database = new OleDBDatabase();
            }
            else 
            {
                database = new OracleDatabase();
            }
                

            DbCommand command = database.Command;
            //command.CommandType = CommandType.Text;
            //command.CommandText = "Select * from Customers";
            //command.Connection.Open();
            //DbDataReader reader = command.ExecuteReader();

            //reader.Close();
            //command.Connection.Close();
        }
    }
}
