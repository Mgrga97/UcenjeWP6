using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace EdunovaAPP.Data
{
    public class EdunovaContext : DbContext 
    {
        public EdunovaContext(DbContextOptions<EdunovaContext> options) : base(options)
        {
            // ovdje bi upravljali s razlicitim opcijama

        }

        public DbSet<Smjer> Smjerovi { get; set; }


    }
    
    
}
