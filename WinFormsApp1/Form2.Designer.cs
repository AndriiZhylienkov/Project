namespace WinFormsApp1
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            passField2 = new TextBox();
            registerField = new TextBox();
            registrationText = new Panel();
            registerText = new Label();
            registerButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            recomLabel = new Label();
            sendToLogInLabel = new Label();
            registrationText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // passField2
            // 
            passField2.Anchor = AnchorStyles.Top;
            passField2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            passField2.ForeColor = Color.LightSlateGray;
            passField2.Location = new Point(98, 230);
            passField2.Name = "passField2";
            passField2.Size = new Size(315, 36);
            passField2.TabIndex = 10;
            passField2.UseSystemPasswordChar = true;
            // 
            // registerField
            // 
            registerField.Anchor = AnchorStyles.Top;
            registerField.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            registerField.ForeColor = Color.LightSlateGray;
            registerField.Location = new Point(98, 128);
            registerField.Name = "registerField";
            registerField.Size = new Size(315, 36);
            registerField.TabIndex = 8;
            // 
            // registrationText
            // 
            registrationText.BackColor = SystemColors.ActiveCaption;
            registrationText.Controls.Add(registerText);
            registrationText.Dock = DockStyle.Top;
            registrationText.Location = new Point(0, 0);
            registrationText.Name = "registrationText";
            registrationText.Size = new Size(459, 91);
            registrationText.TabIndex = 6;
            // 
            // registerText
            // 
            registerText.Dock = DockStyle.Fill;
            registerText.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            registerText.ForeColor = Color.White;
            registerText.Location = new Point(0, 0);
            registerText.Name = "registerText";
            registerText.Size = new Size(459, 91);
            registerText.TabIndex = 0;
            registerText.Text = "Реєстрація";
            registerText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Top;
            registerButton.BackColor = SystemColors.ActiveCaption;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            registerButton.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(98, 380);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(276, 52);
            registerButton.TabIndex = 11;
            registerButton.Text = "Зареєструватись";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // recomLabel
            // 
            recomLabel.Anchor = AnchorStyles.Top;
            recomLabel.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recomLabel.ForeColor = Color.LightSlateGray;
            recomLabel.Location = new Point(28, 308);
            recomLabel.Name = "recomLabel";
            recomLabel.Size = new Size(385, 36);
            recomLabel.TabIndex = 14;
            recomLabel.Text = "Якщо ви вже маєте обліковий запис, виповніть авторизацію";
            recomLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // sendToLogInLabel
            // 
            sendToLogInLabel.Anchor = AnchorStyles.Top;
            sendToLogInLabel.Cursor = Cursors.Hand;
            sendToLogInLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sendToLogInLabel.ForeColor = Color.LightSlateGray;
            sendToLogInLabel.Location = new Point(180, 435);
            sendToLogInLabel.Name = "sendToLogInLabel";
            sendToLogInLabel.Size = new Size(118, 24);
            sendToLogInLabel.TabIndex = 15;
            sendToLogInLabel.Text = "Авторизація";
            sendToLogInLabel.TextAlign = ContentAlignment.MiddleCenter;
            sendToLogInLabel.Click += sendToLogInLabel_Click;
            sendToLogInLabel.MouseEnter += sendToLogInLabel_MouseEnter;
            sendToLogInLabel.MouseLeave += sendToLogInLabel_MouseLeave;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(459, 504);
            Controls.Add(sendToLogInLabel);
            Controls.Add(recomLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(registerButton);
            Controls.Add(passField2);
            Controls.Add(registerField);
            Controls.Add(registrationText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(412, 504);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            registrationText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passField2;
        private TextBox registerField;
        private Panel registrationText;
        private Label registerText;
        private Button registerButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label recomLabel;
        private Label sendToLogInLabel;
    }
}