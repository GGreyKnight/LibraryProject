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
    public partial class BorrowBookManagementForm : Form
    {
        public BorrowBookManagementForm()
        {
            InitializeComponent();
        }

        private void BorrowBookManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.menuFormCaller.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm.menuFormCaller.Show();
        }

        private void BorrowBookManagementForm_Load(object sender, EventArgs e)
        {
            Member.ShowMembers(usersTable);
            Book.ShowBooks(booksTable);
            BorrowBook.ShowBooksBorrow(borrowsTable);
        }

        private void searchMemberButton_Click(object sender, EventArgs e)
        {
            Member.SearchMembers(usersTable, searchMemberTextBox.Text);
        }

        private void selectMember(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (usersTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    usersTable.CurrentRow.Selected = true;
                    peselTextBox.Text = usersTable.Rows[e.RowIndex].Cells["pesel"].FormattedValue.ToString();
                    positionTextBox.Text = usersTable.Rows[e.RowIndex].Cells["id_position"].FormattedValue.ToString();
                    firstNameTextBox.Text = usersTable.Rows[e.RowIndex].Cells["first_name"].FormattedValue.ToString();
                    lastNameTextBox.Text = usersTable.Rows[e.RowIndex].Cells["last_name"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
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
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void searchBookButton_Click(object sender, EventArgs e)
        {
            Book.SearchBooks(booksTable, searchBookTextBox.Text);
        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = new Member(Convert.ToUInt64(peselTextBox.Text), positionTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
                Book newBook = new Book(titleTextBox.Text, authorTextBox.Text, publisherTextBox.Text, sectionTextBox.Text, 0);
                BorrowBook.AddBorrowBook(newMember, newBook, dateTimePickerBorrowBookFrom, dateTimePickerBorrowBookTo);
            }
            catch (Exception)
            {
                MessageBox.Show("Niepełne dane! Proszę wybrać osobę i książkę w celu wyporzyczenia.");
                return;
            }

            BorrowBook.ShowBooksBorrow(borrowsTable);
            Book.ShowBooks(booksTable);
        }

        private void selectBooksBorrows(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (usersTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    borrowsTable.CurrentRow.Selected = true;
                    peselTextBox.Text = usersTable.Rows[e.RowIndex].Cells["pesel"].FormattedValue.ToString();
                    positionTextBox.Text = usersTable.Rows[e.RowIndex].Cells["id_position"].FormattedValue.ToString();
                    firstNameTextBox.Text = usersTable.Rows[e.RowIndex].Cells["first_name"].FormattedValue.ToString();
                    lastNameTextBox.Text = usersTable.Rows[e.RowIndex].Cells["last_name"].FormattedValue.ToString();
                    titleTextBox.Text = booksTable.Rows[e.RowIndex].Cells["title"].FormattedValue.ToString();
                    authorTextBox.Text = booksTable.Rows[e.RowIndex].Cells["author"].FormattedValue.ToString();
                    publisherTextBox.Text = booksTable.Rows[e.RowIndex].Cells["publisher"].FormattedValue.ToString();
                    sectionTextBox.Text = booksTable.Rows[e.RowIndex].Cells["section"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
