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

namespace ClientAdv
{
    public partial class Home : Form
    {
        Form parent;
        TcpClient clientSocket;
        public Home(TcpClient clientSocket, Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.clientSocket = clientSocket;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("201$");
            NetworkStream serverStream = clientSocket.GetStream();
            serverStream.Write(outStream, 0, outStream.Length);
            clientSocket.Close();
            parent.Close();
            this.Close();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Settings s = new Settings(this.clientSocket, this);
            s.Show();
            this.Hide();
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            AddRoom ar = new AddRoom(this.clientSocket,this);
            ar.Show();
            this.Hide();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            Search s = new Search(this.clientSocket,this);
            s.Show();
            this.Hide();
        }
    }
}
