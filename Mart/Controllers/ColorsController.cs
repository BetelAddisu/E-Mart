using Microsoft.AspNetCore.Mvc;

namespace Mart.Controllers
{
    public class ColorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
