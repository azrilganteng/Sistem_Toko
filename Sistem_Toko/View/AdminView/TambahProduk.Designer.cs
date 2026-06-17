namespace Sistem_Toko.View.AdminView
{
    partial class TambahProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahProduk));
            LblJudul = new Label();
            LblNama = new Label();
            LblHarga = new Label();
            LblSupplier = new Label();
            LblDeskripsi = new Label();
            LblKategori = new Label();
            LblGambar = new Label();
            TxtNama = new TextBox();
            TxtHarga = new TextBox();
            CmbSupplier = new ComboBox();
            TxtDeskripsi = new TextBox();
            CmbKategori = new ComboBox();
            TxtGambar = new TextBox();
            BtnBrowse = new Button();
            BtnSimpan = new Button();
            BtnKembali = new Button();
            PnlPreview = new Panel();
            PbPreview = new PictureBox();
            PnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbPreview).BeginInit();
            SuspendLayout();
            // 
            // LblJudul
            // 
            LblJudul.AutoSize = true;
            LblJudul.BackColor = System.Drawing.Color.Transparent;
            LblJudul.Font = new Font("Book Antiqua", 15F, FontStyle.Bold);
            LblJudul.Location = new Point(260, 15);
            LblJudul.Name = "LblJudul";
            LblJudul.Size = new Size(198, 29);
            LblJudul.TabIndex = 0;
            LblJudul.Text = "Tambah Produk";
            // 
            // LblNama
            // 
            LblNama.AutoSize = true;
            LblNama.BackColor = System.Drawing.Color.Transparent;
            LblNama.Font = new Font("Book Antiqua", 10F);
            LblNama.Location = new Point(40, 70);
            LblNama.Name = "LblNama";
            LblNama.Size = new Size(124, 22);
            LblNama.TabIndex = 1;
            LblNama.Text = "Nama Produk :";
            // 
            // LblHarga
            // 
            LblHarga.AutoSize = true;
            LblHarga.BackColor = System.Drawing.Color.Transparent;
            LblHarga.Font = new Font("Book Antiqua", 10F);
            LblHarga.Location = new Point(40, 110);
            LblHarga.Name = "LblHarga";
            LblHarga.Size = new Size(66, 22);
            LblHarga.TabIndex = 2;
            LblHarga.Text = "Harga :";
            // 
            // LblSupplier
            // 
            LblSupplier = new Label();
            LblSupplier.AutoSize = true;
            LblSupplier.BackColor = System.Drawing.Color.Transparent;
            LblSupplier.Font = new Font("Book Antiqua", 10F);
            LblSupplier.Location = new Point(40, 150);
            LblSupplier.Name = "LblSupplier";
            LblSupplier.Size = new Size(80, 22);
            LblSupplier.TabIndex = 3;
            LblSupplier.Text = "Supplier :";
            // 
            // LblDeskripsi
            // 
            LblDeskripsi.AutoSize = true;
            LblDeskripsi.BackColor = System.Drawing.Color.Transparent;
            LblDeskripsi.Font = new Font("Book Antiqua", 10F);
            LblDeskripsi.Location = new Point(40, 190);
            LblDeskripsi.Name = "LblDeskripsi";
            LblDeskripsi.Size = new Size(89, 22);
            LblDeskripsi.TabIndex = 4;
            LblDeskripsi.Text = "Deskripsi :";
            // 
            // LblKategori
            // 
            LblKategori.AutoSize = true;
            LblKategori.BackColor = System.Drawing.Color.Transparent;
            LblKategori.Font = new Font("Book Antiqua", 10F);
            LblKategori.Location = new Point(40, 260);
            LblKategori.Name = "LblKategori";
            LblKategori.Size = new Size(83, 22);
            LblKategori.TabIndex = 5;
            LblKategori.Text = "Kategori :";
            // 
            // LblGambar
            // 
            LblGambar.AutoSize = true;
            LblGambar.BackColor = System.Drawing.Color.Transparent;
            LblGambar.Font = new Font("Book Antiqua", 10F);
            LblGambar.Location = new Point(40, 305);
            LblGambar.Name = "LblGambar";
            LblGambar.Size = new Size(80, 22);
            LblGambar.TabIndex = 6;
            LblGambar.Text = "Gambar :";
            // 
            // TxtNama
            // 
            TxtNama.Location = new Point(180, 65);
            TxtNama.Name = "TxtNama";
            TxtNama.Size = new Size(280, 30);
            TxtNama.TabIndex = 10;
            // 
            // TxtHarga
            // 
            TxtHarga.Location = new Point(180, 105);
            TxtHarga.Name = "TxtHarga";
            TxtHarga.Size = new Size(160, 30);
            TxtHarga.TabIndex = 11;
            // 
            // CmbSupplier
            // 
            CmbSupplier = new ComboBox();
            CmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSupplier.FormattingEnabled = true;
            CmbSupplier.Location = new Point(180, 145);
            CmbSupplier.Name = "CmbSupplier";
            CmbSupplier.Size = new Size(240, 31);
            CmbSupplier.TabIndex = 12;
            // 
            // BtnTambahSupplier
            // 
            BtnTambahSupplier = new Button();
            BtnTambahSupplier.BackColor = Color.MediumSeaGreen;
            BtnTambahSupplier.Cursor = Cursors.Hand;
            BtnTambahSupplier.FlatStyle = FlatStyle.Flat;
            BtnTambahSupplier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnTambahSupplier.ForeColor = Color.White;
            BtnTambahSupplier.Location = new Point(430, 144);
            BtnTambahSupplier.Name = "BtnTambahSupplier";
            BtnTambahSupplier.Size = new Size(30, 33);
            BtnTambahSupplier.TabIndex = 100;
            BtnTambahSupplier.Text = "+";
            BtnTambahSupplier.UseVisualStyleBackColor = false;
            BtnTambahSupplier.Click += BtnTambahSupplier_Click;
            // 
            // TxtDeskripsi
            // 
            TxtDeskripsi.Location = new Point(180, 185);
            TxtDeskripsi.Multiline = true;
            TxtDeskripsi.Name = "TxtDeskripsi";
            TxtDeskripsi.Size = new Size(280, 60);
            TxtDeskripsi.TabIndex = 13;
            // 
            // CmbKategori
            // 
            CmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbKategori.FormattingEnabled = true;
            CmbKategori.Items.AddRange(new object[] { "Pupuk", "Obat", "Bibit" });
            CmbKategori.Location = new Point(180, 255);
            CmbKategori.Name = "CmbKategori";
            CmbKategori.Size = new Size(160, 31);
            CmbKategori.TabIndex = 14;
            // 
            // TxtGambar
            // 
            TxtGambar.Location = new Point(180, 300);
            TxtGambar.Name = "TxtGambar";
            TxtGambar.ReadOnly = true;
            TxtGambar.Size = new Size(230, 30);
            TxtGambar.TabIndex = 15;
            // 
            // BtnBrowse
            // 
            BtnBrowse.BackColor = Color.MediumSeaGreen;
            BtnBrowse.Cursor = Cursors.Hand;
            BtnBrowse.FlatStyle = FlatStyle.Flat;
            BtnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnBrowse.ForeColor = Color.White;
            BtnBrowse.Location = new Point(420, 299);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(40, 32);
            BtnBrowse.TabIndex = 16;
            BtnBrowse.Text = "...";
            BtnBrowse.UseVisualStyleBackColor = false;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSimpan.BackColor = Color.SeaGreen;
            BtnSimpan.Cursor = Cursors.Hand;
            BtnSimpan.FlatStyle = FlatStyle.Flat;
            BtnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnSimpan.ForeColor = Color.White;
            BtnSimpan.Location = new Point(567, 340);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(133, 40);
            BtnSimpan.TabIndex = 20;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnKembali
            // 
            BtnKembali.BackColor = Color.Transparent;
            BtnKembali.BackgroundImage = (Image)resources.GetObject("BtnKembali.BackgroundImage");
            BtnKembali.BackgroundImageLayout = ImageLayout.Zoom;
            BtnKembali.Location = new Point(5, 12);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(40, 40);
            BtnKembali.TabIndex = 99;
            BtnKembali.UseVisualStyleBackColor = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // PnlPreview
            // 
            PnlPreview.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlPreview.BorderStyle = BorderStyle.FixedSingle;
            PnlPreview.Controls.Add(PbPreview);
            PnlPreview.Location = new Point(500, 65);
            PnlPreview.Name = "PnlPreview";
            PnlPreview.Size = new Size(200, 200);
            PnlPreview.TabIndex = 17;
            // 
            // PbPreview
            // 
            PbPreview.Dock = DockStyle.Fill;
            PbPreview.Location = new Point(0, 0);
            PbPreview.Name = "PbPreview";
            PbPreview.Size = new Size(198, 198);
            PbPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            PbPreview.TabIndex = 0;
            PbPreview.TabStop = false;
            // 
            // TambahProduk
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(730, 400);

            Controls.Add(BtnKembali);
            Controls.Add(BtnSimpan);
            Controls.Add(PnlPreview);
            Controls.Add(BtnBrowse);
            Controls.Add(TxtGambar);
            Controls.Add(CmbKategori);
            Controls.Add(TxtDeskripsi);
            Controls.Add(CmbSupplier);
            Controls.Add(BtnTambahSupplier);
            Controls.Add(TxtHarga);
            Controls.Add(TxtNama);
            Controls.Add(LblGambar);
            Controls.Add(LblKategori);
            Controls.Add(LblDeskripsi);
            Controls.Add(LblSupplier);
            Controls.Add(LblHarga);
            Controls.Add(LblNama);
            Controls.Add(LblJudul);
            Font = new Font("Segoe UI", 10F);
            Name = "TambahProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tambah Produk";
            PnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblJudul;
        private Label LblNama;
        private Label LblHarga;
        private Label LblSupplier;
        private Label LblDeskripsi;
        private Label LblKategori;
        private Label LblGambar;
        private TextBox TxtNama;
        private TextBox TxtHarga;
        private ComboBox CmbSupplier;
        private Button BtnTambahSupplier;
        private TextBox TxtDeskripsi;
        private ComboBox CmbKategori;
        private TextBox TxtGambar;
        private Button BtnBrowse;
        private Panel PnlPreview;
        private PictureBox PbPreview;
        private Button BtnSimpan;
        private Button BtnKembali;
    }
}
