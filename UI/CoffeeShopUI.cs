using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop_Management_System.BL;
using Cofee_Shop_Management_System.DL;
namespace Cofee_Shop_Management_System.UI
{
    internal class CoffeeShopUI
    {
        public static string addOrder()
        {
            Console.WriteLine("Enter name of Item : ");
            string name = Console.ReadLine();
            return name;
        }
        public static void fulfillOrder()
        {
            foreach (string order in CoffeShopDL.orders)
            {
                Console.WriteLine("This " + order + " is ready!");
            }
            if (CoffeShopDL.orders.Count == 0)
            {
                Console.WriteLine("All orders have been fulfilled!");
            }

        }
        public static void ordersList()
        {
            Console.WriteLine();
            foreach (string order in CoffeShopDL.orders)
            {
                Console.WriteLine(order);
            }
            if (CoffeShopDL.orders.Count == 0)
            {
                Console.WriteLine("No orders is placed yet!");
            }
        }
    }
}
