﻿using System;
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
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Reservationlist> Reservationlist { get; set; }
        public DbSet<ReservationMenu> ReservationMenu { get; set; }
        public DbSet<JITMenu> JITMenu { get; set; }
        public DbSet<CanceledMeals> CanceledMeals { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SW4DABSpring23;User ID=sa;Password=<YourStrong@Passw0rd>;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasNoKey();
            modelBuilder.Entity<Reservationlist>().HasNoKey();
            modelBuilder.Entity<JITMenu>().HasNoKey();
            modelBuilder.Entity<CanceledMeals>().HasNoKey();

            // other configurations
        }

    }
}
