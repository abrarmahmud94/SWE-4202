using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_task_03
{
    internal class N2B_Building
    {   List<Lecture_Room>lecturerooms=new List<Lecture_Room>(); 
        List<Lab>labs=new List<Lab>();  
       public Lab lab=new Lab();
          

       public Lecture_Room lecture_room = new Lecture_Room();
       

      public string showAllLabs()
        {
            foreach(Lab lab in labs)
            {
                return lab.getLabName();

            }
        }
        public string showAllLectureRoom()
        {
            foreach (Lecture_Room lecture_room in lecturerooms)
            {
                return lecture_room.getRoomName();
            }
        }
    }
}
