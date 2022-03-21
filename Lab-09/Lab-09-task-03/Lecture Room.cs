using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_task_03
{
    internal class Lecture_Room
    {
        string roomName;
         string roomNo;
        string capacity;
        public string getRoomName()
        {
            return roomName;

        }
        public string getRoomNo()
        {
            return roomNo;
        }
        public string getCapacity()
        {
            return capacity;
        }
        public void setCapacity(string cap)
        {
            capacity = cap;
        }
        public void setRoomName(string roomname)
        {
            roomName = roomname;

        }
        public void setRoomNo(string roomno)
        {
            this.roomNo = roomno;
        }
    }
}
