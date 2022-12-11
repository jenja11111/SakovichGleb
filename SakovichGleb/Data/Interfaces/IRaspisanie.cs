using SakovichGleb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.Data.Interfaces
{
    public interface IRaspisanie
    {
        public IEnumerable<Raspisanie> GetRaspisanie();
        public Raspisanie FindByUserId(int id);
        public Raspisanie FindByUserIdAndDay(int id, DayOfWeek day);
        public Raspisanie FindByUserIdAndDayAndSmena(int id, DayOfWeek day, Smena smena);
        public int SaveRaspisanie(Raspisanie raspisanie);
        public void DeleteRaspisanie(Raspisanie raspisanie);
    }
}
