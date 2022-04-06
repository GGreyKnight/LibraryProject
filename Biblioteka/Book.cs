using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblioteka
{
    public class Book
    {
        public ulong id { get; }
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string section { get; set; }
        public ulong quantity { get; set; }
        public ulong quantity_available { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string deleted_at { get; set; }

        public Book(string title, string author, string publisher, string section, ulong quantity)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.section = section;
            this.quantity = quantity;
            this.quantity_available = quantity;
            this.created_at = DateTime.Now.ToString();
            this.updated_at = DateTime.Now.ToString();
        }

        public static void ShowBooks(DataGridView dataGridView)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            connection.Open();

            string sqlCommand = $"SELECT * FROM books WHERE deleted_at IS NULL";
            var command = new SQLiteCommand(sqlCommand, connection);

            SQLiteDataReader dataReader = command.ExecuteReader();

            dataGridView.Rows.Clear();
            while (dataReader.Read())
            {
                dataGridView.Rows.Insert(0, dataReader.GetInt64(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt64(5), dataReader.GetInt64(6), dataReader.GetString(7), dataReader.GetString(8));
            }

            connection.Close();
        }

        public static void AddBook(Book book)
        {
            if (!String.IsNullOrEmpty(book.title) && !String.IsNullOrEmpty(book.author) && !String.IsNullOrEmpty(book.publisher) && !String.IsNullOrEmpty(book.section))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);

                if (String.IsNullOrEmpty(GetBookID(book)))
                {
                    try
                    {
                        command.CommandText = "INSERT INTO books (title, author, publisher, section, quantity, quantity_available, created_at, updated_at) VALUES(@title, @author, @publisher, @section, @quantity, @quantity_available, @created_at, @updated_at)";

                        command.Parameters.AddWithValue("@title", book.title);
                        command.Parameters.AddWithValue("@author", book.author);
                        command.Parameters.AddWithValue("@publisher", book.publisher);
                        command.Parameters.AddWithValue("@section", book.section);
                        command.Parameters.AddWithValue("@quantity", book.quantity);
                        command.Parameters.AddWithValue("@quantity_available", book.quantity_available);
                        command.Parameters.AddWithValue("@created_at", book.created_at);
                        command.Parameters.AddWithValue("@updated_at", book.updated_at);

                        command.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
                else
                {
                    try
                    {
                        command.CommandText = $"UPDATE books SET updated_at=@updated_at, deleted_at=null where id=@id";
                        command.Parameters.AddWithValue("@id", GetBookID(book));
                        command.Parameters.AddWithValue("@updated_at", book.updated_at);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        return;
                    }
                    MessageBox.Show("Książka o podanych parametrach widnieje w bazie bądź właśnie została do niej przywrócona!");
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("Należy podać tytuł, autora, wydawcę oraz sekcję dodawanej książki!");
            }
        }

        public static string GetBookID(Book book)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            string sqlCommand = $"SELECT id FROM books WHERE (title=@title AND author=@author AND publisher=@publisher AND section=@section)";

            var command = new SQLiteCommand(sqlCommand, connection);

            command.Parameters.AddWithValue("@title", book.title);
            command.Parameters.AddWithValue("@author", book.author);
            command.Parameters.AddWithValue("@publisher", book.publisher);
            command.Parameters.AddWithValue("@section", book.section);

            connection.Open();

            SQLiteDataReader dataReader = command.ExecuteReader();
            string position = null;
            while (dataReader.Read())
            {
                position = dataReader[0].ToString();
            }

            connection.Close();

            return position;
        }

        public static void UpdateBook(Book book, ulong id_book)
        {
            if (!String.IsNullOrEmpty(book.title) && !String.IsNullOrEmpty(book.author) && !String.IsNullOrEmpty(book.publisher) && !String.IsNullOrEmpty(book.section))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);

                try
                {
                    command.CommandText = "UPDATE books SET title=@title, author=@author, publisher=@publisher, section=@section, quantity=@quantity, quantity_available=@quantity_available, updated_at=@updated_at WHERE id=@id";

                    command.Parameters.AddWithValue("@id", id_book);
                    command.Parameters.AddWithValue("@title", book.title);
                    command.Parameters.AddWithValue("@author", book.author);
                    command.Parameters.AddWithValue("@publisher", book.publisher);
                    command.Parameters.AddWithValue("@section", book.section);
                    command.Parameters.AddWithValue("@quantity", book.quantity);
                    command.Parameters.AddWithValue("@quantity_available", book.quantity_available);
                    command.Parameters.AddWithValue("@updated_at", book.updated_at);

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Błędne dane, książka o podanym Id nie widnieje w bazie!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Należy podać tytuł, autora, wydawcę oraz sekcję książki!");
            }
        }

        public static void DeleteBook(Book book)
        {
            if (!String.IsNullOrEmpty(book.title) && !String.IsNullOrEmpty(book.author) && !String.IsNullOrEmpty(book.publisher) && !String.IsNullOrEmpty(book.section))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);

                try
                {
                    /*instead of deleting, we ad delete_at value
                    delete would look like:
                    command.CommandText = $"DELETE FROM books where id={id_book}";
                    but this can ruin our database if we delete member who has book actually*/
                    command.CommandText = $"UPDATE books SET updated_at=@updated_at, deleted_at=@deleted_at WHERE id=@id";
                    command.Parameters.AddWithValue("@id", GetBookID(book));
                    command.Parameters.AddWithValue("@deleted_at", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString());
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Należy podać tytuł, autora, wydawcę oraz sekcję książki w celu jej usunięcia!");
            }
        }

        public static void SearchBooks(DataGridView dataGridView, string keyword)
        {
            if (!String.IsNullOrEmpty(keyword))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);

                keyword = string.Format($"'%{keyword}%'");
                string sqlCommand = $"SELECT * FROM books WHERE title LIKE {keyword} OR author LIKE {keyword} OR publisher LIKE {keyword} OR section LIKE {keyword} ORDER BY id ASC";
                var command = new SQLiteCommand(sqlCommand, connection);

                connection.Open();

                SQLiteDataReader dataReader = command.ExecuteReader();

                dataGridView.Rows.Clear();
                while (dataReader.Read())
                {
                    dataGridView.Rows.Insert(0, dataReader.GetInt64(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt64(5), dataReader.GetInt64(6), dataReader.GetString(7), dataReader.GetString(8));
                }

                connection.Close();
            }
            else
            {
                ShowBooks(dataGridView);
            }
        }

        public static ulong BooksLeftInLibrary(Book book)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            string sqlCommand = $"SELECT quantity_available FROM books WHERE id=@id";

            var command = new SQLiteCommand(sqlCommand, connection);

            command.Parameters.AddWithValue("@id", GetBookID(book));

            connection.Open();

            SQLiteDataReader dataReader = command.ExecuteReader();
            ulong booksLeft = 0;
            while (dataReader.Read())
            {
                booksLeft = Convert.ToUInt64(dataReader[0].ToString());
            }

            connection.Close();

            return booksLeft;
        }

        public static ulong BooksLeftInLibrary(string book_id)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            string sqlCommand = $"SELECT quantity_available FROM books WHERE id=@id";

            var command = new SQLiteCommand(sqlCommand, connection);

            command.Parameters.AddWithValue("@id", book_id);

            connection.Open();

            SQLiteDataReader dataReader = command.ExecuteReader();
            ulong booksLeft = 0;
            while (dataReader.Read())
            {
                booksLeft = Convert.ToUInt64(dataReader[0].ToString());
            }

            connection.Close();

            return booksLeft;
        }

        public static ulong BooksTotalNumber(string book_id)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            string sqlCommand = $"SELECT quantity FROM books WHERE id=@id";

            var command = new SQLiteCommand(sqlCommand, connection);

            command.Parameters.AddWithValue("@id", book_id);

            connection.Open();

            SQLiteDataReader dataReader = command.ExecuteReader();
            ulong booksTotalNumber = 0;
            while (dataReader.Read())
            {
                booksTotalNumber = Convert.ToUInt64(dataReader[0].ToString());
            }

            connection.Close();

            return booksTotalNumber;
        }

        public static void ShowBooksAvaiilableNow(DataGridView dataGridView)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            connection.Open();

            string sqlCommand = $"SELECT * FROM books where (deleted_at IS NULL AND quantity_available > 0)";
            var command = new SQLiteCommand(sqlCommand, connection);

            SQLiteDataReader dataReader = command.ExecuteReader();

            dataGridView.Rows.Clear();
            while (dataReader.Read())
            {
                dataGridView.Rows.Insert(0, dataReader.GetInt64(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt64(5), dataReader.GetInt64(6), dataReader.GetString(7), dataReader.GetString(8));
            }

            connection.Close();
        }

        public static void TakeBookFromLibrary(Book book)
        {
            if(BooksLeftInLibrary(book) > 0)
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);

                try
                {
                    command.CommandText = $"UPDATE books SET quantity_available = quantity_available - 1, updated_at=@updated_at WHERE id=@id";
                    command.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@id", GetBookID(book));
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Wszystkie egzemplarze wybranej pozycji są aktualnie niedostępne!");
            }
        }

        public static void ReturnBookToLibrary(string book_id)
        {
            if(!String.IsNullOrEmpty(book_id) && (BooksLeftInLibrary(book_id) < BooksTotalNumber(book_id)))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);

                try
                {
                    command.CommandText = $"UPDATE books SET quantity_available = quantity_available + 1, updated_at=@updated_at WHERE id=@id";
                    command.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@id", book_id);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Takie wypożyczenie nie istnieje, zwrot niemożliwy do wykonania!");
            }
            
        }
    }
}
