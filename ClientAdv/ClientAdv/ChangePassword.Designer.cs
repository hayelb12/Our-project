namespace ClientAdv
{
    partial class ChangePassword
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
            this.OldPass = new System.Windows.Forms.Label();
            this.NewPass = new System.Windows.Forms.Label();
            this.NewPassConfirm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ChagePass = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OldPass
            // 
            this.OldPass.AutoSize = true;
            this.OldPass.Location = new System.Drawing.Point(12, 31);
            this.OldPass.Name = "OldPass";
            this.OldPass.Size = new System.Drawing.Size(72, 13);
            this.OldPass.TabIndex = 0;
            this.OldPass.Text = "Old Password";
            // 
            // NewPass
            // 
            this.NewPass.AutoSize = true;
            this.NewPass.Location = new System.Drawing.Point(12, 115);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(78, 13);
            this.NewPass.TabIndex = 1;
            this.NewPass.Text = "New Password";
            // 
            // NewPassConfirm
            // 
            this.NewPassConfirm.AutoSize = true;
            this.NewPassConfirm.Location = new System.Drawing.Point(12, 196);
            this.NewPassConfirm.Name = "NewPassConfirm";
            this.NewPassConfirm.Size = new System.Drawing.Size(91, 13);
            this.NewPassConfirm.TabIndex = 2;
            this.NewPassConfirm.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 20);
            this.textBox3.TabIndex = 5;
            // 
            // ChagePass
            // 
            this.ChagePass.Location = new System.Drawing.Point(171, 287);
            this.ChagePass.Name = "ChagePass";
            this.ChagePass.Size = new System.Drawing.Size(84, 31);
            this.ChagePass.TabIndex = 6;
            this.ChagePass.Text = "Change";
            this.ChagePass.UseVisualStyleBackColor = true;
            this.ChagePass.Click += new System.EventHandler(this.ChagePass_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(15, 291);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 7;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(110, 249);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 13);
            this.Status.TabIndex = 8;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 335);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.ChagePass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NewPassConfirm);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.OldPass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPass;
        private System.Windows.Forms.Label NewPass;
        private System.Windows.Forms.Label NewPassConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ChagePass;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label Status;
    }
}