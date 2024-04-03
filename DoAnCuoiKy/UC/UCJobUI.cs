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

namespace DoAnCuoiKy
{
    public partial class UCJobUI : UserControl
    {
        JobDetails jobDetails;
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        DBconnection db = new DBconnection();
        FavJobDAO favoriteJobDAO = new FavJobDAO();
        public UCJobUI()
        {
            InitializeComponent();
        }
        public UCJobUI(JobDetails j1)
        {
            InitializeComponent();
            this.jobDetails = j1;

            this.lblJobTitle.Text = j1.JobTitle;
            this.lblJobPosition.Text = j1.JobPosition;
            this.txtJobtype.Text = j1.JobType;
            this.lblSalary.Text = j1.JobSalary;
            this.lblLocation.Text = j1.Location;
            this.txtExpYear.Text = j1.ExpInYears;
            
        }
        private void btnDetails_Click_1(object sender, EventArgs e)
        {
            FJobDetails f1 = new FJobDetails(this.jobDetails);
       
            f1.ShowDialog();
        }

        private void btnApplyNow_Click(object sender, EventArgs e)
        {

        }
        private void btnFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if(this.btnFavorite.Checked)
            {
                favoriteJobDAO.them(this.jobDetails);
            }
            else
            {
                favoriteJobDAO.xoa(this.jobDetails);
            }

            
        }
    }
}