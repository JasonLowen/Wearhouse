using Microsoft.AspNetCore.Mvc;

namespace WearHouse.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Landing()
        {
            return View();
        }
    }
}
