using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanteenDb.Models
{
    public class Reservationlist
    {
        [ForeignKey("Reservation")]
        public string MealName { get; set; }
        public Reservation Reservation { get; set; }

        [ForeignKey("Canteen")]
        public string CanteenName { get; set; }
        public Canteen Canteen { get; set; }


    }
}
