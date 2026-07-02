namespace PersonalExpenseManager
{
    partial class frmBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudget));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.pnlAddBudet = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbPeriod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtAmont = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cboCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtBudgetName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBugetName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddHeader = new System.Windows.Forms.Label();
            this.pnlChucNang = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.dgvButdgets = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBudgetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlIncome = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTotalIncomeTitle = new System.Windows.Forms.Label();
            this.imgIncome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlExpense = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblExpenseTitle = new System.Windows.Forms.Label();
            this.imgExpense = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.imgBalance = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlAddBudet.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvButdgets)).BeginInit();
            this.pnlIncome.SuspendLayout();
            this.pnlExpense.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMainTitle.Location = new System.Drawing.Point(218, 74);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(107, 38);
            this.lblMainTitle.TabIndex = 2;
            this.lblMainTitle.Text = "Bugets";
            // 
            // pnlAddBudet
            // 
            this.pnlAddBudet.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddBudet.BorderRadius = 12;
            this.pnlAddBudet.Controls.Add(this.cmbPeriod);
            this.pnlAddBudet.Controls.Add(this.lblPeriod);
            this.pnlAddBudet.Controls.Add(this.txtAmont);
            this.pnlAddBudet.Controls.Add(this.lblAmount);
            this.pnlAddBudet.Controls.Add(this.cboCategory);
            this.pnlAddBudet.Controls.Add(this.lblCategory);
            this.pnlAddBudet.Controls.Add(this.txtBudgetName);
            this.pnlAddBudet.Controls.Add(this.lblBugetName);
            this.pnlAddBudet.Controls.Add(this.label2);
            this.pnlAddBudet.Controls.Add(this.lblAddHeader);
            this.pnlAddBudet.FillColor = System.Drawing.Color.White;
            this.pnlAddBudet.Location = new System.Drawing.Point(254, 285);
            this.pnlAddBudet.Name = "pnlAddBudet";
            this.pnlAddBudet.ShadowDecoration.Enabled = true;
            this.pnlAddBudet.Size = new System.Drawing.Size(671, 231);
            this.pnlAddBudet.TabIndex = 3;
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriod.BorderRadius = 6;
            this.cmbPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPeriod.ItemHeight = 30;
            this.cmbPeriod.Items.AddRange(new object[] {
            "Monthly"});
            this.cmbPeriod.Location = new System.Drawing.Point(370, 166);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(180, 36);
            this.cmbPeriod.TabIndex = 14;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPeriod.Location = new System.Drawing.Point(366, 143);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(53, 20);
            this.lblPeriod.TabIndex = 13;
            this.lblPeriod.Text = "Period";
            // 
            // txtAmont
            // 
            this.txtAmont.BorderRadius = 6;
            this.txtAmont.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmont.DefaultText = "";
            this.txtAmont.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmont.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmont.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmont.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmont.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAmont.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmont.Location = new System.Drawing.Point(370, 82);
            this.txtAmont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmont.Name = "txtAmont";
            this.txtAmont.PlaceholderText = "Enter amont";
            this.txtAmont.SelectedText = "";
            this.txtAmont.Size = new System.Drawing.Size(180, 36);
            this.txtAmont.TabIndex = 11;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAmount.Location = new System.Drawing.Point(366, 58);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(115, 20);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Budget amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboCategory.BorderRadius = 6;
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCategory.ItemHeight = 30;
            this.cboCategory.Items.AddRange(new object[] {
            "Select category"});
            this.cboCategory.Location = new System.Drawing.Point(48, 166);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(180, 36);
            this.cboCategory.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCategory.Location = new System.Drawing.Point(44, 143);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // txtBudgetName
            // 
            this.txtBudgetName.BorderRadius = 6;
            this.txtBudgetName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBudgetName.DefaultText = "";
            this.txtBudgetName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBudgetName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBudgetName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBudgetName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBudgetName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBudgetName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBudgetName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBudgetName.Location = new System.Drawing.Point(48, 82);
            this.txtBudgetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBudgetName.Name = "txtBudgetName";
            this.txtBudgetName.PlaceholderText = "Enter budget name";
            this.txtBudgetName.SelectedText = "";
            this.txtBudgetName.Size = new System.Drawing.Size(180, 36);
            this.txtBudgetName.TabIndex = 7;
            // 
            // lblBugetName
            // 
            this.lblBugetName.AutoSize = true;
            this.lblBugetName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBugetName.Location = new System.Drawing.Point(44, 58);
            this.lblBugetName.Name = "lblBugetName";
            this.lblBugetName.Size = new System.Drawing.Size(100, 20);
            this.lblBugetName.TabIndex = 6;
            this.lblBugetName.Text = "Budget name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // lblAddHeader
            // 
            this.lblAddHeader.AutoSize = true;
            this.lblAddHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAddHeader.ForeColor = System.Drawing.Color.Green;
            this.lblAddHeader.Location = new System.Drawing.Point(21, 16);
            this.lblAddHeader.Name = "lblAddHeader";
            this.lblAddHeader.Size = new System.Drawing.Size(108, 23);
            this.lblAddHeader.TabIndex = 1;
            this.lblAddHeader.Text = "Add Budget";
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BackColor = System.Drawing.Color.Transparent;
            this.pnlChucNang.BorderRadius = 10;
            this.pnlChucNang.BorderThickness = 1;
            this.pnlChucNang.Controls.Add(this.btnLamMoi);
            this.pnlChucNang.Controls.Add(this.btnEdit);
            this.pnlChucNang.Controls.Add(this.btnAdd);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.FillColor = System.Drawing.Color.White;
            this.pnlChucNang.Location = new System.Drawing.Point(1029, 267);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.ShadowDecoration.Enabled = true;
            this.pnlChucNang.Size = new System.Drawing.Size(247, 278);
            this.pnlChucNang.TabIndex = 4;
            this.pnlChucNang.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChucNang_Paint);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderColor = System.Drawing.Color.Gray;
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
            this.btnLamMoi.Location = new System.Drawing.Point(34, 218);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 45);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.BorderRadius = 6;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(34, 87);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(34, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.DarkGray;
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
            this.btnXoa.Location = new System.Drawing.Point(34, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvButdgets
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvButdgets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvButdgets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvButdgets.ColumnHeadersHeight = 19;
            this.dgvButdgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvButdgets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColBudgetName,
            this.colCategory,
            this.colSpent,
            this.ColProgress,
            this.ColPeriod});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvButdgets.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvButdgets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvButdgets.Location = new System.Drawing.Point(254, 561);
            this.dgvButdgets.Name = "dgvButdgets";
            this.dgvButdgets.RowHeadersVisible = false;
            this.dgvButdgets.RowHeadersWidth = 51;
            this.dgvButdgets.RowTemplate.Height = 24;
            this.dgvButdgets.Size = new System.Drawing.Size(1049, 234);
            this.dgvButdgets.TabIndex = 5;
            this.dgvButdgets.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvButdgets.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvButdgets.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvButdgets.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvButdgets.ThemeStyle.HeaderStyle.Height = 19;
            this.dgvButdgets.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvButdgets.ThemeStyle.RowsStyle.Height = 24;
            this.dgvButdgets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // ColBudgetName
            // 
            this.ColBudgetName.HeaderText = "Budget name";
            this.ColBudgetName.MinimumWidth = 6;
            this.ColBudgetName.Name = "ColBudgetName";
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            // 
            // colSpent
            // 
            this.colSpent.HeaderText = "Spent";
            this.colSpent.MinimumWidth = 6;
            this.colSpent.Name = "colSpent";
            // 
            // ColProgress
            // 
            this.ColProgress.HeaderText = "Progress";
            this.ColProgress.MinimumWidth = 6;
            this.ColProgress.Name = "ColProgress";
            // 
            // ColPeriod
            // 
            this.ColPeriod.HeaderText = "Period";
            this.ColPeriod.MinimumWidth = 6;
            this.ColPeriod.Name = "ColPeriod";
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
            this.pnlIncome.Location = new System.Drawing.Point(254, 118);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(324, 127);
            this.pnlIncome.TabIndex = 6;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.lblTotalIncome.Location = new System.Drawing.Point(102, 53);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(187, 38);
            this.lblTotalIncome.TabIndex = 1;
            this.lblTotalIncome.Text = "25.750.000 đ";
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
            this.imgIncome.Name = "imgIncome";
            this.imgIncome.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgIncome.Size = new System.Drawing.Size(106, 100);
            this.imgIncome.TabIndex = 2;
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
            this.pnlExpense.Location = new System.Drawing.Point(624, 118);
            this.pnlExpense.Name = "pnlExpense";
            this.pnlExpense.Size = new System.Drawing.Size(324, 127);
            this.pnlExpense.TabIndex = 4;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblTotalExpense.Location = new System.Drawing.Point(102, 53);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(187, 38);
            this.lblTotalExpense.TabIndex = 1;
            this.lblTotalExpense.Text = "16.500.000 đ";
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
            this.imgExpense.Name = "imgExpense";
            this.imgExpense.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgExpense.Size = new System.Drawing.Size(106, 100);
            this.imgExpense.TabIndex = 2;
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
            this.pnlBalance.Location = new System.Drawing.Point(987, 118);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(324, 127);
            this.pnlBalance.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(98)))), ((int)(((byte)(253)))));
            this.lblBalance.Location = new System.Drawing.Point(102, 53);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(187, 38);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "12.450.000 đ";
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
            this.imgBalance.Name = "imgBalance";
            this.imgBalance.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgBalance.Size = new System.Drawing.Size(106, 100);
            this.imgBalance.TabIndex = 2;
            // 
            // frmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 903);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlExpense);
            this.Controls.Add(this.pnlIncome);
            this.Controls.Add(this.dgvButdgets);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlAddBudet);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "frmBudget";
            this.Text = "frmBudget";
            this.pnlAddBudet.ResumeLayout(false);
            this.pnlAddBudet.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvButdgets)).EndInit();
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.pnlExpense.ResumeLayout(false);
            this.pnlExpense.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlAddBudet;
        private System.Windows.Forms.Label lblAddHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBugetName;
        private Guna.UI2.WinForms.Guna2ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtBudgetName;
        private System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAmont;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private Guna.UI2.WinForms.Guna2Panel pnlChucNang;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvButdgets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBudgetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeriod;
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
    }
}