using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Lab7_68
{
    internal class Student:Course
    {
        public string studentname;
        public Student(string studentname, string semester, string coursetitle):base( semester, coursetitle)
        {
            this.studentname = studentname;
            this.semester = semester;
             this.coursetitle = coursetitle;
        }
    }
}
