using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofee_Shop_Management_System.UI;
using Cofee_Shop_Management_System.DL;

namespace Cofee_Shop_Management_System.BL
{
    internal class MenuItem
    {
        private string name;
        private string type;
        private int price;
        public string getName() { return name; }
        public string getType() { return type; }
        public int getPrice() { return price; }
        public void setName(string name) { this.name = name; }
        public void setType(string type) { this.type = type; }
        public void setPrice(int price) { this.price = price; } 
        public MenuItem() { }
        public MenuItem(string name,string type,int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
    }
}
