using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Typewriter:Employee
    {
        public int employeeid;
        public Typewriter(string name, string employeetype, string contactno, int serviceprovided, int salary, int employeeid) : base(name, employeetype, contactno, serviceprovided, salary)
        {
            this.employeeid = employeeid;
        }
        public void current_salary()
        {
              int n = (serviceprovided / 12);
           
                currentsalary = (salary+salary* n* 0.05);
           
        }
    }
}
