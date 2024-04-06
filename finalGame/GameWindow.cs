using MySql.Data.MySqlClient;
using NAudio.Wave;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace finalGame
{
    public partial class GameWindow : Form
    {
        private DBConnection dbConnection;
        private Timer timer;
        private User user;
        private int x = 1500, y = 500, spaceShipScore = 0;
        private Point pozitionShip, pozitionInoprishelts, pozitionBullet;
        private Random random = new Random();
        private int randomNumber = 1;
        private List<PictureBox> bullets = new List<PictureBox>();
        private SoundPlayer shoot_Sound, explosion_Sound;

        public GameWindow()
        {
            InitializeComponent();
            user = User.Instance;
            dbConnection = new DBConnection();
            pozitionShip.X = x;
            pozitionShip.Y = y;
            spaceShip01.Location = pozitionShip;
            pozitionInoprishelts.Y = random.Next(1, 809);
            pozitionBullet.Y = pozitionShip.Y;
            pozitionBullet.X = x - 80;
            DoubleBuffered = true;

            explosion_Sound = new SoundPlayer("game source\\sounds\\explosion_sound.wav");
            shoot_Sound = new SoundPlayer("game source\\sounds\\shoot_sound.wav");

            timer = new Timer();
            timer.Interval = 90;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string scoreMsg = "YOUR SCORE: "+spaceShipScore.ToString();
            GameOver_Closing(scoreMsg);
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            pozitionInoprishelts.X += 25;

            foreach (PictureBox bullet in bullets)
            {
                bullet.Location = new Point(bullet.Location.X - 35, bullet.Location.Y);
                bullet.Invalidate();
            }
            CheckCollisions();

            inoprishelets.Invalidate();
            inoprishelets.Location = pozitionInoprishelts;
        }

        private void CheckCollisions()
        {
            string spaceShipImagePath = "game source\\spaceship01.png";

            string inoprisheletsImagePath = $"game source\\inoprishelets{randomNumber:D2}.png";


            if (System.IO.File.Exists(spaceShipImagePath))
            {
                spaceShip01.Image = Image.FromFile(spaceShipImagePath);
            }
            if (System.IO.File.Exists(inoprisheletsImagePath))
            {
                inoprishelets.Image = Image.FromFile(inoprisheletsImagePath);
            }
            if (pozitionInoprishelts.X >= x)
            {
                pozitionInoprishelts.X = 1;
                pozitionInoprishelts.Y = random.Next(1, 809);
            }

            if (bullets.Any(bullet => bullet.Bounds.IntersectsWith(inoprishelets.Bounds) && bullet.Visible))
            { 
                HandleInoprisheltsHit();
            }

            if (inoprishelets.Bounds.IntersectsWith(spaceShip01.Bounds))
            {
                HandleShipHit();
            }
        }

        private async void HandleInoprisheltsHit()
        {

            explosion_Sound.Play();
            string imagePath = "game source\\explosion.gif";

            if (System.IO.File.Exists(imagePath))
            {
                inoprishelets.Image = Image.FromFile(imagePath);

                foreach (var bullet in bullets.Where(b => b.Bounds.IntersectsWith(inoprishelets.Bounds) && b.Visible))
                {
                    bullet.Visible = false;
                }

                pozitionBullet.X = x - 80;
            }

            spaceShipScore++;
            LScoreValue.Text = spaceShipScore.ToString();


            await Task.Delay(40);

            pozitionInoprishelts.X = 1;
            pozitionInoprishelts.Y = random.Next(1, 809);
            randomNumber = random.Next(1, 4);
        }


        private async void HandleShipHit()
        {
            explosion_Sound.Play();
            string imagePath = "game source\\explosion.gif";

            if (System.IO.File.Exists(imagePath))
            {
                spaceShip01.Image = Image.FromFile(imagePath);
            }

            await Task.Delay(40);
            pozitionInoprishelts.X = 1;
            pozitionInoprishelts.Y = random.Next(1, 809);
            GameOver_Closing(" YOU  LOSE");
        }
        
        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down) y += 10;
            if (y <= 1) y = 5;
            if (e.KeyData == Keys.Up) y -= 10;
            if (y >= 890) y = 890;
            if (e.KeyData == Keys.Left) x -= 10;
            if (x <= 1) x = 5;
            if (e.KeyData == Keys.Right) x += 10;
            if (x >= 1500) x = 1500;

            if (e.KeyData == Keys.Space)
            {
                shoot_Sound.Play();
                pozitionBullet.Y = y + 59;
                pozitionBullet.X = x + 10;
                Create_New_Bullet();
            }

            pozitionShip.X = x;
            pozitionShip.Y = y;
            bullet.Invalidate();
            bullet.Location = pozitionBullet;
            spaceShip01.Invalidate();
            spaceShip01.Location = pozitionShip;
        }

        private void Create_New_Bullet()
        {
            PictureBox newBullet = new PictureBox();
            newBullet.Name = "bullet" + bullets.Count;
            newBullet.BackgroundImage = Image.FromFile("game source\\bullet01.png");
            newBullet.BackgroundImageLayout = ImageLayout.Stretch;
            newBullet.Size = bullet.Size;
            newBullet.Location = new Point(pozitionBullet.X, pozitionBullet.Y);
            newBullet.Visible = true;
            newBullet.BackColor = Color.Transparent;

            this.Controls.Add(newBullet);
            bullets.Add(newBullet);
        }

        private void GameOver_Closing(string message)
        {
            timer.Stop();
            using (GameOverForm gameOverForm = new GameOverForm(message))
            {
                gameOverForm.ShowDialog();
            }
            string fetchQuery = $"SELECT bestScore FROM playerscores WHERE userId = {Properties.Settings.Default.UserId}";

            int existingBestScore = -1;
            string query = "";

            try
            {
                if (dbConnection.OpenConnection())
                {
                    MySqlCommand fetchCmd = new MySqlCommand(fetchQuery, dbConnection.GetConnection());
                    object result = fetchCmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        existingBestScore = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching existing bestScore: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }


            if (existingBestScore != -1)
            {
                if (spaceShipScore > existingBestScore)
                {
                    query = $"UPDATE playerscores SET bestScore = {spaceShipScore}, lastScore = {spaceShipScore} WHERE userId = {Properties.Settings.Default.UserId}";
                }
                else
                {
                    query = $"UPDATE playerscores SET lastScore = {spaceShipScore} WHERE userId = {Properties.Settings.Default.UserId}";
                }
            }
            else
            {
                query = $"INSERT INTO playerscores (userId, bestScore, lastScore) VALUES ({Properties.Settings.Default.UserId}, {spaceShipScore}, {spaceShipScore})";
            }

            try
            {
                if (dbConnection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            Menu newGameMenu = new Menu();
            newGameMenu.Show();
            this.Hide();
        }
    }
}
