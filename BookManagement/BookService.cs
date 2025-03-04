using System.Collections.Generic;

namespace BookManagement
{
    public class BookService
    {
        private List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public Book GetBook(int id)
        {
            return Books.Find(b => b.Id == id);
        }

        public List<Book> GetAllBooks()
        {
            return Books;
        }
    }
}
