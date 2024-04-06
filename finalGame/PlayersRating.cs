using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace finalGame
{
    public partial class PlayersRating : Form
    {
        private DBConnection conn;
        private User user;
        public PlayersRating()
        {
            InitializeComponent();
            conn =new DBConnection();
            user = User.Instance;
            LoadPlayerRatings();
            setPixelFont();
            CenterLinkLabel();
        }

        private void setPixelFont()
        {
            Color greenColor = Color.FromArgb(15, 255, 80);
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("ARCADECLASSIC.TTF");
            Font pixelFont = new Font(privateFonts.Families[0], 35, FontStyle.Regular);
            Font pixelFontRating = new Font(privateFonts.Families[0], 25, FontStyle.Regular);
            LNumberOne.Font = pixelFont;
            LNumberOne.ForeColor = greenColor;
            LPlayerRating.Font = pixelFontRating;
            LPlayerRating.ForeColor = greenColor;

        }
        private void CenterLinkLabel()
        {
            int spacing = 10;

            LNumberOne.Location = new Point(
                (this.ClientSize.Width - LNumberOne.Width) / 2,
                spacing
            );

        }

        private void LoadPlayerRatings()
        {
            string query = "SELECT playerscores.bestscore, users.username, playerscores.userId FROM playerscores JOIN users ON playerscores.userId = users.id ORDER BY playerscores.bestscore DESC";

            StringBuilder playerInfo = new StringBuilder();

            if (conn.OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn.GetConnection());
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    int rank = 1;
                    int userRank = 0;

                    while (dataReader.Read())
                    {
                        string username = dataReader.GetString(1);
                        int score = dataReader.GetInt32(0);

                        if (Properties.Settings.Default.UserId == dataReader.GetInt32(2))
                        {
                            userRank = rank;
                            username = "YOUR ";
                            LNumberOne.Text = $"#{userRank} {username}   score: {score}";
                            LNumberOne.ForeColor = Color.OrangeRed;
                        }
                        else
                        {
                            playerInfo.AppendLine($"#{rank} {username}   scored: {score}");
                        }

                        rank++;
                    }

                    LPlayerRating.Text = playerInfo.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.CloseConnection();
                }
            }
        }




        private void PlayersRating_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu existingMenu = Application.OpenForms.OfType<Menu>().FirstOrDefault();

            if (existingMenu == null)
            {
                existingMenu.BringToFront();
            }
            else
            {
                Menu menu = new Menu();
                menu.Show();
            }

        }
    }
}
