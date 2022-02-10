using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a class library with BookRepository class and add methods like AddBook, DisplayBooks.
// Add reference of this class library in windows form application and call methods appropriately.
// Convert the windows forms application ( of emp management system) to use class library

namespace BookDll
{
    public enum Genre
    {
        Fantasy,
        SciFi,
        Mystery,
        Thriller,
        Romance,
        Horror,
        Childrens,
        NonFiction
    }

    public class BookRepository
    {
        private List<Book> booksList;

        public BookRepository()
        {
            booksList = new List<Book>() 
            { 
                new Book() { ISBN = "0-553-10354-7", Title = "A Game of Thrones", Author = "George R. R. Martin", Genre = 0, PublishedDate = new DateTime(1996,8,1) },
                new Book() { ISBN = "0-553-10803-4", Title = "A Clash of Kings", Author = "George R. R. Martin", Genre = 0, PublishedDate = new DateTime(1998,11,16) },
                new Book() { ISBN = "0-553-10663-5", Title = "A Storm of Swords", Author = "George R. R. Martin", Genre = 0, PublishedDate = new DateTime(2000,8,8)},
                new Book() { ISBN = "0-553-80150-3", Title = "A Feast for Crows", Author = "George R. R. Martin", Genre = 0, PublishedDate = new DateTime(2005,11,8)},
                new Book() { ISBN = "0-553-10230-1", Title = "A Dance with Dragons", Author = "George R. R. Martin", Genre = 0, PublishedDate = new DateTime(2011,7,12)}
            };
        }
        public List<Book> GetBooks()
        {
            return booksList;
        }
        public void AddBook(Book newBook) // for thsoe who have access to Book class
        {
            booksList.Add(newBook);
        }
        public void AddBook(string title, string author, Genre genre, DateTime publishedDate) // for those who do not have access to Book class
        {
            Book newbook = new Book();
            newbook.ISBN = newbook.GenerateISBN();
            newbook.Title = title;
            newbook.Author = author;
            newbook.Genre = genre;
            newbook.PublishedDate = publishedDate;
            booksList.Add(newbook);
        }
        public void DeleteBook(int index)
        {
            booksList.RemoveAt(index);
        }
    }

    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }

        static Random rnd = new Random();

        public string GenerateISBN()
        {
            return 0 + "-" + rnd.Next(100, 999) + "-" + rnd.Next(10000, 99999) + "-" + rnd.Next(0,9);
        }
    }
}