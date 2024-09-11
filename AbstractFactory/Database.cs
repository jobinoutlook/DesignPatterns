using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Database
    {
        public abstract DbConnection Connection { get; set; }

        public abstract DbCommand Command { get; set; }
    }
}
