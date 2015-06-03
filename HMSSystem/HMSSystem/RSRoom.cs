using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSSystem
{
    class RSRoom
   {
        private string roomNo;
        private string roomAvailability;
        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }
        public string RoomAvailability
        {
            get { return roomAvailability; }
            set { roomAvailability = value; }
        }
        public RSRoom(string roomno, string roomavailability)
        {
            this.roomNo = roomno;
            this.roomAvailability = roomavailability;
        }
    }
}
