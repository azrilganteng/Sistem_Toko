namespace Sistem_Toko.View.KasirView
{
    partial class FormStatusPengiriman
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
            LblHeader = new Label();
            FinishBtn = new Button();
            OngoingBtn = new Button();
            FlpStatus = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(LblHeader);
            panel1.Controls.Add(FinishBtn);
            panel1.Controls.Add(OngoingBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 100);
            panel1.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.White;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BackBtn.ForeColor = Color.SeaGreen;
            BackBtn.Location = new Point(15, 35);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(90, 40);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "< Kembali";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // LblHeader
            // 
            LblHeader.AutoSize = true;
            LblHeader.Font = new Font("Book Antiqua", 28F, FontStyle.Bold);
            LblHeader.ForeColor = Color.White;
            LblHeader.Location = new Point(130, 22);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(400, 55);
            LblHeader.TabIndex = 3;
            LblHeader.Text = "Status Pengiriman";
            // 
            // FinishBtn
            // 
            FinishBtn.BackColor = Color.White;
            FinishBtn.FlatStyle = FlatStyle.Flat;
            FinishBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            FinishBtn.ForeColor = Color.SeaGreen;
            FinishBtn.Location = new Point(780, 35);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(120, 40);
            FinishBtn.TabIndex = 1;
            FinishBtn.Text = "Selesai";
            FinishBtn.UseVisualStyleBackColor = false;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // OngoingBtn
            // 
            OngoingBtn.BackColor = Color.White;
            OngoingBtn.FlatStyle = FlatStyle.Flat;
            OngoingBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            OngoingBtn.ForeColor = Color.SeaGreen;
            OngoingBtn.Location = new Point(640, 35);
            OngoingBtn.Name = "OngoingBtn";
            OngoingBtn.Size = new Size(120, 40);
            OngoingBtn.TabIndex = 0;
            OngoingBtn.Text = "Dikirim";
            OngoingBtn.UseVisualStyleBackColor = false;
            OngoingBtn.Click += OngoingBtn_Click;
            // 
            // FlpStatus
            // 
            FlpStatus.AutoScroll = true;
            FlpStatus.BackColor = Color.WhiteSmoke;
            FlpStatus.Dock = DockStyle.Fill;
            FlpStatus.Location = new Point(0, 100);
            FlpStatus.Name = "FlpStatus";
            FlpStatus.Padding = new Padding(10);
            FlpStatus.Size = new Size(1067, 471);
            FlpStatus.TabIndex = 1;
            // 
            // FormStatusPengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1067, 571);
            Controls.Add(FlpStatus);
            Controls.Add(panel1);
            Name = "FormStatusPengiriman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Status Pengiriman - Toko Tani Samudra";
            FormClosing += FormStatusPengiriman_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel FlpStatus;
        private Button FinishBtn;
        private Button OngoingBtn;
        private Button BackBtn;
        private Label LblHeader;
    }
}
