using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using CanteenDb.Models;


namespace CanteenDb
{
    public class myDbContext : DbContext
    {
        public DbSet<Canteen> Canteen { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Reservationlist> Reservationlist { get; set; }
        public DbSet<ReservationMenu> ReservationMenu { get; set; }
        public DbSet<CanceledMeals> CanceledMeals { get; set; }
       
        public DbSet<StreetFood> StreetFood { get; set; }
        public DbSet<Warmdish> Warmdish { get; set; }

        //Connection String to the database
        public string Connect = "Data Source=localhost;Initial Catalog=SqlConnection;Persist Security Info=True;User ID=sa;Password=0988220170Aa;TrustServerCertificate=True;";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connect);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservationlist>().HasNoKey();
            modelBuilder.Entity<CanceledMeals>().HasNoKey();

            // Configure other relationships if needed

            // Call base class method to complete the model configuration
            base.OnModelCreating(modelBuilder);

            // other configurations
        }

    }
}
