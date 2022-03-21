using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTask2_168
{
    public partial class Form1 : Form
    {
        List<Student> stud = new List<Student>();
        List<Teacher> teach = new List<Teacher>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studsavebutton_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            

            s.setstudent_info(studentidtextbox.Text, studentnametextbox.Text, studentdeptextbox.Text, studentsemestertextbox.Text);
            stud.Add(s);
            MessageBox.Show("Student details saved successfully");
            //studentdetailsbox.Items.Clear();
            //for (int i = 0; i < stud.Count; i++)
            //{
            //  studentdetailsbox.Items.Add(stud[i].getstudent_info());
            // }
        }

        private void studclearbutton_Click(object sender, EventArgs e)
        {
            studentidtextbox.Text = "";
            studentnametextbox.Text = "";
            studentdeptextbox.Text = "";
            studentsemestertextbox.Text = "";
            MessageBox.Show("Student fields cleared successfully");
            
        }
    

        private void studentdetailsviewbutton_Click(object sender, EventArgs e)
        {
            studentdetailsbox.Items.Clear();                
            for (int i = 0; i <stud.Count; i++)
            {
                studentdetailsbox.Items.Add(stud[i].getstudent_info());
                
            }

        }

        private void teachersavebutton_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.setteacher_info(teacheridtextbox.Text, teachernametextbox.Text, teacherdeptextbox.Text, designationtextbox.Text, salarytextbox.Text);
            teach.Add(t);
            MessageBox.Show("Teacher Details saved successfully");//////
            //teacherdetailsbox.Items.Clear();
            //for (int i = 0; i < teach.Count; i++)
            // {
             // teacherdetailsbox.Items.Add(teach[i].getteacher_info());
          //  }
        }

        private void teacherclearbutton_Click(object sender, EventArgs e)
        {
            teacheridtextbox.Text = "";
            teachernametextbox.Text = "";
            teacherdeptextbox.Text = "";
            designationtextbox.Text = "";
            salarytextbox.Text = "";
            MessageBox.Show("Teacher fields cleared successfully");
        }

        private void teacherdetailsviewbutton_Click(object sender, EventArgs e)
        {
            teacherdetailsbox.Items.Clear();
            for (int i = 0; i < teach.Count; i++)
            {
                teacherdetailsbox.Items.Add(teach[i].getteacher_info());
            }
        }
    }
}
