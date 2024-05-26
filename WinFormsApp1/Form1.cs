namespace WinFormsApp1
{
    public partial class LogInForm : Form
    {
        private const string FilePath = "user_data.txt";

        public LogInForm()
        {
            InitializeComponent();
        }

        private void sendToRegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void sendToRegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            sendToRegisterLabel.ForeColor = Color.LightSteelBlue;
        }

        private void sendToRegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            sendToRegisterLabel.ForeColor = Color.LightSlateGray;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = logInField.Text;
            string password = passField1.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Авторизація пройшла успішно!");

                this.Hide();
                Terminology terminology = new Terminology();
                terminology.Show();
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Ім'я не може бути пустим.");
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пароль не може бути пустим.");
            }
            else if (password.Length < 4)
            {
                MessageBox.Show("Пароль має складати не менше 4 символів.");
            }
            else
            {
                MessageBox.Show("Невірне ім'я або пароль.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string storedUsername = reader.ReadLine();
                        string storedPassword = reader.ReadLine();

                        if (username == storedUsername && password == storedPassword)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
