using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop_Management_System.UI;
using Cofee_Shop_Management_System.DL;
using Cofee_Shop_Management_System.BL;

namespace Cofee_Shop_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItemDL.loadMenuItem();
            CoffeShopDL.loadOrders();
            while (true)
            {
                int option = ShopUI.Options();
                if (option == 1)
                {
                    MenuItemDL.addItemsIntoMenuList(MenuItemUI.addItem());
                    MenuItemDL.storeMenuItem();
                }
                else if (option == 2)
                {
                    MenuItemUI.viewCheapestItem(MenuItemDL.cheapestItem());
                }
                else if (option == 3)
                {
                    List <MenuItem> list = MenuItemDL.drinksOnly();
                    MenuItemUI.displayDrinksMenu(list);
                }
                else if (option == 4)
                {
                    List<MenuItem> list = MenuItemDL.foodOnly();
                    MenuItemUI.displayFoodMenu(list);
                }
                else if (option == 5)
                {
                    string name=CoffeeShopUI.addOrder();
                    Console.Write(CoffeShopDL.addOrder(name));
                    CoffeShopDL.storeOrders();
                }
                else if (option == 6)
                {
                    List<string> list = CoffeShopDL.fulfillOrder();
                    CoffeeShopUI.fulfillOrder();
                    CoffeShopDL.orders.Clear();
                    CoffeShopDL.storeOrders();
                }
                else if (option == 7)
                {
                    CoffeeShopUI.ordersList();
                }
                else if (option == 8)
                {
                    float amount = CoffeShopDL.dueAmount();
                    ShopUI.dueAmount(amount);
                }
                else if (option == 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }

                ShopUI.clear();
            }
        }
    }
}

