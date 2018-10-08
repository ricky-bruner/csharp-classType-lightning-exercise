using System;
using System.Collections.Generic;

namespace Library
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //  Create a few (4 or so) instances of books and use the method on your Library class to add them to the list of books in an instance of Library

            Book book1 = new Book();
            book1.Title = "Harry Potter and the Prisoner of Azkaban";
            book1.Author = "J.K. Rowling";
            book1.ISBN = "9780439136358";

            Book book2 = new Book();
            book1.Title = "Harry Potter and the Goblet of Fire";
            book1.Author = "J.K. Rowling";
            book1.ISBN = "0439139597";

            Book book3 = new Book();
            book1.Title = "Harry Potter and the Order of the Phoenix";
            book1.Author = "J.K. Rowling";
            book1.ISBN = "9780439358064";
            
            Book book4 = new Book();
            book1.Title = "Harry Potter and the Half-Blood Prince";
            book1.Author = "J.K. Rowling";
            book1.ISBN = "0439784549";

            Book book5 = new Book();
            book1.Title = "Harry Potter and the Deathly Hallows";
            book1.Author = "J.K. Rowling";
            book1.ISBN = "043978454912234";

            Book book6 = new Book();
            book1.Title = "Harry Potter and the Chamber of Secrets";
            book1.Author = "J.K. Rowling";
            book1.ISBN = "0439784549907865832";

            List<Book> books = new List<Book>(){
                book5, book6
            };

            Library potterBooks = new Library(books, "My Harry Potter Books", "My Home!");
            

            potterBooks.AddToInventory(book1);
            potterBooks.AddToInventory(book2);
            potterBooks.AddToInventory(book3);
            potterBooks.AddToInventory(book4);

            // foreach (Book book in potterBooks){
            //     Console.WriteLine($"This book is {book.Title} by {book.Author}!")
            // }
            
        }
    }
}
