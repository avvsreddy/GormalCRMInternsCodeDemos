namespace OOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Initialization Syntax

            Product p1 = new Product { ProductId = 111, Name = "IPhone X", Rate = 90000 };

            Product p2 = new Product { ProductId = 222 };

            Product p3 = new Product { ProductId = 333, Name = "IWatch" };

            Product p4 = new Product();

            Product p5 = new Product { Name = "Dell XPS 5" };
            //p5.Name = "sdfsdfd";

            Product p6 = new Product { ProductId = 123, Rate = 56000 };


        }
    }

    class Account
    {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public double Balace { get; set; }
    }

    class Product
    {
        // product id, name, rate

        public int ProductId { get; set; }
        public string Name { get; set; }
        private int rate;
        public int Rate
        {
            get { return rate; }
            set
            {
                if (value < 0)
                    this.rate = 1;
                else
                    this.rate = value;
            }
        }

        //~Product()
        //{

        //}

        //public Product(int id, string name, double rate):this(id,name)
        //{
        //    //ProductId = id;
        //    //Name = name;
        //    Rate = Rate;
        //}
        //public Product()
        //{

        //}
        //public Product(int id)
        //{
        //    ProductId = id;
        //}

        //public Product(int id, string name):this(id)
        //{
        //    //ProductId = id;
        //    Name = name;
        //}

    }

    class Employee
    {
        private string name;
        private int age;
        private static string companyName;
        //private string location;
        //private string _backingfield2342343;

        public string Location // Automatic Property
        {
            get;// { return _backingfield2342343; }
            set;// { _backingfield2342343 = value; }
        }

        public string Name
        {
            set
            {
                if (name.Length >= 3)
                    this.name = value;
                else
                    this.name = "Invalid";
            }
            get
            {
                return name;
            }
        }
        //public void SetName(string name)
        //{
        //    if (name.Length >= 3)
        //        this.name = name;
        //    else
        //        this.name = "Invalid";
        //}
        //public string GetName()
        //{
        //    return name;
        //}
        public void SetAge(int a)
        {
            if (a >= 18 && a <= 60)
            {
                age = a;
            }
            else
            {
                age = 18;
            }
        }
        public int GetAge()
        {
            return age;
        }


    }

    class SalesPerson : Employee
    {

    }
}