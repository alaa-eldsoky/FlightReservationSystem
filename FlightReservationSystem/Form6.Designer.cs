namespace FlightReservationSystem
{
    partial class ticket_frm
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
            tic_pic = new PictureBox();
            grp_ticket = new GroupBox();
            lbl_ticket_passengername = new Label();
            lbl_tic_class = new Label();
            lbl_tic_flightroute = new Label();
            lbl_tic_seatnum = new Label();
            lbl_tic_date = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_gotodash = new Button();
            ((System.ComponentModel.ISupportInitialize)tic_pic).BeginInit();
            grp_ticket.SuspendLayout();
            SuspendLayout();
            // 
            // tic_pic
            // 
            tic_pic.Dock = DockStyle.Fill;
            tic_pic.Image = Properties.Resources.WhatsApp_Image_2026_05_01_at_10_47_54_AM;
            tic_pic.Location = new Point(0, 0);
            tic_pic.Margin = new Padding(3, 4, 3, 4);
            tic_pic.Name = "tic_pic";
            tic_pic.Size = new Size(914, 600);
            tic_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            tic_pic.TabIndex = 0;
            tic_pic.TabStop = false;
            // 
            // grp_ticket
            // 
            grp_ticket.Anchor = AnchorStyles.None;
            grp_ticket.BackColor = Color.Transparent;
            grp_ticket.Controls.Add(lbl_ticket_passengername);
            grp_ticket.Controls.Add(lbl_tic_class);
            grp_ticket.Controls.Add(lbl_tic_flightroute);
            grp_ticket.Controls.Add(lbl_tic_seatnum);
            grp_ticket.Controls.Add(lbl_tic_date);
            grp_ticket.Controls.Add(label7);
            grp_ticket.Controls.Add(label5);
            grp_ticket.Controls.Add(label4);
            grp_ticket.Controls.Add(label3);
            grp_ticket.Controls.Add(label2);
            grp_ticket.Controls.Add(label1);
            grp_ticket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_ticket.Location = new Point(32, 104);
            grp_ticket.Margin = new Padding(3, 4, 3, 4);
            grp_ticket.Name = "grp_ticket";
            grp_ticket.Padding = new Padding(3, 4, 3, 4);
            grp_ticket.Size = new Size(847, 339);
            grp_ticket.TabIndex = 1;
            grp_ticket.TabStop = false;
            // 
            // lbl_ticket_passengername
            // 
            lbl_ticket_passengername.AutoSize = true;
            lbl_ticket_passengername.ForeColor = Color.Black;
            lbl_ticket_passengername.Location = new Point(210, 61);
            lbl_ticket_passengername.Name = "lbl_ticket_passengername";
            lbl_ticket_passengername.Size = new Size(36, 28);
            lbl_ticket_passengername.TabIndex = 11;
            lbl_ticket_passengername.Text = "iiii";
            // 
            // lbl_tic_class
            // 
            lbl_tic_class.AutoSize = true;
            lbl_tic_class.ForeColor = Color.Black;
            lbl_tic_class.Location = new Point(210, 117);
            lbl_tic_class.Name = "lbl_tic_class";
            lbl_tic_class.Size = new Size(82, 28);
            lbl_tic_class.TabIndex = 10;
            lbl_tic_class.Text = "label10";
            // 
            // lbl_tic_flightroute
            // 
            lbl_tic_flightroute.AutoSize = true;
            lbl_tic_flightroute.ForeColor = Color.Black;
            lbl_tic_flightroute.Location = new Point(210, 89);
            lbl_tic_flightroute.Name = "lbl_tic_flightroute";
            lbl_tic_flightroute.Size = new Size(36, 28);
            lbl_tic_flightroute.TabIndex = 9;
            lbl_tic_flightroute.Text = "llll";
            // 
            // lbl_tic_seatnum
            // 
            lbl_tic_seatnum.AutoSize = true;
            lbl_tic_seatnum.ForeColor = Color.Black;
            lbl_tic_seatnum.Location = new Point(210, 145);
            lbl_tic_seatnum.Name = "lbl_tic_seatnum";
            lbl_tic_seatnum.Size = new Size(70, 28);
            lbl_tic_seatnum.TabIndex = 8;
            lbl_tic_seatnum.Text = "label8";
            // 
            // lbl_tic_date
            // 
            lbl_tic_date.AutoSize = true;
            lbl_tic_date.ForeColor = Color.Black;
            lbl_tic_date.Location = new Point(210, 173);
            lbl_tic_date.Name = "lbl_tic_date";
            lbl_tic_date.Size = new Size(70, 28);
            lbl_tic_date.TabIndex = 7;
            lbl_tic_date.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(33, 173);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 6;
            label7.Text = "Date & Time : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(33, 145);
            label5.Name = "label5";
            label5.Size = new Size(159, 28);
            label5.TabIndex = 4;
            label5.Text = "Seat Number :  ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(33, 117);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 3;
            label4.Text = "Class : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(33, 89);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 2;
            label3.Text = "Flight Route :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(33, 61);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 1;
            label2.Text = "Passenger Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(66, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 32);
            label1.TabIndex = 0;
            label1.Text = "FLIGHT BOARDING PASS";
            // 
            // btn_gotodash
            // 
            btn_gotodash.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gotodash.BackColor = Color.Crimson;
            btn_gotodash.FlatStyle = FlatStyle.Flat;
            btn_gotodash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_gotodash.ForeColor = Color.White;
            btn_gotodash.Location = new Point(697, 520);
            btn_gotodash.Margin = new Padding(3, 4, 3, 4);
            btn_gotodash.Name = "btn_gotodash";
            btn_gotodash.Size = new Size(150, 45);
            btn_gotodash.TabIndex = 3;
            btn_gotodash.Text = "Exit";
            btn_gotodash.UseVisualStyleBackColor = false;
            btn_gotodash.Click += btn_exit_Click;
            // 
            // ticket_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_gotodash);
            Controls.Add(grp_ticket);
            Controls.Add(tic_pic);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ticket_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Your Flight Ticket";
            Load += ticket_frm_Load;
            ((System.ComponentModel.ISupportInitialize)tic_pic).EndInit();
            grp_ticket.ResumeLayout(false);
            grp_ticket.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox tic_pic;
        private GroupBox grp_ticket;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_gotodash;
        private Label lbl_ticket_passengername;
        private Label lbl_tic_class;
        private Label lbl_tic_flightroute;
        private Label lbl_tic_seatnum;
        private Label lbl_tic_date;
    }
}