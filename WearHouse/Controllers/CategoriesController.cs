using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WearHouse.Data;
using WearHouse.Models;
using WearHouse.Models.Domain;

namespace WearHouse.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly WearHouseData wearhouseData;

        public CategoriesController(WearHouseData wearhouseData)
        {
            this.wearhouseData = wearhouseData;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await wearhouseData.Categories.ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Category()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAdd(AddCategoryViewModel addCategoryRequest)
        {
            var category = new Category()
            {
                Id = Guid.NewGuid(),
                CategoryName = addCategoryRequest.CategoryName
            };
            
            await wearhouseData.Categories.AddAsync(category);
            await wearhouseData.SaveChangesAsync();
            return RedirectToAction("Category");

        }

    }
}
