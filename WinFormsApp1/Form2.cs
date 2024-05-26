using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        private const string FilePath = "user_data.txt";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void sendToLogInLabel_MouseEnter(object sender, EventArgs e)
        {
            sendToLogInLabel.ForeColor = Color.LightSteelBlue;
        }

        private void sendToLogInLabel_MouseLeave(object sender, EventArgs e)
        {
            sendToLogInLabel.ForeColor = Color.LightSlateGray;
        }

        private void sendToLogInLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = registerField.Text;
            string password = passField2.Text;

            if (IsInputValid(username, password))
            {
                if (IsUsernameTaken(username))
                {
                    MessageBox.Show("Ім'я вже використовується. Будь ласка, виберіть інше ім'я.");
                }
                else
                {
                    SaveUserData(username, password);
                    MessageBox.Show("Реєстрація пройшла успішно!");
                    this.Hide();
                    LogInForm logInForm = new LogInForm();
                    logInForm.Show();
                }
            }
        }

        private bool IsInputValid(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Ім'я не може бути пустим.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пароль не може бути пустим.");
                return false;
            }

            if (password.Length < 4)
            {
                MessageBox.Show("Пароль має складати не менше 4 символів.");
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Пароль має містити хоча б одну цифру.");
                return false;
            }

            return true;
        }

        private bool IsUsernameTaken(string username)
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string storedUsername = reader.ReadLine();
                        string storedPassword = reader.ReadLine();

                        if (username == storedUsername)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void SaveUserData(string username, string password)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, append: true))
            {
                writer.WriteLine(username);
                writer.WriteLine(password);
            }
        }
    }
    
}
