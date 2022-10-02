using Microsoft.AspNetCore.Mvc;

namespace Mart.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
