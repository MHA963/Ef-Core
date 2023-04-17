# Canteen Database Project with  Ef-Core
This project is a C# .NET Core application that provides a database context, myDbContext, for managing data related to a canteen. The myDbContext class inherits from DbContext in Entity Framework Core, and it includes DbSet properties for different entities such as Canteen, Customer, Ratings, Reservation, Reservationlist, ReservationMenu, CanceledMeals, StreetFood, Warmdish, and Staff. These DbSet properties represent database tables that can be queried and modified using LINQ queries and Entity Framework Core features.

The myDbContext class also includes a connection string, Connect, which specifies the database server, initial catalog, security credentials, and other settings for connecting to the SQL Server database. You can update this connection string with your own database server and credentials to connect to your own database.

This project serves as the data access layer for a canteen management system and can be used as a starting point for building a C# .NET Core application that interacts with a SQL Server database for managing canteen-related data.
