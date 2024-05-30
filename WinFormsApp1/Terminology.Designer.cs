using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            terminologyText.Size = new Size(1288, 69);
            terminologyText.TabIndex = 7;
            // 
            // terminText
            // 
            terminText.Dock = DockStyle.Fill;
            terminText.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            terminText.ForeColor = Color.White;
            terminText.Location = new Point(0, 0);
            terminText.Name = "terminText";
            terminText.Size = new Size(1288, 69);
            terminText.TabIndex = 0;
            terminText.Text = "Термінологія";
            terminText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = SystemColors.Window;
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Cursor = Cursors.IBeam;
            searchTextBox.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchTextBox.ForeColor = Color.LightSlateGray;
            searchTextBox.Location = new Point(12, 87);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(396, 30);
            searchTextBox.TabIndex = 8;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.ActiveCaption;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(276, 123);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(132, 30);
            searchButton.TabIndex = 9;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.ActiveCaption;
            editButton.Cursor = Cursors.Hand;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(1125, 120);
            editButton.Name = "editButton";
            editButton.Size = new Size(151, 33);
            editButton.TabIndex = 10;
            editButton.Text = "Редагування";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultsDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            resultsDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            resultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            resultsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resultsDataGridView.GridColor = SystemColors.ActiveCaption;
            resultsDataGridView.Location = new Point(12, 170);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            resultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.ForeColor = Color.LightSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ActiveCaptionText;
            resultsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            resultsDataGridView.Size = new Size(1264, 452);
            resultsDataGridView.TabIndex = 11;
            // 
            // filterComboBox
            // 
            filterComboBox.Cursor = Cursors.Hand;
            filterComboBox.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            filterComboBox.ForeColor = Color.LightSlateGray;
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "За алфавітом", "За датою додавання" });
            filterComboBox.Location = new Point(12, 124);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(258, 30);
            filterComboBox.TabIndex = 12;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // Terminology
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1288, 634);
            Controls.Add(filterComboBox);
            Controls.Add(resultsDataGridView);
            Controls.Add(editButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(terminologyText);
            Name = "Terminology";
            StartPosition = FormStartPosition.CenterScreen;
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