namespace Sistem_Toko.View.AdminView
{
    partial class EditKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditKaryawan));
            ComBox_Role2 = new ComboBox();
            ComBox_Role3 = new ComboBox();
            ComBox_Role1 = new ComboBox();
            TextBox_Email = new TextBox();
            TextBox_Password = new TextBox();
            TextBox_NamaLengkap = new TextBox();
            TextBox_NoHP = new TextBox();
            TextBox_Alamat = new TextBox();
            TextBox_Username = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Btn_Simpan = new Button();
            label10 = new Label();
            Btn_Kembali = new Button();
            SuspendLayout();
            // 
            // ComBox_Role2
            // 
            ComBox_Role2.FormattingEnabled = true;
            ComBox_Role2.Items.AddRange(new object[] { "Kasir", "Kurir", "Admin", "Tidak Ada" });
            ComBox_Role2.Location = new Point(165, 338);
            ComBox_Role2.Name = "ComBox_Role2";
            ComBox_Role2.Size = new Size(151, 31);
            ComBox_Role2.TabIndex = 36;
            // 
            // ComBox_Role3
            // 
            ComBox_Role3.FormattingEnabled = true;
            ComBox_Role3.Items.AddRange(new object[] { "Kasir", "Kurir", "Admin", "Tidak ada" });
            ComBox_Role3.Location = new Point(165, 374);
            ComBox_Role3.Name = "ComBox_Role3";
            ComBox_Role3.Size = new Size(151, 31);
            ComBox_Role3.TabIndex = 35;
            // 
            // ComBox_Role1
            // 
            ComBox_Role1.FormattingEnabled = true;
            ComBox_Role1.Items.AddRange(new object[] { "Kasir", "Kurir", "Admin" });
            ComBox_Role1.Location = new Point(165, 297);
            ComBox_Role1.Name = "ComBox_Role1";
            ComBox_Role1.Size = new Size(151, 31);
            ComBox_Role1.TabIndex = 34;
            // 
            // TextBox_Email
            // 
            TextBox_Email.Location = new Point(165, 257);
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.Size = new Size(343, 30);
            TextBox_Email.TabIndex = 33;
            // 
            // TextBox_Password
            // 
            TextBox_Password.Location = new Point(165, 91);
            TextBox_Password.Name = "TextBox_Password";
            TextBox_Password.Size = new Size(173, 30);
            TextBox_Password.TabIndex = 32;
            // 
            // TextBox_NamaLengkap
            // 
            TextBox_NamaLengkap.Location = new Point(165, 131);
            TextBox_NamaLengkap.Name = "TextBox_NamaLengkap";
            TextBox_NamaLengkap.Size = new Size(343, 30);
            TextBox_NamaLengkap.TabIndex = 31;
            // 
            // TextBox_NoHP
            // 
            TextBox_NoHP.Location = new Point(165, 171);
            TextBox_NoHP.Name = "TextBox_NoHP";
            TextBox_NoHP.Size = new Size(190, 30);
            TextBox_NoHP.TabIndex = 30;
            // 
            // TextBox_Alamat
            // 
            TextBox_Alamat.Location = new Point(165, 214);
            TextBox_Alamat.Name = "TextBox_Alamat";
            TextBox_Alamat.Size = new Size(343, 30);
            TextBox_Alamat.TabIndex = 29;
            // 
            // TextBox_Username
            // 
            TextBox_Username.Location = new Point(165, 52);
            TextBox_Username.Name = "TextBox_Username";
            TextBox_Username.Size = new Size(173, 30);
            TextBox_Username.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new Font("Book Antiqua", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(25, 344);
            label9.Name = "label9";
            label9.Size = new Size(51, 22);
            label9.TabIndex = 27;
            label9.Text = "Role :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new Font("Book Antiqua", 10F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(25, 380);
            label8.Name = "label8";
            label8.Size = new Size(51, 22);
            label8.TabIndex = 26;
            label8.Text = "Role :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new Font("Book Antiqua", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 303);
            label7.Name = "label7";
            label7.Size = new Size(51, 22);
            label7.TabIndex = 25;
            label7.Text = "Role :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new Font("Book Antiqua", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(25, 176);
            label6.Name = "label6";
            label6.Size = new Size(69, 22);
            label6.TabIndex = 24;
            label6.Text = "No HP :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new Font("Book Antiqua", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 219);
            label5.Name = "label5";
            label5.Size = new Size(75, 22);
            label5.TabIndex = 23;
            label5.Text = "Alamat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new Font("Book Antiqua", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 262);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 22;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new Font("Book Antiqua", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 96);
            label3.Name = "label3";
            label3.Size = new Size(91, 22);
            label3.TabIndex = 21;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new Font("Book Antiqua", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 136);
            label2.Name = "label2";
            label2.Size = new Size(134, 22);
            label2.TabIndex = 20;
            label2.Text = "Nama Lengkap :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new Font("Book Antiqua", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 19;
            label1.Text = "Username :";
            // 
            // Btn_Simpan
            // 
            Btn_Simpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Simpan.BackColor = Color.Gold;
            Btn_Simpan.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Simpan.Cursor = Cursors.Hand;
            Btn_Simpan.FlatStyle = FlatStyle.Flat;
            Btn_Simpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Simpan.ForeColor = Color.White;
            Btn_Simpan.Location = new Point(617, 380);
            Btn_Simpan.Name = "Btn_Simpan";
            Btn_Simpan.Size = new Size(133, 34);
            Btn_Simpan.TabIndex = 20;
            Btn_Simpan.Text = "Simpan";
            Btn_Simpan.UseVisualStyleBackColor = false;
            Btn_Simpan.Click += Btn_Simpan_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new Font("Book Antiqua", 15F);
            label10.Location = new Point(270, 9);
            label10.Name = "label10";
            label10.Size = new Size(251, 31);
            label10.TabIndex = 38;
            label10.Text = "Edit Akun Karyawan";
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
            // EditKaryawan
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(788, 426);
            Controls.Add(label10);
            Controls.Add(Btn_Simpan);
            Controls.Add(ComBox_Role2);
            Controls.Add(ComBox_Role3);
            Controls.Add(ComBox_Role1);
            Controls.Add(TextBox_Email);
            Controls.Add(TextBox_Password);
            Controls.Add(TextBox_NamaLengkap);
            Controls.Add(TextBox_NoHP);
            Controls.Add(TextBox_Alamat);
            Controls.Add(TextBox_Username);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Kembali);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F);
            Name = "EditKaryawan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditKaryawan";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComBox_Role2;
        private ComboBox ComBox_Role3;
        private ComboBox ComBox_Role1;
        private TextBox TextBox_Email;
        private TextBox TextBox_Password;
        private TextBox TextBox_NamaLengkap;
        private TextBox TextBox_NoHP;
        private TextBox TextBox_Alamat;
        private TextBox TextBox_Username;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Btn_Simpan;
        private Label label10;
    
        private System.Windows.Forms.Button Btn_Kembali;
    }
}







