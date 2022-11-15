using Microsoft.EntityFrameworkCore;

namespace IndividualPlan.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }
    }
}
