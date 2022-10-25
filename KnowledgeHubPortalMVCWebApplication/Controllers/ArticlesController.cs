using KnowledgeHubPortalMVCWebApplication.Models.DataAccess;
using KnowledgeHubPortalMVCWebApplication.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KnowledgeHubPortalMVCWebApplication.Controllers
{
    public class ArticlesController : Controller
    {
        IArticlesRepository articlesRepo = new ArticlesRepository();
        ICatagoriesRepository catagoriesRepo = new CatagoriesRepository();
        public IActionResult Index()
        {
            return View();
        }
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
        [HttpPost]
        public IActionResult Submit(Article article)
        {
            // server side validatation
            //if (!ModelState.IsValid)
            //    return View();

            article.DateSubmitted = DateTime.Now;
            article.IsApproved = false;
            article.SubmittedBy = "Unknow";//User.Identity.Name;
            articlesRepo.Submit(article);
            TempData["Message"] = $"Article {article.Title} is submited for review";
            return RedirectToAction("Submit");
        }
    }
}
