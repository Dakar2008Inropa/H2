namespace LibraryApp.Classes
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; private set; }

        public Book()
        {
            ISBN = Guid.NewGuid().ToString("N");
            IsAvailable = true;
        }

        public Book(string title, string author)
        {
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