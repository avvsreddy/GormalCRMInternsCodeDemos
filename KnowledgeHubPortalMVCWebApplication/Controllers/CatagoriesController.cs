using KnowledgeHubPortalMVCWebApplication.Models.DataAccess;
using KnowledgeHubPortalMVCWebApplication.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeHubPortalMVCWebApplication.Controllers
{
    [Authorize(Roles = "admin")]
    public class CatagoriesController : Controller
    {

        ICatagoriesRepository repo = null;// new CatagoriesRepository();

        public CatagoriesController(ICatagoriesRepository repo)
        {
            this.repo = repo;
        }

        //[AllowAnonymous]
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


            //ViewBag.Message = "sdfsdfsd";
            //ViewData["Message"] = "sdfsdfsd";
            TempData["Message"] = $"Catagory {catagory.Name} created successfully";

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            repo.Delete(id);
            TempData["Message"] = $"Catagory Id {id} deleted successfully";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var catagoryToEdit = repo.GetCatagory(id);
            return View(catagoryToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Catagory catagory)
        {
            // collects data from view and send to model
            if (!ModelState.IsValid)
            {
                return View();
            }
            repo.Edit(catagory);


            //ViewBag.Message = "sdfsdfsd";
            //ViewData["Message"] = "sdfsdfsd";
            TempData["Message"] = $"Catagory {catagory.CatagoryID} edited successfully";

            return RedirectToAction("Index");
        }
    }
}
