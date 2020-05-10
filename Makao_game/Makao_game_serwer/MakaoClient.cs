using System.Net.Sockets;

namespace MakaoGameNetLayer
{
    class MakaoClient
    {
        public TcpClient client;
        public string Name { get; set; }

        public MakaoClient()
        {

        }

        public MakaoClient(TcpClient client)
        {
            this.client = client;
        }
    }
}
