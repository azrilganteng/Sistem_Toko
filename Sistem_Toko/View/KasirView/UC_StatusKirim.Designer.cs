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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LblInfo);
            panel1.Controls.Add(LblStatus);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 10, 20, 10);
            panel1.Size = new Size(1020, 110);
            panel1.TabIndex = 0;
            // 
            // LblInfo
            // 
            LblInfo.AutoSize = true;
            LblInfo.Font = new Font("Segoe UI", 12F);
            LblInfo.ForeColor = Color.DarkSlateGray;
            LblInfo.Location = new Point(25, 20);
            LblInfo.Name = "LblInfo";
            LblInfo.Size = new Size(87, 28);
            LblInfo.TabIndex = 0;
            LblInfo.Text = "label1";
            // 
            // LblStatus
            // 
            LblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblStatus.Location = new Point(880, 40);
            LblStatus.Name = "LblStatus";
            LblStatus.Padding = new Padding(12, 6, 12, 6);
            LblStatus.Size = new Size(80, 37);
            LblStatus.TabIndex = 1;
            LblStatus.Text = "label2";
            // 
            // UC_StatusKirim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "UC_StatusKirim";
            Size = new Size(1020, 110);
            Load += UC_StatusKirim_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LblInfo;
        private Label LblStatus;
    }
}
