using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Data.Common;
using System.Net;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void lb_Server_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(1308);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 1308);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + ":" +
                 returnData.ToString();
                lb_Server.Items.Add(mess);
            }
        }
        private void Server_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
            

        }
    }
}
