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
            SetupDashboardGrid();

            this.Load += frmDashboard_Load;

            btnDashboard.FillColor = Color.FromArgb(239, 196, 85);
            btnDashboard.ForeColor = Color.FromArgb(47, 93, 80);
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
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
                string type = row.Cells["Type"].Value.ToString();

                if (type == "Income")
                {
                    row.Cells["Amount"].Style.ForeColor = Color.FromArgb(46, 125, 50); // xanh lá
                }
                else if (type == "Expense")
                {
                    row.Cells["Amount"].Style.ForeColor = Color.FromArgb(211, 47, 47); // đỏ
                }

                row.Cells["Amount"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
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
        private void SetupDashboardGrid()
        {
            dgvRecentTransactions.EnableHeadersVisualStyles = false;

            // Header — style giống hệt bảng Transactions
            dgvRecentTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvRecentTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRecentTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRecentTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRecentTransactions.ColumnHeadersHeight = 40;
            dgvRecentTransactions.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvRecentTransactions.ColumnHeadersDefaultCellStyle.BackColor;
            dgvRecentTransactions.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // Body
            dgvRecentTransactions.BackgroundColor = Color.White;
            dgvRecentTransactions.GridColor = Color.FromArgb(230, 230, 230);

            dgvRecentTransactions.DefaultCellStyle.BackColor = Color.White;
            dgvRecentTransactions.DefaultCellStyle.ForeColor = Color.Black;
            dgvRecentTransactions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dgvRecentTransactions.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvRecentTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgvRecentTransactions.RowTemplate.Height = 35;

            dgvRecentTransactions.BorderStyle = BorderStyle.None;
            dgvRecentTransactions.RowHeadersVisible = false;
            dgvRecentTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn col in dgvRecentTransactions.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Date (cột 0)
            dgvRecentTransactions.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Description (cột 1)
            dgvRecentTransactions.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Category (cột 2)
            dgvRecentTransactions.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Type (cột 3)
            dgvRecentTransactions.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Amount (cột 4)
            dgvRecentTransactions.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void pnlIncome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
