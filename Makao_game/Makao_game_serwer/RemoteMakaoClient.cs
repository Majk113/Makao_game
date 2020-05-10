using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MakaoGameNetLayer
{
    class RemoteMakaoClient
    {
        public delegate void OnMessageReceived(string name, string message);

        bool isClientCreatedInThisSession = false;
        bool isServerListeningForMessages = false;

        public string Name { get; set; }

        TcpClient makaoClient;
        IPAddress clientIp;
        NetworkStream stream;
        BinaryFormatter formatter = new BinaryFormatter();
        public OnMessageReceived onChatMessage;


        public RemoteMakaoClient(string ip, int port)
        {
            clientIp = IPAddress.Parse(ip);

            try
            {
                makaoClient = new TcpClient();
                makaoClient.Connect(clientIp, port);
                stream = makaoClient.GetStream();
                isClientCreatedInThisSession = true;
                Task.Run(() => ListenForMessages());
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Wrong format of IP/port!");
            }

            catch (SocketException)
            {
                MessageBox.Show("There is no server to connect with this IP/port!");
            }

        }

        private void ListenForMessages()
        {
            isServerListeningForMessages = true;
            byte[] messageBuffer = new byte[256];

            while (isServerListeningForMessages)
            {
                Message msg = formatter.Deserialize(stream) as Message;
                switch (msg.type)
                {
                    case Message.MessageType.CHAT_MESSAGE:
                        onChatMessage(msg.name, msg.msg);
                        Console.WriteLine("Right message interpretation");
                        break;

                    default:
                        Console.WriteLine("Unknown message recieved");
                        break;
                }

            }
        }

        public void SendDatagram(string message)
        {
            Message msg = new Message(Message.MessageType.CHAT_MESSAGE, message);
            SendDatagram(msg);
        }

        private void SendDatagram(Message msg)
        {
            formatter.Serialize(stream, msg);
        }

        public void SetName(string name)
        {
            Message msg = new Message(Message.MessageType.SET_PLAYER_NAME, name);
            SendDatagram(msg);
        }
    }
}
