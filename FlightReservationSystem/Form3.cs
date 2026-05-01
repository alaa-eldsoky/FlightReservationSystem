using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    public partial class loginfrm : Form
    {
        // 1. تعريف مصفوفة (Array) من نوع User
        // حددنا هنا إنها هتشيل 3 مستخدمين مثلاً
        private User[] systemUsers = new User[3];

        public loginfrm()
        {
            InitializeComponent();

            // 2. بنملا المصفوفة أول ما الصفحة تفتح
            LoadUserData();
        }

        private void loginfrm_Load(object sender, EventArgs e)
        {
            //Background
            pnl_login.Parent = piclogin;
            pnl_buts_login.Parent = piclogin;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_logname_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoadUserData()
        {
            // بنضيف المستخدمين للمصفوفة باستخدام الـ Index (0, 1, 2)
            systemUsers[0] = new User("aml@skyway.com", "1234");
            systemUsers[1] = new User("amira@skyway.com", "0000");
            systemUsers[2] = new User("alaa@skyway.com", "123");
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string inputEmail = txtusername.Text;
            string inputPass = txtpassword.Text;
            bool loginSuccess = false;


            // 3. بنلف على المصفوفة (نفس طريقة الـ List بالظبط)
            foreach (var user in systemUsers)
            {
                // بنأكد إن المكان في المصفوفة مش فاضي (Null Check) عشان البرنامج ميهنجش
                if (user != null)
                {
                    if (user.Username == inputEmail && user.Password == inputPass)
                    {
                        loginSuccess = true;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                //BookingFrm booking = new BookingFrm();
                //booking.Show();
                Session.CurrentUserEmail = txtusername.Text;

                dashboard_frm welcome = new dashboard_frm();
                welcome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
            }
        }
    }

}
