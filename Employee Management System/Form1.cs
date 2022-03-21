using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        List<Typewriter> typewriters = new List<Typewriter>();
        List<Manager> managers = new List<Manager>();
        List<Salesperson>salespersons=new List<Salesperson>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {    Employee.employeeID++;

            /*int servicetime = dateofjoiningdatetimepicker.Value.Month;
            int todaystime = DateTime.Now.Month;
            int servicetimef = todaystime - servicetime;
            namelabel.Text = servicetimef.ToString();*/
            int servicetime = (DateTime.Now.Year - dateofjoiningdatetimepicker.Value.Year) * 12 + (DateTime.Now.Month - dateofjoiningdatetimepicker.Value.Month);
            if (employeetypecombobox.SelectedItem.ToString()=="MANAGER")
            {
                Manager manager = new Manager(nametextbox.Text, employeetypecombobox.SelectedItem.ToString(), contactnotextbox.Text, servicetime, Convert.ToInt32(salarytextbox.Text), Employee.employeeID);
                managers.Add(manager);
            }
            if (employeetypecombobox.SelectedItem.ToString() == "SALESPERSON")
            {
                Salesperson salesperson = new Salesperson(nametextbox.Text, employeetypecombobox.SelectedItem.ToString(), contactnotextbox.Text, servicetime, Convert.ToInt32(salarytextbox.Text), Employee.employeeID);
                salespersons.Add(salesperson);
            }
            if (employeetypecombobox.SelectedItem.ToString() == "TYPEWRITER")
            {
                Typewriter typewriter = new Typewriter(nametextbox.Text, employeetypecombobox.SelectedItem.ToString(), contactnotextbox.Text, servicetime, Convert.ToInt32(salarytextbox.Text), Employee.employeeID);
                typewriters.Add(typewriter);
            }
            MessageBox.Show("Employee has been added and employee id is " + Employee.employeeID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Employee.employeeID.ToString() != employeeidtextbox.Text)
            {
                MessageBox.Show("Wrong Search.Try again");
            }
            else
            {
                foreach (Manager manager in managers)
                {
                    if (employeeidtextbox.Text == manager.employeeid.ToString())
                    {
                        namelabel.Text = manager.name;
                        contactnolabel.Text = manager.contactno;
                        serviceprovidedlabel.Text = manager.serviceprovided.ToString() + " Months";
                        employeeidlabel.Text = manager.employeeid.ToString();
                        currrentsalarylabel.Text = manager.salary.ToString();
                        manager.current_salary();
                        presentsalarylabel.Text = manager.currentsalary.ToString();
                        position.Text = manager.employeetype.ToString();

                    }
                }
                foreach (Salesperson salesperson in salespersons)
                {
                    if (employeeidtextbox.Text == salesperson.employeeid.ToString())
                    {
                        namelabel.Text = salesperson.name;
                        contactnolabel.Text = salesperson.contactno;
                        serviceprovidedlabel.Text = salesperson.serviceprovided.ToString() + " Months";
                        employeeidlabel.Text = salesperson.employeeid.ToString();
                        currrentsalarylabel.Text = salesperson.salary.ToString();
                        salesperson.current_salary();

                        presentsalarylabel.Text = salesperson.currentsalary.ToString();
                        position.Text = salesperson.employeetype.ToString();

                    }
                }
                foreach (Typewriter typewriter in typewriters)
                {
                    if (employeeidtextbox.Text == typewriter.employeeid.ToString())
                    {
                        namelabel.Text = typewriter.name;
                        contactnolabel.Text = typewriter.contactno;
                        serviceprovidedlabel.Text = typewriter.serviceprovided.ToString() + " Months";
                        employeeidlabel.Text = typewriter.employeeid.ToString();
                        currrentsalarylabel.Text = typewriter.salary.ToString();

                        typewriter.current_salary();

                        presentsalarylabel.Text = typewriter.currentsalary.ToString();
                        position.Text = typewriter.employeetype.ToString();

                    }
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
