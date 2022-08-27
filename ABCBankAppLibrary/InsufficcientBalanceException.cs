using System.Runtime.Serialization;

namespace ABCBankAppLibrary
{
    [Serializable]
    public class InsufficcientBalanceException : Exception
    {
        public InsufficcientBalanceException()
        {
        }

        public InsufficcientBalanceException(string? message) : base(message)
        {
        }

        public InsufficcientBalanceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InsufficcientBalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}