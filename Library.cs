using System;
using System.Collections.Generic;

namespace Library
{

//     Make a Library class that has:
// - Private List of Books (remember casing and naming convention here)
// - Public Method to add a Book to the List of Books
// - Public Address property
// - Public Name property
    public class Library 
    {
        // constructor has to have the same name as the class, and DOES NOT have a return type
        public Library(List<Book> initialInventory, string name, string address)
        {
            _bookList = initialInventory;
            Name = name;
            Address = address;
        }
        private List<Book> _bookList;

        public string Address { get; set; }

        public string Name { get; set; }

        public void AddToInventory (Book book) {
            _bookList.Add(book);
        }

        public void Checkout(string isbn, CardHolder cardHolder)
        {
            foreach(Book book in _bookList)
            {
                if(book.ISBN == isbn && book.IsAvailable)
                {
                    cardHolder.CheckoutBook(book);
                    book.IsAvailable = false;
                }
            }
        }

        public bool IsAvailable(string isbn){
            // bool isAvailable = false;
            foreach(Book book in _bookList)
            {
                if(book.ISBN == isbn)
                {
                    return book.IsAvailable;
                    // isAvailable = book.IsAvailable;
                }
            }
            // return isAvailable;
            return false;
        }

    }
}