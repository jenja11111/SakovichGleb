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
        private readonly ISemestr semestrRepository;
        private readonly IMonth monthRepository;
        private readonly INHours nHoursRepository;

        public MonthController(IUser userRepository, ISemestr semestrRepository, IMonth monthRepository, INHours nHoursRepository)
        {
            this.userRepository = userRepository;
            this.semestrRepository = semestrRepository;
            this.monthRepository = monthRepository;
            this.nHoursRepository = nHoursRepository;
        }

        public IActionResult Index()
        {
            MonthViewModel monthViewModel = new MonthViewModel();
            foreach(NHours nHours in nHoursRepository.GetNHourses().Where(x => x.IdMonth == 1))
            {
                if (nHours == null)
                {
                    for (int i = 0; i < 31; i++)
                        monthViewModel.NHourses.Add(new NHours());
                }
                else
                {
                    monthViewModel.NHourses.Add(nHours);
                }
            }
            return View(monthViewModel);
        }

        [HttpPost]
        public IActionResult Index(MonthViewModel monthViewModel)
        {
            foreach (var nHours in monthViewModel.NHourses)
            {
                nHoursRepository.SaveNHours(nHours);
            }
            return View(monthViewModel);
        }
    }
}
