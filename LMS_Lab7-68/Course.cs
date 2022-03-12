using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Lab7_68
{
    internal class Course
    {
        public string coursecode;
        public string coursetype;
        public string coursetitle;
        public string semester;
        public Course(string coursecode,string coursetype,string coursetitle,string semester)
        {
            this.coursecode = coursecode;
            this.coursetype = coursetype;
            this.coursetitle = coursetitle;
                this.semester = semester;
        }
        public Course(string semester,string coursetitle)
        {
            this.semester = semester;
           this.coursetitle = coursetitle;

        }
        public Course()
        {

        }
    }
}
