using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           N2B_Building n2B_Building = new N2B_Building();
            n2B_Building.lab.setName("Lab 01") ;
            n2B_Building.lecture_room.setRoomName("Chem Lab");
            n2B_Building.showAllLabs.Add(n2B_Building) ;

        }
    }
}
