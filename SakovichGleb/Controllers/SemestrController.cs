using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using SakovichGleb.Data.Repository;
using SakovichGleb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.Controllers
{
    [Authorize]
    public class SemestrController : Controller
    {
        private readonly IUser userRepository;
        private readonly ISemestr semestrRepository;

        public SemestrController(IUser userRepository, ISemestr semestrRepository)
        {
            this.userRepository = userRepository;
            this.semestrRepository = semestrRepository;
        }

        public IActionResult IndexSemestr1()
        {
            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            User user = userRepository.FindByLogin(login);
            SemestrViewModel semestrViewModel = new SemestrViewModel(user, 1);
            return View(semestrViewModel);
        }
        public IActionResult IndexSemestr2()
        {
            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            User user = userRepository.FindByLogin(login);
            SemestrViewModel semestrViewModel = new SemestrViewModel(user, 2);           
            return View(semestrViewModel);
        }

        [HttpPost]
        public IActionResult IndexSemestr2(SemestrViewModel semestrViewModel)
        {
            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            User user = userRepository.FindByLogin(login);

            return View(semestrViewModel);
        }

        [HttpPost]
        public IActionResult IndexSemestr1(SemestrViewModel semestrViewModel)
        {
            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            User user = userRepository.FindByLogin(login);

            return View(semestrViewModel);
        }
    }
}
