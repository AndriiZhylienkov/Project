namespace WinFormsApp1
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            panel1 = new Panel();
            logInText = new Label();
            logInField = new TextBox();
            passField1 = new TextBox();
            logInButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            recomLabel = new Label();
            sendToRegisterLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(logInText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 91);
            panel1.TabIndex = 0;
            // 
            // logInText
            // 
            logInText.Dock = DockStyle.Fill;
            logInText.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            logInText.ForeColor = Color.White;
            logInText.Location = new Point(0, 0);
            logInText.Name = "logInText";
            logInText.Size = new Size(457, 91);
            logInText.TabIndex = 0;
            logInText.Text = "Авторизація";
            logInText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logInField
            // 
            logInField.Anchor = AnchorStyles.Top;
            logInField.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            logInField.ForeColor = Color.LightSlateGray;
            logInField.Location = new Point(102, 129);
            logInField.Name = "logInField";
            logInField.Size = new Size(315, 36);
            logInField.TabIndex = 2;
            // 
            // passField1
            // 
            passField1.Anchor = AnchorStyles.Top;
            passField1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            passField1.ForeColor = Color.LightSlateGray;
            passField1.Location = new Point(102, 231);
            passField1.Name = "passField1";
            passField1.Size = new Size(315, 36);
            passField1.TabIndex = 4;
            passField1.UseSystemPasswordChar = true;
            // 
            // logInButton
            // 
            logInButton.Anchor = AnchorStyles.Top;
            logInButton.BackColor = SystemColors.ActiveCaption;
            logInButton.Cursor = Cursors.Hand;
            logInButton.FlatAppearance.BorderSize = 0;
            logInButton.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            logInButton.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            logInButton.ForeColor = Color.White;
            logInButton.Location = new Point(102, 383);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(244, 52);
            logInButton.TabIndex = 5;
            logInButton.Text = "Авторизуватись";
            logInButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // recomLabel
            // 
            recomLabel.Anchor = AnchorStyles.Top;
            recomLabel.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recomLabel.ForeColor = Color.LightSlateGray;
            recomLabel.Location = new Point(32, 317);
            recomLabel.Name = "recomLabel";
            recomLabel.Size = new Size(385, 36);
            recomLabel.TabIndex = 8;
            recomLabel.Text = "Якщо ви не маєте облікового запису, спочатку виповніть процес реєстрації";
            recomLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // sendToRegisterLabel
            // 
            sendToRegisterLabel.Anchor = AnchorStyles.Top;
            sendToRegisterLabel.Cursor = Cursors.Hand;
            sendToRegisterLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sendToRegisterLabel.ForeColor = Color.LightSlateGray;
            sendToRegisterLabel.Location = new Point(170, 438);
            sendToRegisterLabel.Name = "sendToRegisterLabel";
            sendToRegisterLabel.Size = new Size(105, 25);
            sendToRegisterLabel.TabIndex = 9;
            sendToRegisterLabel.Text = "Реєстрація";
            sendToRegisterLabel.TextAlign = ContentAlignment.MiddleCenter;
            sendToRegisterLabel.Click += sendToRegisterLabel_Click;
            sendToRegisterLabel.MouseEnter += sendToRegisterLabel_MouseEnter;
            sendToRegisterLabel.MouseLeave += sendToRegisterLabel_MouseLeave;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(457, 517);
            Controls.Add(sendToRegisterLabel);
            Controls.Add(recomLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(logInButton);
            Controls.Add(passField1);
            Controls.Add(logInField);
            Controls.Add(panel1);
            MinimumSize = new Size(405, 528);
            Name = "LogInForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label logInText;
        private TextBox logInField;
        private TextBox passField1;
        private Button logInButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label recomLabel;
        private Label sendToRegisterLabel;
    }
}
