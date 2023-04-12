using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanteenDb.Models
{
    public class Reservation
    {
        [Key]
        public int mealId { get; set; }

        [ForeignKey("Customer")]
        public string CPR { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Canteen")]
        public string CanteenName { get; set; }
        public Canteen Canteen { get; set; }
        
        //public bool IsCanceled { get; set; }
        public string MealName { get; set; }


    }
}
