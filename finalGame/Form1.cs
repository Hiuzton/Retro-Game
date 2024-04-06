using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalGame
{
    public partial class Game : Form
    {
        private DBConnection dbConnection;
        private Form gameMenu;
        private User user;
        private string username = "";
        private string password = "";
        private string confPassword = "";
        private string query = "";
        private string hashedPassword = "";
        public string userId = "";

        public Game()
        {
            InitializeComponent();
            user = User.Instance;
            gameMenu = new Menu();
            dbConnection = new DBConnection();
        }


        private void btnSignin_Click(object sender, EventArgs e)
        {
            username = NameTB.Text;
            password = PasswordTB.Text;
            confPassword = ConfPasswordTB.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            hashedPassword = HashPassword(password);

            if (AuthentificationUser(username, hashedPassword))
            {
                MessageBox.Show("Sign IN successful!");
                Hide_Elements(true, false, "Log In");
            }
            else
            {
                MessageBox.Show("Registration faild. Try again!");
            }

        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private bool AuthentificationUser(string username, string password)
        {
            query = $"INSERT INTO users (username, password) VALUES ('{username}', '{password}')";

            if (dbConnection.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    dbConnection.CloseConnection();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    dbConnection.CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            username = NameTB.Text;
            password = PasswordTB.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            hashedPassword = HashPassword(password);

            if (ValidateUser(username, hashedPassword))
            {
                Form newgameMenu = new Menu();
                newgameMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private bool ValidateUser(string username, string password)
        {
            query = $"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'";

            if (dbConnection.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    user.Id = dataReader.GetInt32(0);
                    user.Username = dataReader.GetString(1);
                    user.Password = dataReader.GetString(2);
                    Properties.Settings.Default.UserId = user.Id;
                    dbConnection.CloseConnection();
                    return true;
                }
                else
                {
                    dbConnection.CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void LLHaveAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide_Elements(true, false, "Log In");
        }

        private void LLCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide_Elements(false, true, "Sign In");
        }

        private void Hide_Elements(bool LogIn_Elements, bool SignIn_Elements, string headerName)
        {
            NameTB.Text = "";
            PasswordTB.Text = "";
            ConfPasswordTB.Text = "";
            btnLogIn.Visible = LogIn_Elements;
            LLCreateAccount.Visible = LogIn_Elements;
            LForm.Text = headerName;
            btnSignIn.Visible = SignIn_Elements;
            LConfPassword.Visible = SignIn_Elements;
            ConfPasswordTB.Visible = SignIn_Elements;
            LLHaveAccount.Visible = SignIn_Elements;
        }


        private bool closingInProgress = false;
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
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
    }
}
