using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Net;

namespace MakaoGameNetLayer
{
    public class MakaoServer : MakaoConnections
    {
        bool isServerListeningForConnections = false;
        bool isServerListeningForMessages = false;

        TcpListener serverHandle;
        List<TcpClient> remoteClientList = new List<TcpClient>();
        NetworkStream stream;
        IPAddress serverIp;
        //Message msg;
        BinaryFormatter formatter = new BinaryFormatter();

        byte[] message = new byte[256];

        public MakaoServer(string ip, int port, int maxClients)
        {
            serverIp = IPAddress.Parse(ip);

            if (serverHandle == null)
            {
                serverHandle = new TcpListener(serverIp, port);
                serverHandle.Start();
                Task listenForConnectionsTask = new Task(ListenForNewConnections);
                listenForConnectionsTask.Start();
            }
        }

        private void ListenForNewConnections()
        {
            isServerListeningForConnections = true;
            
            while (isServerListeningForConnections)
            {
                TcpClient tempClient = serverHandle.AcceptTcpClient();
                Console.WriteLine("Connected to:");
                Console.WriteLine(tempClient.Client.RemoteEndPoint);

                remoteClientList.Add(tempClient);

                Task.Run(() => ListenForMessages(tempClient));
            }
        }

        private void ListenForMessages(TcpClient client)
        {
            isServerListeningForMessages = true;
            byte[] messageBuffer = new byte[256];

            while (isServerListeningForMessages)
            {
                client.GetStream().Read(messageBuffer, 0, messageBuffer.Length);
                Message msg = formatter.Deserialize(client.GetStream()) as Message;

                Console.WriteLine(msg);
                //Console.WriteLine(msg.content);

                //Console.WriteLine(Encoding.ASCII.GetString(messageBuffer));
            }
        }

        public void SendDatagram(string data)
        {
            byte[] datagram = new byte[256];
            datagram = Encoding.ASCII.GetBytes(data);

            stream.Write(datagram, 0, datagram.Length);
        }


    }
}
