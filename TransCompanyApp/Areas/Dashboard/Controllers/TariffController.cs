using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransCompanyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace TransCompanyApp.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TariffController : Controller
    {
        private BaseContext _db;

        public TariffController(BaseContext context)
        {
            _db = context;
        }

        public async Task<IActionResult> Index()
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
                return RedirectToAction("index");
            }
            return RedirectToAction("index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Tariff tariff = await _db.Tariffs.FirstOrDefaultAsync(p => p.Id == id);
                if (tariff != null)
                {
                    return View(tariff);
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Tariff tariff = await _db.Tariffs.FirstOrDefaultAsync(p => p.Id == id);
                if (tariff != null)
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