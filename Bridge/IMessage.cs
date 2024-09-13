using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal interface IMessage
    {
        void SendMessage(string to, string message);
    }
}
