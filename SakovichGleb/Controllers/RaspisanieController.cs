using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using SakovichGleb.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.Controllers
{
    [Authorize]
    public class RaspisanieController : Controller
    {
        private readonly IUser userRepository;
        private readonly IRaspisanie raspisanieRepository;
        public RaspisanieController(IUser userRepository, IRaspisanie raspisanieRepository)
        {
            this.userRepository = userRepository;
            this.raspisanieRepository = raspisanieRepository;
        }

        public IActionResult Index()
        {
            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            User user = userRepository.FindByLogin(login);
            Raspisanie raspisanie;
            RaspisanieViewModel raspisanieViewModel;
            if (raspisanieRepository.FindByUserIdAndDay(user.Id, DayOfWeek.Monday) == null)
            {
                raspisanie = new Raspisanie
                {
                    idUser = user.Id,
                    Name = "Выбор,Выбор,Выбор,Выбор,Выбор,Выбор,Выбор,Выбор,Выбор,Выбор",
                    User = user,
                    Day = DayOfWeek.Monday
                };
                raspisanieRepository.SaveRaspisanie(raspisanie);
            }
            else
            {
                raspisanie = raspisanieRepository.FindByUserIdAndDay(user.Id, DayOfWeek.Monday);
            }
            raspisanieViewModel = new RaspisanieViewModel
            {
                Raspisanie = raspisanie,
                Name = raspisanie.Name.Split(','),
                Day = raspisanie.Day
            };
            return View(raspisanieViewModel);
        }

        [HttpPost]
        public IActionResult Index(RaspisanieViewModel raspisanieViewModel)
        {
            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            User user = userRepository.FindByLogin(login);
            Raspisanie raspisanie;

            string fullName = "";
            for (int i = 0; i < raspisanieViewModel.Name.Length; i++)
            {
                if (i == raspisanieViewModel.Name.Length - 1)
                    fullName += raspisanieViewModel.Name[i];
                else
                    fullName += raspisanieViewModel.Name[i] + ",";
            }

            if (raspisanieRepository.FindByUserIdAndDay(user.Id, raspisanieViewModel.Day) == null)
            {
                raspisanie = new Raspisanie
                {
                    idUser = user.Id,
                    Name = fullName,
                    User = user,
                    Day = raspisanieViewModel.Day
                };
                raspisanieRepository.SaveRaspisanie(raspisanie);
            }
            else
            {
                raspisanie = raspisanieRepository.FindByUserIdAndDay(user.Id, raspisanieViewModel.Day);
            }
            raspisanieViewModel.Raspisanie = raspisanie;

            raspisanieRepository.SaveRaspisanie(raspisanieViewModel.Raspisanie);

            return View(raspisanieViewModel);
        }
    }
}
