using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblioteka
{
    public class BorrowBook
    {
        public ulong id_member { get; }
        public ulong id_book { get; }
        public string create_datetime { get; set; }
        public string return_datetime { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string deleted_at { get; set; }

        public BorrowBook(ulong id_member, ulong id_book, string create_datetime, string return_datetime)
        {
            this.id_member = id_member;
            this.id_book = id_book;
            this.create_datetime = create_datetime;
            this.return_datetime = return_datetime;
            this.created_at = DateTime.Now.ToString();
            this.updated_at = DateTime.Now.ToString();
        }

        public static void ShowBooksBorrow(DataGridView dataGridView)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            connection.Open();

            string sqlCommand = $"SELECT members_books.id_member, members_books.id_book, members.position_name, members.first_name, members.last_name, books.title, books.author, members_books.create_datetime, members_books.return_datetime FROM members_books LEFT JOIN members ON members_books.id_member = members.id LEFT JOIN books ON members_books.id_book = books.id where members_books.deleted_at IS NULL;";
            var command = new SQLiteCommand(sqlCommand, connection);

            SQLiteDataReader dataReader = command.ExecuteReader();

            dataGridView.Rows.Clear();
            while (dataReader.Read())
            {
                dataGridView.Rows.Insert(0, dataReader.GetInt64(0), dataReader.GetInt64(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8));
            }

            connection.Close();
        }

        public static void AddBorrowBook(Member member, Book book, DateTimePicker dateTimePickerFrom, DateTimePicker dateTimePickerTo)
        {
            if(!String.IsNullOrEmpty(Member.GetMemberID(member)) && !String.IsNullOrEmpty(Book.GetBookID(book)))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);
                ulong member_id = Convert.ToUInt64(Member.GetMemberID(member));
                ulong book_id = Convert.ToUInt64(Book.GetBookID(book));

                try
                {
                    command.CommandText = "INSERT INTO members_books(id_member, id_book, create_datetime, return_datetime, created_at, updated_at) VALUES(@id_member, @id_book, @create_datetime, @return_datetime, @created_at, @updated_at)";

                    command.Parameters.AddWithValue("@id_member", member_id);
                    command.Parameters.AddWithValue("@id_book", book_id);
                    command.Parameters.AddWithValue("@create_datetime", dateTimePickerFrom.Value.ToString());
                    command.Parameters.AddWithValue("@return_datetime", dateTimePickerTo.Value.ToString());
                    command.Parameters.AddWithValue("@created_at", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString());

                    command.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    return;
                }
                
                connection.Close();
            }
            else
            {
                MessageBox.Show("Niepełne dane! Proszę wskazać osobę i książkę w celu wyporzyczenia.");
            }
        }
    }
}

