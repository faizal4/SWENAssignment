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
    public partial class BookingRnD : Form
    {
        public BookingRnD()
        {
            InitializeComponent();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string bookingID = tbBookingID.Text;

            string constring1 = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";
            SqlConnection conn = new SqlConnection(constring1);
            SqlCommand comm = new SqlCommand("select * from Booking where bookingID = '" + this.tbBookingID.Text + "'; ", conn);

            try
            {
                SqlDataAdapter b = new SqlDataAdapter();
                b.SelectCommand = comm;
                DataTable dbdataset = new DataTable();
                b.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                b.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string constring2 = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";
            SqlConnection conn = new SqlConnection(constring2);
            SqlCommand comm = new SqlCommand("delete from Booking where bookingID = '" + this.tbBookingID.Text + "'; ", conn);

            try
            {
                SqlDataAdapter b = new SqlDataAdapter();
                b.SelectCommand = comm;
                DataTable dbdataset = new DataTable();
                b.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                b.Update(dbdataset);
                MessageBox.Show("Deleted");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookingCnU frm = new BookingCnU();
            frm.Show();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
