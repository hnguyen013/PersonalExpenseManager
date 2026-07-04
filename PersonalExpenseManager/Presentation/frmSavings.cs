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
using PersonalExpenseManager.DAL;
using PersonalExpenseManager.Entity;
using System.Globalization;

namespace PersonalExpenseManager
{
    public partial class frmSavings : frmMainLayout
    {
        SavingDAL savingDAL = new SavingDAL();
        ITransactionDAL transactionDAL = new TransactionDAL();
        string selectedId = "";
        double oldSavedAmount = 0;
        private const string SAVINGS_CATEGORY_ID = "CAT010";

        public frmSavings()
        {
            InitializeComponent();

            SetupSavingsGrid();

            dgvSavings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSavings.MultiSelect = false;
            dgvSavings.ReadOnly = true;

            btnSavings.FillColor = Color.FromArgb(239, 196, 85);
            btnSavings.ForeColor = Color.FromArgb(47, 93, 80);

            chkInProgress.CheckedChanged += FilterChanged;
            chkCompleted.CheckedChanged += FilterChanged;
        }
        private void FilterChanged(object sender, EventArgs e)
        {
            LoadSavings();
        }
        private void SetupSavingsGrid()
        {
            dgvSavings.AllowUserToAddRows = false;
            dgvSavings.EnableHeadersVisualStyles = false;

            // Header
            dgvSavings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvSavings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSavings.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSavings.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSavings.ColumnHeadersHeight = 40;

            // Body
            dgvSavings.BackgroundColor = Color.White;
            dgvSavings.GridColor = Color.FromArgb(230, 230, 230);

            dgvSavings.DefaultCellStyle.BackColor = Color.White;
            dgvSavings.DefaultCellStyle.ForeColor = Color.Black;
            dgvSavings.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 245, 233);
            dgvSavings.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvSavings.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgvSavings.RowTemplate.Height = 35;

            dgvSavings.BorderStyle = BorderStyle.None;
            dgvSavings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSavings.RowHeadersVisible = false;

            dgvSavings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSavings.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvSavings.ColumnHeadersDefaultCellStyle.BackColor;
            dgvSavings.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            foreach (DataGridViewColumn col in dgvSavings.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Căn giữa ID
            dgvSavings.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Goal Name căn trái
            dgvSavings.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // TargetAmount căn phải
            dgvSavings.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Saved Amount căn phải
            dgvSavings.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Progress căn phải
            dgvSavings.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Target Date căn phải
            dgvSavings.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Status căn giữa
            dgvSavings.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frmSavings_Load(object sender, EventArgs e)
        {
            LoadSavings();
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGoalName_TextChanged(object sender, EventArgs e)
        {
        }

        private void LoadSavings()
        {
            dgvSavings.Rows.Clear();

            double totalTarget = 0;
            double totalSaved = 0;

            bool showInProgress = chkInProgress.Checked;
            bool showCompleted = chkCompleted.Checked;

            foreach (Saving s in savingDAL.ReadAll())
            {
                if (showInProgress == false && showCompleted == false)
                {
                    // Bỏ tích cả 2 -> hiển thị tất cả
                }
                else
                {
                    if (s.Status == "In Progress" && !showInProgress)
                        continue;

                    if (s.Status == "Completed" && !showCompleted)
                        continue;
                }

                double progress = 0;

                if (s.TargetAmount > 0)
                    progress = s.SavedAmount / s.TargetAmount * 100;

                int rowIndex = dgvSavings.Rows.Add(
                    s.Id,
                    s.GoalName,
                    s.TargetAmount.ToString("N0") + " đ",
                    s.SavedAmount.ToString("N0") + " đ",
                    progress.ToString("0") + "%",
                    s.TargetDate.ToString("dd/MM/yyyy"),
                    s.Status
                );
                if (s.Status == "In Progress")
                {
                    dgvSavings.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = Color.Red;
                }
                else if (s.Status == "Completed")
                {
                    dgvSavings.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = Color.Blue;
                }

                dgvSavings.Rows[rowIndex].Cells["colStatus"].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                totalTarget += s.TargetAmount;
                totalSaved += s.SavedAmount;
            }

            lblNumGoals.Text = dgvSavings.Rows.Count.ToString();
            lblTotalTargetAmount.Text = totalTarget.ToString("N0") + " đ";
            lblTotalSavedAmount.Text = totalSaved.ToString("N0") + " đ";
            lblRemainingAmount.Text = (totalTarget - totalSaved).ToString("N0") + " đ";
        }

        private void ClearInput()
        {
            selectedId = "";
            oldSavedAmount = 0;
            txtGoalName.Clear();
            txtTargetAmount.Text = "0";
            txtInitialAmount.Text = "0";
            txtNotes.Clear();
            dtpTargetDate.Value = DateTime.Now;
        }

        private string GetStatus(double saved, double target)
        {
            if (saved >= target)
                return "Completed";

            return "In Progress";
        }

        private string TaoMaGiaoDich()
        {
            List<Transaction> list = transactionDAL.ReadAll();
            int stt = list.Count + 1;
            return "T" + stt.ToString("000");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtGoalName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter goal name");
                return;
            }

            if (!double.TryParse(txtTargetAmount.Text, out double targetAmount))
            {
                MessageBox.Show("Please enter a valid target amount");
                return;
            }

            if (!double.TryParse(txtInitialAmount.Text, out double savedAmount))
            {
                MessageBox.Show("Please enter a valid initial amount");
                return;
            }

            Saving s = new Saving(
                savingDAL.GetNextId(),
                txtGoalName.Text,
                targetAmount,
                savedAmount,
                dtpTargetDate.Value,
                txtNotes.Text,
                GetStatus(savedAmount, targetAmount)
            );

            if (savingDAL.Create(s))
            {
                if (savedAmount > 0)
                {
                    Transaction t = new Transaction(
                        TaoMaGiaoDich(),
                        "Expense",
                        SAVINGS_CATEGORY_ID,
                        savedAmount,
                        DateTime.Now,
                        "Initial deposit for savings goal: " + s.GoalName
                    );
                    transactionDAL.Create(t);
                }

                // Đã xóa bỏ MessageBox thông báo "Add saving goal successfully"
                LoadSavings();
                ClearInput();
            }
            else
            {
                MessageBox.Show(savingDAL.GetError());
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSavings.Rows[e.RowIndex];

            selectedId = row.Cells[0].Value.ToString();
            txtGoalName.Text = row.Cells[1].Value.ToString();
            txtTargetAmount.Text = row.Cells[2].Value.ToString();
            txtInitialAmount.Text = row.Cells[3].Value.ToString();
            dtpTargetDate.Value = Convert.ToDateTime(row.Cells[5].Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Please select a saving goal to edit");
                return;
            }

            double targetAmount = Convert.ToDouble(txtTargetAmount.Text);
            double savedAmount = Convert.ToDouble(txtInitialAmount.Text);

            Saving s = new Saving(
                selectedId,
                txtGoalName.Text,
                targetAmount,
                savedAmount,
                dtpTargetDate.Value,
                txtNotes.Text,
                GetStatus(savedAmount, targetAmount)
            );

            if (savingDAL.Update(s))
            {
                double delta = savedAmount - oldSavedAmount;

                if (delta > 0)
                {
                    Transaction t = new Transaction(
                        TaoMaGiaoDich(),
                        "Expense",
                        SAVINGS_CATEGORY_ID,
                        delta,
                        DateTime.Now,
                        "Additional deposit for savings goal: " + s.GoalName
                    );
                    transactionDAL.Create(t);
                }

                // Đã xóa bỏ MessageBox thông báo "Edit saving goal successfully"
                LoadSavings();
                ClearInput();
            }
            else
            {
                MessageBox.Show(savingDAL.GetError());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Please select a saving goal to delete");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this saving goal?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                if (savingDAL.DeleteById(selectedId))
                {
                    // Đã xóa bỏ MessageBox thông báo "Delete saving goal successfully"
                    LoadSavings();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show(savingDAL.GetError());
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dgvSavings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSavings.Rows[e.RowIndex].IsNewRow)
                return;

            DataGridViewRow row = dgvSavings.Rows[e.RowIndex];

            selectedId = row.Cells[0].Value.ToString();

            // Lấy dữ liệu GỐC (số thô, chưa format) từ Database, thay vì đọc từ ô bảng đã format sẵn
            Saving s = savingDAL.ReadById(selectedId);

            if (s == null)
                return;

            txtGoalName.Text = s.GoalName;
            txtTargetAmount.Text = s.TargetAmount.ToString();
            txtInitialAmount.Text = s.SavedAmount.ToString();
            oldSavedAmount = s.SavedAmount;

            dtpTargetDate.Value = s.TargetDate;

            txtNotes.Text = "";
        }
    }
}