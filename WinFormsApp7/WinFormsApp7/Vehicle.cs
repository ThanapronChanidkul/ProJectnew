using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Vehicle
    {
        private string name;
        private string price;
        private string quantity;

        public Vehicle(string name, string price, string quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string getName()
        {
            return name;
        }

        public string getPrice()
        {
            return price;
        }
        public string getQuantity()
        {
            return quantity;
        }
    }
}
