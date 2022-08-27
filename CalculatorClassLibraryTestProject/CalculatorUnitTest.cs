using CalculatorClassLibrary;
using SuperCalculatorConsoleApp;

namespace CalculatorClassLibraryTestProject
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void FindSum_WithValidInput_ShouldGiveCorrectResult() // Test Case
        {
            // write simple code
            // dont use any conditional, looping,try...catch
            // AAA
            // A - Arrange
            int fno = 2;
            int sno = 4;
            int sum = 0;
            int expected = 6;
            //Calculator target = new Calculator();
            // A - Act
            int actual = Calculator.FindSum(fno, sno);
            // A - Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputException))]
        public void FindSum_WithZeroInput_ShouldThrowExp()
        {
            Calculator.FindSum(0, 0);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputException))]
        public void FindSum_WithNegativeInput_ShouldThrowExp()
        {
            Calculator.FindSum(-2, -4);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputException))]
        public void FindSum_WithOddInput_ShouldThrowExp()
        {
            Calculator.FindSum(3, 5);
        }


    }
}