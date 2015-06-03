using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMSSystem
{
    public partial class BookingCnU : Form
    {
        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";

        public BookingCnU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookingID = tbbookingid.Text;
            string noOfAdults = tbnoofadults.Text;
            string noOfChildren = tbnoofchildren.Text;
            string checkInDate = tbcheckindate.Text;
            string checkOutDate = tbcheckoutdate.Text;
            string noOfNights = tbnoofnights.Text;
            string roomID = tbroomid.Text;
            string additionalRequest = tbaddrequest.Text;
            string employeeID = tbemployeeid.Text;
            string guestID = tbxguestID.Text;


            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            try
            {

                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "insert into Booking(bookingID, noOfAdults, noOfChildren, checkInDate, checkOutDate, noOfNights, roomID, additionalRequest, employeeID, guestID) values('" + this.tbbookingid.Text + "' , '" + this.tbnoofadults.Text + "' , '" + this.tbnoofchildren.Text + "' , '" + this.tbcheckindate.Text + "' , '" + this.tbcheckoutdate.Text + "' , '" + this.tbnoofnights.Text + "' , '" + this.tbroomid.Text + "' , '" + this.tbaddrequest.Text + "' , '" + this.tbemployeeid.Text + "', '" + this.tbxguestID.Text + "')";
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string bookingID = tbbookingid.Text;
            string noOfAdults = tbnoofadults.Text;
            string noOfChildren = tbnoofchildren.Text;
            string checkInDate = tbcheckindate.Text;
            string checkOutDate = tbcheckoutdate.Text;
            string noOfNights = tbnoofnights.Text;
            string roomID = tbroomid.Text;
            string additionalRequest = tbaddrequest.Text;
            string guestID = tbxguestID.Text;


            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            try
            {

                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "update Booking set bookingID = '" + this.tbbookingid.Text + "' , noOfAdults = '" + this.tbnoofadults.Text + "' , noOfChildren = '" + this.tbnoofchildren.Text + "' , checkInDate = '" + this.tbcheckindate.Text + "' , checkOutDate = '" + this.tbcheckoutdate.Text + "' , noOfNights =  '" + this.tbnoofnights.Text + "' , roomID = '" + this.tbroomid.Text + "' , additionalRequest = '" + this.tbaddrequest.Text + "' , guestID = '" + this.tbxguestID.Text +"' where bookingID = '" + this.tbbookingid.Text + "';";
                SqlDataReader dr = comm.ExecuteReader();
                MessageBox.Show("Updated");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
