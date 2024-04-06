namespace finalGame
{
    partial class PlayersRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersRating));
            this.LNumberOne = new System.Windows.Forms.Label();
            this.LPlayerRating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LNumberOne
            // 
            this.LNumberOne.AutoSize = true;
            this.LNumberOne.BackColor = System.Drawing.Color.Transparent;
            this.LNumberOne.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LNumberOne.Location = new System.Drawing.Point(216, 79);
            this.LNumberOne.Name = "LNumberOne";
            this.LNumberOne.Size = new System.Drawing.Size(129, 25);
            this.LNumberOne.TabIndex = 0;
            this.LNumberOne.Text = "Number one";
            // 
            // LPlayerRating
            // 
            this.LPlayerRating.AutoSize = true;
            this.LPlayerRating.BackColor = System.Drawing.Color.Transparent;
            this.LPlayerRating.Location = new System.Drawing.Point(221, 129);
            this.LPlayerRating.Name = "LPlayerRating";
            this.LPlayerRating.Size = new System.Drawing.Size(203, 25);
            this.LPlayerRating.TabIndex = 1;
            this.LPlayerRating.Text = "OTHERS PLAYERS";
            // 
            // PlayersRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 1139);
            this.Controls.Add(this.LPlayerRating);
            this.Controls.Add(this.LNumberOne);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlayersRating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayersRating";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayersRating_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNumberOne;
        private System.Windows.Forms.Label LPlayerRating;
    }
}