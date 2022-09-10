using System.Xml.Linq;

namespace LinqToXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            XDocument xml = XDocument.Load("XMLFile1.xml");

            // get all books price is more than 5$

            var books1 = from b in xml.Descendants("book")
                         where double.Parse(b.Element("price").Value) <= 5
                         orderby b.Element("title").Value descending
                         select b.Element("title").Value;

            foreach (var item in books1)
            {
                Console.WriteLine(item);
            }

        }
    }
}