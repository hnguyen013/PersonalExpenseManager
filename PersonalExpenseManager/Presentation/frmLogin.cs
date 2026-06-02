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

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return;
            }

            if (userDAL.CheckLogin(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");

                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
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