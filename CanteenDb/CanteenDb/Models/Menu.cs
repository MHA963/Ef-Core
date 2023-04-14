using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanteenDb.Models
{

    public class CanceledMeals 
    {

        [ForeignKey("Canteen")]
        public string? CanteenName { get; set; }
        public Canteen? Canteen { get; set; }

       
        public string? CanceledMealsName { get; set; }
    }

    
    public class ReservationMenu
    {
        [Key]
        public int MenuId { get; set; }


        [ForeignKey("Canteen")]
        public string? CanteenName { get; set; }
        public Canteen? Canteen { get; set; }

    }

    public class StreetFood : ReservationMenu
    {

        public string? name { get; set; }
    }
    public class Warmdish : ReservationMenu
    {

        public string? name { get; set; }
    }

}
