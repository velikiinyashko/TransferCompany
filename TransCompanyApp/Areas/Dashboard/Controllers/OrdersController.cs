using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransCompanyApp.Models;
using TransCompanyApp.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace TransCompanyApp.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class OrdersController : Controller
    {
        private BaseContext _db;

        public OrdersController(BaseContext context)
        {
            _db = context;
        }

        public async Task<IActionResult> Index(int? Id)
        {
            if (Id == null)
            {
                return View(await _db.Orders.ToListAsync());
            }
            else
            {
                return View();
            }
        }
    }
}