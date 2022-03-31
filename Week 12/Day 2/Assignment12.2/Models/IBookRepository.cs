using System.Collections.Generic;

namespace Assignment12._2.Models
{
    public interface IBookRepository
    {
        List<Book> Books { get; set; }

        Book GetBook(int? ISBN);

        List<Book> InitializeBooks();

        void AddBook(Book book);

        void UpdateBook(Book book);

        void RemoveBook(Book book);
    }
}
