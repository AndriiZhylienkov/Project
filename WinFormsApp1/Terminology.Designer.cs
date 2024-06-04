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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminology));
            terminologyText = new Panel();
            terminText = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            editButton = new Button();
            resultsDataGridView = new DataGridView();
            linkColumn = new DataGridViewLinkColumn();
            filterComboBox = new ComboBox();
            welcomeLabel = new Label();
            helpButton = new Button();
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
            terminologyText.Margin = new Padding(4, 3, 4, 3);
            terminologyText.Name = "terminologyText";
            terminologyText.Size = new Size(1289, 69);
            terminologyText.TabIndex = 7;
            // 
            // terminText
            // 
            terminText.Dock = DockStyle.Fill;
            terminText.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            terminText.ForeColor = Color.White;
            terminText.Location = new Point(0, 0);
            terminText.Margin = new Padding(4, 0, 4, 0);
            terminText.Name = "terminText";
            terminText.Size = new Size(1289, 69);
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
            searchTextBox.Margin = new Padding(4, 3, 4, 3);
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
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(132, 30);
            searchButton.TabIndex = 9;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.BackColor = SystemColors.ActiveCaption;
            editButton.Cursor = Cursors.Hand;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(1126, 120);
            editButton.Margin = new Padding(4, 3, 4, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 33);
            editButton.TabIndex = 10;
            editButton.Text = "Редагування";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { linkColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            resultsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resultsDataGridView.GridColor = SystemColors.ActiveCaption;
            resultsDataGridView.Location = new Point(12, 169);
            resultsDataGridView.Margin = new Padding(4, 3, 4, 3);
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
            resultsDataGridView.Size = new Size(1329, 455);
            resultsDataGridView.TabIndex = 11;
            resultsDataGridView.CellContentClick += ResultsDataGridView_CellContentClick;
            resultsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            resultsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // linkColumn
            // 
            linkColumn.DataPropertyName = "Links";
            linkColumn.HeaderText = "Посилання";
            linkColumn.Name = "linkColumn";
            linkColumn.ReadOnly = true;
            // 
            // filterComboBox
            // 
            filterComboBox.Cursor = Cursors.Hand;
            filterComboBox.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            filterComboBox.ForeColor = Color.LightSlateGray;
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "За алфавітом", "За датою додавання", "За довжиною" });
            filterComboBox.Location = new Point(12, 124);
            filterComboBox.Margin = new Padding(4, 3, 4, 3);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(258, 30);
            filterComboBox.TabIndex = 12;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            welcomeLabel.FlatStyle = FlatStyle.Flat;
            welcomeLabel.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            welcomeLabel.ForeColor = Color.SlateGray;
            welcomeLabel.Location = new Point(416, 82);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(699, 72);
            welcomeLabel.TabIndex = 13;
            welcomeLabel.Text = resources.GetString("welcomeLabel.Text");
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // helpButton
            // 
            helpButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            helpButton.BackColor = SystemColors.ActiveCaption;
            helpButton.Cursor = Cursors.Hand;
            helpButton.FlatAppearance.BorderSize = 0;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            helpButton.ForeColor = Color.White;
            helpButton.Location = new Point(1251, 82);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(25, 25);
            helpButton.TabIndex = 17;
            helpButton.Text = "?";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // Terminology
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1289, 637);
            Controls.Add(helpButton);
            Controls.Add(welcomeLabel);
            Controls.Add(filterComboBox);
            Controls.Add(resultsDataGridView);
            Controls.Add(editButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(terminologyText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(594, 248);
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
        private DataGridViewLinkColumn linkColumn;
        private Label welcomeLabel;
        private Button helpButton;
    }
}