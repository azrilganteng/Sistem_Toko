namespace Sistem_Toko.View.AdminView
{
    partial class Restock
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restock));
            LblToko = new Label();
            Btn_Kembali = new Button();
            LblSubjudul = new Label();
            LblInfo = new Label();
            PnlScroll = new Panel();
            FlowProduk = new FlowLayoutPanel();
            Btn_Simpan = new Button();
            Btn_Tambah_Produk = new Button();
            PnlScroll.SuspendLayout();
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.BackColor = System.Drawing.Color.Transparent;
            LblToko.Font = new Font("Book Antiqua", 36F, FontStyle.Bold);
            LblToko.ForeColor = Color.FromArgb(40, 100, 60);
            LblToko.Location = new Point(53, 20);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(468, 73);
            LblToko.TabIndex = 11;
            LblToko.Text = "Restock Produk";
            // 
            // Btn_Kembali
            // 
            Btn_Kembali.BackColor = Color.Transparent;
            Btn_Kembali.BackgroundImage = (Image)resources.GetObject("Btn_Kembali.BackgroundImage");
            Btn_Kembali.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Kembali.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Kembali.ForeColor = Color.White;
            Btn_Kembali.Location = new Point(5, 12);
            Btn_Kembali.Name = "Btn_Kembali";
            Btn_Kembali.Size = new Size(40, 40);
            Btn_Kembali.TabIndex = 99;
            Btn_Kembali.UseVisualStyleBackColor = false;
            Btn_Kembali.Click += Btn_Kembali_Click;
            // 
            // LblSubjudul
            // 
            LblSubjudul.AutoSize = true;
            LblSubjudul.BackColor = System.Drawing.Color.Transparent;
            LblSubjudul.Font = new Font("Segoe UI", 10F);
            LblSubjudul.ForeColor = Color.Gray;
            LblSubjudul.Location = new Point(55, 85);
            LblSubjudul.Name = "LblSubjudul";
            LblSubjudul.Size = new Size(596, 23);
            LblSubjudul.TabIndex = 12;
            LblSubjudul.Text = "Centang produk yang ingin di-restock, lalu masukkan jumlah tambahan stok.";
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Segoe UI", 10F);
            LblInfo.ForeColor = Color.Gray;
            LblInfo.Location = new Point(55, 120);
            LblInfo.Name = "LblInfo";
            LblInfo.BackColor = System.Drawing.Color.Transparent;
            LblInfo.Size = new Size(145, 23);
            LblInfo.TabIndex = 13;
            LblInfo.Text = "Memuat produk...";
            LblInfo.Visible = false;
            // 
            // PnlScroll
            // 
            PnlScroll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PnlScroll.AutoScroll = true;
            PnlScroll.BackColor = Color.WhiteSmoke;
            PnlScroll.BorderStyle = BorderStyle.FixedSingle;
            PnlScroll.Controls.Add(FlowProduk);
            PnlScroll.Location = new Point(55, 115);
            PnlScroll.Name = "PnlScroll";
            PnlScroll.Size = new Size(1060, 370);
            PnlScroll.TabIndex = 14;
            // 
            // FlowProduk
            // 
            FlowProduk.AutoSize = true;
            FlowProduk.Dock = DockStyle.Top;
            FlowProduk.FlowDirection = FlowDirection.TopDown;
            FlowProduk.Location = new Point(0, 0);
            FlowProduk.Name = "FlowProduk";
            FlowProduk.Padding = new Padding(4);
            FlowProduk.Size = new Size(1058, 8);
            FlowProduk.TabIndex = 0;
            FlowProduk.WrapContents = false;
            // 
            // Btn_Simpan
            // 
            Btn_Simpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_Simpan.BackColor = Color.SeaGreen;
            Btn_Simpan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Simpan.ForeColor = Color.White;
            Btn_Simpan.Location = new Point(55, 500);
            Btn_Simpan.Name = "Btn_Simpan";
            Btn_Simpan.Size = new Size(200, 44);
            Btn_Simpan.TabIndex = 15;
            Btn_Simpan.Text = "✔ Simpan Restock";
            Btn_Simpan.UseVisualStyleBackColor = false;
            Btn_Simpan.Click += Btn_Simpan_Click;
            // 
            // Btn_Tambah_Produk
            // 
            Btn_Tambah_Produk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_Tambah_Produk.BackColor = Color.DarkOrange;
            Btn_Tambah_Produk.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Tambah_Produk.ForeColor = Color.White;
            Btn_Tambah_Produk.Location = new Point(270, 500);
            Btn_Tambah_Produk.Name = "Btn_Tambah_Produk";
            Btn_Tambah_Produk.Size = new Size(200, 44);
            Btn_Tambah_Produk.TabIndex = 16;
            Btn_Tambah_Produk.Text = "+ Tambah Produk";
            Btn_Tambah_Produk.UseVisualStyleBackColor = false;
            Btn_Tambah_Produk.Click += Btn_Tambah_Produk_Click;
            // 
            // Restock
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1168, 568);
            Controls.Add(Btn_Tambah_Produk);
            Controls.Add(Btn_Simpan);
            Controls.Add(PnlScroll);
            Controls.Add(LblInfo);
            Controls.Add(LblSubjudul);
            Controls.Add(LblToko);
            Controls.Add(Btn_Kembali);
            Font = new Font("Segoe UI", 10F);
            Name = "Restock";
            Text = "Restock Produk";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            PnlScroll.ResumeLayout(false);
            PnlScroll.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LblToko;
        private System.Windows.Forms.Button Btn_Kembali;
        private System.Windows.Forms.Label LblSubjudul;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Panel PnlScroll;
        private System.Windows.Forms.FlowLayoutPanel FlowProduk;
        private System.Windows.Forms.Button Btn_Simpan;
        private System.Windows.Forms.Button Btn_Tambah_Produk;
    }
}
