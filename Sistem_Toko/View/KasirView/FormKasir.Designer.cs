namespace Sistem_Toko
{
    partial class FormKasir
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKasir));
            LblToko = new Label();
            LblKasir = new Label();
            ListKeranjangBtn = new Button();
            StatusKirimBtn = new Button();
            panel1 = new Panel();
            SemuaBtn = new Button();
            Profil = new PictureBox();
            ObatBtn = new Button();
            BibitBtn = new Button();
            PupukBtn = new Button();
            panel2 = new Panel();
            FlpProduk = new FlowLayoutPanel();
            imageList1 = new ImageList(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            profilToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Profil).BeginInit();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblToko.ForeColor = Color.White;
            LblToko.Location = new Point(20, 10);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(306, 56);
            LblToko.TabIndex = 0;
            LblToko.Text = "Toko Taniku";
            // 
            // LblKasir
            // 
            LblKasir.AutoSize = true;
            LblKasir.Font = new Font("Segoe UI", 12F);
            LblKasir.ForeColor = Color.WhiteSmoke;
            LblKasir.Location = new Point(24, 68);
            LblKasir.Name = "LblKasir";
            LblKasir.Size = new Size(202, 28);
            LblKasir.TabIndex = 1;
            LblKasir.Text = "Selamat Datang Kasir:";
            // 
            // ListKeranjangBtn
            // 
            ListKeranjangBtn.BackColor = Color.SeaGreen;
            ListKeranjangBtn.Cursor = Cursors.Hand;
            ListKeranjangBtn.FlatAppearance.BorderSize = 0;
            ListKeranjangBtn.FlatStyle = FlatStyle.Flat;
            ListKeranjangBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ListKeranjangBtn.ForeColor = Color.White;
            ListKeranjangBtn.Location = new Point(15, 20);
            ListKeranjangBtn.Name = "ListKeranjangBtn";
            ListKeranjangBtn.Size = new Size(220, 55);
            ListKeranjangBtn.TabIndex = 2;
            ListKeranjangBtn.Text = "Keranjang";
            ListKeranjangBtn.UseVisualStyleBackColor = false;
            ListKeranjangBtn.Click += ListKeranjangBtn_Click;
            // 
            // StatusKirimBtn
            // 
            StatusKirimBtn.BackColor = Color.SeaGreen;
            StatusKirimBtn.Cursor = Cursors.Hand;
            StatusKirimBtn.FlatAppearance.BorderSize = 0;
            StatusKirimBtn.FlatStyle = FlatStyle.Flat;
            StatusKirimBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            StatusKirimBtn.ForeColor = Color.White;
            StatusKirimBtn.Location = new Point(15, 90);
            StatusKirimBtn.Name = "StatusKirimBtn";
            StatusKirimBtn.Size = new Size(220, 55);
            StatusKirimBtn.TabIndex = 3;
            StatusKirimBtn.Text = "Status Pengiriman";
            StatusKirimBtn.UseVisualStyleBackColor = false;
            StatusKirimBtn.Click += StatusKirimBtn_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(SemuaBtn);
            panel1.Controls.Add(Profil);
            panel1.Controls.Add(ObatBtn);
            panel1.Controls.Add(BibitBtn);
            panel1.Controls.Add(PupukBtn);
            panel1.Controls.Add(LblToko);
            panel1.Controls.Add(LblKasir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 100);
            panel1.TabIndex = 4;
            // 
            // SemuaBtn
            // 
            SemuaBtn.BackColor = Color.White;
            SemuaBtn.Cursor = Cursors.Hand;
            SemuaBtn.FlatStyle = FlatStyle.Flat;
            SemuaBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SemuaBtn.ForeColor = Color.SeaGreen;
            SemuaBtn.Location = new Point(530, 35);
            SemuaBtn.Name = "SemuaBtn";
            SemuaBtn.Size = new Size(95, 40);
            SemuaBtn.TabIndex = 5;
            SemuaBtn.Text = "Semua";
            SemuaBtn.UseVisualStyleBackColor = false;
            SemuaBtn.Click += SemuaBtn_Click;
            // 
            // Profil
            // 
            Profil.BackgroundImage = (Image)resources.GetObject("Profil.BackgroundImage");
            Profil.BackgroundImageLayout = ImageLayout.Stretch;
            Profil.Location = new Point(989, 0);
            Profil.Name = "Profil";
            Profil.Size = new Size(75, 75);
            Profil.TabIndex = 5;
            Profil.TabStop = false;
            Profil.Click += Profil_Click;
            // 
            // ObatBtn
            // 
            ObatBtn.BackColor = Color.White;
            ObatBtn.Cursor = Cursors.Hand;
            ObatBtn.FlatStyle = FlatStyle.Flat;
            ObatBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ObatBtn.ForeColor = Color.SeaGreen;
            ObatBtn.Location = new Point(870, 35);
            ObatBtn.Name = "ObatBtn";
            ObatBtn.Size = new Size(95, 40);
            ObatBtn.TabIndex = 4;
            ObatBtn.Text = "Obat";
            ObatBtn.UseVisualStyleBackColor = false;
            ObatBtn.Click += ObatBtn_Click;
            // 
            // BibitBtn
            // 
            BibitBtn.BackColor = Color.White;
            BibitBtn.Cursor = Cursors.Hand;
            BibitBtn.FlatStyle = FlatStyle.Flat;
            BibitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BibitBtn.ForeColor = Color.SeaGreen;
            BibitBtn.Location = new Point(755, 35);
            BibitBtn.Name = "BibitBtn";
            BibitBtn.Size = new Size(95, 40);
            BibitBtn.TabIndex = 3;
            BibitBtn.Text = "Bibit";
            BibitBtn.UseVisualStyleBackColor = false;
            BibitBtn.Click += BibitBtn_Click;
            // 
            // PupukBtn
            // 
            PupukBtn.BackColor = Color.White;
            PupukBtn.Cursor = Cursors.Hand;
            PupukBtn.FlatStyle = FlatStyle.Flat;
            PupukBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PupukBtn.ForeColor = Color.SeaGreen;
            PupukBtn.Location = new Point(640, 35);
            PupukBtn.Name = "PupukBtn";
            PupukBtn.Size = new Size(95, 40);
            PupukBtn.TabIndex = 2;
            PupukBtn.Text = "Pupuk";
            PupukBtn.UseVisualStyleBackColor = false;
            PupukBtn.Click += PupukBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 240, 240);
            panel2.Controls.Add(ListKeranjangBtn);
            panel2.Controls.Add(StatusKirimBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(250, 471);
            panel2.TabIndex = 5;
            // 
            // FlpProduk
            // 
            FlpProduk.AutoScroll = true;
            FlpProduk.BackColor = Color.WhiteSmoke;
            FlpProduk.Dock = DockStyle.Fill;
            FlpProduk.Location = new Point(250, 100);
            FlpProduk.Name = "FlpProduk";
            FlpProduk.Padding = new Padding(10);
            FlpProduk.Size = new Size(817, 471);
            FlpProduk.TabIndex = 6;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { profilToolStripMenuItem, logoutToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(210, 24);
            profilToolStripMenuItem.Text = "Profil";
            profilToolStripMenuItem.Click += profilToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(210, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 571);
            Controls.Add(FlpProduk);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "FormKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kasir - Toko Tani Samudra";
            FormClosed += FormKasir_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Profil).EndInit();
            panel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LblToko;
        private Label LblKasir;
        private Button ListKeranjangBtn;
        private Button StatusKirimBtn;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel FlpProduk;
        private ImageList imageList1;
        private Button ObatBtn;
        private Button BibitBtn;
        private Button PupukBtn;
        private Button SemuaBtn;
        private PictureBox Profil;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}
