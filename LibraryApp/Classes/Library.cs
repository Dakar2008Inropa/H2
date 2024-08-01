namespace LibraryApp.Classes
{
    public class Library
    {
        private List<Book> Books { get; set; }
        private List<User> Users { get; set; }
        private List<PremiumUser> PremiumUsers { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Users = new List<User>();
            PremiumUsers = new List<PremiumUser>();
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

        public void RegisterPremiumUser(PremiumUser user)
        {
            PremiumUsers.Add(user);
        }

        public void UnregisterPremiumUser(PremiumUser user)
        {
            PremiumUsers.Remove(user);
        }

        public List<Book> DisplayAllBooks()
        {
            return Books;
        }

        public List<Book> DisplayAllBooks(string isbn)
        {
            return Books.Where(x => x.ISBN == isbn).ToList();
        }

        public List<User> DisplayAllUsers()
        {
            return Users;
        }

        public List<User> DisplayAllUsers(string userid)
        {
            return Users.Where(x => x.UserId == userid).ToList();
        }

        public List<PremiumUser> DisplayAllPremiumUsers()
        {
            return PremiumUsers;
        }

        public List<PremiumUser> DisplayAllPremiumUsers(string userid)
        {
            return PremiumUsers.Where(x => x.UserId == userid).ToList();
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

        public string GenerateUniqueISBN()
        {
            string isbn;
            do
            {
                isbn = GenerateISBN();
            } while (Books.Exists(b => b.ISBN == isbn));
            return isbn;
        }

        private string GenerateISBN()
        {
            Random rnd = new Random();
            string prefix = "978";
            int registrationGroup = rnd.Next(1, 10); // Simplified example
            int registrant = rnd.Next(100, 1000); // Simplified example
            int publication = rnd.Next(10000, 100000); // Simplified example
            string partialISBN = $"{prefix}-{registrationGroup}-{registrant}-{publication}";
            string checkDigit = CalculateCheckDigit(partialISBN.Replace("-", ""));
            return $"{partialISBN}-{checkDigit}";
        }

        private string CalculateCheckDigit(string partialISBN)
        {
            int sum = 0;
            for (int i = 0; i < partialISBN.Length; i++)
            {
                int digit = int.Parse(partialISBN[i].ToString());
                sum += (i % 2 == 0) ? digit : digit * 3;
            }
            int remainder = sum % 10;
            int checkDigit = (10 - remainder) % 10;
            return checkDigit.ToString();
        }
    }
}