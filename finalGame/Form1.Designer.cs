namespace finalGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.NameTB = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LForm = new System.Windows.Forms.Label();
            this.LConfPassword = new System.Windows.Forms.Label();
            this.ConfPasswordTB = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.LLHaveAccount = new System.Windows.Forms.LinkLabel();
            this.LLCreateAccount = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(330, 164);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(401, 41);
            this.NameTB.TabIndex = 0;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(324, 125);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(92, 36);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassword.Location = new System.Drawing.Point(324, 231);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(147, 36);
            this.LPassword.TabIndex = 3;
            this.LPassword.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(330, 270);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(401, 41);
            this.PasswordTB.TabIndex = 2;
            // 
            // LForm
            // 
            this.LForm.AutoSize = true;
            this.LForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LForm.Location = new System.Drawing.Point(444, 43);
            this.LForm.Name = "LForm";
            this.LForm.Size = new System.Drawing.Size(158, 55);
            this.LForm.TabIndex = 4;
            this.LForm.Text = "Log In";
            // 
            // LConfPassword
            // 
            this.LConfPassword.AutoSize = true;
            this.LConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfPassword.Location = new System.Drawing.Point(324, 360);
            this.LConfPassword.Name = "LConfPassword";
            this.LConfPassword.Size = new System.Drawing.Size(258, 36);
            this.LConfPassword.TabIndex = 6;
            this.LConfPassword.Text = "Confirm Password";
            this.LConfPassword.Visible = false;
            // 
            // ConfPasswordTB
            // 
            this.ConfPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfPasswordTB.Location = new System.Drawing.Point(330, 410);
            this.ConfPasswordTB.Name = "ConfPasswordTB";
            this.ConfPasswordTB.PasswordChar = '*';
            this.ConfPasswordTB.Size = new System.Drawing.Size(401, 41);
            this.ConfPasswordTB.TabIndex = 5;
            this.ConfPasswordTB.Visible = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(330, 472);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(142, 60);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Visible = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(589, 346);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(142, 60);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // LLHaveAccount
            // 
            this.LLHaveAccount.ActiveLinkColor = System.Drawing.Color.Black;
            this.LLHaveAccount.AutoSize = true;
            this.LLHaveAccount.LinkColor = System.Drawing.Color.DimGray;
            this.LLHaveAccount.Location = new System.Drawing.Point(478, 472);
            this.LLHaveAccount.Name = "LLHaveAccount";
            this.LLHaveAccount.Size = new System.Drawing.Size(256, 25);
            this.LLHaveAccount.TabIndex = 10;
            this.LLHaveAccount.TabStop = true;
            this.LLHaveAccount.Text = "Already have an account!";
            this.LLHaveAccount.Visible = false;
            this.LLHaveAccount.VisitedLinkColor = System.Drawing.Color.Black;
            this.LLHaveAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLHaveAccount_LinkClicked);
            // 
            // LLCreateAccount
            // 
            this.LLCreateAccount.ActiveLinkColor = System.Drawing.Color.Black;
            this.LLCreateAccount.AutoSize = true;
            this.LLCreateAccount.LinkColor = System.Drawing.Color.DimGray;
            this.LLCreateAccount.Location = new System.Drawing.Point(330, 346);
            this.LLCreateAccount.Name = "LLCreateAccount";
            this.LLCreateAccount.Size = new System.Drawing.Size(164, 25);
            this.LLCreateAccount.TabIndex = 11;
            this.LLCreateAccount.TabStop = true;
            this.LLCreateAccount.Text = "Create account!";
            this.LLCreateAccount.VisitedLinkColor = System.Drawing.Color.Black;
            this.LLCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLCreateAccount_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::finalGame.Properties.Resources.logIn_image;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LLCreateAccount);
            this.Controls.Add(this.LLHaveAccount);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.LConfPassword);
            this.Controls.Add(this.ConfPasswordTB);
            this.Controls.Add(this.LForm);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.NameTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label LForm;
        private System.Windows.Forms.Label LConfPassword;
        private System.Windows.Forms.TextBox ConfPasswordTB;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.LinkLabel LLHaveAccount;
        private System.Windows.Forms.LinkLabel LLCreateAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

