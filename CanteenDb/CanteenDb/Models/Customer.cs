using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CanteenDb.Models
{
    public class Customer
    {
        [Key]
        public string? CPR { get; set; }
     
    }
}
