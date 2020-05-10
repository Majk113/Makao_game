using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace MakaoGameNetLayer
{
    public class MakaoServer
    {
        bool isServerListeningForConnections = false;
        bool isServerListeningForMessages = false;
        bool isServerCreatedInActiveSession = false;

        TcpListener serverHandle;
        List<MakaoClient> remoteClientList = new List<MakaoClient>();
        NetworkStream stream;
        IPAddress serverIp;
        BinaryFormatter formatter = new BinaryFormatter();

        public MakaoServer(string ip, int port, int maxClients)
        {
            try
            {
                serverIp = IPAddress.Parse(ip);
                serverHandle = new TcpListener(serverIp, port);
                serverHandle.Start();
                Task listenForConnectionsTask = new Task(ListenForNewConnections);
                listenForConnectionsTask.Start();
            }
            catch (SocketException)
            {
                MessageBox.Show("Server is already running!");
            }
        }

        private void ListenForNewConnections()
        {
            isServerListeningForConnections = true;
            
            while (isServerListeningForConnections)
            {
                MakaoClient tempClient = new MakaoClient(serverHandle.AcceptTcpClient());
                Console.WriteLine("Connected with:");
                Console.WriteLine(tempClient.client.Client.RemoteEndPoint);

                remoteClientList.Add(tempClient);
                Task.Run(() => ListenForMessages(remoteClientList[remoteClientList.Count-1]));
            }
        }

        private void ListenForMessages(MakaoClient client)
        {
            isServerListeningForMessages = true;
            byte[] messageBuffer = new byte[256];

            while (isServerListeningForMessages)
            {
                Message msg = formatter.Deserialize(client.client.GetStream()) as Message;
                switch (msg.type)
                {
                    case Message.MessageType.SET_PLAYER_NAME:
                        client.Name = msg.name;
                        break;
                        
                    case Message.MessageType.CHAT_MESSAGE:
                        Console.WriteLine("dupa");

                        foreach (var cl in remoteClientList)
                        {
                            SendMessage(cl.client.GetStream(), msg);
                        }

                        break;

                    default:
                        Console.WriteLine("Unknown message recieved");
                        break;
                }

            }
        }

        private void SendMessage(NetworkStream stream, Message msg)
        {
            Console.WriteLine("dupa2");
            formatter.Serialize(stream, msg);
        }
    }
}
