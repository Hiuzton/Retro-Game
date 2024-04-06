using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalGame
{
    public partial class Menu : Form
    {
        private User user;
        private SoundPlayer background_Sound;
        private string currentImagePath = "game source\\speaker.png";


        public Menu()
        {
            InitializeComponent();
            user = User.Instance;
            setPixelFont();
            CenterLinkLabel();
            user.isLogIn = true;
            Properties.Settings.Default.IsUserLoggedIn = user.isLogIn;
            Properties.Settings.Default.Save();

            background_Sound = new SoundPlayer("game source\\sounds\\menu_sound.wav");
            background_Sound.PlayLooping();
        }

        private void setPixelFont()
        {
            Color violetColor = Color.FromArgb(162, 86, 248);
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("ARCADECLASSIC.TTF");
            Font pixelFont = new Font(privateFonts.Families[0], 110, FontStyle.Regular);
            Font pixelFontElements = new Font(privateFonts.Families[0], 55, FontStyle.Regular);
            LLStartGame.Font = pixelFont; 
            LLLogOut.Font = pixelFontElements;
            LLRatings.Font = pixelFontElements;
            LLRatings.LinkColor = violetColor;
            LLLogOut.LinkColor = violetColor;
            LLStartGame.LinkColor = violetColor;

        }
        private void CenterLinkLabel()
        {
            int spacing = 10;
            int totalHeight = LLStartGame.Height + spacing + LLRatings.Height + spacing + LLLogOut.Height;

            int startY = (this.ClientSize.Height - totalHeight) / 2;

            LLStartGame.Location = new Point(
                (this.ClientSize.Width - LLStartGame.Width) / 2,
                startY
            );

            LLRatings.Location = new Point(
                (this.ClientSize.Width - LLRatings.Width) / 2,
                LLStartGame.Bottom + spacing
            );

            LLLogOut.Location = new Point(
                (this.ClientSize.Width - LLLogOut.Width) / 2,
                LLRatings.Bottom + spacing
            );
        }

        private void GameMenu_Resize(object sender, EventArgs e)
        {
            CenterLinkLabel();
        }

        private void LLStartGame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form newgame = new GameWindow();
            newgame.Show();
            this.Hide();

        }

        private void LLLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Game game = new Game();
            game.Show();
            user.isLogIn = false;
            Properties.Settings.Default.IsUserLoggedIn = user.isLogIn;
            Properties.Settings.Default.Save();
            background_Sound.Stop();
            this.Hide();
        }
        private bool closingInProgress = false;

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            background_Sound.Stop();
            if (!closingInProgress)
            {
                closingInProgress = true;

                List<Form> openFormsCopy = new List<Form>(Application.OpenForms.Cast<Form>());
                foreach (Form form in openFormsCopy)
                {
                    form.Close();
                }
                Application.Exit();
            }
        }

        private void LLRatings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlayersRating playersRating = new PlayersRating();
            playersRating.Show();
            this.Hide();
        }

        private void soundPicBox_Click(object sender, EventArgs e)
        { 
            string speakerImagePath = "game source\\speaker.png";
            string muteImagePath = "game source\\mute.png";

            if (currentImagePath == speakerImagePath)
            {
                soundPicBox.ImageLocation = muteImagePath;
                background_Sound.Stop();
                currentImagePath = muteImagePath;
            }
            else if (currentImagePath == muteImagePath)
            {
                soundPicBox.ImageLocation = speakerImagePath;
                background_Sound.PlayLooping();
                currentImagePath = speakerImagePath;
            }
        }
    }
}
