namespace LibraryApp.Classes
{
    public class PremiumUser : User
    {
        public PremiumUser(string name)
        {
            Name = name;
            LoanLimit = 5;
        }

        public override bool BorrowBook(Book book)
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
    }
}