namespace Sistem_Toko
{
    partial class FormKasir
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            LblToko = new Label();
            LblKasir = new Label();
            Btn_Profil = new Button();
            SemuaBtn = new Button();
            PupukBtn = new Button();
            BibitBtn = new Button();
            ObatBtn = new Button();
            panelSidebar = new Panel();
            ListKeranjangBtn = new Button();
            StatusKirimBtn = new Button();
            FlpProduk = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SeaGreen;
            panelHeader.Controls.Add(Btn_Profil);
            panelHeader.Controls.Add(SemuaBtn);
            panelHeader.Controls.Add(ObatBtn);
            panelHeader.Controls.Add(BibitBtn);
            panelHeader.Controls.Add(PupukBtn);
            panelHeader.Controls.Add(LblToko);
            panelHeader.Controls.Add(LblKasir);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1168, 140);
            panelHeader.TabIndex = 0;
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.BackColor = System.Drawing.Color.Transparent;
            LblToko.Font = new Font("Book Antiqua", 36F, FontStyle.Bold);
            LblToko.ForeColor = Color.White;
            LblToko.Location = new Point(41, 9);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(490, 73);
            LblToko.TabIndex = 0;
            LblToko.Text = "Toko Taniku";
            // 
            // LblKasir
            // 
            LblKasir.AutoSize = true;
            LblKasir.BackColor = System.Drawing.Color.Transparent;
            LblKasir.Font = new Font("Book Antiqua", 14F);
            LblKasir.ForeColor = Color.White;
            LblKasir.Location = new Point(48, 85);
            LblKasir.Name = "LblKasir";
            LblKasir.Size = new Size(157, 29);
            LblKasir.TabIndex = 1;
            LblKasir.Text = "User Notif";
            // 
            // Btn_Profil
            // 
            Btn_Profil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Profil.BackColor = Color.White;
            Btn_Profil.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Profil.Cursor = Cursors.Hand;
            Btn_Profil.FlatStyle = FlatStyle.Flat;
            Btn_Profil.FlatAppearance.BorderColor = Color.SeaGreen;
            Btn_Profil.FlatAppearance.BorderSize = 2;
            Btn_Profil.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            Btn_Profil.ForeColor = Color.SeaGreen;
            Btn_Profil.Location = new Point(1080, 15);
            Btn_Profil.Name = "Btn_Profil";
            Btn_Profil.Size = new Size(70, 70);
            Btn_Profil.TabIndex = 6;
            Btn_Profil.Text = "Profil";
            Btn_Profil.TextImageRelation = TextImageRelation.ImageAboveText;
            Btn_Profil.ImageAlign = ContentAlignment.MiddleCenter;
            Btn_Profil.UseVisualStyleBackColor = false;
            Btn_Profil.Click += Profil_Click;
            // 
            // SemuaBtn
            // 
            SemuaBtn.BackColor = Color.DarkSeaGreen;
            SemuaBtn.Cursor = Cursors.Hand;
            SemuaBtn.FlatStyle = FlatStyle.Flat;
            SemuaBtn.FlatAppearance.BorderSize = 0;
            SemuaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SemuaBtn.ForeColor = Color.White;
            SemuaBtn.Location = new Point(590, 95);
            SemuaBtn.Name = "SemuaBtn";
            SemuaBtn.Size = new Size(90, 38);
            SemuaBtn.TabIndex = 2;
            SemuaBtn.Text = "Semua";
            SemuaBtn.UseVisualStyleBackColor = false;
            SemuaBtn.Click += SemuaBtn_Click;
            // 
            // PupukBtn
            // 
            PupukBtn.BackColor = Color.DarkSeaGreen;
            PupukBtn.Cursor = Cursors.Hand;
            PupukBtn.FlatStyle = FlatStyle.Flat;
            PupukBtn.FlatAppearance.BorderSize = 0;
            PupukBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PupukBtn.ForeColor = Color.White;
            PupukBtn.Location = new Point(695, 95);
            PupukBtn.Name = "PupukBtn";
            PupukBtn.Size = new Size(90, 38);
            PupukBtn.TabIndex = 3;
            PupukBtn.Text = "Pupuk";
            PupukBtn.UseVisualStyleBackColor = false;
            PupukBtn.Click += PupukBtn_Click;
            // 
            // BibitBtn
            // 
            BibitBtn.BackColor = Color.DarkSeaGreen;
            BibitBtn.Cursor = Cursors.Hand;
            BibitBtn.FlatStyle = FlatStyle.Flat;
            BibitBtn.FlatAppearance.BorderSize = 0;
            BibitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BibitBtn.ForeColor = Color.White;
            BibitBtn.Location = new Point(800, 95);
            BibitBtn.Name = "BibitBtn";
            BibitBtn.Size = new Size(90, 38);
            BibitBtn.TabIndex = 4;
            BibitBtn.Text = "Bibit";
            BibitBtn.UseVisualStyleBackColor = false;
            BibitBtn.Click += BibitBtn_Click;
            // 
            // ObatBtn
            // 
            ObatBtn.BackColor = Color.DarkSeaGreen;
            ObatBtn.Cursor = Cursors.Hand;
            ObatBtn.FlatStyle = FlatStyle.Flat;
            ObatBtn.FlatAppearance.BorderSize = 0;
            ObatBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ObatBtn.ForeColor = Color.White;
            ObatBtn.Location = new Point(905, 95);
            ObatBtn.Name = "ObatBtn";
            ObatBtn.Size = new Size(90, 38);
            ObatBtn.TabIndex = 5;
            ObatBtn.Text = "Obat";
            ObatBtn.UseVisualStyleBackColor = false;
            ObatBtn.Click += ObatBtn_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.SeaGreen;
            panelSidebar.Controls.Add(ListKeranjangBtn);
            panelSidebar.Controls.Add(StatusKirimBtn);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 140);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(15, 20, 15, 20);
            panelSidebar.Size = new Size(262, 446);
            panelSidebar.TabIndex = 1;
            // 
            // ListKeranjangBtn
            // 
            ListKeranjangBtn.BackColor = Color.Transparent;
            //ListKeranjangBtn.BackgroundImage = (Image)resources.GetObject("ListKeranjangBtn.BackgroundImage");
            ListKeranjangBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ListKeranjangBtn.Cursor = Cursors.Hand;
            ListKeranjangBtn.FlatStyle = FlatStyle.Flat;
            ListKeranjangBtn.FlatAppearance.BorderSize = 0;
            ListKeranjangBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ListKeranjangBtn.ForeColor = Color.White;
            ListKeranjangBtn.Location = new Point(15, 25);
            ListKeranjangBtn.Name = "ListKeranjangBtn";
            ListKeranjangBtn.Size = new Size(232, 52);
            ListKeranjangBtn.TabIndex = 0;
            ListKeranjangBtn.Text = "Keranjang";
            ListKeranjangBtn.UseVisualStyleBackColor = false;
            ListKeranjangBtn.Click += ListKeranjangBtn_Click;
            // 
            // StatusKirimBtn
            // 
            StatusKirimBtn.BackColor = Color.Transparent;
            //StatusKirimBtn.BackgroundImage = (Image)resources.GetObject("StatusKirimBtn.BackgroundImage");
            StatusKirimBtn.BackgroundImageLayout = ImageLayout.Stretch;
            StatusKirimBtn.Cursor = Cursors.Hand;
            StatusKirimBtn.FlatStyle = FlatStyle.Flat;
            StatusKirimBtn.FlatAppearance.BorderSize = 0;
            StatusKirimBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            StatusKirimBtn.ForeColor = Color.White;
            StatusKirimBtn.Location = new Point(15, 95);
            StatusKirimBtn.Name = "StatusKirimBtn";
            StatusKirimBtn.Size = new Size(232, 52);
            StatusKirimBtn.TabIndex = 1;
            StatusKirimBtn.Text = "Status Pengiriman";
            StatusKirimBtn.UseVisualStyleBackColor = false;
            StatusKirimBtn.Click += StatusKirimBtn_Click_1;

            // 
            // FlpProduk
            // 
            FlpProduk.AutoScroll = true;
            FlpProduk.BackColor = Color.WhiteSmoke;
            FlpProduk.Dock = DockStyle.Fill;
            FlpProduk.Location = new Point(262, 140);
            FlpProduk.Name = "FlpProduk";
            FlpProduk.Padding = new Padding(10);
            FlpProduk.Size = new Size(906, 446);
            FlpProduk.TabIndex = 2;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1168, 586);
            WindowState = FormWindowState.Maximized;
            Controls.Add(FlpProduk);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 10F);
            Name = "FormKasir";
            Text = "Kasir - Toko Taniku";
            FormClosed += FormKasir_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label LblToko;
        private Label LblKasir;
        private Button Btn_Profil;
        private Button SemuaBtn;
        private Button PupukBtn;
        private Button BibitBtn;
        private Button ObatBtn;
        private Panel panelSidebar;
        private Button ListKeranjangBtn;
        private Button StatusKirimBtn;
        private FlowLayoutPanel FlpProduk;
    }
}
