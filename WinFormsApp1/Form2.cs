﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
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
    }
}
