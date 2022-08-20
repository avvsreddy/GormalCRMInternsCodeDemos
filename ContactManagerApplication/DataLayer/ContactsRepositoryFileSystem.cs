namespace ContactManagerApplication.DataLayer
{
    public class ContactsRepositoryFileSystem : IContactsRepository
    {
        private static readonly string file = "e:/mycontacts.txt";
        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public void Edit(Contact contactToEdit)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAllContacts()
        {
            StreamReader sr = null;
            List<Contact> contacts = new List<Contact>();
            try
            {
                sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string csv = sr.ReadLine();
                    //string allData = sr.ReadToEnd();
                    string[] data = csv.Split(',');
                    Contact c = new Contact();
                    c.Name = data[0];
                    c.Email = data[1];
                    c.Mobile = data[2];
                    c.Location = data[3];
                    contacts.Add(c);
                }
            }
            finally
            {
                sr.Close();
            }
            return contacts;
        }

        public Contact GetContactByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetContactsByLocation(string location)
        {
            throw new NotImplementedException();
        }

        public void Save(Contact contactToSave)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(file, true);
                string csv = $"{contactToSave.Name},{contactToSave.Email},{contactToSave.Mobile},{contactToSave.Location}";
                sw.WriteLine(csv);
                //
                //sw.Close();
            }
            finally
            {
                sw.Close();
            }

        }
    }
}
