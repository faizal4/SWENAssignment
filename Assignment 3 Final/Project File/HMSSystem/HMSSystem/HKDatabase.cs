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
    class HKDatabase
    {


        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";

        public static ArrayList GetAllJobs(HKDate ndate)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList HJobs = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Housekeeping WHERE housekeepingDate >=" + ndate.StartDate;
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    HKJobs i = new HKJobs(dr["housekeepingDate"].ToString(), dr["housekeepingJob"].ToString(), dr["employeeID1"].ToString(), dr["employeeID1Name"].ToString(), dr["employeeID2"].ToString(), dr["employeeID2Name"].ToString(), dr["employeeID3"].ToString(), dr["employeeID3Name"].ToString());
                    HJobs.Add(i);
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
            return HJobs;

        }

    }
}