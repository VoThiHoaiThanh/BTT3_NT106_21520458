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

        private void Server_Load(object sender, EventArgs e)
        {
           
            Thread  th= new Thread(new ThreadStart(server1));
            th.Start();
        }
        public void server1()
        {
            UdpClient udpClient = new UdpClient(11000);

            
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                this.Invoke((MethodInvoker)delegate {
                    lb_Server.Items.Add(RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString());
                });
            }
        }
    }
}
