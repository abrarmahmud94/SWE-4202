using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Medicine
    {
        public string medicinename;
        public string numberofmedicine;
        public string quantity;
        public string priceperpiece;
         public Medicine(string medicinename,string quantity)
        {
            this.medicinename= medicinename;
            this.quantity = quantity;
            
        }

    }
}
