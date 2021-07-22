using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace C969___Scheduler_App
{
    public partial class loginScreen : Form
    {
        // CAPSTONE COMMENT: Advanced security features are implemented in this program through a Login screen as well as 
        // a function that logs all log in attemps (whether successfulr or unsuccessful) to a .txt file in the bin/debug folder named "logintracker.txt" 


        // Properties ------------------------------------------------------------------------------------------------------
        ResourceManager rm = new ResourceManager("C969___Scheduler_App.Resources.LoginScreen", Assembly.GetExecutingAssembly());
        public StreamWriter fileWriter;
        public string fileName = "logintracker.txt";

        // Constructors ----------------------------------------------------------------------------------------------------
        public loginScreen()
        {
            InitializeComponent();

            FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            fileWriter = new StreamWriter(fileStream);

            this.Text = rm.GetString("Login Screen Title");
            titleLabel.Text = rm.GetString("Welcome");
            usernameLabel.Text = rm.GetString("Username");
            passwordLabel.Text = rm.GetString("Password");
            loginButton.Text = rm.GetString("Login");
            exitButton.Text = rm.GetString("Exit");

        }


        // Events & Methods ---------------------------------------------------------------------------------------------------
        private void loginScreen_Load(object sender, EventArgs e)
        {
            switch (CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
            {
                case "es":
                    this.usernameLabel.Location = new Point(53, 170);
                    this.usernameTextbox.Location = new Point(193, 169);

                    this.passwordLabel.Location = new Point(101, 206);
                    this.passwordTextbox.Location = new Point(193, 205);

                    this.loginButton.Size = new Size(63, 41);
                    this.loginButton.Location = new Point(207, 243);

                    break;

                default:
                    // No change
                    break;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextbox.Text))
            {
                MessageBox.Show(rm.GetString("Missing Username Body"), rm.GetString("Missing Username Title"));
            }
            else if (string.IsNullOrWhiteSpace(passwordTextbox.Text))
            {
                MessageBox.Show(rm.GetString("Missing Password Body"), rm.GetString("Missing Password Title"));
            }
            else
            {
                using (MySqlConnection DatabaseConnection = new MySqlConnection(Connections.ConnectionString))
                {
                    MySqlCommand Command = new MySqlCommand();
                    Command.CommandText = "SELECT COUNT(userID) FROM U07wVX.user WHERE userName ='"
                        + usernameTextbox.Text + "' AND password = '" + passwordTextbox.Text + "';";
                    Command.Connection = DatabaseConnection;
                    DatabaseConnection.Open();
                    int Match = Convert.ToInt32(Command.ExecuteScalar());
                    if (Match == 1)
                    {
                        fileWriter.WriteLine($"{DateTime.Now}: Successful login.");
                        fileWriter.Close();

                        mainScreen mainScreen = new mainScreen(this);
                        mainScreen.Show();
                        this.Hide();
                    }
                    else
                    {
                        fileWriter.WriteLine($"{DateTime.Now}: Unsuccessful login.");

                        MessageBox.Show(rm.GetString("Invalid Login Credentials Body"), rm.GetString("Invalid Login Credentials Title"));
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            fileWriter.Close();
            Application.Exit();
        }
    }
}
