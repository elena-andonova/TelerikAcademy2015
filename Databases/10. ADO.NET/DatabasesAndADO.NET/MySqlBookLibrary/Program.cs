namespace MySqlBookLibrary
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var sqlDB = new MySqlHandler();
            sqlDB.Connect();
            var allBooks = sqlDB.GetAllBooks();
            foreach (var book in allBooks)
            {
                Console.WriteLine("Title:{0}", book["Title"]);
                Console.WriteLine("Author:{0}", book["Author"]);
                Console.WriteLine("Date:{0}", book["PublishDate"]);
                Console.WriteLine("ISBN:{0}", book["ISBN"]);
                Console.WriteLine("========================================");
            }
            Console.WriteLine();

            sqlDB.Insert("Book Four", "NoOne", DateTime.Now, "123-123");

            string bookToFind = "Book One";
            sqlDB.FindBookByName(bookToFind);
        }
    }
}
