using System.Net.Http.Json;

namespace CoolProductsClientConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serviceUri = "https://localhost:44320/api/CoolProducts";
            HttpClient client = new HttpClient();
            //string result = client.GetStringAsync(serviceUri).Result;
            List<Product> products = client.GetFromJsonAsync<List<Product>>(serviceUri).Result;

            foreach (var item in products)
            {
                Console.WriteLine(item.name);
            }

        }
    }
}