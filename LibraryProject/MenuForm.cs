using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class MenuForm : Form
    {
        public static MenuForm menuFormCaller;

        public MenuForm()
        {
            InitializeComponent();
            menuFormCaller = this;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_UserManagement_Click(object sender, EventArgs e)
        {
            UsersManagementForm usersManagementForm = new UsersManagementForm();
            this.Hide();
            usersManagementForm.Show();
        }

        private void BooksManagement_Click(object sender, EventArgs e)
        {
            BooksManagementForm booksManagementForm = new BooksManagementForm();
            this.Hide();
            booksManagementForm.Show();
        }

        private void BorrowBookManagement_Click(object sender, EventArgs e)
        {
            BorrowBookManagementForm borrowBookManagementForm = new BorrowBookManagementForm();
            this.Hide();
            borrowBookManagementForm.Show();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
