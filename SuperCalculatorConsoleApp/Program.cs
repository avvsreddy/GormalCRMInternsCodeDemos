using CalculatorClassLibrary;

namespace SuperCalculatorConsoleApp
{
    internal class Program // UI
    {

        // UI
        static void Main(string[] args)
        {
            // accept two int numbers and find the sum and display, do it repeatdly
            int fno;
            int sno;
            int sum = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter First Number: ");
                    fno = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number: ");
                    sno = int.Parse(Console.ReadLine());
                    sum = Calculator.FindSum(fno, sno); // BLL
                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Enter only numbers");
                    // mail
                    // sms
                    // log/save ex

                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //catch (OverflowException e)
                //{
                //    Console.WriteLine("Enter small numbers only");
                //}
                // catch all block
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
            }

        }


    }
}