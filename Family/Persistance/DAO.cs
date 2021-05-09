using Family_Management.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Family.Persistance
{
    public class DAO:DbContext
    {
        public DbSet<Adult> Adults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= /Users/satish/RiderProjects/DNP/Family/DAO.db");
        }
    }
    }
