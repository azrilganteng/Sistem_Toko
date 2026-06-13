namespace Sistem_Toko.View.KasirView
{
    partial class FormPilihKurir
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
            CboKurir = new ComboBox();
            TxtAlamat = new TextBox();
            Kirmkan = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 125);
            panel1.TabIndex = 0;
            // 
            // CboKurir
            // 
            CboKurir.FormattingEnabled = true;
            CboKurir.Location = new Point(31, 184);
            CboKurir.Name = "CboKurir";
            CboKurir.Size = new Size(987, 28);
            CboKurir.TabIndex = 1;
            // 
            // TxtAlamat
            // 
            TxtAlamat.Location = new Point(31, 412);
            TxtAlamat.Name = "TxtAlamat";
            TxtAlamat.Size = new Size(599, 27);
            TxtAlamat.TabIndex = 2;
            // 
            // Kirmkan
            // 
            Kirmkan.Location = new Point(874, 488);
            Kirmkan.Name = "Kirmkan";
            Kirmkan.Size = new Size(134, 51);
            Kirmkan.TabIndex = 3;
            Kirmkan.Text = "button1";
            Kirmkan.UseVisualStyleBackColor = true;
            Kirmkan.Click += Kirmkan_Click;
            // 
            // FormPilihKurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            Controls.Add(Kirmkan);
            Controls.Add(TxtAlamat);
            Controls.Add(CboKurir);
            Controls.Add(panel1);
            Name = "FormPilihKurir";
            Text = "PilihKurir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox CboKurir;
        private TextBox TxtAlamat;
        private Button Kirmkan;
    }
}