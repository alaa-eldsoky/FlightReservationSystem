namespace FlightReservationSystem
{
    partial class BookingFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picbooking = new PictureBox();
            passenger_details = new Panel();
            txt_passenger_email = new TextBox();
            txt_passenger_id = new TextBox();
            lbl_passenger_id = new Label();
            lbl_passenger_email = new Label();
            textBox1 = new TextBox();
            lbl_Passport = new Label();
            txt_passenger_name = new TextBox();
            lbl_passenger_name = new Label();
            pnl_class_date = new Panel();
            cmbfrom = new ComboBox();
            dtpFlightDate = new DateTimePicker();
            lbl_availableflight = new Label();
            cmbclass = new ComboBox();
            lbl_departure_time = new Label();
            lbl_class = new Label();
            lbl_class_date = new Label();
            btnBack = new Button();
            btnClear = new Button();
            btnBookNow = new Button();
            ((System.ComponentModel.ISupportInitialize)picbooking).BeginInit();
            passenger_details.SuspendLayout();
            pnl_class_date.SuspendLayout();
            SuspendLayout();
            // 
            // picbooking
            // 
            picbooking.Dock = DockStyle.Fill;
            picbooking.Image = Properties.Resources.WhatsApp_Image_2026_04_29_at_7_05_43_PM;
            picbooking.Location = new Point(0, 0);
            picbooking.Margin = new Padding(3, 4, 3, 4);
            picbooking.Name = "picbooking";
            picbooking.Size = new Size(897, 544);
            picbooking.SizeMode = PictureBoxSizeMode.StretchImage;
            picbooking.TabIndex = 0;
            picbooking.TabStop = false;
            picbooking.Click += picbooking_Click;
            // 
            // passenger_details
            // 
            passenger_details.Anchor = AnchorStyles.Top;
            passenger_details.BackColor = Color.Transparent;
            passenger_details.Controls.Add(txt_passenger_email);
            passenger_details.Controls.Add(txt_passenger_id);
            passenger_details.Controls.Add(lbl_passenger_id);
            passenger_details.Controls.Add(lbl_passenger_email);
            passenger_details.Controls.Add(textBox1);
            passenger_details.Controls.Add(lbl_Passport);
            passenger_details.Controls.Add(txt_passenger_name);
            passenger_details.Controls.Add(lbl_passenger_name);
            passenger_details.Location = new Point(18, 43);
            passenger_details.Margin = new Padding(3, 4, 3, 4);
            passenger_details.Name = "passenger_details";
            passenger_details.Size = new Size(865, 76);
            passenger_details.TabIndex = 1;
            // 
            // txt_passenger_email
            // 
            txt_passenger_email.Location = new Point(515, 4);
            txt_passenger_email.Margin = new Padding(3, 4, 3, 4);
            txt_passenger_email.Name = "txt_passenger_email";
            txt_passenger_email.Size = new Size(281, 27);
            txt_passenger_email.TabIndex = 7;
            // 
            // txt_passenger_id
            // 
            txt_passenger_id.Location = new Point(502, 40);
            txt_passenger_id.Margin = new Padding(3, 4, 3, 4);
            txt_passenger_id.Name = "txt_passenger_id";
            txt_passenger_id.Size = new Size(294, 27);
            txt_passenger_id.TabIndex = 6;
            // 
            // lbl_passenger_id
            // 
            lbl_passenger_id.AutoSize = true;
            lbl_passenger_id.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_passenger_id.Location = new Point(450, 43);
            lbl_passenger_id.Name = "lbl_passenger_id";
            lbl_passenger_id.Size = new Size(50, 28);
            lbl_passenger_id.TabIndex = 5;
            lbl_passenger_id.Text = "ID : ";
            // 
            // lbl_passenger_email
            // 
            lbl_passenger_email.AutoSize = true;
            lbl_passenger_email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_passenger_email.Location = new Point(450, 7);
            lbl_passenger_email.Name = "lbl_passenger_email";
            lbl_passenger_email.Size = new Size(81, 28);
            lbl_passenger_email.TabIndex = 4;
            lbl_passenger_email.Text = "Email : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 41);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 3;
            // 
            // lbl_Passport
            // 
            lbl_Passport.AutoSize = true;
            lbl_Passport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Passport.Location = new Point(5, 41);
            lbl_Passport.Name = "lbl_Passport";
            lbl_Passport.Size = new Size(200, 28);
            lbl_Passport.TabIndex = 2;
            lbl_Passport.Text = "Passport Number :  ";
            // 
            // txt_passenger_name
            // 
            txt_passenger_name.Location = new Point(118, 3);
            txt_passenger_name.Margin = new Padding(3, 4, 3, 4);
            txt_passenger_name.Name = "txt_passenger_name";
            txt_passenger_name.Size = new Size(242, 27);
            txt_passenger_name.TabIndex = 1;
            // 
            // lbl_passenger_name
            // 
            lbl_passenger_name.AutoSize = true;
            lbl_passenger_name.Dock = DockStyle.Top;
            lbl_passenger_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_passenger_name.Location = new Point(0, 0);
            lbl_passenger_name.Name = "lbl_passenger_name";
            lbl_passenger_name.Size = new Size(143, 28);
            lbl_passenger_name.TabIndex = 0;
            lbl_passenger_name.Text = "Full Name  :   ";
            // 
            // pnl_class_date
            // 
            pnl_class_date.Anchor = AnchorStyles.Top;
            pnl_class_date.BackColor = Color.Transparent;
            pnl_class_date.Controls.Add(cmbfrom);
            pnl_class_date.Controls.Add(dtpFlightDate);
            pnl_class_date.Controls.Add(lbl_availableflight);
            pnl_class_date.Controls.Add(cmbclass);
            pnl_class_date.Controls.Add(lbl_departure_time);
            pnl_class_date.Controls.Add(lbl_class);
            pnl_class_date.Controls.Add(lbl_class_date);
            pnl_class_date.Location = new Point(18, 160);
            pnl_class_date.Margin = new Padding(3, 4, 3, 4);
            pnl_class_date.Name = "pnl_class_date";
            pnl_class_date.Size = new Size(594, 223);
            pnl_class_date.TabIndex = 4;
            pnl_class_date.Paint += panel1_Paint;
            // 
            // cmbfrom
            // 
            cmbfrom.BackColor = Color.White;
            cmbfrom.FlatStyle = FlatStyle.Flat;
            cmbfrom.Font = new Font("Segoe UI Semilight", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbfrom.ForeColor = Color.LightSlateGray;
            cmbfrom.FormattingEnabled = true;
            cmbfrom.Items.AddRange(new object[] { "Cairo to Dubai (10:00 AM)", "Cairo to Dubai (08:30 PM)", "Paris to Berlin (01:15 PM)", "Cairo to London(05:30 AM)" });
            cmbfrom.Location = new Point(177, 52);
            cmbfrom.Margin = new Padding(3, 4, 3, 4);
            cmbfrom.Name = "cmbfrom";
            cmbfrom.Size = new Size(310, 33);
            cmbfrom.TabIndex = 3;
            cmbfrom.Text = "Select a Flight...";
            cmbfrom.SelectedIndexChanged += cmbfrom_SelectedIndexChanged;
            // 
            // dtpFlightDate
            // 
            dtpFlightDate.Anchor = AnchorStyles.Top;
            dtpFlightDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFlightDate.Format = DateTimePickerFormat.Short;
            dtpFlightDate.Location = new Point(190, 113);
            dtpFlightDate.Margin = new Padding(3, 4, 3, 4);
            dtpFlightDate.MinDate = new DateTime(2026, 4, 30, 2, 27, 24, 0);
            dtpFlightDate.Name = "dtpFlightDate";
            dtpFlightDate.Size = new Size(113, 29);
            dtpFlightDate.TabIndex = 4;
            dtpFlightDate.Value = new DateTime(2026, 4, 30, 2, 27, 24, 0);
            // 
            // lbl_availableflight
            // 
            lbl_availableflight.AutoSize = true;
            lbl_availableflight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_availableflight.Location = new Point(17, 61);
            lbl_availableflight.Name = "lbl_availableflight";
            lbl_availableflight.Size = new Size(183, 28);
            lbl_availableflight.TabIndex = 1;
            lbl_availableflight.Text = "Available Flight :  ";
            // 
            // cmbclass
            // 
            cmbclass.Anchor = AnchorStyles.Top;
            cmbclass.FlatStyle = FlatStyle.Flat;
            cmbclass.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbclass.ForeColor = Color.LightSlateGray;
            cmbclass.FormattingEnabled = true;
            cmbclass.Items.AddRange(new object[] { "Economy Class", "Business Class", "First Class" });
            cmbclass.Location = new Point(190, 161);
            cmbclass.Margin = new Padding(3, 4, 3, 4);
            cmbclass.Name = "cmbclass";
            cmbclass.Size = new Size(178, 33);
            cmbclass.TabIndex = 3;
            cmbclass.Text = "Select Class...";
            cmbclass.SelectedIndexChanged += cmbclass_SelectedIndexChanged;
            // 
            // lbl_departure_time
            // 
            lbl_departure_time.Anchor = AnchorStyles.Top;
            lbl_departure_time.AutoSize = true;
            lbl_departure_time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_departure_time.Location = new Point(17, 117);
            lbl_departure_time.Name = "lbl_departure_time";
            lbl_departure_time.Size = new Size(177, 28);
            lbl_departure_time.TabIndex = 2;
            lbl_departure_time.Text = "Departure Date : ";
            // 
            // lbl_class
            // 
            lbl_class.Anchor = AnchorStyles.Top;
            lbl_class.AutoSize = true;
            lbl_class.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_class.Location = new Point(17, 171);
            lbl_class.Name = "lbl_class";
            lbl_class.Size = new Size(82, 28);
            lbl_class.TabIndex = 1;
            lbl_class.Text = "Class :  ";
            // 
            // lbl_class_date
            // 
            lbl_class_date.Anchor = AnchorStyles.Top;
            lbl_class_date.AutoSize = true;
            lbl_class_date.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_class_date.Location = new Point(5, 0);
            lbl_class_date.Name = "lbl_class_date";
            lbl_class_date.Size = new Size(157, 32);
            lbl_class_date.TabIndex = 0;
            lbl_class_date.Text = "flight details";
            lbl_class_date.Click += lbl_class_date_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom;
            btnBack.BackColor = Color.SlateGray;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(107, 456);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 43);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back to Login ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.IndianRed;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(390, 456);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 43);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnBookNow
            // 
            btnBookNow.Anchor = AnchorStyles.Bottom;
            btnBookNow.BackColor = Color.Navy;
            btnBookNow.Cursor = Cursors.Hand;
            btnBookNow.FlatAppearance.MouseOverBackColor = Color.MediumBlue;
            btnBookNow.FlatStyle = FlatStyle.Flat;
            btnBookNow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookNow.ForeColor = Color.White;
            btnBookNow.Location = new Point(647, 456);
            btnBookNow.Margin = new Padding(3, 4, 3, 4);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(184, 43);
            btnBookNow.TabIndex = 7;
            btnBookNow.Text = "Pay Now  ";
            btnBookNow.UseVisualStyleBackColor = false;
            btnBookNow.Click += btnBookNow_Click_1;
            // 
            // BookingFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(897, 544);
            Controls.Add(btnBookNow);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(pnl_class_date);
            Controls.Add(passenger_details);
            Controls.Add(picbooking);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookingFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking ";
            Load += BookingFrm_Load;
            ((System.ComponentModel.ISupportInitialize)picbooking).EndInit();
            passenger_details.ResumeLayout(false);
            passenger_details.PerformLayout();
            pnl_class_date.ResumeLayout(false);
            pnl_class_date.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picbooking;
        private Panel passenger_details;
        private Label lbl_passenger_name;
        private Label lbl_Passport;
        private TextBox txt_passenger_name;
        private TextBox textBox1;
        private Panel pnl_class_date;
        private Label lbl_availableflight;
        private ComboBox cmbfrom;
        private DateTimePicker dtpFlightDate;
        private ComboBox cmbclass;
        private Label lbl_departure_time;
        private Label lbl_class;
        private Label lbl_class_date;
        private Button btnBack;
        private Button btnClear;
        private Button btnBookNow;
        private TextBox txt_passenger_email;
        private TextBox txt_passenger_id;
        private Label lbl_passenger_id;
        private Label lbl_passenger_email;
    }
}
