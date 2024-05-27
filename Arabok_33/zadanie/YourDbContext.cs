using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task;

namespace zadanie
{
    public class YourDbContext : DbContext
    {
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Tourist> Tourists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\sqlite\\DBTur_firm.sqlite");
        }
    }
}
