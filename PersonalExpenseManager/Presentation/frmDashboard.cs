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
using PersonalExpenseManager.Entity;


namespace PersonalExpenseManager.Presentation
{
    public partial class frmDashboard : frmMainLayout
    {
        ITransactionDAL transactionDAL = new TransactionDAL();
        public frmDashboard()
        {
            InitializeComponent();

            this.Load += frmDashboard_Load;

            btnDashboard.FillColor = Color.FromArgb(239, 196, 85);
            btnDashboard.ForeColor = Color.FromArgb(47, 93, 80);
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            btnMonth.Text = DateTime.Now.ToString("MMMM yyyy");
            LoadRecentTransactions();
            FormatAmountColumn();
            LoadDashboardSummary();
        }
        private void LoadRecentTransactions()
        {
            dgvRecentTransactions.Rows.Clear();

            List<Transaction> list = transactionDAL.ReadAll();

            var recentList = list
                .OrderByDescending(t => t.Date)
                .Take(5)
                .ToList();

            foreach (Transaction t in recentList)
            {
                dgvRecentTransactions.Rows.Add(
                    t.Date.ToShortDateString(),
                    t.Notes,
                    t.CategoryID,
                    t.Type,
                    t.Amount.ToString("N0") + " đ"
                );
            }
        }
        private void FormatAmountColumn()
        {
            foreach (DataGridViewRow row in dgvRecentTransactions.Rows)
            {
                string amount = row.Cells["Amount"].Value.ToString();

                if (amount.StartsWith("+"))
                {
                    row.Cells["Amount"].Style.ForeColor = Color.Green;
                }
                else if (amount.StartsWith("-"))
                {
                    row.Cells["Amount"].Style.ForeColor = Color.Red;
                }

                row.Cells["Amount"].Style.Font =
                    new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }
        private void LoadDashboardSummary()
        {
            List<Transaction> list = transactionDAL.ReadAll();

            DateTime now = DateTime.Now;

            var currentMonthData = list
                .Where(t => t.Date.Month == now.Month && t.Date.Year == now.Year)
                .ToList();

            decimal totalIncome = currentMonthData
                .Where(t => t.Type == "Income")
                .Sum(t => (decimal)t.Amount);

            decimal totalExpense = currentMonthData
                .Where(t => t.Type == "Expense")
                .Sum(t => (decimal)t.Amount);

            decimal balance = totalIncome - totalExpense;

            // gán lên UI
            lblTotalIncome.Text = totalIncome.ToString("N0") + " đ";
            lblTotalExpense.Text = totalExpense.ToString("N0") + " đ";
            lblBalance.Text = balance.ToString("N0") + " đ";
        }

        private void pnlIncome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
