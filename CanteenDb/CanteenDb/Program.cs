// See https://aka.ms/new-console-template for more information

using CanteenDb.Models;
using CanteenDb;

public class Program
{
    static void Main()
    {
        #region Inserting Data into the database
        //using (var dbContext = new myDbContext())
        //{
        //    //    //    #region Creating dummy data for Canteen, Customer and Reservation
        //    //    //    //Creating dummy data for canteen
        //    //    //    var canteen1 = new Canteen { CanteenName = "Canteen 1", postCode = 8200 };
        //    //    //    var canteen2 = new Canteen { CanteenName = "Canteen 2", postCode = 8210 };
        //    //    //    var canteen3 = new Canteen { CanteenName = "Canteen 3", postCode = 8000 };

        //    //    //    //Creating dummy data for customer
        //    //    //    var customer1 = new Customer { CPR = "000001" };
        //    //    //    var customer2 = new Customer { CPR = "000002" };
        //    //    //    var customer3 = new Customer { CPR = "000003" };
        //    //    //    var customer4 = new Customer { CPR = "000004" };

        //    //    //    //Creating Dummy data for Reservation
        //    //    //    var reservation1 = new Reservation { CPR = "000001", Customer = customer1, CanteenName = "Canteen 1", MealName = "Kebab" };
        //    //    //    var reservation2 = new Reservation { CPR = "000002", Customer = customer2, CanteenName = "Canteen 3", MealName = "Pita" };
        //    //    //    var reservation3 = new Reservation { CPR = "000003", Customer = customer3, CanteenName = "Canteen 3", MealName = "Soup" };
        //    //    //    var reservation4 = new Reservation { CPR = "000004", Customer = customer4, CanteenName = "Canteen 2", MealName = "Gulash" };


        //    //    //    dbContext.Canteen.AddRange(canteen1, canteen2, canteen3);

        //    //    //    dbContext.Customer.AddRange(customer1, customer2, customer3, customer4);

        //    //    //    dbContext.Reservation.AddRange(reservation1, reservation2, reservation3, reservation4);
        //    //    //    #endregion

        //    //    //    #region Creating dummy data Menu, ReservationMenu and Rating


        //    //    //    //adding the list for the generated dummy data
        //    //    //    var streetFood1 = new StreetFood { name = "Burger" };
        //    //    //    var streetFood2 = new StreetFood { name = "Taco" };
        //    //    //    var streetFood3 = new StreetFood { name = "Hotdog" };

        //    //    //    // Dummy data for WarmDish
        //    //    //    var warmDish1 = new Warmdish { name = "Spaghetti" };
        //    //    //    var warmDish2 = new Warmdish { name = "Lasagna" };
        //    //    //    var warmDish3 = new Warmdish { name = "Shepherd's Pie" };

        //    //    //    // Add dummy ReservationMenu objects to the list
        //    //    //    dbContext.StreetFood.AddRange(streetFood1, streetFood2, streetFood3);
        //    //    //    dbContext.Warmdish.AddRange(warmDish1, warmDish2, warmDish3);
        //    //    //    // Create some dummy data for Ratings

        //            ////var rating1 = new Ratings { Rating = 5, CanteenName = "Canteen 1", CPR = "000001" };
        //            ////var rating2 = new Ratings { Rating = 4, CanteenName = "Canteen 2", CPR = "000002" };
        //            ////var rating3 = new Ratings { Rating = 3, CanteenName = "Canteen 3", CPR = "000003" };
        //            ////var rating4 = new Ratings { Rating = 4, CanteenName = "Canteen 1", CPR = "000001" };
        //            ////var rating5 = new Ratings { Rating = 2, CanteenName = "Canteen 2", CPR = "000002" };
        //            ////var rating6 = new Ratings { Rating = 5, CanteenName = "Canteen 3", CPR = "000003" };

        ////    //    // Add the dummy data to the DbContext and save changes

        ////    //    dbContext.Ratings.AddRange(rating1, rating2, rating3);

        ////    //// Adding dummy data til JIT and CanceledMeals 
        ////    //var JIT1 = new JITMeals { CanteenName = "Canteen 3", JITName = "Burger" };
        ////    //var JIT2 = new JITMeals { CanteenName = "Canteen 2", JITName = "Taco" };
        ////    //var JIT3 = new JITMeals {CanteenName = "Canteen 3", JITName = "Hotdog" };

        ////    //var canceledMeals1 = new CanceledMeals { CanteenName = "Canteen 1", CanceledMealsName = "Spaghetti" };
        ////    //var canceledMeals2 = new CanceledMeals { CanteenName = "Canteen 2", CanceledMealsName = "Lasagna" };
        ////    //var canceledMeals3 = new CanceledMeals { CanteenName = "Canteen 3", CanceledMealsName = "Shepherd's Pie" };
        ////    //var rsrvlist = new Reservationlist{CanteenName = "Canteen 1", MealName = "Spaghetti" };
        ////var rsrvlist2 = new Reservationlist { CanteenName = "Canteen 1", MealName = "Lasagna" };
        ////var rsrvlist3 = new Reservationlist { CanteenName = "Canteen 1", MealName = "Lasagna" };
        ////var rsrvlist4 = new Reservationlist { CanteenName = "Canteen 1", MealName = "Spaghetti" };  




        //      // dbContext.SaveChanges();
        ////    //    #endregion

        //}
        #endregion

        #region Pulling data from the database
        using (var dbContext = new myDbContext()) // Replace with your actual DbContext name
        {

            // Input canteen name
            string canteenName = "Canteen 1"; // Replace with the input canteen name

            // Query to get the menu options for the input canteen name
            var menuOptions = dbContext.StreetFood
                .Where(rm => rm.Canteen.CanteenName == canteenName)
                .Select(rm => new
                {
                    rm.name
                })
                .ToList();
            var menuOptions2 = dbContext.Warmdish
                .Where(rm => rm.Canteen.CanteenName == canteenName)
                .Select(rm => new
                {
                    rm.name
                })
                .ToList();

            // Join the two queries using Union
            var combinedMenuOptions = menuOptions.Union(menuOptions2).ToList();

            // Output the menu options
            Console.WriteLine($"Menu options for {canteenName}:");
            foreach (var menuOption in combinedMenuOptions)
            {
                Console.WriteLine($"- Meal Name: {menuOption.name}");
            }

            Console.WriteLine("------------------------------------------------");

            // Define the CPR value for which you want to retrieve reservations
            string cprValue = "000001"; // Replace with the actual CPR value

            // Query reservations based on CPR value
            var reservations = dbContext.Reservation
                .Where(r => r.CPR == cprValue)
                .ToList();

            // Output the reservations
            Console.WriteLine($"Reservations for CPR: {cprValue}");
            foreach (var reservation in reservations)
            {
                Console.WriteLine($"- Reservation ID: {reservation.ReservationId}");
                Console.WriteLine($"- Canteen Name: {reservation.CanteenName}");
                Console.WriteLine($"- Meal Name: {reservation.MealName}");
                // Output other relevant reservation properties as needed
            }

            Console.WriteLine("------------------------------------------------");


            // Query reservations and group by MealName, counting the occurrences of each meal
            var reservationCounts = dbContext.Reservationlist
                .GroupBy(r => r.MealName)
                .Select(g => new
                {
                    MealName = g.Key,
                    Amount = g.Count()
                })
                .ToList();

            // Output the meal counts
            Console.WriteLine("Meal counts:");
            foreach (var reservationCount in reservationCounts)
            {
                Console.WriteLine($"- Meal Name: {reservationCount.MealName}");
                Console.WriteLine($"- Amount: {reservationCount.Amount}");
            }

            Console.WriteLine("------------------------------------------------");


            // Query JIT meal option from JIT table
            var jitMealOption = dbContext.JITMeals
                .Where(sf => sf.Canteen.CanteenName == canteenName)
                .Select(sf => new
                {
                    sf.JITName
                })
                .FirstOrDefault();

            // Query available Canceled meals from Canceled table
            var canceledMeals = dbContext.CanceledMeals
                .Where(wd => wd.Canteen.CanteenName == canteenName)
                .Select(wd => new
                {
                    wd.CanceledMealsName
                })
                .ToList();

            // Output the JIT meal option
            Console.WriteLine($"JIT meal option for {canteenName}:");
            if (jitMealOption != null)
            {
                Console.WriteLine($"- Meal Name: {jitMealOption.JITName}");
            }
            else
            {
                Console.WriteLine("No JIT meal option available.");
            }

            // Output the available Canceled meals
            Console.WriteLine($"Available Canceled meals for {canteenName}:");
            if (canceledMeals.Any())
            {
                foreach (var canceledMeal in canceledMeals)
                {
                    Console.WriteLine($"- Meal Name: {canceledMeal.CanceledMealsName}");
                }
            }
            else
            {
                Console.WriteLine("No available Canceled meals.");
            }



            Console.WriteLine("------------------------------------------------");

            // Query available Canceled meals from Warmdish table in canteens except for Canteen1
            var canceledMeals2 = dbContext.Warmdish
                .Where(wd => wd.Canteen.CanteenName != canteenName)
                .Select(wd => new
                {
                    CanteenName = wd.Canteen.CanteenName,
                    MealName = wd.name
                })
                .ToList();

            // Output the available Canceled meals
            Console.WriteLine($"Available Canceled meals in canteens except for {canteenName}:");
            if (canceledMeals.Any())
            {
                foreach (var canceledMeal in canceledMeals2)
                {
                    Console.WriteLine($"- Canteen Name: {canceledMeal.CanteenName}, Meal Name: {canceledMeal.MealName}");
                }
            }
            else
            {
                Console.WriteLine("No available Canceled meals.");
            }


            Console.WriteLine("------------------------------------------------");
            
            // Query and calculate average ratings from all canteens
            var averageRatings = dbContext.Ratings
                .GroupBy(r => r.CanteenName)
                .Select(g => new
                {
                    CanteenName = g.Key,
                    AverageRating = g.Average(r => r.Rating)
                })
                .OrderByDescending(g => g.AverageRating)
                .ToList();

            // Output the average ratings
            Console.WriteLine("Average Ratings from all canteens:");
            if (averageRatings.Any())
            {
                foreach (var rating in averageRatings)
                {
                    Console.WriteLine($"- Canteen Name: {rating.CanteenName}, Average Rating: {rating.AverageRating}");
                }
            }
            else
            {
                Console.WriteLine("No ratings found.");
            }






        }

        #endregion

        Console.WriteLine("Data pulled successfully!");
            Console.WriteLine("Goodbye, World!");



        }
    }


