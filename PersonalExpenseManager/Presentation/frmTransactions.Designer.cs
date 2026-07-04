namespace PersonalExpenseManager.Presentation
{
    partial class frmTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.chkExpense = new System.Windows.Forms.CheckBox();
            this.chkIncome = new System.Windows.Forms.CheckBox();
            this.pnlBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.imgBalance = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlExpense = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblExpenseTitle = new System.Windows.Forms.Label();
            this.imgExpense = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlIncome = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTotalIncomeTitle = new System.Windows.Forms.Label();
            this.imgIncome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTitleList = new System.Windows.Forms.Label();
            this.pnlChucNanng = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTransactionInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTransactiontype = new System.Windows.Forms.Label();
            this.cmbBudget = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTransactionType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSubTItleInfo = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblcate = new System.Windows.Forms.Label();
            this.lblCatego = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnlContent.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlExpense.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.pnlChucNanng.SuspendLayout();
            this.pnlTransactionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.chkExpense);
            this.pnlContent.Controls.Add(this.chkIncome);
            this.pnlContent.Controls.Add(this.pnlBalance);
            this.pnlContent.Controls.Add(this.pnlExpense);
            this.pnlContent.Controls.Add(this.pnlIncome);
            this.pnlContent.Controls.Add(this.dgvTransactions);
            this.pnlContent.Controls.Add(this.lblSubTitleList);
            this.pnlContent.Controls.Add(this.pnlChucNanng);
            this.pnlContent.Controls.Add(this.pnlTransactionInfo);
            this.pnlContent.Controls.Add(this.lblMainTitle);
            this.pnlContent.Location = new System.Drawing.Point(191, 73);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1193, 834);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chkExpense
            // 
            this.chkExpense.AutoSize = true;
            this.chkExpense.Checked = true;
            this.chkExpense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.chkExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chkExpense.Location = new System.Drawing.Point(1034, 469);
            this.chkExpense.Name = "chkExpense";
            this.chkExpense.Size = new System.Drawing.Size(102, 24);
            this.chkExpense.TabIndex = 8;
            this.chkExpense.Text = "Expense";
            this.chkExpense.UseVisualStyleBackColor = true;
            // 
            // chkIncome
            // 
            this.chkIncome.AutoSize = true;
            this.chkIncome.Checked = true;
            this.chkIncome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.chkIncome.Location = new System.Drawing.Point(924, 469);
            this.chkIncome.Name = "chkIncome";
            this.chkIncome.Size = new System.Drawing.Size(91, 24);
            this.chkIncome.TabIndex = 7;
            this.chkIncome.Text = "Income\n";
            this.chkIncome.UseVisualStyleBackColor = true;
            // 
            // pnlBalance
            // 
            this.pnlBalance.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlBalance.BorderRadius = 10;
            this.pnlBalance.BorderThickness = 1;
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Controls.Add(this.lblBalanceTitle);
            this.pnlBalance.Controls.Add(this.imgBalance);
            this.pnlBalance.FillColor = System.Drawing.Color.White;
            this.pnlBalance.Location = new System.Drawing.Point(815, 64);
            this.pnlBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(340, 127);
            this.pnlBalance.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(253)))));
            this.lblBalance.Location = new System.Drawing.Point(101, 53);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 38);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "0 đ";
            // 
            // lblBalanceTitle
            // 
            this.lblBalanceTitle.AutoSize = true;
            this.lblBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTitle.Location = new System.Drawing.Point(105, 33);
            this.lblBalanceTitle.Name = "lblBalanceTitle";
            this.lblBalanceTitle.Size = new System.Drawing.Size(63, 20);
            this.lblBalanceTitle.TabIndex = 0;
            this.lblBalanceTitle.Text = "Balance";
            // 
            // imgBalance
            // 
            this.imgBalance.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgBalance.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgBalance.Image = ((System.Drawing.Image)(resources.GetObject("imgBalance.Image")));
            this.imgBalance.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgBalance.ImageRotate = 0F;
            this.imgBalance.Location = new System.Drawing.Point(3, 14);
            this.imgBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBalance.Name = "imgBalance";
            this.imgBalance.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgBalance.Size = new System.Drawing.Size(107, 100);
            this.imgBalance.TabIndex = 2;
            // 
            // pnlExpense
            // 
            this.pnlExpense.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlExpense.BorderRadius = 10;
            this.pnlExpense.BorderThickness = 1;
            this.pnlExpense.Controls.Add(this.lblTotalExpense);
            this.pnlExpense.Controls.Add(this.lblExpenseTitle);
            this.pnlExpense.Controls.Add(this.imgExpense);
            this.pnlExpense.FillColor = System.Drawing.Color.White;
            this.pnlExpense.Location = new System.Drawing.Point(436, 64);
            this.pnlExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlExpense.Name = "pnlExpense";
            this.pnlExpense.Size = new System.Drawing.Size(340, 127);
            this.pnlExpense.TabIndex = 4;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblTotalExpense.Location = new System.Drawing.Point(101, 53);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(59, 38);
            this.lblTotalExpense.TabIndex = 1;
            this.lblTotalExpense.Text = "0 đ";
            // 
            // lblExpenseTitle
            // 
            this.lblExpenseTitle.AutoSize = true;
            this.lblExpenseTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseTitle.Location = new System.Drawing.Point(105, 33);
            this.lblExpenseTitle.Name = "lblExpenseTitle";
            this.lblExpenseTitle.Size = new System.Drawing.Size(105, 20);
            this.lblExpenseTitle.TabIndex = 0;
            this.lblExpenseTitle.Text = "Total Expense";
            // 
            // imgExpense
            // 
            this.imgExpense.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgExpense.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgExpense.Image = ((System.Drawing.Image)(resources.GetObject("imgExpense.Image")));
            this.imgExpense.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgExpense.ImageRotate = 0F;
            this.imgExpense.Location = new System.Drawing.Point(3, 14);
            this.imgExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgExpense.Name = "imgExpense";
            this.imgExpense.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgExpense.Size = new System.Drawing.Size(107, 100);
            this.imgExpense.TabIndex = 2;
            // 
            // pnlIncome
            // 
            this.pnlIncome.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlIncome.BorderRadius = 10;
            this.pnlIncome.BorderThickness = 1;
            this.pnlIncome.Controls.Add(this.lblTotalIncome);
            this.pnlIncome.Controls.Add(this.lblTotalIncomeTitle);
            this.pnlIncome.Controls.Add(this.imgIncome);
            this.pnlIncome.FillColor = System.Drawing.Color.White;
            this.pnlIncome.Location = new System.Drawing.Point(53, 64);
            this.pnlIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(340, 127);
            this.pnlIncome.TabIndex = 6;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.lblTotalIncome.Location = new System.Drawing.Point(101, 53);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(59, 38);
            this.lblTotalIncome.TabIndex = 1;
            this.lblTotalIncome.Text = "0 đ";
            // 
            // lblTotalIncomeTitle
            // 
            this.lblTotalIncomeTitle.AutoSize = true;
            this.lblTotalIncomeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncomeTitle.Location = new System.Drawing.Point(105, 33);
            this.lblTotalIncomeTitle.Name = "lblTotalIncomeTitle";
            this.lblTotalIncomeTitle.Size = new System.Drawing.Size(100, 20);
            this.lblTotalIncomeTitle.TabIndex = 0;
            this.lblTotalIncomeTitle.Text = "Total Income";
            // 
            // imgIncome
            // 
            this.imgIncome.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgIncome.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgIncome.Image = ((System.Drawing.Image)(resources.GetObject("imgIncome.Image")));
            this.imgIncome.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgIncome.ImageRotate = 0F;
            this.imgIncome.Location = new System.Drawing.Point(3, 14);
            this.imgIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgIncome.Name = "imgIncome";
            this.imgIncome.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgIncome.Size = new System.Drawing.Size(107, 100);
            this.imgIncome.TabIndex = 2;
            // 
            // dgvTransactions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.ColumnHeadersHeight = 18;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Type,
            this.Category,
            this.Amount,
            this.Notes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactions.GridColor = System.Drawing.Color.Silver;
            this.dgvTransactions.Location = new System.Drawing.Point(56, 499);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(1101, 263);
            this.dgvTransactions.TabIndex = 5;
            this.dgvTransactions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTransactions.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTransactions.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            // 
            // lblSubTitleList
            // 
            this.lblSubTitleList.AutoSize = true;
            this.lblSubTitleList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubTitleList.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSubTitleList.Location = new System.Drawing.Point(48, 467);
            this.lblSubTitleList.Name = "lblSubTitleList";
            this.lblSubTitleList.Size = new System.Drawing.Size(188, 25);
            this.lblSubTitleList.TabIndex = 4;
            this.lblSubTitleList.Text = "TRANSACTION LIST";
            this.lblSubTitleList.Click += new System.EventHandler(this.lblSubTitleList_Click);
            // 
            // pnlChucNanng
            // 
            this.pnlChucNanng.BackColor = System.Drawing.Color.Transparent;
            this.pnlChucNanng.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlChucNanng.BorderRadius = 10;
            this.pnlChucNanng.BorderThickness = 1;
            this.pnlChucNanng.Controls.Add(this.btnLamMoi);
            this.pnlChucNanng.Controls.Add(this.btnXoa);
            this.pnlChucNanng.Controls.Add(this.btnThem);
            this.pnlChucNanng.Controls.Add(this.btnSua);
            this.pnlChucNanng.FillColor = System.Drawing.Color.White;
            this.pnlChucNanng.Location = new System.Drawing.Point(904, 219);
            this.pnlChucNanng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChucNanng.Name = "pnlChucNanng";
            this.pnlChucNanng.ShadowDecoration.BorderRadius = 0;
            this.pnlChucNanng.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.pnlChucNanng.ShadowDecoration.Enabled = true;
            this.pnlChucNanng.Size = new System.Drawing.Size(251, 229);
            this.pnlChucNanng.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderColor = System.Drawing.Color.LightGray;
            this.btnLamMoi.BorderRadius = 6;
            this.btnLamMoi.BorderThickness = 1;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(37, 161);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 37);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.LightGray;
            this.btnXoa.BorderRadius = 6;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(37, 113);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 37);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.LightGray;
            this.btnThem.BorderRadius = 6;
            this.btnThem.BorderThickness = 1;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(37, 17);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 37);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Add";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderColor = System.Drawing.Color.LightGray;
            this.btnSua.BorderRadius = 6;
            this.btnSua.BorderThickness = 1;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(37, 65);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 37);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Edit ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pnlTransactionInfo
            // 
            this.pnlTransactionInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlTransactionInfo.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlTransactionInfo.BorderRadius = 10;
            this.pnlTransactionInfo.BorderThickness = 1;
            this.pnlTransactionInfo.Controls.Add(this.lblCategory);
            this.pnlTransactionInfo.Controls.Add(this.lblAmount);
            this.pnlTransactionInfo.Controls.Add(this.lblTransactiontype);
            this.pnlTransactionInfo.Controls.Add(this.cmbBudget);
            this.pnlTransactionInfo.Controls.Add(this.lblBudget);
            this.pnlTransactionInfo.Controls.Add(this.txtNotes);
            this.pnlTransactionInfo.Controls.Add(this.lblNotes);
            this.pnlTransactionInfo.Controls.Add(this.dtpDate);
            this.pnlTransactionInfo.Controls.Add(this.lblDate);
            this.pnlTransactionInfo.Controls.Add(this.txtAmount);
            this.pnlTransactionInfo.Controls.Add(this.cmbCategory);
            this.pnlTransactionInfo.Controls.Add(this.cmbTransactionType);
            this.pnlTransactionInfo.Controls.Add(this.lblSubTItleInfo);
            this.pnlTransactionInfo.FillColor = System.Drawing.Color.White;
            this.pnlTransactionInfo.Location = new System.Drawing.Point(53, 219);
            this.pnlTransactionInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTransactionInfo.Name = "pnlTransactionInfo";
            this.pnlTransactionInfo.ShadowDecoration.BorderRadius = 0;
            this.pnlTransactionInfo.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.pnlTransactionInfo.ShadowDecoration.Enabled = true;
            this.pnlTransactionInfo.Size = new System.Drawing.Size(807, 229);
            this.pnlTransactionInfo.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(456, 59);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 16);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Category :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(19, 118);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 16);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount :";
            // 
            // lblTransactiontype
            // 
            this.lblTransactiontype.AutoSize = true;
            this.lblTransactiontype.Location = new System.Drawing.Point(19, 59);
            this.lblTransactiontype.Name = "lblTransactiontype";
            this.lblTransactiontype.Size = new System.Drawing.Size(113, 16);
            this.lblTransactiontype.TabIndex = 12;
            this.lblTransactiontype.Text = "Transaction type :";
            // 
            // cmbBudget
            // 
            this.cmbBudget.BackColor = System.Drawing.Color.Transparent;
            this.cmbBudget.BorderRadius = 6;
            this.cmbBudget.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBudget.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBudget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBudget.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBudget.ItemHeight = 30;
            this.cmbBudget.Location = new System.Drawing.Point(529, 162);
            this.cmbBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBudget.Name = "cmbBudget";
            this.cmbBudget.Size = new System.Drawing.Size(247, 36);
            this.cmbBudget.TabIndex = 10;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(456, 172);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(56, 16);
            this.lblBudget.TabIndex = 11;
            this.lblBudget.Text = "Budget :";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 6;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(147, 164);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(284, 36);
            this.txtNotes.TabIndex = 9;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(19, 175);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 16);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Notes :";
            // 
            // dtpDate
            // 
            this.dtpDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpDate.BorderRadius = 6;
            this.dtpDate.Checked = true;
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(527, 107);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(164, 36);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.Value = new System.DateTime(2026, 7, 4, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(456, 113);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date :";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 6;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.Location = new System.Drawing.Point(147, 107);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(284, 36);
            this.txtAmount.TabIndex = 5;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderRadius = 6;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Items.AddRange(new object[] {
            "Food & Drink",
            "Transport",
            "Salary",
            "Housing"});
            this.cmbCategory.Location = new System.Drawing.Point(527, 49);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(249, 36);
            this.cmbCategory.TabIndex = 2;
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.BackColor = System.Drawing.Color.Transparent;
            this.cmbTransactionType.BorderRadius = 6;
            this.cmbTransactionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTransactionType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTransactionType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTransactionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTransactionType.ItemHeight = 30;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "Expense",
            "Income"});
            this.cmbTransactionType.Location = new System.Drawing.Point(147, 49);
            this.cmbTransactionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(284, 36);
            this.cmbTransactionType.TabIndex = 2;
            // 
            // lblSubTItleInfo
            // 
            this.lblSubTItleInfo.AutoSize = true;
            this.lblSubTItleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubTItleInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSubTItleInfo.Location = new System.Drawing.Point(17, 17);
            this.lblSubTItleInfo.Name = "lblSubTItleInfo";
            this.lblSubTItleInfo.Size = new System.Drawing.Size(267, 25);
            this.lblSubTItleInfo.TabIndex = 0;
            this.lblSubTItleInfo.Text = "TRANSACTION INFOMATION";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMainTitle.Location = new System.Drawing.Point(37, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(193, 41);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Transactions";
            // 
            // lblcate
            // 
            this.lblcate.AutoSize = true;
            this.lblcate.Location = new System.Drawing.Point(19, 113);
            this.lblcate.Name = "lblcate";
            this.lblcate.Size = new System.Drawing.Size(58, 16);
            this.lblcate.TabIndex = 4;
            this.lblcate.Text = "Amount :";
            this.lblcate.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCatego
            // 
            this.lblCatego.AutoSize = true;
            this.lblCatego.Location = new System.Drawing.Point(456, 58);
            this.lblCatego.Name = "lblCatego";
            this.lblCatego.Size = new System.Drawing.Size(68, 16);
            this.lblCatego.TabIndex = 3;
            this.lblCatego.Text = "Category :";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(19, 58);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(113, 16);
            this.lblTransaction.TabIndex = 1;
            this.lblTransaction.Text = "Transaction type :";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(134, 20);
            this.guna2CheckBox1.TabIndex = 3;
            this.guna2CheckBox1.Text = "guna2CheckBox1";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 903);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTransactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlExpense.ResumeLayout(false);
            this.pnlExpense.PerformLayout();
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.pnlChucNanng.ResumeLayout(false);
            this.pnlTransactionInfo.ResumeLayout(false);
            this.pnlTransactionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblMainTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlTransactionInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTransactionType;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblSubTItleInfo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label lblcate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCatego;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBudget;
        private System.Windows.Forms.Label lblBudget;
        private Guna.UI2.WinForms.Guna2Panel pnlChucNanng;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private System.Windows.Forms.Label lblSubTitleList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private Guna.UI2.WinForms.Guna2Panel pnlIncome;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTotalIncomeTitle;
        private Guna.UI2.WinForms.Guna2ImageButton imgIncome;
        private Guna.UI2.WinForms.Guna2Panel pnlExpense;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblExpenseTitle;
        private Guna.UI2.WinForms.Guna2ImageButton imgExpense;
        private Guna.UI2.WinForms.Guna2Panel pnlBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceTitle;
        private Guna.UI2.WinForms.Guna2ImageButton imgBalance;
        private System.Windows.Forms.CheckBox chkExpense;
        private System.Windows.Forms.CheckBox chkIncome;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTransactiontype;
    }
}