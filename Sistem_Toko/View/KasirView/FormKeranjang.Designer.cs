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
            ObatBtn.Location = new Point(927, 88);
            ObatBtn.Name = "ObatBtn";
            ObatBtn.Size = new Size(94, 29);
            ObatBtn.TabIndex = 4;
            ObatBtn.Text = "Obat";
            ObatBtn.UseVisualStyleBackColor = true;
            // 
            // BibitBtn
            // 
            BibitBtn.Location = new Point(779, 88);
            BibitBtn.Name = "BibitBtn";
            BibitBtn.Size = new Size(94, 29);
            BibitBtn.TabIndex = 3;
            BibitBtn.Text = "Bibit";
            BibitBtn.UseVisualStyleBackColor = true;
            // 
            // PupukBtn
            // 
            PupukBtn.Location = new Point(632, 88);
            PupukBtn.Name = "PupukBtn";
            PupukBtn.Size = new Size(94, 29);
            PupukBtn.TabIndex = 2;
            PupukBtn.Text = "Pupuk";
            PupukBtn.UseVisualStyleBackColor = true;
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
            BayarBtn.BackColor = Color.MediumSeaGreen;
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
            ListKeranjangBtn.BackColor = Color.GreenYellow;
            ListKeranjangBtn.Cursor = Cursors.Hand;
            ListKeranjangBtn.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListKeranjangBtn.Location = new Point(12, 51);
            ListKeranjangBtn.Name = "ListKeranjangBtn";
            ListKeranjangBtn.Size = new Size(221, 67);
            ListKeranjangBtn.TabIndex = 2;
            ListKeranjangBtn.Text = "Keranjang";
            ListKeranjangBtn.UseVisualStyleBackColor = false;
            // 
            // StatusKirimBtn
            // 
            StatusKirimBtn.BackColor = Color.GreenYellow;
            StatusKirimBtn.Cursor = Cursors.Hand;
            StatusKirimBtn.Font = new Font("Franklin Gothic Medium", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            Controls.Add(FlpKeranjang);
            Controls.Add(panel2);
            Controls.Add(panel1);
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