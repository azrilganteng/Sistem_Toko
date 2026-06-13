namespace Sistem_Toko.View.AdminView
{
    partial class DaftarKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaftarKaryawan));
            LblToko = new Label();
            Grid_Daftar_Karyawan = new DataGridView();
            Btn_Tambah = new Button();
            Btn_Hapus = new Button();
            Btn_Edit = new Button();
            Btn_Kembali = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid_Daftar_Karyawan).BeginInit();
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblToko.Location = new Point(51, 22);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(428, 100);
            LblToko.TabIndex = 1;
            LblToko.Text = "Toko Taniku";
            // 
            // Grid_Daftar_Karyawan
            // 
            Grid_Daftar_Karyawan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Grid_Daftar_Karyawan.BackgroundColor = Color.LightGray;
            Grid_Daftar_Karyawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Daftar_Karyawan.GridColor = Color.LightGray;
            Grid_Daftar_Karyawan.Location = new Point(51, 177);
            Grid_Daftar_Karyawan.Name = "Grid_Daftar_Karyawan";
            Grid_Daftar_Karyawan.RowHeadersWidth = 51;
            Grid_Daftar_Karyawan.Size = new Size(922, 379);
            Grid_Daftar_Karyawan.TabIndex = 9;
            Grid_Daftar_Karyawan.CellClick += Grid_Daftar_Karyawan_CellClick;
            // 
            // Btn_Tambah
            // 
            Btn_Tambah.BackColor = Color.SeaGreen;
            Btn_Tambah.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Tambah.Cursor = Cursors.Hand;
            Btn_Tambah.FlatStyle = FlatStyle.Flat;
            Btn_Tambah.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Tambah.ForeColor = Color.White;
            Btn_Tambah.Location = new Point(51, 130);
            Btn_Tambah.Name = "Btn_Tambah";
            Btn_Tambah.RightToLeft = RightToLeft.Yes;
            Btn_Tambah.Size = new Size(141, 41);
            Btn_Tambah.TabIndex = 11;
            Btn_Tambah.Text = "Tambah";
            Btn_Tambah.UseVisualStyleBackColor = false;
            Btn_Tambah.Click += Btn_Tambah_Click;
            // 
            // Btn_Hapus
            // 
            Btn_Hapus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Hapus.BackColor = Color.Crimson;
            Btn_Hapus.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Hapus.Cursor = Cursors.Hand;
            Btn_Hapus.FlatStyle = FlatStyle.Flat;
            Btn_Hapus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Hapus.ForeColor = Color.White;
            Btn_Hapus.Location = new Point(832, 130);
            Btn_Hapus.Name = "Btn_Hapus";
            Btn_Hapus.RightToLeft = RightToLeft.Yes;
            Btn_Hapus.Size = new Size(141, 41);
            Btn_Hapus.TabIndex = 12;
            Btn_Hapus.Text = "Hapus";
            Btn_Hapus.UseVisualStyleBackColor = false;
            Btn_Hapus.Click += Btn_Hapus_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.BackColor = Color.Gold;
            Btn_Edit.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Edit.Cursor = Cursors.Hand;
            Btn_Edit.FlatStyle = FlatStyle.Flat;
            Btn_Edit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Edit.ForeColor = Color.White;
            Btn_Edit.Location = new Point(218, 130);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.RightToLeft = RightToLeft.Yes;
            Btn_Edit.Size = new Size(141, 41);
            Btn_Edit.TabIndex = 13;
            Btn_Edit.Text = "Edit";
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Kembali
            // 
            Btn_Kembali.Anchor = AnchorStyles.None;
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
            // DaftarKaryawan
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1168, 568);
            Controls.Add(Btn_Edit);
            Controls.Add(Btn_Hapus);
            Controls.Add(Btn_Tambah);
            Controls.Add(Grid_Daftar_Karyawan);
            Controls.Add(LblToko);
            Controls.Add(Btn_Kembali);
            Font = new Font("Segoe UI", 10F);
            IsMdiContainer = true;
            Name = "DaftarKaryawan";
            Text = "DaftarKaryawan";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_Daftar_Karyawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblToko;
        private DataGridView Grid_Daftar_Karyawan;
        private Button Btn_Tambah;
        private Button Btn_Hapus;
        private Button Btn_Edit;
    
        private System.Windows.Forms.Button Btn_Kembali;
    }
}






