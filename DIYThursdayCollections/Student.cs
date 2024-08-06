namespace DIYThursdayCollections
{
    public class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstName, string lastName)
        {
            Id = Guid.NewGuid().ToString("N");
            FirstName = firstName;
            LastName = lastName;
        }
    }
}