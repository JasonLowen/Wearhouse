using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WearHouse.Data;
using WearHouse.Models;
using WearHouse.Models.Domain;

namespace WearHouse.Controllers
{
    public class LoginController : Controller
    {
        private readonly WearHouseDbContext wearHouseDbContext;

        public LoginController(WearHouseDbContext wearHouseDbContext)
        {
            this.wearHouseDbContext = wearHouseDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginValidationViewModel addLoginRequest)
        {

            var login = await wearHouseDbContext.RegisDatas.ToListAsync();

            bool isValid = false;
            foreach (var user in login)
            {
                if(user.Email == addLoginRequest.Email && user.Password == addLoginRequest.Password)
                {
                    isValid = true;
                    break;
                }
            }

            if (isValid)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View("Index");
            }
            
        }

    }
}
