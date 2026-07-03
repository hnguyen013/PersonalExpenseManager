using Guna.UI2.WinForms;
using PersonalExpenseManager.DAL;
using PersonalExpenseManager.Entity;
using PersonalExpenseManager.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseManager
{
    public partial class frmBudget : frmMainLayout
    {
        BudgetDAL budgetDAL = new BudgetDAL();
        ICategoryDAL categoryDAL = new CategoryDAL();
        ITransactionDAL transactionDAL = new TransactionDAL();
        string selectedBudgetId = "";
        public frmBudget()
        {
            InitializeComponent();
            SetupBudgetGrid();
            btnBudget.FillColor = Color.FromArgb(239, 196, 85);
            btnBudget.ForeColor = Color.FromArgb(47, 93, 80);
            this.Load += frmBudget_Load;
            chkDaily.CheckedChanged += FilterChanged;
            chkWeekly.CheckedChanged += FilterChanged;
            chkMonthly.CheckedChanged += FilterChanged;
            chkYearly.CheckedChanged += FilterChanged;
        }
        private void FilterChanged(object sender, EventArgs e)
        {
            LoadBudgets(); // Gọi làm mới lại dữ liệu khi nhấn thay đổi bộ lọc
        }

        private void SetupBudgetGrid()
        {
            dgvButdgets.EnableHeadersVisualStyles = false;

            // 1. Header (Tiêu đề cột): Chữ trắng, nền xanh đậm và CĂN GIỮA TOÀN BỘ
            dgvButdgets.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvButdgets.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvButdgets.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvButdgets.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvButdgets.ColumnHeadersHeight = 40;

            // 2. Body (Thân lưới hiển thị dữ liệu)
            dgvButdgets.BackgroundColor = Color.White;
            dgvButdgets.GridColor = Color.FromArgb(230, 230, 230);

            dgvButdgets.DefaultCellStyle.BackColor = Color.White;
            dgvButdgets.DefaultCellStyle.ForeColor = Color.Black;
            dgvButdgets.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dgvButdgets.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvButdgets.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgvButdgets.RowTemplate.Height = 35;

            dgvButdgets.BorderStyle = BorderStyle.None;
            dgvButdgets.RowHeadersVisible = false;
            dgvButdgets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvButdgets.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvButdgets.ColumnHeadersDefaultCellStyle.BackColor;
            dgvButdgets.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            foreach (DataGridViewColumn col in dgvButdgets.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

                // Mặc định ban đầu cho toàn bộ các cột căn giữa
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // 3. CĂN CHỈNH RIÊNG VỊ TRÍ CHO CÁC CỘT ĐẶC BIỆT
            // Cột Budget Name (Cột thứ 2, index là 1) -> Căn trái
            if (dgvButdgets.Columns.Count > 1)
            {
                dgvButdgets.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            // Cột Spent (Cột thứ 4, index là 3) -> Căn phải
            if (dgvButdgets.Columns.Count > 3)
            {
                dgvButdgets.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvButdgets.Columns.Count > 4)
            {
                dgvButdgets.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
   
        }

        private void RefreshTopStats()
        {
            List<Transaction> listTrans = transactionDAL.ReadAll();
            double income = 0;
            double expense = 0;

            foreach (Transaction t in listTrans)
            {
                if (t.Type == "Income")
                    income += t.Amount;
                else
                    expense += t.Amount;
            }

            lblTotalIncome.Text = income.ToString("N0") + " đ";
            lblTotalExpense.Text = expense.ToString("N0") + " đ";
            lblBalance.Text = (income - expense).ToString("N0") + " đ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void pnlChucNang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadBudgets()
        {
            dgvButdgets.Rows.Clear();

            List<Category> categories = categoryDAL.ReadAll();

            bool showDaily = chkDaily.Checked;
            bool showWeekly = chkWeekly.Checked;
            bool showMonthly = chkMonthly.Checked;
            bool showYearly = chkYearly.Checked;

            foreach (Budget b in budgetDAL.ReadAll())
            {
                if (showDaily == false && showWeekly == false && showMonthly == false && showYearly == false)
                {
                    // Không chặn gì cả, chạy thẳng xuống đoạn add dữ liệu phía dưới
                }
                else
                {
                    // Nếu có nút được tick chọn, loại bỏ các chu kỳ không phù hợp
                    if (b.Period == "Daily" && !showDaily) continue;
                    if (b.Period == "Weekly" && !showWeekly) continue;
                    if (b.Period == "Monthly" && !showMonthly) continue;
                    if (b.Period == "Yearly" && !showYearly) continue;
                }
                double progress = 0;

                if (b.BudgetAmount > 0)
                {
                    progress = b.Spent / b.BudgetAmount * 100;
                }

                Category matchedCategory = categories.FirstOrDefault(c => c.Id == b.CategoryID);
                string categoryName = matchedCategory != null ? matchedCategory.Name : b.CategoryID;

                dgvButdgets.Rows.Add(
                    b.Id,
                    b.BudgetName,
                    categoryName,
                    b.Spent.ToString("N0") + " đ",
                    progress.ToString("0.##") + "%",
                    b.Period
                );
            }
            RefreshTopStats();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBudgetName.Text == "" || txtAmont.Text == "" ||
        cboCategory.Text == "" || cmbPeriod.Text == "")
            {
                MessageBox.Show("Please enter full budget information");
                return;
            }

            double amount;

            if (!double.TryParse(txtAmont.Text, out amount))
            {
                MessageBox.Show("Budget amount must be a number");
                return;
            }

            Budget b = new Budget(
                budgetDAL.GetNextId(),
                txtBudgetName.Text,
                cboCategory.SelectedValue?.ToString(),
                amount,
                0,
                cmbPeriod.Text
            );

            if (budgetDAL.Create(b))
            {
                MessageBox.Show("Add budget successfully");
                LoadBudgets();
                ClearInput();
            }
            else
            {
                MessageBox.Show(budgetDAL.GetError());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedBudgetId == "")
            {
                MessageBox.Show("Please select a budget to edit");
                return;
            }

            if (txtBudgetName.Text == "" || txtAmont.Text == "" ||
                cmbPeriod.Text == "" || cmbPeriod.Text == "")
            {
                MessageBox.Show("Please enter full budget information");
                return;
            }

            double amount;

            if (!double.TryParse(txtAmont.Text, out amount))
            {
                MessageBox.Show("Budget amount must be a number");
                return;
            }

            Budget oldBudget = budgetDAL.ReadById(selectedBudgetId);

            Budget b = new Budget(
            selectedBudgetId,
            txtBudgetName.Text,
            cboCategory.SelectedValue?.ToString(),
            amount,
            oldBudget.Spent,
            cmbPeriod.Text
            );

            if (budgetDAL.Update(b))
            {
                MessageBox.Show("Update budget successfully");
                LoadBudgets();
                ClearInput();
            }
            else
            {
                MessageBox.Show(budgetDAL.GetError());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedBudgetId == "")
            {
                MessageBox.Show("Please select a budget to delete");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this budget?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                if (budgetDAL.DeleteById(selectedBudgetId))
                {
                    MessageBox.Show("Delete budget successfully");
                    LoadBudgets();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show(budgetDAL.GetError());
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (selectedBudgetId == "")
            {
                MessageBox.Show("Please select a budget to reset");
                return;
            }

            if (budgetDAL.ResetSpent(selectedBudgetId))
            {
                MessageBox.Show("Reset budget successfully");
                LoadBudgets();
                ClearInput();
            }
            else
            {
                MessageBox.Show(budgetDAL.GetError());
            }
        }

        private void dgvButdgets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ClearInput()
        {
            selectedBudgetId = "";

            txtBudgetName.Clear();
            txtAmont.Clear();
            cboCategory.SelectedIndex = -1;
            cmbPeriod.SelectedIndex = -1;
        }
        private void frmBudget_Load(object sender, EventArgs e)
        {
            cmbPeriod.Items.Clear();
            cmbPeriod.Items.Add("Daily");
            cmbPeriod.Items.Add("Weekly");
            cmbPeriod.Items.Add("Monthly");
            cmbPeriod.Items.Add("Yearly");

            cboCategory.DataSource = categoryDAL.ReadAll();
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";

            LoadBudgets();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvButdgets.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvButdgets.Rows[e.RowIndex];

            selectedBudgetId = row.Cells["ID"].Value.ToString();


            Budget b = budgetDAL.ReadById(selectedBudgetId);

            if (b == null)
            {
                MessageBox.Show("Không tìm thấy budget");
                return;
            }

            txtBudgetName.Text = b.BudgetName;
            txtAmont.Text = b.BudgetAmount.ToString();
            cboCategory.SelectedValue = b.CategoryID;
            cmbPeriod.Text = b.Period;
        }

        private void chkIncome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblMainTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
