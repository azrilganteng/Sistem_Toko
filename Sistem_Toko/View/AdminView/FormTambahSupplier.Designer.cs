namespace Sistem_Toko.View.AdminView
{
    partial class FormTambahSupplier
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.LblJudul = new System.Windows.Forms.Label();
            this.LblNama = new System.Windows.Forms.Label();
            this.LblNoHp = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblAlamat = new System.Windows.Forms.Label();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.TxtNoHp = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAlamat = new System.Windows.Forms.TextBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblJudul
            // 
            this.LblJudul.AutoSize = true;
            this.LblJudul.BackColor = System.Drawing.Color.Transparent;
            this.LblJudul.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold);
            this.LblJudul.Location = new System.Drawing.Point(120, 20);
            this.LblJudul.Name = "LblJudul";
            this.LblJudul.Size = new System.Drawing.Size(211, 29);
            this.LblJudul.TabIndex = 0;
            this.LblJudul.Text = "Tambah Supplier";
            // 
            // LblNama
            // 
            this.LblNama.AutoSize = true;
            this.LblNama.BackColor = System.Drawing.Color.Transparent;
            this.LblNama.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.LblNama.Location = new System.Drawing.Point(40, 80);
            this.LblNama.Name = "LblNama";
            this.LblNama.Size = new System.Drawing.Size(130, 22);
            this.LblNama.TabIndex = 1;
            this.LblNama.Text = "Nama Supplier:";
            // 
            // LblNoHp
            // 
            this.LblNoHp.AutoSize = true;
            this.LblNoHp.BackColor = System.Drawing.Color.Transparent;
            this.LblNoHp.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.LblNoHp.Location = new System.Drawing.Point(40, 120);
            this.LblNoHp.Name = "LblNoHp";
            this.LblNoHp.Size = new System.Drawing.Size(69, 22);
            this.LblNoHp.TabIndex = 2;
            this.LblNoHp.Text = "No HP :";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.LblEmail.Location = new System.Drawing.Point(40, 160);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(61, 22);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email :";
            // 
            // LblAlamat
            // 
            this.LblAlamat.AutoSize = true;
            this.LblAlamat.BackColor = System.Drawing.Color.Transparent;
            this.LblAlamat.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.LblAlamat.Location = new System.Drawing.Point(40, 200);
            this.LblAlamat.Name = "LblAlamat";
            this.LblAlamat.Size = new System.Drawing.Size(73, 22);
            this.LblAlamat.TabIndex = 4;
            this.LblAlamat.Text = "Alamat :";
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(180, 75);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(220, 30);
            this.TxtNama.TabIndex = 5;
            // 
            // TxtNoHp
            // 
            this.TxtNoHp.Location = new System.Drawing.Point(180, 115);
            this.TxtNoHp.Name = "TxtNoHp";
            this.TxtNoHp.Size = new System.Drawing.Size(220, 30);
            this.TxtNoHp.TabIndex = 6;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(180, 155);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(220, 30);
            this.TxtEmail.TabIndex = 7;
            // 
            // TxtAlamat
            // 
            this.TxtAlamat.Location = new System.Drawing.Point(180, 195);
            this.TxtAlamat.Multiline = true;
            this.TxtAlamat.Name = "TxtAlamat";
            this.TxtAlamat.Size = new System.Drawing.Size(220, 60);
            this.TxtAlamat.TabIndex = 8;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSimpan.ForeColor = System.Drawing.Color.White;
            this.BtnSimpan.Location = new System.Drawing.Point(267, 275);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(133, 40);
            this.BtnSimpan.TabIndex = 9;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = false;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnKembali
            // 
            this.BtnKembali.BackColor = System.Drawing.Color.Tomato;
            this.BtnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKembali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnKembali.ForeColor = System.Drawing.Color.White;
            this.BtnKembali.Location = new System.Drawing.Point(12, 12);
            this.BtnKembali.Name = "BtnKembali";
            this.BtnKembali.Size = new System.Drawing.Size(40, 40);
            this.BtnKembali.TabIndex = 10;
            this.BtnKembali.Text = "X";
            this.BtnKembali.UseVisualStyleBackColor = false;
            this.BtnKembali.Click += new System.EventHandler(this.BtnKembali_Click);
            // 
            // FormTambahSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Sistem_Toko.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.BtnKembali);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TxtAlamat);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNoHp);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.LblAlamat);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblNoHp);
            this.Controls.Add(this.LblNama);
            this.Controls.Add(this.LblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormTambahSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Supplier Baru";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LblJudul;
        private System.Windows.Forms.Label LblNama;
        private System.Windows.Forms.Label LblNoHp;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblAlamat;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.TextBox TxtNoHp;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAlamat;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnKembali;
    }
}
