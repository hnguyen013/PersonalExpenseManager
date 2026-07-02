using PersonalExpenseManager.DAL;
using PersonalExpenseManager.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace PersonalExpenseManager.Presentation
{
    public partial class frmTransactions : frmMainLayout
    {
        ITransactionDAL transactionDAL = new TransactionDAL();
        ICategoryDAL categoryDAL = new CategoryDAL();
        public frmTransactions()
        {
            InitializeComponent();
            SetupTransactionGrid();
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.MultiSelect = false;
            dgvTransactions.ReadOnly = true;
            btnTransactions.FillColor = Color.FromArgb(239, 196, 85);
            btnTransactions.ForeColor = Color.FromArgb(47, 93, 80);
            LoadData();
            LoadCategoryComboBox();
            dgvTransactions.CellClick += dgvTransactions_CellClick;

            chkIncome.CheckedChanged += FilterChanged;
            chkExpense.CheckedChanged += FilterChanged;

            txtAmount.Enter += TextBox_Enter;
            txtNotes.Enter += TextBox_Enter;

        }
        void LoadData()
        {
            RefreshData();
        }
        private void SetupTransactionGrid()
        {
            dgvTransactions.EnableHeadersVisualStyles = false;

            // Header
            dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTransactions.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvTransactions.ColumnHeadersDefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.ColumnHeadersHeight = 40;


            // Body
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.GridColor = Color.FromArgb(230, 230, 230);

            dgvTransactions.DefaultCellStyle.BackColor = Color.White;
            dgvTransactions.DefaultCellStyle.ForeColor = Color.Black;
            dgvTransactions.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(232, 245, 233);
            dgvTransactions.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvTransactions.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 248, 248);

            dgvTransactions.RowTemplate.Height = 35;

            dgvTransactions.BorderStyle = BorderStyle.None;
            dgvTransactions.RowHeadersVisible = false;

            dgvTransactions.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor;

            dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.White;

            foreach (DataGridViewColumn col in dgvTransactions.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Date (cột 1)
            dgvTransactions.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Type (cột 2)
            dgvTransactions.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Amount (cột 4)
            dgvTransactions.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }
        void RefreshData()
        {
            dgvTransactions.Rows.Clear();

            List<Transaction> list = transactionDAL.ReadAll();

            bool showIncome = chkIncome.Checked;
            bool showExpense = chkExpense.Checked;

            double income = 0;
            double expense = 0;

            foreach (Transaction t in list)
            {
                // Nếu bỏ tick cả 2 thì xem như All
                if (showIncome == false && showExpense == false)
                {
                    // không filter
                }
                else
                {
                    if (t.Type == "Income" && !showIncome)
                        continue;

                    if (t.Type == "Expense" && !showExpense)
                        continue;
                }

                int row = dgvTransactions.Rows.Add(
                    t.Id,
                    t.Date.ToShortDateString(),
                    t.Type,
                    t.Category,
                    t.Amount,
                    t.Notes
                );

                DataGridViewCell amountCell = dgvTransactions.Rows[row].Cells[4];

                if (t.Type == "Income")
                {
                    amountCell.Value = "+" + t.Amount.ToString("N0") + " đ";
                    amountCell.Style.ForeColor = Color.Green;
                    amountCell.Style.SelectionForeColor = Color.Green;
                }
                else
                {
                    amountCell.Value = "-" + t.Amount.ToString("N0") + " đ";
                    amountCell.Style.ForeColor = Color.Red;
                    amountCell.Style.SelectionForeColor = Color.Red;
                }

                if (t.Type == "Income")
                    income += t.Amount;
                else
                    expense += t.Amount;

                amountCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            lblTotalIncome.Text = income.ToString("N0") + " đ";
            lblTotalExpense.Text = expense.ToString("N0") + " đ";
            lblBalance.Text = (income - expense).ToString("N0") + " đ";

        }
        private void FilterChanged(object sender, EventArgs e)
        {
            RefreshData();
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
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvTransactions.Rows[e.RowIndex];

            dtpDate.Value = DateTime.Parse(row.Cells[1].Value.ToString());
            cmbTransactionType.Text = row.Cells[2].Value.ToString();
            cmbCategory.Text = row.Cells[3].Value.ToString();
            txtAmount.Text = row.Cells[4].Value.ToString();
            txtNotes.Text = row.Cells[5].Value.ToString();

        }
        void ResetForm()
        {
            cmbTransactionType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            txtNotes.Clear();
            dtpDate.Value = DateTime.Today;
        }

        string TaoMaTuDong()
        {
            List<Transaction> list = transactionDAL.ReadAll();

            int stt = list.Count + 1;

            return "T" + stt.ToString("000");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbTransactionType.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại giao dịch");
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục");
                return;
            }

            double amount;
            if (double.TryParse(txtAmount.Text, out amount) == false)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ");
                return;
            }

            string id = TaoMaTuDong();
            string type = cmbTransactionType.Text;
            string category = cmbCategory.Text;
            DateTime date = dtpDate.Value;
            string notes = txtNotes.Text;

            Transaction t = new Transaction(id, type, category, amount, date, notes);

            if (transactionDAL.Create(t))
            {
                RefreshData();
                ResetForm();
            }
            else
            {
                MessageBox.Show(transactionDAL.GetError());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần xóa");
                return;
            }

            string id = dgvTransactions.SelectedRows[0].Cells[0].Value.ToString();

            if (transactionDAL.DeleteById(id))
            {
                RefreshData();
                ResetForm();
            }
            else
            {
                MessageBox.Show(transactionDAL.GetError());
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTransactions.Rows[e.RowIndex];

            cmbTransactionType.Text = row.Cells["Type"].Value.ToString();
            cmbCategory.Text = row.Cells["Category"].Value.ToString();

            dtpDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            txtAmount.Text = row.Cells["Amount"].Value.ToString();
            txtNotes.Text = row.Cells["Notes"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow == null)
            {
                MessageBox.Show("Please select a row!");
                return;
            }

            DataGridViewRow row = dgvTransactions.CurrentRow;

            row.Cells["Type"].Value = cmbTransactionType.Text;
            row.Cells["Category"].Value = cmbCategory.Text;
            row.Cells["Date"].Value = dtpDate.Value.ToShortDateString();

            row.Cells["Amount"].Value = txtAmount.Text;
            row.Cells["Notes"].Value = txtNotes.Text;

            MessageBox.Show("Updated successfully!");
        }
        private void LoadCategoryComboBox()
        {
            cmbCategory.Items.Clear();

            foreach (Category c in categoryDAL.ReadAll())
            {
                cmbCategory.Items.Add(c.Name);
            }

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2TextBox tb)
            {
                tb.BeginInvoke(new Action(() => tb.SelectAll()));
            }
        }
    }
}
