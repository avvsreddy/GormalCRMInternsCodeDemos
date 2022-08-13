namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> numbs = new List<int>();
            numbs.Add(1);
            numbs.Add(2);
            numbs.Add(3);
            numbs.Add(4);
            numbs.Add(5);

            numbs.Insert(3, 50);

            Console.WriteLine(numbs.Capacity);
            numbs.RemoveAt(0);
            numbs.RemoveAt(1);
            numbs.TrimExcess();
            Console.WriteLine(numbs.Capacity);

            numbs.Sum();
            numbs.Sort();

            Stack<int> s = new Stack<int>();
            s.Push(10);

            int x = s.Pop();
            x = s.Peek();

            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            x = q.Dequeue();
            x = q.Peek();

            HashSet<int> hs = new HashSet<int>();
            hs.Add(10);
            hs.Add(10);

            Dictionary<int, string> results = new Dictionary<int, string>();
            results.Add(111, "Pass");

            string r = results[111];
        }
    }
}