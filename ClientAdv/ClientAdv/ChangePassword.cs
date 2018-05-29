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
    public partial class ChangePassword : Form
    {
        TcpClient clientSocket;
        Form parent;

        public ChangePassword(TcpClient clientSocket,Form parent)
        {
            InitializeComponent();
            this.clientSocket = clientSocket;
            this.parent = parent;
        }

        private void ChagePass_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Equals(textBox3.Text))
            {
                NetworkStream serverStream = clientSocket.GetStream();
                string message = "204" + textBox1.Text.Length.ToString("00") + textBox1.Text + textBox2.Text.Length.ToString("00") + textBox2.Text;
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(message + "$");

                serverStream.Write(outStream, 0, outStream.Length);

                serverStream.Flush();



                byte[] inStream = new byte[10025];

                serverStream.Read(inStream, 0, 3000);

                string returndata = System.Text.Encoding.ASCII.GetString(inStream);

                returndata = returndata.Substring(0, 4);

                if(returndata == "1010")
                {
                    Status.Text = "Password Changed successfully";
                }
                else if(returndata == "1011")
                {
                    Status.Text = "Password is wrong";

                }
                else if(returndata == "1012")
                {
                    Status.Text = "new password is illegal";
                }

            }
            else
            {
                Status.Text = "passwords Must Match";
            }

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.parent.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
