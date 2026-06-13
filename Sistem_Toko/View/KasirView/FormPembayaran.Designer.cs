namespace Sistem_Toko
{
    partial class FormPembayaran
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
            panelHeader = new Panel();
            BackBtn = new Button();
            LblHeader = new Label();
            panelContent = new Panel();
            LblMetodeKirim = new Label();
            LblMetodeBayar = new Label();
            CboMetodeKirim = new ComboBox();
            CboMetodeBayar = new ComboBox();
            lblTotal = new Label();
            txtNota = new TextBox();
            KonfirmBtn = new Button();
            LblNotaTitle = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SeaGreen;
            panelHeader.Controls.Add(BackBtn);
            panelHeader.Controls.Add(LblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1067, 100);
            panelHeader.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.White;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BackBtn.ForeColor = Color.SeaGreen;
            BackBtn.Location = new Point(15, 35);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(90, 40);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "< Kembali";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // LblHeader
            // 
            LblHeader.AutoSize = true;
            LblHeader.Font = new Font("Book Antiqua", 28F, FontStyle.Bold);
            LblHeader.ForeColor = Color.White;
            LblHeader.Location = new Point(130, 22);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(300, 55);
            LblHeader.TabIndex = 1;
            LblHeader.Text = "Pembayaran";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Controls.Add(LblNotaTitle);
            panelContent.Controls.Add(LblMetodeKirim);
            panelContent.Controls.Add(LblMetodeBayar);
            panelContent.Controls.Add(CboMetodeKirim);
            panelContent.Controls.Add(CboMetodeBayar);
            panelContent.Controls.Add(lblTotal);
            panelContent.Controls.Add(txtNota);
            panelContent.Controls.Add(KonfirmBtn);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(30);
            panelContent.Size = new Size(1067, 471);
            panelContent.TabIndex = 1;
            // 
            // LblNotaTitle
            // 
            LblNotaTitle.AutoSize = true;
            LblNotaTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LblNotaTitle.ForeColor = Color.SeaGreen;
            LblNotaTitle.Location = new Point(50, 20);
            LblNotaTitle.Name = "LblNotaTitle";
            LblNotaTitle.Size = new Size(180, 32);
            LblNotaTitle.TabIndex = 10;
            LblNotaTitle.Text = "Detail Pesanan";
            // 
            // LblMetodeKirim
            // 
            LblMetodeKirim.AutoSize = true;
            LblMetodeKirim.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblMetodeKirim.Location = new Point(50, 310);
            LblMetodeKirim.Name = "LblMetodeKirim";
            LblMetodeKirim.Size = new Size(140, 25);
            LblMetodeKirim.TabIndex = 7;
            LblMetodeKirim.Text = "Metode Kirim:";
            // 
            // LblMetodeBayar
            // 
            LblMetodeBayar.AutoSize = true;
            LblMetodeBayar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblMetodeBayar.Location = new Point(50, 360);
            LblMetodeBayar.Name = "LblMetodeBayar";
            LblMetodeBayar.Size = new Size(145, 25);
            LblMetodeBayar.TabIndex = 8;
            LblMetodeBayar.Text = "Metode Bayar:";
            // 
            // CboMetodeKirim
            // 
            CboMetodeKirim.DropDownStyle = ComboBoxStyle.DropDownList;
            CboMetodeKirim.Font = new Font("Segoe UI", 11F);
            CboMetodeKirim.Location = new Point(220, 307);
            CboMetodeKirim.Name = "CboMetodeKirim";
            CboMetodeKirim.Size = new Size(200, 33);
            CboMetodeKirim.TabIndex = 0;
            // 
            // CboMetodeBayar
            // 
            CboMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;
            CboMetodeBayar.Font = new Font("Segoe UI", 11F);
            CboMetodeBayar.Location = new Point(220, 357);
            CboMetodeBayar.Name = "CboMetodeBayar";
            CboMetodeBayar.Size = new Size(200, 33);
            CboMetodeBayar.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotal.ForeColor = Color.SeaGreen;
            lblTotal.Location = new Point(50, 415);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(180, 37);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: Rp. 0";
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.White;
            txtNota.BorderStyle = BorderStyle.FixedSingle;
            txtNota.Font = new Font("Consolas", 11F);
            txtNota.Location = new Point(50, 60);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.ReadOnly = true;
            txtNota.ScrollBars = ScrollBars.Vertical;
            txtNota.Size = new Size(960, 230);
            txtNota.TabIndex = 4;
            txtNota.WordWrap = false;
            // 
            // KonfirmBtn
            // 
            KonfirmBtn.BackColor = Color.SeaGreen;
            KonfirmBtn.Cursor = Cursors.Hand;
            KonfirmBtn.FlatAppearance.BorderSize = 0;
            KonfirmBtn.FlatStyle = FlatStyle.Flat;
            KonfirmBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            KonfirmBtn.ForeColor = Color.White;
            KonfirmBtn.Location = new Point(830, 395);
            KonfirmBtn.Name = "KonfirmBtn";
            KonfirmBtn.Size = new Size(180, 55);
            KonfirmBtn.TabIndex = 5;
            KonfirmBtn.Text = "Konfirmasi Bayar";
            KonfirmBtn.UseVisualStyleBackColor = false;
            KonfirmBtn.Click += KonfirmBtn_Click;
            // 
            // FormPembayaran
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1067, 571);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 10F);
            Name = "FormPembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pembayaran - Toko Tani Samudra";
            FormClosing += FormPembayaran_FormClosing;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button BackBtn;
        private Label LblHeader;
        private Panel panelContent;
        private Label LblNotaTitle;
        private Label LblMetodeKirim;
        private Label LblMetodeBayar;
        private ComboBox CboMetodeKirim;
        private ComboBox CboMetodeBayar;
        private Label lblTotal;
        private TextBox txtNota;
        private Button KonfirmBtn;
    }
}
