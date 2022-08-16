namespace SuperCalculatorConsoleApp
{
    internal class Program // UI
    {

        // UI
        static void Main(string[] args)
        {
            // accept two int numbers and find the sum and display
            int fno;
            int sno;
            int sum = 0;
            Console.Write("Enter First Number: ");
            fno = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            sno = int.Parse(Console.ReadLine());

            sum = Calculator.FindSum(fno, sno); // BLL

            Console.WriteLine($"The sum of {fno} and {sno} is {sum}");

        }


    }
}