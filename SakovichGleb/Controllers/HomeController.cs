using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using SakovichGleb.Data.Repository;
using SakovichGleb.ViewModels;
using System.Linq;

namespace SakovichGleb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUser userRepository;

        public HomeController(IUser userRepository)
        {
            this.userRepository = userRepository;

        }
        public IActionResult Index()
        {
            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            if (login != null)
            {
                User user = userRepository.FindByLogin(login);
                if (user != null && user.Login == "Admin")
                {
                    return RedirectToAction("IndexAdmin");
                }
                else if (user != null && user.Login != "Admin")
                {
                    return View(user);
                }
                else
                    ModelState.AddModelError("", "Такого просто не может быть!");
            }
            else
                ModelState.AddModelError("", "Такого просто не может быть!");
            return View();
        }
        public IActionResult IndexAdmin()
        {
            return View(userRepository);
        }

        [HttpPost]
        public IActionResult IndexAdmin(UserRepository userRepository)
        {
            return View(userRepository);
        }

        [HttpPost]
        public IActionResult Index(User usertest)
        {
            if (ModelState.IsValid)
            {
                var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
                if (login != null)
                {
                    User user = userRepository.FindByLogin(login);
                    if (user != null)
                    {
                        
                    }
                    else
                        ModelState.AddModelError("", "Такого просто не может быть!");
                }
                else
                    ModelState.AddModelError("", "Такого просто не может быть!");
            }
            return View(usertest);
        }
    }
}
