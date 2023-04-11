using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CanteenDb.Models
{
    public class Canteen
    {
        [Key]
        public string CanteenName { get; set; }
        public float AvgRating { get; set; }
        public int postCode { get; set; }

    }
}
