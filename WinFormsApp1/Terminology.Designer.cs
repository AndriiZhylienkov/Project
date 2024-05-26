namespace WinFormsApp1
{
    partial class Terminology
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
            terminologyText = new Panel();
            terminText = new Label();
            terminologyText.SuspendLayout();
            SuspendLayout();
            // 
            // terminologyText
            // 
            terminologyText.BackColor = SystemColors.ActiveCaption;
            terminologyText.Controls.Add(terminText);
            terminologyText.Dock = DockStyle.Top;
            terminologyText.Location = new Point(0, 0);
            terminologyText.Name = "terminologyText";
            terminologyText.Size = new Size(925, 69);
            terminologyText.TabIndex = 7;
            // 
            // terminText
            // 
            terminText.Dock = DockStyle.Fill;
            terminText.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            terminText.ForeColor = Color.White;
            terminText.Location = new Point(0, 0);
            terminText.Name = "terminText";
            terminText.Size = new Size(925, 69);
            terminText.TabIndex = 0;
            terminText.Text = "Термінологія";
            terminText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Terminology
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(925, 537);
            Controls.Add(terminologyText);
            Name = "Terminology";
            Text = "Terminology";
            terminologyText.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel terminologyText;
        private Label terminText;
    }
}