namespace ContactManagerApplication.DataLayer
{
    public interface IContactsRepository
    {
        void Save(Contact contactToSave);
        Contact GetContactByName(string name);
        List<Contact> GetContactsByLocation(string location);

        List<Contact> GetAllContacts();

        void Edit(Contact contactToEdit);
        void Delete(string name);

    }
}
