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
        }

        private void addButton_Click(object sender, EventArgs e)
        {
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (termsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = termsDataGridView.SelectedRows[0].Index;
                termsList[selectedRow].Name = termTextBox.Text;
                termsList[selectedRow].Definition = definitionTextBox.Text;
                termsList[selectedRow].Links = linksTextBox.Text;
                RefreshDataGridView();

                termTextBox.Clear();
                definitionTextBox.Clear();
                linksTextBox.Clear();

                MessageBox.Show("Термін оновлено!");
            }
        }

        private void termsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedTerm = termsList[e.RowIndex];
                termTextBox.Text = selectedTerm.Name;
                definitionTextBox.Text = selectedTerm.Definition;
                linksTextBox.Text = selectedTerm.Links;
            }
        }
    }
}
