namespace ClientAdv
{
    partial class Home
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
            this.QuitButton = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.AddRoom = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(101, 247);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 0;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Profile
            // 
            this.Profile.BackgroundImage = global::ClientAdv.Properties.Resources.settings_512;
            this.Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Profile.Location = new System.Drawing.Point(197, 166);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(75, 75);
            this.Profile.TabIndex = 3;
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // AddRoom
            // 
            this.AddRoom.BackgroundImage = global::ClientAdv.Properties.Resources.LineUp;
            this.AddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddRoom.Location = new System.Drawing.Point(101, 166);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(75, 75);
            this.AddRoom.TabIndex = 2;
            this.AddRoom.UseVisualStyleBackColor = true;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // Search
            // 
            this.Search.BackgroundImage = global::ClientAdv.Properties.Resources.globe;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search.Location = new System.Drawing.Point(12, 166);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 75);
            this.Search.TabIndex = 1;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.AddRoom);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.QuitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Button Profile;
    }
}