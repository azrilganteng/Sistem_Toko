namespace Sistem_Toko.View.KurirView
{
    partial class DetailPengiriman
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
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            TxtNota = new RichTextBox();
            LblJudul = new Label();
            LblTujuan = new Label();
            LblTotalHarga = new Label();
            SuspendLayout();
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // TxtNota
            // 
            TxtNota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtNota.Location = new Point(113, 117);
            TxtNota.Name = "TxtNota";
            TxtNota.ReadOnly = true;
            TxtNota.Size = new Size(817, 403);
            TxtNota.TabIndex = 4;
            TxtNota.Text = "";
            // 
            // LblJudul
            // 
            LblJudul.AutoSize = true;
            LblJudul.Location = new Point(188, 36);
            LblJudul.Name = "LblJudul";
            LblJudul.Size = new Size(50, 20);
            LblJudul.TabIndex = 5;
            LblJudul.Text = "label1";
            // 
            // LblTujuan
            // 
            LblTujuan.AutoSize = true;
            LblTujuan.Location = new Point(167, 155);
            LblTujuan.Name = "LblTujuan";
            LblTujuan.Size = new Size(50, 20);
            LblTujuan.TabIndex = 6;
            LblTujuan.Text = "label1";
            // 
            // LblTotalHarga
            // 
            LblTotalHarga.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblTotalHarga.AutoSize = true;
            LblTotalHarga.Location = new Point(761, 456);
            LblTotalHarga.Name = "LblTotalHarga";
            LblTotalHarga.Size = new Size(50, 20);
            LblTotalHarga.TabIndex = 7;
            LblTotalHarga.Text = "label1";
            // 
            // DetailPengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            WindowState = FormWindowState.Maximized;
            Controls.Add(LblTotalHarga);
            Controls.Add(LblTujuan);
            Controls.Add(LblJudul);
            Controls.Add(TxtNota);
            Name = "DetailPengiriman";
            Text = "DetailPengiriman";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private RichTextBox TxtNota;
        private Label LblJudul;
        private Label LblTujuan;
        private Label LblTotalHarga;
    }
}