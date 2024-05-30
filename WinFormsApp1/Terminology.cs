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
                    SortByAlphabet();
                    break;
                case 1:
                    SortByDateAdded();
                    break;
                default:
                    break;
            }

            RefreshDataGridView();
        }

        private void SortByAlphabet()
        {
            termsList = termsList.OrderBy(t => t.Name).ToList();
        }

        private void SortByDateAdded()
        {
            termsList = termsList.OrderBy(t => t.DateAdded).ToList();
        }
    }
}
