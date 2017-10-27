using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransCompanyApp.Models;

namespace TransCompanyApp.Controllers
{
    public class HomeController : Controller
    {
        BaseContext db;

        public HomeController(BaseContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Orders.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return View(db.Orders.ToList());
        }
    }
}
