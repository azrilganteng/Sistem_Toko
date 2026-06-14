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
            BackBtn = new Button();
            LblToko = new Label();
            LblKasir = new Label();
            panel2 = new Panel();
            LblTotalKeranjang = new Label();
            BayarBtn = new Button();
            FlpKeranjang = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(LblToko);
            panel1.Controls.Add(LblKasir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 100);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.White;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BackBtn.ForeColor = Color.SeaGreen;
            BackBtn.Location = new Point(15, 35);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(90, 40);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "< Kembali";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblToko.ForeColor = Color.White;
            LblToko.Location = new Point(130, 10);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(353, 55);
            LblToko.TabIndex = 0;
            LblToko.Text = "Keranjang Belanja";
            // 
            // LblKasir
            // 
            LblKasir.AutoSize = true;
            LblKasir.Font = new Font("Segoe UI", 12F);
            LblKasir.ForeColor = Color.WhiteSmoke;
            LblKasir.Location = new Point(134, 68);
            LblKasir.Name = "LblKasir";
            LblKasir.Size = new Size(157, 28);
            LblKasir.TabIndex = 1;
            LblKasir.Text = "User Notif";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 240, 240);
            panel2.Controls.Add(LblTotalKeranjang);
            panel2.Controls.Add(BayarBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 481);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 90);
            panel2.TabIndex = 6;
            // 
            // LblTotalKeranjang
            // 
            LblTotalKeranjang.AutoSize = true;
            LblTotalKeranjang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LblTotalKeranjang.ForeColor = Color.SeaGreen;
            LblTotalKeranjang.Location = new Point(30, 28);
            LblTotalKeranjang.Name = "LblTotalKeranjang";
            LblTotalKeranjang.Size = new Size(200, 37);
            LblTotalKeranjang.TabIndex = 5;
            LblTotalKeranjang.Text = "Total: Rp. 0";
            // 
            // BayarBtn
            // 
            BayarBtn.BackColor = Color.SeaGreen;
            BayarBtn.Cursor = Cursors.Hand;
            BayarBtn.FlatAppearance.BorderSize = 0;
            BayarBtn.FlatStyle = FlatStyle.Flat;
            BayarBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BayarBtn.ForeColor = Color.White;
            BayarBtn.Location = new Point(860, 18);
            BayarBtn.Name = "BayarBtn";
            BayarBtn.Size = new Size(180, 55);
            BayarBtn.TabIndex = 4;
            BayarBtn.Text = "Bayar Sekarang";
            BayarBtn.UseVisualStyleBackColor = false;
            BayarBtn.Click += BayarBtn_Click;
            // 
            // FlpKeranjang
            // 
            FlpKeranjang.AutoScroll = true;
            FlpKeranjang.BackColor = Color.WhiteSmoke;
            FlpKeranjang.Dock = DockStyle.Fill;
            FlpKeranjang.Location = new Point(0, 100);
            FlpKeranjang.Name = "FlpKeranjang";
            FlpKeranjang.Padding = new Padding(10);
            FlpKeranjang.Size = new Size(1067, 381);
            FlpKeranjang.TabIndex = 7;
            // 
            // FormKeranjang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1067, 571);
            Controls.Add(FlpKeranjang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "FormKeranjang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Keranjang - Toko Tani Samudra";
            FormClosing += FormKeranjang_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LblToko;
        private Label LblKasir;
        private Panel panel2;
        private Button BayarBtn;
        private FlowLayoutPanel FlpKeranjang;
        private Button BackBtn;
        private Label LblTotalKeranjang;
    }
}
