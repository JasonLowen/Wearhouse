using Microsoft.AspNetCore.Mvc;

namespace WearHouse.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
