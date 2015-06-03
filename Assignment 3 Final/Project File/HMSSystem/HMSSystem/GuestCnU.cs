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
    public partial class GuestCnU : Form
    {
        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";
        public GuestCnU()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string guestID = tbguestid.Text;
            string guestName = tbguestname.Text;
            string guestPassword = tbguestpwd.Text;
            string firstName = tbfirstname.Text;
            string lastName = tblastname.Text;
            string email = tbemail.Text;
            string IC = tbicno.Text;
            string phoneNum = tbphoneno.Text;
            string bookingDetails = tbnationality.Text;
            string checkIn = tbbookingdetails.Text;

            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "insert into Guest(guestID, guestName, guestPassword, firstName, lastName, email, icNo, phoneNo, nationality, bookingdetails) values('" + this.tbguestid.Text + "' , '" + this.tbguestname.Text + "' , '" + this.tbguestpwd.Text + "' , '" + this.tbfirstname.Text + "' , '" + this.tblastname.Text + "' , '" + this.tbemail.Text + "' , '" + this.tbicno.Text + "' , '" + this.tbphoneno.Text + "' , '" + this.tbnationality.Text + "' , '" + this.tbbookingdetails.Text + "')";
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

            int guestID = Convert.ToInt32(tbguestid.Text.ToString());
            string guestName = tbguestname.Text;
            string guestPassword = tbguestpwd.Text;
            string firstName = tbfirstname.Text;
            string lastName = tblastname.Text;
            string email = tbemail.Text;
            string icNo = tbicno.Text;
            string phoneNo = tbphoneno.Text;
            string nationality = tbnationality.Text;
            string bookingDetails = tbbookingdetails.Text;


            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "update Guest set guestName = '" + this.tbguestname.Text + "' , guestPassword = '" + this.tbguestpwd.Text + "' , firstName = '" + this.tbfirstname + "' , lastName = '" + this.tblastname.Text + "' , email =  '" + this.tbemail.Text + "' , icNo = '" + this.tbicno.Text + "' , phoneNo = '" + this.tbphoneno.Text + "' , nationality = '" + this.tbnationality.Text + "' , bookingDetails = '" + this.tbbookingdetails.Text + "' where guestID = '" + guestID + "';";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}