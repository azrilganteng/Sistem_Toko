namespace Sistem_Toko.View.KasirView
{
    partial class FormBuyNow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LblQty = new System.Windows.Forms.Label();
            this.TambahQty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblKategori = new System.Windows.Forms.Label();
            this.LblProduk = new System.Windows.Forms.Label();
            this.BayarBtn = new System.Windows.Forms.Button();
            this.DeskripsiLbl = new System.Windows.Forms.Label();
            this.PbGambar = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbGambar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LblQty);
            this.panel1.Controls.Add(this.TambahQty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LblKategori);
            this.panel1.Controls.Add(this.LblProduk);
            this.panel1.Controls.Add(this.BayarBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(667, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 571);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(50, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LblQty.Location = new System.Drawing.Point(110, 245);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(28, 32);
            this.LblQty.TabIndex = 5;
            this.LblQty.Text = "1";
            this.LblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TambahQty
            // 
            this.TambahQty.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.TambahQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TambahQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TambahQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TambahQty.ForeColor = System.Drawing.Color.White;
            this.TambahQty.Location = new System.Drawing.Point(160, 240);
            this.TambahQty.Name = "TambahQty";
            this.TambahQty.Size = new System.Drawing.Size(40, 40);
            this.TambahQty.TabIndex = 4;
            this.TambahQty.Text = "+";
            this.TambahQty.UseVisualStyleBackColor = false;
            this.TambahQty.Click += new System.EventHandler(this.TambahQty_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(44, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beli Sekarang";
            // 
            // LblKategori
            // 
            this.LblKategori.AutoSize = true;
            this.LblKategori.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblKategori.ForeColor = System.Drawing.Color.Gray;
            this.LblKategori.Location = new System.Drawing.Point(45, 120);
            this.LblKategori.Name = "LblKategori";
            this.LblKategori.Size = new System.Drawing.Size(84, 25);
            this.LblKategori.TabIndex = 2;
            this.LblKategori.Text = "Kategori";
            // 
            // LblProduk
            // 
            this.LblProduk.Font = new System.Drawing.Font("Book Antiqua", 22F, System.Drawing.FontStyle.Bold);
            this.LblProduk.ForeColor = System.Drawing.Color.SeaGreen;
            this.LblProduk.Location = new System.Drawing.Point(40, 40);
            this.LblProduk.Name = "LblProduk";
            this.LblProduk.Size = new System.Drawing.Size(320, 80);
            this.LblProduk.TabIndex = 1;
            this.LblProduk.Text = "Nama Produk";
            // 
            // BayarBtn
            // 
            this.BayarBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.BayarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BayarBtn.FlatAppearance.BorderSize = 0;
            this.BayarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BayarBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BayarBtn.ForeColor = System.Drawing.Color.White;
            this.BayarBtn.Location = new System.Drawing.Point(50, 460);
            this.BayarBtn.Name = "BayarBtn";
            this.BayarBtn.Size = new System.Drawing.Size(300, 60);
            this.BayarBtn.TabIndex = 0;
            this.BayarBtn.Text = "BAYAR";
            this.BayarBtn.UseVisualStyleBackColor = false;
            this.BayarBtn.Click += new System.EventHandler(this.BayarBtn_Click);
            // 
            // DeskripsiLbl
            // 
            this.DeskripsiLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeskripsiLbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DeskripsiLbl.Location = new System.Drawing.Point(10, 30);
            this.DeskripsiLbl.Name = "DeskripsiLbl";
            this.DeskripsiLbl.Padding = new System.Windows.Forms.Padding(10);
            this.DeskripsiLbl.Size = new System.Drawing.Size(580, 160);
            this.DeskripsiLbl.TabIndex = 1;
            this.DeskripsiLbl.Text = "Deskripsi produk...";
            // 
            // PbGambar
            // 
            this.PbGambar.BackColor = System.Drawing.Color.White;
            this.PbGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbGambar.Location = new System.Drawing.Point(40, 80);
            this.PbGambar.Name = "PbGambar";
            this.PbGambar.Size = new System.Drawing.Size(600, 260);
            this.PbGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbGambar.TabIndex = 2;
            this.PbGambar.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Tomato;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(40, 40);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "X";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.DeskripsiLbl);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(40, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(600, 200);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deskripsi";
            // 
            // FormBuyNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Sistem_Toko.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1067, 571);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PbGambar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormBuyNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Beli Sekarang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbGambar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BayarBtn;
        private System.Windows.Forms.Label LblProduk;
        private System.Windows.Forms.Label LblKategori;
        private System.Windows.Forms.Button TambahQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DeskripsiLbl;
        private System.Windows.Forms.PictureBox PbGambar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}