using Microsoft.AspNetCore.Mvc;

namespace Mart.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
