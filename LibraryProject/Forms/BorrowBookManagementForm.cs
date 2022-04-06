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
            Book.ShowBooksAvaiilableNow(booksTable);
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
                MessageBox.Show("Niepełne dane! Proszę wybrać osobę i książkę w celu wypożyczenia.");
                return;
            }

            BorrowBook.ShowBooksBorrow(borrowsTable);
            Book.ShowBooksAvaiilableNow(booksTable);
        }

        private void clearTextBoxes(List<TextBox> textBoxes)
        {
            foreach(TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        private void selectBooksBorrows(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (borrowsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    borrowsTable.CurrentRow.Selected = true;
                    borrowMemberIdTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["id_member"].FormattedValue.ToString();
                    borrowBookIdTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["id_book"].FormattedValue.ToString();
                    borrowMemberPositionTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["position_member"].FormattedValue.ToString();
                    borrowMemberFirstNameTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["first_name_member"].FormattedValue.ToString();
                    borrowMemberLastNameTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["last_name_member"].FormattedValue.ToString();
                    borrowBookTitleTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["title_book"].FormattedValue.ToString();
                    borrowBookAuthorTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["author_book"].FormattedValue.ToString();
                    borrowDateFromTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["borrow_date"].FormattedValue.ToString();
                    borrowDateToTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["return_date"].FormattedValue.ToString();
                    borrowDateCreatedTextBox.Text = borrowsTable.Rows[e.RowIndex].Cells["created_at"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                BorrowBook.DeleteBorrowBook(borrowMemberIdTextBox.Text, borrowBookIdTextBox.Text, borrowDateCreatedTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niepełne dane! Proszę wybrać wypożyczenie do zwrotu z tabeli wypożyczeń.");
                return;
            }
            clearTextBoxes(new List<TextBox> { borrowMemberIdTextBox, borrowBookIdTextBox, borrowMemberPositionTextBox, borrowMemberFirstNameTextBox, borrowMemberLastNameTextBox, borrowBookTitleTextBox, borrowBookAuthorTextBox, borrowDateFromTextBox, borrowDateToTextBox, borrowDateCreatedTextBox });
            BorrowBook.ShowBooksBorrow(borrowsTable);
            Book.ShowBooksAvaiilableNow(booksTable);
        }

        private void calculatePenaltyButton_Click(object sender, EventArgs e)
        {
            try
            {
                penaltyTextBox.Text = BorrowBook.CalculatePenaltyForSelectedBorrow(borrowMemberIdTextBox.Text, borrowBookIdTextBox.Text, borrowDateCreatedTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niepełne dane! Proszę wybrać wypożyczenie do zwrotu z tabeli wypożyczeń.");
                return;
            }
        }
    }
}
