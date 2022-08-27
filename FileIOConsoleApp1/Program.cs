namespace FileIOConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the file to search :");
            string file = Console.ReadLine();
            Console.Write("Enter the foler to search: ");
            string folder = Console.ReadLine();
            SearchFile(file, folder);


        }

        static void SearchFile(string file, string folder)
        {
            string search = $"{folder}\\{file}";
            Console.WriteLine(search);
            bool found = File.Exists(search);
            if (found)
                Console.WriteLine($"File {file} found in {folder}");
            else
                Console.WriteLine($"File {file} not found in {folder}");
        }
    }
}