using Mart.Data;
using Microsoft.AspNetCore.Mvc;
using Mart.Models;
using System;
using Mart.Data.Services;

namespace Mart.Controllers
{
    public class ColorsController : Controller
    {
        private readonly IColorsService _service;

        


        public ColorsController(IColorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
