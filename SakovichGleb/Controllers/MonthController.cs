using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using SakovichGleb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.Controllers
{
    [Authorize]
    public class MonthController : Controller
    {
        private readonly IUser userRepository;
        private readonly IRaspisanie raspisanieRepository;

        public MonthController(IRaspisanie raspisanieRepository, IUser userRepository)
        {
            this.raspisanieRepository = raspisanieRepository;
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            MonthViewModel model = new MonthViewModel();

            var login = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Login").Value;
            User user = userRepository.FindByLogin(login);

            if (raspisanieRepository.GetRaspisanie().Where(x => x.idUser == user.Id) != null)
            {
                foreach (var raspisanie in raspisanieRepository.GetRaspisanie().Where(x => x.idUser == user.Id))
                {
                    for (int j = 0; j < raspisanie.Name.Split(',').Length; j++)
                    {
                        switch (raspisanie.Day)
                        {
                            case DayOfWeek.Monday:
                                if (raspisanie.Name.Split(',')[j] == "Лекции")
                                {
                                    model.Hours[0, 0] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Практики")
                                {
                                    model.Hours[0, 1] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Лабораторная")
                                {
                                    model.Hours[0, 2] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Консультация")
                                {
                                    model.Hours[0, 3] += 2;
                                }                 
                                break;
                            case DayOfWeek.Tuesday:
                                if (raspisanie.Name.Split(',')[j] == "Лекции")
                                {
                                    model.Hours[1, 0] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Практики")
                                {
                                    model.Hours[1, 1] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Лабораторная")
                                {
                                    model.Hours[1, 2] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Консультация")
                                {
                                    model.Hours[1, 3] += 2;
                                }
                                break;
                            case DayOfWeek.Wednesday:
                                if (raspisanie.Name.Split(',')[j] == "Лекции")
                                {
                                    model.Hours[2, 0] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Практики")
                                {
                                    model.Hours[2, 1] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Лабораторная")
                                {
                                    model.Hours[2, 2] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Консультация")
                                {
                                    model.Hours[2, 3] += 2;
                                }
                                break;
                            case DayOfWeek.Thursday:
                                if (raspisanie.Name.Split(',')[j] == "Лекции")
                                {
                                    model.Hours[3, 0] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Практики")
                                {
                                    model.Hours[3, 1] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Лабораторная")
                                {
                                    model.Hours[3, 2] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Консультация")
                                {
                                    model.Hours[3, 3] += 2;
                                }
                                break;
                            case DayOfWeek.Friday:
                                if (raspisanie.Name.Split(',')[j] == "Лекции")
                                {
                                    model.Hours[4, 0] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Практики")
                                {
                                    model.Hours[4, 1] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Лабораторная")
                                {
                                    model.Hours[4, 2] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Консультация")
                                {
                                    model.Hours[4, 3] += 2;
                                }
                                break;
                            case DayOfWeek.Saturday:
                                if (raspisanie.Name.Split(',')[j] == "Лекции")
                                {
                                    model.Hours[5, 0] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Практики")
                                {
                                    model.Hours[5, 1] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Лабораторная")
                                {
                                    model.Hours[5, 2] += 2;
                                }
                                else if (raspisanie.Name.Split(',')[j] == "Консультация")
                                {
                                    model.Hours[5, 3] += 2;
                                }
                                break;
                        }
                    }
                }
                return View(model);
            }
            return View();
        }
    }
}
