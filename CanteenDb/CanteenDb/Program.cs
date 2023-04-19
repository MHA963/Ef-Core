// See https://aka.ms/new-console-template for more information

using CanteenDb.Models;
using CanteenDb;

public class Program
{
    static void Main()
    {
        //#region Inserting Data into the database

        //using (var dbContext = new myDbContext())
        //{
        //    #region Creating dummy data for Canteen, Customer, Reservation and Staff
        //    ////Creating dummy data for canteen
        //    var canteen1 = new Canteen { CanteenName = "canteen 1", postCode = 8200 };
        //    var canteen2 = new Canteen { CanteenName = "canteen 2", postCode = 8210 };
        //    var canteen3 = new Canteen { CanteenName = "canteen 3", postCode = 8000 };

        //    //Creating dummy data for customer
        //    var customer1 = new Customer { AUID = "000001" };
        //    var customer2 = new Customer { AUID = "000002" };
        //    var customer3 = new Customer { AUID = "000003" };
        //    var customer4 = new Customer { AUID = "000004" };

        //    //Creating Dummy data for Reservation
        //    var reservation1 = new Reservation
        //    { AUID = "000001", Customer = customer1, CanteenName = "Canteen 1", MealName = "Kebab" };
        //    var reservation2 = new Reservation
        //    { AUID = "000002", Customer = customer2, CanteenName = "Canteen 3", MealName = "Pita" };
        //    var reservation3 = new Reservation
        //    { AUID = "000003", Customer = customer3, CanteenName = "Canteen 3", MealName = "Soup" };
        //    var reservation4 = new Reservation
        //    { AUID = "000004", Customer = customer4, CanteenName = "Canteen 2", MealName = "Gulash" };

        //    ////Creating Dummy data for Staff
        //    var staff1 = new Staff { Name = "Jens B.", Title = "Cook", Salary = 30700, CanteenName = "Canteen 1" };
        //    var staff2 = new Staff { Name = "Mette C.", Title = "Waiter", Salary = 29000, CanteenName = "Canteen 1" };
        //    var staff3 = new Staff { Name = "Mads D.", Title = "Waiter", Salary = 29000, CanteenName = "Canteen 1" };
        //    var staff4 = new Staff { Name = "Lucile E.", Title = "Cook", Salary = 30700, CanteenName = "Canteen 1" };


        //    //dbContext.Canteen.AddRange(canteen1, canteen2, canteen3);

        //    dbContext.Customer.AddRange(customer1, customer2, customer3, customer4);

        //    dbContext.Reservation.AddRange(reservation1, reservation2, reservation3, reservation4);

        //    //dbContext.Staff.AddRange(staff1, staff2, staff3, staff4);

        //    #endregion

        //    #region creating dummy data menu, reservationmenu and rating
        //    //adding the list for the generated dummy data
        //    var streetfood1 = new StreetFood { name = "burger" };
        //    var streetfood2 = new StreetFood { name = "taco" };
        //    var streetfood3 = new StreetFood { name = "hotdog" };

        //    // dummy data for warmdish
        //    var warmdish1 = new Warmdish { name = "spaghetti" };
        //    var warmdish2 = new Warmdish { name = "lasagna" };
        //    var warmdish3 = new Warmdish { name = "shepherd's pie" };

        //    // add dummy reservationmenu objects to the list
        //    dbContext.StreetFood.AddRange(streetfood1, streetfood2, streetfood3);
        //    dbContext.Warmdish.AddRange(warmdish1, warmdish2, warmdish3);
        //    // create some dummy data for ratings

        //    var rating1 = new Ratings { Rating = 5, CanteenName = "canteen 1", AUID = "000001" };
        //    var rating2 = new Ratings { Rating = 4, CanteenName = "canteen 2", AUID = "000002" };
        //    var rating3 = new Ratings { Rating = 3, CanteenName = "canteen 3", AUID = "000003" };
        //    var rating4 = new Ratings { Rating = 4, CanteenName = "canteen 1", AUID = "000001" };
        //    var rating5 = new Ratings { Rating = 2, CanteenName = "canteen 2", AUID = "000002" };
        //    var rating6 = new Ratings { Rating = 5, CanteenName = "canteen 3", AUID = "000003" };

        //    // add the dummy data to the dbcontext and save changes

        //    dbContext.Ratings.AddRange(rating1, rating2, rating3, rating4, rating5, rating6);

        //    // adding dummy data til jit and canceledmeals
        //    //var jit1 = new jitmeals {canteenname = "canteen 3", jitname = "burger"};
        //    //var jit2 = new jitmeals {canteenname = "canteen 2", jitname = "taco"};
        //    //var jit3 = new jitmeals {canteenname = "canteen 3", jitname = "hotdog"};

        //    var canceledmeals1 = new CanceledMeals { CanteenName = "canteen 1", CanceledMealsName = "spaghetti" };
        //    var canceledmeals2 = new CanceledMeals { CanteenName = "canteen 2", CanceledMealsName = "lasagna" };
        //    var canceledmeals3 = new CanceledMeals { CanteenName = "canteen 3", CanceledMealsName = "shepherd's pie" };
        //    var rsrvlist = new Reservationlist { CanteenName = "canteen 1", MealName = "spaghetti" };
        //    var rsrvlist2 = new Reservationlist { CanteenName = "canteen 1", MealName = "lasagna" };
        //    var rsrvlist3 = new Reservationlist { CanteenName = "canteen 1", MealName = "lasagna" };
        //    var rsrvlist4 = new Reservationlist { CanteenName = "canteen 1", MealName = "spaghetti" };


        //    dbContext.CanceledMeals.AddRange(canceledmeals1, canceledmeals2, canceledmeals3);
        //    dbContext.Reservationlist.AddRange(rsrvlist, rsrvlist2, rsrvlist3, rsrvlist4);

        //    dbContext.SaveChanges();
        //#endregion

        //}

        //#endregion

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
                .Where(r => r.AUID == cprValue)
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


            //// Query JIT meal option from JIT table
            //var jitMealOption = dbContext.JITMeals
            //    .Where(sf => sf.Canteen.CanteenName == canteenName)
            //    .Select(sf => new
            //    {
            //        sf.JITName
            //    })
            //    .FirstOrDefault();

            // Query available Canceled meals from Canceled table
            var canceledMeals = dbContext.CanceledMeals
                .Where(wd => wd.Canteen.CanteenName == canteenName)
                .Select(wd => new
                {
                    wd.CanceledMealsName
                })
                .ToList();

            //// Output the JIT meal option
            //Console.WriteLine($"JIT meal option for {canteenName}:");
            //if (jitMealOption != null)
            //{
            //    Console.WriteLine($"- Meal Name: {jitMealOption.JITName}");
            //}
            //else
            //{
            //    Console.WriteLine("No JIT meal option available.");
            //}

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
                    Console.WriteLine(
                        $"- Canteen Name: {canceledMeal.CanteenName}, Meal Name: {canceledMeal.MealName}");
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

            var staffData = dbContext.Staff.Select(s => new {s.Name, s.Title, s.Salary}).ToList();

            foreach (var staff in staffData)
            {
                Console.WriteLine($"Name: {staff.Name}, Title: {staff.Title}, Salary: {staff.Salary}");
            }


        }
        #endregion
    }

}


