using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaOrder p1 = new PizzaOrder { PizzaID = 101, PizzaName = "Cheesy", Toppings = "Chicken", Type = "NonVeg", Size = 'M', Price = 56.80 };
            PizzaOrder p2 = new PizzaOrder { PizzaID = 102, PizzaName = "Paneer", Toppings = "Onion", Type = "Veg", Size = 'S', Price = 40.30 };
            PizzaEntities pe =new PizzaEntities();
            pe.PizzaOrders.Add(p1);
            pe.PizzaOrders.Add(p2);
            int res=pe.SaveChanges();
            if (res > 0)
                Console.WriteLine("Data Inserted");
        }
    }
}
