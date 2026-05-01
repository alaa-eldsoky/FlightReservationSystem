using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class dashboard_frm : Form
    {
        public dashboard_frm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_frm_Load(object sender, EventArgs e)
        {
            //background
            pnl_dashbutt.Parent = pic_dash;
            lbldash.Parent = pic_dash;
        }

        private void but_my_bookings_Click(object sender, EventArgs e)
        {
            My_book_frm secondForm = new My_book_frm();
            secondForm.Show();
            this.Hide();
        }

        private void but_New_booking_Click(object sender, EventArgs e)
        {
           
        }

        private void but_New_booking_Click_1(object sender, EventArgs e)
        {
            BookingFrm bookingPage = new BookingFrm();
            bookingPage.Show();
            this.Hide();
        }

        private void lbldash_Click(object sender, EventArgs e)
        {

        }
    }
}
