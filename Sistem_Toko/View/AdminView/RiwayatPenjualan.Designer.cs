namespace Sistem_Toko.View.AdminView
{
    partial class Riwayat_Stok
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
            Grid_RiwayatPenjualan = new DataGridView();
            LblToko = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_RiwayatPenjualan).BeginInit();
            SuspendLayout();
            // 
            // Grid_RiwayatPenjualan
            // 
            Grid_RiwayatPenjualan.BackgroundColor = Color.LightGray;
            Grid_RiwayatPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_RiwayatPenjualan.GridColor = Color.LightGray;
            Grid_RiwayatPenjualan.Location = new Point(52, 177);
            Grid_RiwayatPenjualan.Name = "Grid_RiwayatPenjualan";
            Grid_RiwayatPenjualan.RowHeadersWidth = 51;
            Grid_RiwayatPenjualan.Size = new Size(922, 379);
            Grid_RiwayatPenjualan.TabIndex = 11;
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 45F);
            LblToko.Location = new Point(52, 42);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(465, 92);
            LblToko.TabIndex = 9;
            LblToko.Text = "Toko Taniku";
            // 
            // Riwayat_Stok
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1168, 568);
            Controls.Add(Grid_RiwayatPenjualan);
            Controls.Add(LblToko);
            Font = new Font("Segoe UI", 10F);
            Name = "Riwayat_Stok";
            Text = "RiwayatPenjualan";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_RiwayatPenjualan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid_RiwayatPenjualan;
        private Label LblToko;
    }
}


