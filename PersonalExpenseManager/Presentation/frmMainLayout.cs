using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalExpenseManager.DAL;


namespace PersonalExpenseManager.Presentation
{
    public partial class frmMainLayout : Form
    {
        public frmMainLayout()
        {
            InitializeComponent();
            this.Load += frmMainLayout_Load;
        }
    private void frmMainLayout_Load(object sender, EventArgs e)
        {
            btnMonth.Text = "Tháng " + DateTime.Now.ToString("MM/yyyy") + "   ˅";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard f = new frmDashboard();
            f.Show();
            this.Hide();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            pnlContent f = new pnlContent();
            f.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory f = new frmCategory();
            f.Show();
            this.Hide();
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            frmBudget f = new frmBudget();
            f.Show();
            this.Hide();
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            frmSavings f = new frmSavings();
            f.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.Show();
            this.Hide();
        }
    }
}
