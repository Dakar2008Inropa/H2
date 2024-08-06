using System.Collections.ObjectModel;

namespace DIYThursdayCollections
{
    public class CollectionExamples
    {
        public int[] CreateArray()
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            return numbers;
        }

        public List<int> CreateList()
        {
            List<int> numbers = new List<int> { 10, 20 };
            numbers.Remove(10);
            return numbers;
        }

        public Dictionary<int, string> CreateDictionary()
        {
            Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Daniel" },
            { 2, "Emma" }
        };
            students.Remove(2);
            return students;
        }

        public HashSet<int> CreateHashSet()
        {
            HashSet<int> uniqueNumbers = new HashSet<int> { 10, 20, 10 };
            return uniqueNumbers;
        }

        public Queue<int> CreateQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Dequeue();
            return queue;
        }

        public Stack<int> CreateStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Pop();
            return stack;
        }

        public LinkedList<int> CreateLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(10);
            linkedList.AddFirst(5);
            linkedList.AddLast(20);
            linkedList.Remove(10);
            return linkedList;
        }

        public (ObservableCollection<int>, bool) CreateObservableCollection()
        {
            ObservableCollection<int> observableCollection = new ObservableCollection<int>();
            bool collectionChanged = false;
            observableCollection.CollectionChanged += (sender, e) => { collectionChanged = true; };
            observableCollection.Add(10);
            observableCollection.Remove(10);
            return (observableCollection, collectionChanged);
        }

        public SortedList<int, string> CreateSortedList()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>{
                { 2, "Emma" },
                { 1, "Daniel" }
            };
            return sortedList;
        }

        public SortedSet<int> CreateSortedSet()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 10, 5, 10 };
            return sortedSet;
        }
    }
}