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
            ThongKeDanhMuc();

            chkIncome.CheckedChanged += FilterChanged;
            chkExpense.CheckedChanged += FilterChanged;
        }

        private void SetupCategoryGrid()
        {
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.AllowUserToAddRows = false;

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

            // Cột 4: Icon -> Căn trái
            if (dgvCategories.Columns.Count > 4)
                dgvCategories.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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

            bool showIncome = chkIncome.Checked;
            bool showExpense = chkExpense.Checked;

            foreach (Category c in categoryDAL.ReadAll())
            {
                if (showIncome == false && showExpense == false)
                {
                    // Nếu bỏ tích cả hai thì hiển thị tất cả
                }
                else
                {
                    if (c.Type == "Income" && !showIncome)
                        continue;

                    if (c.Type == "Expense" && !showExpense)
                        continue;
                }

                int row = dgvCategories.Rows.Add(
                    c.Id,
                    c.Name,
                    c.Type,
                    c.Description,
                    c.Icon
                );

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

                typeCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }

        // Đếm số lượng danh mục theo loại để đổ lên 3 thẻ thống kê ở Top Form
        private void ThongKeDanhMuc()
        {
            try
            {
                List<Category> list = categoryDAL.ReadAll();

                int totalCategories = list.Count;
                int incomeCategories = list.Count(c => c.Type == "Income");
                int expenseCategories = list.Count(c => c.Type == "Expense");

                // Thẻ 1 (pnlIncome - xanh): số danh mục Thu
                lblTotalIncome.Text = incomeCategories.ToString();
                // Thẻ 2 (pnlExpense - đỏ): số danh mục Chi
                lblTotalExpense.Text = expenseCategories.ToString();
                // Thẻ 3 (pnlBalance - trung tính): tổng số danh mục
                lblBalance.Text = totalCategories.ToString();
            }
            catch { }
        }

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
                // Đã xóa bỏ MessageBox.Show thông báo thành công
                LoadCategories();
                ResetForm();
                ThongKeDanhMuc();
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
                // Đã xóa bỏ MessageBox.Show thông báo thành công
                LoadCategories();
                ResetForm();
                ThongKeDanhMuc();
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
                // Đã xóa bỏ MessageBox.Show thông báo thành công
                LoadCategories();
                ResetForm();
                ThongKeDanhMuc();
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
            // Không sử dụng MessageBox thông báo reset ở đây
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