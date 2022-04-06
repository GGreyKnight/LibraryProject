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

            string sqlCommand = $"SELECT members_books.id_member, members_books.id_book, members.position_name, members.first_name, members.last_name, books.title, books.author, members_books.create_datetime, members_books.return_datetime, members_books.created_at FROM members_books LEFT JOIN members ON members_books.id_member = members.id LEFT JOIN books ON members_books.id_book = books.id WHERE members_books.deleted_at IS NULL ORDER BY members_books.return_datetime;";
            var command = new SQLiteCommand(sqlCommand, connection);

            SQLiteDataReader dataReader = command.ExecuteReader();

            dataGridView.Rows.Clear();
            while (dataReader.Read())
            {
                dataGridView.Rows.Insert(0, dataReader.GetInt64(0), dataReader.GetInt64(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6), dataReader.GetString(7), dataReader.GetString(8), dataReader.GetString(9));
            }

            connection.Close();
        }

        public static void AddBorrowBook(Member member, Book book, DateTimePicker dateTimePickerFrom, DateTimePicker dateTimePickerTo)
        {
            if (dateTimePickerFrom.Value.Date < dateTimePickerTo.Value.Date)
            {
                if (!String.IsNullOrEmpty(Member.GetMemberID(member)) && !String.IsNullOrEmpty(Book.GetBookID(book)) && (Book.BooksLeftInLibrary(book) > 0))
                {
                    var connection = new SQLiteConnection(ConnectionString.connectionString);
                    connection.Open();

                    var command = new SQLiteCommand(connection);

                    try
                    {
                        command.CommandText = "INSERT INTO members_books(id_member, id_book, create_datetime, return_datetime, created_at, updated_at) VALUES(@id_member, @id_book, @create_datetime, @return_datetime, @created_at, @updated_at)";

                        command.Parameters.AddWithValue("@id_member", Member.GetMemberID(member));
                        command.Parameters.AddWithValue("@id_book", Book.GetBookID(book));
                        command.Parameters.AddWithValue("@create_datetime", dateTimePickerFrom.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@return_datetime", dateTimePickerTo.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@created_at", DateTime.Now.ToString());
                        command.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString());

                        command.ExecuteNonQuery();
                        Book.TakeBookFromLibrary(book);
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Niepełne dane! Proszę wskazać osobę i książkę w celu wypożyczenia.");
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane! Data zwrotu książki musi być późniejsza niż data wypożyczenia.");
            }

        }

        public static bool CheckIfBorrowWasNotDeleted(string member_id, string book_id, string created_at)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            string sqlCommand = $"SELECT deleted_at FROM members_books WHERE (id_member=@id_member AND id_book=@id_book AND created_at=@created_at)";

            var command = new SQLiteCommand(sqlCommand, connection);

            command.Parameters.AddWithValue("@id_member", member_id);
            command.Parameters.AddWithValue("@id_book", book_id);
            command.Parameters.AddWithValue("@created_at", created_at);

            connection.Open();

            SQLiteDataReader dataReader = command.ExecuteReader();
            string isDeleted = string.Empty;
            while (dataReader.Read())
            {
                isDeleted = dataReader[0].ToString();
            }

            connection.Close();

            bool deleted = String.IsNullOrEmpty(isDeleted);

            return deleted;
        }

        public static void DeleteBorrowBook(string member_id, string book_id, string created_at)
        {
            if (!String.IsNullOrEmpty(member_id) && !String.IsNullOrEmpty(book_id) && !String.IsNullOrEmpty(created_at) && CheckIfBorrowWasNotDeleted(member_id, book_id, created_at))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);

                try
                {
                    /*instead of deleting, we ad delete_at value*/
                    command.CommandText = $"UPDATE members_books SET updated_at=@updated_at, deleted_at=@deleted_at WHERE (id_member=@id_member AND id_book=@id_book AND created_at=@created_at)";
                    //command.CommandText = $"DELETE FROM members_books WHERE id_member=@id_member AND id_book=@id_book AND created_at=@created_at";
                    command.Parameters.AddWithValue("@deleted_at", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@id_member", member_id);
                    command.Parameters.AddWithValue("@id_book", book_id);
                    command.Parameters.AddWithValue("@created_at", created_at);
                    command.ExecuteNonQuery();

                    Book.ReturnBookToLibrary(book_id);
                }
                catch (Exception)
                {
                    MessageBox.Show("Podane wypożyczenie nie widnieje w bazie, żaden rekord nie został usunięty!");
                    return;
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("Aby zwrócić książkę należy wybrać interesujące nas wypożyczenie!");
            }
        }

        public static string GetBorrowReturnDay(string member_id, string book_id, string created_at)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            string sqlCommand = $"SELECT return_datetime FROM members_books WHERE (id_member=@id_member AND id_book=@id_book AND created_at=@created_at)";

            var command = new SQLiteCommand(sqlCommand, connection);

            command.Parameters.AddWithValue("@id_member", member_id);
            command.Parameters.AddWithValue("@id_book", book_id);
            command.Parameters.AddWithValue("@created_at", created_at);

            connection.Open();

            SQLiteDataReader dataReader = command.ExecuteReader();
            string returnDay = string.Empty;
            while (dataReader.Read())
            {
                returnDay = dataReader[0].ToString();
            }

            connection.Close();

            return returnDay;
        }

        public static string CalculatePenaltyForSelectedBorrow(string member_id, string book_id, string created_at)
        {
            double penalty = 0;

            if (!String.IsNullOrEmpty(member_id) && !String.IsNullOrEmpty(book_id) && !String.IsNullOrEmpty(created_at))
            {
                double difference = (DateTime.Now - Convert.ToDateTime(GetBorrowReturnDay(member_id, book_id, created_at))).TotalDays;
                difference = Math.Ceiling(difference);

                if (difference >= 0)
                {
                    string positionMember = Member.CheckPosition(member_id);
                    
                    var connection = new SQLiteConnection(ConnectionString.connectionString);
                    connection.Open();

                    string sqlCommand = $"SELECT penalty_up_to_3_days, penalty_up_to_7_days, penalty_up_to_14_days, penalty_up_to_28_days, penalty_over_28_days FROM positions WHERE name = @name";
                    var command = new SQLiteCommand(sqlCommand, connection);
                    command.Parameters.AddWithValue("@name", positionMember);

                    List<string> temporaryData = new List<string>();
                    SQLiteDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string data1 = dataReader[0].ToString();
                        string data2 = dataReader[1].ToString();
                        string data3 = dataReader[2].ToString();
                        string data4 = dataReader[3].ToString();
                        string data5 = dataReader[4].ToString();
                        temporaryData.Add(data1);
                        temporaryData.Add(data2);
                        temporaryData.Add(data3);
                        temporaryData.Add(data4);
                        temporaryData.Add(data5);
                    }

                    connection.Close();

                    for (double i = 0; i < difference; i++)
                    {
                        if (i < 3)
                        {
                            penalty += Convert.ToDouble(temporaryData[0]);
                        }
                        
                        if (i >= 3 && i < 7)
                        {
                            penalty += Convert.ToDouble(temporaryData[1]);
                        }

                        if (i >= 7 && i < 14)
                        {
                            penalty += Convert.ToDouble(temporaryData[2]);
                        }

                        if (i >= 14 && i < 28)
                        {
                            penalty += Convert.ToDouble(temporaryData[3]);
                        }

                        if (i >= 28)
                        {
                            penalty += Convert.ToDouble(temporaryData[4]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Osoba ma jeszcze czas aby zwrócić książkę.");
                }
            }
            else
            {
                MessageBox.Show("Należy wybrać interesujące nas wypożyczenie, aby obliczyć dla niego karę.");
            }

            return penalty.ToString();
        }
    }
}

