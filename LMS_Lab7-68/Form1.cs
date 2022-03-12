using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Lab7_68
{
    public partial class Form1 : Form
    {
        List<Course> courses=new List<Course>();
        List<Student> students=new List<Student>();
        List<Teacher>teachers=new List<Teacher>();
        public Form1()
        {
            InitializeComponent();
        }

        private void coursetypecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher1 = new Teacher(teachernametextbox.Text, teachertypecombobox.SelectedItem.ToString());
            teachers.Add(teacher1);
            
           
            teachercombobox.Items.Add(teacher1.teachername);
           
            MessageBox.Show("Teacher has been added");
        }

        private void button3_Click(object sender, EventArgs e)
        {      
            foreach(Teacher teacher1 in teachers)
            {
                if(teachercombobox.SelectedItem.ToString()==teacher1.teachername)
                {
                    Teacher teacher = new Teacher(coursecodetextbox.Text, coursetypecombobox.SelectedItem.ToString(), coursetitletextbox.Text, semestercombobox.SelectedItem.ToString(), teacher1.teachername);
                    teachers.Add(teacher);
                }
            }
        }
    }
}
