﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case FactoryMethod.DatabaseType.OleDb:
                    return new OleDBDatabase();
                   
                case FactoryMethod.DatabaseType.SqlServer:
                default:
                    return new SqlServerDatabase();
                    

            }
        }
    }
}
