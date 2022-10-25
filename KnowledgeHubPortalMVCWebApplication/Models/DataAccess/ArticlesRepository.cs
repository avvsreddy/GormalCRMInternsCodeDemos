using KnowledgeHubPortalMVCWebApplication.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortalMVCWebApplication.Models.DataAccess
{
    public class ArticlesRepository : IArticlesRepository
    {
        private KHPortalDbContext db = new KHPortalDbContext();
        public void Approve(List<int> articleIds)
        {
            foreach (var aid in articleIds)
            {
                foreach (var article in db.Articles)
                {
                    if (article.ArticleID == aid)
                    {
                        article.IsApproved = true;
                    }
                }
            }
            db.SaveChanges();
        }

        public List<Article> GetArticlesByCatagory(int catagoryID, bool approved)
        {
            List<Article> articles = new List<Article>();
            if (approved)
            {
                articles = (from a in db.Articles
                            where a.CatagoryID == catagoryID && a.IsApproved == true
                            select a).ToList();
            }
            else
            {
                articles = (from a in db.Articles
                            where a.CatagoryID == catagoryID && a.IsApproved == false
                            select a).ToList();
            }
            return articles;
        }

        public List<Article> GetArticlesForBrowse()
        {
            var articles = (from a in db.Articles
                            where a.IsApproved == true
                            select a).ToList();
            return articles;
        }

        public List<Article> GetArticlesForReview()
        {
            var articles = (from a in db.Articles.Include("Catagory")
                            where a.IsApproved == false
                            select a).ToList();
            return articles;
        }

        public void Reject(List<int> articlesIds)
        {
            foreach (var aid in articlesIds)
            {
                foreach (var article in db.Articles)
                {
                    if (article.ArticleID == aid)
                    {
                        db.Articles.Remove(article);
                    }
                }
            }
            db.SaveChanges();
        }

        public void Submit(Article article)
        {
            db.Articles.Add(article);
            db.SaveChanges();
        }
    }
}
