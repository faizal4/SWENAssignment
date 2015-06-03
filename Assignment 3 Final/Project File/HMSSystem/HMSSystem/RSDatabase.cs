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
    class RSDatabase
    {
        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;" +
   "initial catalog=HMSSystem;integrated security=true;";
        public static ArrayList GetRoomStatus()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList roomStatus = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT roomNo, roomAvailability from Room";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    RSRoom p = new RSRoom(dr["roomNo"].ToString(),
                        dr["roomAvailability"].ToString());
                    roomStatus.Add(p);
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
            return roomStatus;
        }
    }
}
