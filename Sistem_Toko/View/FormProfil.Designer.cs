namespace Sistem_Toko.View
{
    partial class FormProfil
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfil));
            LblJudul = new Label();
            GrpInfo = new GroupBox();
            LblIdUser = new Label();
            LblIdUserVal = new Label();
            LblNama = new Label();
            LblNamaVal = new Label();
            LblRole = new Label();
            LblRoleVal = new Label();
            LblUsername = new Label();
            LblUsernameVal = new Label();
            LblEmail = new Label();
            LblEmailVal = new Label();
            LblNoHP = new Label();
            LblNoHPVal = new Label();
            LblAlamat = new Label();
            LblAlamatVal = new Label();
            TxtNama = new TextBox();
            TxtUsername = new TextBox();
            TxtEmail = new TextBox();
            TxtNoHP = new TextBox();
            TxtAlamat = new TextBox();
            Btn_Logout = new Button();
            Btn_Edit = new Button();
            Btn_Kembali = new Button();
            GrpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // LblJudul
            // 
            LblJudul.AutoSize = true;
            LblJudul.BackColor = Color.Transparent;
            LblJudul.Font = new Font("Book Antiqua", 36F, FontStyle.Bold);
            LblJudul.ForeColor = Color.FromArgb(40, 100, 60);
            LblJudul.Location = new Point(55, 20);
            LblJudul.Name = "LblJudul";
            LblJudul.Size = new Size(333, 73);
            LblJudul.TabIndex = 0;
            LblJudul.Text = "Profil Saya";
            // 
            // GrpInfo
            // 
            GrpInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrpInfo.BackColor = Color.White;
            GrpInfo.Controls.Add(LblIdUser);
            GrpInfo.Controls.Add(LblIdUserVal);
            GrpInfo.Controls.Add(LblNama);
            GrpInfo.Controls.Add(LblNamaVal);
            GrpInfo.Controls.Add(LblRole);
            GrpInfo.Controls.Add(LblRoleVal);
            GrpInfo.Controls.Add(LblUsername);
            GrpInfo.Controls.Add(LblUsernameVal);
            GrpInfo.Controls.Add(LblEmail);
            GrpInfo.Controls.Add(LblEmailVal);
            GrpInfo.Controls.Add(LblNoHP);
            GrpInfo.Controls.Add(LblNoHPVal);
            GrpInfo.Controls.Add(LblAlamat);
            GrpInfo.Controls.Add(LblAlamatVal);
            GrpInfo.Controls.Add(TxtNama);
            GrpInfo.Controls.Add(TxtUsername);
            GrpInfo.Controls.Add(TxtEmail);
            GrpInfo.Controls.Add(TxtNoHP);
            GrpInfo.Controls.Add(TxtAlamat);
            GrpInfo.Font = new Font("Segoe UI", 11F);
            GrpInfo.ForeColor = Color.DimGray;
            GrpInfo.Location = new Point(55, 110);
            GrpInfo.Name = "GrpInfo";
            GrpInfo.Padding = new Padding(20, 15, 20, 15);
            GrpInfo.Size = new Size(700, 360);
            GrpInfo.TabIndex = 1;
            GrpInfo.TabStop = false;
            // 
            // LblIdUser
            // 
            LblIdUser.AutoSize = true;
            LblIdUser.BackColor = Color.Transparent;
            LblIdUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblIdUser.ForeColor = Color.DimGray;
            LblIdUser.Location = new Point(30, 45);
            LblIdUser.Name = "LblIdUser";
            LblIdUser.Size = new Size(68, 23);
            LblIdUser.TabIndex = 0;
            LblIdUser.Text = "ID User";
            // 
            // LblIdUserVal
            // 
            LblIdUserVal.AutoSize = true;
            LblIdUserVal.BackColor = Color.Transparent;
            LblIdUserVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblIdUserVal.ForeColor = Color.Black;
            LblIdUserVal.Location = new Point(30, 70);
            LblIdUserVal.Name = "LblIdUserVal";
            LblIdUserVal.Size = new Size(33, 28);
            LblIdUserVal.TabIndex = 1;
            LblIdUserVal.Text = "ID";
            // 
            // LblNama
            // 
            LblNama.AutoSize = true;
            LblNama.BackColor = Color.Transparent;
            LblNama.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblNama.ForeColor = Color.DimGray;
            LblNama.Location = new Point(350, 45);
            LblNama.Name = "LblNama";
            LblNama.Size = new Size(57, 23);
            LblNama.TabIndex = 2;
            LblNama.Text = "Nama";
            // 
            // LblNamaVal
            // 
            LblNamaVal.AutoSize = true;
            LblNamaVal.BackColor = Color.Transparent;
            LblNamaVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblNamaVal.ForeColor = Color.Black;
            LblNamaVal.Location = new Point(350, 70);
            LblNamaVal.Name = "LblNamaVal";
            LblNamaVal.Size = new Size(68, 28);
            LblNamaVal.TabIndex = 3;
            LblNamaVal.Text = "Nama";
            // 
            // LblRole
            // 
            LblRole.AutoSize = true;
            LblRole.BackColor = Color.Transparent;
            LblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblRole.ForeColor = Color.DimGray;
            LblRole.Location = new Point(30, 115);
            LblRole.Name = "LblRole";
            LblRole.Size = new Size(45, 23);
            LblRole.TabIndex = 4;
            LblRole.Text = "Role";
            // 
            // LblRoleVal
            // 
            LblRoleVal.AutoSize = true;
            LblRoleVal.BackColor = Color.Transparent;
            LblRoleVal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblRoleVal.ForeColor = Color.SeaGreen;
            LblRoleVal.Location = new Point(30, 140);
            LblRoleVal.Name = "LblRoleVal";
            LblRoleVal.Size = new Size(54, 28);
            LblRoleVal.TabIndex = 5;
            LblRoleVal.Text = "Role";
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.BackColor = Color.Transparent;
            LblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblUsername.ForeColor = Color.DimGray;
            LblUsername.Location = new Point(30, 185);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(89, 23);
            LblUsername.TabIndex = 6;
            LblUsername.Text = "Username";
            // 
            // LblUsernameVal
            // 
            LblUsernameVal.AutoSize = true;
            LblUsernameVal.BackColor = Color.Transparent;
            LblUsernameVal.Font = new Font("Segoe UI", 12F);
            LblUsernameVal.ForeColor = Color.Black;
            LblUsernameVal.Location = new Point(30, 210);
            LblUsernameVal.Name = "LblUsernameVal";
            LblUsernameVal.Size = new Size(99, 28);
            LblUsernameVal.TabIndex = 7;
            LblUsernameVal.Text = "Username";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.BackColor = Color.Transparent;
            LblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblEmail.ForeColor = Color.DimGray;
            LblEmail.Location = new Point(350, 185);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(54, 23);
            LblEmail.TabIndex = 8;
            LblEmail.Text = "Email";
            // 
            // LblEmailVal
            // 
            LblEmailVal.AutoSize = true;
            LblEmailVal.BackColor = Color.Transparent;
            LblEmailVal.Font = new Font("Segoe UI", 12F);
            LblEmailVal.ForeColor = Color.Black;
            LblEmailVal.Location = new Point(350, 210);
            LblEmailVal.Name = "LblEmailVal";
            LblEmailVal.Size = new Size(59, 28);
            LblEmailVal.TabIndex = 9;
            LblEmailVal.Text = "Email";
            // 
            // LblNoHP
            // 
            LblNoHP.AutoSize = true;
            LblNoHP.BackColor = Color.Transparent;
            LblNoHP.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblNoHP.ForeColor = Color.DimGray;
            LblNoHP.Location = new Point(30, 255);
            LblNoHP.Name = "LblNoHP";
            LblNoHP.Size = new Size(61, 23);
            LblNoHP.TabIndex = 10;
            LblNoHP.Text = "No HP";
            // 
            // LblNoHPVal
            // 
            LblNoHPVal.AutoSize = true;
            LblNoHPVal.BackColor = Color.Transparent;
            LblNoHPVal.Font = new Font("Segoe UI", 12F);
            LblNoHPVal.ForeColor = Color.Black;
            LblNoHPVal.Location = new Point(30, 280);
            LblNoHPVal.Name = "LblNoHPVal";
            LblNoHPVal.Size = new Size(69, 28);
            LblNoHPVal.TabIndex = 11;
            LblNoHPVal.Text = "No HP";
            // 
            // LblAlamat
            // 
            LblAlamat.AutoSize = true;
            LblAlamat.BackColor = Color.Transparent;
            LblAlamat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblAlamat.ForeColor = Color.DimGray;
            LblAlamat.Location = new Point(350, 255);
            LblAlamat.Name = "LblAlamat";
            LblAlamat.Size = new Size(68, 23);
            LblAlamat.TabIndex = 12;
            LblAlamat.Text = "Alamat";
            // 
            // LblAlamatVal
            // 
            LblAlamatVal.AutoSize = true;
            LblAlamatVal.BackColor = Color.Transparent;
            LblAlamatVal.Font = new Font("Segoe UI", 12F);
            LblAlamatVal.ForeColor = Color.Black;
            LblAlamatVal.Location = new Point(350, 280);
            LblAlamatVal.Name = "LblAlamatVal";
            LblAlamatVal.Size = new Size(74, 28);
            LblAlamatVal.TabIndex = 13;
            LblAlamatVal.Text = "Alamat";
            // 
            // TxtNama
            // 
            TxtNama.Font = new Font("Segoe UI", 12F);
            TxtNama.Location = new Point(350, 68);
            TxtNama.Name = "TxtNama";
            TxtNama.Size = new Size(300, 34);
            TxtNama.TabIndex = 14;
            TxtNama.Visible = false;
            // 
            // TxtUsername
            // 
            TxtUsername.Font = new Font("Segoe UI", 12F);
            TxtUsername.Location = new Point(30, 208);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(280, 34);
            TxtUsername.TabIndex = 15;
            TxtUsername.Visible = false;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Segoe UI", 12F);
            TxtEmail.Location = new Point(350, 208);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(300, 34);
            TxtEmail.TabIndex = 16;
            TxtEmail.Visible = false;
            // 
            // TxtNoHP
            // 
            TxtNoHP.Font = new Font("Segoe UI", 12F);
            TxtNoHP.Location = new Point(30, 278);
            TxtNoHP.Name = "TxtNoHP";
            TxtNoHP.Size = new Size(280, 34);
            TxtNoHP.TabIndex = 17;
            TxtNoHP.Visible = false;
            // 
            // TxtAlamat
            // 
            TxtAlamat.Font = new Font("Segoe UI", 12F);
            TxtAlamat.Location = new Point(350, 278);
            TxtAlamat.Name = "TxtAlamat";
            TxtAlamat.Size = new Size(300, 34);
            TxtAlamat.TabIndex = 18;
            TxtAlamat.Visible = false;
            // 
            // Btn_Logout
            // 
            Btn_Logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Logout.BackColor = Color.IndianRed;
            Btn_Logout.Cursor = Cursors.Hand;
            Btn_Logout.FlatAppearance.BorderSize = 0;
            Btn_Logout.FlatStyle = FlatStyle.Flat;
            Btn_Logout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Logout.ForeColor = Color.White;
            Btn_Logout.Location = new Point(590, 500);
            Btn_Logout.Name = "Btn_Logout";
            Btn_Logout.Size = new Size(165, 48);
            Btn_Logout.TabIndex = 10;
            Btn_Logout.Text = "Logout";
            Btn_Logout.UseVisualStyleBackColor = false;
            Btn_Logout.Click += Btn_Logout_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_Edit.BackColor = Color.SeaGreen;
            Btn_Edit.Cursor = Cursors.Hand;
            Btn_Edit.FlatAppearance.BorderSize = 0;
            Btn_Edit.FlatStyle = FlatStyle.Flat;
            Btn_Edit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Btn_Edit.ForeColor = Color.White;
            Btn_Edit.Location = new Point(410, 500);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(165, 48);
            Btn_Edit.TabIndex = 11;
            Btn_Edit.Text = "Edit Profil";
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Kembali
            // 
            Btn_Kembali.BackColor = Color.Transparent;
            Btn_Kembali.BackgroundImage = (Image)resources.GetObject("Btn_Kembali.BackgroundImage");
            Btn_Kembali.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Kembali.Location = new Point(5, 12);
            Btn_Kembali.Name = "Btn_Kembali";
            Btn_Kembali.Size = new Size(40, 40);
            Btn_Kembali.TabIndex = 99;
            Btn_Kembali.UseVisualStyleBackColor = false;
            Btn_Kembali.Click += Btn_Kembali_Click;
            // 
            // FormProfil
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 570);
            Controls.Add(Btn_Kembali);
            Controls.Add(Btn_Logout);
            Controls.Add(Btn_Edit);
            Controls.Add(GrpInfo);
            Controls.Add(LblJudul);
            Font = new Font("Segoe UI", 10F);
            Name = "FormProfil";
            Text = "Profil";
            WindowState = FormWindowState.Maximized;
            GrpInfo.ResumeLayout(false);
            GrpInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblJudul;
        private GroupBox GrpInfo;
        private Label LblIdUser;
        private Label LblIdUserVal;
        private Label LblNama;
        private Label LblNamaVal;
        private Label LblRole;
        private Label LblRoleVal;
        private Label LblUsername;
        private Label LblUsernameVal;
        private Label LblEmail;
        private Label LblEmailVal;
        private Label LblNoHP;
        private Label LblNoHPVal;
        private Label LblAlamat;
        private Label LblAlamatVal;
        private Button Btn_Edit;
        private TextBox TxtNama;
        private TextBox TxtUsername;
        private TextBox TxtEmail;
        private TextBox TxtNoHP;
        private TextBox TxtAlamat;
        private Button Btn_Logout;
        private Button Btn_Kembali;
    }
}
