using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSSystem
{
    class ROStatsWeek
    {
        private string week;

        public string Week
        {
            get { return week; }
            set { week = value; }
        }
        private string month;

        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        private int totalOccupants;

        public int TotalOccupants
        {
            get { return totalOccupants; }
            set { totalOccupants = value; }
        }
        public ROStatsWeek(string sWeek, string sMonth, string sYear, int stotal)
        {
            this.week = sWeek;
            this.month = sMonth;
            this.year = sYear;
            this.totalOccupants = stotal;
        }
    }
}
