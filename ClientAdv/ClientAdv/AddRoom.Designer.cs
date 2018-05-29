using System.Globalization;
using System;
namespace ClientAdv
{
    partial class AddRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startQueue = new System.Windows.Forms.DateTimePicker();
            this.Title = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.Until = new System.Windows.Forms.Label();
            this.EndQueue = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.EndMin = new System.Windows.Forms.ComboBox();
            this.startHour = new System.Windows.Forms.ComboBox();
            this.EndHour = new System.Windows.Forms.ComboBox();
            this.startMin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startQueue
            // 
            this.startQueue.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.startQueue.Location = new System.Drawing.Point(5, 83);
            this.startQueue.MinDate = new System.DateTime(2018, 5, 21, 18, 32, 5, 653);
            this.startQueue.Name = "startQueue";
            this.startQueue.Size = new System.Drawing.Size(320, 20);
            this.startQueue.TabIndex = 0;
            this.startQueue.Value = new System.DateTime(2018, 5, 21, 18, 32, 5, 653);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.Location = new System.Drawing.Point(96, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(141, 31);
            this.Title.TabIndex = 1;
            this.Title.Text = "Add Room";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(2, 67);
            this.From.Name = "From";
            this.From.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.From.Size = new System.Drawing.Size(27, 13);
            this.From.TabIndex = 2;
            this.From.Text = "from";
            // 
            // Until
            // 
            this.Until.AutoSize = true;
            this.Until.Location = new System.Drawing.Point(2, 150);
            this.Until.Name = "Until";
            this.Until.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Until.Size = new System.Drawing.Size(28, 13);
            this.Until.TabIndex = 4;
            this.Until.Text = "Until";
            this.Until.Visible = false;
            // 
            // EndQueue
            // 
            this.EndQueue.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.EndQueue.Location = new System.Drawing.Point(5, 166);
            this.EndQueue.MinDate = new System.DateTime(2018, 5, 21, 18, 39, 10, 316);
            this.EndQueue.Name = "EndQueue";
            this.EndQueue.Size = new System.Drawing.Size(320, 20);
            this.EndQueue.TabIndex = 3;
            this.EndQueue.Value = new System.DateTime(2018, 5, 21, 18, 39, 10, 316);
            this.EndQueue.Visible = false;
            this.EndQueue.ValueChanged += new System.EventHandler(this.EndQueue_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Timed Queue",
            "Numbered Queue"});
            this.comboBox1.Location = new System.Drawing.Point(102, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "How to Queue?";
            this.label1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 349);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numbered";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Timed (mins)";
            this.label3.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(192, 349);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(12, 396);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 27);
            this.ReturnButton.TabIndex = 11;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(250, 400);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Visible = false;
            // 
            // EndMin
            // 
            this.EndMin.FormattingEnabled = true;
            this.EndMin.Location = new System.Drawing.Point(159, 192);
            this.EndMin.Name = "EndMin";
            this.EndMin.Size = new System.Drawing.Size(51, 21);
            this.EndMin.TabIndex = 13;
            this.EndMin.Visible = false;
            this.EndMin.SelectedIndexChanged += new System.EventHandler(this.EndMin_SelectedIndexChanged);
            // 
            // startHour
            // 
            this.startHour.FormattingEnabled = true;
            this.startHour.Location = new System.Drawing.Point(102, 109);
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(51, 21);
            this.startHour.TabIndex = 14;
            this.startHour.SelectedIndexChanged += new System.EventHandler(this.startHour_SelectedIndexChanged);
            // 
            // EndHour
            // 
            this.EndHour.FormattingEnabled = true;
            this.EndHour.Location = new System.Drawing.Point(102, 192);
            this.EndHour.Name = "EndHour";
            this.EndHour.Size = new System.Drawing.Size(51, 21);
            this.EndHour.TabIndex = 15;
            this.EndHour.Visible = false;
            this.EndHour.SelectedIndexChanged += new System.EventHandler(this.EndHour_SelectedIndexChanged);
            // 
            // startMin
            // 
            this.startMin.FormattingEnabled = true;
            this.startMin.Location = new System.Drawing.Point(159, 109);
            this.startMin.Name = "startMin";
            this.startMin.Size = new System.Drawing.Size(51, 21);
            this.startMin.TabIndex = 16;
            this.startMin.SelectedIndexChanged += new System.EventHandler(this.startMin_SelectedIndexChanged);
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 435);
            this.Controls.Add(this.startMin);
            this.Controls.Add(this.EndHour);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.EndMin);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Until);
            this.Controls.Add(this.EndQueue);
            this.Controls.Add(this.From);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.startQueue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startQueue;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label Until;
        private System.Windows.Forms.DateTimePicker EndQueue;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox EndMin;
        private System.Windows.Forms.ComboBox startHour;
        private System.Windows.Forms.ComboBox EndHour;
        private System.Windows.Forms.ComboBox startMin;
    }
}