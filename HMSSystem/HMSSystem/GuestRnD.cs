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
    public partial class GuestRnD : Form
    {
        public GuestRnD()
        {
            InitializeComponent();
        }

        private void btnGuestFind_Click(object sender, EventArgs e)
        {
            string guestID = tbxGuestID.Text;

            string constring3 = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";
            SqlConnection conn3 = new SqlConnection(constring3);
            SqlCommand comm3 = new SqlCommand("select * from Guest where guestID = '" + this.tbxGuestID.Text + "'; ", conn3);

            try
            {
                SqlDataAdapter b = new SqlDataAdapter();
                b.SelectCommand = comm3;
                DataTable dbdataset = new DataTable();
                b.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                b.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteID_Click(object sender, EventArgs e)
        {

            {
                string guestID = tbxGuestID.Text;
                string constring4 = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";
                SqlConnection conn = new SqlConnection(constring4);
                SqlCommand comm = new SqlCommand("delete from Guest where guestID = '" + this.tbxGuestID.Text + "'; ", conn);

                try
                {
                    SqlDataAdapter b = new SqlDataAdapter();
                    b.SelectCommand = comm;
                    DataTable dbdataset = new DataTable();
                    b.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView2.DataSource = bSource;
                    b.Update(dbdataset);
                    MessageBox.Show("Deleted");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            GuestCnU frm = new GuestCnU();
            frm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
