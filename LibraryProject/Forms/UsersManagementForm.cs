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
    public partial class UsersManagementForm : Form
    {
        public UsersManagementForm()
        {
            InitializeComponent();
        }

        private void UsersManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.menuFormCaller.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm.menuFormCaller.Show();
        }

        private void UsersManagementForm_Load(object sender, EventArgs e)
        {
            Member.ShowMembers(usersTable);
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = new Member(Convert.ToUInt64(peselTextBox.Text), positionComboBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
                Member.AddMember(newMember);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane! Proszę uzupełnić PESEL użytkownika.");
            }
            Member.ShowMembers(usersTable);
        }

        private void updateMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = new Member(Convert.ToUInt64(peselTextBox.Text), positionComboBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
                Member.UpdateMember(newMember);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane! Proszę uzupełnić PESEL użytkownika.");
            }
            Member.ShowMembers(usersTable);
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = new Member(Convert.ToUInt64(peselTextBox.Text), positionComboBox.Text, firstNameTextBox.Text, lastNameTextBox.Text);
                Member.DeleteMember(newMember);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane! Proszę uzupełnić PESEL użytkownika.");
            }
            Member.ShowMembers(usersTable);
        }

        private void selectMember(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (usersTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    usersTable.CurrentRow.Selected = true;
                    peselTextBox.Text = usersTable.Rows[e.RowIndex].Cells["pesel"].FormattedValue.ToString();
                    positionComboBox.Text = usersTable.Rows[e.RowIndex].Cells["id_position"].FormattedValue.ToString();
                    firstNameTextBox.Text = usersTable.Rows[e.RowIndex].Cells["first_name"].FormattedValue.ToString();
                    lastNameTextBox.Text = usersTable.Rows[e.RowIndex].Cells["last_name"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
