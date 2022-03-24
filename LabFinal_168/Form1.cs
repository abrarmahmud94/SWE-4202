using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LabFinal_168
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<StudentInfo> students = new List<StudentInfo>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            resultlistbox.Items.Add("ID" + "\t" + "\t" + "\t" + "Name" + "\t"+ "\t"  +"\t" + "\t" + "Percentage" +"\t"+ "\t" + "Grade");
            using (var reader = new StreamReader(@"D:\IUT\SWE4201MarkSheet.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    StudentInfo student = new StudentInfo();
                    student.id = values[0] == "" ? "0" : values[0]; ;
                    student.name = values[1];

                    student.attendance = values[2] == "" ? "0" : values[2];
                    student.quizes[0] = values[3] == "" ? "0" : values[3];
                    student.quizes[1] =values[4] == "" ? "0" : values[4];
                    student.quizes[2] =values[5]== "" ? "0" : values[5];
                    student.quizes[3] =values[6] == "" ? "0" : values[6];
                    int att=Convert.ToInt32(student.attendance);
                    int[] quiz = new int[4];
                    quiz[0] = Convert.ToInt32(student.quizes[0]);
                    quiz[1] = Convert.ToInt32(student.quizes[1]);
                    quiz[2] = Convert.ToInt32(student.quizes[2]);
                    quiz[3] = Convert.ToInt32(student.quizes[3]);



                   // quiz[0] = quiz1;
                  //  quiz[1] = quiz2;
                   // quiz[2] = quiz3;
                   // quiz[3] = quiz4;

                    student.mid = values[7]== "" ? "0" : values[7];

                    student.final =values[8]== "" ? "0" : values[8];
                    student.viva= values[9] == "" ? "0" : values[9];
                   Array.Sort(quiz);
                    student.percentage = (Convert.ToInt32(student.attendance) + quiz[1] +quiz[2]+quiz[3] + Convert.ToInt32(student.mid) + Convert.ToInt32(student.final) + Convert.ToInt32(student.viva))/3;

                    if(student.percentage>=80 && student.percentage<=100)
                    {
                        student.grade = "A+";

                    }
                    if (student.percentage >= 75 && student.percentage <= 79)
                    {
                        student.grade = "A";

                    }
                    if (student.percentage >= 70 && student.percentage <= 74)
                    {
                        student.grade = "A-";

                    }
                    if (student.percentage >= 65 && student.percentage <= 69)
                    {
                        student.grade = "B+";

                    }
                    if (student.percentage >= 60 && student.percentage <= 64)
                    {
                        student.grade = "B";

                    }
                    if (student.percentage >= 55 && student.percentage <= 59)
                    {
                        student.grade = "B-";

                    }
                    if (student.percentage >= 50 && student.percentage <= 54)
                    {
                        student.grade = "C+";

                    }
                    if (student.percentage >= 45 && student.percentage <= 49)
                    {
                        student.grade = "C";

                    }
                    if (student.percentage >= 40 && student.percentage <= 44)
                    {
                        student.grade = "D";

                    }
                    if (student.percentage >= 0 && student.percentage <= 39)
                    {
                        student.grade = "F";

                    }





                    students.Add(student);
                    resultlistbox.Items.Add(student.id +  "\t" + "\t" + student.name + "\t" + "\t" + "\t" + student.percentage+"%"+ "\t" +"\t" +student.grade);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int id = Convert.ToInt32(studentidtextbox.Text);
                var info = from student1 in students where Convert.ToInt32(student1.id) == id select student1;
                 StudentInfo student=info.FirstOrDefault();
                
                    informationlabel.Text = "Name:" + "\t" + student.name + "\n" + "Attendance:" + "\t" + student.attendance + "\n" +"QUIZ 1:" +"\t" +student.quizes[0] + "\n" + "Quiz 2:" + "\t" + student.quizes[1] + "\n" + "Quiz 3:" +"\t"+ student.quizes[2]+"\n" +"Quiz 4:"+student.quizes[3]+ "\n"+ "Mid" + "\t" + student.mid + "\n" + " Final:" + "\t" + student.final + "\n" + "Viva" + "\t" + student.viva + "\n" + "Percentage" + "\t" + student.percentage + "\n" + "Grade" + "\t" + student.grade;
                
            
        }
    }
}
