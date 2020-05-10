using System;
using System.Windows.Forms;

namespace MakaoGameNetLayer
{
    public partial class MakaoGameNetLayer : Form
    {
        private RemoteMakaoClient client;
        private MakaoServer server;

        private bool isClientCreated = false;

        public MakaoGameNetLayer()
        {
            InitializeComponent();
        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            server = new MakaoServer(serverIpBox.Text, Int32.Parse(serverPortBox.Text), 4);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isClientCreated)
            {
                client = new RemoteMakaoClient(clientIpBox.Text, Int32.Parse(clientPortBox.Text));
                isClientCreated = true;
                client.SetName(clientNameBox.Text);
                client.onChatMessage += PrintChatMessage;
                client.Name = clientNameBox.Text;
            }
            else
            {
                MessageBox.Show("Already connected!");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            client.SendDatagram(toSendBox.Text);
        }

        private void PrintChatMessage(string name, string message)
        {
            Console.WriteLine("In print chat method!");
            Console.WriteLine(name);
            Console.WriteLine(message);
            chatTextbox.AppendText(name + ": " + message + "\n");
            chatTextbox.Focus();
        }
    }
}
