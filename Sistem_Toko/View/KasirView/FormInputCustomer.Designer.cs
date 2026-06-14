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
            LblNama = new Label();
            TxtNamaCustomer = new TextBox();
            BtnCari = new Button();
            LblInfoCustomer = new Label();
            LblNoHp = new Label();
            TxtNoHp = new TextBox();
            LblAlamat = new Label();
            TxtAlamat = new TextBox();
            BtnTambahBaru = new Button();
            BtnPilih = new Button();
            BtnBatal = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SeaGreen;
            panelHeader.Controls.Add(LblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 60);
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
            LblHeader.Text = "Input Customer";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Controls.Add(LblNama);
            panelContent.Controls.Add(TxtNamaCustomer);
            panelContent.Controls.Add(BtnCari);
            panelContent.Controls.Add(LblInfoCustomer);
            panelContent.Controls.Add(LblNoHp);
            panelContent.Controls.Add(TxtNoHp);
            panelContent.Controls.Add(LblAlamat);
            panelContent.Controls.Add(TxtAlamat);
            panelContent.Controls.Add(BtnTambahBaru);
            panelContent.Controls.Add(BtnPilih);
            panelContent.Controls.Add(BtnBatal);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 60);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(500, 380);
            panelContent.TabIndex = 1;
            // 
            // LblNama
            // 
            LblNama.AutoSize = true;
            LblNama.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblNama.Location = new Point(30, 25);
            LblNama.Name = "LblNama";
            LblNama.Size = new Size(130, 25);
            LblNama.TabIndex = 0;
            LblNama.Text = "Nama Customer:";
            // 
            // TxtNamaCustomer
            // 
            TxtNamaCustomer.Font = new Font("Segoe UI", 11F);
            TxtNamaCustomer.Location = new Point(30, 55);
            TxtNamaCustomer.Name = "TxtNamaCustomer";
            TxtNamaCustomer.Size = new Size(300, 32);
            TxtNamaCustomer.TabIndex = 1;
            // 
            // BtnCari
            // 
            BtnCari.BackColor = Color.SeaGreen;
            BtnCari.Cursor = Cursors.Hand;
            BtnCari.FlatAppearance.BorderSize = 0;
            BtnCari.FlatStyle = FlatStyle.Flat;
            BtnCari.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnCari.ForeColor = Color.White;
            BtnCari.Location = new Point(345, 53);
            BtnCari.Name = "BtnCari";
            BtnCari.Size = new Size(110, 36);
            BtnCari.TabIndex = 2;
            BtnCari.Text = "Cari";
            BtnCari.UseVisualStyleBackColor = false;
            BtnCari.Click += BtnCari_Click;
            // 
            // LblInfoCustomer
            // 
            LblInfoCustomer.Font = new Font("Segoe UI", 10F);
            LblInfoCustomer.Location = new Point(30, 100);
            LblInfoCustomer.Name = "LblInfoCustomer";
            LblInfoCustomer.Size = new Size(430, 60);
            LblInfoCustomer.TabIndex = 3;
            LblInfoCustomer.Text = "";
            LblInfoCustomer.Visible = false;
            // 
            // LblNoHp
            // 
            LblNoHp.AutoSize = true;
            LblNoHp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblNoHp.Location = new Point(30, 170);
            LblNoHp.Name = "LblNoHp";
            LblNoHp.Size = new Size(70, 25);
            LblNoHp.TabIndex = 4;
            LblNoHp.Text = "No. HP:";
            // 
            // TxtNoHp
            // 
            TxtNoHp.Font = new Font("Segoe UI", 11F);
            TxtNoHp.Location = new Point(30, 200);
            TxtNoHp.Name = "TxtNoHp";
            TxtNoHp.Size = new Size(300, 32);
            TxtNoHp.TabIndex = 5;
            // 
            // LblAlamat
            // 
            LblAlamat.AutoSize = true;
            LblAlamat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblAlamat.Location = new Point(30, 245);
            LblAlamat.Name = "LblAlamat";
            LblAlamat.Size = new Size(70, 25);
            LblAlamat.TabIndex = 6;
            LblAlamat.Text = "Alamat:";
            // 
            // TxtAlamat
            // 
            TxtAlamat.Font = new Font("Segoe UI", 11F);
            TxtAlamat.Location = new Point(30, 275);
            TxtAlamat.Multiline = true;
            TxtAlamat.Name = "TxtAlamat";
            TxtAlamat.Size = new Size(430, 50);
            TxtAlamat.TabIndex = 7;
            // 
            // BtnTambahBaru
            // 
            BtnTambahBaru.BackColor = Color.Teal;
            BtnTambahBaru.Cursor = Cursors.Hand;
            BtnTambahBaru.FlatAppearance.BorderSize = 0;
            BtnTambahBaru.FlatStyle = FlatStyle.Flat;
            BtnTambahBaru.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnTambahBaru.ForeColor = Color.White;
            BtnTambahBaru.Location = new Point(340, 340);
            BtnTambahBaru.Name = "BtnTambahBaru";
            BtnTambahBaru.Size = new Size(120, 40);
            BtnTambahBaru.TabIndex = 8;
            BtnTambahBaru.Text = "Tambah Baru";
            BtnTambahBaru.UseVisualStyleBackColor = false;
            BtnTambahBaru.Click += BtnTambahBaru_Click;
            // 
            // BtnPilih
            // 
            BtnPilih.BackColor = Color.SeaGreen;
            BtnPilih.Cursor = Cursors.Hand;
            BtnPilih.FlatAppearance.BorderSize = 0;
            BtnPilih.FlatStyle = FlatStyle.Flat;
            BtnPilih.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnPilih.ForeColor = Color.White;
            BtnPilih.Location = new Point(30, 340);
            BtnPilih.Name = "BtnPilih";
            BtnPilih.Size = new Size(120, 40);
            BtnPilih.TabIndex = 9;
            BtnPilih.Text = "Pilih Customer";
            BtnPilih.UseVisualStyleBackColor = false;
            BtnPilih.Click += BtnPilih_Click;
            // 
            // BtnBatal
            // 
            BtnBatal.BackColor = Color.Gray;
            BtnBatal.Cursor = Cursors.Hand;
            BtnBatal.FlatAppearance.BorderSize = 0;
            BtnBatal.FlatStyle = FlatStyle.Flat;
            BtnBatal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnBatal.ForeColor = Color.White;
            BtnBatal.Location = new Point(185, 340);
            BtnBatal.Name = "BtnBatal";
            BtnBatal.Size = new Size(100, 40);
            BtnBatal.TabIndex = 10;
            BtnBatal.Text = "Batal";
            BtnBatal.UseVisualStyleBackColor = false;
            BtnBatal.Click += BtnBatal_Click;
            // 
            // FormInputCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 440);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInputCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Input Customer - Toko Tani Samudra";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label LblHeader;
        private Panel panelContent;
        private Label LblNama;
        private TextBox TxtNamaCustomer;
        private Button BtnCari;
        private Label LblInfoCustomer;
        private Label LblNoHp;
        private TextBox TxtNoHp;
        private Label LblAlamat;
        private TextBox TxtAlamat;
        private Button BtnTambahBaru;
        private Button BtnPilih;
        private Button BtnBatal;
    }
}
