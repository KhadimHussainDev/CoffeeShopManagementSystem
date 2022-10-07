using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop_Management_System.UI;
using Cofee_Shop_Management_System.BL;

namespace Cofee_Shop_Management_System.DL
{
    internal class CoffeShopDL
    {
        static public List<string> orders = new List<string>();
        public static void addOrderIntoOrderList(string name)
        {
            orders.Add(name);
        }
        public static List<string> fulfillOrder()
        {
            return orders;
        }
        public static float dueAmount()
        {
            float amount = 0f;
            foreach (string order in orders)
            {
                foreach (MenuItem item in MenuItemDL.menu)
                {
                    if (order == item.getName())
                    {
                        amount = amount + item.getPrice();
                    }
                }
            }
            return amount;
        }
        public static bool checkOrder(string name)
        {
            foreach (MenuItem item in MenuItemDL.menu)
            {
                if (item.getName() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static string addOrder(string name)
        {
            if (checkOrder(name))
            {
                addOrderIntoOrderList(name);
            }
            else
            {
                return "This item is currently unavailable!\n";
            }
            return null;
        }
        public static void loadOrders()
        {
            string path = "Orders.txt";
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                addOrderIntoOrderList(line);
            }
            sr.Close();
        }

        public static void storeOrders()
        {
            string path = "Orders.txt";
            StreamWriter sw = new StreamWriter(path, false);
            foreach (string order in orders)
            {
                sw.WriteLine(order);
            }
            sw.Flush();
            sw.Close();
        }
    }
}
