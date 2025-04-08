using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectLab.Models
{
    public class Library
    {
        public Library(string name)
        {
            Name = name;
            Book[] books = new Book[0];
        }

        public string Name { get; set; }
        public Book[] Books;

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
            Console.WriteLine($"{book.Name} added successfully!");
        }
        public Book GetBookById(int id)
        {
            foreach (Book book in Books)
            {
                if (book.Id == id)
                    return book;
            }
            return null;
        }
        public void RemoveBookById(int id)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Id == id)
                {
                    Book lastBook = Books[Books.Length - 1];
                    Books[Books.Length - 1] = Books[i];
                    Books[i] = lastBook;
                    Array.Resize(ref Books, Books.Length - 1);
                    Console.WriteLine($"{Books[i].Name} removed!");
                }
            }
        }
        public Book[] GetBook(string name)
        {
            Book[] books = new Book[0];
            foreach (Book book in Books)
            {
                if (book.Name.ToUpper() == name.ToUpper())
                {
                    Array.Resize(ref books, books.Length + 1);
                    books[^1] = book;
                }
            }

            return books;
        }
        public void GetAllBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        public void Update(int id, Book userBook)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Id == id)
                {
                    Books[i] = userBook;
                    Console.WriteLine($"{Books[i].Name} was updated by {userBook}");
                }
            }
        }
    }
}
