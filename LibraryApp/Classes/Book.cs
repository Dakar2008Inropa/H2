namespace LibraryApp.Classes
{
    public class Book
    {
        //
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; private set; }

        public Book()
        {
            IsAvailable = true;
        }

        public Book(string title, string author, string isbn)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            ISBN = Guid.NewGuid().ToString("N");
            IsAvailable = true;
        }

        public void ChangeAvailability(bool availability)
        {
            IsAvailable = availability;
        }
    }
}