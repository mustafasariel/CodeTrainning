using Dapper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Z.Dapper.Plus;
using System.Linq;
using DapperDemo1.Entity;
using System.Diagnostics;

namespace DapperDemo1
{
    class Program
    {
        static string connStr = @"Server=msariel\SQLEXPRESS;Database=DapperDemo;Integrated security=true;";
        static void Main(string[] args)
        {
            // demo1();


            BulkInsertDemo2();
        }

        private static void BulkInsertDemo2()
        {
            var lst = GetCategories(100000);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BulkInsertDemo(lst);


            stopwatch.Stop();
            Console.WriteLine($"Total Second = {stopwatch.Elapsed.TotalSeconds}");


            Console.ReadLine();
        }

        private static void demo1()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                sqlConnection.Open();
                string strQuery = "insert into Categories(CategoryName) values(@CategoryName)";

                sqlConnection.Execute
                (
                    strQuery, new object[]
                    {
                        new { CategoryName = "Programlama" }
                    }
                );

                sqlConnection.Execute(strQuery, new Category() { CategoryName = "Web Programlama" });
                sqlConnection.Close();
            }
        }

        static void BulkInsertDemo(List<Category> categories)
        {
            DapperPlusManager.Entity<Category>().Table("Categories");

            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                sqlConnection.BulkInsert(categories);
            }
        }

        static List<Category> GetCategories(int count)
        {
            List<Category> categories = new List<Category>();

            for (int i = 0; i < count; i++)
            {
                categories.Add(new Category() { CategoryName = $"Category{i}" });
            }

            return categories;
        }
    }
}
