using KnowledgeHubPortalMVCWebApplication.Models.Entities;

namespace KnowledgeHubPortalMVCWebApplication.Models.DataAccess
{
    public interface ICatagoriesRepository
    {
        void Create(Catagory catagory);
        List<Catagory> GetCatagories();
        Catagory GetCatagory(int id);

        void Edit(Catagory catagory);

        void Delete(int id);

    }
}
