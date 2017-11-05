using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransCompanyApp.Models;

namespace TransCompanyApp.Controllers
{
    public class DashboardController : Controller
    {
        private BaseContext _db;

        public DashboardController(BaseContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Configure()
        {
            return View(_db.Contacts.ToList());
        }

        public async Task<IActionResult> Orders()
        {
            return View(await _db.Orders.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Tariffed()
        {
            return View(await _db.Tariffs.ToListAsync());
        }

        [HttpPost]
        public IActionResult Create(Tariff tariff)
        {
            if (tariff != null)
            {
                _db.Tariffs.Add(tariff);
                _db.SaveChanges();
                return RedirectToAction("Tariffed");
            }
            return RedirectToAction("Tariffed");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if(id != null)
            {
                Tariff tariff = await _db.Tariffs.FirstOrDefaultAsync(p => p.Id == id);
                if(tariff != null)
                {
                    return View(tariff);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id != null)
            {
                Tariff tariff = await _db.Tariffs.FirstOrDefaultAsync(p => p.Id == id);
                if(tariff != null)
                {
                    _db.Tariffs.Remove(tariff);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Tariffed");
                }
            }
            return NotFound();
        }
    }
}
