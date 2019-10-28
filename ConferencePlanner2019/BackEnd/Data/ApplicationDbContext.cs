using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{   

    /// <summary>
    /// this is the connection obj for our DB
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}