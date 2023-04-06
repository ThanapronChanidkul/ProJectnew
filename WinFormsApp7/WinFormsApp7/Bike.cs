using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    internal class Bike : Vehicle
    {
        private string company;

        public Bike(string name, string price, string quantity, string company) : base (name,price, quantity)
        {
            this.company = company;
        }
        public string getCompany() 
        {
            return company; 
        }
    }
}
