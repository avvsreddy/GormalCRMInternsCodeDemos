using ContactManagerApplication.DataLayer;

namespace ContactManagerApplication.UILayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Contact Management Application");
                    Console.WriteLine("-------------> Main Menu <-----------------");
                    Console.WriteLine("1. Save Contact");
                    Console.WriteLine("2. Display All Contacts");
                    Console.WriteLine("3. Search Contact By Name");
                    Console.WriteLine("4. Search Contact By Location");
                    Console.WriteLine("5. Edit Contact");
                    Console.WriteLine("6. Delete Contact");
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: SaveContact(); break;
                        case 2: DisplayAllContacts(); break;
                        case 3: SerachByName(); break;
                        case 4: SearchByLocation(); break;
                        case 5: EditContact(); break;
                        case 6: DeleteContact(); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }
        private static void SaveContact()
        {
            Contact c = new Contact();
            Console.Write("Enter Contact Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Enter Email: ");
            c.Email = Console.ReadLine();
            Console.Write("Enter Mobile Number: ");
            c.Mobile = Console.ReadLine();
            Console.Write("Enter Location: ");
            c.Location = Console.ReadLine();
            IContactsRepository repo = new ContactsRepositoryFileSystem();
            repo.Save(c);
        }
        private static void DisplayAllContacts()
        {
            IContactsRepository repo = new ContactsRepositoryFileSystem();
            List<Contact> contacts = repo.GetAllContacts();
            Console.WriteLine("Name\tEmail\tMobile\tLocaton");
            foreach (var c in contacts)
            {
                Console.WriteLine($"{c.Name}\t{c.Email}\t{c.Mobile}\t{c.Location}");
            }


        }
        private static void SerachByName() { }
        private static void SearchByLocation() { }
        private static void EditContact() { }
        private static void DeleteContact() { }

    }
}