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
        [ForeignKey("Canteen")]
        public string CanteenName { get; set; }
        public Canteen Canteen { get; set; }
    }

    public class JIT : Menu
    {
    }

    public class CanceledMenu : Menu
    {
    }

}
