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
    }
}