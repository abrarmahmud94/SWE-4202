using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();
      
            Teacher teacher = new Teacher();
            teacher.name = "AB";
            teacher.code = "2732";
            Console.WriteLine("Teacher      " + "Name:" + teacher.name + "        Code:" + teacher.code);
            Typist typist = new Typist();

            Officer officer = new Officer();
            officer.name = "Mushfiq";
            officer.code = "128329";
            officer.grade = "9th";
            Console.WriteLine("Officer       " + "Name:" + officer.name + "        Code:" + officer.code + "     grade:" + officer.grade);
            Regular regular = new Regular();
            regular.name = "Shoyeb";
            regular.code = "17842";
            regular.speed = "10 words persecond";
            Console.WriteLine("Regular Typist             " + "Name:" + regular.name + "        Code:" + regular.code+"   Speed:"+regular.speed);

            Casual casual = new Casual();
            casual.name = "Jaber";
            casual.speed = "12 words persecond";
            casual.code = "1432";
            casual.wages = "200 taka per hour";
           Console.WriteLine("Casual Typist             " + "Name:" + casual.name + "        Code:" + casual.code + "   Speed:" + casual.speed+ "      wages:" +casual.wages);
            Console.ReadKey();
        }
    }
}
