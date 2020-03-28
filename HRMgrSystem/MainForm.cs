using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HRMgrSystem.db;
using HRMgrSystem.vo;
using Dapper;
using Dapper.FluentColumnMapping;

namespace HRMgrSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            VoMapping.Mapping();
            DBUtils.Test();

        }

        private void menuItemDeptJob_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm();
            jobForm.MdiParent = this;
            jobForm.Show();
        }

        private void menuItemDeptEmployee_Click(object sender, EventArgs e)
        {

        }

        private void menuItemDeptContract_Click(object sender, EventArgs e)
        {

        }

        private void menuItemDeptUser_Click(object sender, EventArgs e)
        {

        }

        private void menuItemDept_Click(object sender, EventArgs e)
        {
            DeptForm deptF = new DeptForm();
            ShowChildForm(deptF);
        }

        private void menuItemDeptWorkLog_Click(object sender, EventArgs e)
        {

        }

        private void ShowChildForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
    }
}
