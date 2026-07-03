namespace PersonalExpenseManager
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlReportContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlExpenseChart = new Guna.UI2.WinForms.Guna2Panel();
            this.chartExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblExpenseChartTitle = new System.Windows.Forms.Label();
            this.pnlIncomeChart = new Guna.UI2.WinForms.Guna2Panel();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblIncomeChartTitle = new System.Windows.Forms.Label();
            this.pnlSavingsCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSavingsCompare = new System.Windows.Forms.Label();
            this.lblTotalSavings = new System.Windows.Forms.Label();
            this.lblSavingsTitle = new System.Windows.Forms.Label();
            this.picSavings = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlExpenseCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblExpenseCompare = new System.Windows.Forms.Label();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblExpenseTitle = new System.Windows.Forms.Label();
            this.picExpense = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlIncomeCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblIncomeCompare = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblIncomeTitle = new System.Windows.Forms.Label();
            this.picIncome = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.btnExportReport = new Guna.UI2.WinForms.Guna2Button();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.pnlReportContent.SuspendLayout();
            this.pnlExpenseChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpense)).BeginInit();
            this.pnlIncomeChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            this.pnlSavingsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSavings)).BeginInit();
            this.pnlExpenseCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpense)).BeginInit();
            this.pnlIncomeCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReportContent
            // 
            this.pnlReportContent.BackColor = System.Drawing.Color.White;
            this.pnlReportContent.Controls.Add(this.pnlExpenseChart);
            this.pnlReportContent.Controls.Add(this.pnlIncomeChart);
            this.pnlReportContent.Controls.Add(this.pnlSavingsCard);
            this.pnlReportContent.Controls.Add(this.pnlExpenseCard);
            this.pnlReportContent.Controls.Add(this.pnlIncomeCard);
            this.pnlReportContent.Controls.Add(this.lblDateFrom);
            this.pnlReportContent.Controls.Add(this.lblReportTitle);
            this.pnlReportContent.Controls.Add(this.btnExportReport);
            this.pnlReportContent.Controls.Add(this.dtpTo);
            this.pnlReportContent.Controls.Add(this.dtpFrom);
            this.pnlReportContent.Controls.Add(this.lblDateTo);
            this.pnlReportContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportContent.Location = new System.Drawing.Point(0, 0);
            this.pnlReportContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReportContent.Name = "pnlReportContent";
            this.pnlReportContent.Size = new System.Drawing.Size(1382, 903);
            this.pnlReportContent.TabIndex = 2;
            this.pnlReportContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReportContent_Paint);
            // 
            // pnlExpenseChart
            // 
            this.pnlExpenseChart.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlExpenseChart.BorderRadius = 12;
            this.pnlExpenseChart.BorderThickness = 1;
            this.pnlExpenseChart.Controls.Add(this.chartExpense);
            this.pnlExpenseChart.Controls.Add(this.lblExpenseChartTitle);
            this.pnlExpenseChart.FillColor = System.Drawing.Color.White;
            this.pnlExpenseChart.Location = new System.Drawing.Point(780, 400);
            this.pnlExpenseChart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlExpenseChart.Name = "pnlExpenseChart";
            this.pnlExpenseChart.Size = new System.Drawing.Size(589, 479);
            this.pnlExpenseChart.TabIndex = 12;
            // 
            // chartExpense
            // 
            chartArea5.Name = "ChartArea1";
            this.chartExpense.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartExpense.Legends.Add(legend5);
            this.chartExpense.Location = new System.Drawing.Point(56, 63);
            this.chartExpense.Margin = new System.Windows.Forms.Padding(4);
            this.chartExpense.Name = "chartExpense";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chartExpense.Series.Add(series5);
            this.chartExpense.Size = new System.Drawing.Size(497, 386);
            this.chartExpense.TabIndex = 2;
            this.chartExpense.Text = "chart2";
            // 
            // lblExpenseChartTitle
            // 
            this.lblExpenseChartTitle.AutoSize = true;
            this.lblExpenseChartTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExpenseChartTitle.Location = new System.Drawing.Point(214, 23);
            this.lblExpenseChartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenseChartTitle.Name = "lblExpenseChartTitle";
            this.lblExpenseChartTitle.Size = new System.Drawing.Size(155, 20);
            this.lblExpenseChartTitle.TabIndex = 0;
            this.lblExpenseChartTitle.Text = "Expense by Category";
            this.lblExpenseChartTitle.Click += new System.EventHandler(this.lblExpenseChartTitle_Click);
            // 
            // pnlIncomeChart
            // 
            this.pnlIncomeChart.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlIncomeChart.BorderRadius = 12;
            this.pnlIncomeChart.BorderThickness = 1;
            this.pnlIncomeChart.Controls.Add(this.chartIncome);
            this.pnlIncomeChart.Controls.Add(this.lblIncomeChartTitle);
            this.pnlIncomeChart.FillColor = System.Drawing.Color.White;
            this.pnlIncomeChart.Location = new System.Drawing.Point(224, 400);
            this.pnlIncomeChart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlIncomeChart.Name = "pnlIncomeChart";
            this.pnlIncomeChart.Size = new System.Drawing.Size(548, 479);
            this.pnlIncomeChart.TabIndex = 11;
            // 
            // chartIncome
            // 
            chartArea6.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartIncome.Legends.Add(legend6);
            this.chartIncome.Location = new System.Drawing.Point(21, 63);
            this.chartIncome.Margin = new System.Windows.Forms.Padding(4);
            this.chartIncome.Name = "chartIncome";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.YValuesPerPoint = 2;
            this.chartIncome.Series.Add(series6);
            this.chartIncome.Size = new System.Drawing.Size(497, 386);
            this.chartIncome.TabIndex = 3;
            this.chartIncome.Text = "chart1";
            // 
            // lblIncomeChartTitle
            // 
            this.lblIncomeChartTitle.AutoSize = true;
            this.lblIncomeChartTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIncomeChartTitle.Location = new System.Drawing.Point(157, 23);
            this.lblIncomeChartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomeChartTitle.Name = "lblIncomeChartTitle";
            this.lblIncomeChartTitle.Size = new System.Drawing.Size(150, 20);
            this.lblIncomeChartTitle.TabIndex = 0;
            this.lblIncomeChartTitle.Text = "Income by Category";
            // 
            // pnlSavingsCard
            // 
            this.pnlSavingsCard.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlSavingsCard.BorderRadius = 12;
            this.pnlSavingsCard.BorderThickness = 1;
            this.pnlSavingsCard.Controls.Add(this.lblSavingsCompare);
            this.pnlSavingsCard.Controls.Add(this.lblTotalSavings);
            this.pnlSavingsCard.Controls.Add(this.lblSavingsTitle);
            this.pnlSavingsCard.Controls.Add(this.picSavings);
            this.pnlSavingsCard.FillColor = System.Drawing.Color.White;
            this.pnlSavingsCard.Location = new System.Drawing.Point(997, 240);
            this.pnlSavingsCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSavingsCard.Name = "pnlSavingsCard";
            this.pnlSavingsCard.Size = new System.Drawing.Size(372, 121);
            this.pnlSavingsCard.TabIndex = 10;
            // 
            // lblSavingsCompare
            // 
            this.lblSavingsCompare.AutoSize = true;
            this.lblSavingsCompare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSavingsCompare.Location = new System.Drawing.Point(113, 81);
            this.lblSavingsCompare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavingsCompare.Name = "lblSavingsCompare";
            this.lblSavingsCompare.Size = new System.Drawing.Size(141, 20);
            this.lblSavingsCompare.TabIndex = 3;
            this.lblSavingsCompare.Text = "+0% vs last month";
            this.lblSavingsCompare.Click += new System.EventHandler(this.lblSavingsCompare_Click);
            // 
            // lblTotalSavings
            // 
            this.lblTotalSavings.AutoSize = true;
            this.lblTotalSavings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalSavings.Location = new System.Drawing.Point(113, 44);
            this.lblTotalSavings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSavings.Name = "lblTotalSavings";
            this.lblTotalSavings.Size = new System.Drawing.Size(50, 32);
            this.lblTotalSavings.TabIndex = 2;
            this.lblTotalSavings.Text = "0 đ";
            this.lblTotalSavings.Click += new System.EventHandler(this.lblTotalSavings_Click);
            // 
            // lblSavingsTitle
            // 
            this.lblSavingsTitle.AutoSize = true;
            this.lblSavingsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSavingsTitle.Location = new System.Drawing.Point(113, 20);
            this.lblSavingsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavingsTitle.Name = "lblSavingsTitle";
            this.lblSavingsTitle.Size = new System.Drawing.Size(62, 20);
            this.lblSavingsTitle.TabIndex = 1;
            this.lblSavingsTitle.Text = "Savings";
            this.lblSavingsTitle.Click += new System.EventHandler(this.lblSavingsTitle_Click);
            // 
            // picSavings
            // 
            this.picSavings.Image = global::PersonalExpenseManager.Properties.Resources.save;
            this.picSavings.ImageRotate = 0F;
            this.picSavings.Location = new System.Drawing.Point(4, 4);
            this.picSavings.Margin = new System.Windows.Forms.Padding(4);
            this.picSavings.Name = "picSavings";
            this.picSavings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picSavings.Size = new System.Drawing.Size(101, 113);
            this.picSavings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSavings.TabIndex = 0;
            this.picSavings.TabStop = false;
            // 
            // pnlExpenseCard
            // 
            this.pnlExpenseCard.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlExpenseCard.BorderRadius = 12;
            this.pnlExpenseCard.BorderThickness = 1;
            this.pnlExpenseCard.Controls.Add(this.lblExpenseCompare);
            this.pnlExpenseCard.Controls.Add(this.lblTotalExpense);
            this.pnlExpenseCard.Controls.Add(this.lblExpenseTitle);
            this.pnlExpenseCard.Controls.Add(this.picExpense);
            this.pnlExpenseCard.FillColor = System.Drawing.Color.White;
            this.pnlExpenseCard.Location = new System.Drawing.Point(608, 236);
            this.pnlExpenseCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlExpenseCard.Name = "pnlExpenseCard";
            this.pnlExpenseCard.Size = new System.Drawing.Size(372, 121);
            this.pnlExpenseCard.TabIndex = 10;
            // 
            // lblExpenseCompare
            // 
            this.lblExpenseCompare.AutoSize = true;
            this.lblExpenseCompare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExpenseCompare.Location = new System.Drawing.Point(113, 81);
            this.lblExpenseCompare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenseCompare.Name = "lblExpenseCompare";
            this.lblExpenseCompare.Size = new System.Drawing.Size(136, 20);
            this.lblExpenseCompare.TabIndex = 3;
            this.lblExpenseCompare.Text = "-0% vs last month";
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalExpense.Location = new System.Drawing.Point(113, 44);
            this.lblTotalExpense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(50, 32);
            this.lblTotalExpense.TabIndex = 2;
            this.lblTotalExpense.Text = "0 đ";
            // 
            // lblExpenseTitle
            // 
            this.lblExpenseTitle.AutoSize = true;
            this.lblExpenseTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExpenseTitle.Location = new System.Drawing.Point(113, 20);
            this.lblExpenseTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpenseTitle.Name = "lblExpenseTitle";
            this.lblExpenseTitle.Size = new System.Drawing.Size(105, 20);
            this.lblExpenseTitle.TabIndex = 1;
            this.lblExpenseTitle.Text = "Total Expense";
            this.lblExpenseTitle.Click += new System.EventHandler(this.lblExpenseTitle_Click);
            // 
            // picExpense
            // 
            this.picExpense.Image = global::PersonalExpenseManager.Properties.Resources._6085552d_cdbd_475a_8d56_647ad5bedcd1;
            this.picExpense.ImageRotate = 0F;
            this.picExpense.Location = new System.Drawing.Point(4, 4);
            this.picExpense.Margin = new System.Windows.Forms.Padding(4);
            this.picExpense.Name = "picExpense";
            this.picExpense.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picExpense.Size = new System.Drawing.Size(101, 113);
            this.picExpense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExpense.TabIndex = 0;
            this.picExpense.TabStop = false;
            // 
            // pnlIncomeCard
            // 
            this.pnlIncomeCard.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlIncomeCard.BorderRadius = 12;
            this.pnlIncomeCard.BorderThickness = 1;
            this.pnlIncomeCard.Controls.Add(this.lblIncomeCompare);
            this.pnlIncomeCard.Controls.Add(this.lblTotalIncome);
            this.pnlIncomeCard.Controls.Add(this.lblIncomeTitle);
            this.pnlIncomeCard.Controls.Add(this.picIncome);
            this.pnlIncomeCard.FillColor = System.Drawing.Color.White;
            this.pnlIncomeCard.Location = new System.Drawing.Point(225, 236);
            this.pnlIncomeCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlIncomeCard.Name = "pnlIncomeCard";
            this.pnlIncomeCard.Size = new System.Drawing.Size(372, 121);
            this.pnlIncomeCard.TabIndex = 9;
            // 
            // lblIncomeCompare
            // 
            this.lblIncomeCompare.AutoSize = true;
            this.lblIncomeCompare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIncomeCompare.Location = new System.Drawing.Point(113, 81);
            this.lblIncomeCompare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomeCompare.Name = "lblIncomeCompare";
            this.lblIncomeCompare.Size = new System.Drawing.Size(141, 20);
            this.lblIncomeCompare.TabIndex = 3;
            this.lblIncomeCompare.Text = "+0% vs last month";
            this.lblIncomeCompare.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalIncome.Location = new System.Drawing.Point(113, 44);
            this.lblTotalIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(50, 32);
            this.lblTotalIncome.TabIndex = 2;
            this.lblTotalIncome.Text = "0 đ";
            // 
            // lblIncomeTitle
            // 
            this.lblIncomeTitle.AutoSize = true;
            this.lblIncomeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeTitle.Location = new System.Drawing.Point(113, 20);
            this.lblIncomeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomeTitle.Name = "lblIncomeTitle";
            this.lblIncomeTitle.Size = new System.Drawing.Size(100, 20);
            this.lblIncomeTitle.TabIndex = 1;
            this.lblIncomeTitle.Text = "Total Income";
            this.lblIncomeTitle.Click += new System.EventHandler(this.lblIncomeTitle_Click);
            // 
            // picIncome
            // 
            this.picIncome.Image = global::PersonalExpenseManager.Properties.Resources.de9088b2_eaa8_4842_9b79_9e4b7e101e94;
            this.picIncome.ImageRotate = 0F;
            this.picIncome.Location = new System.Drawing.Point(4, 4);
            this.picIncome.Margin = new System.Windows.Forms.Padding(4);
            this.picIncome.Name = "picIncome";
            this.picIncome.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picIncome.Size = new System.Drawing.Size(101, 113);
            this.picIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIncome.TabIndex = 0;
            this.picIncome.TabStop = false;
            this.picIncome.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(269, 158);
            this.lblDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(119, 25);
            this.lblDateFrom.TabIndex = 8;
            this.lblDateFrom.Text = "Date From:";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(220, 95);
            this.lblReportTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(105, 29);
            this.lblReportTitle.TabIndex = 7;
            this.lblReportTitle.Text = "Reports";
            // 
            // btnExportReport
            // 
            this.btnExportReport.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnExportReport.BorderRadius = 5;
            this.btnExportReport.BorderThickness = 1;
            this.btnExportReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportReport.FillColor = System.Drawing.Color.White;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReport.ForeColor = System.Drawing.Color.Black;
            this.btnExportReport.Image = global::PersonalExpenseManager.Properties.Resources.in21;
            this.btnExportReport.Location = new System.Drawing.Point(1062, 95);
            this.btnExportReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(307, 77);
            this.btnExportReport.TabIndex = 6;
            this.btnExportReport.Text = "Export report";
            // 
            // dtpTo
            // 
            this.dtpTo.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpTo.BorderRadius = 10;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.White;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(729, 151);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(188, 32);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.Value = new System.DateTime(2026, 6, 4, 21, 16, 0, 287);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BorderColor = System.Drawing.Color.Gainsboro;
            this.dtpFrom.BorderRadius = 10;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.White;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(408, 151);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(189, 32);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.Value = new System.DateTime(2026, 6, 4, 21, 16, 0, 287);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(617, 158);
            this.lblDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(96, 25);
            this.lblDateTo.TabIndex = 3;
            this.lblDateTo.Text = "Date To:";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 903);
            this.Controls.Add(this.pnlReportContent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.pnlReportContent.ResumeLayout(false);
            this.pnlReportContent.PerformLayout();
            this.pnlExpenseChart.ResumeLayout(false);
            this.pnlExpenseChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpense)).EndInit();
            this.pnlIncomeChart.ResumeLayout(false);
            this.pnlIncomeChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            this.pnlSavingsCard.ResumeLayout(false);
            this.pnlSavingsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSavings)).EndInit();
            this.pnlExpenseCard.ResumeLayout(false);
            this.pnlExpenseCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpense)).EndInit();
            this.pnlIncomeCard.ResumeLayout(false);
            this.pnlIncomeCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlReportContent;
        private System.Windows.Forms.Label lblDateTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2Button btnExportReport;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblReportTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlSavingsCard;
        private Guna.UI2.WinForms.Guna2Panel pnlExpenseCard;
        private Guna.UI2.WinForms.Guna2Panel pnlIncomeCard;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picSavings;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picExpense;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picIncome;
        private System.Windows.Forms.Label lblSavingsCompare;
        private System.Windows.Forms.Label lblTotalSavings;
        private System.Windows.Forms.Label lblSavingsTitle;
        private System.Windows.Forms.Label lblExpenseCompare;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblExpenseTitle;
        private System.Windows.Forms.Label lblIncomeCompare;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblIncomeTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlExpenseChart;
        private Guna.UI2.WinForms.Guna2Panel pnlIncomeChart;
        private System.Windows.Forms.Label lblExpenseChartTitle;
        private System.Windows.Forms.Label lblIncomeChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
    }
}