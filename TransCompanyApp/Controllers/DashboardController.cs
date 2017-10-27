using Microsoft.AspNetCore.Mvc;
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
            return View(db.Contacts.ToList());
        }

        public IActionResult Orders()
        {
            return View();
        }
    }
}
