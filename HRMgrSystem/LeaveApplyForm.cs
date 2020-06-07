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
    /// <summary>
    /// 请假申请表单
    /// </summary>
    public partial class LeaveApplyForm : Form
    {
        LeaveDao dao = new LeaveDao();

        public LeaveApplyForm()
        {
            InitializeComponent();

            cboLeaveType.DataSource = DataDictionaryUtils.GetLeaveTypeDict();
        }


        /// <summary>
        /// 验证输入
        /// </summary>
        /// <returns></returns>
        private bool validateInput()
        {
            if (EmptyUtils.EmptyObj(cboLeaveType.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择请假类型");
                cboLeaveType.Focus();
                return false;
            }
            if (EmptyUtils.EmptyStr(txtLeaveDay.Text))
            {
                MessageBoxEx.Show(this, "请输入请假天数");
                txtLeaveDay.Focus();
                return false;
            }

            if (EmptyUtils.IsNaN(txtLeaveDay.Text))
            {
                MessageBoxEx.Show(this, "请假天数格式不合法，请输入数字。");
                txtLeaveDay.Focus();
                return false;
            }

            if (EmptyUtils.EmptyStr(txtCause.Text))
            {
                MessageBoxEx.Show(this, "请输入请假原因");
                txtCause.Focus();
                return false;
            }
            return true;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if(dao.FindByDate(dtStartDate.Text).Count > 0)
            {
                MessageBoxEx.Show(this, dtStartDate.Text + "已经请过假了，请选择其他日期");
                return;
            }
            if (!validateInput()) return;

            HRLeave vo = new HRLeave();
            vo.Id = UidUtils.GGuidPrefix("LEAVE");
            vo.EmpId = GlobalInfo.loginEmp.Id;
            vo.Cause = txtCause.Text;
            vo.Type = !EmptyUtils.EmptyObj(cboLeaveType.SelectedValue) ? int.Parse(cboLeaveType.SelectedValue.ToString()) : -1;
            vo.LeaveDay = int.Parse(txtLeaveDay.Text);
            vo.LeaveDate = dtStartDate.Text;
            vo.Status = 1;// 提交申请
            dao.Add(vo);

            DialogResult ret = MessageBoxEx.Show(this,"请假提交成功");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
