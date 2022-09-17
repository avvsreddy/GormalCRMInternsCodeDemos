using System.Collections.Concurrent;

namespace MTDemoConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigData bigData = new BigData();
            //bigData.Fill();
            //bigData.Fill();
            Parallel.Invoke(bigData.Fill, bigData.Fill);
            Console.WriteLine($"Count: {bigData.data.Count}");
        }
    }

    class BigData
    {
        //public Stack<int> data = new Stack<int>();
        public ConcurrentStack<int> data = new ConcurrentStack<int>();

        //[MethodImpl(MethodImplOptions.Synchronized)]
        public void Fill()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                //lock (this)
                //{
                //Monitor.Enter(this);

                data.Push(i);
                //}
                //Monitor.Exit(this);
            }
        }
    }
}