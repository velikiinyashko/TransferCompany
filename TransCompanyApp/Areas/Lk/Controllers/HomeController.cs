using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransCompanyApp.Models;
using TransCompanyApp.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace TransCompanyApp.Areas.Lk.Controllers
{
    [Area("Lk")]
    public class HomeController : Controller
    {
        private BaseContext _db;

        public HomeController(BaseContext context)
        {
            _db = context;
        }

        [Authorize]
        public IActionResult Index(int? Id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                User account = await _db.Users.FirstOrDefaultAsync(u => u.Login == login.Name && u.Password == login.Password);
                if(User != null)
                {
                    await Authenticate(login.Name);
                    return Redirect("Index");
                }
                ModelState.AddModelError("", "Проверьте данные");
            }
            return View(login);
        }

        [HttpGet]
        private async Task<IActionResult> Register() => View();

        [HttpPost]
        private async Task<IActionResult> Register(RegisterViewModel register) => View();

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}