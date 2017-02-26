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

namespace _01_Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            string host = txtAddress.Text;
            int port = Convert.ToInt32(nrPort.Value);
            try
            {
                TcpClient client = new TcpClient(host, port);
                lbMessages.Items.Add("Nawiązano połączenie : " + host + ":" + port);
                client.Close();
            }
            catch (Exception ex)
            {
                lbMessages.Items.Add("Błąd: Nie udało się nawiązać połączenia !");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
