using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop_Management_System.BL;
using Cofee_Shop_Management_System.DL;
namespace Cofee_Shop_Management_System.UI
{
    internal class MenuItemUI
    {
        public static MenuItem addItem()
        {
            Console.Write("\nEnter Name Of Menu Item : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Type Of Menu Item : ");
            Console.Write("1 For Food OR 2 For Drinks : ");
            int choice = int.Parse(Console.ReadLine());
            string type;
            if (choice == 1)
            {
                 type = "Food";
            }
            else
            {
                type = "Drinks";
            }
            Console.Write("Enter Price Of Menu Item : ");
            int price = int.Parse(Console.ReadLine());
            MenuItem item = new MenuItem(name,type,price);
            return item;
        }
        public static void displayDrinksMenu(List<MenuItem> drinks)
        {
            Console.WriteLine("Drinks Menu : ");
            Console.WriteLine("Name\tPrice");
            foreach (MenuItem drink in drinks)
            {
                Console.WriteLine(drink.getName() + "\t" + drink.getPrice());
            }
        }
        public static void displayFoodMenu(List<MenuItem> food)
        {
            Console.WriteLine("Food Menu : ");
            Console.WriteLine("Name\tPrice");
            foreach (MenuItem f in food)
            {
                Console.WriteLine(f.getName() + "\t" + f.getPrice());
            }
        }
        public static void viewCheapestItem(MenuItem item)
        {
            Console.WriteLine("Cheapest Item : ");
            Console.WriteLine(item.getName() + "\t" + item.getPrice());
        }
    }
}
