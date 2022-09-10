namespace Delegates5
{
    // declaration
    delegate void MyDelegate(string str);

    //class MyDelegate : Delegate
    //{

    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // Direct
            //Program.Hello("Ravi");
            // Indirect
            MyDelegate del = new MyDelegate(Hello);
            del += Hi;
            del -= Hello;
            //del.Invoke("ravi");
            del("kiran");

            List<int> numbers = new List<int> { 123, 34, 456, 567, 456, 456, 34, 456 };
            // find the sum of all even numbers
            int sum = (from n in numbers
                       where n % 2 == 0
                       select n).Sum();

            Func<int, bool> filter = new Func<int, bool>(IsEven);

            int sum2 = numbers.Where(filter).Sum();
            int sum3 = numbers.Where(IsEven).Sum();
        }

        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        public static void Hello(string name)
        {
            Console.WriteLine("Hello: " + name);
        }

        public static void Hi(string name)
        {
            Console.WriteLine("Hi: " + name);
        }

    }
}