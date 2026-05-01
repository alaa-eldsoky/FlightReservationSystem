using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace FlightReservationSystem
{
    public partial class BookingFrm : Form
    {
        public BookingFrm()
        {
            InitializeComponent();
        }

        private void BookingFrm_Load(object sender, EventArgs e)
        {
            // background
            passenger_details.Parent = picbooking;
            pnl_class_date.Parent = picbooking;

            //banned date time picker
            dtpFlightDate.MinDate = DateTime.Today;
        }

        private void picbooking_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cmbfrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_passenger_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_passenger_id_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }



        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txt_passenger_name.Clear();
            textBox1.Clear();
            txt_passenger_email.Clear();
            txt_passenger_id.Clear();

            cmbfrom.SelectedIndex = -1;
            cmbclass.SelectedIndex = -1;

            dtpFlightDate.Value = DateTime.Today;

            txt_passenger_name.Focus();


        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            loginfrm log = new loginfrm();
            log.Show();

            this.Hide();
        }

        private void btnBookNow_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_passenger_name.Text) || cmbfrom.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the required fields before confirming.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Passenger p = new Passenger(txt_passenger_name.Text, txt_passenger_id.Text, textBox1.Text, txt_passenger_email.Text);

            // 3. عمل الحجز مع حماية من القيم الفاضية باستخدام علامة الـ ?
            Booking newBooking = new Booking(
                cmbfrom.SelectedItem?.ToString(),
                dtpFlightDate.Value,
                cmbclass.SelectedItem?.ToString(),
                p
            );

            ticket_frm t = new ticket_frm();


            t.pName = txt_passenger_name.Text;
            t.pRoute = cmbfrom.Text;
            t.pClass = cmbclass.Text;
            t.pDate = dtpFlightDate.Text;
            t.pSeat = " A-11";

            string row = $"{txt_passenger_id.Text},{cmbfrom.SelectedItem},{cmbclass.SelectedItem} , {Session.CurrentUserEmail}";
            File.AppendAllLines("bookings.txt", new[] { row });

            payment_frm paymentPage = new payment_frm(p, t);
            paymentPage.Show();
            this.Hide();
        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_class_date_Click(object sender, EventArgs e)
        {

        }
    }

}
