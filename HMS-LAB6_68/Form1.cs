using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_LAB6_68
{
    public partial class Form1 : Form
    {

        List<User> users = new List<User>();
        List<HMS> hmss = new List<HMS>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HMS.bookingid++;
            int stayTime = Convert.ToInt32(departureTimePicker2.Value.Day) - Convert.ToInt32(entryTimePicker1.Value.Day);
            // int roomTy = Convert.ToInt32(roomchoicecombobox.SelectedItem);
            int roomTy=1;
            if (roomchoicecombobox.SelectedItem.ToString() == "Single")
            {
                roomTy = 1;
            }
            if(roomchoicecombobox.SelectedItem.ToString() =="Double")
            {
                roomTy = 2;
            }


            foreach (User user in users)
            {
                if (user.userid == placebookinguseridtextbox.Text)
                {
                    HMS hms = new HMS(user.userid, user.name, user.contactno, user.address, roomTy, Convert.ToInt32(quantitycombobox.SelectedItem), stayTime);

                    hms.bookingID = HMS.bookingid;
                    hms.amount = Convert.ToInt32(quantitycombobox.SelectedItem) * stayTime * 500 * roomTy;
                    HMS.totalAmount=HMS.totalAmount+hms.amount;
                    hmss.Add(hms);
                    MessageBox.Show("Booking placed for confirmation.Your booking id is "+HMS.bookingid);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User user = new User(useridtextbox.Text, nametextbox.Text, contactnotextbox.Text, addresstextbox.Text);
            users.Add(user);
            MessageBox.Show("User has been successfully added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (HMS hms in hmss)
            {
                if(hms.bookingID==Convert.ToInt32(ownersbookingidtextbox.Text))
                {
                    hms.status=bookingidcombobox.SelectedItem.ToString();
                    MessageBox.Show("Booking status updated");

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (HMS hms in hmss)
            {
                if(hms.bookingID==Convert.ToInt32(bookingidtextbox.Text))
                {     
                    usernamelabel.Text = hms.name;
                    statuslabel.Text = hms.status;
                    roomnolabel.Text = hms.quantity.ToString();
                    amountlabel.Text = hms.amount.ToString();
                    addresslabel.Text = hms.address.ToString();
                    useridlabel.Text = hms.userid.ToString();



                }
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
           
            listbox.Items.Clear();
            listbox.Items.Add("User name" + "\t" + "No. of Rooms" + "\t" + "Amount");
            foreach(HMS hms in hmss)
            {
                listbox.Items.Add(hms.name+"\t"+"\t"+hms.quantity+"\t"+"\t"+hms.amount);
                Totalamountlabel.Text=HMS.totalAmount.ToString();
                
            }
                
        }
    }
    }
