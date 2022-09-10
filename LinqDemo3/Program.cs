namespace LinqDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evens = (from n in numbers
                         where IsEven(n)   //n % 2 == 0
                         select n).ToList();
            numbers.Add(10);

            foreach (var item in evens)
            {
                Console.WriteLine(item);
            }
        }


        static bool IsEven(int n)
        {
            Console.WriteLine("ISEven() called");
            return n % 2 == 0;

        }
        static IEnumerable<int> GetEvens(List<int> input)
        {
            Console.WriteLine("In Get evens");
            var evens = (from n in input
                         where n % 2 == 0
                         select n).ToList();
            return evens;
        }
    }
}