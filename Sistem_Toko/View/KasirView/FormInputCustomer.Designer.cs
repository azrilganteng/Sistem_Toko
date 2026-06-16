namespace Sistem_Toko.View.KasirView
{
    partial class FormInputCustomer
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
            panelHeader = new Panel();
            LblHeader = new Label();
            panelContent = new Panel();
            TxtCari = new TextBox();
            LblCari = new Label();
            GridCustomer = new DataGridView();
            PanelTambah = new Panel();
            LblNama = new Label();
            TxtNamaCustomer = new TextBox();
            LblNoHp = new Label();
            TxtNoHp = new TextBox();
            LblAlamat = new Label();
            TxtAlamat = new TextBox();
            BtnSimpanBaru = new Button();
            BtnBatalTambah = new Button();
            BtnPilih = new Button();
            BtnTambahBaru = new Button();
            BtnBatal = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridCustomer).BeginInit();
            PanelTambah.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SeaGreen;
            panelHeader.Controls.Add(LblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 60);
            panelHeader.TabIndex = 0;
            // 
            // LblHeader
            // 
            LblHeader.AutoSize = true;
            LblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LblHeader.ForeColor = Color.White;
            LblHeader.Location = new Point(20, 14);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(200, 37);
            LblHeader.TabIndex = 0;
            LblHeader.Text = "Pilih Customer";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Controls.Add(LblCari);
            panelContent.Controls.Add(TxtCari);
            panelContent.Controls.Add(GridCustomer);
            panelContent.Controls.Add(PanelTambah);
            panelContent.Controls.Add(BtnPilih);
            panelContent.Controls.Add(BtnTambahBaru);
            panelContent.Controls.Add(BtnBatal);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 60);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(600, 500);
            panelContent.TabIndex = 1;
            // 
            // LblCari
            // 
            LblCari.AutoSize = true;
            LblCari.Font = new Font("Segoe UI", 10F);
            LblCari.ForeColor = Color.DimGray;
            LblCari.Location = new Point(30, 18);
            LblCari.Name = "LblCari";
            LblCari.Size = new Size(110, 23);
            LblCari.TabIndex = 0;
            LblCari.Text = "Cari Customer:";
            // 
            // TxtCari
            // 
            TxtCari.Font = new Font("Segoe UI", 11F);
            TxtCari.Location = new Point(30, 45);
            TxtCari.Name = "TxtCari";
            TxtCari.PlaceholderText = "Ketik nama untuk filter...";
            TxtCari.Size = new Size(540, 32);
            TxtCari.TabIndex = 1;
            TxtCari.TextChanged += TxtCari_TextChanged;
            // 
            // GridCustomer
            // 
            GridCustomer.AllowUserToAddRows = false;
            GridCustomer.AllowUserToDeleteRows = false;
            GridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridCustomer.BackgroundColor = Color.White;
            GridCustomer.BorderStyle = BorderStyle.None;
            GridCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCustomer.Location = new Point(30, 90);
            GridCustomer.MultiSelect = false;
            GridCustomer.Name = "GridCustomer";
            GridCustomer.ReadOnly = true;
            GridCustomer.RowHeadersWidth = 51;
            GridCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridCustomer.Size = new Size(540, 240);
            GridCustomer.TabIndex = 2;
            GridCustomer.CellClick += GridCustomer_CellClick;
            // 
            // PanelTambah
            // 
            PanelTambah.BackColor = Color.White;
            PanelTambah.BorderStyle = BorderStyle.FixedSingle;
            PanelTambah.Controls.Add(LblNama);
            PanelTambah.Controls.Add(TxtNamaCustomer);
            PanelTambah.Controls.Add(LblNoHp);
            PanelTambah.Controls.Add(TxtNoHp);
            PanelTambah.Controls.Add(LblAlamat);
            PanelTambah.Controls.Add(TxtAlamat);
            PanelTambah.Controls.Add(BtnSimpanBaru);
            PanelTambah.Controls.Add(BtnBatalTambah);
            PanelTambah.Location = new Point(30, 90);
            PanelTambah.Name = "PanelTambah";
            PanelTambah.Padding = new Padding(15);
            PanelTambah.Size = new Size(540, 240);
            PanelTambah.TabIndex = 3;
            PanelTambah.Visible = false;
            // 
            // LblNama
            // 
            LblNama.AutoSize = true;
            LblNama.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblNama.Location = new Point(20, 15);
            LblNama.Name = "LblNama";
            LblNama.Size = new Size(120, 23);
            LblNama.TabIndex = 0;
            LblNama.Text = "Nama Customer:";
            // 
            // TxtNamaCustomer
            // 
            TxtNamaCustomer.Font = new Font("Segoe UI", 10F);
            TxtNamaCustomer.Location = new Point(20, 42);
            TxtNamaCustomer.Name = "TxtNamaCustomer";
            TxtNamaCustomer.Size = new Size(490, 30);
            TxtNamaCustomer.TabIndex = 1;
            // 
            // LblNoHp
            // 
            LblNoHp.AutoSize = true;
            LblNoHp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblNoHp.Location = new Point(20, 78);
            LblNoHp.Name = "LblNoHp";
            LblNoHp.Size = new Size(65, 23);
            LblNoHp.TabIndex = 2;
            LblNoHp.Text = "No. HP:";
            // 
            // TxtNoHp
            // 
            TxtNoHp.Font = new Font("Segoe UI", 10F);
            TxtNoHp.Location = new Point(20, 105);
            TxtNoHp.Name = "TxtNoHp";
            TxtNoHp.Size = new Size(490, 30);
            TxtNoHp.TabIndex = 3;
            // 
            // LblAlamat
            // 
            LblAlamat.AutoSize = true;
            LblAlamat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblAlamat.Location = new Point(20, 140);
            LblAlamat.Name = "LblAlamat";
            LblAlamat.Size = new Size(65, 23);
            LblAlamat.TabIndex = 4;
            LblAlamat.Text = "Alamat:";
            // 
            // TxtAlamat
            // 
            TxtAlamat.Font = new Font("Segoe UI", 10F);
            TxtAlamat.Location = new Point(20, 167);
            TxtAlamat.Name = "TxtAlamat";
            TxtAlamat.Size = new Size(350, 30);
            TxtAlamat.TabIndex = 5;
            // 
            // BtnSimpanBaru
            // 
            BtnSimpanBaru.BackColor = Color.SeaGreen;
            BtnSimpanBaru.Cursor = Cursors.Hand;
            BtnSimpanBaru.FlatAppearance.BorderSize = 0;
            BtnSimpanBaru.FlatStyle = FlatStyle.Flat;
            BtnSimpanBaru.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnSimpanBaru.ForeColor = Color.White;
            BtnSimpanBaru.Location = new Point(390, 165);
            BtnSimpanBaru.Name = "BtnSimpanBaru";
            BtnSimpanBaru.Size = new Size(60, 35);
            BtnSimpanBaru.TabIndex = 6;
            BtnSimpanBaru.Text = "Simpan";
            BtnSimpanBaru.UseVisualStyleBackColor = false;
            BtnSimpanBaru.Click += BtnSimpanBaru_Click;
            // 
            // BtnBatalTambah
            // 
            BtnBatalTambah.BackColor = Color.Gray;
            BtnBatalTambah.Cursor = Cursors.Hand;
            BtnBatalTambah.FlatAppearance.BorderSize = 0;
            BtnBatalTambah.FlatStyle = FlatStyle.Flat;
            BtnBatalTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnBatalTambah.ForeColor = Color.White;
            BtnBatalTambah.Location = new Point(460, 165);
            BtnBatalTambah.Name = "BtnBatalTambah";
            BtnBatalTambah.Size = new Size(55, 35);
            BtnBatalTambah.TabIndex = 7;
            BtnBatalTambah.Text = "Batal";
            BtnBatalTambah.UseVisualStyleBackColor = false;
            BtnBatalTambah.Click += BtnBatalTambah_Click;
            // 
            // BtnPilih
            // 
            BtnPilih.BackColor = Color.SeaGreen;
            BtnPilih.Cursor = Cursors.Hand;
            BtnPilih.FlatAppearance.BorderSize = 0;
            BtnPilih.FlatStyle = FlatStyle.Flat;
            BtnPilih.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnPilih.ForeColor = Color.White;
            BtnPilih.Location = new Point(30, 345);
            BtnPilih.Name = "BtnPilih";
            BtnPilih.Size = new Size(120, 45);
            BtnPilih.TabIndex = 4;
            BtnPilih.Text = "Pilih";
            BtnPilih.UseVisualStyleBackColor = false;
            BtnPilih.Click += BtnPilih_Click;
            // 
            // BtnTambahBaru
            // 
            BtnTambahBaru.BackColor = Color.Teal;
            BtnTambahBaru.Cursor = Cursors.Hand;
            BtnTambahBaru.FlatAppearance.BorderSize = 0;
            BtnTambahBaru.FlatStyle = FlatStyle.Flat;
            BtnTambahBaru.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnTambahBaru.ForeColor = Color.White;
            BtnTambahBaru.Location = new Point(160, 345);
            BtnTambahBaru.Name = "BtnTambahBaru";
            BtnTambahBaru.Size = new Size(140, 45);
            BtnTambahBaru.TabIndex = 5;
            BtnTambahBaru.Text = "+ Tambah Baru";
            BtnTambahBaru.UseVisualStyleBackColor = false;
            BtnTambahBaru.Click += BtnTambahBaru_Click;
            // 
            // BtnBatal
            // 
            BtnBatal.BackColor = Color.Gray;
            BtnBatal.Cursor = Cursors.Hand;
            BtnBatal.FlatAppearance.BorderSize = 0;
            BtnBatal.FlatStyle = FlatStyle.Flat;
            BtnBatal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnBatal.ForeColor = Color.White;
            BtnBatal.Location = new Point(470, 345);
            BtnBatal.Name = "BtnBatal";
            BtnBatal.Size = new Size(100, 45);
            BtnBatal.TabIndex = 6;
            BtnBatal.Text = "Batal";
            BtnBatal.UseVisualStyleBackColor = false;
            BtnBatal.Click += BtnBatal_Click;
            // 
            // FormInputCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(600, 560);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = false;
            Name = "FormInputCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pilih Customer - Toko Tani Samudra";
            Load += FormInputCustomer_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridCustomer).EndInit();
            PanelTambah.ResumeLayout(false);
            PanelTambah.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label LblHeader;
        private Panel panelContent;
        private Label LblCari;
        private TextBox TxtCari;
        private DataGridView GridCustomer;
        private Panel PanelTambah;
        private Label LblNama;
        private TextBox TxtNamaCustomer;
        private Label LblNoHp;
        private TextBox TxtNoHp;
        private Label LblAlamat;
        private TextBox TxtAlamat;
        private Button BtnSimpanBaru;
        private Button BtnBatalTambah;
        private Button BtnPilih;
        private Button BtnTambahBaru;
        private Button BtnBatal;
    }
}
