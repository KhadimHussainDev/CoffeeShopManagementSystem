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
    internal class MenuItemDL
    {
        static public List<MenuItem> menu = new List<MenuItem>();
       
        public static void addItemsIntoMenuList(MenuItem item)
        {
            menu.Add(item);
        }
     
       
        public static MenuItem cheapestItem()
        {
            List<MenuItem> items = menu.OrderBy(x => x.getPrice()).ToList();
            return items[0];
        }
       
        public static List<MenuItem> drinksOnly()
        {
            List<MenuItem> list = new List<MenuItem>();
            foreach (MenuItem menuItem in menu)
            {
                if (menuItem.getType() == "Drinks")
                {
                    list.Add(menuItem);
                }
            }
            return list;
        }
        public static List<MenuItem> foodOnly()
        {
            List<MenuItem> list = new List<MenuItem>();
            foreach (MenuItem menuItem in menu)
            {
                if (menuItem.getType() == "Food")
                {
                    list.Add(menuItem);
                }
            }
            return list;
        }
        public static void loadMenuItem()
        {
            string path = "Menu.txt";
            StreamReader sr=new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] record = line.Split(',');
                string name=record[0];
                string type=record[1];
                int price=int.Parse(record[2]);
                MenuItem item=new MenuItem(name,type,price);
                addItemsIntoMenuList(item);
            }
        }

        public static void storeMenuItem()
        {
            string path = "Menu.txt";
            StreamWriter sw = new StreamWriter(path,false);
            foreach (MenuItem menuItem in menu)
            {
                sw.WriteLine(menuItem.getName()+","+menuItem.getType() + "," +menuItem.getPrice());    
            }
            sw.Flush();
            sw.Close();
        }
    }
}
