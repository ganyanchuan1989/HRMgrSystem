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
        private DeptForm deptForm ;
        private UserForm userForm;
        private ChangePwdForm cpForm;

        private LeaveApplyForm leaveApplyForm;
        private MyLeaveForm myLeaveForm;
        private MyContractForm myContractForm;
        private MyPayrollForm myPayrollForm;

        private PayrollForm payrollForm;
        private LeaveApproveForm leaveApproveForm;


        public MainForm()
        {
            InitializeComponent();
            // 菜单权限
            userAuthority();
            // DBUtils.Test();

            showHomeForm();
        }
        private HomeForm homeForm;

        private void showHomeForm()
        {
            if (homeForm == null || homeForm.IsDisposed)
            {
                homeForm = new HomeForm(
                () => {
                    this.请假申请ToolStripMenuItem_Click(null, null);
                },
                () => {
                    this.请假审批ToolStripMenuItem_Click(null, null);
                },
                () => {
                    this.我的请假ToolStripMenuItem_Click(null, null);
                },
                () => {
                    this.我的合同ToolStripMenuItem_Click(null, null);
                },
                () => {
                    this.我的工资单ToolStripMenuItem_Click(null, null);
                },
                () => {
                    this.修改密码ToolStripMenuItem_Click(null, null);
                });
            }
            ShowChildForm(homeForm);
        }

        /// <summary>
        /// 用户权限判断
        /// </summary>
        private void userAuthority()
        {
            menuItemUser.Visible = false;
            menuItemEmployee.Visible = false;
            menuItemContract.Visible = false;
            menuItemDept.Visible = false;
            menuItemJob.Visible = false;
            menuItemPayroll.Visible = false;
            
            // 0：部门经理；1: 普通用户;2: 管理员
            if (GlobalInfo.loginUser.UserType == GlobalInfo.ADMIN)
            {
                menuItemUser.Visible = true;
                menuItemEmployee.Visible = true;
                menuItemContract.Visible = true;
                menuItemDept.Visible = true;
                menuItemJob.Visible = true;
                menuItemPayroll.Visible = true;
            }
        }

        
        private void menuItemDeptJob_Click(object sender, EventArgs e)
        {
            if (jobForm == null || jobForm.IsDisposed)
            {
                jobForm = new JobForm();
            }
            ShowChildForm(jobForm);            ;
        }

        private void JobForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            jobForm = null;
        }

        private void menuItemDeptEmployee_Click(object sender, EventArgs e)
        {
            if (empForm == null || empForm.IsDisposed)
            {
                empForm = new EmployeeForm();
            }
            ShowChildForm(empForm);
        }

        private void menuItemDeptContract_Click(object sender, EventArgs e)
        {
            if (contractForm == null || contractForm.IsDisposed)
            {
                contractForm = new ContractForm();
            }
            ShowChildForm(contractForm);
        }
        private void menuItemDept_Click(object sender, EventArgs e)
        {
            if (deptForm == null || deptForm.IsDisposed)
            {
                deptForm = new DeptForm();
            }
            ShowChildForm(deptForm);
        }

        private void DeptForm1Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            deptForm = null;
        }

        private void ShowChildForm(Form f)
        {
            f.FormClosed += ChildForm_FormClosed;
            f.MdiParent = this;
            f.Show(); ;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.BringToFront();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = sender as Form;
            f.Dispose();
            f = null;
        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userForm == null || userForm.IsDisposed)
            {
                userForm = new UserForm();
            }
            ShowChildForm(userForm);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuItemUser_Click(object sender, EventArgs e)
        {
            if(userForm == null || userForm.IsDisposed)
            {
                userForm = new UserForm();
            }
            ShowChildForm(userForm);
        }

        private void 请假申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leaveApplyForm == null || leaveApplyForm.IsDisposed)
            {
                leaveApplyForm = new LeaveApplyForm();
            }
            ShowChildForm(leaveApplyForm);
        }

        private void 请假审批ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leaveApproveForm == null || leaveApproveForm.IsDisposed)
            {
                leaveApproveForm = new LeaveApproveForm();
            }
            ShowChildForm(leaveApproveForm);
        }

        private void 我的请假ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myLeaveForm == null || myLeaveForm.IsDisposed)
            {
                myLeaveForm = new MyLeaveForm();
            }
            ShowChildForm(myLeaveForm);
        }

        private void 我的合同ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myContractForm == null || myContractForm.IsDisposed)
            {
                myContractForm = new MyContractForm();
            }
            ShowChildForm(myContractForm);
        }

        private void 我的工资单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myPayrollForm == null || myPayrollForm.IsDisposed)
            {
                myPayrollForm = new MyPayrollForm();
            }
            ShowChildForm(myPayrollForm);
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cpForm == null || cpForm.IsDisposed)
            {
                cpForm = new ChangePwdForm();
            }
            ShowChildForm(cpForm);
        }

        private void 薪资管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (payrollForm == null || payrollForm.IsDisposed)
            {
                payrollForm = new PayrollForm();
            }
            ShowChildForm(payrollForm);
        }

        private void 我的主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHomeForm();
        }
    }
}
