using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CanteenDb.Models
{
    public class Ratings
    {
        [Key]
        public int Rating { get; set; }
        public string CanteenName { get; set; }
        public string CPR { get; set; }
    }
}
