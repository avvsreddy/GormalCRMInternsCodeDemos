namespace CalculatorClassLibrary
{
    public class InvalidInputException : ApplicationException
    {
        public InvalidInputException(string msg) : base(msg)
        {
            //Message = msg;
        }
    }
}
