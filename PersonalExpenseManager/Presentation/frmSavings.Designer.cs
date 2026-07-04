namespace PersonalExpenseManager
{
    partial class frmSavings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSavings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlGoals = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalGoals = new System.Windows.Forms.Label();
            this.picGoals = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNumGoals = new System.Windows.Forms.Label();
            this.pnlTarget = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalTarget = new System.Windows.Forms.Label();
            this.picTarget = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTotalTargetAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSaved = new Guna.UI2.WinForms.Guna2Panel();
            this.picSaved = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTotalSaved = new System.Windows.Forms.Label();
            this.lblTotalSavedAmount = new System.Windows.Forms.Label();
            this.pnlRemaining = new Guna.UI2.WinForms.Guna2Panel();
            this.picRemaining = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.pnlNewGoalBox = new Guna.UI2.WinForms.Guna2Panel();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtInitialAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInitiaAmount = new System.Windows.Forms.Label();
            this.dtpTargetDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTargetDate = new System.Windows.Forms.Label();
            this.txtTargetAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTargetAmount = new System.Windows.Forms.Label();
            this.txtGoalName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGoalName = new System.Windows.Forms.Label();
            this.lblNewGoalHeader = new System.Windows.Forms.Label();
            this.pnlChucNang = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.lblLisHeader = new System.Windows.Forms.Label();
            this.dgvSavings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTargetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSavedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTargetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkInProgress = new System.Windows.Forms.CheckBox();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.pnlGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoals)).BeginInit();
            this.pnlTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).BeginInit();
            this.pnlSaved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaved)).BeginInit();
            this.pnlRemaining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemaining)).BeginInit();
            this.pnlNewGoalBox.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPageTitle.Location = new System.Drawing.Point(238, 94);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(185, 38);
            this.lblPageTitle.TabIndex = 2;
            this.lblPageTitle.Text = "Saving Goals";
            // 
            // pnlGoals
            // 
            this.pnlGoals.BorderColor = System.Drawing.Color.Gray;
            this.pnlGoals.BorderRadius = 12;
            this.pnlGoals.BorderThickness = 1;
            this.pnlGoals.Controls.Add(this.lblTotalGoals);
            this.pnlGoals.Controls.Add(this.picGoals);
            this.pnlGoals.Controls.Add(this.lblNumGoals);
            this.pnlGoals.FillColor = System.Drawing.Color.White;
            this.pnlGoals.Location = new System.Drawing.Point(234, 151);
            this.pnlGoals.Name = "pnlGoals";
            this.pnlGoals.Size = new System.Drawing.Size(259, 133);
            this.pnlGoals.TabIndex = 3;
            // 
            // lblTotalGoals
            // 
            this.lblTotalGoals.AutoSize = true;
            this.lblTotalGoals.BackColor = System.Drawing.Color.White;
            this.lblTotalGoals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalGoals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalGoals.Location = new System.Drawing.Point(72, 17);
            this.lblTotalGoals.Name = "lblTotalGoals";
            this.lblTotalGoals.Size = new System.Drawing.Size(117, 28);
            this.lblTotalGoals.TabIndex = 7;
            this.lblTotalGoals.Text = "Total Goals";
            // 
            // picGoals
            // 
            this.picGoals.BackColor = System.Drawing.Color.White;
            this.picGoals.Image = ((System.Drawing.Image)(resources.GetObject("picGoals.Image")));
            this.picGoals.ImageRotate = 0F;
            this.picGoals.Location = new System.Drawing.Point(10, 47);
            this.picGoals.Name = "picGoals";
            this.picGoals.Size = new System.Drawing.Size(57, 65);
            this.picGoals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoals.TabIndex = 7;
            this.picGoals.TabStop = false;
            // 
            // lblNumGoals
            // 
            this.lblNumGoals.AutoSize = true;
            this.lblNumGoals.BackColor = System.Drawing.Color.White;
            this.lblNumGoals.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumGoals.Location = new System.Drawing.Point(77, 61);
            this.lblNumGoals.Name = "lblNumGoals";
            this.lblNumGoals.Size = new System.Drawing.Size(48, 31);
            this.lblNumGoals.TabIndex = 7;
            this.lblNumGoals.Text = "0 đ";
            // 
            // pnlTarget
            // 
            this.pnlTarget.BorderColor = System.Drawing.Color.Gray;
            this.pnlTarget.BorderRadius = 12;
            this.pnlTarget.BorderThickness = 1;
            this.pnlTarget.Controls.Add(this.lblTotalTarget);
            this.pnlTarget.Controls.Add(this.picTarget);
            this.pnlTarget.Controls.Add(this.lblTotalTargetAmount);
            this.pnlTarget.FillColor = System.Drawing.Color.White;
            this.pnlTarget.Location = new System.Drawing.Point(511, 151);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(259, 133);
            this.pnlTarget.TabIndex = 4;
            // 
            // lblTotalTarget
            // 
            this.lblTotalTarget.AutoSize = true;
            this.lblTotalTarget.BackColor = System.Drawing.Color.White;
            this.lblTotalTarget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTarget.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalTarget.Location = new System.Drawing.Point(58, 17);
            this.lblTotalTarget.Name = "lblTotalTarget";
            this.lblTotalTarget.Size = new System.Drawing.Size(125, 28);
            this.lblTotalTarget.TabIndex = 14;
            this.lblTotalTarget.Text = "Total Target";
            // 
            // picTarget
            // 
            this.picTarget.Image = ((System.Drawing.Image)(resources.GetObject("picTarget.Image")));
            this.picTarget.ImageRotate = 0F;
            this.picTarget.Location = new System.Drawing.Point(19, 47);
            this.picTarget.Name = "picTarget";
            this.picTarget.Size = new System.Drawing.Size(57, 65);
            this.picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTarget.TabIndex = 8;
            this.picTarget.TabStop = false;
            // 
            // lblTotalTargetAmount
            // 
            this.lblTotalTargetAmount.AutoSize = true;
            this.lblTotalTargetAmount.BackColor = System.Drawing.Color.White;
            this.lblTotalTargetAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalTargetAmount.Location = new System.Drawing.Point(82, 61);
            this.lblTotalTargetAmount.Name = "lblTotalTargetAmount";
            this.lblTotalTargetAmount.Size = new System.Drawing.Size(48, 31);
            this.lblTotalTargetAmount.TabIndex = 10;
            this.lblTotalTargetAmount.Text = "0 đ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(73, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            this.label3.TabIndex = 9;
            // 
            // pnlSaved
            // 
            this.pnlSaved.BorderColor = System.Drawing.Color.Gray;
            this.pnlSaved.BorderRadius = 12;
            this.pnlSaved.BorderThickness = 1;
            this.pnlSaved.Controls.Add(this.picSaved);
            this.pnlSaved.Controls.Add(this.lblTotalSaved);
            this.pnlSaved.Controls.Add(this.lblTotalSavedAmount);
            this.pnlSaved.FillColor = System.Drawing.Color.White;
            this.pnlSaved.Location = new System.Drawing.Point(792, 151);
            this.pnlSaved.Name = "pnlSaved";
            this.pnlSaved.Size = new System.Drawing.Size(259, 133);
            this.pnlSaved.TabIndex = 5;
            // 
            // picSaved
            // 
            this.picSaved.Image = ((System.Drawing.Image)(resources.GetObject("picSaved.Image")));
            this.picSaved.ImageRotate = 0F;
            this.picSaved.Location = new System.Drawing.Point(8, 47);
            this.picSaved.Name = "picSaved";
            this.picSaved.Size = new System.Drawing.Size(57, 65);
            this.picSaved.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSaved.TabIndex = 7;
            this.picSaved.TabStop = false;
            // 
            // lblTotalSaved
            // 
            this.lblTotalSaved.AutoSize = true;
            this.lblTotalSaved.BackColor = System.Drawing.Color.White;
            this.lblTotalSaved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaved.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalSaved.Location = new System.Drawing.Point(72, 17);
            this.lblTotalSaved.Name = "lblTotalSaved";
            this.lblTotalSaved.Size = new System.Drawing.Size(121, 28);
            this.lblTotalSaved.TabIndex = 12;
            this.lblTotalSaved.Text = "Total Saved";
            // 
            // lblTotalSavedAmount
            // 
            this.lblTotalSavedAmount.AutoSize = true;
            this.lblTotalSavedAmount.BackColor = System.Drawing.Color.White;
            this.lblTotalSavedAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalSavedAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalSavedAmount.Location = new System.Drawing.Point(71, 61);
            this.lblTotalSavedAmount.Name = "lblTotalSavedAmount";
            this.lblTotalSavedAmount.Size = new System.Drawing.Size(48, 31);
            this.lblTotalSavedAmount.TabIndex = 13;
            this.lblTotalSavedAmount.Text = "0 đ";
            // 
            // pnlRemaining
            // 
            this.pnlRemaining.BorderColor = System.Drawing.Color.Gray;
            this.pnlRemaining.BorderRadius = 12;
            this.pnlRemaining.BorderThickness = 1;
            this.pnlRemaining.Controls.Add(this.picRemaining);
            this.pnlRemaining.Controls.Add(this.lblRemainingAmount);
            this.pnlRemaining.Controls.Add(this.lblRemaining);
            this.pnlRemaining.FillColor = System.Drawing.Color.White;
            this.pnlRemaining.Location = new System.Drawing.Point(1076, 151);
            this.pnlRemaining.Name = "pnlRemaining";
            this.pnlRemaining.Size = new System.Drawing.Size(259, 133);
            this.pnlRemaining.TabIndex = 6;
            // 
            // picRemaining
            // 
            this.picRemaining.Image = ((System.Drawing.Image)(resources.GetObject("picRemaining.Image")));
            this.picRemaining.ImageRotate = 0F;
            this.picRemaining.Location = new System.Drawing.Point(12, 47);
            this.picRemaining.Name = "picRemaining";
            this.picRemaining.Size = new System.Drawing.Size(57, 65);
            this.picRemaining.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRemaining.TabIndex = 8;
            this.picRemaining.TabStop = false;
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.BackColor = System.Drawing.Color.White;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRemainingAmount.Location = new System.Drawing.Point(75, 61);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(48, 31);
            this.lblRemainingAmount.TabIndex = 16;
            this.lblRemainingAmount.Text = "0 đ";
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.BackColor = System.Drawing.Color.White;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemaining.Location = new System.Drawing.Point(76, 17);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(113, 28);
            this.lblRemaining.TabIndex = 15;
            this.lblRemaining.Text = "Remaining";
            // 
            // pnlNewGoalBox
            // 
            this.pnlNewGoalBox.BackColor = System.Drawing.Color.White;
            this.pnlNewGoalBox.BorderColor = System.Drawing.Color.Black;
            this.pnlNewGoalBox.BorderRadius = 10;
            this.pnlNewGoalBox.BorderThickness = 1;
            this.pnlNewGoalBox.Controls.Add(this.txtNotes);
            this.pnlNewGoalBox.Controls.Add(this.lblNotes);
            this.pnlNewGoalBox.Controls.Add(this.txtInitialAmount);
            this.pnlNewGoalBox.Controls.Add(this.lblInitiaAmount);
            this.pnlNewGoalBox.Controls.Add(this.dtpTargetDate);
            this.pnlNewGoalBox.Controls.Add(this.lblTargetDate);
            this.pnlNewGoalBox.Controls.Add(this.txtTargetAmount);
            this.pnlNewGoalBox.Controls.Add(this.lblTargetAmount);
            this.pnlNewGoalBox.Controls.Add(this.txtGoalName);
            this.pnlNewGoalBox.Controls.Add(this.lblGoalName);
            this.pnlNewGoalBox.Controls.Add(this.lblNewGoalHeader);
            this.pnlNewGoalBox.Location = new System.Drawing.Point(234, 318);
            this.pnlNewGoalBox.Name = "pnlNewGoalBox";
            this.pnlNewGoalBox.Size = new System.Drawing.Size(751, 236);
            this.pnlNewGoalBox.TabIndex = 7;
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
            this.txtNotes.Location = new System.Drawing.Point(118, 166);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Add notes (optional)";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(594, 40);
            this.txtNotes.TabIndex = 11;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(26, 176);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(57, 20);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "Notes :";
            // 
            // txtInitialAmount
            // 
            this.txtInitialAmount.BorderRadius = 6;
            this.txtInitialAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitialAmount.DefaultText = "0";
            this.txtInitialAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitialAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInitialAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitialAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInitialAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitialAmount.Location = new System.Drawing.Point(566, 110);
            this.txtInitialAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInitialAmount.Name = "txtInitialAmount";
            this.txtInitialAmount.PlaceholderText = "";
            this.txtInitialAmount.SelectedText = "";
            this.txtInitialAmount.Size = new System.Drawing.Size(146, 40);
            this.txtInitialAmount.TabIndex = 9;
            // 
            // lblInitiaAmount
            // 
            this.lblInitiaAmount.AutoSize = true;
            this.lblInitiaAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblInitiaAmount.Location = new System.Drawing.Point(441, 119);
            this.lblInitiaAmount.Name = "lblInitiaAmount";
            this.lblInitiaAmount.Size = new System.Drawing.Size(108, 20);
            this.lblInitiaAmount.TabIndex = 8;
            this.lblInitiaAmount.Text = "Inital amount :";
            // 
            // dtpTargetDate
            // 
            this.dtpTargetDate.BorderRadius = 6;
            this.dtpTargetDate.Checked = true;
            this.dtpTargetDate.CustomFormat = "dd/MM/yyyy";
            this.dtpTargetDate.FillColor = System.Drawing.Color.White;
            this.dtpTargetDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTargetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTargetDate.Location = new System.Drawing.Point(120, 111);
            this.dtpTargetDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTargetDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTargetDate.Name = "dtpTargetDate";
            this.dtpTargetDate.Size = new System.Drawing.Size(169, 36);
            this.dtpTargetDate.TabIndex = 6;
            this.dtpTargetDate.Value = new System.DateTime(2026, 6, 5, 2, 21, 21, 545);
            // 
            // lblTargetDate
            // 
            this.lblTargetDate.AutoSize = true;
            this.lblTargetDate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblTargetDate.Location = new System.Drawing.Point(23, 120);
            this.lblTargetDate.Name = "lblTargetDate";
            this.lblTargetDate.Size = new System.Drawing.Size(94, 20);
            this.lblTargetDate.TabIndex = 5;
            this.lblTargetDate.Text = "Target date :";
            // 
            // txtTargetAmount
            // 
            this.txtTargetAmount.BorderRadius = 6;
            this.txtTargetAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTargetAmount.DefaultText = "0";
            this.txtTargetAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTargetAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTargetAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTargetAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTargetAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTargetAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTargetAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTargetAmount.Location = new System.Drawing.Point(566, 54);
            this.txtTargetAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.PlaceholderText = "";
            this.txtTargetAmount.SelectedText = "";
            this.txtTargetAmount.Size = new System.Drawing.Size(146, 40);
            this.txtTargetAmount.TabIndex = 4;
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.AutoSize = true;
            this.lblTargetAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblTargetAmount.Location = new System.Drawing.Point(441, 65);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(117, 20);
            this.lblTargetAmount.TabIndex = 3;
            this.lblTargetAmount.Text = "Target amount :";
            // 
            // txtGoalName
            // 
            this.txtGoalName.BorderRadius = 6;
            this.txtGoalName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGoalName.DefaultText = "";
            this.txtGoalName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGoalName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGoalName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGoalName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGoalName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGoalName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGoalName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGoalName.Location = new System.Drawing.Point(120, 55);
            this.txtGoalName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.PlaceholderText = "e.g.Buy a new laptop";
            this.txtGoalName.SelectedText = "";
            this.txtGoalName.Size = new System.Drawing.Size(287, 40);
            this.txtGoalName.TabIndex = 2;
            this.txtGoalName.TextChanged += new System.EventHandler(this.txtGoalName_TextChanged);
            // 
            // lblGoalName
            // 
            this.lblGoalName.AutoSize = true;
            this.lblGoalName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblGoalName.Location = new System.Drawing.Point(23, 66);
            this.lblGoalName.Name = "lblGoalName";
            this.lblGoalName.Size = new System.Drawing.Size(90, 20);
            this.lblGoalName.TabIndex = 1;
            this.lblGoalName.Text = "Goal name :";
            // 
            // lblNewGoalHeader
            // 
            this.lblNewGoalHeader.AutoSize = true;
            this.lblNewGoalHeader.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNewGoalHeader.ForeColor = System.Drawing.Color.Green;
            this.lblNewGoalHeader.Location = new System.Drawing.Point(26, 15);
            this.lblNewGoalHeader.Name = "lblNewGoalHeader";
            this.lblNewGoalHeader.Size = new System.Drawing.Size(177, 23);
            this.lblNewGoalHeader.TabIndex = 0;
            this.lblNewGoalHeader.Text = "NEW SAVINGS GOAL";
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BorderColor = System.Drawing.Color.Black;
            this.pnlChucNang.BorderRadius = 10;
            this.pnlChucNang.BorderThickness = 1;
            this.pnlChucNang.Controls.Add(this.btnLamMoi);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.FillColor = System.Drawing.Color.White;
            this.pnlChucNang.Location = new System.Drawing.Point(1030, 318);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(305, 236);
            this.pnlChucNang.TabIndex = 10;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderColor = System.Drawing.Color.Silver;
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.BorderThickness = 1;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(38, 175);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(232, 45);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.Silver;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.BorderThickness = 1;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(38, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(232, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderColor = System.Drawing.Color.Silver;
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
            this.btnSua.Location = new System.Drawing.Point(38, 65);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(232, 45);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Edit";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.Silver;
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
            this.btnThem.Location = new System.Drawing.Point(38, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(232, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Add";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblLisHeader
            // 
            this.lblLisHeader.AutoSize = true;
            this.lblLisHeader.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLisHeader.ForeColor = System.Drawing.Color.Green;
            this.lblLisHeader.Location = new System.Drawing.Point(239, 574);
            this.lblLisHeader.Name = "lblLisHeader";
            this.lblLisHeader.Size = new System.Drawing.Size(184, 25);
            this.lblLisHeader.TabIndex = 11;
            this.lblLisHeader.Text = "SAVING GOALS LIST";
            // 
            // dgvSavings
            // 
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvSavings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle50;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSavings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.dgvSavings.ColumnHeadersHeight = 22;
            this.dgvSavings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSavings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colGoalName,
            this.colTargetAmount,
            this.colSavedAmount,
            this.colProgress,
            this.colTargetDate,
            this.colStatus});
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSavings.DefaultCellStyle = dataGridViewCellStyle56;
            this.dgvSavings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvSavings.Location = new System.Drawing.Point(234, 618);
            this.dgvSavings.Name = "dgvSavings";
            this.dgvSavings.RowHeadersVisible = false;
            this.dgvSavings.RowHeadersWidth = 51;
            this.dgvSavings.RowTemplate.Height = 24;
            this.dgvSavings.Size = new System.Drawing.Size(1101, 252);
            this.dgvSavings.TabIndex = 12;
            this.dgvSavings.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dgvSavings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvSavings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvSavings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvSavings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvSavings.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvSavings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvSavings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvSavings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSavings.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSavings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvSavings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSavings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSavings_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            // 
            // colGoalName
            // 
            this.colGoalName.HeaderText = "Goal Name";
            this.colGoalName.MinimumWidth = 6;
            this.colGoalName.Name = "colGoalName";
            // 
            // colTargetAmount
            // 
            this.colTargetAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTargetAmount.DefaultCellStyle = dataGridViewCellStyle52;
            this.colTargetAmount.HeaderText = "TargetAmount";
            this.colTargetAmount.MinimumWidth = 6;
            this.colTargetAmount.Name = "colTargetAmount";
            // 
            // colSavedAmount
            // 
            this.colSavedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSavedAmount.DefaultCellStyle = dataGridViewCellStyle53;
            this.colSavedAmount.HeaderText = "Saved Amount";
            this.colSavedAmount.MinimumWidth = 6;
            this.colSavedAmount.Name = "colSavedAmount";
            // 
            // colProgress
            // 
            this.colProgress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProgress.DefaultCellStyle = dataGridViewCellStyle54;
            this.colProgress.HeaderText = "Progress";
            this.colProgress.MinimumWidth = 6;
            this.colProgress.Name = "colProgress";
            // 
            // colTargetDate
            // 
            this.colTargetDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTargetDate.DefaultCellStyle = dataGridViewCellStyle55;
            this.colTargetDate.HeaderText = "Target Date";
            this.colTargetDate.MinimumWidth = 6;
            this.colTargetDate.Name = "colTargetDate";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // chkInProgress
            // 
            this.chkInProgress.AutoSize = true;
            this.chkInProgress.Checked = true;
            this.chkInProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.chkInProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chkInProgress.Location = new System.Drawing.Point(1046, 581);
            this.chkInProgress.Name = "chkInProgress";
            this.chkInProgress.Size = new System.Drawing.Size(128, 24);
            this.chkInProgress.TabIndex = 14;
            this.chkInProgress.Text = "In Progress";
            this.chkInProgress.UseVisualStyleBackColor = true;
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Checked = true;
            this.chkCompleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.chkCompleted.Location = new System.Drawing.Point(1201, 581);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(120, 24);
            this.chkCompleted.TabIndex = 13;
            this.chkCompleted.Text = "Completed";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // frmSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 903);
            this.Controls.Add(this.chkInProgress);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.dgvSavings);
            this.Controls.Add(this.lblLisHeader);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlNewGoalBox);
            this.Controls.Add(this.pnlRemaining);
            this.Controls.Add(this.pnlSaved);
            this.Controls.Add(this.pnlTarget);
            this.Controls.Add(this.pnlGoals);
            this.Controls.Add(this.lblPageTitle);
            this.Name = "frmSavings";
            this.Text = "Savings";
            this.Load += new System.EventHandler(this.frmSavings_Load);
            this.pnlGoals.ResumeLayout(false);
            this.pnlGoals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoals)).EndInit();
            this.pnlTarget.ResumeLayout(false);
            this.pnlTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).EndInit();
            this.pnlSaved.ResumeLayout(false);
            this.pnlSaved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaved)).EndInit();
            this.pnlRemaining.ResumeLayout(false);
            this.pnlRemaining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemaining)).EndInit();
            this.pnlNewGoalBox.ResumeLayout(false);
            this.pnlNewGoalBox.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlGoals;
        private Guna.UI2.WinForms.Guna2Panel pnlTarget;
        private Guna.UI2.WinForms.Guna2Panel pnlSaved;
        private Guna.UI2.WinForms.Guna2Panel pnlRemaining;
        private Guna.UI2.WinForms.Guna2PictureBox picGoals;
        private Guna.UI2.WinForms.Guna2PictureBox picTarget;
        private Guna.UI2.WinForms.Guna2PictureBox picSaved;
        private Guna.UI2.WinForms.Guna2PictureBox picRemaining;
        private System.Windows.Forms.Label lblTotalGoals;
        private System.Windows.Forms.Label lblNumGoals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalTargetAmount;
        private System.Windows.Forms.Label lblTotalSaved;
        private System.Windows.Forms.Label lblTotalSavedAmount;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblRemainingAmount;
        private Guna.UI2.WinForms.Guna2Panel pnlNewGoalBox;
        private System.Windows.Forms.Label lblNewGoalHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtGoalName;
        private System.Windows.Forms.Label lblGoalName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTargetDate;
        private System.Windows.Forms.Label lblTargetDate;
        private Guna.UI2.WinForms.Guna2TextBox txtTargetAmount;
        private System.Windows.Forms.Label lblTargetAmount;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtInitialAmount;
        private System.Windows.Forms.Label lblInitiaAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2Panel pnlChucNang;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.Label lblLisHeader;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSavings;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTargetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSavedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTargetDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label lblTotalTarget;
        private System.Windows.Forms.CheckBox chkInProgress;
        private System.Windows.Forms.CheckBox chkCompleted;
    }
}