using ABCBankAppLibrary;

namespace ABCBankAppUnitTest
{
    [TestClass]
    public class AccountManagerUnitTest
    {
        [TestMethod]
        public void Withdraw_WithSufficcientBalanceAndCorrectPinAndActive_ShouldReduceTheBalance()
        {
            Account account = new Account();
            account.AccNo = 111;
            account.Name = "Venkat";
            account.IsActive = true;
            account.Balance = 5000;
            account.Pin = 123;
            AccountManager target = new AccountManager();
            target.WithDraw(account, 1000, 123);
            Assert.AreEqual(4000, account.Balance);

        }

        [TestMethod]
        [ExpectedException(typeof(InactiveAccountException))]
        public void Withdraw_WithInActiveAccount_ShouldThrowsExp()
        {
            Account account = new Account();
            account.AccNo = 111;
            account.Name = "Venkat";
            account.IsActive = false;
            account.Balance = 5000;
            account.Pin = 123;
            AccountManager target = new AccountManager();
            target.WithDraw(account, 1000, 123);
            //Assert.AreEqual(4000, account.Balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InsufficcientBalanceException))]
        public void Withdraw_WithInsufficcientBalance_ShouldThrowsExp()
        {
            Account account = new Account();
            account.AccNo = 111;
            account.Name = "Venkat";
            account.IsActive = true;
            account.Balance = 1000;
            account.Pin = 123;
            AccountManager target = new AccountManager();
            target.WithDraw(account, 5000, 123);
        }

    }
}