using Microsoft.EntityFrameworkCore;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakovichGleb.Data.Repository
{
    public class RaspisanieRepository : IRaspisanie
    {
        private readonly AppDbContext appDbContext;

        public RaspisanieRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Raspisanie> GetRaspisanie()
        {
            return appDbContext.Raspisanies;
        }

        public void DeleteRaspisanie(Raspisanie raspisanie)
        {
            appDbContext.Raspisanies.Remove(raspisanie);
            appDbContext.SaveChanges();
        }

        public Raspisanie FindByUserId(int id)
        {
            return appDbContext.Raspisanies.FirstOrDefault(x => x.idUser == id);
        }

        public Raspisanie FindByUserIdAndDay(int id, DayOfWeek day)
        {
            return appDbContext.Raspisanies.FirstOrDefault(x => x.idUser == id && x.Day == day);
        }
        public Raspisanie FindByUserIdAndDayAndSmena(int id, DayOfWeek day, Smena smena)
        {
            return appDbContext.Raspisanies.FirstOrDefault(x => x.idUser == id && x.Day == day && x.Smena == smena);
        }
        public int SaveRaspisanie(Raspisanie raspisanie)
        {
            if (raspisanie.Id == default)
                appDbContext.Entry(raspisanie).State = EntityState.Added;
            else
                appDbContext.Entry(raspisanie).State = EntityState.Modified;
            appDbContext.SaveChanges();

            return raspisanie.Id;
        }
    }
}
