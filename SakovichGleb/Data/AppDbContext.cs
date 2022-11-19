using Microsoft.EntityFrameworkCore;
using SakovichGleb.Data.Models;

namespace SakovichGleb.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Semestr> Semestrs { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<NHours> NHourses { get; set; }
    }
}
