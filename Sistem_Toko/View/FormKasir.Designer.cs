namespace Sistem_Toko
{
    partial class FormKasir
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
            LblToko = new Label();
            LblKasir = new Label();
            KeranjangBtn = new Button();
            StatusKirimBtn = new Button();
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblToko.Location = new Point(54, 43);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(353, 73);
            LblToko.TabIndex = 0;
            LblToko.Text = "Nama Toko";
            // 
            // LblKasir
            // 
            LblKasir.AutoSize = true;
            LblKasir.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblKasir.Location = new Point(64, 116);
            LblKasir.Name = "LblKasir";
            LblKasir.Size = new Size(157, 37);
            LblKasir.TabIndex = 1;
            LblKasir.Text = "User Notif";
            // 
            // KeranjangBtn
            // 
            KeranjangBtn.BackColor = Color.GreenYellow;
            KeranjangBtn.Cursor = Cursors.Hand;
            KeranjangBtn.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeranjangBtn.Location = new Point(27, 193);
            KeranjangBtn.Name = "KeranjangBtn";
            KeranjangBtn.Size = new Size(221, 67);
            KeranjangBtn.TabIndex = 2;
            KeranjangBtn.Text = "button1";
            KeranjangBtn.UseVisualStyleBackColor = false;
            // 
            // StatusKirimBtn
            // 
            StatusKirimBtn.BackColor = Color.GreenYellow;
            StatusKirimBtn.Cursor = Cursors.Hand;
            StatusKirimBtn.Font = new Font("Franklin Gothic Medium", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusKirimBtn.Location = new Point(27, 282);
            StatusKirimBtn.Name = "StatusKirimBtn";
            StatusKirimBtn.Size = new Size(221, 67);
            StatusKirimBtn.TabIndex = 3;
            StatusKirimBtn.Text = "button2";
            StatusKirimBtn.UseVisualStyleBackColor = false;
            // 
            // FormKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1067, 571);
            Controls.Add(StatusKirimBtn);
            Controls.Add(KeranjangBtn);
            Controls.Add(LblKasir);
            Controls.Add(LblToko);
            Name = "FormKasir";
            Text = "FormKasir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblToko;
        private Label LblKasir;
        private Button KeranjangBtn;
        private Button StatusKirimBtn;
    }
}