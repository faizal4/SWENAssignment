using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HMSSystem
{
    class RODatabase
    {


        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";

        public static ArrayList GetAllWeek(RODate ndate)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList Statistics = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT DATEDIFF(week," + ndate.StartDate + ", checkInDate) as WeekNumber,month(checkInDate) as month,year(checkInDate) as Year, sum(noOfAdults + noOfChildren) as TotalAmount FROM Booking WHERE checkInDate >=" + ndate.StartDate + "group by DATEDIFF(week," + ndate.StartDate + ", checkInDate), month(checkInDate), year(checkInDate)";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    ROStatsWeek i = new ROStatsWeek(dr["WeekNumber"].ToString(), dr["month"].ToString(), dr["Year"].ToString(), Convert.ToInt32(dr["TotalAmount"].ToString()));
                    Statistics.Add(i);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Statistics;

        }
        public static ArrayList GetAllMonth(RODate ndate)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList Statistics = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT month(checkInDate) as month,year(checkInDate) as Year, sum(noOfAdults + noOfChildren) as TotalAmount FROM Booking WHERE checkInDate >=" + ndate.StartDate + "group by month(checkInDate), year(checkInDate)";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    ROStatsMonth i = new ROStatsMonth(dr["month"].ToString(), dr["Year"].ToString(), Convert.ToInt32(dr["TotalAmount"].ToString()));
                    Statistics.Add(i);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Statistics;

        }
        public static ArrayList GetAllYear(RODate ndate)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList Statistics = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT year(checkInDate) as Year, sum(noOfAdults + noOfChildren) as TotalAmount FROM Booking WHERE checkInDate >=" + ndate.StartDate + "group by year(checkInDate)";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    ROStatsYear i = new ROStatsYear(dr["Year"].ToString(), Convert.ToInt32(dr["TotalAmount"].ToString()));
                    Statistics.Add(i);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return Statistics;

        }

    }
}