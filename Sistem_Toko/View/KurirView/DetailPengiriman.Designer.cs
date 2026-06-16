namespace Sistem_Toko.View.KurirView
{
    partial class DetailPengiriman
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
            TxtNota = new RichTextBox();
            LblJudul = new Label();
            LblTujuan = new Label();
            LblTotalHarga = new Label();
            Btn_Kembali = new Button();
            PanelNota = new Panel();
            PanelNota.SuspendLayout();
            SuspendLayout();
            // 
            // TxtNota
            // 
            TxtNota.BackColor = Color.White;
            TxtNota.BorderStyle = BorderStyle.None;
            TxtNota.Dock = DockStyle.Fill;
            TxtNota.Font = new Font("Consolas", 12F);
            TxtNota.Location = new Point(20, 20);
            TxtNota.Name = "TxtNota";
            TxtNota.ReadOnly = true;
            TxtNota.Size = new Size(860, 360);
            TxtNota.TabIndex = 0;
            TxtNota.Text = "";
            // 
            // PanelNota
            // 
            PanelNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelNota.BackColor = Color.White;
            PanelNota.Controls.Add(TxtNota);
            PanelNota.Location = new Point(40, 180);
            PanelNota.Name = "PanelNota";
            PanelNota.Padding = new Padding(20);
            PanelNota.Size = new Size(900, 400);
            PanelNota.TabIndex = 4;
            // 
            // LblJudul
            // 
            LblJudul.AutoSize = true;
            LblJudul.BackColor = System.Drawing.Color.Transparent;
            LblJudul.Font = new Font("Book Antiqua", 28F, FontStyle.Bold);
            LblJudul.Location = new Point(30, 30);
            LblJudul.Name = "LblJudul";
            LblJudul.Size = new Size(300, 45);
            LblJudul.TabIndex = 5;
            LblJudul.Text = "Detail Pesanan";
            // 
            // LblTujuan
            // 
            LblTujuan.AutoSize = true;
            LblTujuan.BackColor = System.Drawing.Color.Transparent;
            LblTujuan.Font = new Font("Segoe UI", 12F);
            LblTujuan.Location = new Point(36, 100);
            LblTujuan.Name = "LblTujuan";
            LblTujuan.Size = new Size(140, 21);
            LblTujuan.TabIndex = 6;
            LblTujuan.Text = "Alamat Pengiriman";
            // 
            // LblTotalHarga
            // 
            LblTotalHarga.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblTotalHarga.BackColor = System.Drawing.Color.Transparent;
            LblTotalHarga.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LblTotalHarga.Location = new Point(540, 600);
            LblTotalHarga.Name = "LblTotalHarga";
            LblTotalHarga.Size = new Size(400, 30);
            LblTotalHarga.TabIndex = 7;
            LblTotalHarga.Text = "Total: Rp 0";
            LblTotalHarga.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_Kembali
            // 
            Btn_Kembali.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_Kembali.BackColor = Color.SeaGreen;
            Btn_Kembali.Cursor = Cursors.Hand;
            Btn_Kembali.FlatAppearance.BorderSize = 0;
            Btn_Kembali.FlatStyle = FlatStyle.Flat;
            Btn_Kembali.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Kembali.ForeColor = Color.White;
            Btn_Kembali.Location = new Point(40, 600);
            Btn_Kembali.Name = "Btn_Kembali";
            Btn_Kembali.Size = new Size(150, 45);
            Btn_Kembali.TabIndex = 8;
            Btn_Kembali.Text = "Kembali";
            Btn_Kembali.UseVisualStyleBackColor = false;
            Btn_Kembali.Click += Btn_Kembali_Click;
            // 
            // DetailPengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(980, 680);
            Controls.Add(Btn_Kembali);
            Controls.Add(LblTotalHarga);
            Controls.Add(LblTujuan);
            Controls.Add(LblJudul);
            Controls.Add(PanelNota);
            DoubleBuffered = true;
            Name = "DetailPengiriman";
            Text = "Detail Pengiriman - Toko Taniku";
            WindowState = FormWindowState.Maximized;
            Load += DetailPengiriman_Load;
            PanelNota.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox TxtNota;
        private Panel PanelNota;
        private Label LblJudul;
        private Label LblTujuan;
        private Label LblTotalHarga;
        private Button Btn_Kembali;
    }
}