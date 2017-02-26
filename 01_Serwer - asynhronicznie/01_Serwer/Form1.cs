using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace _01_Serwer
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private TcpClient client;
        private delegate void SetTextCallBack(string text);
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            IPAddress adresIP;
            try
            {
                adresIP = IPAddress.Parse(txtAddress.Text);
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IPv4", "Błąd");
                txtAddress.Text = String.Empty;
                return;
            }
            int port = Convert.ToInt32(nrPort.Value);
            try
            {
                server = new TcpListener(adresIP, port);
                server.Start();
                //client = server.AcceptTcpClient();
                //lbMessages.Items.Add("Nawiązano połączenie : " + client.Client.RemoteEndPoint.ToString());
                server.BeginAcceptTcpClient(new AsyncCallback(AcceptTcpClientCallBack), server);
                btStart.Enabled = false;
                btStop.Enabled = true;
                //client.Close();
                //server.Stop();
            }
            catch (Exception ex)
            {
                lbMessages.Items.Add("Błąd inicjacji serwera ! ");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
        private void AcceptTcpClientCallBack(IAsyncResult AsyncResult) {
            TcpListener s= (TcpListener)AsyncResult.AsyncState;
            client = s.EndAcceptTcpClient(AsyncResult);
            SetListBoxText("Połącznie powiodło się");
            client.Close();
            server.Stop();
        }
        private void SetListBoxText(string text) {
            if (lbMessages.InvokeRequired)
            {
                SetTextCallBack f = new SetTextCallBack(SetListBoxText);
                this.Invoke(f, new object[] { text });
            }
            else {
                lbMessages.Items.Add(text);
            }        
        }
        private void btStop_Click(object sender, EventArgs e)
        {
            client.Close();
            server.Stop();
            lbMessages.Items.Add("Zakończono pracę serwera");
            btStop.Enabled = false;
            btStart.Enabled = true;
        }
    }
}