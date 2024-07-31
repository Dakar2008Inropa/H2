namespace LibraryApp.Classes
{
    public class Library
    {
        private List<Book> Books { get; set; }
        private List<User> Users { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Users = new List<User>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public void RegisterUser(User user)
        {
            Users.Add(user);
        }

        public void UnregisterUser(User user)
        {
            Users.Remove(user);
        }

        public List<Book> DisplayAllBooks()
        {
            return Books;
        }

        public List<User> DisplayAllUsers()
        {
            return Users;
        }

        public List<Book> DisplayAvailableBooks()
        {
            return Books.Where(b => b.IsAvailable).ToList();
        }

        public List<Book> DisplayBorrowedBooks()
        {
            return Books.Where(b => !b.IsAvailable).ToList();
        }

        public Tuple<Book, string> FindBookByISBN(string isbn)
        {
            Book foundBook = Books.FirstOrDefault(b => b.ISBN == isbn);
            if (foundBook == null)
            {
                return new Tuple<Book, string>(null, "Book not found");
            }
            else
            {
                return new Tuple<Book, string>(foundBook, "Book found");
            }
        }
    }
}