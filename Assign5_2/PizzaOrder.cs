using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assign5_2
{
    class PizzaOrder
    {  [Key]
        public int PizzaID { get; set; }
        [Required]
        public string PizzaName { get; set; }
        [Required]
        public string Toppings { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public char Size { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
