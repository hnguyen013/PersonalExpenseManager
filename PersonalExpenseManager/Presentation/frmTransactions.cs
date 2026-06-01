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
    public partial class pnlContent : frmMainLayout
    {
        public pnlContent()
        {
            InitializeComponent();

            btnTransactions.FillColor = Color.FromArgb(239, 196, 85);
            btnTransactions.ForeColor = Color.FromArgb(47, 93, 80);
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
