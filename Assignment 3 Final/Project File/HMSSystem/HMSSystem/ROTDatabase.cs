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
    class ROTDatabase
    {
        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;" +
   "initial catalog=HMSSystem;integrated security=true;";
        public static ArrayList GetRoomOccupant()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList roomOccupant = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT r.roomNo, g.guestName from Room r, Guest g, Booking b where b.guestID = g.guestID AND b.roomID = r.roomID";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    ROTOccupant o = new ROTOccupant(dr["roomNo"].ToString(),
                        dr["guestName"].ToString());
                    roomOccupant.Add(o);
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
            return roomOccupant;
        }
    }
}