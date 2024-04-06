using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalGame
{
    public partial class GameOverForm : Form
    {
        public GameOverForm(string message)
        {
            InitializeComponent();
            setPixelFont();
            CenterLinkLabel();
            LYourScore.Text = message;
        }

        private void setPixelFont()
        {
            Color violetColor = Color.FromArgb(255, 255, 51);
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("ARCADECLASSIC.TTF");
            Font pixelFont = new Font(privateFonts.Families[0], 80, FontStyle.Regular);
            Font pixelFontElements = new Font(privateFonts.Families[0], 35, FontStyle.Regular);
            LGameOver.Font = pixelFont;
            LYourScore.Font = pixelFontElements;
            LGameOver.ForeColor = violetColor;
            LYourScore.ForeColor = violetColor;

        }
        private void CenterLinkLabel()
        {
            int spacing = 10;
            int totalHeight = LGameOver.Height + spacing + LYourScore.Height ;

            int startY = (this.ClientSize.Height - totalHeight) / 2;

            LGameOver.Location = new Point(
                (this.ClientSize.Width - LGameOver.Width) / 2,
                startY
            );

            LYourScore.Location = new Point(
                (this.ClientSize.Width - LYourScore.Width) / 2,
                LGameOver.Bottom + spacing
            );
        }

        private void GameOverForm_Resize(object sender, EventArgs e)
        {
            CenterLinkLabel();
        }
    }
}
