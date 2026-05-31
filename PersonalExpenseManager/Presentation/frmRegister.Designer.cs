namespace PersonalExpenseManager.Presentation
{
    partial class frmRegister
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblAlreadyHaveAccount = new System.Windows.Forms.Label();
            this.chkAgree = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dtpDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBackground = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRegisterClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BorderRadius = 22;
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.lblAlreadyHaveAccount);
            this.pnlLogin.Controls.Add(this.chkAgree);
            this.pnlLogin.Controls.Add(this.dtpDateOfBirth);
            this.pnlLogin.Controls.Add(this.lblDateOfBirth);
            this.pnlLogin.Controls.Add(this.lblConfirmPassword);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.lblFullName);
            this.pnlLogin.Controls.Add(this.txtConfirmPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnSignUp);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.txtFullName);
            this.pnlLogin.Controls.Add(this.lblTitle);
            this.pnlLogin.FillColor = System.Drawing.Color.White;
            this.pnlLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlLogin.ForeColor = System.Drawing.Color.FromArgb(58, 45, 40);
            this.pnlLogin.Location = new System.Drawing.Point(195, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(467, 409);
            this.pnlLogin.TabIndex = 4;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);

            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(47, 93, 80);
            this.lblLogin.Location = new System.Drawing.Point(280, 354);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 15);
            this.lblLogin.TabIndex = 17;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);

            // 
            // lblAlreadyHaveAccount
            // 
            this.lblAlreadyHaveAccount.AutoSize = true;
            this.lblAlreadyHaveAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlreadyHaveAccount.ForeColor = System.Drawing.Color.Black;
            this.lblAlreadyHaveAccount.Location = new System.Drawing.Point(120, 354);
            this.lblAlreadyHaveAccount.Name = "lblAlreadyHaveAccount";
            this.lblAlreadyHaveAccount.Size = new System.Drawing.Size(142, 15);
            this.lblAlreadyHaveAccount.TabIndex = 16;
            this.lblAlreadyHaveAccount.Text = "Already have an account?";

            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.CheckedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.chkAgree.CheckedState.BorderRadius = 0;
            this.chkAgree.CheckedState.BorderThickness = 0;
            this.chkAgree.CheckedState.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.chkAgree.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkAgree.Location = new System.Drawing.Point(33, 260);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(229, 19);
            this.chkAgree.TabIndex = 15;
            this.chkAgree.Text = "I agree to the Terms and Privacy Policy";
            this.chkAgree.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(125, 137, 149);
            this.chkAgree.UncheckedState.BorderRadius = 0;
            this.chkAgree.UncheckedState.BorderThickness = 0;
            this.chkAgree.UncheckedState.FillColor = System.Drawing.Color.FromArgb(125, 137, 149);

            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.BorderColor = System.Drawing.Color.Transparent;
            this.dtpDateOfBirth.BorderRadius = 10;
            this.dtpDateOfBirth.Checked = true;
            this.dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.FillColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.FocusedColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(30, 214);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(164, 29);
            this.dtpDateOfBirth.TabIndex = 14;
            this.dtpDateOfBirth.Value = new System.DateTime(2026, 5, 31, 0, 0, 0, 0);

            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.BackColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirth.Location = new System.Drawing.Point(30, 197);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(73, 14);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "Date of Birth";

            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.Location = new System.Drawing.Point(247, 137);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(102, 14);
            this.lblConfirmPassword.TabIndex = 12;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.Click += new System.EventHandler(this.label4_Click);

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(26, 137);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 14);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(247, 77);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 14);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";

            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.White;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(27, 77);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 14);
            this.lblFullName.TabIndex = 9;
            this.lblFullName.Text = "Full Name";

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BorderRadius = 10;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.IconLeft = global::PersonalExpenseManager.Properties.Resources.icon_lockkk1;
            this.txtConfirmPassword.Location = new System.Drawing.Point(250, 154);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "Confirm your password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(164, 29);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.IconLeft = global::PersonalExpenseManager.Properties.Resources.icon_lockkk;
            this.txtPassword.Location = new System.Drawing.Point(29, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(164, 29);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);

            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderRadius = 12;
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(47, 93, 80);
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(20, 296);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(403, 45);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);

            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.IconLeft = global::PersonalExpenseManager.Properties.Resources.icon_user2;
            this.txtUsername.Location = new System.Drawing.Point(250, 94);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Enter your username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(164, 29);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.UseSystemPasswordChar = false;

            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BorderRadius = 10;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.IconLeft = global::PersonalExpenseManager.Properties.Resources.icon_user1;
            this.txtFullName.Location = new System.Drawing.Point(29, 94);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "Enter your full name";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(164, 29);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.UseSystemPasswordChar = false;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(58, 45, 40);
            this.lblTitle.Location = new System.Drawing.Point(22, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create Account";

            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.ImageRotate = 0F;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Margin = new System.Windows.Forms.Padding(2);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(662, 409);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 6;
            this.picBackground.TabStop = false;
            this.picBackground.Click += new System.EventHandler(this.picBackground_Click);

            // 
            // btnRegisterClose
            // 
            this.btnRegisterClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterClose.FillColor = System.Drawing.Color.IndianRed;
            this.btnRegisterClose.IconColor = System.Drawing.Color.White;
            this.btnRegisterClose.Location = new System.Drawing.Point(628, 0);
            this.btnRegisterClose.Name = "btnRegisterClose";
            this.btnRegisterClose.Size = new System.Drawing.Size(34, 24);
            this.btnRegisterClose.TabIndex = 18;

            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 409);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegisterClose);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox picBackground;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDateOfBirth;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblAlreadyHaveAccount;
        private Guna.UI2.WinForms.Guna2CheckBox chkAgree;
        private System.Windows.Forms.Label lblLogin;
        private Guna.UI2.WinForms.Guna2ControlBox btnRegisterClose;
    }
}