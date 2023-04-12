using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanteenDb.Models
{
    public class Ratings
    {
        [Key]
        public int Rating { get; set; }
        [ForeignKey("Canteen")]
        public string CanteenName { get; set; }
        public Canteen Canteen { get; set; }

        [ForeignKey("Customer")]
        public string CPR { get; set; }
        public Customer Customer { get; set; }
    }
}
