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
    public partial class SignUp : Form
    {
        Form1 Parent;
        System.Net.Sockets.TcpClient clientSocket;
        public SignUp(System.Net.Sockets.TcpClient clientSocket,Form1 parent)
        {
            this.clientSocket = clientSocket;
            this.Parent = parent;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();

            if(textBox1.Text.Length != 0 && textBox2.Text.Length!=0)
            {
                string message = "203" + textBox1.Text.Length.ToString("00") + textBox1.Text + textBox2.Text.Length.ToString("00") + textBox2.Text;
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(message + "$");

                serverStream.Write(outStream, 0, outStream.Length);

                serverStream.Flush();



                byte[] inStream = new byte[10025];

                serverStream.Read(inStream, 0, 3000);

                string returndata = System.Text.Encoding.ASCII.GetString(inStream);

                if (returndata.Substring(0, 4) == "1040")
                {
                    Home h = new Home(clientSocket,this);
                    h.Show();
                    this.Hide();
                }
                else if (returndata.Substring(0, 4) == "1041")
                {
                    label4.Text = "password illegal";
                }
                else if (returndata.Substring(0, 4) == "1042")
                {
                    label4.Text = "user taken";

                }
                else if (returndata.Substring(0, 4) == "1043")
                {
                    label4.Text = "user illegal";

                }




                textBox2.Focus();
            }
            else
            {
                MessageBox.Show("Password and Username Both REquired");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("201$");
            NetworkStream serverStream = clientSocket.GetStream();
            serverStream.Write(outStream, 0, outStream.Length);
            this.clientSocket.Close();
            Parent.Close();
            this.Close();
        }
    }
}
