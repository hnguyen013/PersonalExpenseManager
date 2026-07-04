using System;
using System.Windows.Forms;
using PersonalExpenseManager.DAL;
using PersonalExpenseManager.Entity;

namespace PersonalExpenseManager.Presentation
{
    public partial class frmRegister : Form
    {
        IUserDAL userDAL = new UserDAL();

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Kiểm tra thông tin bỏ trống (Dịch sang tiếng Anh)
            if (fullName == "" || username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all the information!");
                return;
            }

            // Kiểm tra trùng tài khoản (Dịch sang tiếng Anh)
            if (userDAL.IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists!");
                return;
            }

            // Kiểm tra khớp mật khẩu (Dịch sang tiếng Anh)
            if (password != confirmPassword)
            {
                MessageBox.Show("Confirm password does not match!");
                return;
            }

            // Kiểm tra checkbox điều khoản (Dịch sang tiếng Anh)
            if (!chkAgree.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions before registering!");
                return;
            }

            User user = new User(username, password);

            bool result = userDAL.Create(user);

            if (result)
            {
                // Đã xóa bỏ hoàn toàn MessageBox.Show("Đăng ký thành công!") theo yêu cầu

                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                // Thông báo lỗi khi lưu thất bại (Dịch sang tiếng Anh)
                MessageBox.Show("Username already exists!");
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void picBackground_Click(object sender, EventArgs e)
        {
        }
    }
}