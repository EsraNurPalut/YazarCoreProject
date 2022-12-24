using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> Index(User p)
        //{
        //    Context c = new Context();
        //    var datavalue = c.Users.FirstOrDefault(x => x.UserName == p.UserName && x.UserPassword == p.UserPassword);
        //    if (datavalue != null)
        //    {
        //        var claims = new List<Claim> //talepler
        //        {
        //            new Claim(ClaimTypes.Name,p.UserName)
        //        };
        //        var useridentity = new ClaimsIdentity(claims, "A");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        return View();
        //    }

        //}

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(User user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName, user.UserPassword, user.UserRole, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Hatalı Giriş");

            }
            return View(user);
        }
    }

