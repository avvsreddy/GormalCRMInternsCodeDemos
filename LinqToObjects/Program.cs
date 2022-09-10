namespace LinqToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get all Employees based on the location - Hyd
            var hydemp = from e in Employee.Employees
                         where e.Location == "Hyderabad"
                         select e;

            //foreach (var item in hydemp)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Location}");
            //}

            // get all sr. dev names

            var resutl2 = from e in Employee.Employees
                          where e.Designation == "Sr. Dev"
                          select e.Name;

            foreach (var item in resutl2)
            {
                // Console.WriteLine(item);
            }

            // get all sr. dev names and their salary

            var resutl3 = from e in Employee.Employees
                          where e.Designation == "Sr. Dev"
                          select new { EName = e.Name, ESalary = e.Salary };

            foreach (var item in resutl3)
            {
                //Console.WriteLine(item.EName);
            }

            // Get the emp who is getting max salary
            int maxSalary = (from e in Employee.Employees
                             select e.Salary).Max();
            Console.WriteLine(maxSalary);

            string ename = (from e in Employee.Employees
                            where e.Salary == (from e1 in Employee.Employees
                                               select e1.Salary).Max()
                            select e.Name).First();
            Console.WriteLine(ename);
        }
    }

    //class NameSal
    //{
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //}

    class Employee
    {
        public int EmpNO { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Location { get; set; }
        public string Designation { get; set; }

        public static List<Employee> Employees
        {
            get
            {
                return new List<Employee>
                {
                    new Employee{EmpNO=111, Name="Suresh", Salary = 56000, Designation="Jr. Dev", Location="Hyderabad"},
                     new Employee{EmpNO=222, Name="Girish", Salary = 66000, Designation="Sr. Dev", Location="Bangalore"},
                      new Employee{EmpNO=333, Name="Mahesh", Salary = 86000, Designation="Manager", Location="Hyderabad"},
                       new Employee{EmpNO=444, Name="Satish", Salary = 46000, Designation="Tester", Location="Chennai"},
                        new Employee{EmpNO=555, Name="Somesh", Salary = 56000, Designation="Jr. Dev", Location="Hyderabad"},

                };
            }
        }

    }
}