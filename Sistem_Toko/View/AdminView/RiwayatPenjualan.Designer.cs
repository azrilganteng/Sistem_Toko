namespace Sistem_Toko.View.AdminView
{
    partial class Riwayat_Stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Riwayat_Stok));
            Grid_RiwayatPenjualan = new DataGridView();
            LblToko = new Label();
            Btn_Kembali = new Button();
            CmbBulan = new ComboBox();
            NumTahun = new NumericUpDown();
            Btn_Filter = new Button();
            LblBulan = new Label();
            LblTahun = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_RiwayatPenjualan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumTahun).BeginInit();
            SuspendLayout();
            // 
            // Grid_RiwayatPenjualan
            // 
            Grid_RiwayatPenjualan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Grid_RiwayatPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_RiwayatPenjualan.Location = new Point(52, 194);
            Grid_RiwayatPenjualan.Name = "Grid_RiwayatPenjualan";
            Grid_RiwayatPenjualan.RowHeadersWidth = 51;
            Grid_RiwayatPenjualan.Size = new Size(952, 321);
            Grid_RiwayatPenjualan.TabIndex = 9;
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.BackColor = System.Drawing.Color.Transparent;
            LblToko.Font = new Font("Book Antiqua", 24F, FontStyle.Bold);
            LblToko.Location = new Point(344, 40);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(364, 49);
            LblToko.TabIndex = 8;
            LblToko.Text = "Riwayat Penjualan";
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
            // CmbBulan
            // 
            CmbBulan.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBulan.Font = new Font("Segoe UI", 10F);
            CmbBulan.Location = new Point(110, 141);
            CmbBulan.Name = "CmbBulan";
            CmbBulan.Size = new Size(140, 31);
            CmbBulan.TabIndex = 21;
            // 
            // NumTahun
            // 
            NumTahun.Font = new Font("Segoe UI", 10F);
            NumTahun.Location = new Point(325, 141);
            NumTahun.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            NumTahun.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            NumTahun.Name = "NumTahun";
            NumTahun.Size = new Size(100, 30);
            NumTahun.TabIndex = 23;
            NumTahun.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // Btn_Filter
            // 
            Btn_Filter.BackColor = Color.SeaGreen;
            Btn_Filter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Filter.ForeColor = Color.White;
            Btn_Filter.Location = new Point(441, 140);
            Btn_Filter.Name = "Btn_Filter";
            Btn_Filter.Size = new Size(100, 32);
            Btn_Filter.TabIndex = 24;
            Btn_Filter.Text = "Filter";
            Btn_Filter.UseVisualStyleBackColor = false;
            Btn_Filter.Click += Btn_Filter_Click;
            // 
            // LblBulan
            // 
            LblBulan.AutoSize = true;
            LblBulan.BackColor = System.Drawing.Color.Transparent;
            LblBulan.Font = new Font("Segoe UI", 10F);
            LblBulan.Location = new Point(52, 144);
            LblBulan.Name = "LblBulan";
            LblBulan.Size = new Size(57, 23);
            LblBulan.TabIndex = 20;
            LblBulan.Text = "Bulan:";
            // 
            // LblTahun
            // 
            LblTahun.AutoSize = true;
            LblTahun.BackColor = System.Drawing.Color.Transparent;
            LblTahun.Font = new Font("Segoe UI", 10F);
            LblTahun.Location = new Point(268, 144);
            LblTahun.Name = "LblTahun";
            LblTahun.Size = new Size(60, 23);
            LblTahun.TabIndex = 22;
            LblTahun.Text = "Tahun:";
            // 
            // Riwayat_Stok
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 560);
            Controls.Add(Grid_RiwayatPenjualan);
            Controls.Add(LblToko);
            Controls.Add(LblBulan);
            Controls.Add(CmbBulan);
            Controls.Add(LblTahun);
            Controls.Add(NumTahun);
            Controls.Add(Btn_Filter);
            Controls.Add(Btn_Kembali);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F);
            Name = "Riwayat_Stok";
            Text = "Riwayat Penjualan";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_RiwayatPenjualan).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumTahun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_RiwayatPenjualan;
        private System.Windows.Forms.Label LblToko;
        private System.Windows.Forms.Button Btn_Kembali;
        private System.Windows.Forms.ComboBox CmbBulan;
        private System.Windows.Forms.NumericUpDown NumTahun;
        private System.Windows.Forms.Button Btn_Filter;
        private System.Windows.Forms.Label LblBulan;
        private System.Windows.Forms.Label LblTahun;
    }
}
