using KnowledgeHubPortalMVCWebApplication.Models.DataAccess;
using KnowledgeHubPortalMVCWebApplication.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHubPortalMVCWebApplication.Controllers
{
    public class CatagoriesController : Controller
    {

        ICatagoriesRepository repo = new CatagoriesRepository();


        // .../catagories/index
        public IActionResult Index(string data = null)
        {
            List<Catagory> catagories = null;
            if (data == null)
            {
                // fetch all catagories info from model
                catagories = repo.GetCatagories();
            }
            else
            {
                catagories = repo.Search(data);
            }
            return View(catagories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // return a view for collecting data
            return View();
        }

        [HttpPost]
        public IActionResult Create(Catagory catagory)
        {
            // collects data from view and send to model
            if (!ModelState.IsValid)
            {
                return View();
            }
            repo.Create(catagory);
            return RedirectToAction("Index");
        }

    }
}
