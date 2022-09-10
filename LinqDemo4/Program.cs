using System.Xml.Linq;

namespace LinqDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string> { "one", "two", "three", "four", "five", "six" };

            // get all short words in memory - Linq To Object

            //var shortwords = from w in words
            //                 where w.Length <= 3
            //                 orderby w descending
            //                 select w;


            // get all short words from xml

            XDocument xml = XDocument.Load("XMLFile1.xml");
            var shortwords = from w in xml.Descendants("word")
                             where w.Value.Length <= 3
                             orderby w.Value descending
                             select w.Value;


            foreach (var item in shortwords)
            {
                Console.WriteLine(item);
            }
        }
    }
}