using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace MakaoGameNetLayer
{
    class MakaoClient : MakaoConnections
    {
        TcpClient makaoClient;
        IPAddress clientIp;
        NetworkStream stream;
        BinaryFormatter formater = new BinaryFormatter();


        public MakaoClient(string ip, int port)
        {
            clientIp = IPAddress.Parse(ip);

            if (makaoClient == null)
            {
                makaoClient = new TcpClient();
                makaoClient.Connect(clientIp, port);
                stream = makaoClient.GetStream();
            }
        }

        public void SendDatagram(string data)
        {
            byte[] datagram = new byte[256];
            datagram = Encoding.ASCII.GetBytes(data);

            formater.Serialize(stream, new Message(Message.MessageType.CHAT_MESSAGE, "asd"));
            //stream.Write(datagram, 0, datagram.Length);
        }
    }
}
