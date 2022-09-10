namespace LinqDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq To Objects");
            List<int> numbers = new List<int> { 23, 53, 23, 64, 24, 75, 22, 77, 34 };
            // Get all even numbers into another array and display
            // traditional way
            var evens = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                    evens.Add(item);
            }
            foreach (var item in evens)
            {
                //Console.WriteLine(item);
            }
            // table: numbers
            // column: number
            // SQL: select number from numbers where number mod 2 = 0;

            // LINQ Expression
            var evens2 = from n in numbers where n % 2 == 0 select n;
            // LINQ Extension Methods
            var evens3 = numbers.Where(n => n % 2 == 0);

            foreach (var item in evens3)
            {
                Console.WriteLine(item);
            }
        }
    }
}