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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatusPengiriman));
            panel1 = new Panel();
            BackBtn = new Button();
            FinishBtn = new Button();
            OngoingBtn = new Button();
            FlpStatus = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(FinishBtn);
            panel1.Controls.Add(OngoingBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 125);
            panel1.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundImage = (Image)resources.GetObject("BackBtn.BackgroundImage");
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.Location = new Point(28, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(39, 29);
            BackBtn.TabIndex = 2;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // FinishBtn
            // 
            FinishBtn.BackColor = Color.Chartreuse;
            FinishBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            FinishBtn.Location = new Point(225, 70);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(116, 39);
            FinishBtn.TabIndex = 1;
            FinishBtn.Text = "Selesai";
            FinishBtn.UseVisualStyleBackColor = false;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // OngoingBtn
            // 
            OngoingBtn.BackColor = Color.Yellow;
            OngoingBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OngoingBtn.Location = new Point(48, 70);
            OngoingBtn.Name = "OngoingBtn";
            OngoingBtn.Size = new Size(116, 39);
            OngoingBtn.TabIndex = 0;
            OngoingBtn.Text = "Dikirim";
            OngoingBtn.UseVisualStyleBackColor = false;
            OngoingBtn.Click += OngoingBtn_Click;
            // 
            // FlpStatus
            // 
            FlpStatus.AllowDrop = true;
            FlpStatus.AutoScroll = true;
            FlpStatus.Dock = DockStyle.Fill;
            FlpStatus.Location = new Point(0, 125);
            FlpStatus.Name = "FlpStatus";
            FlpStatus.Size = new Size(1067, 446);
            FlpStatus.TabIndex = 1;
            // 
            // FormStatusPengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            Controls.Add(FlpStatus);
            Controls.Add(panel1);
            Name = "FormStatusPengiriman";
            Text = "FormStatusPengiriman";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel FlpStatus;
        private Button FinishBtn;
        private Button OngoingBtn;
        private Button BackBtn;
    }
}