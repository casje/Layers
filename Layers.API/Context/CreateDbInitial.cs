using System;
using System.Linq;
using System.Collections.Generic;
using Layers.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Layers.API.Context
{
    public class CreateDbInitial
    {
        public static void GenerateData()
        {
            var options = new DbContextOptionsBuilder<LayersDbContext>()
                                .UseInMemoryDatabase(databaseName: "LayersDB")
                                .Options;

            List<Book> listBooks = GenerateListBooks();

            using (var context = new LayersDbContext(options))
            {
                listBooks.ForEach(book => context.Books.Add(book));
                context.SaveChanges();
            }
        }

        private static List<Book> GenerateListBooks()
        {
            List<Book> listBooks = new List<Book>()
            {
                new Book() { Title = "Patterns Microservices", ISBN = "132-718728-23", YearPublication = "Q1 2019" },
                new Book() { Title = "Learning .Net Core", ISBN = "121-986377-09", YearPublication = "Q3 2018" },
                new Book() { Title = "Angular Essencial", ISBN = "998-092537-42", YearPublication = "Q3 2017" },
                new Book() { Title = "Mastering React", ISBN = "624-292638-54", YearPublication = "Q2 2019" },
                new Book() { Title = "Kubernetes Up and Running", ISBN = "273-725366-21", YearPublication = "Q1 2019" },
                new Book() { Title = "Node in Action", ISBN = "232-654345-09", YearPublication = "Q4 2018"}
            };

            return listBooks;
        }

    }
}