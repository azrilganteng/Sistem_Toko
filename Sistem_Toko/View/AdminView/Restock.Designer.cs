namespace Sistem_Toko.View.AdminView
{
    partial class Restock
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
            SuspendLayout();
            // 
            // LblToko
            // 
            LblToko.AutoSize = true;
            LblToko.Font = new Font("Book Antiqua", 45F);
            LblToko.Location = new Point(53, 41);
            LblToko.Name = "LblToko";
            LblToko.Size = new Size(465, 92);
            LblToko.TabIndex = 11;
            LblToko.Text = "Toko Taniku";
            // 
            // Restock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1168, 568);
            Controls.Add(LblToko);
            Name = "Restock";
            Text = "Restock";
            // INJECTED_MANUAL_UI
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblToko;
    }
}


