using LibraryApp.Classes;

namespace LibraryAppUnitTest
{
    [TestClass]
    public class LibraryTest
    {
        private Library _library;

        [TestInitialize]
        public void Initialize()
        {
            _library = new Library();
        }

        [TestMethod]
        public void AddBookTest()
        {
            Book book = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            _library.AddBook(book);
            List<Book> books = _library.DisplayAllBooks();
            Assert.AreEqual(1, books.Count);
            Assert.AreEqual(book, books[0]);
        }

        [TestMethod]
        public void RemoveBookTest()
        {
            Book book = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            _library.AddBook(book);
            _library.RemoveBook(book);
            List<Book> books = _library.DisplayAllBooks();
            Assert.AreEqual(0, books.Count);
        }

        [TestMethod]
        public void RegisterUserTest()
        {
            User user = new User("User 1");
            _library.RegisterUser(user);
            List<User> users = _library.DisplayAllUsers();
            Assert.AreEqual(1, users.Count);
            Assert.AreEqual(user, users[0]);
        }

        [TestMethod]
        public void UnregisterUserTest()
        {
            User user = new User("User 1");
            _library.RegisterUser(user);
            _library.UnregisterUser(user);
            List<User> users = _library.DisplayAllUsers();
            Assert.AreEqual(0, users.Count);
        }

        [TestMethod]
        public void DisplayAllBooksTest()
        {
            Book book1 = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            Book book2 = new Book("Title 2", "Author 2", _library.GenerateUniqueISBN());
            _library.AddBook(book1);
            _library.AddBook(book2);
            List<Book> books = _library.DisplayAllBooks();
            Assert.AreEqual(2, books.Count);
            Assert.AreEqual(book1, books[0]);
            Assert.AreEqual(book2, books[1]);
        }

        [TestMethod]
        public void DisplayAllUsersTest()
        {
            User user1 = new User("User 1");
            User user2 = new User("User 2");
            _library.RegisterUser(user1);
            _library.RegisterUser(user2);
            List<User> users = _library.DisplayAllUsers();
            Assert.AreEqual(2, users.Count);
            Assert.AreEqual(user1, users[0]);
            Assert.AreEqual(user2, users[1]);
        }

        [TestMethod]
        public void DisplayAllPremiumUsersTest()
        {
            PremiumUser premiumUser1 = new PremiumUser("PremiumUser 1");
            PremiumUser premiumUser2 = new PremiumUser("PremiumUser 2");
            _library.RegisterPremiumUser(premiumUser1);
            _library.RegisterPremiumUser(premiumUser2);
            List<PremiumUser> premiumUsers = _library.DisplayAllPremiumUsers();
            Assert.AreEqual(2, premiumUsers.Count);
            Assert.AreEqual(premiumUser1, premiumUsers[0]);
            Assert.AreEqual(premiumUser2, premiumUsers[1]);
        }

        [TestMethod]
        public void DisplayAvailableBooksTest()
        {
            Book availableBook = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            Book borrowedBook = new Book("Title 2", "Author 2", _library.GenerateUniqueISBN());

            borrowedBook.ChangeAvailability(false);

            _library.AddBook(availableBook);
            _library.AddBook(borrowedBook);

            List<Book> availableBooks = _library.DisplayAvailableBooks();
            Assert.AreEqual(1, availableBooks.Count);
            Assert.AreEqual(availableBook, availableBooks[0]);
        }

        [TestMethod]
        public void DisplayBorrowedBooksTest()
        {
            Book availableBook = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            Book borrowedBook = new Book("Title 2", "Author 2", _library.GenerateUniqueISBN());

            borrowedBook.ChangeAvailability(false);

            _library.AddBook(availableBook);
            _library.AddBook(borrowedBook);

            List<Book> borrowedBooks = _library.DisplayBorrowedBooks();
            Assert.AreEqual(1, borrowedBooks.Count);
            Assert.AreEqual(borrowedBook, borrowedBooks[0]);
        }

        [TestMethod]
        public void FindBookByISBNTest()
        {
            Book book = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            _library.AddBook(book);
            Tuple<Book, string> result = _library.FindBookByISBN(book.ISBN);
            Assert.AreEqual(book, result.Item1);
            Assert.AreEqual("Book found", result.Item2);
        }

        [TestMethod]
        public void FindBookByISBNTest_BookNotFound()
        {
            Tuple<Book, string> result = _library.FindBookByISBN("123");
            Assert.IsNull(result.Item1);
            Assert.AreEqual("Book not found", result.Item2);
        }

        [TestMethod]
        public void BorrowBookTest()
        {
            Book book = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            User user = new User("User 1");
            _library.AddBook(book);
            _library.RegisterUser(user);
            bool result = user.BorrowBook(book);
            Assert.IsTrue(result);
            Assert.IsFalse(book.IsAvailable);
        }

        [TestMethod]
        public void BorrowBookTest_LoanLimitReached()
        {
            Book book1 = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            Book book2 = new Book("Title 2", "Author 2", _library.GenerateUniqueISBN());
            Book book3 = new Book("Title 2", "Author 2", _library.GenerateUniqueISBN());
            Book book4 = new Book("Title 2", "Author 2", _library.GenerateUniqueISBN());
            User user = new User("User 1");
            _library.AddBook(book1);
            _library.AddBook(book2);
            _library.AddBook(book3);
            _library.AddBook(book4);
            _library.RegisterUser(user);
            user.BorrowBook(book1);
            user.BorrowBook(book2);
            user.BorrowBook(book3);
            user.BorrowBook(book4);
            bool result = user.BorrowBook(new Book("Title 3", "Author 3", _library.GenerateUniqueISBN()));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReturnBookTest()
        {
            Book book = new Book("Title 1", "Author 1", _library.GenerateUniqueISBN());
            User user = new User("User 1");
            _library.AddBook(book);
            _library.RegisterUser(user);
            user.BorrowBook(book);
            user.ReturnBook(book);
            Assert.IsTrue(book.IsAvailable);
        }

        [TestMethod]
        public void PremiumUserBorrowBookTest()
        {
            var premiumUser = new PremiumUser("PremiumUser1");
            var books = new List<Book>
            {
                new Book("Title1", "Author1", _library.GenerateUniqueISBN()),
                new Book("Title2", "Author2", _library.GenerateUniqueISBN()),
                new Book("Title3", "Author3", _library.GenerateUniqueISBN()),
                new Book("Title4", "Author4", _library.GenerateUniqueISBN()),
                new Book("Title5", "Author5", _library.GenerateUniqueISBN()),
            };

            foreach (var book in books)
            {
                _library.AddBook(book);
            }

            foreach (var book in books.Take(4))
            {
                premiumUser.BorrowBook(book);
            }

            Assert.AreEqual(4, premiumUser.BorrowedBooks.Count);

            premiumUser.BorrowBook(books[4]);

            Assert.AreEqual(5, premiumUser.BorrowedBooks.Count);
        }

        [TestMethod]
        public void GenerateUniqueISBNTest()
        {
            string isbn1 = _library.GenerateUniqueISBN();
            string isbn2 = _library.GenerateUniqueISBN();
            Assert.AreNotEqual(isbn1, isbn2);
        }
    }
}