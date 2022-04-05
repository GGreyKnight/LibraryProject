using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Biblioteka
{
    public static class ConnectionString
    {
        public static string connectionString;// = @"Data Source=.\libraryDB.db;Version=3";

        public static void setConnectionString(string myConnectionString)
        {
            connectionString = myConnectionString;
        }
    }

    public class Member
    {
        public int id { get; }
        public ulong pesel_number { get; set; }
        public string position_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string deleted_at { get; set; }

        public Member(ulong pesel_number, string position_name, string first_name, string last_name)
        {
            this.pesel_number = pesel_number;
            this.position_name = CheckPositionName(position_name);
            this.first_name = first_name;
            this.last_name = last_name;
            this.created_at = DateTime.Now.ToString();
            this.updated_at = DateTime.Now.ToString();
        }

        private string CheckPositionName(string positionName)
        {
            if(positionName!="Student" && positionName != "Wykładowca" && positionName != "Pracownik")
            {
                return "Student";
            }
            else
            {
                return positionName;
            }
        }

        public static void ShowMembers(DataGridView dataGridView)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            connection.Open();

            string sqlCommand = "SELECT * FROM members";
            var command = new SQLiteCommand(sqlCommand, connection);

            SQLiteDataReader dataReader = command.ExecuteReader();

            dataGridView.Rows.Clear();
            while (dataReader.Read())
            {
                dataGridView.Rows.Insert(0 ,dataReader.GetInt64(0), dataReader.GetInt64(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6));
            }

            connection.Close();
        }

        public static void AddMember(Member member)
        {

            if(!String.IsNullOrEmpty(member.first_name) && !String.IsNullOrEmpty(member.last_name))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);

                try
                {
                    command.CommandText = "INSERT INTO members(PESEL, position_name, first_name, last_name, created_at, updated_at) VALUES(@PESEL, @position_name, @first_name, @last_name, @created_at, @updated_at)";

                    command.Parameters.AddWithValue("@PESEL", member.pesel_number);
                    command.Parameters.AddWithValue("@position_name", member.position_name);
                    command.Parameters.AddWithValue("@first_name", member.first_name);
                    command.Parameters.AddWithValue("@last_name", member.last_name);
                    command.Parameters.AddWithValue("@created_at", member.created_at);
                    command.Parameters.AddWithValue("@updated_at", member.updated_at);

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Użytkownik o podanym numerze PESEL widnieje w bazie!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Należy podać imię oraz nazwisko użytkownika!");
            }
        }

        public static void UpdateMember(Member member)
        {
            

            if (!String.IsNullOrEmpty(member.first_name) && !String.IsNullOrEmpty(member.last_name))
            {
                var connection = new SQLiteConnection(ConnectionString.connectionString);
                connection.Open();

                var command = new SQLiteCommand(connection);

                try
                {
                    command.CommandText = "UPDATE members SET position_name=@position_name, first_name=@first_name, last_name=@last_name, updated_at=@updated_at where PESEL=@PESEL";
                    //command.Prepare();

                    switch (CheckPosition(member))
                    {
                        case "Student":
                            command.Parameters.AddWithValue("@position_name", member.position_name);
                            break;
                        case "Wykładowca":
                            if (member.position_name == "Wykładowca" || member.position_name == "Pracownik") { command.Parameters.AddWithValue("@position_name", member.position_name); }
                            break;
                        case "Pracownik":
                            if (member.position_name == "Pracownik") { command.Parameters.AddWithValue("@position_name", member.position_name); }
                            break;
                    }


                    command.Parameters.AddWithValue("@first_name", member.first_name);
                    command.Parameters.AddWithValue("@last_name", member.last_name);
                    command.Parameters.AddWithValue("@PESEL", member.pesel_number);
                    command.Parameters.AddWithValue("@updated_at", member.updated_at);

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception)
                {
                    if(String.IsNullOrEmpty(CheckPosition(member)))
                    {
                        MessageBox.Show($"Błędne dane, osoba o podanym numerze PESEL nie widnieje w bazie!");
                    }
                    else
                    {
                        MessageBox.Show($"Błędne dane, nie można zmienić roli wybranej osoby! Obecna rola: {CheckPosition(member)}");
                    }
                    return;
                }

            }
            else
            {
                MessageBox.Show("Należy podać imię oraz nazwisko użytkownika!");
            }

                
        }

        private static string CheckPosition(Member member)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            string sqlCommand = $"SELECT position_name FROM members where PESEL={member.pesel_number}";
            var command = new SQLiteCommand(sqlCommand, connection);

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

        public static void DeleteMember(Member member)
        {
            var connection = new SQLiteConnection(ConnectionString.connectionString);
            connection.Open();

            var command = new SQLiteCommand(connection);

            try
            {
                command.CommandText = $"DELETE FROM members where PESEL={member.pesel_number}";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Podany numer PESEL nie widnieje w bazie, żaden rekord nie został usunięty!");
                return;
            }
        }
    }
}