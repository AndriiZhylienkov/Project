using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string term = Regex.Replace(termTextBox.Text.Trim(), @"\s+", " ");
            string definition = Regex.Replace(definitionTextBox.Text.Trim(), @"\s+", " ");
            string links = Regex.Replace(linksTextBox.Text.Trim(), @"\s+", " ");

            if (string.IsNullOrWhiteSpace(term) || string.IsNullOrWhiteSpace(definition) || string.IsNullOrWhiteSpace(links))
            {
                MessageBox.Show("Для додавання терміну всі поля мають бути заповнені.");
                return;
            }

            if (!Regex.IsMatch(term, @"\p{L}") || !Regex.IsMatch(definition, @"\p{L}") || !Regex.IsMatch(links, @"\p{L}"))
            {
                MessageBox.Show("Термін, визначення та посилання повинні містити хоча б одну букву.");
                return;
            }

            var newTerm = new Term
            {
                Name = term,
                Definition = definition,
                Links = links
            };

            termsList.Add(newTerm);
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
                var selectedTerm = termsDataGridView.SelectedRows[0].DataBoundItem as Term;
                if (selectedTerm != null)
                {
                    var result = MessageBox.Show($"Ви дійсно хочете видалити термін '{selectedTerm.Name}'?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        termsList.Remove(selectedTerm);
                        LoadDataGrid();
                        MessageBox.Show("Термін видалено!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть термін для видалення.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DataManager.SaveData(termsList);
        }

        private void helpButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Інструкції користування:\n\n" +
                        "1. Введіть термін у відповідне поле та його визначення у відповідне поле.\n\n" +
                        "2. Введіть вигляд посилання у поле 'Посилання'.\n\n" +
                        "3. Натисніть кнопку 'Додати', щоб додати новий термін до бази даних.\n\n" +
                        "4. Для редагування терміну треба двічі клацнути по ньому лівою кнопкою миші.\n\n" +
                        "5. Виберіть термін зі списку, щоб видалити його.\n\n" +
                        "6. Натисніть кнопку 'Видалити', щоб видалити вибраний термін.",
                        "Допомога", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
