﻿using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using System.Windows.Forms.DataVisualization.Charting;
using DoAnCuoiKy.Class;

namespace DoAnCuoiKy
{
    public partial class FJobDetails : Form
    {
        Job jobInfo;
        DoAnCuoiKyEntities db = new DoAnCuoiKyEntities();
        public FJobDetails()
        {
            InitializeComponent();
        }
        public FJobDetails(Job j1 )
        {
            InitializeComponent();
            this.jobInfo = j1;
            var inforCompany = from c in db.Companies where c.CompanyID == j1.CompanyID select c;
            var result = inforCompany.First();
            this.lblJobTitle.Text = j1.JobTitle.ToString();
            this.lblCompanyName.Text = result.CompanyName.ToString();
            this.labelCompanyName2.Text = result.CompanyName.ToString();
            this.lblCompanySize.Text = result.CompanySize.ToString();
            this.lblCompanyType.Text = result.CompanyType.ToString();
            this.lblCountry.Text = result.CompanyCountry.ToString();
            this.lblWorkingday.Text = result.CompanyWorkingDays.ToString();
            this.lblSalary.Text = j1.JobSalary.ToString();
            this.lblJobDescription.Text = j1.JobDescription.ToString();
            this.lblJobBenefit.Text = j1.JobBenefit.ToString();
            this.lblJobRequirement.Text = j1.JobRequirement.ToString();
            this.pnlDetails.Size = new Size(this.pnlDetails.Width, this.lblJobBenefit.Location.Y-this.pnlJobDetails.Location.Y+30);
        }
        private void btnCompanyName_Click(object sender, EventArgs e)
        {
            
        }

        private void btnApplyNow_Click(object sender, EventArgs e)
        {
            FProfileApplicant f1 = new FProfileApplicant();
            f1.Show();
        }

        private void btnViewCompany_Click(object sender, EventArgs e)
        {
            FInformation f1 = new FInformation();
            f1.Show();
        }

        private void btnApplyNow_Click_1(object sender, EventArgs e)
        {
            CompanyDAO companyDAO = new CompanyDAO();
            companyDAO.ThemApplicant(Constant.ApplicantID,(int)this.jobInfo.CompanyID);
        }
    }
}
