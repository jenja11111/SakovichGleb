using SakovichGleb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.ViewModels
{
    public class RaspisanieViewModel
    {
        public Raspisanie Raspisanie { get; set; }
        public DayOfWeek Day { get; set; }
        public Smena Smena { get; set; }
        public string[] Name { get; set; }
    }
}
