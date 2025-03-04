using System;
using UserManagement;
using BookManagement;
using BorrowingManagement;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService();
            var bookService = new BookService();
            var borrowingService = new BorrowingService(userService, bookService);

            var user = new User { Id = 1, Name = "Alice" };
            var book = new Book { Id = 1, Title = "C# Programming" };

            userService.AddUser(user);
            bookService.AddBook(book);
            borrowingService.BorrowBook(user.Id, book.Id);

            DisplayLibraryInfo(userService, bookService);

            // Programın çıktısını görebilmek için bir tuşa basmayı bekleyin
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void DisplayLibraryInfo(UserService userService, BookService bookService)
        {
            Console.WriteLine("Library Info:");
            Console.WriteLine("Users:");
            userService.GetAllUsers().ForEach(user => Console.WriteLine($"- {user.Name}"));
            Console.WriteLine("Books:");
            bookService.GetAllBooks().ForEach(book => Console.WriteLine($"- {book.Title}"));
        }
    }
}
