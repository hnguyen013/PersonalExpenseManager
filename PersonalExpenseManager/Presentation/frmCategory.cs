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
    public partial class frmCategory : frmMainLayout
    {
        ICategoryDAL categoryDAL = new CategoryDAL();
        ITransactionDAL transactionDAL = new TransactionDAL();
        string selectedId = "";
        public frmCategory()
        {
            InitializeComponent();
            SetupCategoryGrid();
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;
            dgvCategories.ReadOnly = true;

            btnCategory.FillColor = Color.FromArgb(239, 196, 85);
            btnCategory.ForeColor = Color.FromArgb(47, 93, 80);
            LoadCategories();
            ThongKeThuChi();

            chkIncome.CheckedChanged += FilterChanged;
            chkExpense.CheckedChanged += FilterChanged;
        }
        private void SetupCategoryGrid()
        {
            dgvCategories.EnableHeadersVisualStyles = false;

            // Header (Tiêu đề cột): Căn giữa chữ
            dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvCategories.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategories.ColumnHeadersHeight = 40;

            // Body (Thân lưới dữ liệu)
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.GridColor = Color.FromArgb(230, 230, 230);

            dgvCategories.DefaultCellStyle.BackColor = Color.White;
            dgvCategories.DefaultCellStyle.ForeColor = Color.Black;
            dgvCategories.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dgvCategories.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCategories.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgvCategories.RowTemplate.Height = 35;

            dgvCategories.BorderStyle = BorderStyle.None;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCategories.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvCategories.ColumnHeadersDefaultCellStyle.BackColor;
            dgvCategories.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            foreach (DataGridViewColumn col in dgvCategories.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Thực hiện căn giữa nội dung các cột dữ liệu cụ thể:
            // Cột 0: ID -> Căn giữa
            if (dgvCategories.Columns.Count > 0)
                dgvCategories.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cột 2: Type -> Căn giữa
            if (dgvCategories.Columns.Count > 2)
                dgvCategories.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cột 4: Icon -> Căn giữa
            if (dgvCategories.Columns.Count > 4)
                dgvCategories.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedId = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtCategoryName.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbType.Text = dgvCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbIcon.Text = dgvCategories.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void LoadCategories()
        {
            dgvCategories.Rows.Clear();

            // Lấy trạng thái check giống hệt RefreshData() của Transactions
            bool showIncome = chkIncome.Checked;
            bool showExpense = chkExpense.Checked;

            foreach (Category c in categoryDAL.ReadAll())
            {
                // Áp dụng thuật toán bộ lọc gốc loại trừ (Đã đổi biến t thành c)
                if (showIncome == false && showExpense == false)
                {
                    // Nếu bỏ tích cả hai thì hiển thị tất cả (Không filter)
                }
                else
                {
                    if (c.Type == "Income" && !showIncome)
                        continue;

                    if (c.Type == "Expense" && !showExpense)
                        continue;
                }

                // Thêm dòng mới vào Grid
                int row = dgvCategories.Rows.Add(
                    c.Id,
                    c.Name,
                    c.Type,
                    c.Description,
                    c.Icon
                );

                // TRÍCH XUẤT ĐỔI MÀU: Nhắm trực tiếp vào cột Type (Cột index số 2) để nhuộm màu chữ
                DataGridViewCell typeCell = dgvCategories.Rows[row].Cells[2];

                if (c.Type == "Income")
                {
                    typeCell.Style.ForeColor = Color.Green;
                    typeCell.Style.SelectionForeColor = Color.Green;
                }
                else
                {
                    typeCell.Style.ForeColor = Color.Red;
                    typeCell.Style.SelectionForeColor = Color.Red;
                }

                // Chuyển font chữ ô Type thành Bold đậm cho rõ ràng
                typeCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }

        // TRÍCH XUẤT CHUẨN: Tính tổng số tiền giao dịch đổ lên thẻ thống kê ở Top Form
        private void ThongKeThuChi()
        {
            try
            {
                List<Transaction> list = transactionDAL.ReadAll();
                double income = 0;
                double expense = 0;

                foreach (Transaction t in list)
                {
                    if (t.Type == "Income")
                        income += t.Amount;
                    else
                        expense += t.Amount;
                }

                // Gán chuỗi tiền tệ định dạng "N0" + " đ" lên các Label
                lblTotalIncome.Text = income.ToString("N0") + " đ";
                lblTotalExpense.Text = expense.ToString("N0") + " đ";
                lblBalance.Text = (income - expense).ToString("N0") + " đ";
            }
            catch { }
        }

        // Kích hoạt lại hàm tải lưới khi click đổi bộ lọc
        private void FilterChanged(object sender, EventArgs e)
        {
            LoadCategories();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category c = new Category();

            c.Id = categoryDAL.GenerateID();
            c.Name = txtCategoryName.Text;
            c.Type = cmbType.Text;
            c.Description = txtDescription.Text;
            c.Icon = cmbIcon.Text;

            if (categoryDAL.Create(c))
            {
                MessageBox.Show("Add successful!");

                LoadCategories();
                ResetForm();
                ThongKeThuChi();
            }
            else
            {
                MessageBox.Show(categoryDAL.GetError());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Please select a category!");
                return;
            }

            Category c = new Category();

            c.Id = selectedId;
            c.Name = txtCategoryName.Text;
            c.Type = cmbType.Text;
            c.Description = txtDescription.Text;
            c.Icon = cmbIcon.Text;

            if (categoryDAL.Update(c))
            {
                MessageBox.Show("Update successful!");
                LoadCategories();
                ResetForm();
                ThongKeThuChi();
            }
            else
            {
                MessageBox.Show(categoryDAL.GetError());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Please select a category!");
                return;
            }

            if (categoryDAL.Delete(selectedId))
            {
                MessageBox.Show("Delete successful!");

                LoadCategories();
                ResetForm();
                ThongKeThuChi();
            }
            else
            {
                MessageBox.Show(categoryDAL.GetError());
            }
        }
        private void ResetForm()
        {
            selectedId = "";

            txtCategoryName.Clear();
            txtDescription.Clear();

            cmbType.SelectedIndex = -1;
            cmbIcon.SelectedIndex = -1;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void pnlIncome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbIcon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
