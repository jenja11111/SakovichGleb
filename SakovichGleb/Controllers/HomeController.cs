using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using SakovichGleb.ViewModels;
using System.Linq;

namespace SakovichGleb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUser userRepository;
        private HomeViewModel homeViewModel;

        public HomeController(IUser userRepository, HomeViewModel homeViewModel)
        {
            this.userRepository = userRepository;
            this.homeViewModel = homeViewModel;

        }
        public IActionResult Index()
        {
            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            if (login != null)
            {
                User user = userRepository.FindByLogin(login);
                if (user != null)
                {
                    homeViewModel.User = user;
                    return View(homeViewModel);
                }
                else
                    ModelState.AddModelError("", "Такого просто не может быть!");
            }
            else
                ModelState.AddModelError("", "Такого просто не может быть!");
            return View();
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel homeViewModeltest)
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
            return View(homeViewModeltest);
        }
    }
}
