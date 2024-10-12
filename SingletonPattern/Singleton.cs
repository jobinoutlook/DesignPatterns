using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private Singleton _singleton;

        private Singleton() { }

        public Singleton GetSingleton()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();   
            }
            
                return _singleton;
            
        }

    }
}
