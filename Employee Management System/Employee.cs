using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Employee
    {
        public string name;
        public string contactno;
        public string employeetype;
        public int serviceprovided;
        public static int employeeID=0;
        public int salary;
        public double currentsalary;

        public Employee(string name, string employeetype, string contactno, int serviceprovided, int salary)

        {
            this.name = name;
            this.contactno = contactno;
            this.salary = salary;
            this.employeetype=employeetype;
            this.serviceprovided = serviceprovided;
        

        }
      

    }
}
