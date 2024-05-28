using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public Terminology()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.ToLower();

            var filteredTerms = termsList
                .Where(t => t.Name.ToLower().Contains(searchTerm) || t.Definition.ToLower().Contains(searchTerm))
                .ToList();

            resultsDataGridView.DataSource = new BindingSource { DataSource = filteredTerms };

            if (filteredTerms.Count == 0)
            {
                MessageBox.Show("Нічого не знайдено.");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm(termsList);
            editForm.ShowDialog();

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            resultsDataGridView.DataSource = null;
            resultsDataGridView.DataSource = termsList;
        }
    }
}
