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
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelAppName2 = new System.Windows.Forms.Label();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnBudget = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnSavings = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cardIncome = new Guna.UI2.WinForms.Guna2Panel();
            this.lblIncomeTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.cardIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnSavings);
            this.pnlSidebar.Controls.Add(this.btnReport);
            this.pnlSidebar.Controls.Add(this.btnBudget);
            this.pnlSidebar.Controls.Add(this.btnCategory);
            this.pnlSidebar.Controls.Add(this.labelAppName2);
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblAppName);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(98)))));
            this.pnlSidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(47)))), ((int)(((byte)(40)))));
            this.pnlSidebar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.ShadowDecoration.Parent = this.pnlSidebar;
            this.pnlSidebar.Size = new System.Drawing.Size(193, 503);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(92)))));
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.ImageSize = new System.Drawing.Size(200, 45);
            this.btnDashboard.Location = new System.Drawing.Point(12, 96);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(167, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(70)))));
            this.lblAppName.Location = new System.Drawing.Point(83, 28);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(74, 23);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Expense";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(33, 28);
            this.picLogo.Name = "picLogo";
            this.picLogo.ShadowDecoration.Parent = this.picLogo;
            this.picLogo.Size = new System.Drawing.Size(45, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // labelAppName2
            // 
            this.labelAppName2.AutoSize = true;
            this.labelAppName2.BackColor = System.Drawing.Color.Transparent;
            this.labelAppName2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(235)))), ((int)(((byte)(141)))));
            this.labelAppName2.Location = new System.Drawing.Point(83, 50);
            this.labelAppName2.Name = "labelAppName2";
            this.labelAppName2.Size = new System.Drawing.Size(81, 23);
            this.labelAppName2.TabIndex = 3;
            this.labelAppName2.Text = "Manager";
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.BorderRadius = 10;
            this.btnCategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategory.Checked = true;
            this.btnCategory.CheckedState.Parent = this.btnCategory;
            this.btnCategory.CustomImages.Parent = this.btnCategory;
            this.btnCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.HoverState.Parent = this.btnCategory;
            this.btnCategory.ImageSize = new System.Drawing.Size(200, 45);
            this.btnCategory.Location = new System.Drawing.Point(12, 152);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.ShadowDecoration.Parent = this.btnCategory;
            this.btnCategory.Size = new System.Drawing.Size(167, 45);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Category";
            // 
            // btnBudget
            // 
            this.btnBudget.BackColor = System.Drawing.Color.Transparent;
            this.btnBudget.BorderRadius = 10;
            this.btnBudget.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBudget.Checked = true;
            this.btnBudget.CheckedState.Parent = this.btnBudget;
            this.btnBudget.CustomImages.Parent = this.btnBudget;
            this.btnBudget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.btnBudget.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudget.ForeColor = System.Drawing.Color.White;
            this.btnBudget.HoverState.Parent = this.btnBudget;
            this.btnBudget.ImageSize = new System.Drawing.Size(200, 45);
            this.btnBudget.Location = new System.Drawing.Point(12, 208);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.ShadowDecoration.Parent = this.btnBudget;
            this.btnBudget.Size = new System.Drawing.Size(167, 45);
            this.btnBudget.TabIndex = 5;
            this.btnBudget.Text = "Budget";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BorderRadius = 10;
            this.btnReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReport.Checked = true;
            this.btnReport.CheckedState.Parent = this.btnReport;
            this.btnReport.CustomImages.Parent = this.btnReport;
            this.btnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.HoverState.Parent = this.btnReport;
            this.btnReport.ImageSize = new System.Drawing.Size(200, 45);
            this.btnReport.Location = new System.Drawing.Point(12, 264);
            this.btnReport.Name = "btnReport";
            this.btnReport.ShadowDecoration.Parent = this.btnReport;
            this.btnReport.Size = new System.Drawing.Size(167, 45);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            // 
            // btnSavings
            // 
            this.btnSavings.BackColor = System.Drawing.Color.Transparent;
            this.btnSavings.BorderRadius = 10;
            this.btnSavings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSavings.Checked = true;
            this.btnSavings.CheckedState.Parent = this.btnSavings;
            this.btnSavings.CustomImages.Parent = this.btnSavings;
            this.btnSavings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.btnSavings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavings.ForeColor = System.Drawing.Color.White;
            this.btnSavings.HoverState.Parent = this.btnSavings;
            this.btnSavings.ImageSize = new System.Drawing.Size(200, 45);
            this.btnSavings.Location = new System.Drawing.Point(12, 320);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.ShadowDecoration.Parent = this.btnSavings;
            this.btnSavings.Size = new System.Drawing.Size(167, 45);
            this.btnSavings.TabIndex = 7;
            this.btnSavings.Text = "Savings ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cardIncome);
            this.pnlMain.Controls.Add(this.guna2Panel1);
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(193, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(691, 503);
            this.pnlMain.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(691, 71);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cardIncome
            // 
            this.cardIncome.BackColor = System.Drawing.Color.Transparent;
            this.cardIncome.BorderRadius = 15;
            this.cardIncome.Controls.Add(this.lblIncomeTitle);
            this.cardIncome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.cardIncome.Location = new System.Drawing.Point(33, 107);
            this.cardIncome.Name = "cardIncome";
            this.cardIncome.ShadowDecoration.Parent = this.cardIncome;
            this.cardIncome.Size = new System.Drawing.Size(286, 146);
            this.cardIncome.TabIndex = 1;
            // 
            // lblIncomeTitle
            // 
            this.lblIncomeTitle.AutoSize = true;
            this.lblIncomeTitle.Location = new System.Drawing.Point(45, 28);
            this.lblIncomeTitle.Name = "lblIncomeTitle";
            this.lblIncomeTitle.Size = new System.Drawing.Size(59, 16);
            this.lblIncomeTitle.TabIndex = 0;
            this.lblIncomeTitle.Text = "Tổng thu";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.cardIncome.ResumeLayout(false);
            this.cardIncome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label lblAppName;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private System.Windows.Forms.Label labelAppName2;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
        private Guna.UI2.WinForms.Guna2Button btnSavings;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2Button btnBudget;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel cardIncome;
        private System.Windows.Forms.Label lblIncomeTitle;
    }
}