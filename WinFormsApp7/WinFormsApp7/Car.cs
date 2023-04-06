using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Car : Vehicle
    {
        private string oil;
        public Car(string name, string price, string quantity, string oil) : base(name,price,quantity)
        {
            this.oil = oil;
        }

        public string getOil()
        { 
            return oil; 
        }
    }
}
