namespace DIYThursdayCollections
{
    public class Car
    {
        public string Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string make, string model)
        {
            Id = Guid.NewGuid().ToString("N");
            Make = make;
            Model = model;
        }
    }
}