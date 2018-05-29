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
    public partial class Form1 : Form
    {

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        public Form1()
        {
            InitializeComponent();

            clientSocket.Connect("127.0.0.1", 8220);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NetworkStream serverStream = clientSocket.GetStream();

            string message = "200" + textBox1.Text.Length.ToString("00") + textBox1.Text + textBox2.Text.Length.ToString("00") + textBox2.Text;
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(message + "$");

            serverStream.Write(outStream, 0, outStream.Length);

            serverStream.Flush();



            byte[] inStream = new byte[10025];

            serverStream.Read(inStream, 0, 3000);

            string returndata = System.Text.Encoding.ASCII.GetString(inStream);

            if (returndata.Substring(0,4) == "1020")
            {
                Home h = new Home(clientSocket,this);
                h.Show();
                this.Hide();
            }
            else if (returndata.Substring(0, 4) == "1021")
            {
                label4.Text = "password incorrect";
            }
            else if (returndata.Substring(0, 4) == "1022")
            {
                label4.Text = "user connected!";

            }
            else if (returndata.Substring(0, 4) == "1023")
            {
                label4.Text = "user does not exist";

            }


            textBox2.Text = "";

            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp(this.clientSocket,this);
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("201$");
            NetworkStream serverStream = clientSocket.GetStream();
            serverStream.Write(outStream, 0, outStream.Length);
            clientSocket.Close();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
