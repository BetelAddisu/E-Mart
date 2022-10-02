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
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Picture")]Color color)
        {
            if (ModelState.IsValid)
            {
                return View(color);
            }
            await _service.AddAsync(color);
            return RedirectToAction(nameof(Index)); 

        }

        //GET by id

        public async Task<IActionResult> Details(int id)
        {
            var colorDetails = _service.GetByIdAsync(id);

            if (colorDetails == null) {
                return View("Not Found");
            }
            return View(colorDetails);  

        }

        public async Task<IActionResult> Edit(int id)
        {
            var colorDetails = _service.GetByIdAsync(id);

            if (colorDetails == null)
            {
                return View("Not Found");
            }
            return View(colorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Picture")] Color color)
        {

            if (ModelState.IsValid)
            {
                return View(color);
            }
            await _service.UpdateAsync(id, color);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            var colorDetails = _service.GetByIdAsync(id);

            if (colorDetails == null)
            {
                return View("Not Found");
            }
            return View(colorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConferimed(int id)
        {
            var colorDetails =  _service.GetByIdAsync(id);
            if (colorDetails == null)
            {
                return View("Not Found");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }

    }
}
