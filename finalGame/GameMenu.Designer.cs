namespace finalGame
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.LLStartGame = new System.Windows.Forms.LinkLabel();
            this.LLRatings = new System.Windows.Forms.LinkLabel();
            this.LLLogOut = new System.Windows.Forms.LinkLabel();
            this.soundPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soundPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LLStartGame
            // 
            this.LLStartGame.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.LLStartGame.AutoSize = true;
            this.LLStartGame.BackColor = System.Drawing.Color.Transparent;
            this.LLStartGame.Font = new System.Drawing.Font("Mistral", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLStartGame.LinkColor = System.Drawing.Color.BlueViolet;
            this.LLStartGame.Location = new System.Drawing.Point(254, 140);
            this.LLStartGame.Name = "LLStartGame";
            this.LLStartGame.Size = new System.Drawing.Size(540, 143);
            this.LLStartGame.TabIndex = 0;
            this.LLStartGame.TabStop = true;
            this.LLStartGame.Text = "START GAME";
            this.LLStartGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLStartGame_LinkClicked);
            // 
            // LLRatings
            // 
            this.LLRatings.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.LLRatings.AutoSize = true;
            this.LLRatings.BackColor = System.Drawing.Color.Transparent;
            this.LLRatings.Font = new System.Drawing.Font("Mistral", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLRatings.LinkColor = System.Drawing.Color.BlueViolet;
            this.LLRatings.Location = new System.Drawing.Point(464, 357);
            this.LLRatings.Name = "LLRatings";
            this.LLRatings.Size = new System.Drawing.Size(225, 83);
            this.LLRatings.TabIndex = 1;
            this.LLRatings.TabStop = true;
            this.LLRatings.Text = "RATINGS";
            this.LLRatings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLRatings_LinkClicked);
            // 
            // LLLogOut
            // 
            this.LLLogOut.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.LLLogOut.AutoSize = true;
            this.LLLogOut.BackColor = System.Drawing.Color.Transparent;
            this.LLLogOut.Font = new System.Drawing.Font("Mistral", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLLogOut.LinkColor = System.Drawing.Color.BlueViolet;
            this.LLLogOut.Location = new System.Drawing.Point(464, 490);
            this.LLLogOut.Name = "LLLogOut";
            this.LLLogOut.Size = new System.Drawing.Size(236, 83);
            this.LLLogOut.TabIndex = 2;
            this.LLLogOut.TabStop = true;
            this.LLLogOut.Text = "LOG OUT";
            this.LLLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLLogOut_LinkClicked);
            // 
            // soundPicBox
            // 
            this.soundPicBox.BackColor = System.Drawing.Color.Transparent;
            this.soundPicBox.Image = ((System.Drawing.Image)(resources.GetObject("soundPicBox.Image")));
            this.soundPicBox.Location = new System.Drawing.Point(1243, 12);
            this.soundPicBox.Name = "soundPicBox";
            this.soundPicBox.Size = new System.Drawing.Size(56, 55);
            this.soundPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundPicBox.TabIndex = 3;
            this.soundPicBox.TabStop = false;
            this.soundPicBox.Click += new System.EventHandler(this.soundPicBox_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1311, 719);
            this.Controls.Add(this.soundPicBox);
            this.Controls.Add(this.LLLogOut);
            this.Controls.Add(this.LLRatings);
            this.Controls.Add(this.LLStartGame);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Resize += new System.EventHandler(this.GameMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.soundPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LLStartGame;
        private System.Windows.Forms.LinkLabel LLRatings;
        private System.Windows.Forms.LinkLabel LLLogOut;
        private System.Windows.Forms.PictureBox soundPicBox;
    }
}