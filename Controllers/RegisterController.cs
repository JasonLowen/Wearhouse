using Microsoft.AspNetCore.Mvc;
using WearHouse.Data;
using WearHouse.Models.Domain;
using WearHouse.Models;

namespace WearHouse.Controllers
{
    public class RegisterController : Controller
    {
        private readonly WearHouseDbContext wearHouseDbContext;

        public RegisterController(WearHouseDbContext wearHouseDbContext)
        {
            this.wearHouseDbContext = wearHouseDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRegisterViewModel addRegisterRequest)
        {
            var regisdata = new RegisData()
            {
                Id = Guid.NewGuid(),
                Name = addRegisterRequest.Name,
                Email = addRegisterRequest.Email,
                Password = addRegisterRequest.Password
            };

            await wearHouseDbContext.RegisDatas.AddAsync(regisdata);
            await wearHouseDbContext.SaveChangesAsync();
            return RedirectToAction("Add");
        }
    }
}
