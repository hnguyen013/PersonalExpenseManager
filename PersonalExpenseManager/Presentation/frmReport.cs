using PersonalExpenseManager.DAL;
using PersonalExpenseManager.Entity;
using PersonalExpenseManager.Presentation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PersonalExpenseManager
{
    public partial class frmReport : frmMainLayout
    {
        ITransactionDAL transactionDAL = new TransactionDAL();
        ICategoryDAL categoryDAL = new CategoryDAL();

        public frmReport()
        {
            InitializeComponent();

            btnReport.FillColor = Color.FromArgb(239, 196, 85);
            btnReport.ForeColor = Color.FromArgb(47, 93, 80);

            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;

            LoadReportData();

            dtpFrom.ValueChanged += Dtp_ValueChanged;
            dtpTo.ValueChanged += Dtp_ValueChanged;
            btnExportReport.Click += BtnExportReport_Click;
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            List<Transaction> transactions = transactionDAL.ReadAll();

            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;

            List<Transaction> filteredList = transactions
                .Where(t => t.Date.Date >= fromDate && t.Date.Date <= toDate)
                .ToList();

            double totalIncome = filteredList
                .Where(t => IsIncome(t.Type))
                .Sum(t => t.Amount);

            double totalExpense = filteredList
                .Where(t => IsExpense(t.Type))
                .Sum(t => t.Amount);

            double savings = totalIncome - totalExpense;

            lblTotalIncome.Text = FormatMoney(totalIncome);
            lblTotalExpense.Text = FormatMoney(totalExpense);
            lblTotalSavings.Text = FormatMoney(savings);

            LoadChart(
                chartIncome,
                filteredList.Where(t => IsIncome(t.Type)).ToList(),
                "Total income"
            );

            LoadChart(
                chartExpense,
                filteredList.Where(t => IsExpense(t.Type)).ToList(),
                "Total expense"
            );
        }

        private void LoadChart(Chart chart, List<Transaction> list, string centerText)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.White;
            chartArea.Area3DStyle.Enable3D = false;
            chart.ChartAreas.Add(chartArea);

            Legend legend = new Legend();
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            chart.Legends.Add(legend);

            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;
            series.ChartArea = chartArea.Name;
            series.Legend = legend.Name;
            series.IsValueShownAsLabel = false;
            series["DoughnutRadius"] = "55";

            var groupData = list
                .GroupBy(t => t.CategoryID)
                .Select(g => new
                {
                    Category = g.Key,
                    Total = g.Sum(t => t.Amount)
                })
                .Where(x => x.Total > 0)
                .ToList();

            if (groupData.Count == 0)
            {
                series.Points.AddXY("No data", 1);
                series.Points[0].Color = Color.LightGray;
                series.Points[0].LegendText = "No data";
            }
            else
            {
                foreach (var item in groupData)
                {
                    int pointIndex = series.Points.AddXY(item.Category, item.Total);
                    series.Points[pointIndex].LegendText =
                        item.Category + " - " + FormatMoney(item.Total);
                }
            }

            chart.Series.Add(series);
        }

        private bool IsIncome(string type)
        {
            if (type == null)
                return false;

            string value = type.ToLower();

            return value.Contains("income")
                || value.Contains("thu");
        }

        private bool IsExpense(string type)
        {
            if (type == null)
                return false;

            string value = type.ToLower();

            return value.Contains("expense")
                || value.Contains("chi");
        }

        private string FormatMoney(double money)
        {
            return money.ToString("#,##0", new CultureInfo("vi-VN")) + " đ";
        }

        private void BtnExportReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file|*.txt";
            saveFileDialog.FileName = "report.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content =
                    "PERSONAL EXPENSE REPORT\n" +
                    "From: " + dtpFrom.Value.ToShortDateString() + "\n" +
                    "To: " + dtpTo.Value.ToShortDateString() + "\n\n" +
                    "Total Income: " + lblTotalIncome.Text + "\n" +
                    "Total Expense: " + lblTotalExpense.Text + "\n" +
                    "Savings: " + lblTotalSavings.Text;

                System.IO.File.WriteAllText(saveFileDialog.FileName, content);

                MessageBox.Show("Export report successfully!");
            }
        }

        private void pnlFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateFrom_Click(object sender, EventArgs e)
        {

        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblExpenseTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSavingsTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalSavings_Click(object sender, EventArgs e)
        {

        }

        private void lblIncomeTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSavingsCompare_Click(object sender, EventArgs e)
        {

        }
    }
}