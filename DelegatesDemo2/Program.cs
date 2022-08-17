using System.Diagnostics;

namespace DelegatesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // client 1
            //ProcessManager.ShowProcessList(FilterByNone);
            // client 2
            //FilterDelegate filter = new FilterDelegate(FilterByName);
            //ProcessManager.ShowProcessList(filter);
            // client 3

            //ProcessManager.ShowProcessList(FilterBySize);

            // Anonymous Delegates

            // client 1
            //ProcessManager.ShowProcessList(delegate
            //    {
            //        return true;
            //    }
            //);

            // client 2

            //ProcessManager.ShowProcessList(delegate (Process p)
            //    {
            //        return p.ProcessName.StartsWith("S");
            //    }
            //);

            // client 3
            ProcessManager.ShowProcessList(delegate (Process p)
                {
                    return p.WorkingSet64 >= 50 * 1024 * 1024;
                });

            // Lambda : Light weight syntax for anonymous delegates

            // Lambda Statement - Expression

            ProcessManager.ShowProcessList((Process p) =>
            {
                return p.WorkingSet64 >= 50 * 1024 * 1024;
            });

            // Lambda Expression

            ProcessManager.ShowProcessList((Process p) =>

                p.WorkingSet64 >= 50 * 1024 * 1024
            );

            ProcessManager.ShowProcessList(p => p.WorkingSet64 >= 50 * 1024 * 1024);
        }

        // client 1

        //public static bool FilterByNone(Process p)
        //{
        //    return true;
        //}
        // client 2
        public static bool FilterByName(Process p)
        {
            return p.ProcessName.StartsWith("S");
        }

        // client 3
        public static bool FilterBySize(Process p)
        {
            return p.WorkingSet64 >= 50 * 1024 * 1024;
        }


    }

    // declare the delegate

    public delegate bool FilterDelegate(Process p);
    class ProcessManager
    {
        //public static void ShowProcessList()
        //{
        //    // display all running processes
        //    foreach (Process p in Process.GetProcesses())
        //    {
        //        Console.WriteLine(p.ProcessName);
        //    }

        //}

        public static void ShowProcessList(FilterDelegate filter)
        {
            // display all running processes starting with an alphabet
            foreach (Process p in Process.GetProcesses())
            {
                if (filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }

        //public static void ShowProcessList(long size)
        //{
        //    // display all running processes by memory
        //    foreach (Process p in Process.GetProcesses())
        //    {
        //        if (p.WorkingSet64 >= size)
        //            Console.WriteLine(p.ProcessName);
        //    }

        //}
    }
}