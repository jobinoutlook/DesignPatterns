﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDB_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            IDatabaseBuilder builder;

            if (radSQL.Checked)
            {
                builder = new SqlServerDatabaseBuilder();
            }
            else
            {
                builder = new OleDbDatabaseBuilder();
            }
            
            director.Build(builder);

            Database database = builder.Database;
            DbCommand command = database.Command;

            //use command for execute db commands
        }
    }
}
