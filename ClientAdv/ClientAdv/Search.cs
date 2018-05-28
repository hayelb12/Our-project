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
    public partial class Search : Form
    {
        TcpClient clientSocket;
        Form parent;

        public Search(TcpClient clientSocket,Form parent)
        {
            InitializeComponent();
            this.clientSocket = clientSocket;
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetworkStream stream = this.clientSocket.GetStream();
            string toserver = "109" + this.SearchBox.Text.Length.ToString("00") + this.SearchBox.Text + "$";
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(toserver);
            stream.Write(outStream, 0, outStream.Length);
            stream.Flush();

            byte[] inStream = new byte[10025];

            stream.Read(inStream, 0, 3000);

            string returndata = System.Text.Encoding.ASCII.GetString(inStream);

            Request r = new Request(returndata);

            this.Rooms.DataSource = r.getValues();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            NetworkStream stream = this.clientSocket.GetStream();
            string toserver = "109" + this.SearchBox.Text.Length.ToString("00") + this.SearchBox.Text + "$";
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(toserver);
            stream.Write(outStream,0,outStream.Length);
            stream.Flush();

            byte[] inStream = new byte[10025];

            stream.Read(inStream, 0, 3000);

            string returndata = System.Text.Encoding.ASCII.GetString(inStream);

            Request r = new Request(returndata);

            this.Rooms.DataSource = r.getValues();
        }
    }
}
