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
            LblToko = new System.Windows.Forms.Label();
            Btn_Kembali = new System.Windows.Forms.Button();
            LblSubjudul = new System.Windows.Forms.Label();
            LblInfo = new System.Windows.Forms.Label();
            PnlScroll = new System.Windows.Forms.Panel();
            FlowProduk = new System.Windows.Forms.FlowLayoutPanel();
            Btn_Simpan = new System.Windows.Forms.Button();
            PnlScroll.SuspendLayout();
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.Anchor = System.Windows.Forms.AnchorStyles.None;
            LblToko.AutoSize = true;
            LblToko.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Bold);
            LblToko.ForeColor = System.Drawing.Color.FromArgb(40, 100, 60);
            LblToko.Location = new System.Drawing.Point(53, 20);
            LblToko.Name = "LblToko";
            LblToko.TabIndex = 11;
            LblToko.Text = "Restock Produk";
            // 
            // Btn_Kembali
            // 
            Btn_Kembali.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_Kembali.BackColor = System.Drawing.Color.Transparent;
            Btn_Kembali.BackgroundImage = (System.Drawing.Image)resources.GetObject("Btn_Kembali.BackgroundImage");
            Btn_Kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Btn_Kembali.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            Btn_Kembali.ForeColor = System.Drawing.Color.White;
            Btn_Kembali.Location = new System.Drawing.Point(5, 12);
            Btn_Kembali.Name = "Btn_Kembali";
            Btn_Kembali.Size = new System.Drawing.Size(40, 40);
            Btn_Kembali.TabIndex = 99;
            Btn_Kembali.UseVisualStyleBackColor = false;
            Btn_Kembali.Click += Btn_Kembali_Click;
            // 
            // LblSubjudul
            // 
            LblSubjudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            LblSubjudul.AutoSize = true;
            LblSubjudul.Font = new System.Drawing.Font("Segoe UI", 10F);
            LblSubjudul.ForeColor = System.Drawing.Color.Gray;
            LblSubjudul.Location = new System.Drawing.Point(55, 85);
            LblSubjudul.Name = "LblSubjudul";
            LblSubjudul.TabIndex = 12;
            LblSubjudul.Text = "Centang produk yang ingin di-restock, lalu masukkan jumlah tambahan stok.";
            // 
            // LblInfo
            // 
            LblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            LblInfo.AutoSize = true;
            LblInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            LblInfo.ForeColor = System.Drawing.Color.Gray;
            LblInfo.Location = new System.Drawing.Point(55, 120);
            LblInfo.Name = "LblInfo";
            LblInfo.TabIndex = 13;
            LblInfo.Text = "Memuat produk...";
            LblInfo.Visible = false;
            // 
            // PnlScroll
            // 
            PnlScroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            PnlScroll.AutoScroll = true;
            PnlScroll.BackColor = System.Drawing.Color.WhiteSmoke;
            PnlScroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PnlScroll.Controls.Add(FlowProduk);
            PnlScroll.Location = new System.Drawing.Point(55, 115);
            PnlScroll.Name = "PnlScroll";
            PnlScroll.Size = new System.Drawing.Size(1060, 370);
            PnlScroll.TabIndex = 14;
            // 
            // FlowProduk
            // 
            FlowProduk.AutoSize = true;
            FlowProduk.Dock = System.Windows.Forms.DockStyle.Top;
            FlowProduk.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            FlowProduk.Location = new System.Drawing.Point(0, 0);
            FlowProduk.Name = "FlowProduk";
            FlowProduk.Padding = new System.Windows.Forms.Padding(4);
            FlowProduk.Size = new System.Drawing.Size(1058, 0);
            FlowProduk.TabIndex = 0;
            FlowProduk.WrapContents = false;
            // 
            // Btn_Simpan
            // 
            Btn_Simpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            Btn_Simpan.BackColor = System.Drawing.Color.SeaGreen;
            Btn_Simpan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            Btn_Simpan.ForeColor = System.Drawing.Color.White;
            Btn_Simpan.Location = new System.Drawing.Point(55, 500);
            Btn_Simpan.Name = "Btn_Simpan";
            Btn_Simpan.Size = new System.Drawing.Size(200, 44);
            Btn_Simpan.TabIndex = 15;
            Btn_Simpan.Text = "✔ Simpan Restock";
            Btn_Simpan.UseVisualStyleBackColor = false;
            Btn_Simpan.Click += Btn_Simpan_Click;
            // 
            // Restock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1168, 568);
            Controls.Add(Btn_Simpan);
            Controls.Add(PnlScroll);
            Controls.Add(LblInfo);
            Controls.Add(LblSubjudul);
            Controls.Add(LblToko);
            Controls.Add(Btn_Kembali);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            Name = "Restock";
            Text = "Restock Produk";
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
    }
}
