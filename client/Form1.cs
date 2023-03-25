using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void btSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient(11000);
            try
            {
                udpClient.Connect(IP.Text, 11000);

                Byte[] sendBytes = Encoding.ASCII.GetBytes(Mess.Text);

                udpClient.Send(sendBytes, sendBytes.Length);

                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                udpClient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
