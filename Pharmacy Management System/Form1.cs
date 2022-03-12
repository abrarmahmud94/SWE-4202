using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {

        List<Medicine>Medicines=new List<Medicine>();
        List<Balance> Balances = new List<Balance>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string medname = medicinenametextbox.Text;
            string quantity = quantitytextbox.Text;
            Medicine medicine = new Medicine(medname,quantity);
            Medicines.Add(medicine);
            MessageBox.Show("Medicine has been sold");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medicinenametextbox.Text = "";
            quantitytextbox.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string previousBalance = previousbalancetextbox.Text;
            string medicineName = medicinehistorynametextbox.Text;
            string NumberOfMedicine = medicinehistorynoofmedicinetextbox.Text;
            string Add = medicinehistoryaddtextbox.Text;
            string ppp = medicinehistoryppptextbox.Text;
            Balance balance = new Balance(previousBalance, medicineName, NumberOfMedicine, Add, ppp);
            Balances.Add(balance);
            MessageBox.Show("Inventory has been updated");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bala;
            int mednum = Convert.ToInt32(quantitytextbox.Text);
            medicinenamelabel.Text = medicinenametextbox.Text;
            int rem;
           
            foreach(Balance balance in Balances)
            {
              if(balance.name==medicinenametextbox.Text)
                    {
                    bala =Convert.ToInt32( balance.previousbalance) + mednum * Convert.ToInt32(balance.priceperpiece);
                    currentbalancelabel.Text = Convert.ToString(bala);
                    rem = Convert.ToInt32(balance.number) - Convert.ToInt32(quantitytextbox.Text)+Convert.ToInt32(balance.add);
                    quantityremaininglabel.Text = Convert.ToString(rem);
                }

            }
        }

        private void medicinehistorynametextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
