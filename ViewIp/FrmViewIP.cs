using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace ViewIp
{
    public partial class FrmViewIP : Form
    {
        public FrmViewIP()
        {
            InitializeComponent();
        }

        private void FrmViewIP_Load(object sender, EventArgs e)
        {
            viewIp();
        }

        private void viewIp()
        {
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            TxtIpActual.Text = localIP;
        }

        private void BtnFindIP_Click(object sender, EventArgs e)
        {
            string subnet = "172.16.40";

            Task.Factory.StartNew(new Action(() =>
            {
                for (int i = 2; i < 255; i++)
                {
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip, 100);
                    if (reply.Status == IPStatus.Success)
                    {
                        try
                        {
                            IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                            LvIPRespuesta.Items.Add(ip.ToString());
                        }
                        catch
                        {
                            MessageBox.Show($"Couldn't retrieve hostname from {ip}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        LvIPRespuesta.Items.Add(ip.ToString());

                    }
                }
            }));
        }
    }
}
