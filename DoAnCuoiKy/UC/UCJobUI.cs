﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;
using DoAnCuoiKy.Class;
using System.IO;

namespace DoAnCuoiKy
{
    public partial class UCJobUI : UserControl
    {
        public Job job;
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();

        public UCJobUI()
        {
            InitializeComponent();
        }
        public UCJobUI(Job j1)
        {
            InitializeComponent();
            this.job = j1;
            this.lblJobTitle.Text = j1.JobTitle;
            this.txtJobtype.Text = j1.JobType;
            this.lblSalary.Text = j1.JobSalary;
            this.lblLocation.Text = j1.Location;
            this.txtExpYear.Text = j1.ExpInYears;

            if (job.Company.CompanyAvatar != null)
            {
                this.pboxCompanyLogo.Image = Image.FromFile(Path.Combine(Constant.appDirectory, job.Company.CompanyAvatar));
            }

        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (FJobDetails f1 = new FJobDetails(this.job))
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = false;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    f1.Owner = formBackground;
                    f1.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
            
        }
   
        private void btnApplyNow_Click_1(object sender, EventArgs e)
        {
            
            CompanyDAO companyDAO = new CompanyDAO();
            companyDAO.ThemApplicant(Constant.ApplicantID, this.job);
            this.btnApplyNow.Enabled = false;
            this.btnApplyNow.Text = "Applied";
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            JobsDAO jobsDAO = new JobsDAO();
            if (this.btnFavorite.Checked)
            {
                jobsDAO.YeuThich(this.job);
            }
            else
            {
                jobsDAO.HuyYeuThich(this.job);
            }
        }
    }
}
