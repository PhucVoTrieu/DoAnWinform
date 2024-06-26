﻿namespace DoAnCuoiKy
{
    partial class FJobs
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
            this.components = new System.ComponentModel.Container();
            this.ScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.pnlCreatedJob = new System.Windows.Forms.FlowLayoutPanel();
            this.RecommendJobsElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.JobFilterElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlJobFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackbarSalary = new Guna.UI2.WinForms.Guna2TrackBar();
            this.checkboxTemporary = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkboxFullTime = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkboxPartTime = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkbox5To10 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkboxLessThan3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkbox3To5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewProfileElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FindingBoxElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FormFindingCandidateElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtJobName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCountCreatedJobs = new Guna.UI2.WinForms.Guna2Button();
            this.pnlJobFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScrollBar1
            // 
            this.ScrollBar1.AutoRoundedCorners = true;
            this.ScrollBar1.AutoScroll = true;
            this.ScrollBar1.BindingContainer = this.pnlCreatedJob;
            this.ScrollBar1.BorderRadius = 8;
            this.ScrollBar1.InUpdate = false;
            this.ScrollBar1.LargeChange = 10;
            this.ScrollBar1.Location = new System.Drawing.Point(938, 192);
            this.ScrollBar1.Name = "ScrollBar1";
            this.ScrollBar1.ScrollbarSize = 18;
            this.ScrollBar1.Size = new System.Drawing.Size(18, 595);
            this.ScrollBar1.TabIndex = 26;
            // 
            // pnlCreatedJob
            // 
            this.pnlCreatedJob.AutoScroll = true;
            this.pnlCreatedJob.Location = new System.Drawing.Point(12, 192);
            this.pnlCreatedJob.Name = "pnlCreatedJob";
            this.pnlCreatedJob.Size = new System.Drawing.Size(944, 595);
            this.pnlCreatedJob.TabIndex = 32;
            // 
            // RecommendJobsElipse
            // 
            this.RecommendJobsElipse.BorderRadius = 15;
            this.RecommendJobsElipse.TargetControl = this.pnlCreatedJob;
            // 
            // JobFilterElipse
            // 
            this.JobFilterElipse.BorderRadius = 20;
            this.JobFilterElipse.TargetControl = this.pnlJobFilter;
            // 
            // pnlJobFilter
            // 
            this.pnlJobFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.pnlJobFilter.Controls.Add(this.label8);
            this.pnlJobFilter.Controls.Add(this.label13);
            this.pnlJobFilter.Controls.Add(this.label12);
            this.pnlJobFilter.Controls.Add(this.trackbarSalary);
            this.pnlJobFilter.Controls.Add(this.checkboxTemporary);
            this.pnlJobFilter.Controls.Add(this.checkboxFullTime);
            this.pnlJobFilter.Controls.Add(this.label7);
            this.pnlJobFilter.Controls.Add(this.checkboxPartTime);
            this.pnlJobFilter.Controls.Add(this.checkbox5To10);
            this.pnlJobFilter.Controls.Add(this.checkboxLessThan3);
            this.pnlJobFilter.Controls.Add(this.checkbox3To5);
            this.pnlJobFilter.Controls.Add(this.label6);
            this.pnlJobFilter.Location = new System.Drawing.Point(962, 191);
            this.pnlJobFilter.Name = "pnlJobFilter";
            this.pnlJobFilter.Size = new System.Drawing.Size(208, 595);
            this.pnlJobFilter.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Salary Range";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "5000$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "0$";
            // 
            // trackbarSalary
            // 
            this.trackbarSalary.FillColor = System.Drawing.Color.White;
            this.trackbarSalary.Location = new System.Drawing.Point(30, 294);
            this.trackbarSalary.Name = "trackbarSalary";
            this.trackbarSalary.Size = new System.Drawing.Size(148, 31);
            this.trackbarSalary.TabIndex = 33;
            this.trackbarSalary.ThumbColor = System.Drawing.Color.Black;
            // 
            // checkboxTemporary
            // 
            this.checkboxTemporary.AutoSize = true;
            this.checkboxTemporary.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxTemporary.CheckedState.BorderRadius = 0;
            this.checkboxTemporary.CheckedState.BorderThickness = 0;
            this.checkboxTemporary.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkboxTemporary.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxTemporary.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkboxTemporary.Location = new System.Drawing.Point(30, 217);
            this.checkboxTemporary.Name = "checkboxTemporary";
            this.checkboxTemporary.Size = new System.Drawing.Size(90, 21);
            this.checkboxTemporary.TabIndex = 32;
            this.checkboxTemporary.Text = "Temporary";
            this.checkboxTemporary.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkboxTemporary.UncheckedState.BorderRadius = 0;
            this.checkboxTemporary.UncheckedState.BorderThickness = 1;
            this.checkboxTemporary.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // checkboxFullTime
            // 
            this.checkboxFullTime.AutoSize = true;
            this.checkboxFullTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxFullTime.CheckedState.BorderRadius = 0;
            this.checkboxFullTime.CheckedState.BorderThickness = 0;
            this.checkboxFullTime.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkboxFullTime.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxFullTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkboxFullTime.Location = new System.Drawing.Point(30, 190);
            this.checkboxFullTime.Name = "checkboxFullTime";
            this.checkboxFullTime.Size = new System.Drawing.Size(76, 21);
            this.checkboxFullTime.TabIndex = 31;
            this.checkboxFullTime.Text = "Full-time";
            this.checkboxFullTime.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkboxFullTime.UncheckedState.BorderRadius = 0;
            this.checkboxFullTime.UncheckedState.BorderThickness = 1;
            this.checkboxFullTime.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Job type";
            // 
            // checkboxPartTime
            // 
            this.checkboxPartTime.AutoSize = true;
            this.checkboxPartTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxPartTime.CheckedState.BorderRadius = 0;
            this.checkboxPartTime.CheckedState.BorderThickness = 0;
            this.checkboxPartTime.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkboxPartTime.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxPartTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkboxPartTime.Location = new System.Drawing.Point(30, 163);
            this.checkboxPartTime.Name = "checkboxPartTime";
            this.checkboxPartTime.Size = new System.Drawing.Size(80, 21);
            this.checkboxPartTime.TabIndex = 29;
            this.checkboxPartTime.Text = "Part-time";
            this.checkboxPartTime.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkboxPartTime.UncheckedState.BorderRadius = 0;
            this.checkboxPartTime.UncheckedState.BorderThickness = 1;
            this.checkboxPartTime.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // checkbox5To10
            // 
            this.checkbox5To10.AutoSize = true;
            this.checkbox5To10.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkbox5To10.CheckedState.BorderRadius = 0;
            this.checkbox5To10.CheckedState.BorderThickness = 0;
            this.checkbox5To10.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkbox5To10.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkbox5To10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkbox5To10.Location = new System.Drawing.Point(30, 105);
            this.checkbox5To10.Name = "checkbox5To10";
            this.checkbox5To10.Size = new System.Drawing.Size(61, 21);
            this.checkbox5To10.TabIndex = 28;
            this.checkbox5To10.Text = "5 - 10";
            this.checkbox5To10.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkbox5To10.UncheckedState.BorderRadius = 0;
            this.checkbox5To10.UncheckedState.BorderThickness = 1;
            this.checkbox5To10.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // checkboxLessThan3
            // 
            this.checkboxLessThan3.AutoSize = true;
            this.checkboxLessThan3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxLessThan3.CheckedState.BorderRadius = 0;
            this.checkboxLessThan3.CheckedState.BorderThickness = 0;
            this.checkboxLessThan3.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkboxLessThan3.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkboxLessThan3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkboxLessThan3.Location = new System.Drawing.Point(30, 51);
            this.checkboxLessThan3.Name = "checkboxLessThan3";
            this.checkboxLessThan3.Size = new System.Drawing.Size(92, 21);
            this.checkboxLessThan3.TabIndex = 0;
            this.checkboxLessThan3.Text = "Less than 3";
            this.checkboxLessThan3.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkboxLessThan3.UncheckedState.BorderRadius = 0;
            this.checkboxLessThan3.UncheckedState.BorderThickness = 1;
            this.checkboxLessThan3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // checkbox3To5
            // 
            this.checkbox3To5.AutoSize = true;
            this.checkbox3To5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkbox3To5.CheckedState.BorderRadius = 0;
            this.checkbox3To5.CheckedState.BorderThickness = 0;
            this.checkbox3To5.CheckedState.FillColor = System.Drawing.Color.White;
            this.checkbox3To5.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            this.checkbox3To5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkbox3To5.Location = new System.Drawing.Point(30, 78);
            this.checkbox3To5.Name = "checkbox3To5";
            this.checkbox3To5.Size = new System.Drawing.Size(54, 21);
            this.checkbox3To5.TabIndex = 27;
            this.checkbox3To5.Text = "3 - 5";
            this.checkbox3To5.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.checkbox3To5.UncheckedState.BorderRadius = 0;
            this.checkbox3To5.UncheckedState.BorderThickness = 1;
            this.checkbox3To5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(114)))), ((int)(((byte)(137)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Experience Years";
            // 
            // ViewProfileElipse
            // 
            this.ViewProfileElipse.BorderRadius = 20;
            // 
            // FindingBoxElipse
            // 
            this.FindingBoxElipse.BorderRadius = 20;
            // 
            // FormFindingCandidateElipse
            // 
            this.FormFindingCandidateElipse.BorderRadius = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(998, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 35;
            this.label5.Text = "Job Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Created Jobs";
            // 
            // cbxLocation
            // 
            this.cbxLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbxLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.cbxLocation.BorderRadius = 10;
            this.cbxLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxLocation.ItemHeight = 46;
            this.cbxLocation.Items.AddRange(new object[] {
            "",
            "Ha Noi",
            "Ho Chi Minh",
            "Hai Phong"});
            this.cbxLocation.Location = new System.Drawing.Point(156, 34);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(196, 52);
            this.cbxLocation.StartIndex = 0;
            this.cbxLocation.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(873, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 52);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtJobName
            // 
            this.txtJobName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.txtJobName.BorderRadius = 10;
            this.txtJobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobName.DefaultText = "";
            this.txtJobName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJobName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJobName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJobName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobName.IconLeft = global::DoAnCuoiKy.Properties.Resources._871;
            this.txtJobName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtJobName.Location = new System.Drawing.Point(358, 34);
            this.txtJobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.PasswordChar = '\0';
            this.txtJobName.PlaceholderText = "Search jobs by name and location";
            this.txtJobName.SelectedText = "";
            this.txtJobName.Size = new System.Drawing.Size(508, 52);
            this.txtJobName.TabIndex = 36;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(811, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 32);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextOffset = new System.Drawing.Point(0, -2);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCountCreatedJobs
            // 
            this.btnCountCreatedJobs.AutoRoundedCorners = true;
            this.btnCountCreatedJobs.BorderRadius = 17;
            this.btnCountCreatedJobs.BorderThickness = 1;
            this.btnCountCreatedJobs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCountCreatedJobs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCountCreatedJobs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCountCreatedJobs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCountCreatedJobs.Enabled = false;
            this.btnCountCreatedJobs.FillColor = System.Drawing.Color.Transparent;
            this.btnCountCreatedJobs.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountCreatedJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.btnCountCreatedJobs.Location = new System.Drawing.Point(214, 147);
            this.btnCountCreatedJobs.Name = "btnCountCreatedJobs";
            this.btnCountCreatedJobs.Size = new System.Drawing.Size(81, 37);
            this.btnCountCreatedJobs.TabIndex = 49;
            this.btnCountCreatedJobs.Text = "3";
            // 
            // FJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1167, 800);
            this.Controls.Add(this.ScrollBar1);
            this.Controls.Add(this.btnCountCreatedJobs);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxLocation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.pnlCreatedJob);
            this.Controls.Add(this.pnlJobFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FJobs";
            this.Text = "FJobs";
            this.pnlJobFilter.ResumeLayout(false);
            this.pnlJobFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2VScrollBar ScrollBar1;
        public System.Windows.Forms.FlowLayoutPanel pnlCreatedJob;
        public Guna.UI2.WinForms.Guna2Elipse RecommendJobsElipse;
        public Guna.UI2.WinForms.Guna2Elipse JobFilterElipse;
        public Guna.UI2.WinForms.Guna2Panel pnlJobFilter;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public Guna.UI2.WinForms.Guna2TrackBar trackbarSalary;
        public Guna.UI2.WinForms.Guna2CheckBox checkboxTemporary;
        public Guna.UI2.WinForms.Guna2CheckBox checkboxFullTime;
        public System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2CheckBox checkboxPartTime;
        public Guna.UI2.WinForms.Guna2CheckBox checkbox5To10;
        public Guna.UI2.WinForms.Guna2CheckBox checkboxLessThan3;
        public Guna.UI2.WinForms.Guna2CheckBox checkbox3To5;
        public System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2Elipse ViewProfileElipse;
        public Guna.UI2.WinForms.Guna2Elipse FindingBoxElipse;
        public Guna.UI2.WinForms.Guna2Elipse FormFindingCandidateElipse;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2ComboBox cbxLocation;
        public Guna.UI2.WinForms.Guna2Button btnSearch;
        public Guna.UI2.WinForms.Guna2TextBox txtJobName;
        public Guna.UI2.WinForms.Guna2Button btnDelete;
        public Guna.UI2.WinForms.Guna2Button btnCountCreatedJobs;
    }
}