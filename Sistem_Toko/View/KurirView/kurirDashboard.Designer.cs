namespace Sistem_Toko.View.KurirView
{
    partial class kurirDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kurirDashboard));
            label1 = new Label();
            lblSelamatDatang = new Label();
            button1 = new Button();
            button2 = new Button();
            lblNamaKurir = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 42);
            label1.Name = "label1";
            label1.Size = new Size(488, 89);
            label1.TabIndex = 0;
            label1.Text = "Toko Taniku";
            // 
            // lblSelamatDatang
            // 
            lblSelamatDatang.AutoSize = true;
            lblSelamatDatang.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelamatDatang.ForeColor = SystemColors.ActiveCaptionText;
            lblSelamatDatang.Location = new Point(70, 170);
            lblSelamatDatang.Name = "lblSelamatDatang";
            lblSelamatDatang.Size = new Size(183, 31);
            lblSelamatDatang.TabIndex = 1;
            lblSelamatDatang.Text = "Selamat Datang ";
            //lblSelamatDatang.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSpringGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(71, 267);
            button1.Name = "button1";
            button1.Size = new Size(281, 49);
            button1.TabIndex = 2;
            button1.Text = "Pengiriman Anda";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.LightGray;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(874, 33);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // lblNamaKurir
            // 
            lblNamaKurir.AutoSize = true;
            lblNamaKurir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaKurir.Location = new Point(247, 170);
            lblNamaKurir.Name = "lblNamaKurir";
            lblNamaKurir.Size = new Size(0, 31);
            lblNamaKurir.TabIndex = 4;
            //lblNamaKurir.Click += lblNamaKurir_Click;
            // 
            // kurirDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1067, 571);
            Controls.Add(lblNamaKurir);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblSelamatDatang);
            Controls.Add(label1);
            Name = "kurirDashboard";
            Text = "DashboardKurir";
            Load += MuatDashboard;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSelamatDatang;
        private Button button1;
        private Button button2;
        private Label lblNamaKurir;
    }
}


