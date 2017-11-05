using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransCompanyApp.Models;

namespace TransCompanyApp.Controllers
{
    public class CpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Account account)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register(Account account)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register()
        {
            return View();
        }
    }
}