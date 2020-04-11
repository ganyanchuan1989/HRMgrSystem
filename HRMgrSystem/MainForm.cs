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
        private JobForm jobForm;
        private EmployeeForm empForm ;
        private ContractForm contractForm ;
        private DeptForm1 deptForm ;
        private WorkLogForm wlForm ;
        private RewardsPunishmentsForm rpForm ;
        private UserForm userForm;
        private ChangePwdForm cpForm;

        public MainForm()
        {
            InitializeComponent();
            // 菜单权限
            userAuthority();
            // DBUtils.Test();
        }

        /// <summary>
        /// 用户权限判断
        /// </summary>
        private void userAuthority()
        {
            menuItemContract.Visible = false;
            menuItemEmployee.Visible = false;
            menuItemDept.Visible = false;
            menuItemJob.Visible = false;
            menuItemWorkLog.Visible = false;
            menuItemJC.Visible = false;
            menuItemMgr.Visible = false;


            // 1: 普通用户;2: 管理员
            if (GlobalInfo.loginUser.UserType == 1)
            {
                menuItemWorkLog.Visible = true;
                GlobalInfo.IS_ADMIN = false;
            }
            else if (GlobalInfo.loginUser.UserType == 2)
            {
                GlobalInfo.IS_ADMIN = true;
                menuItemContract.Visible = true;
                menuItemEmployee.Visible = true;
                menuItemDept.Visible = true;
                menuItemJob.Visible = true;
                menuItemWorkLog.Visible = true;
                menuItemJC.Visible = true;
                menuItemMgr.Visible = true;
            }
        }

        
        private void menuItemDeptJob_Click(object sender, EventArgs e)
        {
            if(jobForm == null)
            {
                jobForm = new JobForm();
                jobForm.FormClosed += JobForm_FormClosed;
            }

            ShowChildForm(jobForm);            ;
        }

        private void JobForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            jobForm = null;
        }

        private void menuItemDeptEmployee_Click(object sender, EventArgs e)
        {
            if(empForm == null)
            {
                empForm = new EmployeeForm();
                empForm.FormClosed += EmployeeForm_FormClosed;
            }
            ShowChildForm(empForm);
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            empForm = null;
        }

        private void menuItemDeptContract_Click(object sender, EventArgs e)
        {
            if(contractForm == null)
            {
                contractForm = new ContractForm();
                contractForm.FormClosed += ContractForm_FormClosed;
            }
            ShowChildForm(contractForm);
        }
        private void ContractForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            contractForm = null;
        }

        private void menuItemDept_Click(object sender, EventArgs e)
        {
            if(deptForm == null)
            {
                deptForm = new DeptForm1();
                deptForm.FormClosed += DeptForm1Form_FormClosed;
            }
            ShowChildForm(deptForm);
        }

        private void DeptForm1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            deptForm = null;
        }

        private void menuItemDeptWorkLog_Click(object sender, EventArgs e)
        {
            if(wlForm == null)
            {
                wlForm = new WorkLogForm();
                wlForm.FormClosed += WorkLogForm_FormClosed;
            }
            ShowChildForm(wlForm);
        }

        private void WorkLogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wlForm = null;
        }

        private void ShowChildForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }

        private void 奖惩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(rpForm == null)
            {
                rpForm = new RewardsPunishmentsForm();
                rpForm.FormClosed += RewardsPunishmentsForm_FormClosed;
            } 
            ShowChildForm(rpForm);
        }

        private void RewardsPunishmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rpForm = null;
        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(userForm == null)
            {
                userForm = new UserForm();
                userForm.FormClosed += UserForm_FormClosed;
            }
            ShowChildForm(userForm);
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm = null;
        }

        private void menuItemChangePwd_Click(object sender, EventArgs e)
        {
            if(cpForm == null)
            {
                cpForm = new ChangePwdForm();
                cpForm.FormClosed += ChangePwdForm_FormClosed;
            }
            ShowChildForm(cpForm);
        }

        private void ChangePwdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cpForm = null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
