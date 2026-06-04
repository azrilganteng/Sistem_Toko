namespace Sistem_Toko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            LoginText = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(PasswordBox);
            groupBox1.Controls.Add(UsernameBox);
            groupBox1.Controls.Add(LoginText);
            groupBox1.Location = new Point(346, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 413);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(174, 251);
            button1.Name = "button1";
            button1.Size = new Size(111, 45);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(38, 181);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 10;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(38, 116);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 9;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(149, 185);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(268, 27);
            PasswordBox.TabIndex = 8;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(149, 120);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(268, 27);
            UsernameBox.TabIndex = 7;
            // 
            // LoginText
            // 
            LoginText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginText.AutoSize = true;
            LoginText.BackColor = Color.Transparent;
            LoginText.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginText.ForeColor = Color.Honeydew;
            LoginText.Location = new Point(136, 23);
            LoginText.Margin = new Padding(0);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(187, 41);
            LoginText.TabIndex = 6;
            LoginText.Text = "Login Kuy";
            LoginText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1168, 568);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sistem_Toko";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private Label LoginText;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}
