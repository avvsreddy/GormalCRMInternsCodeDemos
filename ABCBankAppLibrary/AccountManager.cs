namespace ABCBankAppLibrary
{
    public class AccountManager
    {
        public bool WithDraw(Account account, int amount, int pin)
        {

            if (!account.IsActive)
                throw new InactiveAccountException();
            if (account.Balance < amount)
                throw new InsufficcientBalanceException();
            account.Balance -= amount;
            return true;
        }
    }
}