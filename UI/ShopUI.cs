using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop_Management_System.BL;
using Cofee_Shop_Management_System.DL;

namespace Cofee_Shop_Management_System.UI
{
    internal class ShopUI
    {
        public static int Options()
        {
            Console.WriteLine("Welcome to the UET Coffee Shop\n\n1.Add a Menu item\n2.View the Cheapest Item in the menu\n3.View the Drink’s Menu\n4.View the Food’s Menu\n5.Add Order\n6.Fulfill the Order\n7.View the Orders’s List\n8.Total Payable Amount\n9.Exit");
            Console.Write("Your Option...");
            int option=int.Parse(Console.ReadLine());
            return option;
        }
        public static void dueAmount(float amount)
        {
            Console.WriteLine("Total Payable Amount is : "+amount);
        }
        public static void clear()
        {
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
