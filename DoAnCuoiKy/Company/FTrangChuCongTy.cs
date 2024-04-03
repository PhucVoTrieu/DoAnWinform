﻿using DoAnCuoiKy.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class FTrangChuCongTy : Form
    {
        public FTrangChuCongTy()
        {
            InitializeComponent();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenForm(new FInformation());
        }
        private Form currentFormChild;
        private void OpenForm(Form form)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            pnlContent.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnApplicants_Click(object sender, EventArgs e)
        {
            OpenForm(new FApplicants());

        }

        private void btnPostAJob_Click(object sender, EventArgs e)
        {
            FPostAJob fp1 = new FPostAJob();
            fp1.ShowDialog();

        }
        private void btnJobs_Click(object sender, EventArgs e)
        {
            OpenForm(new FJobs());
        }

        private void btnFavApplicants_Click(object sender, EventArgs e)
        {
            OpenForm(new FFavoriteApplicants());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            OpenForm(new FStatistic());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f1 = new FLogin();
            f1.Show();
        }
    }
}