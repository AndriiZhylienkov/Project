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
            edittingText = new Panel();
            editText = new Label();
            termTextBox = new TextBox();
            definitionTextBox = new TextBox();
            linksTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            termsDataGridView = new DataGridView();
            deleteButton = new Button();
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
            termTextBox.Location = new Point(12, 69);
            termTextBox.Name = "termTextBox";
            termTextBox.Size = new Size(566, 23);
            termTextBox.TabIndex = 9;
            // 
            // definitionTextBox
            // 
            definitionTextBox.Location = new Point(12, 98);
            definitionTextBox.Name = "definitionTextBox";
            definitionTextBox.Size = new Size(566, 23);
            definitionTextBox.TabIndex = 10;
            // 
            // linksTextBox
            // 
            linksTextBox.Location = new Point(12, 127);
            linksTextBox.Name = "linksTextBox";
            linksTextBox.Size = new Size(566, 23);
            linksTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.Location = new Point(658, 69);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(658, 98);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // termsDataGridView
            // 
            termsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            termsDataGridView.Location = new Point(12, 156);
            termsDataGridView.Name = "termsDataGridView";
            termsDataGridView.Size = new Size(776, 282);
            termsDataGridView.TabIndex = 14;
            termsDataGridView.CellContentClick += termsDataGridView_CellContentClick;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(658, 127);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 15;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(termsDataGridView);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(linksTextBox);
            Controls.Add(definitionTextBox);
            Controls.Add(termTextBox);
            Controls.Add(edittingText);
            Name = "EditForm";
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
        private Button updateButton;
        private DataGridView termsDataGridView;
        private Button deleteButton;
    }
}