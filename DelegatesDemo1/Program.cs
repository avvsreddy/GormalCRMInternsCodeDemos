namespace DelegatesDemo1
{

    //class MyDelegate : MulticastDelegate
    //{

    //}

    // Step 1: Delegate declaration/creation
    delegate void MyDelegate(string str);
    //delegate void MyOtherDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {

            // Directly
            Program p = new Program();
            //p.Greeting("Hello Good Morning! .. Direct");
            // Step 2: Instantiate and Initialize
            MyDelegate d1 = new MyDelegate(p.Greeting);
            d1 += Hello; // subscribe
            d1 -= p.Greeting; // unsubscribe
            //MyDelegate d2 = new MyDelegate(Hello);
            // Step 3: Invoke
            //d1.Invoke("hello from delegate");
            d1(" from delegate other way");
        }

        void Greeting(string msg)
        {
            Console.WriteLine($"Greeting - {msg}");
        }

        static void Hello(string str)
        {
            Console.WriteLine($"Hello - {str}");
        }
    }
}