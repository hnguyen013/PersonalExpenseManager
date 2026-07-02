namespace PersonalExpenseManager.Presentation
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
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
            this.pnlRecent = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvRecentTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlIncome.SuspendLayout();
            this.pnlExpense.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.pnlIncome.Location = new System.Drawing.Point(226, 104);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(340, 127);
            this.pnlIncome.TabIndex = 2;
            this.pnlIncome.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIncome_Paint);
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
            this.pnlExpense.Location = new System.Drawing.Point(600, 104);
            this.pnlExpense.Name = "pnlExpense";
            this.pnlExpense.Size = new System.Drawing.Size(340, 127);
            this.pnlExpense.TabIndex = 3;
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
            this.pnlBalance.Location = new System.Drawing.Point(974, 104);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(340, 127);
            this.pnlBalance.TabIndex = 4;
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
            // pnlRecent
            // 
            this.pnlRecent.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlRecent.BorderRadius = 20;
            this.pnlRecent.BorderThickness = 1;
            this.pnlRecent.Controls.Add(this.dgvRecentTransactions);
            this.pnlRecent.Controls.Add(this.label1);
            this.pnlRecent.Location = new System.Drawing.Point(224, 253);
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.Size = new System.Drawing.Size(1090, 603);
            this.pnlRecent.TabIndex = 5;
            // 
            // dgvRecentTransactions
            // 
            this.dgvRecentTransactions.AllowUserToAddRows = false;
            this.dgvRecentTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRecentTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentTransactions.ColumnHeadersHeight = 18;
            this.dgvRecentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRecentTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Description,
            this.Category,
            this.Type,
            this.Amount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentTransactions.Location = new System.Drawing.Point(35, 64);
            this.dgvRecentTransactions.Name = "dgvRecentTransactions";
            this.dgvRecentTransactions.ReadOnly = true;
            this.dgvRecentTransactions.RowHeadersVisible = false;
            this.dgvRecentTransactions.RowHeadersWidth = 51;
            this.dgvRecentTransactions.RowTemplate.Height = 24;
            this.dgvRecentTransactions.Size = new System.Drawing.Size(1004, 510);
            this.dgvRecentTransactions.TabIndex = 1;
            this.dgvRecentTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecentTransactions.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvRecentTransactions.ThemeStyle.ReadOnly = true;
            this.dgvRecentTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecentTransactions.ThemeStyle.RowsStyle.Height = 24;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent Transactions";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 903);
            this.Controls.Add(this.pnlRecent);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlExpense);
            this.Controls.Add(this.pnlIncome);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.pnlIncome.ResumeLayout(false);
            this.pnlIncome.PerformLayout();
            this.pnlExpense.ResumeLayout(false);
            this.pnlExpense.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlRecent.ResumeLayout(false);
            this.pnlRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Panel pnlIncome;
        private System.Windows.Forms.Label lblTotalIncomeTitle;
        private System.Windows.Forms.Label lblTotalIncome;
        private Guna.UI2.WinForms.Guna2ImageButton imgIncome;
        private Guna.UI2.WinForms.Guna2Panel pnlExpense;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblExpenseTitle;
        private Guna.UI2.WinForms.Guna2ImageButton imgExpense;
        private Guna.UI2.WinForms.Guna2Panel pnlBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceTitle;
        private Guna.UI2.WinForms.Guna2ImageButton imgBalance;
        private Guna.UI2.WinForms.Guna2Panel pnlRecent;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}