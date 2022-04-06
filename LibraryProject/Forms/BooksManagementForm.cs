using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka;

namespace LibraryProject
{
    public partial class BooksManagementForm : Form
    {
        public BooksManagementForm()
        {
            InitializeComponent();
        }

        private void BooksManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.menuFormCaller.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm.menuFormCaller.Show();
        }

        private void BooksManagementForm_Load(object sender, EventArgs e)
        {
            Book.ShowBooks(booksTable);
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new Book(titleTextBox.Text, authorTextBox.Text, publisherTextBox.Text, sectionTextBox.Text, Convert.ToUInt64(quantityTextBox.Text));
                Book.AddBook(newBook);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane! Proszę poprawnie uzupełnić pole ilość dla dodawanej książki.");
            }
            Book.ShowBooks(booksTable);
        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new Book(titleTextBox.Text, authorTextBox.Text, publisherTextBox.Text, sectionTextBox.Text, Convert.ToUInt64(quantityTextBox.Text));
                Book.UpdateBook(newBook, Convert.ToUInt64(idTextBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane! Proszę poprawnie uzupełnić pole id oraz pole ilość dla aktualizowanej książki.");
            }
            Book.ShowBooks(booksTable);
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new Book(titleTextBox.Text, authorTextBox.Text, publisherTextBox.Text, sectionTextBox.Text, 0);
                Book.DeleteBook(newBook);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane! Proszę poprawnie uzupełnić pola usuwanej książki. Ilość nie jest brana pod uwagę.");
            }
            Book.ShowBooks(booksTable);
        }

        private void selectBook(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (booksTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    booksTable.CurrentRow.Selected = true;
                    titleTextBox.Text = booksTable.Rows[e.RowIndex].Cells["title"].FormattedValue.ToString();
                    authorTextBox.Text = booksTable.Rows[e.RowIndex].Cells["author"].FormattedValue.ToString();
                    publisherTextBox.Text = booksTable.Rows[e.RowIndex].Cells["publisher"].FormattedValue.ToString();
                    sectionTextBox.Text = booksTable.Rows[e.RowIndex].Cells["section"].FormattedValue.ToString();
                    quantityTextBox.Text = booksTable.Rows[e.RowIndex].Cells["quantity"].FormattedValue.ToString();
                    idTextBox.Text = booksTable.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Book.SearchBooks(booksTable, searchBox.Text);
        }

        private void booksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
