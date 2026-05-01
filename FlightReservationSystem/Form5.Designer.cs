namespace FlightReservationSystem
{
    partial class payment_frm
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
            pic_payment = new PictureBox();
            grp_pay = new GroupBox();
            txt_pay_pass = new TextBox();
            cmb_cardtype = new ComboBox();
            txt_paynote = new Label();
            lbl_pay_pass = new Label();
            lbl_card = new Label();
            btn_pay_confirm = new Button();
            btn_pay_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_payment).BeginInit();
            grp_pay.SuspendLayout();
            SuspendLayout();
            // 
            // pic_payment
            // 
            pic_payment.Dock = DockStyle.Fill;
            pic_payment.Image = Properties.Resources.WhatsApp_Image_2026_05_01_at_10_47_50_AM;
            pic_payment.Location = new Point(0, 0);
            pic_payment.Margin = new Padding(3, 4, 3, 4);
            pic_payment.Name = "pic_payment";
            pic_payment.Size = new Size(914, 597);
            pic_payment.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_payment.TabIndex = 0;
            pic_payment.TabStop = false;
            // 
            // grp_pay
            // 
            grp_pay.Anchor = AnchorStyles.None;
            grp_pay.BackColor = Color.Transparent;
            grp_pay.Controls.Add(txt_pay_pass);
            grp_pay.Controls.Add(cmb_cardtype);
            grp_pay.Controls.Add(txt_paynote);
            grp_pay.Controls.Add(lbl_pay_pass);
            grp_pay.Controls.Add(lbl_card);
            grp_pay.Controls.Add(btn_pay_confirm);
            grp_pay.Controls.Add(btn_pay_back);
            grp_pay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_pay.Location = new Point(140, 50);
            grp_pay.Margin = new Padding(3, 4, 3, 4);
            grp_pay.Name = "grp_pay";
            grp_pay.Padding = new Padding(3, 4, 3, 4);
            grp_pay.Size = new Size(531, 463);
            grp_pay.TabIndex = 1;
            grp_pay.TabStop = false;
            grp_pay.Enter += grp_pay_Enter;
            // 
            // txt_pay_pass
            // 
            txt_pay_pass.BackColor = SystemColors.Window;
            txt_pay_pass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_pay_pass.Location = new Point(261, 180);
            txt_pay_pass.Margin = new Padding(3, 4, 3, 4);
            txt_pay_pass.Name = "txt_pay_pass";
            txt_pay_pass.PasswordChar = '*';
            txt_pay_pass.Size = new Size(138, 32);
            txt_pay_pass.TabIndex = 6;
            txt_pay_pass.TextAlign = HorizontalAlignment.Center;
            txt_pay_pass.TextChanged += txt_pay_pass_TextChanged;
            // 
            // cmb_cardtype
            // 
            cmb_cardtype.Font = new Font("Segoe UI Semilight", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmb_cardtype.ForeColor = SystemColors.InactiveCaptionText;
            cmb_cardtype.FormattingEnabled = true;
            cmb_cardtype.Items.AddRange(new object[] { "Visa", "MasterCard", "PayPAL" });
            cmb_cardtype.Location = new Point(261, 95);
            cmb_cardtype.Margin = new Padding(3, 4, 3, 4);
            cmb_cardtype.Name = "cmb_cardtype";
            cmb_cardtype.Size = new Size(138, 33);
            cmb_cardtype.TabIndex = 5;
            cmb_cardtype.Text = "  card type";
            cmb_cardtype.SelectedIndexChanged += cmb_cardtype_SelectedIndexChanged;
            // 
            // txt_paynote
            // 
            txt_paynote.AutoSize = true;
            txt_paynote.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_paynote.Location = new Point(41, 274);
            txt_paynote.Name = "txt_paynote";
            txt_paynote.Size = new Size(452, 20);
            txt_paynote.TabIndex = 4;
            txt_paynote.Text = "*The total amount requested will be deducted from your account";
            // 
            // lbl_pay_pass
            // 
            lbl_pay_pass.AutoSize = true;
            lbl_pay_pass.ForeColor = Color.Navy;
            lbl_pay_pass.Location = new Point(41, 180);
            lbl_pay_pass.Name = "lbl_pay_pass";
            lbl_pay_pass.Size = new Size(215, 28);
            lbl_pay_pass.TabIndex = 3;
            lbl_pay_pass.Text = "Enter Login Password";
            // 
            // lbl_card
            // 
            lbl_card.AutoSize = true;
            lbl_card.ForeColor = Color.Navy;
            lbl_card.Location = new Point(41, 95);
            lbl_card.Name = "lbl_card";
            lbl_card.Size = new Size(169, 28);
            lbl_card.TabIndex = 2;
            lbl_card.Text = "Select Card Type";
            lbl_card.Click += lbl_card_Click;
            // 
            // btn_pay_confirm
            // 
            btn_pay_confirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_pay_confirm.BackColor = Color.Green;
            btn_pay_confirm.FlatAppearance.BorderSize = 0;
            btn_pay_confirm.FlatStyle = FlatStyle.Flat;
            btn_pay_confirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pay_confirm.ForeColor = Color.White;
            btn_pay_confirm.Location = new Point(393, 404);
            btn_pay_confirm.Margin = new Padding(3, 4, 3, 4);
            btn_pay_confirm.Name = "btn_pay_confirm";
            btn_pay_confirm.Size = new Size(112, 39);
            btn_pay_confirm.TabIndex = 1;
            btn_pay_confirm.Text = "Confirm";
            btn_pay_confirm.UseVisualStyleBackColor = false;
            btn_pay_confirm.Click += btn_pay_confirm_Click;
            // 
            // btn_pay_back
            // 
            btn_pay_back.BackColor = Color.IndianRed;
            btn_pay_back.FlatAppearance.BorderSize = 0;
            btn_pay_back.FlatStyle = FlatStyle.Flat;
            btn_pay_back.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pay_back.ForeColor = Color.White;
            btn_pay_back.Location = new Point(238, 404);
            btn_pay_back.Margin = new Padding(3, 4, 3, 4);
            btn_pay_back.Name = "btn_pay_back";
            btn_pay_back.Size = new Size(98, 39);
            btn_pay_back.TabIndex = 0;
            btn_pay_back.Text = "Back";
            btn_pay_back.UseVisualStyleBackColor = false;
            btn_pay_back.Click += btn_pay_back_Click;
            // 
            // payment_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 597);
            Controls.Add(grp_pay);
            Controls.Add(pic_payment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "payment_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += payment_frm_Load;
            ((System.ComponentModel.ISupportInitialize)pic_payment).EndInit();
            grp_pay.ResumeLayout(false);
            grp_pay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_payment;
        private GroupBox grp_pay;
        private TextBox txt_pay_pass;
        private ComboBox cmb_cardtype;
        private Label txt_paynote;
        private Label lbl_pay_pass;
        private Label lbl_card;
        private Button btn_pay_confirm;
        private Button btn_pay_back;
    }
}