namespace FlightReservationSystem
{
    partial class loginfrm
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
            piclogin = new PictureBox();
            pnl_login = new Panel();
            lbl_login = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            lbl_loginpassword = new Label();
            lbl_logname = new Label();
            pnl_buts_login = new Panel();
            btn_exit = new Button();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)piclogin).BeginInit();
            pnl_login.SuspendLayout();
            pnl_buts_login.SuspendLayout();
            SuspendLayout();
            // 
            // piclogin
            // 
            piclogin.BackgroundImageLayout = ImageLayout.Stretch;
            piclogin.Dock = DockStyle.Fill;
            piclogin.Image = Properties.Resources.WhatsApp_Image_2026_04_29_at_7_05_45_PM;
            piclogin.Location = new Point(0, 0);
            piclogin.Margin = new Padding(3, 4, 3, 4);
            piclogin.Name = "piclogin";
            piclogin.Size = new Size(914, 600);
            piclogin.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogin.TabIndex = 0;
            piclogin.TabStop = false;
            // 
            // pnl_login
            // 
            pnl_login.Anchor = AnchorStyles.None;
            pnl_login.BackColor = Color.Transparent;
            pnl_login.Controls.Add(lbl_login);
            pnl_login.Controls.Add(txtusername);
            pnl_login.Controls.Add(txtpassword);
            pnl_login.Controls.Add(lbl_loginpassword);
            pnl_login.Controls.Add(lbl_logname);
            pnl_login.Location = new Point(7, 93);
            pnl_login.Margin = new Padding(3, 4, 3, 4);
            pnl_login.Name = "pnl_login";
            pnl_login.Size = new Size(437, 372);
            pnl_login.TabIndex = 1;
            // 
            // lbl_login
            // 
            lbl_login.Anchor = AnchorStyles.None;
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.Navy;
            lbl_login.Location = new Point(112, 65);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(216, 41);
            lbl_login.TabIndex = 4;
            lbl_login.Text = "SkyWay Login";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(112, 156);
            txtusername.Margin = new Padding(3, 4, 3, 4);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(257, 34);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(135, 265);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(234, 34);
            txtpassword.TabIndex = 2;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // lbl_loginpassword
            // 
            lbl_loginpassword.Anchor = AnchorStyles.None;
            lbl_loginpassword.AutoSize = true;
            lbl_loginpassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_loginpassword.Location = new Point(37, 265);
            lbl_loginpassword.Name = "lbl_loginpassword";
            lbl_loginpassword.Size = new Size(106, 25);
            lbl_loginpassword.TabIndex = 1;
            lbl_loginpassword.Text = "Password : ";
            // 
            // lbl_logname
            // 
            lbl_logname.Anchor = AnchorStyles.None;
            lbl_logname.AutoSize = true;
            lbl_logname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_logname.ForeColor = Color.Black;
            lbl_logname.Location = new Point(37, 156);
            lbl_logname.Name = "lbl_logname";
            lbl_logname.Size = new Size(78, 28);
            lbl_logname.TabIndex = 0;
            lbl_logname.Text = "Email : ";
            lbl_logname.Click += lbl_logname_Click;
            // 
            // pnl_buts_login
            // 
            pnl_buts_login.Anchor = AnchorStyles.None;
            pnl_buts_login.BackColor = Color.Transparent;
            pnl_buts_login.Controls.Add(btn_exit);
            pnl_buts_login.Controls.Add(btn_login);
            pnl_buts_login.Location = new Point(499, 504);
            pnl_buts_login.Margin = new Padding(3, 4, 3, 4);
            pnl_buts_login.Name = "pnl_buts_login";
            pnl_buts_login.Size = new Size(385, 80);
            pnl_buts_login.TabIndex = 2;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.None;
            btn_exit.BackColor = Color.IndianRed;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(223, 4);
            btn_exit.Margin = new Padding(3, 4, 3, 4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(125, 40);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.BackColor = Color.Navy;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(34, 2);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(126, 44);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click_1;
            // 
            // loginfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(pnl_buts_login);
            Controls.Add(pnl_login);
            Controls.Add(piclogin);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "loginfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += loginfrm_Load;
            ((System.ComponentModel.ISupportInitialize)piclogin).EndInit();
            pnl_login.ResumeLayout(false);
            pnl_login.PerformLayout();
            pnl_buts_login.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox piclogin;
        private Panel pnl_login;
        private Panel pnl_buts_login;
        private Label lbl_login;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lbl_loginpassword;
        private Label lbl_logname;
        private Button btn_exit;
        private Button btn_login;
    }
}