using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakaoGameNetLayer
{
    interface MakaoConnections
    {
        void SendDatagram(string data);
    }
}
