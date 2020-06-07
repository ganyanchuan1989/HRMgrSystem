using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMgrSystem.vo;
using HRMgrSystem.db;
using HRMgrSystem.utils;

namespace HRMgrSystem
{
    public partial class HomeForm : Form
    {
        private EmployeeDao dao = new EmployeeDao();
        private Action qjsq;
        private Action qjsp;
        private Action wdqj;
        private Action wdht;
        private Action wdgzd;
        private Action xgmm;

        public HomeForm(Action qjsq, Action qjsp, Action wdqj, Action wdht, Action wdgzd, Action xgmm)
        {
            InitializeComponent();
            InitEmpInfo();

            this.qjsq = qjsq;
            this.qjsp = qjsp;
            this.wdqj = wdqj;
            this.wdht = wdht;
            this.wdgzd = wdgzd;
            this.xgmm = xgmm;
        }

        private void InitEmpInfo()
        {
            HREmployee empVo = GlobalInfo.loginEmp;
            if (empVo != null)
            {
                txtBankCard.Text = empVo.BankCard;
                txtIdCard.Text = empVo.IdCard;
                txtDeptName.Text = empVo.DeptName;
                txtJobName.Text = empVo.JobName;
                txtMail.Text = empVo.Email;
                txtTel.Text = empVo.Telephone;
                txtSchool.Text = empVo.School;
                txtPro.Text = empVo.Profession;
                txtBYSJ.Text = empVo.GraduationTime;
                lblName.Text += " " + empVo.Name;
            }
            if(GlobalInfo.loginUser.UserType == GlobalInfo.ADMIN)
            {
                // 管理员
                btnQJSQ.Enabled = false;
                btnWDQJ.Enabled = false;
                btnWDHT.Enabled = false;

                btnWDGZD.Text = "工资单";
            }
            else if(GlobalInfo.loginUser.UserType == GlobalInfo.EMP)
            {
                // 普通员工
                btnQJSP.Enabled = false;
            }
        }

        private void btnQJSQ_Click(object sender, EventArgs e)
        {
            this.qjsq();
        }

        private void btnQJSP_Click(object sender, EventArgs e)
        {
            this.qjsp();
        }

        private void btnWDQJ_Click(object sender, EventArgs e)
        {
            this.wdqj();
        }

        private void btnWDHT_Click(object sender, EventArgs e)
        {
            this.wdht();
        }

        private void btnWDGZD_Click(object sender, EventArgs e)
        {
            this.wdgzd();
        }

        private void btnXGMM_Click(object sender, EventArgs e)
        {
            this.xgmm();
        }
    }
}
