namespace Sistem_Toko
{
    partial class FormPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembayaran));
            listBox1 = new ListBox();
            lblTotal = new Label();
            txtNota = new TextBox();
            KonfirmBtn = new Button();
            CboMetodeKirim = new ComboBox();
            CboMetodeBayar = new ComboBox();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(120, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(840, 395);
            listBox1.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(706, 401);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(76, 31);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "label1";
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(201, 110);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.ReadOnly = true;
            txtNota.ScrollBars = ScrollBars.Vertical;
            txtNota.Size = new Size(677, 213);
            txtNota.TabIndex = 4;
            txtNota.WordWrap = false;
            // 
            // KonfirmBtn
            // 
            KonfirmBtn.BackColor = Color.SeaGreen;
            KonfirmBtn.Cursor = Cursors.Hand;
            KonfirmBtn.FlatStyle = FlatStyle.Flat;
            KonfirmBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            KonfirmBtn.ForeColor = Color.White;
            KonfirmBtn.Location = new Point(838, 492);
            KonfirmBtn.Name = "KonfirmBtn";
            KonfirmBtn.Size = new Size(122, 46);
            KonfirmBtn.TabIndex = 5;
            KonfirmBtn.Text = "button1";
            KonfirmBtn.UseVisualStyleBackColor = false;
            KonfirmBtn.Click += KonfirmBtn_Click;
            // 
            // CboMetodeKirim
            // 
            CboMetodeKirim.Location = new Point(289, 385);
            CboMetodeKirim.Name = "CboMetodeKirim";
            CboMetodeKirim.Size = new Size(151, 31);
            CboMetodeKirim.TabIndex = 0;
            // 
            // CboMetodeBayar
            // 
            CboMetodeBayar.Location = new Point(289, 437);
            CboMetodeBayar.Name = "CboMetodeBayar";
            CboMetodeBayar.Size = new Size(151, 31);
            CboMetodeBayar.TabIndex = 6;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.BackgroundImage = (Image)resources.GetObject("BackBtn.BackgroundImage");
            BackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            BackBtn.Location = new Point(45, 41);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(39, 37);
            BackBtn.TabIndex = 7;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // FormPembayaran
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1067, 571);
            Controls.Add(BackBtn);
            Controls.Add(CboMetodeBayar);
            Controls.Add(CboMetodeKirim);
            Controls.Add(KonfirmBtn);
            Controls.Add(txtNota);
            Controls.Add(lblTotal);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 10F);
            Name = "FormPembayaran";
            Text = "FormPembayaran";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lblTotal;
        private TextBox txtNota;
        private Button KonfirmBtn;
        private ComboBox CboMetodeKirim;
        private ComboBox CboMetodeBayar;
        private Button BackBtn;
    }
}


