namespace Sistem_Toko.View.AdminView
{
    partial class StokGudang
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
            LblToko = new Label();
            Grid_Riwayat_Stok = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Grid_Riwayat_Stok).BeginInit();
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 45F);
            LblToko.Location = new Point(51, 42);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(465, 92);
            LblToko.TabIndex = 1;
            LblToko.Text = "Toko Taniku";
            // 
            // Grid_Riwayat_Stok
            // 
            Grid_Riwayat_Stok.BackgroundColor = Color.LightGray;
            Grid_Riwayat_Stok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Riwayat_Stok.GridColor = Color.LightGray;
            Grid_Riwayat_Stok.Location = new Point(51, 177);
            Grid_Riwayat_Stok.Name = "Grid_Riwayat_Stok";
            Grid_Riwayat_Stok.RowHeadersWidth = 51;
            Grid_Riwayat_Stok.Size = new Size(922, 379);
            Grid_Riwayat_Stok.TabIndex = 8;
            Grid_Riwayat_Stok.CellContentClick += Grid_Riwayat_Stok_CellContentClick;
            // 
            // RiwayatStok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1168, 568);
            Controls.Add(Grid_Riwayat_Stok);
            Controls.Add(LblToko);
            Name = "RiwayatStok";
            Text = "RiwayatStok";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Riwayat_Stok).EndInit();
            // INJECTED_MANUAL_UI
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblToko;
        private DataGridView Grid_Riwayat_Stok;
    }
}


