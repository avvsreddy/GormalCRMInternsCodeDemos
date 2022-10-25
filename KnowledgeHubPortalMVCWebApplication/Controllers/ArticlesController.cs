using KnowledgeHubPortalMVCWebApplication.Models.DataAccess;
using KnowledgeHubPortalMVCWebApplication.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KnowledgeHubPortalMVCWebApplication.Controllers
{
    public class ArticlesController : Controller
    {
        IArticlesRepository articlesRepo = null;// new ArticlesRepository();
        ICatagoriesRepository catagoriesRepo = null;// new CatagoriesRepository();

        public ArticlesController(IArticlesRepository articlesRepo, ICatagoriesRepository catagoriesRepo)
        {
            this.articlesRepo = articlesRepo;
            this.catagoriesRepo = catagoriesRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Submit()
        {
            // get all catagories
            var catagories = catagoriesRepo.GetCatagories();
            var selectCatagories = from cat in catagories
                                   select new SelectListItem { Text = cat.Name, Value = cat.CatagoryID.ToString() };
            ViewBag.SelectCatagories = selectCatagories;

            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Submit(Article article)
        {
            // server side validatation
            //if (!ModelState.IsValid)
            //    return View();

            article.DateSubmitted = DateTime.Now;
            article.IsApproved = false;
            article.SubmittedBy = User.Identity.Name;
            articlesRepo.Submit(article);
            TempData["Message"] = $"Article {article.Title} is submited for review";
            return RedirectToAction("Submit");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Review(int catid = 0)
        {
            // fetch pending articles

            List<Article> articlesForReview = new List<Article>();
            if (catid == 0)
                articlesForReview = articlesRepo.GetArticlesForReview();
            else
                articlesForReview = articlesRepo.GetArticlesForReview().Where(a => a.CatagoryID == catid).ToList();

            var catagories = from c in catagoriesRepo.GetCatagories()
                             select new SelectListItem { Text = c.Name, Value = c.CatagoryID.ToString() };
            ViewBag.Catagories = catagories;
            return View(articlesForReview);
        }
        [Authorize(Roles = "admin")]
        public IActionResult Approve(List<int> articleids)
        {
            articlesRepo.Approve(articleids);
            TempData["Message"] = $" {articleids.Count} Articles approved successfully";
            return RedirectToAction("Review");
        }
        [Authorize(Roles = "admin")]
        public IActionResult Reject(List<int> articleids)
        {
            articlesRepo.Reject(articleids);
            TempData["Message"] = $" {articleids.Count} Articles rejected successfully";
            return RedirectToAction("Review");
        }

        public IActionResult Browse(int catid = 0)
        {
            // fetch pending articles

            List<Article> articlesForBrowse = new List<Article>();
            if (catid == 0)
                articlesForBrowse = articlesRepo.GetArticlesForBrowse();
            else
                articlesForBrowse = articlesRepo.GetArticlesForBrowse().Where(a => a.CatagoryID == catid).ToList();

            var catagories = from c in catagoriesRepo.GetCatagories()
                             select new SelectListItem { Text = c.Name, Value = c.CatagoryID.ToString() };
            ViewBag.Catagories = catagories;
            return View(articlesForBrowse);
        }


    }
}
