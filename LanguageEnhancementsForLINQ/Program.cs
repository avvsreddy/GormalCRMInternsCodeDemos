namespace LanguageEnhancementsForLINQ
{
    internal class Program
    {

        int a = 10;
        static void Main(string[] args)
        {
            // Local variable type inference
            var a = 10;
            var d = 10.5;
            var str = "abcd";

            //Emp e1 = new Emp();
            //e1.EmpNo = 111;
            //e1.Name = "Ramesh";
            //e1.Salary = 50000;

            // Object Initialization Syntax
            //Emp e2 = new Emp() { EmpNo = 222, Name = "Kiran", Salary = 60000 };
            var e2 = new { EmpNo = 222, Name = "Kiran", Salary = 60000 };
            // Anoymous Objects

            // Extension Methods
            string data = "secret data";

            data.ToUpper();
            data = StringUtil.Encrypt(data);
            data.Encrypt();
            // SQL SELECT
            // from select where orderby .Select .Where .Orderby

        }
    }

    static class StringUtil
    {
        public static string Encrypt(this string data)
        {
            return "@#$@#DWERWE@#$@#%#$^@#%!#$^!#$^!#$^";
        }
    }

    //class Emp
    //{
    //    public int EmpNo { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //}
}