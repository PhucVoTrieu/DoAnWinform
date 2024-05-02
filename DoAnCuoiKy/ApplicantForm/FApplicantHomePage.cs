﻿using System;
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
    public partial class FApplicantHomePage : Form
    {
        public Applicant Applicant;
        public FApplicantHomePage()
        {
            InitializeComponent();
            OpenForm(new FFindingCandidate(this.Applicant));
        }
        public FApplicantHomePage(Applicant applicant)
        {
            this.Applicant = applicant;
            InitializeComponent();
            OpenForm(new FFindingCandidate(this.Applicant));
            
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
            pnlContentCandidate.Controls.Add(form);
            pnlContentCandidate.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnFindding_Click(object sender, EventArgs e)
        {
            OpenForm(new FFindingCandidate(this.Applicant));
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            OpenForm(new FormFavoriteJobs());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FProfileApplicant fProfileApplicant = new FProfileApplicant();
            fProfileApplicant.guna2ControlBox1.Hide();
            OpenForm(fProfileApplicant);

        }

        private void btnPostJobFinding_Click(object sender, EventArgs e)
        {
            OpenForm(new FPostCV());

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f1 = new FLogin();
            f1.Show();
        }
    }
}
