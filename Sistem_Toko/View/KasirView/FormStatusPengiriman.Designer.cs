namespace Sistem_Toko.View.KasirView
{
    partial class FormStatusPengiriman
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
            FinishBtn = new Button();
            OngoingBtn = new Button();
            FlpStatus = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(FinishBtn);
            panel1.Controls.Add(OngoingBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 125);
            panel1.TabIndex = 0;
            // 
            // FinishBtn
            // 
            FinishBtn.Location = new Point(883, 70);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(116, 39);
            FinishBtn.TabIndex = 1;
            FinishBtn.Text = "button2";
            FinishBtn.UseVisualStyleBackColor = true;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // OngoingBtn
            // 
            OngoingBtn.Location = new Point(687, 70);
            OngoingBtn.Name = "OngoingBtn";
            OngoingBtn.Size = new Size(116, 39);
            OngoingBtn.TabIndex = 0;
            OngoingBtn.Text = "button1";
            OngoingBtn.UseVisualStyleBackColor = true;
            OngoingBtn.Click += OngoingBtn_Click;
            // 
            // FlpStatus
            // 
            FlpStatus.AllowDrop = true;
            FlpStatus.AutoScroll = true;
            FlpStatus.Dock = DockStyle.Fill;
            FlpStatus.Location = new Point(0, 125);
            FlpStatus.Name = "FlpStatus";
            FlpStatus.Size = new Size(1067, 446);
            FlpStatus.TabIndex = 1;
            // 
            // FormStatusPengiriman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 571);
            Controls.Add(FlpStatus);
            Controls.Add(panel1);
            Name = "FormStatusPengiriman";
            Text = "FormStatusPengiriman";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel FlpStatus;
        private Button FinishBtn;
        private Button OngoingBtn;
    }
}


