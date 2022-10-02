using Mart.Data;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Mart.Controllers
{
    public class ColorsController : Controller
    {
        private readonly AppDbContext _context;

        public ColorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Colors.ToList();
            return View();
        }
    }
}
