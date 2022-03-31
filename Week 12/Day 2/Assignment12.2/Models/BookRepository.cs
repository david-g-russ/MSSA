using System.Collections.Generic;

namespace Assignment12._2.Models
{
    public class BookRepository : IBookRepository
    {
        public List<Book> Books { get; set; }

        public Book GetBook(int? isbn)
        {
            if(isbn == null)
                return null;
            else
                return Books.Find(x=> x.ISBN == isbn);
        }

        public List<Book> InitializeBooks()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    ISBN = 123456,
                    Name = "Grandpa Voted for Trump",
                    Genre = "Children's",
                    Author = "Robert Kimmel Smith",
                    ImageName = "trump.jpg"
                },
                new Book()
                {
                    ISBN = 234567,
                    Name = "Everything I Want to Do Is Illegal",
                    Genre = "Children's",
                    Author = "John Edwards",
                    ImageName = "everything.jpg"
                },
                new Book()
                {
                    ISBN = 345678,
                    Name = "How To Read A Book",
                    Genre = "Non-Fiction",
                    Author = "Ashton M. Smith",
                    ImageName = "how.jpg"
                },
                new Book()
                {
                    ISBN = 456789,
                    Name = "Taking Dad to Rehab",
                    Genre = "Fiction",
                    Author = "Leslie Aniston",
                    ImageName = "taking.jpg"
                }
            };
            return Books;
        }

        public void AddBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveBook(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}
