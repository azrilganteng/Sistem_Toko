namespace Sistem_Toko
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
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
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.BackColor = Color.SeaGreen;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(189, 285);
            button1.Name = "button1";
            button1.Size = new Size(111, 45);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(38, 181);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 10;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(38, 116);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 9;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            PasswordBox.Location = new Point(149, 185);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(268, 30);
            PasswordBox.TabIndex = 8;
            // 
            // UsernameBox
            // 
            UsernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            UsernameBox.Location = new Point(149, 120);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(268, 30);
            UsernameBox.TabIndex = 7;
            // 
            // LoginText
            // 
            LoginText.Anchor = System.Windows.Forms.AnchorStyles.None;
            LoginText.AutoSize = true;
            LoginText.BackColor = Color.Transparent;
            LoginText.Font = new Font("MS Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginText.ForeColor = Color.DarkGreen;
            LoginText.Location = new Point(136, 23);
            LoginText.Margin = new Padding(0);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(213, 34);
            LoginText.TabIndex = 6;
            LoginText.Text = "Let's Login";
            LoginText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1168, 568);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            Name = "Login";
            Text = "Sistem_Toko";
            WindowState = FormWindowState.Maximized;
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




