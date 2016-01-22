namespace MSSQL
{
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Collections;
    using System.Data;
    using System;
    using System.IO;
    using System.Collections.Generic;

    public static class NorthwindDatabase
    {
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                return connection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Persist Security Info=False; Integrated Security=SSPI;");
            }
        }

        public static void ConnectToDB()
        {            
            Connection.Open();
        }

        public static void DisconnectFromDB()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }

        public static int FindCategoriesCount()
        {
            SqlCommand cmdCount = new SqlCommand(
           "SELECT COUNT(*) FROM Categories", connection);

            int categoriesCount = (int)cmdCount.ExecuteScalar();

            return categoriesCount;
        }

        public static void DisplayAllCategories()
        {
            Console.WriteLine("--- All categories and their descriptions ---");
            SqlCommand cmdAllCategories = new SqlCommand(
              "SELECT CategoryName, Description FROM Categories", connection);
            SqlDataReader categoriesReader = cmdAllCategories.ExecuteReader();
            using (categoriesReader)
            {
                while (categoriesReader.Read())
                {
                    string categoryName = (string)categoriesReader["CategoryName"];
                    string categoryDescription = (string)categoriesReader["Description"];
                    Console.WriteLine("{0}: {1}", categoryName, categoryDescription);
                }
            }
            Console.WriteLine();
        }

        public static void DisplayAllProductsInAllCategories()
        {
            Console.WriteLine("--- All products in all categories ---");
            SqlCommand cmdAllProducts = new SqlCommand(@"
            SELECT c.CategoryName, p.ProductName
            FROM Categories c
            JOIN Products p
            ON c.CategoryID = p.CategoryID
            GROUP BY c.CategoryName, p.ProductName",
                                   connection);

            SqlDataReader productsReader = cmdAllProducts.ExecuteReader();
            var productsInCategories = new Dictionary<string, List<string>>();
            using (productsReader)
            {
                while (productsReader.Read())
                {
                    string categoryName = (string)productsReader["CategoryName"];
                    string productName = (string)productsReader["productName"];
                    if (!productsInCategories.ContainsKey(categoryName))
                    {
                        var products = new List<string>();
                        products.Add(productName);
                        productsInCategories.Add(categoryName, products);
                    }
                    else
                    {
                        productsInCategories[categoryName].Add(productName);
                    }

                }
            }

            foreach (var category in productsInCategories)
            {
                Console.WriteLine("     --- Category: {0} ---", category.Key);
                foreach (var product in productsInCategories[category.Key])
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }

        public static int InsertProduct(string name, int supplierId, int categoryId, string quantityPerUnit, decimal price, int inStock, int onOrder, int reorderLevel, bool discontinued)
        {
            SqlCommand cmdInsertProduct = new SqlCommand(@"
INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
VALUES (@name, @supplierId, @categoryId, @quantityPerUnit, @price, @inStock, @onOrder, @reorderLevel, @discontinued)",
                                                   connection);

            cmdInsertProduct.Parameters.AddWithValue("@name", name);
            cmdInsertProduct.Parameters.AddWithValue("@supplierId", supplierId);
            cmdInsertProduct.Parameters.AddWithValue("@categoryId", categoryId);
            cmdInsertProduct.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            cmdInsertProduct.Parameters.AddWithValue("@price", price);
            cmdInsertProduct.Parameters.AddWithValue("@inStock", inStock);
            cmdInsertProduct.Parameters.AddWithValue("@onOrder", onOrder);
            cmdInsertProduct.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            cmdInsertProduct.Parameters.AddWithValue("@discontinued", discontinued);

            cmdInsertProduct.ExecuteNonQuery();

            SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", connection);
            int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();

            return insertedRecordId;
        }

        public static void ExtractImagesFromCategories()
        {
            for (int i = 1; i <= NorthwindDatabase.FindCategoriesCount(); i++)
            {
                string query = string.Format("SELECT Picture, CategoryID FROM Categories WHERE CategoryID = {0}", i);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    if (reader.Read())
                    {
                        var image = (byte[])reader["Picture"];
                        var imageIndex = (int)reader["CategoryID"];
                        string filename = string.Format(@"..\..\picture_{0}.jpeg", imageIndex);
                        ImageHandler.WriteBinaryFile(filename, image);
                        Console.WriteLine("Extracted picture for CategoryID: {0} ...", imageIndex);
                    }
                    else
                    {
                        throw new Exception(
                            String.Format("Invalid image"));
                    }
                }                
            }               
        }
    }
}
