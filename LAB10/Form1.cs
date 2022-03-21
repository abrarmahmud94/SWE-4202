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

namespace LAB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<UserInfo> users = new List<UserInfo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"D:\LAB10INFO\userInfo.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    UserInfo user = new UserInfo();
                    user.firstname = values[0];
                    user.lastname = values[1];

                    user.address = values[2];
                    user.city = values[3];
                    user.country = values[4];
                    user.state = values[5];
                    user.zip = values[6];
                    user.phone1 = values[7];
                    user.phone = values[8];
                    user.email = values[9];


                    users.Add(user);
                    userInfo.Items.Add(user.firstname + " " + user.lastname + "\t" + user.email + "\t" + user.phone);
                }

            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            foreach (UserInfo user in users)
            {
                try
                {


                    if (user.phone == phonenumbertxtbox.Text)
                    {
                        showinfolabel.Text = "Name:" + "\t" + user.firstname + "\t" + user.lastname + "\n" + "Address:" + "\t" + user.address + "\n" + "city" + "\t" + user.city + "\n" + " Country:" + "\t" + user.country + "\n" + "State:" + "\t" + user.state + "\n" + "Zip:" + "\t" + user.zip + "\n" + "Phone:" + "\t" + user.phone + "\n" + "Email:" + "\t" + user.email;
                        using (StreamWriter write = File.AppendText(@"D:\LAB10INFO\USERTXTFILE.txt"))
                        {
                            write.WriteLine(user.firstname + "\t" + user.lastname + "\t" + user.address + "\t" + user.city + "\t" + user.country + "\t" + user.state + "\t" + user.zip + "\t" + user.phone + "\t" + user.email);
                            write.Close();

                        }
                    }

                }



                catch (Exception ex)
                {
                    MessageBox.Show("Not found" + ex.Message);
                }


            }
        }
    }
}

