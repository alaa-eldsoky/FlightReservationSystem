using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class payment_frm : Form
    {
        Passenger currentPassenger;
        ticket_frm currentTicket;

        // 2. الـ Constructor بيستلم الراكب والتذكرة من الشاشة اللي قبلها
        public payment_frm(Passenger p, ticket_frm t)
        {
            InitializeComponent();
            currentPassenger = p;
            currentTicket = t; // كدة الخط الأحمر اللي تحتها هيختفي
        }

        private void payment_frm_Load(object sender, EventArgs e)
        {
            grp_pay.Parent = pic_payment;
        }

        private void grp_pay_Enter(object sender, EventArgs e)
        {

        }

        private void btn_pay_back_Click(object sender, EventArgs e)
        {
            this.Close();
            BookingFrm bookingPage = new BookingFrm();
            bookingPage.Show();
        }

        private void cmb_cardtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_pay_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pay_confirm_Click(object sender, EventArgs e)
        {
            string password = txt_pay_pass.Text;
            // 1. التحقق من صحة كلمة السر باستخدام الكلاس
            if (password.Length == 4)
            {
                MessageBox.Show("Payment Confirmed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ticket_frm ticketPage = new ticket_frm();
                //ticketPage.Show();
                currentTicket.Show();
                this.Hide();
            }
            else
            {
                // في حالة الخطأ
                MessageBox.Show("Invalid Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pay_pass.Clear();
                txt_pay_pass.Focus();
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void lbl_card_Click(object sender, EventArgs e)
        {

        }
    }

}
