namespace LibraryApp.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public int LoanLimit { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public User()
        {
            UserId = Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
            LoanLimit = 4;
            BorrowedBooks = new List<Book>();
        }

        public User(string name)
        {
            Name = name;
            UserId = Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
            LoanLimit = 4;
            BorrowedBooks = new List<Book>();
        }

        public virtual bool BorrowBook(Book book)
        {
            if (BorrowedBooks.Count < LoanLimit)
            {
                BorrowedBooks.Add(book);
                book.ChangeAvailability(false);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
            book.ChangeAvailability(true);
        }

        public List<Book> DisplayBorrowedBooks()
        {
            return BorrowedBooks;
        }
    }
}