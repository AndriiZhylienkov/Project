namespace WinFormsApp1
{
    public partial class LogInForm : Form
    {
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


    }
}
