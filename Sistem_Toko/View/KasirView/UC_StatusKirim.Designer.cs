namespace Sistem_Toko.View.KasirView
{
    partial class UC_StatusKirim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StatusKirim));
            LblInfo = new Label();
            LblStatus = new Label();
            SuspendLayout();
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblInfo.Location = new Point(221, 26);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(87, 34);
            LblInfo.TabIndex = 0;
            LblInfo.Text = "label1";
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(934, 47);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(65, 28);
            LblStatus.TabIndex = 1;
            LblStatus.Text = "label2";
            // 
            // UC_StatusKirim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(LblStatus);
            Controls.Add(LblInfo);
            DoubleBuffered = true;
            Name = "UC_StatusKirim";
            Size = new Size(1067, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblInfo;
        private Label LblStatus;
    }
}



