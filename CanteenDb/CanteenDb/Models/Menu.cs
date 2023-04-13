using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanteenDb.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }

        [ForeignKey("Canteen")]
        public string CanteenName { get; set; }
        public Canteen Canteen { get; set; }

        public string CanceledMeals { get; set; }
        //navigating to ReservationMenu as list
        public List<ReservationMenu> ReservationMenus { get; set; }
    }
}
