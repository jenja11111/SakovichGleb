using Microsoft.EntityFrameworkCore;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SakovichGleb.Data.Repository
{
    public class SemestrRepository : ISemestr
    {
        private readonly AppDbContext appDbContext;

        public SemestrRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Semestr> GetSemestrs()
        {
            return appDbContext.Semestrs;
        }

        public void DeleteSemestr(Semestr semestr)
        {
            appDbContext.Semestrs.Remove(semestr);
            appDbContext.SaveChanges();
        }

        public Semestr FindById(int id)
        {
            return appDbContext.Semestrs.Single(x => x.Id == id);
        }

        public int SaveSemestr(Semestr semestr)
        {
            if (semestr.Id == default)
                appDbContext.Entry(semestr).State = EntityState.Added;
            else
                appDbContext.Entry(semestr).State = EntityState.Modified;
            appDbContext.SaveChanges();

            return semestr.Id;
        }
    }
}
