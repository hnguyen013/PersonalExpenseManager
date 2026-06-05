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
        string selectedBudgetId = "";
        public frmBudget()
        {
            InitializeComponent();
            btnBudget.FillColor = Color.FromArgb(239, 196, 85);
            btnBudget.ForeColor = Color.FromArgb(47, 93, 80);
            this.Load += frmBudget_Load;
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

            foreach (Budget b in budgetDAL.ReadAll())
            {
                double progress = 0;

                if (b.BudgetAmount > 0)
                {
                    progress = b.Spent / b.BudgetAmount * 100;
                }

                dgvButdgets.Rows.Add(
                    b.Id,
                    b.BudgetName,
                    b.Category,
                    b.Spent.ToString("N0"),
                    progress.ToString("0.##") + "%",
                    b.Period
                );
            }

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
                cboCategory.Text,
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
            cboCategory.Text,
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

            cboCategory.Items.Add("Food");
            cboCategory.Items.Add("Transport");
            cboCategory.Items.Add("Shopping");
            cboCategory.Items.Add("Education");
            cboCategory.Items.Add("Health");
            cboCategory.Items.Add("Other");

            LoadBudgets();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvButdgets.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvButdgets.Rows[e.RowIndex];

            selectedBudgetId = row.Cells["colID"].Value.ToString();

            Budget b = budgetDAL.ReadById(selectedBudgetId);

            if (b == null)
            {
                MessageBox.Show("Không tìm thấy budget");
                return;
            }

            txtBudgetName.Text = b.BudgetName;
            txtAmont.Text = b.BudgetAmount.ToString();
            cboCategory.Text = b.Category;
            cmbPeriod.Text = b.Period;
        }
    }
}
