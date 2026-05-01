namespace FlightReservationSystem
{
    partial class dashboard_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pic_dash = new PictureBox();
            lbl_dashb = new Label();
            lbldash = new Label();
            pnl_dashbutt = new Panel();
            but_my_bookings = new Button();
            but_New_booking = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_dash).BeginInit();
            pnl_dashbutt.SuspendLayout();
            SuspendLayout();
            // 
            // pic_dash
            // 
            pic_dash.BackgroundImageLayout = ImageLayout.Stretch;
            pic_dash.Dock = DockStyle.Fill;
            pic_dash.Image = Properties.Resources.WhatsApp_Image_2026_04_29_at_7_051;
            pic_dash.Location = new Point(0, 0);
            pic_dash.Margin = new Padding(4);
            pic_dash.Name = "pic_dash";
            pic_dash.Size = new Size(752, 531);
            pic_dash.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_dash.TabIndex = 0;
            pic_dash.TabStop = false;
            pic_dash.Click += pictureBox1_Click;
            // 
            // lbl_dashb
            // 
            lbl_dashb.AutoSize = true;
            lbl_dashb.BackColor = Color.Transparent;
            lbl_dashb.Location = new Point(302, 92);
            lbl_dashb.Name = "lbl_dashb";
            lbl_dashb.Size = new Size(0, 28);
            lbl_dashb.TabIndex = 1;
            // 
            // lbldash
            // 
            lbldash.Anchor = AnchorStyles.None;
            lbldash.AutoSize = true;
            lbldash.BackColor = Color.Transparent;
            lbldash.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldash.ForeColor = Color.Navy;
            lbldash.Location = new Point(244, 92);
            lbldash.Name = "lbldash";
            lbldash.Size = new Size(237, 56);
            lbldash.TabIndex = 2;
            lbldash.Text = "welcome";
            lbldash.Click += lbldash_Click;
            // 
            // pnl_dashbutt
            // 
            pnl_dashbutt.Anchor = AnchorStyles.None;
            pnl_dashbutt.BackColor = Color.Transparent;
            pnl_dashbutt.Controls.Add(but_my_bookings);
            pnl_dashbutt.Controls.Add(but_New_booking);
            pnl_dashbutt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnl_dashbutt.ForeColor = Color.Navy;
            pnl_dashbutt.Location = new Point(28, 178);
            pnl_dashbutt.Name = "pnl_dashbutt";
            pnl_dashbutt.Size = new Size(697, 288);
            pnl_dashbutt.TabIndex = 3;
            // 
            // but_my_bookings
            // 
            but_my_bookings.BackColor = Color.Navy;
            but_my_bookings.FlatAppearance.BorderSize = 0;
            but_my_bookings.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            but_my_bookings.FlatStyle = FlatStyle.Flat;
            but_my_bookings.ForeColor = Color.White;
            but_my_bookings.Location = new Point(388, 72);
            but_my_bookings.Name = "but_my_bookings";
            but_my_bookings.Size = new Size(254, 44);
            but_my_bookings.TabIndex = 2;
            but_my_bookings.Text = "My history";
            but_my_bookings.UseVisualStyleBackColor = false;
            but_my_bookings.Click += but_my_bookings_Click;
            // 
            // but_New_booking
            // 
            but_New_booking.BackColor = Color.Navy;
            but_New_booking.FlatAppearance.BorderSize = 0;
            but_New_booking.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            but_New_booking.FlatStyle = FlatStyle.Flat;
            but_New_booking.ForeColor = Color.White;
            but_New_booking.Location = new Point(52, 72);
            but_New_booking.Name = "but_New_booking";
            but_New_booking.Size = new Size(254, 44);
            but_New_booking.TabIndex = 1;
            but_New_booking.Text = "Book a New Flight";
            but_New_booking.UseVisualStyleBackColor = false;
            but_New_booking.Click += but_New_booking_Click_1;
            // 
            // dashboard_frm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 531);
            Controls.Add(pnl_dashbutt);
            Controls.Add(lbldash);
            Controls.Add(lbl_dashb);
            Controls.Add(pic_dash);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "dashboard_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += dashboard_frm_Load;
            ((System.ComponentModel.ISupportInitialize)pic_dash).EndInit();
            pnl_dashbutt.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_dash;
        private Label lbl_dashb;
        private Label lbldash;
        private Panel pnl_dashbutt;
        private Button but_my_bookings;
        private Button but_New_booking;
    }
}