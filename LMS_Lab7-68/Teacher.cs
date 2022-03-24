using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Lab7_68
{
    internal class Teacher:Course
    {
        public string teachername;
        public string teachertype;
        public Teacher(string teachername,string teachertype)
        {
            this.teachername = teachername; 
            this.teachertype = teachertype; 
        }
        public Teacher(string coursecode, string coursetype, string coursetitle, string semester,string teachername):base(coursecode,coursetype, coursetitle, semester)
        {
            this.coursecode = coursecode;
            this.coursetype = coursetype;
            this.coursetitle = coursetitle;
                this.semester = semester;
               this.teachername = teachername;
            
        }


    }
}
