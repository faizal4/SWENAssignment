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
    public partial class Login : Form
    {
        private const string GSM_CONN_STR = "data source=(localdb)\\v11.0;initial catalog=HMSSystem;integrated security=true;";
        public Login()
        {
            InitializeComponent();
            tbxPassword.PasswordChar = '*';
            tbxPassword.MaxLength = 20;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string employeeID = tbxUsername.Text;
            string employeePwd = tbxPassword.Text;

            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = ("select * from Employee where employeeID = '" + this.tbxUsername.Text + "' and employeePwd = '" + this.tbxPassword.Text + "' ; ");
                SqlDataReader dr = comm.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    this.Hide();
                    HMS frm = new HMS();
                    frm.Show();
                    
                }
                else if (count > 1)
                {
                    MessageBox.Show("Access Denied!... Duplicate Username or Password!");
                }
                else
                {
                    MessageBox.Show("Username and Password is not correct!... Please try again!");
                    dr.Close();
                }

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
