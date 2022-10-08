using KnowledgeHubPortalMVCWebApplication.Models.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHubPortalMVCWebApplication.Controllers
{
    public class CatagoriesController : Controller
    {

        ICatagoriesRepository repo = new CatagoriesRepository();

        public IActionResult Index()
        {
            // fetch the catagories info from model
            var catagories = repo.GetCatagories();
            return View(catagories);
        }
    }
}
