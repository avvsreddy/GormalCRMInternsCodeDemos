using CalculatorClassLibrary;

namespace SuperCalculatorConsoleApp
{

    /// <summary>
    /// A Simple Calculator
    /// </summary>
    public class Calculator // BL
    {
        // BL

        /// <summary>
        /// Finds the sum of non zero positive evns two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>the sum of two int numbers</returns>
        /// <exception cref="InvalidInputException"></exception>
        public static int FindSum(int a, int b) // 2 + 2 = 4/0
        {
            // both the input must me positive, non zero and even numbers only
            if (a > 0 && b > 0 & a % 2 == 0 && b % 2 == 0)
                return a + b;
            else
            {
                InvalidInputException ex = new InvalidInputException("Enter non zero positive even number");
                //return ex;
                throw ex;
            }
        }
        // single line comment

        /*
         * multi line comments
         * 
         * sdfsdf
         * sdfsdf
         * sdfsdf
         */

        /// Document comments/xml comments


        // find the difference
    }
}