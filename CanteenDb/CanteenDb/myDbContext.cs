using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace CanteenDb
{
    public class myDbContext : DbContext
    {
        public DbSet<Canteen> Canteen { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Meals> Meals { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SqlConnection;Persist Security Info=True;User ID=sa;Password=220170Aa");
        }

    }
}
