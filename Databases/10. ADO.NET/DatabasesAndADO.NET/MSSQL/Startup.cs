namespace MSSQL
{
    using System;

    class Startup
    {
        static void Main()
        {           
            try
            {
                NorthwindDatabase.ConnectToDB();

                //1) Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
                int categoriesCount = NorthwindDatabase.FindCategoriesCount();
                Console.WriteLine("Categories count: {0} ", categoriesCount);
                Console.WriteLine();

                //2) Write a program that retrieves the name and description of all categories in the Northwind DB.
                NorthwindDatabase.DisplayAllCategories();

                //3) Write a program that retrieves from the Northwind database all product categories and the names of the products in each category.
                NorthwindDatabase.DisplayAllProductsInAllCategories();

                //4) Write a method that adds a new product in the products table in the Northwind database.
                //Use a parameterized SQL command.
                int newProductId = NorthwindDatabase.InsertProduct("Black Tea", 1, 1, "some quantity", 5.0M, 10, 3, 0, false);
                Console.WriteLine("Inserted new product. " + "ProductID = {0}", newProductId);

                //5) Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.
                NorthwindDatabase.ExtractImagesFromCategories();
            }
            finally
            {
                NorthwindDatabase.DisconnectFromDB();
            }
        }       
    }
}