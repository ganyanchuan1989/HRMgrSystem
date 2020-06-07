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

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if(dao.FindByDate(dtStartDate.Text).Count > 0)
            {
                MessageBoxEx.Show(this, dtStartDate.Text + "已经请过假了，请选择其他日期");
                return;
            }
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
