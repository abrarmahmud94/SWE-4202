using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Balance
    {
        public string name;
        public string number;
        public string add;
        public string priceperpiece;
       
         public  string previousbalance;
        public Balance(string previousbalance,string name,string number,string add,string priceperpiece)
        {
            this.previousbalance = previousbalance;
            this.name = name;
            this .number = number; 
            this .add = add;
            this .priceperpiece = priceperpiece;
        }
    }
}
