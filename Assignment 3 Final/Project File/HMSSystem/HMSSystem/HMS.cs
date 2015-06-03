using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSSystem
{
    public partial class HMS : Form
    {
        public HMS()
        {
            InitializeComponent();
        }

        private void roomOccupancy_Click(object sender, EventArgs e)
        {
            RoomOccupancy frm = new RoomOccupancy();
            frm.Show();
        }

        private void roomStatus_Click(object sender, EventArgs e)
        {
            RoomStatus frm = new RoomStatus();
            frm.Show();
        }

        private void roomBooking_Click(object sender, EventArgs e)
        {
            RoomBooking frm = new RoomBooking();
            frm.Show();
        }

        private void roomOccupant_Click(object sender, EventArgs e)
        {
            RoomOccupant frm = new RoomOccupant();
            frm.Show();
        }

        private void housekeeping_Click(object sender, EventArgs e)
        {
            Housekeeping frm = new Housekeeping();
            frm.Show();
        }

        private void bookingDetails_Click(object sender, EventArgs e)
        {
            BookingRnD frm = new BookingRnD();
            frm.Show();
        }

        private void guestParticulars_Click(object sender, EventArgs e)
        {
            GuestRnD frm = new GuestRnD();
            frm.Show();
        }

        private void bookingDetails2_Click(object sender, EventArgs e)
        {
            BookingCnU frm = new BookingCnU();
            frm.Show();
        }

        private void guestParticulars2_Click(object sender, EventArgs e)
        {
            GuestCnU frm = new GuestCnU();
            frm.Show();
        }
    }
}
