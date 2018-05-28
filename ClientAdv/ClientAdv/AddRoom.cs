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
    public partial class AddRoom : Form
    {
		
		

        private TcpClient clientSocket;
        private Form parent;
        public AddRoom(TcpClient clientSocket,Form parent)
        {
            InitializeComponent();
            LoadBoxes();
            this.clientSocket = clientSocket;
            this.parent = parent;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Timed Queue")
            {
                label3.Visible = true;
                comboBox3.Visible = true;

                label2.Visible = false;
                comboBox2.Visible = false;
            }
            else
            {
                label2.Visible = true;
                comboBox2.Visible = true;

                label3.Visible = false;
                comboBox3.Visible = false;

            }
        }

        private void LoadBoxes()
        {
            for (int i = 0; i < 100; i++)
            {
                comboBox2.Items.Add((i + 1).ToString());
                comboBox3.Items.Add((i + 1).ToString());
                if (i <= 24 && i >= 0)
                {
                    EndHour.Items.Add(i.ToString("00"));
                    startHour.Items.Add(i.ToString("00"));
                }
                if (i >= 0 && i <= 59)
                {
                    EndMin.Items.Add(i.ToString("00"));
                    startMin.Items.Add(i.ToString("00"));

                }
            }
            EndQueue.Visible = false;
            EndHour.Visible = false;
            EndMin.Visible = false;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void EndQueue_ValueChanged(object sender, EventArgs e)
        {
            if(EndQueue.Value < startQueue.Value)
            {
                MessageBox.Show("invalid time!");
                EndQueue.Value = startQueue.Value;
            }
        }

        private void checkToVisible()
        {
            bool calender, hour, min;
            calender = this.startQueue.Value != null;
            hour = this.startHour.SelectedValue != null;

            min = this.startMin.SelectedValue != null;

            if(calender && hour && min)
            {
                this.EndQueue.Visible = Visible;
                this.EndHour.Visible = Visible;
                this.EndMin.Visible = Visible;
            }
        }

        private void startHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkToVisible();
        }

        private void startMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkToVisible();
        }
    }
}
