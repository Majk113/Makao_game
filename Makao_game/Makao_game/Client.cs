using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Makao_game
{
    class Client
    {
        public Client()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

            Socket sender = new Socket(ipAddr.AddressFamily,
                       SocketType.Stream, ProtocolType.Tcp);


            sender.Connect(localEndPoint);
        }
    }
}
