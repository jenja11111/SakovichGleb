using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using SakovichGleb.Data;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Linq;
using SakovichGleb.ViewModels;

namespace SakovichGleb.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUser userRepository;
        private readonly AppDbContext appDbContext;

        public UserController(AppDbContext appDbContext, IUser users)
        {
            userRepository = users;
            this.appDbContext = appDbContext;

        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = userRepository.FindByLoginAndPassword(model.Login, model.Password);
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim("Login", model.Login)
                    };
                    var climeIdentity = new ClaimsIdentity(claims, "Cookie");
                    var climePrincipal = new ClaimsPrincipal(climeIdentity);
                    await HttpContext.SignInAsync("Cookie", climePrincipal);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином или паролем нет");
                }
            }

            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel registerUser)
        {
            if (ModelState.IsValid)
            {
                User user = appDbContext.Users.FirstOrDefault(u => u.Login == registerUser.Login && u.Password == registerUser.Password);

                if (user == null)
                {
                    appDbContext.Users.Add(new User
                    {
                        Login = registerUser.Login,
                        Password = registerUser.Password,
                        Surname = "Фамилия",
                        FName = "Имя",
                        LName = "Отчество"
                    });
                    appDbContext.SaveChanges();
                    user = appDbContext.Users.Where(u => u.Login == registerUser.Login && u.Password == registerUser.Password).FirstOrDefault();
                    if (user != null)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim("Login", user.Login)
                        };
                        var climeIdentity = new ClaimsIdentity(claims, "Cookie");
                        var climePrincipal = new ClaimsPrincipal(climeIdentity);
                        await HttpContext.SignInAsync("Cookie", climePrincipal);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
            }
            return View(registerUser);
        }

        public IActionResult LogOff()
        {
            HttpContext.SignOutAsync("Cookie");
            return Redirect("/User/Login");
        }
    }
}
