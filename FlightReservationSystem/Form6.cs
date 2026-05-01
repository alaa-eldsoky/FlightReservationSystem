using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class ticket_frm : Form
    {
        public string pName, pRoute, pClass, pSeat, pDate;

        public ticket_frm()
        {
            InitializeComponent();
        }

        private void ticket_frm_Load(object sender, EventArgs e)
        {

            grp_ticket.Parent = tic_pic;


            lbl_ticket_passengername.Text = pName;
            lbl_tic_flightroute.Text = pRoute;
            lbl_tic_class.Text = pClass;
            lbl_tic_seatnum.Text = "A-11";
            lbl_tic_date.Text = pDate;


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
