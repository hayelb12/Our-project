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

        private void checkToVisible1()
        {
            bool calender, hour, min;
            calender = this.startQueue.Value != null;
            hour = this.startHour.SelectedItem != null;
            min = this.startMin.SelectedItem != null;

            if(calender && hour && min)
            {
                this.EndQueue.Visible = true;
                this.EndHour.Visible = true;
                this.EndMin.Visible = true;
                this.Until.Visible = true;
                this.startQueue.Enabled = false;
                this.startHour.Enabled = false;
                this.startMin.Enabled = false;
            }
        }

        private void checkToVisible2()
        {
            bool calender, hour, min;
            calender = this.EndQueue.Value != null;
            hour = this.EndHour.SelectedItem != null;
            min = this.EndMin.SelectedItem != null;

            if (calender && hour && min)
            {
                this.label1.Visible = true;
                this.comboBox1.Visible = true;
                this.EndQueue.Enabled = false;
                this.EndHour.Enabled = false;
                this.EndMin.Enabled = false;
            }
        }


        private void startHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkToVisible1();
            this.startQueue.Value.AddHours(double.Parse(startHour.SelectedItem.ToString()));
        }

        private void startMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkToVisible1();
            this.startQueue.Value.AddMinutes(double.Parse(startMin.SelectedItem.ToString()));
        }

        private void EndHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkToVisible2();
        }

        private void EndMin_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkToVisible2();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CreateButton.Visible = true;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CreateButton.Visible = true;
        }

        private void startQueue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
