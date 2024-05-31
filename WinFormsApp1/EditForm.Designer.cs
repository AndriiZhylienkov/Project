namespace WinFormsApp1
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            edittingText = new Panel();
            editText = new Label();
            termTextBox = new TextBox();
            definitionTextBox = new TextBox();
            linksTextBox = new TextBox();
            addButton = new Button();
            termsDataGridView = new DataGridView();
            deleteButton = new Button();
            helpButton2 = new Button();
            edittingText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)termsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // edittingText
            // 
            edittingText.BackColor = SystemColors.ActiveCaption;
            edittingText.Controls.Add(editText);
            edittingText.Dock = DockStyle.Top;
            edittingText.Location = new Point(0, 0);
            edittingText.Name = "edittingText";
            edittingText.Size = new Size(800, 63);
            edittingText.TabIndex = 8;
            // 
            // editText
            // 
            editText.Dock = DockStyle.Fill;
            editText.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            editText.ForeColor = Color.White;
            editText.Location = new Point(0, 0);
            editText.Name = "editText";
            editText.Size = new Size(800, 63);
            editText.TabIndex = 0;
            editText.Text = "Редагування";
            editText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // termTextBox
            // 
            termTextBox.BorderStyle = BorderStyle.FixedSingle;
            termTextBox.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            termTextBox.ForeColor = Color.LightSlateGray;
            termTextBox.Location = new Point(12, 69);
            termTextBox.Name = "termTextBox";
            termTextBox.Size = new Size(566, 26);
            termTextBox.TabIndex = 9;
            // 
            // definitionTextBox
            // 
            definitionTextBox.BorderStyle = BorderStyle.FixedSingle;
            definitionTextBox.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            definitionTextBox.ForeColor = Color.LightSlateGray;
            definitionTextBox.Location = new Point(12, 101);
            definitionTextBox.Name = "definitionTextBox";
            definitionTextBox.Size = new Size(566, 26);
            definitionTextBox.TabIndex = 10;
            // 
            // linksTextBox
            // 
            linksTextBox.BorderStyle = BorderStyle.FixedSingle;
            linksTextBox.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            linksTextBox.ForeColor = Color.LightSlateGray;
            linksTextBox.Location = new Point(12, 133);
            linksTextBox.Name = "linksTextBox";
            linksTextBox.Size = new Size(566, 26);
            linksTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ActiveCaption;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(593, 69);
            addButton.Name = "addButton";
            addButton.Size = new Size(124, 41);
            addButton.TabIndex = 12;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // termsDataGridView
            // 
            termsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            termsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            termsDataGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            termsDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            termsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            termsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            termsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            termsDataGridView.Location = new Point(12, 179);
            termsDataGridView.Name = "termsDataGridView";
            termsDataGridView.Size = new Size(776, 268);
            termsDataGridView.TabIndex = 14;
            termsDataGridView.CellContentClick += termsDataGridView_CellContentClick;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ActiveCaption;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(593, 116);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(124, 41);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // helpButton2
            // 
            helpButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            helpButton2.BackColor = SystemColors.ActiveCaption;
            helpButton2.Cursor = Cursors.Hand;
            helpButton2.FlatAppearance.BorderSize = 0;
            helpButton2.FlatStyle = FlatStyle.Flat;
            helpButton2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            helpButton2.ForeColor = Color.White;
            helpButton2.Location = new Point(747, 100);
            helpButton2.Name = "helpButton2";
            helpButton2.Size = new Size(25, 25);
            helpButton2.TabIndex = 16;
            helpButton2.Text = "?";
            helpButton2.UseVisualStyleBackColor = false;
            helpButton2.Click += helpButton2_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 459);
            Controls.Add(helpButton2);
            Controls.Add(deleteButton);
            Controls.Add(termsDataGridView);
            Controls.Add(addButton);
            Controls.Add(linksTextBox);
            Controls.Add(definitionTextBox);
            Controls.Add(termTextBox);
            Controls.Add(edittingText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(791, 198);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditForm";
            edittingText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)termsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel edittingText;
        private Label editText;
        private TextBox termTextBox;
        private TextBox definitionTextBox;
        private TextBox linksTextBox;
        private Button addButton;
        private DataGridView termsDataGridView;
        private Button deleteButton;
        private Button helpButton2;
    }
}