using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSSystem
{
    class HKJobs
   {
        private string date;
        private string job;
        private string employee1;
        private string employee1Name;
        private string employee2;
        private string employee2Name;
        private string employee3;
        private string employee3Name;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public string Employee1
        {
            get { return employee1; }
            set { employee1 = value; }
        }

        public string Employee1Name
        {
            get { return employee1Name; }
            set { employee1Name = value; }
        }

        public string Employee2
        {
            get { return employee2; }
            set { employee2 = value; }
        }

        public string Employee2Name
        {
            get { return employee2Name; }
            set { employee2Name = value; }
        }

        public string Employee3
        {
            get { return employee3; }
            set { employee3 = value; }
        }

        public string Employee3Name
        {
            get { return employee3Name; }
            set { employee3Name = value; }
        }

        public HKJobs(string sDate, string sJob, string sEmployee1, string sEmployee1Name, string sEmployee2, string sEmployee2Name, string sEmployee3, string sEmployee3Name)
        {
            this.date = sDate;
            this.job = sJob;
            this.employee1 = sEmployee1;
            this.employee1Name = sEmployee1Name;
            this.employee2 = sEmployee2;
            this.employee2Name = sEmployee2Name;
            this.employee3 = sEmployee3;
            this.employee3Name = sEmployee3Name;
        }

    }
}
