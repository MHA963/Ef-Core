using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenDb.Models
{
    public class ReservationMenu
    {
        [Key]
        public int ReservationMenuId { get; set; }

        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }

        public string StreetFood { get; set; }
        public string WarmDish { get; set; }

    }
}
