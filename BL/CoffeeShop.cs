using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop_Management_System.UI;
using Cofee_Shop_Management_System.DL;

namespace Cofee_Shop_Management_System.BL
{
    internal class CoffeeShop
    {
        private string name;
        private List<MenuItem> menu;
        private List<string> orders;
        public string getName() { return name; }
        public List<MenuItem> getMenu() { return menu; }
        public List<string> getOrders() { return orders; }  
        public void setName(string name) { this.name = name; }
        public void setOrders(List<string> orders) { this.orders = orders; }
        public void setMenu(List<MenuItem> menu) { this.menu = menu; }
        public CoffeeShop(string name)
        {
            this.name = name;
            menu = new List<MenuItem>();
            orders = new List<string>();
        }
        
    }
}
