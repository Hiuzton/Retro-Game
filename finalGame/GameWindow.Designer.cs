namespace finalGame
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.spaceShip01 = new System.Windows.Forms.PictureBox();
            this.timeInoprishelts = new System.Windows.Forms.Timer(this.components);
            this.inoprishelets = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.LScore = new System.Windows.Forms.Label();
            this.LScoreValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spaceShip01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoprishelets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            this.SuspendLayout();
            // 
            // spaceShip01
            // 
            this.spaceShip01.BackColor = System.Drawing.Color.Transparent;
            this.spaceShip01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spaceShip01.Image = ((System.Drawing.Image)(resources.GetObject("spaceShip01.Image")));
            this.spaceShip01.Location = new System.Drawing.Point(1312, 277);
            this.spaceShip01.Name = "spaceShip01";
            this.spaceShip01.Size = new System.Drawing.Size(250, 250);
            this.spaceShip01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceShip01.TabIndex = 0;
            this.spaceShip01.TabStop = false;
            // 
            // inoprishelets
            // 
            this.inoprishelets.BackColor = System.Drawing.Color.Transparent;
            this.inoprishelets.Image = ((System.Drawing.Image)(resources.GetObject("inoprishelets.Image")));
            this.inoprishelets.Location = new System.Drawing.Point(24, 324);
            this.inoprishelets.Name = "inoprishelets";
            this.inoprishelets.Size = new System.Drawing.Size(160, 160);
            this.inoprishelets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inoprishelets.TabIndex = 1;
            this.inoprishelets.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = ((System.Drawing.Image)(resources.GetObject("bullet.Image")));
            this.bullet.Location = new System.Drawing.Point(1269, 388);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(90, 29);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 2;
            this.bullet.TabStop = false;
            this.bullet.Visible = false;
            // 
            // LScore
            // 
            this.LScore.AutoSize = true;
            this.LScore.BackColor = System.Drawing.Color.Transparent;
            this.LScore.Font = new System.Drawing.Font("OCR A Extended", 25.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LScore.ForeColor = System.Drawing.Color.OrangeRed;
            this.LScore.Location = new System.Drawing.Point(-2, -4);
            this.LScore.Name = "LScore";
            this.LScore.Size = new System.Drawing.Size(310, 69);
            this.LScore.TabIndex = 3;
            this.LScore.Text = "Score: ";
            // 
            // LScoreValue
            // 
            this.LScoreValue.AutoSize = true;
            this.LScoreValue.BackColor = System.Drawing.Color.Transparent;
            this.LScoreValue.Font = new System.Drawing.Font("OCR A Extended", 25.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LScoreValue.ForeColor = System.Drawing.Color.OrangeRed;
            this.LScoreValue.Location = new System.Drawing.Point(257, -4);
            this.LScoreValue.Name = "LScoreValue";
            this.LScoreValue.Size = new System.Drawing.Size(70, 69);
            this.LScoreValue.TabIndex = 4;
            this.LScoreValue.Text = "0";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.LScoreValue);
            this.Controls.Add(this.LScore);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.inoprishelets);
            this.Controls.Add(this.spaceShip01);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spaceShip01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inoprishelets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spaceShip01;
        private System.Windows.Forms.Timer timeInoprishelts;
        private System.Windows.Forms.PictureBox inoprishelets;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Label LScore;
        private System.Windows.Forms.Label LScoreValue;
    }
}