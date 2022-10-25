using KnowledgeHubPortalMVCWebApplication.Models.Entities;

namespace KnowledgeHubPortalMVCWebApplication.Models.DataAccess
{
    public interface IArticlesRepository
    {
        void Submit(Article article);
        void Approve(List<int> articleIds);
        void Reject(List<int> articlesIds);
        List<Article> GetArticlesForBrowse();
        List<Article> GetArticlesForReview();

        List<Article> GetArticlesByCatagory(int catagoryID, bool approved);

    }
}
