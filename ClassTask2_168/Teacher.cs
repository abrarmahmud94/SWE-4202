using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask2_168
{
    internal class Teacher
    {
        private string teacher_id;
        private string teacher_name;
        private string teacher_dept;
        private string teacher_designation;
        private string teacher_salary;
        public void setteacher_info(string id, string name, string dept, string des, string salary)
        {
            this.teacher_id = id;
            this.teacher_name = name;
            this.teacher_dept = dept;
            this.teacher_designation = des;
            this.teacher_salary = salary;
        }

        /* public void setteacherid(string id)
         {
             this.teacher_id = id;
         }

         public void setteachername(string n)
         {
             this.teacher_name = n;
         }

         public void setteacherdept(string d)
         {
             this.teacher_dept = d;
         }

         public void setteacherdesignation(string s)
         {
             this.teacher_designation = s;
         }

         public void setteachersalary(string a)
         {
             this.teacher_salary = a;
         }

 */
        

        public string getteacher_info()
        {
            string teacher_info = teacher_id + "\t" + teacher_name + "\t" + teacher_dept + "\t" + teacher_designation + "\t" + teacher_salary;
            return teacher_info;
        }
    }

}

