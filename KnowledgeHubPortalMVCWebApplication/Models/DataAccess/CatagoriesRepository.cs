using KnowledgeHubPortalMVCWebApplication.Models.Entities;

namespace KnowledgeHubPortalMVCWebApplication.Models.DataAccess
{
    public class CatagoriesRepository : ICatagoriesRepository
    {

        private KHPortalDbContext db = new KHPortalDbContext();
        public void Create(Catagory catagory)
        {
            db.Catagories.Add(catagory);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var catagoryToDel = db.Catagories.Find(id);
            if (catagoryToDel == null)
                throw new Exception($"Catagory ID {id} is not found for deleting");
            db.Catagories.Remove(catagoryToDel);
            db.SaveChanges();
        }

        public void Edit(Catagory catagory)
        {
            db.Entry(catagory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public List<Catagory> GetCatagories()
        {
            return db.Catagories.ToList();
        }

        public Catagory GetCatagory(int id)
        {
            return db.Catagories.Find(id);
        }
    }
}
