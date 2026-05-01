namespace FlightReservationSystem
{
    partial class My_book_frm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pic_tot_book = new PictureBox();
            dataGrid_myflights = new DataGridView();
            col_ticket_id = new DataGridViewTextBoxColumn();
            col_flight_path = new DataGridViewTextBoxColumn();
            col_status = new DataGridViewTextBoxColumn();
            btn_back_mybooks = new Button();
            lbl_totalbookings = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_tot_book).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_myflights).BeginInit();
            SuspendLayout();
            // 
            // pic_tot_book
            // 
            pic_tot_book.Dock = DockStyle.Fill;
            pic_tot_book.Image = Properties.Resources.WhatsApp_Image_2026_04_29_at_7_05_50_PM;
            pic_tot_book.Location = new Point(0, 0);
            pic_tot_book.Margin = new Padding(3, 4, 3, 4);
            pic_tot_book.Name = "pic_tot_book";
            pic_tot_book.Size = new Size(914, 600);
            pic_tot_book.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_tot_book.TabIndex = 0;
            pic_tot_book.TabStop = false;
            // 
            // dataGrid_myflights
            // 
            dataGrid_myflights.AllowUserToAddRows = false;
            dataGrid_myflights.AllowUserToDeleteRows = false;
            dataGrid_myflights.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_myflights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_myflights.BackgroundColor = Color.White;
            dataGrid_myflights.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Navy;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGrid_myflights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGrid_myflights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_myflights.Columns.AddRange(new DataGridViewColumn[] { col_ticket_id, col_flight_path, col_status });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGrid_myflights.DefaultCellStyle = dataGridViewCellStyle5;
            dataGrid_myflights.EnableHeadersVisualStyles = false;
            dataGrid_myflights.GridColor = Color.AliceBlue;
            dataGrid_myflights.Location = new Point(14, 79);
            dataGrid_myflights.Margin = new Padding(3, 4, 3, 4);
            dataGrid_myflights.Name = "dataGrid_myflights";
            dataGrid_myflights.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGrid_myflights.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGrid_myflights.RowHeadersVisible = false;
            dataGrid_myflights.RowHeadersWidth = 51;
            dataGrid_myflights.Size = new Size(543, 491);
            dataGrid_myflights.TabIndex = 1;
            dataGrid_myflights.CellContentClick += dataGrid_myflights_CellContentClick;
            // 
            // col_ticket_id
            // 
            col_ticket_id.HeaderText = "Ticket ID";
            col_ticket_id.MinimumWidth = 6;
            col_ticket_id.Name = "col_ticket_id";
            col_ticket_id.ReadOnly = true;
            // 
            // col_flight_path
            // 
            col_flight_path.HeaderText = "Flight Path ";
            col_flight_path.MinimumWidth = 6;
            col_flight_path.Name = "col_flight_path";
            col_flight_path.ReadOnly = true;
            // 
            // col_status
            // 
            col_status.HeaderText = "Status";
            col_status.MinimumWidth = 6;
            col_status.Name = "col_status";
            col_status.ReadOnly = true;
            // 
            // btn_back_mybooks
            // 
            btn_back_mybooks.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_back_mybooks.BackColor = Color.Crimson;
            btn_back_mybooks.FlatAppearance.BorderSize = 0;
            btn_back_mybooks.FlatStyle = FlatStyle.Flat;
            btn_back_mybooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back_mybooks.ForeColor = Color.White;
            btn_back_mybooks.Location = new Point(719, 511);
            btn_back_mybooks.Margin = new Padding(3, 4, 3, 4);
            btn_back_mybooks.Name = "btn_back_mybooks";
            btn_back_mybooks.Size = new Size(153, 50);
            btn_back_mybooks.TabIndex = 2;
            btn_back_mybooks.Text = "Back";
            btn_back_mybooks.UseVisualStyleBackColor = false;
            btn_back_mybooks.Click += btn_back_mybooks_Click;
            // 
            // lbl_totalbookings
            // 
            lbl_totalbookings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_totalbookings.AutoSize = true;
            lbl_totalbookings.BackColor = Color.Transparent;
            lbl_totalbookings.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_totalbookings.ForeColor = Color.Navy;
            lbl_totalbookings.Location = new Point(145, 25);
            lbl_totalbookings.Name = "lbl_totalbookings";
            lbl_totalbookings.Size = new Size(282, 50);
            lbl_totalbookings.TabIndex = 3;
            lbl_totalbookings.Text = "Total Bookings";
            // 
            // My_book_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lbl_totalbookings);
            Controls.Add(btn_back_mybooks);
            Controls.Add(dataGrid_myflights);
            Controls.Add(pic_tot_book);
            Margin = new Padding(3, 4, 3, 4);
            Name = "My_book_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Booking";
            Load += My_book_frm_Load;
            ((System.ComponentModel.ISupportInitialize)pic_tot_book).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_myflights).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_tot_book;
        private DataGridView dataGrid_myflights;
        private DataGridViewTextBoxColumn col_ticket_id;
        private DataGridViewTextBoxColumn col_flight_path;
        private DataGridViewTextBoxColumn col_status;
        private Button btn_back_mybooks;
        private Label lbl_totalbookings;
    }
}