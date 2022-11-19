using Microsoft.EntityFrameworkCore;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SakovichGleb.Data.Repository
{
    public class NHoursRepository : INHours
    {
        private readonly AppDbContext appDbContext;

        public NHoursRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<NHours> GetNHourses()
        {
            return appDbContext.NHourses;
        }
        public void DeleteNHours(NHours nHours)
        {
            appDbContext.NHourses.Remove(nHours);
            appDbContext.SaveChanges();
        }

        public NHours FindById(int id)
        {
            return appDbContext.NHourses.Single(x => x.Id == id);
        }

        public int SaveNHours(NHours nHours)
        {
            if (nHours.Id == default)
                appDbContext.Entry(nHours).State = EntityState.Added;
            else
                appDbContext.Entry(nHours).State = EntityState.Modified;
            appDbContext.SaveChanges();

            return nHours.Id;
        }
    }
}
