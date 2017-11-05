using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransCompanyApp.Models;
using TransCompanyApp.ViewModel;

namespace TransCompanyApp.Controllers
{
    public class WebController : Controller
    {
        private BaseContext _db;
        private List<Tariff> _tariffs;
        private List<Order> _orders;

        public WebController(BaseContext context)
        {
            _db = context;
            _tariffs = _db.Tariffs.ToList();
            _orders = _db.Orders.ToList();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_db.Orders.ToList());
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

        [HttpGet]
        public IActionResult Order(int? TariffId)
        {
            List<TariffModel> TariffMod = _tariffs.Select(c => new TariffModel { Id = c.Id, Name = c.TariffName }).ToList();

            OrderViewModel order = new OrderViewModel { Orders = _orders, Tariffs = TariffMod };
            return View(order);
        }

        [HttpPost]
        public IActionResult Order(Order order)
        {
            _db.Orders.Add(order);
            _db.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Create(int? OrderId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (order != null)
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
                return RedirectToAction("Order");
            }
            return RedirectToAction("Order");
        }
    }
}
