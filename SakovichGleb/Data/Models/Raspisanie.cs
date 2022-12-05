using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.Data.Models
{
    public enum DayWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }
    public class Raspisanie
    {
        public int Id { get; set; }
        public DayOfWeek Day { get; set; }
        public string Name { get; set; }
        public int idUser { get; set; }
        public User User { get; set; }
    }
}
