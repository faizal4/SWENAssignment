using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSSystem
{
    class ROStatsMonth
    {
   private string month;
        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        private int totalOccupants;


        public string Month
        {
            get { return month; }
            set { month = value; }
        }

        public int TotalOccupants
        {
            get { return totalOccupants; }
            set { totalOccupants = value; }
        }
        public ROStatsMonth(string sMonth,string sYear, int stotal)
        {
            this.month = sMonth;
            this.year = sYear;
            this.totalOccupants = stotal;
        }
    }
}
