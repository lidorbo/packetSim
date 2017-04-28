using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace packetSimulatorClient
{
    public partial class Main : Form
    {
        private IPAddress serverIP = null;
        private const int PORT = 8090;
        private TcpListener server;
        private int clientCount = 0;
        private string port = null;
        private bool isServerRuning = false;
        private const int BUFFER_SIZE = 256;
        private const int LISTEN_INTERVAL = 50;
        private TcpClient client = null;
        const string CLOSE = "CLOSE";
        private List<TcpClient> clientList = new List<TcpClient>();

        public Main()
        {
            InitializeComponent();
            serverIP = GetServerIP();
            logListBox.Text = ("IP: " + serverIP.ToString() + " PORT " + PORT + Environment.NewLine);
        }

        private IPAddress GetServerIP()
        {
            IPAddress[] ipAddress = Dns.GetHostAddresses("");
            IPAddress currentIP = null;
            foreach (var item in ipAddress)
            {
                if (!IPAddress.IsLoopback(item) && item.AddressFamily == AddressFamily.InterNetwork)
                {
                    currentIP = item;
                    break;
                }
            }
            return currentIP;
        }
        private void StartListen()
        {
            while (isServerRuning)
            {
                try
                {
                    client = server.AcceptTcpClient();
                    clientList.Add(client);
                    logListBox.Text += "Clients:" + clientList.Count + Environment.NewLine;
                     logListBox.Text += "New Client!" + Environment.NewLine;
                    Thread t = new Thread(() => DoWork(client));
                    t.IsBackground = true;
                    t.Start();
                }

                catch (SocketException ex)
                {
                    if (int.Parse(ex.ErrorCode.ToString()) != 10004) //Ignore from specific blocking exception
                    {
                        MessageBox.Show(ex.ErrorCode.ToString(), "Error");
                    }
                }
                Thread.Sleep(LISTEN_INTERVAL);
            }
            server.Server.Close();
        }

        private void DoWork(TcpClient client)
        {
            Byte[] bytes = new Byte[BUFFER_SIZE];
            NetworkStream stream = client.GetStream();
            int i;
            string data;
            string allData ="";
            string response;
            try
            {
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    allData += data;
                    response = "OK";                 
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(response);
                    stream.Write(msg, 0, msg.Length);
                }

            }
            catch (Exception)
            {
                client.Close();
            }
            client.Close();
            foreach (var c in clientList)
            {
                if (!c.Connected)
                {
                    clientList.Remove(c);
                    break;
                }
            }
            logListBox.Text += "Clients:" + clientList.Count;

        }

        private void StartServer()
        {
            Thread listen = null;
            server = new TcpListener(serverIP, PORT);
            server.Start();
            logListBox.Text += "***Server Strart!***" + Environment.NewLine;
            isServerRuning = true;
            startBtn.Text = "Stop Listening";
            listen = new Thread(new ThreadStart(StartListen));
            listen.IsBackground = true;
            listen.Start();

        }

        private void StopServer()
        {
            startBtn.Text += "Start Listening";
            isServerRuning = false;
            foreach (var c in clientList)
            {
                c.Close();
            }
             logListBox.Text += ("Server Stop!");

            try
            {
                server.Stop();
            }
            catch
            {

            }


        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isServerRuning)
                {
                    StartServer();
                }
                else
                {
                    StopServer();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}
