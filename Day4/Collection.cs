namespace Day3
{
    class MyCollection
    {
        public static void InitList()
        {
            Console.WriteLine("\n======alfabet=======\n");
            var alfabet = new List<string> { "A", "B", "C", "D", "E"};
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G", "H", "I" });
            alfabet.Insert(0, "J");
            alfabet.InsertRange(3, new[] { "X", "Y" });


            foreach (var item in alfabet)
            {
                Console.Write(item + " ");
            }

            // remove elemet from list<T>
            alfabet.Remove("X");
            alfabet.RemoveRange(4, 6);
            alfabet.RemoveAll(v => v == "A");

            // clear
            alfabet.Clear();

            Console.WriteLine("\n========numbers========\n");
            
            // declare List<int>
            var numbers = new List<int> { 2, 5, 7, 11, 13, 17, 19 };

            numbers.Add(23);
/*            numbers.Remove(13);
            numbers.RemoveAll(v => v >= 7);*/
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            // find element
            Console.WriteLine("\n===========find elemnt===========\n");
            var a = numbers.Find(e => e < 10);
            var b = numbers.FindLast(e => e < 11);
            var c = numbers.FindAll(e => e <= 10);
            Console.WriteLine("a ", a);
            Console.WriteLine("b ", b);
            Console.WriteLine("c ", c);

            Console.WriteLine("\n===========find elemnt index===========\n");
            // find element index 
            var d = numbers.FindIndex(e => e <= 11);
            var e = numbers.FindLastIndex(e => e <= 11);
            var f = numbers.IndexOf(13);
            var g = numbers.BinarySearch(11);
            Console.WriteLine("d ", d);
            Console.WriteLine("e ", e);
            Console.WriteLine("f ", f);
            Console.WriteLine();
        }


        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] {1,2,3});
            numbers.Push(5);
            numbers.Push(7);

            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();

            foreach (var item in numbers)
            {
                Console.Write($"Init stack number {item}");
            }
        }
        public static void InitDictionary()
        {
            Console.WriteLine("\n=========== Init Dictionary ===========\n");
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");

            var pl2 = new Dictionary<int, string>()
            {
                {1, "C#" },
                {2, "Java" },
                {3, "Python" }
            };

            // add new element
            pl2.Add(4, "Golang");
            pl2.TryAdd(4, "SQL");

            pl2[4] = "SQL";

            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key} dan {item.Value}");
            }

        }

        public static void InitHashSet()
        {
            HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 5, 8 };
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(8);

            var hash1 = new HashSet<int>() { 1, 2, 5, 6, 9 };
            var hash2 = new HashSet<int>() { 1, 2, 3, 4 };
            var r1 = new HashSet<int>(hash1);
            r1.Intersect(hash2);
            IEnumerable<int> both = r1.Intersect(hash2);
            Console.WriteLine("========r1========");
            foreach (var item in both)
                Console.WriteLine(item);

            var r2 = new HashSet<int>(hash1);
            r2.UnionWith(hash2);
            IEnumerable<int> both2 = r2.Union(hash2);
            Console.WriteLine("========r2========");
            foreach (var item in both2)
                Console.WriteLine(item);

            var r3 = new HashSet<int>(hash1);
            IEnumerable<int> both3 = r3.Except(hash2);
            var both10 = r3.Except(hash1);
            Console.WriteLine("========r3========");
            foreach (var item in both3)
                Console.WriteLine(item);

            Console.WriteLine("========r4========");
            var r4 = new HashSet<int>(hash1);
            r4.SymmetricExceptWith(hash2);
            var myNumber = r4.ToList();
            foreach (var item in myNumber)
                Console.WriteLine(item);

        }
        public static void InitQueue()
        {
            Console.WriteLine("========Queue========");
            var queue = new Queue<string>();
            queue.Enqueue("asep");
            queue.Enqueue("budi");
            queue.Enqueue("charlie");


            string served = queue.Dequeue();
            Console.WriteLine($"Served : {served}");
            Console.WriteLine($"Queue from front to back");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }

            served = queue.Dequeue();
            Console.WriteLine($"Served : {served}");

        }
        public static List<T> GetStudent<T>(ref List<T> list)
        {
            Console.WriteLine("========GetStudent========");
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }
            return myList;
        }
    }
    class NonGeneric
    {
        
    }
}