using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_LAB6_68
{
    internal class HMS:User
    {
        public int quantity;
        public int  roomtype;
        public int staytime;
        public int amount;
        public static int bookingid=0;
        public int bookingID;
        public string status = "Pending";
        public static int totalAmount;
        public HMS(string userid, string name, string contactno, string address,int roomtype,int quantity,int staytime):base( userid,  name,  contactno,  address)
        {
            this.roomtype = roomtype;
            this.quantity = quantity;
            this.staytime = staytime;


        }

    }
}
