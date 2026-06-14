namespace Sistem_Toko.View.KurirView
{
    partial class KurirForm
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
            panel2 = new Panel();
            lblPengiriman = new Label();
            panel3 = new Panel();
            FlpPengiriman = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 452);
            panel2.TabIndex = 0;
            // 
            // lblPengiriman
            // 
            lblPengiriman.AutoSize = true;
            lblPengiriman.BackColor = Color.White;
            lblPengiriman.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPengiriman.Location = new Point(91, 78);
            lblPengiriman.Name = "lblPengiriman";
            lblPengiriman.Size = new Size(119, 28);
            lblPengiriman.TabIndex = 0;
            lblPengiriman.Text = "Pengiriman";
            lblPengiriman.Click += lblPengiriman_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPengiriman);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1067, 125);
            panel3.TabIndex = 1;
            // 
            // FlpPengiriman
            // 
            FlpPengiriman.Dock = DockStyle.Fill;
            FlpPengiriman.Location = new Point(0, 125);
            FlpPengiriman.Name = "FlpPengiriman";
            FlpPengiriman.Size = new Size(1067, 446);
            FlpPengiriman.TabIndex = 2;
            // 
            // KurirForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1067, 571);
            Controls.Add(FlpPengiriman);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "KurirForm";
            Text = "Form1";
            Load += KurirForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblPengiriman;
        private Panel panel3;
        private FlowLayoutPanel FlpPengiriman;
    }
}