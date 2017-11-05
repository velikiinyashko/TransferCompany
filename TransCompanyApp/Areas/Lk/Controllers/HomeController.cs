using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TransCompanyApp.Areas.Lk.Controllers
{
    [Area("Lk")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}