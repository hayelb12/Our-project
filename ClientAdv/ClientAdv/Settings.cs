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
    public partial class Settings : Form
    {
        TcpClient clientSocket;
        Form parent;

        public Settings(TcpClient clientSocket, Form parent)
        {
            InitializeComponent();
            
            this.clientSocket = clientSocket;
            this.parent = parent;
            LoadSettings();
        }

        private void LoadSettings()
        {
            NetworkStream serverStream = clientSocket.GetStream();
            string message = "105";
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(message + "$");

            serverStream.Write(outStream, 0, outStream.Length);

            serverStream.Flush();



            byte[] inStream = new byte[10025];

            serverStream.Read(inStream, 0, 3000);

            string returndata = System.Text.Encoding.ASCII.GetString(inStream);

            Request r = new Request(returndata);

            this.UsernameBox.Text = r.getValues()[0];
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();

        }

        private void PassChangeButton_Click(object sender, EventArgs e)
        {
            ChangePassword ch = new ChangePassword(this.clientSocket, this);
            ch.Show();
            this.Hide();
        }
    }
}
