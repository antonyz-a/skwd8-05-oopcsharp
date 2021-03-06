﻿using SEDC.LibraryApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.LibraryApp.Services
{
    public class BookService
    {
        public Book[] Books { get; set; }

        public BookService()
        {
            Books = new Book[]
            {
                new Book()
                {
                    Author = "Bob",
                    Genre = "Novel",
                    Pages = 200,
                    Title = "Harry Potter and the goblet of fire"
                },
                new Book()
                {
                    Author = "John",
                    Genre = "Comic Book",
                    Pages = 100,
                    Title = "Spiderman"
                },
                new Book()
                {
                    Author = "Jack",
                    Genre = "Adventure",
                    Pages = 500,
                    Title = "Star Wars"
                }
            };
        }

        public void PrintAllBooks()
        {
            if(Books.Length == 0)
            {
                Console.WriteLine("There are no books yet :(");
                return;
            }
            foreach (Book book in Books)
            {
                Console.WriteLine(book.BookInfo());
            }
        }

        
    }
}
