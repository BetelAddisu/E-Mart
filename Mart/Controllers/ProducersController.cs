using Microsoft.AspNetCore.Mvc;

namespace Mart.Controllers
{
    public class ProducersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
