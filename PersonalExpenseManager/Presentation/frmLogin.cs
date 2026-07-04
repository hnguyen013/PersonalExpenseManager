using System;
using System.Windows.Forms;
using PersonalExpenseManager.DAL;

namespace PersonalExpenseManager.Presentation
{
    public partial class frmLogin : Form
    {
        IUserDAL userDAL = new UserDAL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra thông tin bỏ trống (Dịch sang tiếng Anh)
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password!");
                return;
            }

            // Kiểm tra logic đăng nhập
            if (userDAL.CheckLogin(username, password))
            {
                // Đã xóa bỏ hoàn toàn MessageBox thông báo đăng nhập thành công theo yêu cầu

                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                // Thông báo sai tài khoản/mật khẩu (Dịch sang tiếng Anh)
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }
    }
}