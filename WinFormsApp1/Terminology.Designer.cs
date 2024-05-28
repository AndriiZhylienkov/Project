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
            searchTextBox = new TextBox();
            searchButton = new Button();
            editButton = new Button();
            resultsDataGridView = new DataGridView();
            filterComboBox = new ComboBox();
            terminologyText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
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
            // searchTextBox
            // 
            searchTextBox.Location = new Point(170, 218);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 8;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(444, 202);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 9;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(386, 322);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 10;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Location = new Point(30, 332);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.Size = new Size(240, 150);
            resultsDataGridView.TabIndex = 11;
            // 
            // filterComboBox
            // 
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Location = new Point(608, 330);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(121, 23);
            filterComboBox.TabIndex = 12;
            // 
            // Terminology
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(925, 537);
            Controls.Add(filterComboBox);
            Controls.Add(resultsDataGridView);
            Controls.Add(editButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(terminologyText);
            Name = "Terminology";
            Text = "Terminology";
            terminologyText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel terminologyText;
        private Label terminText;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button editButton;
        private DataGridView resultsDataGridView;
        private ComboBox filterComboBox;
    }
}