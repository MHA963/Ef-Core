﻿// <auto-generated />
using CanteenDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CanteenDb.Migrations
{
    [DbContext(typeof(myDbContext))]
    partial class myDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CanteenDb.Models.Canteen", b =>
                {
                    b.Property<string>("CanteenName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("AvgRating")
                        .HasColumnType("real");

                    b.Property<int>("postCode")
                        .HasColumnType("int");

                    b.HasKey("CanteenName");

                    b.ToTable("Canteen");
                });

            modelBuilder.Entity("CanteenDb.Models.Customer", b =>
                {
                    b.Property<string>("CPR")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CPR");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CanteenDb.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"));

                    b.Property<string>("CanteenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MenuId");

                    b.HasIndex("CanteenName");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("CanteenDb.Models.Ratings", b =>
                {
                    b.Property<int>("Rating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Rating"));

                    b.Property<string>("CPR")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CanteenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Rating");

                    b.HasIndex("CPR");

                    b.HasIndex("CanteenName");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("CanteenDb.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<string>("CPR")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CanteenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservationId");

                    b.HasIndex("CPR");

                    b.HasIndex("CanteenName");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("CanteenDb.Models.ReservationMenu", b =>
                {
                    b.Property<int>("ReservationMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationMenuId"));

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("StreetFood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarmDish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservationMenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("ReservationMenu");
                });

            modelBuilder.Entity("CanteenDb.Models.Reservationlist", b =>
                {
                    b.Property<string>("CanteenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CanteenName");

                    b.ToTable("Reservationlist");
                });

            modelBuilder.Entity("CanteenDb.Models.Menu", b =>
                {
                    b.HasOne("CanteenDb.Models.Canteen", "Canteen")
                        .WithMany()
                        .HasForeignKey("CanteenName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canteen");
                });

            modelBuilder.Entity("CanteenDb.Models.Ratings", b =>
                {
                    b.HasOne("CanteenDb.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CPR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CanteenDb.Models.Canteen", "Canteen")
                        .WithMany()
                        .HasForeignKey("CanteenName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canteen");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CanteenDb.Models.Reservation", b =>
                {
                    b.HasOne("CanteenDb.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CPR")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CanteenDb.Models.Canteen", "Canteen")
                        .WithMany()
                        .HasForeignKey("CanteenName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canteen");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CanteenDb.Models.ReservationMenu", b =>
                {
                    b.HasOne("CanteenDb.Models.Menu", "Menu")
                        .WithMany("ReservationMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("CanteenDb.Models.Reservationlist", b =>
                {
                    b.HasOne("CanteenDb.Models.Canteen", "Canteen")
                        .WithMany()
                        .HasForeignKey("CanteenName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canteen");
                });

            modelBuilder.Entity("CanteenDb.Models.Menu", b =>
                {
                    b.Navigation("ReservationMenus");
                });
#pragma warning restore 612, 618
        }
    }
}
