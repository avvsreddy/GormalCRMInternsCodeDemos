using System.Diagnostics;

namespace MTDemoConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Running Seq...");
            M1();
            M2();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw = Stopwatch.StartNew();
            Console.WriteLine("Running Parallel....");
            Parallel.Invoke(M1, M2);
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw = Stopwatch.StartNew();
            Console.WriteLine("Running Parallel For....");
            Parallel.Invoke(M11, M22);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        static void M1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
            }
        }

        static void M2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(100);
            }
        }

        static void M11()
        {
            //for (int i = 1; i <= 10; i++)
            Parallel.For(1, 11, i =>
            {
                Thread.Sleep(100);
            });
        }

        static void M22()
        {
            //for (int i = 1; i <= 10; i++)
            int pcount = Environment.ProcessorCount;
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = pcount / 2;

            Parallel.For(1, 1000, options, x =>
            {
                Thread.Sleep(100);
            });
        }
    }
}