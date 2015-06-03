using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSSystem
{
    class ROTOccupant
    {
        private string roomNo;
        private string guestName;
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
        public ROTOccupant(string roomno, string guestname)
        {
            this.roomNo = roomno;
            this.guestName = guestname;
        }
    }
}
