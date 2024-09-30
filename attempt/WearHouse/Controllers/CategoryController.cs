using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WearHouse.Data;
using WearHouse.Models;
using WearHouse.Models.Domain;

namespace WearHouse.Controllers
{
    public class CategoryController : Controller
    {
        private readonly WearHouseDbContext wearHouseDbContext;

        public CategoryController(WearHouseDbContext wearHouseDbContext)
        {
            this.wearHouseDbContext = wearHouseDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var category = await wearHouseDbContext.Categories.ToListAsync();
            return View(category);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCategoryViewModel addCategoryRequest)
        {
            var category = new Category()
            {
                Id = Guid.NewGuid(),
                CategoryName = addCategoryRequest.CategoryName
            };

            await wearHouseDbContext.Categories.AddAsync(category);
            await wearHouseDbContext.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var category = await wearHouseDbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);

            if(category != null)
            {
                var viewCategory = new EditCategoryViewModel()
                {
                    Id = category.Id,
                    CategoryName = category.CategoryName
                };

                return View(viewCategory);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCategoryViewModel editModel)
        {
            var category = await wearHouseDbContext.Categories.FindAsync(editModel.Id);

            if(category != null)
            {
                category.CategoryName = editModel.CategoryName;

                await wearHouseDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
                
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EditCategoryViewModel deleteModel)
        {
            var category = await wearHouseDbContext.Categories.FindAsync(deleteModel.Id);

            if(category != null)
            {
                wearHouseDbContext.Categories.Remove(category);
                await wearHouseDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}
