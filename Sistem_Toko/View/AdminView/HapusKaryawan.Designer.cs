namespace Sistem_Toko.View.AdminView
{
    partial class HapusKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HapusKaryawan));
            label10 = new Label();
            label1 = new Label();
            TextBox_ID = new TextBox();
            Btn_Simpan = new Button();
            Btn_Kembali = new Button();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new Font("Book Antiqua", 15F);
            label10.Location = new Point(74, 9);
            label10.Name = "label10";
            label10.Size = new Size(281, 31);
            label10.TabIndex = 39;
            label10.Text = "Hapus Akun Karyawan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 15F);
            label1.Location = new Point(107, 124);
            label1.Name = "label1";
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Size = new Size(53, 31);
            label1.TabIndex = 40;
            label1.Text = "ID :";
            // 
            // TextBox_ID
            // 
            TextBox_ID.Location = new Point(177, 128);
            TextBox_ID.Name = "TextBox_ID";
            TextBox_ID.Size = new Size(125, 30);
            TextBox_ID.TabIndex = 41;
            // 
            // Btn_Simpan
            // 
            Btn_Simpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Simpan.BackColor = Color.Crimson;
            Btn_Simpan.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_Simpan.Cursor = Cursors.Hand;
            Btn_Simpan.FlatStyle = FlatStyle.Flat;
            Btn_Simpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Simpan.ForeColor = Color.White;
            Btn_Simpan.Location = new Point(290, 247);
            Btn_Simpan.Name = "Btn_Simpan";
            Btn_Simpan.Size = new Size(133, 34);
            Btn_Simpan.TabIndex = 42;
            Btn_Simpan.Text = "Simpan";
            Btn_Simpan.UseVisualStyleBackColor = false;
            Btn_Simpan.Click += Btn_Simpan_Click;
            // 
            // Btn_Kembali
            // 
            Btn_Kembali.BackColor = Color.Transparent;
            Btn_Kembali.BackgroundImage = (Image)resources.GetObject("Btn_Kembali.BackgroundImage");
            Btn_Kembali.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Kembali.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Btn_Kembali.ForeColor = Color.White;
            Btn_Kembali.Location = new Point(5, 12);
            Btn_Kembali.Name = "Btn_Kembali";
            Btn_Kembali.Size = new Size(40, 40);
            Btn_Kembali.TabIndex = 99;
            Btn_Kembali.UseVisualStyleBackColor = false;
            Btn_Kembali.Click += Btn_Kembali_Click;
            // 
            // HapusKaryawan
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(435, 293);
            Controls.Add(Btn_Simpan);
            Controls.Add(TextBox_ID);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(Btn_Kembali);
            Font = new Font("Segoe UI", 10F);
            Name = "HapusKaryawan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HapusKaryawan";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label1;
        private TextBox TextBox_ID;
        private Button Btn_Simpan;
    
        private System.Windows.Forms.Button Btn_Kembali;
    }
}







