using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMSSystem
{
    class BCnUDatabase
    {

        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";

        public void insertBookingData()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "insert into Booking";
                SqlDataReader dr = comm.ExecuteReader();
                MessageBox.Show("Saved");
                while (dr.Read())
                {

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
        }
    }
}

    