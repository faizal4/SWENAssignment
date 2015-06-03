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
    class RBDatabase
    {


        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";

        
        public static ArrayList GetAllBooking(RBDate ndate)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList Information = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT r.roomNo, g.guestName, b.checkInDate from Room r, Guest g, Booking b where b.guestID = g.guestID AND b.roomID = r.roomID AND b.checkInDate >=" + ndate.StartDate;
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RBInformation o = new RBInformation(dr["roomNo"].ToString(), dr["guestName"].ToString(), dr["checkInDate"].ToString());
                    Information.Add(o);

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
            return Information;

        }

    }
}