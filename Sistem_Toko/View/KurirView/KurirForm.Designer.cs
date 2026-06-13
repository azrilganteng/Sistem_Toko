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
            dgvPengiriman = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengiriman).BeginInit();
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
            panel2.Controls.Add(lblPengiriman);
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
            lblPengiriman.Location = new Point(24, 37);
            lblPengiriman.Name = "lblPengiriman";
            lblPengiriman.Size = new Size(119, 28);
            lblPengiriman.TabIndex = 0;
            lblPengiriman.Text = "Pengiriman";
            lblPengiriman.Click += lblPengiriman_Click;
            // 
            // dgvPengiriman
            // 
            dgvPengiriman.AllowUserToAddRows = false;
            dgvPengiriman.AllowUserToResizeColumns = false;
            dgvPengiriman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengiriman.ColumnHeadersVisible = false;
            dgvPengiriman.Location = new Point(3, 68);
            dgvPengiriman.Name = "dgvPengiriman";
            dgvPengiriman.RowHeadersVisible = false;
            dgvPengiriman.RowHeadersWidth = 51;
            dgvPengiriman.Size = new Size(1066, 504);
            dgvPengiriman.TabIndex = 1;
            dgvPengiriman.CellClick += dgvPengiriman_CellClick;
            // 
            // KurirForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1067, 571);
            Controls.Add(dgvPengiriman);
            Controls.Add(panel1);
            Name = "KurirForm";
            Text = "Form1";
            Load += KurirForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengiriman).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblPengiriman;
        private DataGridView dgvPengiriman;
    }
}