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
            BackBtn = new Button();
            LblToko = new Label();
            LblKasir = new Label();
            panel2 = new Panel();
            BayarBtn = new Button();
            FlpKeranjang = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(LblToko);
            panel1.Controls.Add(LblKasir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 125);
            panel1.TabIndex = 5;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundImage = (Image)resources.GetObject("BackBtn.BackgroundImage");
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.Location = new Point(23, 17);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(39, 37);
            BackBtn.TabIndex = 5;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
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
            panel2.Controls.Add(BackBtn);
            panel2.Controls.Add(BayarBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 446);
            panel2.TabIndex = 6;
            // 
            // BayarBtn
            // 
            BayarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BayarBtn.BackColor = Color.SeaGreen;
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
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1067, 571);
            WindowState = FormWindowState.Maximized;
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
        private Button BackBtn;
        private Label LblToko;
        private Label LblKasir;
        private Panel panel2;
        private Button BayarBtn;
        private FlowLayoutPanel FlpKeranjang;
    }
}


