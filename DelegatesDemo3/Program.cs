namespace DelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sum = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                    sum += n;
            }


            Func<int, bool> filter = new Func<int, bool>(IsEven);
            int sum2 = numbers.Where(filter).Sum();
            Console.WriteLine(sum2);

            int sum3 = numbers.Where(delegate (int n)
            {
                return n % 2 == 0;
            }).Sum();

            int sum4 = numbers.Where((int n) =>
            {
                return n % 2 == 0;
            }).Sum();

            int sum5 = numbers.Where(n => n % 2 == 0).Sum();
        }

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}