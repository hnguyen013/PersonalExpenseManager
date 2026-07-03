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
            btnSavings.FillColor = Color.FromArgb(239, 196, 85);
            btnSavings.ForeColor = Color.FromArgb(47, 93, 80);
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

            foreach (Saving s in savingDAL.ReadAll())
            {
                double progress = 0;

                if (s.TargetAmount > 0)
                    progress = s.SavedAmount / s.TargetAmount * 100;

                dgvSavings.Rows.Add(
                    s.Id,
                    s.GoalName,
                    s.TargetAmount,
                    s.SavedAmount,
                    progress.ToString("0") + "%",
                    s.TargetDate.ToString("dd/MM/yyyy"),
                    s.Status
                );

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

            double targetAmount = Convert.ToDouble(txtTargetAmount.Text);
            double savedAmount = Convert.ToDouble(txtInitialAmount.Text);

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

                MessageBox.Show("Add saving goal successfully");
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

                MessageBox.Show("Edit saving goal successfully");
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
                    MessageBox.Show("Delete saving goal successfully");
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

            DataGridViewRow row = dgvSavings.Rows[e.RowIndex];

            selectedId = row.Cells[0].Value.ToString();
            txtGoalName.Text = row.Cells[1].Value.ToString();
            txtTargetAmount.Text = row.Cells[2].Value.ToString();
            txtInitialAmount.Text = row.Cells[3].Value.ToString();
            oldSavedAmount = Convert.ToDouble(row.Cells[3].Value);


            string dateText = row.Cells[5].Value.ToString();

            DateTime date;
            if (DateTime.TryParseExact(dateText, "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date))
            {
                dtpTargetDate.Value = date;
            }

            txtNotes.Text = "";
        }
    }
}
