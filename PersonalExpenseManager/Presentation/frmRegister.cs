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

            if (fullName == "" || username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (userDAL.IsUsernameExists(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            if (!chkAgree.Checked)
            {
                MessageBox.Show("Bạn cần đồng ý với điều khoản trước khi đăng ký!");
                return;
            }

            User user = new User(username, password);

            bool result = userDAL.Create(user);

            if (result)
            {
                MessageBox.Show("Đăng ký thành công!");

                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
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