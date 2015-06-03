using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSSystem
{
    class RBInformation
        {
        private string roomNo;
        private string guestName;
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }
        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }
        public RBInformation(string roomno, string guestname,string date)
        {
            this.roomNo = roomno;
            this.guestName = guestname;
            this.date = date;
        }
    }
}

