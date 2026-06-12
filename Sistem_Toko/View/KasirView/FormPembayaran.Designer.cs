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
            listBox1 = new ListBox();
            lblTotal = new Label();
            txtNota = new TextBox();
            KonfirmBtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(120, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(840, 404);
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
            txtNota.Location = new Point(199, 158);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(677, 27);
            txtNota.TabIndex = 4;
            // 
            // KonfirmBtn
            // 
            KonfirmBtn.Location = new Point(838, 492);
            KonfirmBtn.Name = "KonfirmBtn";
            KonfirmBtn.Size = new Size(122, 46);
            KonfirmBtn.TabIndex = 5;
            KonfirmBtn.Text = "button1";
            KonfirmBtn.UseVisualStyleBackColor = true;
            KonfirmBtn.Click += KonfirmBtn_Click;
            // 
            // FormPembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            Controls.Add(KonfirmBtn);
            Controls.Add(txtNota);
            Controls.Add(lblTotal);
            Controls.Add(listBox1);
            Name = "FormPembayaran";
            Text = "FormPembayaran";
            // INJECTED_MANUAL_UI
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KonfirmBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.KonfirmBtn.ForeColor = System.Drawing.Color.White;
            this.KonfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KonfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KonfirmBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lblTotal;
        private TextBox txtNota;
        private Button KonfirmBtn;
    }
}


