namespace Sistem_Toko.View.AdminView
{
    partial class ProdukRestockControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            PnlKartu = new System.Windows.Forms.Panel();
            LblNamaProduk = new System.Windows.Forms.Label();
            LblStokSaatIni = new System.Windows.Forms.Label();
            LblDeskripsi = new System.Windows.Forms.Label();
            LblJumlah = new System.Windows.Forms.Label();
            NumJumlahRestock = new System.Windows.Forms.NumericUpDown();
            ChkPilih = new System.Windows.Forms.CheckBox();
            PnlKartu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumJumlahRestock).BeginInit();
            SuspendLayout();
            // 
            // PnlKartu
            // 
            PnlKartu.BackColor = System.Drawing.Color.White;
            PnlKartu.Controls.Add(ChkPilih);
            PnlKartu.Controls.Add(LblNamaProduk);
            PnlKartu.Controls.Add(LblStokSaatIni);
            PnlKartu.Controls.Add(LblJumlah);
            PnlKartu.Controls.Add(NumJumlahRestock);
            PnlKartu.Controls.Add(LblDeskripsi);
            PnlKartu.Dock = System.Windows.Forms.DockStyle.Fill;
            PnlKartu.Location = new System.Drawing.Point(0, 0);
            PnlKartu.Name = "PnlKartu";
            PnlKartu.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            PnlKartu.Size = new System.Drawing.Size(1000, 84);
            PnlKartu.TabIndex = 0;
            // 
            // ChkPilih
            // 
            ChkPilih.Location = new System.Drawing.Point(12, 20);
            ChkPilih.Name = "ChkPilih";
            ChkPilih.Size = new System.Drawing.Size(20, 20);
            ChkPilih.TabIndex = 0;
            ChkPilih.CheckedChanged += ChkPilih_CheckedChanged;
            // 
            // LblNamaProduk
            // 
            LblNamaProduk.AutoSize = false;
            LblNamaProduk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            LblNamaProduk.Location = new System.Drawing.Point(40, 8);
            LblNamaProduk.Name = "LblNamaProduk";
            LblNamaProduk.BackColor = System.Drawing.Color.Transparent;
            LblNamaProduk.Size = new System.Drawing.Size(220, 22);
            LblNamaProduk.TabIndex = 1;
            LblNamaProduk.Text = "Nama Produk";
            // 
            // LblStokSaatIni
            // 
            LblStokSaatIni.AutoSize = false;
            LblStokSaatIni.Font = new System.Drawing.Font("Segoe UI", 9F);
            LblStokSaatIni.ForeColor = System.Drawing.Color.Gray;
            LblStokSaatIni.Location = new System.Drawing.Point(40, 32);
            LblStokSaatIni.Name = "LblStokSaatIni";
            LblStokSaatIni.BackColor = System.Drawing.Color.Transparent;
            LblStokSaatIni.Size = new System.Drawing.Size(180, 20);
            LblStokSaatIni.TabIndex = 2;
            LblStokSaatIni.Text = "Stok: 0";
            // 
            // LblJumlah
            // 
            LblJumlah.AutoSize = true;
            LblJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            LblJumlah.Location = new System.Drawing.Point(270, 32);
            LblJumlah.Name = "LblJumlah";
            LblJumlah.BackColor = System.Drawing.Color.Transparent;
            LblJumlah.TabIndex = 3;
            LblJumlah.Text = "Tambah:";
            // 
            // NumJumlahRestock
            // 
            NumJumlahRestock.Enabled = false;
            NumJumlahRestock.Font = new System.Drawing.Font("Segoe UI", 10F);
            NumJumlahRestock.Location = new System.Drawing.Point(350, 28);
            NumJumlahRestock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            NumJumlahRestock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumJumlahRestock.Name = "NumJumlahRestock";
            NumJumlahRestock.Size = new System.Drawing.Size(80, 30);
            NumJumlahRestock.TabIndex = 4;
            NumJumlahRestock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LblDeskripsi
            // 
            LblDeskripsi.AutoSize = false;
            LblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            LblDeskripsi.ForeColor = System.Drawing.Color.DimGray;
            LblDeskripsi.Location = new System.Drawing.Point(450, 10);
            LblDeskripsi.Name = "LblDeskripsi";
            LblDeskripsi.BackColor = System.Drawing.Color.Transparent;
            LblDeskripsi.Size = new System.Drawing.Size(530, 64);
            LblDeskripsi.TabIndex = 5;
            LblDeskripsi.Text = "";
            // 
            // ProdukRestockControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(PnlKartu);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            Name = "ProdukRestockControl";
            Size = new System.Drawing.Size(1000, 84);
            PnlKartu.ResumeLayout(false);
            PnlKartu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumJumlahRestock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PnlKartu;
        private System.Windows.Forms.CheckBox ChkPilih;
        private System.Windows.Forms.Label LblNamaProduk;
        private System.Windows.Forms.Label LblStokSaatIni;
        private System.Windows.Forms.Label LblDeskripsi;
        private System.Windows.Forms.Label LblJumlah;
        private System.Windows.Forms.NumericUpDown NumJumlahRestock;
    }
}
