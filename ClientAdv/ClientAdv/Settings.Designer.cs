namespace ClientAdv
{
    partial class Settings
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.PassChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Goudy Stout", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(70, 54);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(139, 15);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Your Name";
            // 
            // UsernameBox
            // 
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UsernameBox.Location = new System.Drawing.Point(12, 72);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.ReadOnly = true;
            this.UsernameBox.Size = new System.Drawing.Size(253, 13);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(12, 271);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // PassChangeButton
            // 
            this.PassChangeButton.Location = new System.Drawing.Point(171, 271);
            this.PassChangeButton.Name = "PassChangeButton";
            this.PassChangeButton.Size = new System.Drawing.Size(101, 23);
            this.PassChangeButton.TabIndex = 3;
            this.PassChangeButton.Text = "ChangePassword";
            this.PassChangeButton.UseVisualStyleBackColor = true;
            this.PassChangeButton.Click += new System.EventHandler(this.PassChangeButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.PassChangeButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button PassChangeButton;
    }
}