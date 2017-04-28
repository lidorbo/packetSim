using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace packetSimulator
{
    public partial class Form1 : Form
    {
        byte[] streamData = new byte[1024];
        byte[] resp = new byte[1024];

        TcpClient tcpClient;
        NetworkStream networkStream;


        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(ipText.Text, int.Parse(portText.Text));
            networkStream = tcpClient.GetStream();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            NewPacket();
        }

        private void NewPacket()
        {
            if (packetLen.Text.Length > 0)
            {
                packetTxt.Text = "";
                int len = int.Parse(packetLen.Text);
                Random rnd = new Random(Guid.NewGuid().GetHashCode());

                for (int i = 0; i < len; i++)
                {
                    packetTxt.Text += rnd.Next(-1000, 1000) + " ";
                }


            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string data = "";
            for (int i = 0; i < (int)numOfMsg.Value; i++)
            {
                SendData();
                NewPacket();
                data += packetTxt.Text.Replace(" ", string.Empty) + Environment.NewLine;
            }
            File.WriteAllText("packet.txt", data);
        }

        private void SendData()
        {
            streamData = Encoding.UTF8.GetBytes(packetTxt.Text.Replace(" ", string.Empty));
            networkStream.Write(streamData, 0, streamData.Length);
           

            networkStream.Read(resp, 0, resp.Length);
            string response = Encoding.ASCII.GetString(resp).ToUpper();
            MessageBox.Show(response);
        }
    }
}
