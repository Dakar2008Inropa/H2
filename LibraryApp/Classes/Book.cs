namespace LibraryApp.Classes
{
    public class Book
    {
        //ISBN skal være readonly da det er en unik identifikator for bogen
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; private set; }

        public Book()
        {
            IsAvailable = true;
            //Hvorfor have en bog uden en titel, forfatter og ISBN? ISBN skal kun genereres når en bog oprettes
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
            //At have en metode der styrer Availability er fint hvis der skal tilføjes mere logik
            //Men lige nu er det lidt nytteløst
            //ChangeAvailability(true); eller
            //book.IsAvailable = true; er det samme lige nu
        }

        //Mangler DisplayInfo metode
    }
}