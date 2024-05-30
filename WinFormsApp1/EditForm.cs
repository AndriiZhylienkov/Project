using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Terminology;

namespace WinFormsApp1
{
    public partial class EditForm : Form
    {
        private List<Term> termsList;

        public EditForm(List<Term> terms)
        {
            termsList = terms;
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            termsDataGridView.DataSource = new BindingSource { DataSource = termsList };

            termsDataGridView.Columns["Name"].HeaderText = "Термін";
            termsDataGridView.Columns["Definition"].HeaderText = "Визначення";
            termsDataGridView.Columns["Links"].HeaderText = "Посилання";
            termsDataGridView.Columns["DateAdded"].HeaderText = "Дата додавання";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(termTextBox.Text) ||
        string.IsNullOrWhiteSpace(definitionTextBox.Text) ||
        string.IsNullOrWhiteSpace(linksTextBox.Text))
            {
                MessageBox.Show("Для додавання терміну всі поля мають бути заповнені.");
                return;
            }

            var term = new Term
            {
                Name = termTextBox.Text,
                Definition = definitionTextBox.Text,
                Links = linksTextBox.Text
            };

            termsList.Add(term);
            RefreshDataGridView();

            termTextBox.Clear();
            definitionTextBox.Clear();
            linksTextBox.Clear();

            MessageBox.Show("Термін додано!");
        }

        private void RefreshDataGridView()
        {
            termsDataGridView.DataSource = null;
            termsDataGridView.DataSource = termsList;
        }

        private void termsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < termsList.Count)
            {
                var selectedTerm = termsList[e.RowIndex];
                termTextBox.Text = selectedTerm.Name;
                definitionTextBox.Text = selectedTerm.Definition;
                linksTextBox.Text = selectedTerm.Links;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (termsDataGridView.SelectedRows.Count > 0)
            {
                int selectedRow = termsDataGridView.SelectedRows[0].Index;
                if (selectedRow >= 0 && selectedRow < termsList.Count)
                {
                    termsList.RemoveAt(selectedRow);
                    RefreshDataGridView();

                    termTextBox.Clear();
                    definitionTextBox.Clear();
                    linksTextBox.Clear();

                    MessageBox.Show("Термін видалено!");
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DataManager.SaveData(termsList);
        }
    }
}
