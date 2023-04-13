using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenDb.Models
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Salary { get; set; }
        [ForeignKey("Canteen")]
        public string CanteenName { get; set; }
        public Canteen Canteen { get; set; }
    }
}
