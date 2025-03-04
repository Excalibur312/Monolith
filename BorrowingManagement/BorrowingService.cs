using System;
using UserManagement;
using BookManagement;

namespace BorrowingManagement
{
    public class BorrowingService
    {
        private UserService _userService;
        private BookService _bookService;

        public BorrowingService(UserService userService, BookService bookService)
        {
            _userService = userService;
            _bookService = bookService;
        }

        public void BorrowBook(int userId, int bookId)
        {
            var user = _userService.GetUser(userId);
            var book = _bookService.GetBook(bookId);

            if (user != null && book != null)
            {
                Console.WriteLine($"{user.Name} borrowed {book.Title}");
            }
        }
    }
}
