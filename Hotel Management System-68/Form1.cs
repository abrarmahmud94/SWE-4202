using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_68
{
    public partial class Form1 : Form
    {
        List<Single>Singles=new List<Single>();
        List<Double>Doubles=new List<Double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


      


        private void button1_Click(object sender, EventArgs e)
        {
            Single singleroom=new Single();
            singleroom.name = singleroomnametextbox.Text;
            singleroom.quantity=Convert.ToInt32(singleroomquantitytextbox.Text);
            singleroom.cost = 2000;
            if (singleroomgamingsetupcombobox.SelectedItem.ToString()== "YES")
            {
                singleroom.cost = singleroom.cost + 1000;
            }
            if(singleroomaccombobox.SelectedItem.ToString()=="YES")
            {
                singleroom.cost = singleroom.cost + 500;

            }
           
            Singles.Add(singleroom);
            MessageBox.Show("You have created " + singleroomquantitytextbox.Text+ " Single Room. Each will cost " + singleroom.cost);
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double doubleroom=new Double();
            doubleroom.name = doubleroomnametextbox.Text;
            doubleroom.quantity = Convert.ToInt32(doubleroomquantitytextbox.Text);
            doubleroom.cost = 3500;
            if(doubleroomaccombobox.SelectedItem.ToString()=="YES")
            {
                doubleroom.cost = doubleroom.cost + 500;

            }
            if(doubleroomcomplementarybreakfastcombobox.SelectedItem.ToString()=="YES")
            {
                doubleroom.cost=doubleroom.cost + 500;
            }
            if(doubleroomextratvcombobox.SelectedItem.ToString()=="YES")
            {
                doubleroom.cost = doubleroom.cost + 500;
            }
            Doubles.Add(doubleroom);
            MessageBox.Show("You have created " + doubleroomquantitytextbox.Text + " Double Room.Each will cost " + doubleroom.cost);


            






        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name=rentroomnametextbox.Text;
            int quant=Convert.ToInt32(rentroomquantitytextbox.Text);
            foreach(Single singleroom in Singles)
            {
                if(Name==singleroom.name)
                {
                    singleroom.quantity = singleroom.quantity - quant;
                    MessageBox.Show("Room booking successful and will cost you " + quant * singleroom.cost);

                }
               
            }
            foreach(Double doubleroom in Doubles)
            {
                if (Name==doubleroom.name)
                {
                    doubleroom.quantity=doubleroom.quantity - quant;
                    MessageBox.Show("Room booking successful and will cost you "+quant * doubleroom.cost);
                }
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NAME=checkavaibalityroomnametextbox.Text;
            foreach(Single singleroom in Singles)
            {
                if (NAME == singleroom.name)
                {
                    if (singleroom.quantity > 0)
                    {
                        checkavailableroomlabel.Text = singleroom.quantity.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Room Unavailable");
                    }
                }

            }
            foreach(Double doubleroom in Doubles)
            {
                if(NAME==doubleroom.name)
                {
                    if(doubleroom.quantity>0)
                    {
                        checkavailableroomlabel.Text=doubleroom.quantity.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Room Unavailable");
                    }
                }
            }
        }
    }
}





