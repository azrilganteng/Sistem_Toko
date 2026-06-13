namespace Sistem_Toko.View.KasirView
{
    partial class FormPilihKurir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPilihKurir));
            panel1 = new Panel();
            NamaToko = new Label();
            LblToko = new Label();
            CboKurir = new ComboBox();
            TxtAlamat = new TextBox();
            Kirmkan = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            BackBtn = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(NamaToko);
            panel1.Controls.Add(LblToko);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 125);
            panel1.TabIndex = 0;
            // 
            // NamaToko
            // 
            NamaToko.AutoSize = true;
            NamaToko.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaToko.Location = new Point(66, 9);
            NamaToko.Name = "NamaToko";
            NamaToko.Size = new Size(353, 73);
            NamaToko.TabIndex = 1;
            NamaToko.Text = "Nama Toko";
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Location = new Point(131, 29);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(0, 20);
            LblToko.TabIndex = 0;
            // 
            // CboKurir
            // 
            CboKurir.FormattingEnabled = true;
            CboKurir.Location = new Point(28, 67);
            CboKurir.Name = "CboKurir";
            CboKurir.Size = new Size(810, 28);
            CboKurir.TabIndex = 1;
            // 
            // TxtAlamat
            // 
            TxtAlamat.Location = new Point(28, 184);
            TxtAlamat.Name = "TxtAlamat";
            TxtAlamat.Size = new Size(599, 27);
            TxtAlamat.TabIndex = 2;
            // 
            // Kirmkan
            // 
            Kirmkan.Location = new Point(874, 488);
            Kirmkan.Name = "Kirmkan";
            Kirmkan.Size = new Size(134, 51);
            Kirmkan.TabIndex = 3;
            Kirmkan.Text = "Konfirmasi";
            Kirmkan.UseVisualStyleBackColor = true;
            Kirmkan.Click += Kirmkan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CboKurir);
            groupBox1.Controls.Add(TxtAlamat);
            groupBox1.Location = new Point(94, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(876, 272);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(243, 24);
            label1.TabIndex = 3;
            label1.Text = "Pilih Kurir Untuk mengirim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 146);
            label2.Name = "label2";
            label2.Size = new Size(179, 24);
            label2.TabIndex = 4;
            label2.Text = "Alamat Pengiriman";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundImage = (Image)resources.GetObject("BackBtn.BackgroundImage");
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.Location = new Point(21, 29);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(39, 29);
            BackBtn.TabIndex = 6;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // FormPilihKurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            Controls.Add(groupBox1);
            Controls.Add(Kirmkan);
            Controls.Add(panel1);
            Name = "FormPilihKurir";
            Text = "PilihKurir";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox CboKurir;
        private TextBox TxtAlamat;
        private Button Kirmkan;
        private Label LblToko;
        private Label NamaToko;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button BackBtn;
    }
}