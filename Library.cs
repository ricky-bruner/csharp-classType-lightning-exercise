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
        private List<Book> _bookList;

        public string Address { get; set; }

        public string Name { get; set; }

        public void AddToInventory (Book book) {
            _bookList.Add(book);
        }
    }
}