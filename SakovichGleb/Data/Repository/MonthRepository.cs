using Microsoft.EntityFrameworkCore;
using SakovichGleb.Data.Interfaces;
using SakovichGleb.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SakovichGleb.Data.Repository
{
    public class MonthRepository : IMonth
    {
        private readonly AppDbContext appDbContext;

        public MonthRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Month> GetMonths()
        {
            return appDbContext.Months;
        }
        public void DeleteMonth(Month month)
        {
            appDbContext.Months.Remove(month);
            appDbContext.SaveChanges();
        }

        public Month FindById(int id)
        {
            return appDbContext.Months.Single(x => x.Id == id);
        }

        public int SaveMonth(Month month)
        {
            if (month.Id == default)
                appDbContext.Entry(month).State = EntityState.Added;
            else
                appDbContext.Entry(month).State = EntityState.Modified;
            appDbContext.SaveChanges();

            return month.Id;
        }
    }
}
