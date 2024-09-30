using Microsoft.AspNetCore.Mvc;

namespace WearHouse.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
