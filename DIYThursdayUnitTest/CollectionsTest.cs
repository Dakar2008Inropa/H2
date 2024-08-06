using DIYThursdayCollections;

namespace DIYThursdayUnitTest
{
    [TestClass]
    public class CollectionsTest
    {
        private CollectionExamples examples;

        [TestInitialize]
        public void Setup()
        {
            examples = new CollectionExamples();
        }

        [TestMethod]
        public void CreateArrayTest()
        {
            int[] array = examples.CreateArray();

            Assert.AreEqual(10, array[0]);
            Assert.AreEqual(20, array[1]);
            Assert.AreEqual(5, array.Length);
        }

        [TestMethod]
        public void CreateListTest()
        {
            List<int> list = examples.CreateList();

            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(20, list[0]);
        }

        [TestMethod]
        public void CreateDictionaryTest()
        {
            Dictionary<int, string> dictionary = examples.CreateDictionary();

            Assert.AreEqual("Daniel", dictionary[1]);
            Assert.IsFalse(dictionary.ContainsKey(2));
        }

        [TestMethod]
        public void CreateHashSetTest()
        {
            HashSet<int> hashSet = examples.CreateHashSet();

            Assert.AreEqual(2, hashSet.Count);
            Assert.IsTrue(hashSet.Contains(10));
            Assert.IsTrue(hashSet.Contains(20));
        }

        [TestMethod]
        public void CreateQueueTest()
        {
            Queue<int> queue = examples.CreateQueue();

            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(20, queue.Peek());
        }

        [TestMethod]
        public void CreateStackTest()
        {
            Stack<int> stack = examples.CreateStack();

            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(10, stack.Peek());
        }

        [TestMethod]
        public void CreateLinkedListTest()
        {
            LinkedList<int> linkedList = examples.CreateLinkedList();

            Assert.AreEqual(2, linkedList.Count);
            Assert.AreEqual(5, linkedList.First.Value);
            Assert.AreEqual(20, linkedList.Last.Value);
        }

        [TestMethod]
        public void CreateObservableCollectionOperations()
        {
            var (observableCollection, collectionChanged) = examples.CreateObservableCollection();

            Assert.IsTrue(collectionChanged);
            Assert.AreEqual(0, observableCollection.Count);
        }

        [TestMethod]
        public void CreateSortedListTest()
        {
            SortedList<int, string> sortedList = examples.CreateSortedList();

            Assert.AreEqual("Daniel", sortedList[1]);
            Assert.AreEqual("Emma", sortedList[2]);
        }

        [TestMethod]
        public void CreateSortedSetTest()
        {
            SortedSet<int> sortedSet = examples.CreateSortedSet();

            Assert.AreEqual(2, sortedSet.Count);
            Assert.AreEqual(5, sortedSet.Min);
            Assert.AreEqual(10, sortedSet.Max);
        }

        [TestMethod]
        public void AddStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student("Daniel", "Andersen");
            Helper.AddToCollection(students, student);

            Assert.AreEqual(1, students.Count);
            Assert.AreEqual("Daniel", students[0].FirstName);
        }

        [TestMethod]
        public void RemoveStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student("Daniel", "Andersen");
            Helper.AddToCollection(students, student);
            Assert.AreEqual(1, students.Count);

            Helper.RemoveFromCollection(students, student);
            Assert.AreEqual(0, students.Count);
        }

        [TestMethod]
        public void PrintStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student("Daniel", "Andersen");
            Helper.AddToCollection(students, student);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Helper.PrintCollection(students);
                string expected = string.Format("{0}{1}", student, Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void AddCars()
        {
            List<Car> cars = new List<Car>();
            Car car = new Car("Toyota", "Corolla");
            Helper.AddToCollection(cars, car);

            Assert.AreEqual(1, cars.Count);
            Assert.AreEqual("Toyota", cars[0].Make);
        }

        [TestMethod]
        public void RemoveCars()
        {
            List<Car> cars = new List<Car>();
            Car car = new Car("Toyota", "Corolla");
            Helper.AddToCollection(cars, car);
            Assert.AreEqual(1, cars.Count);

            Helper.RemoveFromCollection(cars, car);
            Assert.AreEqual(0, cars.Count);
        }

        [TestMethod]
        public void PrintCars()
        {
            List<Car> cars = new List<Car>();
            Car car = new Car("Toyota", "Corolla");
            Helper.AddToCollection(cars, car);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Helper.PrintCollection(cars);
                string expected = string.Format("{0}{1}", car, Environment.NewLine);
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}