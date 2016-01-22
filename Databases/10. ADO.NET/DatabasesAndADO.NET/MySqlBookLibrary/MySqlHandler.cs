namespace MySqlBookLibrary
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MySqlHandler
    {
        private MySqlConnection connection;

        public void Connect()
        {
            this.Initialize();
        }
        private void Initialize()
        {
            connection = new MySqlConnection("Server=localhost; Port=3306; Database=BooksStore; Uid=root; Pwd=mysql; pooling=true");
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Insert(string title, string author, DateTime time, string isbn)
        {
            string query = @"INSERT INTO Books (Title, Author, PublishDate, ISBN) 
                            VALUES(@Title, @Author, @PublishDate, @ISBN)";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);                
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@PublishDate", time);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.ExecuteNonQuery();
                
                this.CloseConnection();
            }

            Console.WriteLine("New book was inserted..");
            Console.WriteLine();
        }

        public List<Dictionary<string, string>> GetAllBooks()
        {
            string query = "SELECT * FROM books";

            var bookList = new List<Dictionary<string, string>>() { };
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentBook = new Dictionary<string, string>() { };
                    currentBook["Title"] = (string)dataReader["Title"];
                    currentBook["Author"] = (string)dataReader["Author"];
                    currentBook["PublishDate"] = ((DateTime)dataReader["PublishDate"]).ToString();
                    currentBook["ISBN"] = (string)dataReader["ISBN"];
                    bookList.Add(currentBook);
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return bookList;
        }


        public void FindBookByName(string name)
        {
            string query = @"SELECT * FROM booksstore.books WHERE books.title=""" + name + @"""";
            bool bookFound = false;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    bookFound = true;
                }
                dataReader.Close();
                this.CloseConnection();
            }

            if (bookFound)
            {
                Console.WriteLine("{0} was found.", name);
            }
            else
            {
                Console.WriteLine("{0} was NOT found.", name);
            }
            Console.WriteLine();
        }
    }
}
