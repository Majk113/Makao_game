using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakaoGameNetLayer
{
    public partial class MakaoGameNetLayer : Form
    {
        private static MakaoConnections connectionHandle;

        public MakaoGameNetLayer()
        {
            InitializeComponent();
        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            connectionHandle = new MakaoServer(serverIpBox.Text, Int32.Parse(serverPortBox.Text), 4);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectionHandle = new MakaoClient(clientIpBox.Text, Int32.Parse(clientPortBox.Text));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            connectionHandle.SendDatagram(toSendBox.Text);
        }
    }
}
