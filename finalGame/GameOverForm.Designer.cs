namespace finalGame
{
    partial class GameOverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            this.LGameOver = new System.Windows.Forms.Label();
            this.LYourScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LGameOver
            // 
            this.LGameOver.AutoSize = true;
            this.LGameOver.BackColor = System.Drawing.Color.Transparent;
            this.LGameOver.Location = new System.Drawing.Point(388, 165);
            this.LGameOver.Name = "LGameOver";
            this.LGameOver.Size = new System.Drawing.Size(139, 25);
            this.LGameOver.TabIndex = 0;
            this.LGameOver.Text = "GAME OVER";
            // 
            // LYourScore
            // 
            this.LYourScore.AutoSize = true;
            this.LYourScore.BackColor = System.Drawing.Color.Transparent;
            this.LYourScore.Location = new System.Drawing.Point(393, 228);
            this.LYourScore.Name = "LYourScore";
            this.LYourScore.Size = new System.Drawing.Size(120, 25);
            this.LYourScore.TabIndex = 1;
            this.LYourScore.Text = "Your Score";
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 728);
            this.Controls.Add(this.LYourScore);
            this.Controls.Add(this.LGameOver);
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverForm";
            this.Resize += new System.EventHandler(this.GameOverForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LGameOver;
        private System.Windows.Forms.Label LYourScore;
    }
}