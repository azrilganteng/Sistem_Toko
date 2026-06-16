namespace Sistem_Toko.View.KurirView
{
    partial class KurirForm
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
            HeaderPanel = new Panel();
            lblTitle = new Label();
            BtnBack = new Button();
            lblSubtitle = new Label();
            FlpPengiriman = new FlowLayoutPanel();
            HeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.SeaGreen;
            HeaderPanel.Controls.Add(BtnBack);
            HeaderPanel.Controls.Add(lblTitle);
            HeaderPanel.Controls.Add(lblSubtitle);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1100, 90);
            HeaderPanel.TabIndex = 0;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.White;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBack.ForeColor = Color.SeaGreen;
            BtnBack.Location = new Point(20, 25);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(40, 40);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "\u2190";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(75, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Size = new Size(220, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Pengiriman";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 255, 255, 255);
            lblSubtitle.Location = new Point(78, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            lblSubtitle.Size = new Size(200, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Daftar pengiriman aktif";
            // 
            // FlpPengiriman
            // 
            FlpPengiriman.AutoScroll = true;
            FlpPengiriman.BackColor = Color.WhiteSmoke;
            FlpPengiriman.Dock = DockStyle.Fill;
            FlpPengiriman.FlowDirection = FlowDirection.TopDown;
            FlpPengiriman.Location = new Point(0, 90);
            FlpPengiriman.Name = "FlpPengiriman";
            FlpPengiriman.Padding = new Padding(20, 15, 20, 15);
            FlpPengiriman.Size = new Size(1100, 480);
            FlpPengiriman.TabIndex = 1;
            FlpPengiriman.WrapContents = false;
            // 
            // KurirForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1100, 570);
            Controls.Add(FlpPengiriman);
            Controls.Add(HeaderPanel);
            Name = "KurirForm";
            Text = "Pengiriman";
            WindowState = FormWindowState.Maximized;
            Load += KurirForm_Load;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button BtnBack;
        private FlowLayoutPanel FlpPengiriman;
    }
}
