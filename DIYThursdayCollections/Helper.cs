namespace DIYThursdayCollections
{
    public static class Helper
    {
        public static void AddToCollection<T>(List<T> collection, T item)
        {
            collection.Add(item);
        }

        public static void RemoveFromCollection<T>(List<T> collection, T item)
        {
            collection.Remove(item);
        }

        public static void PrintCollection<T>(List<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}