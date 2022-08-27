namespace ABCBankAppLibrary
{
    public class Account
    {

        public int AccNo { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Pin { get; set; }
        public bool IsActive { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }

    }
}