using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.IO;

namespace FlightReservationSystem
{
    public partial class My_book_frm : Form
    {
        public My_book_frm()
        {
            InitializeComponent();
        }

        private void My_book_frm_Load(object sender, EventArgs e)
        {
            lbl_totalbookings.Parent = pic_tot_book;
            dataGrid_myflights.Parent = pic_tot_book;

            if (File.Exists("bookings.txt"))
            {
                // 2. قراءة كل السطور من الملف
                string[] allBookings = File.ReadAllLines("bookings.txt");

                foreach (string line in allBookings)
                {
                    // 3. تقسيم السطر بناءً على الفاصلة
                    string[] data = line.Split(',');

                    // 4. إضافة البيانات لصفوف الجدول (DataGridView)
                    // تأكدي إن اسم الجدول عندك هو dataGridView1 أو غيريه للاسم الصح
                    dataGrid_myflights.Rows.Add(data[0], data[1], data[2]);
                }
            }
        }

        private void dataGrid_myflights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_mybooks_Click(object sender, EventArgs e)
        {
            dashboard_frm home = new dashboard_frm();
            home.Show();
            this.Close();
        }
    }
}
