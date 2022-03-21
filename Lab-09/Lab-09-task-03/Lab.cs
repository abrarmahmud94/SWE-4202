using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_task_03
{
    internal class Lab
    {
         string labName;
         string capacity;

        public string getLabName()
        {
            return labName;
        }
        public string getcapacity()
        {
            return capacity;
        }
        public void setName(string setname)
        {
            this.labName = setname;
        }
        public void setCapacity(string capacity)
        {
            this.capacity = capacity;
        }
    }
}
