using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Terminology;

namespace WinFormsApp1
{
    public partial class Terminology : Form
    {
        private List<Term> termsList = new List<Term>();


        public class Term
        {
            public string Name { get; set; }
            public string Definition { get; set; }
            public string Links { get; set; }
            public DateTime DateAdded { get; set; }

            public Term()
            {
                DateAdded = DateTime.Now;
            }
        }

        public Terminology()
        {
            termsList = DataManager.LoadData();
            InitializeComponent();
            LoadResultsDataGrid();

        }

        private void LoadResultsDataGrid()
        {
            resultsDataGridView.DataSource = new BindingSource { DataSource = termsList };

            SetResultsDataGridViewHeaders();
        }

        private void ResultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == resultsDataGridView.Columns["Links"].Index && e.RowIndex >= 0)
            {
                var term = resultsDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                var url = $"https://uk.wikipedia.org/wiki/{term}";

                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося відкрити посилання: " + ex.Message);
                }
            }
        }

        private void SetResultsDataGridViewHeaders()
        {
            if (resultsDataGridView.Columns.Contains("Name"))
            {
                resultsDataGridView.Columns["Name"].HeaderText = "Термін";
            }
            if (resultsDataGridView.Columns.Contains("Definition"))
            {
                resultsDataGridView.Columns["Definition"].HeaderText = "Визначення";
            }
            if (resultsDataGridView.Columns.Contains("Links"))
            {
                resultsDataGridView.Columns["Links"].HeaderText = "Посилання";
            }
            if (resultsDataGridView.Columns.Contains("DateAdded"))
            {
                resultsDataGridView.Columns["DateAdded"].HeaderText = "Дата додавання";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.ToLower();

            var filteredTerms = termsList.FindAll(t => t.Name.ToLower().Contains(searchTerm) || t.Definition.ToLower().Contains(searchTerm) || t.Links.ToLower().Contains(searchTerm));

            resultsDataGridView.DataSource = new BindingSource { DataSource = filteredTerms };

            SetResultsDataGridViewHeaders();

            if (filteredTerms.Count == 0)
            {
                MessageBox.Show("Нічого не знайдено.");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm(termsList);
            editForm.ShowDialog();
            LoadResultsDataGrid();

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            resultsDataGridView.DataSource = null;
            resultsDataGridView.DataSource = termsList;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DataManager.SaveData(termsList);
        }

        public static class DataManager
        {
            private static string dataFilePath = "terms.json";

            public static void SaveData(List<Term> termsList)
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(termsList, options);
                File.WriteAllText(dataFilePath, json);
            }

            public static List<Term> LoadData()
            {
                if (File.Exists(dataFilePath))
                {
                    var json = File.ReadAllText(dataFilePath);
                    return JsonSerializer.Deserialize<List<Term>>(json);
                }
                return new List<Term>();
            }
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filterComboBox.SelectedIndex)
            {
                case 0:
                    termsList = termsList.OrderBy(t => t.Name).ToList();
                    break;
                case 1:
                    termsList = termsList.OrderBy(t => t.DateAdded).ToList();
                    break;
                case 2:
                    termsList = termsList.OrderBy(term => term.Name.Length).ToList();
                    break;
                default:
                    break;
            }

            RefreshDataGridView();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Інструкції користування:\n\n" +
                        "1. Введіть термін у поле пошуку та натисніть кнопку 'Пошук', щоб знайти терміни.\n\n" +
                        "2. Виберіть фільтр з випадаючого списку, щоб сортувати терміни.\n\n" +
                        "3. Натисніть кнопку 'Редагувати', щоб відкрити форму редагування бази даних.\n\n" +
                        "4. Натисніть на посилання у стовпці 'Посилання', щоб відкрити сторінку Wikipedia для терміну.",
                        "Допомога", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
