using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSSystem
{
    class ROStatsYear
    {
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
        public ROStatsYear(string sYear, int stotal)
        {
            this.year = sYear;
            this.totalOccupants = stotal;
        }
    }
}
