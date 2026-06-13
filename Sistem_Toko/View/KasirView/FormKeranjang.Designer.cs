namespace Sistem_Toko
{
    partial class FormKeranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeranjang));
            panel1 = new Panel();
            ObatBtn = new Button();
            BibitBtn = new Button();
            PupukBtn = new Button();
            LblToko = new Label();
            LblKasir = new Label();
            panel2 = new Panel();
            BayarBtn = new Button();
            ListKeranjangBtn = new Button();
            StatusKirimBtn = new Button();
            FlpKeranjang = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(ObatBtn);
            panel1.Controls.Add(BibitBtn);
            panel1.Controls.Add(PupukBtn);
            panel1.Controls.Add(LblToko);
            panel1.Controls.Add(LblKasir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 125);
            panel1.TabIndex = 5;
            // 
            // ObatBtn
            // 
            ObatBtn.BackColor = Color.SeaGreen;
            ObatBtn.BackgroundImage = (Image)resources.GetObject("ObatBtn.BackgroundImage");
            ObatBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ObatBtn.Cursor = Cursors.Hand;
            ObatBtn.FlatStyle = FlatStyle.Flat;
            ObatBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ObatBtn.ForeColor = Color.White;
            ObatBtn.Location = new Point(926, 77);
            ObatBtn.Name = "ObatBtn";
            ObatBtn.Size = new Size(93, 40);
            ObatBtn.TabIndex = 4;
            ObatBtn.Text = "Obat";
            ObatBtn.UseVisualStyleBackColor = false;
            // 
            // BibitBtn
            // 
            BibitBtn.BackColor = Color.SeaGreen;
            BibitBtn.BackgroundImage = (Image)resources.GetObject("BibitBtn.BackgroundImage");
            BibitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BibitBtn.Cursor = Cursors.Hand;
            BibitBtn.FlatStyle = FlatStyle.Flat;
            BibitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BibitBtn.ForeColor = Color.White;
            BibitBtn.Location = new Point(781, 77);
            BibitBtn.Name = "BibitBtn";
            BibitBtn.Size = new Size(93, 40);
            BibitBtn.TabIndex = 3;
            BibitBtn.Text = "Bibit";
            BibitBtn.UseVisualStyleBackColor = false;
            // 
            // PupukBtn
            // 
            PupukBtn.BackColor = Color.SeaGreen;
            PupukBtn.BackgroundImage = (Image)resources.GetObject("PupukBtn.BackgroundImage");
            PupukBtn.BackgroundImageLayout = ImageLayout.Stretch;
            PupukBtn.Cursor = Cursors.Hand;
            PupukBtn.FlatStyle = FlatStyle.Flat;
            PupukBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            PupukBtn.ForeColor = Color.White;
            PupukBtn.Location = new Point(633, 77);
            PupukBtn.Name = "PupukBtn";
            PupukBtn.Size = new Size(93, 40);
            PupukBtn.TabIndex = 2;
            PupukBtn.Text = "Pupuk";
            PupukBtn.UseVisualStyleBackColor = false;
            PupukBtn.Click += PupukBtn_Click;
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblToko.Location = new Point(41, 9);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(353, 73);
            LblToko.TabIndex = 0;
            LblToko.Text = "Nama Toko";
            // 
            // LblKasir
            // 
            LblKasir.AutoSize = true;
            LblKasir.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblKasir.Location = new Point(54, 88);
            LblKasir.Name = "LblKasir";
            LblKasir.Size = new Size(157, 37);
            LblKasir.TabIndex = 1;
            LblKasir.Text = "User Notif";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(BayarBtn);
            panel2.Controls.Add(ListKeranjangBtn);
            panel2.Controls.Add(StatusKirimBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 446);
            panel2.TabIndex = 6;
            // 
            // BayarBtn
            // 
            BayarBtn.BackColor = Color.SeaGreen;
            BayarBtn.BackgroundImage = (Image)resources.GetObject("BayarBtn.BackgroundImage");
            BayarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BayarBtn.Cursor = Cursors.Hand;
            BayarBtn.FlatStyle = FlatStyle.Flat;
            BayarBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BayarBtn.ForeColor = Color.White;
            BayarBtn.Location = new Point(41, 355);
            BayarBtn.Name = "BayarBtn";
            BayarBtn.Size = new Size(147, 54);
            BayarBtn.TabIndex = 4;
            BayarBtn.Text = "Bayar";
            BayarBtn.UseVisualStyleBackColor = false;
            BayarBtn.Click += BayarBtn_Click;
            // 
            // ListKeranjangBtn
            // 
            ListKeranjangBtn.BackColor = Color.SeaGreen;
            ListKeranjangBtn.BackgroundImage = (Image)resources.GetObject("ListKeranjangBtn.BackgroundImage");
            ListKeranjangBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ListKeranjangBtn.Cursor = Cursors.Hand;
            ListKeranjangBtn.FlatStyle = FlatStyle.Flat;
            ListKeranjangBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ListKeranjangBtn.ForeColor = Color.White;
            ListKeranjangBtn.Location = new Point(12, 51);
            ListKeranjangBtn.Name = "ListKeranjangBtn";
            ListKeranjangBtn.Size = new Size(221, 67);
            ListKeranjangBtn.TabIndex = 2;
            ListKeranjangBtn.Text = "Keranjang";
            ListKeranjangBtn.UseVisualStyleBackColor = false;
            // 
            // StatusKirimBtn
            // 
            StatusKirimBtn.BackColor = Color.SeaGreen;
            StatusKirimBtn.BackgroundImage = (Image)resources.GetObject("StatusKirimBtn.BackgroundImage");
            StatusKirimBtn.BackgroundImageLayout = ImageLayout.Stretch;
            StatusKirimBtn.Cursor = Cursors.Hand;
            StatusKirimBtn.FlatStyle = FlatStyle.Flat;
            StatusKirimBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            StatusKirimBtn.ForeColor = Color.White;
            StatusKirimBtn.Location = new Point(12, 146);
            StatusKirimBtn.Name = "StatusKirimBtn";
            StatusKirimBtn.Size = new Size(221, 99);
            StatusKirimBtn.TabIndex = 3;
            StatusKirimBtn.Text = "Status Pengiriman";
            StatusKirimBtn.UseVisualStyleBackColor = false;
            // 
            // FlpKeranjang
            // 
            FlpKeranjang.AutoScroll = true;
            FlpKeranjang.BackColor = Color.Transparent;
            FlpKeranjang.Dock = DockStyle.Fill;
            FlpKeranjang.Location = new Point(250, 125);
            FlpKeranjang.Name = "FlpKeranjang";
            FlpKeranjang.Size = new Size(817, 446);
            FlpKeranjang.TabIndex = 7;
            // 
            // FormKeranjang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1067, 571);
            Controls.Add(FlpKeranjang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "FormKeranjang";
            Text = "FormKeranjang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ObatBtn;
        private Button BibitBtn;
        private Button PupukBtn;
        private Label LblToko;
        private Label LblKasir;
        private Panel panel2;
        private Button BayarBtn;
        private Button ListKeranjangBtn;
        private Button StatusKirimBtn;
        private FlowLayoutPanel FlpKeranjang;
    }
}


