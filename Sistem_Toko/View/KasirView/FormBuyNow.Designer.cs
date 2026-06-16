namespace Sistem_Toko.View.KasirView
{
    partial class FormBuyNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyNow));
            panel1 = new Panel();
            button1 = new Button();
            LblQty = new Label();
            TambahQty = new Button();
            label3 = new Label();
            LblKategori = new Label();
            LblProduk = new Label();
            BayarBtn = new Button();
            DeskripsiLbl = new Label();
            PbGambar = new PictureBox();
            BackBtn = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbGambar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(LblQty);
            panel1.Controls.Add(TambahQty);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(LblKategori);
            panel1.Controls.Add(LblProduk);
            panel1.Controls.Add(BayarBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(653, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 571);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(49, 264);
            button1.Name = "button1";
            button1.Size = new Size(42, 37);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LblQty
            // 
            LblQty.AutoSize = true;
            LblQty.Location = new Point(111, 272);
            LblQty.Name = "LblQty";
            LblQty.Size = new Size(50, 20);
            LblQty.TabIndex = 5;
            LblQty.Text = "label4";
            // 
            // TambahQty
            // 
            TambahQty.BackColor = Color.Transparent;
            TambahQty.BackgroundImage = (Image)resources.GetObject("TambahQty.BackgroundImage");
            TambahQty.BackgroundImageLayout = ImageLayout.Stretch;
            TambahQty.Location = new Point(184, 264);
            TambahQty.Name = "TambahQty";
            TambahQty.Size = new Size(42, 37);
            TambahQty.TabIndex = 4;
            TambahQty.UseVisualStyleBackColor = false;
            TambahQty.Click += TambahQty_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 205);
            label3.Name = "label3";
            label3.Size = new Size(188, 36);
            label3.TabIndex = 3;
            label3.Text = "Beli sekarang";
            // 
            // LblKategori
            // 
            LblKategori.AutoSize = true;
            LblKategori.Location = new Point(49, 140);
            LblKategori.Name = "LblKategori";
            LblKategori.Size = new Size(50, 20);
            LblKategori.TabIndex = 2;
            LblKategori.Text = "label2";
            // 
            // LblProduk
            // 
            LblProduk.AutoSize = true;
            LblProduk.Location = new Point(49, 39);
            LblProduk.Name = "LblProduk";
            LblProduk.Size = new Size(50, 20);
            LblProduk.TabIndex = 1;
            LblProduk.Text = "label1";
            // 
            // BayarBtn
            // 
            BayarBtn.BackgroundImage = (Image)resources.GetObject("BayarBtn.BackgroundImage");
            BayarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BayarBtn.Location = new Point(111, 471);
            BayarBtn.Name = "BayarBtn";
            BayarBtn.Size = new Size(195, 57);
            BayarBtn.TabIndex = 0;
            BayarBtn.UseVisualStyleBackColor = true;
            BayarBtn.Click += BayarBtn_Click;
            // 
            // DeskripsiLbl
            // 
            DeskripsiLbl.AutoSize = true;
            DeskripsiLbl.Location = new Point(19, 45);
            DeskripsiLbl.Name = "DeskripsiLbl";
            DeskripsiLbl.Size = new Size(50, 20);
            DeskripsiLbl.TabIndex = 1;
            DeskripsiLbl.Text = "label1";
            // 
            // PbGambar
            // 
            PbGambar.Location = new Point(12, 12);
            PbGambar.Name = "PbGambar";
            PbGambar.Size = new Size(596, 238);
            PbGambar.TabIndex = 2;
            PbGambar.TabStop = false;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundImage = (Image)resources.GetObject("BackBtn.BackgroundImage");
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.Location = new Point(27, 31);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(42, 37);
            BackBtn.TabIndex = 7;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(DeskripsiLbl);
            groupBox1.Location = new Point(27, 317);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 160);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FormBuyNow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1067, 571);
            Controls.Add(groupBox1);
            Controls.Add(BackBtn);
            Controls.Add(PbGambar);
            Controls.Add(panel1);
            Name = "FormBuyNow";
            Text = "FormBuyNow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbGambar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BayarBtn;
        private Label LblProduk;
        private Label LblKategori;
        private Button TambahQty;
        private Label label3;
        private Label DeskripsiLbl;
        private PictureBox PbGambar;
        private Button button1;
        private Label LblQty;
        private Button BackBtn;
        private GroupBox groupBox1;
    }
}