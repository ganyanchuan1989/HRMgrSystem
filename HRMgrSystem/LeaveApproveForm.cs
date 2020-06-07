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
    public partial class LeaveApproveForm : Form
    {
        private LeaveDao dao = new LeaveDao();
        private EmployeeDao empDao = new EmployeeDao();


        private BindingSource listSource;
        private List<HRLeave> list = null;
        private List<HREmployee> empList = null;


        public LeaveApproveForm()
        {
            InitializeComponent();

            initData();
        }



        private void initData()
        {
            if(GlobalInfo.loginUser.UserType == GlobalInfo.DEPT_MGR)
            {
                // 默认查询提交状态的请假
                list = dao.FindByDeptMgr(1, GlobalInfo.loginEmp.DeptId, GlobalInfo.loginEmp.Id);

                empList = empDao.FindByDeptId(GlobalInfo.loginEmp.DeptId);
            }
            else if(GlobalInfo.loginUser.UserType == GlobalInfo.ADMIN)
            {
                list = dao.FindByAdmin(1);
                empList = empDao.FindByUserType(GlobalInfo.loginUser.UserType);
            }

            var bindingList = new BindingList<HRLeave>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = null;
            grid.DataSource = listSource;
            
            cboEmp.DataSource = empList;
            cboEmp.SelectedIndex = -1;

            cboStatus.DataSource = DataDictionaryUtils.GetLeaveStatusDict();
            cboStatus.SelectedIndex = -1;

        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataRow[] rows = null;

            if (grid.Columns[e.ColumnIndex].Name.Equals("gridLeaveType"))
            {
                rows = DataDictionaryUtils.GetLeaveTypeDict().Select("value=" + e.Value);
            }

            if (grid.Columns[e.ColumnIndex].Name.Equals("gridStatus"))
            {
                rows = DataDictionaryUtils.GetLeaveStatusDict().Select("value=" + e.Value);
            }

            if (rows != null)
            {
                e.Value = rows[0]["label"];
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            HRLeave vo = list[e.RowIndex];
            if(vo.Status == 1)
            {
                btnPass.Enabled = true;
                btnFail.Enabled = true;
            }
            else
            {
                btnPass.Enabled = false;
                btnFail.Enabled = false;
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            if(grid.CurrentRow != null && grid.CurrentRow.Index >= 0)
            {
                HRLeave vo = list[grid.CurrentRow.Index];
                dao.Update(vo.Id, 2); // 通过

                initData();
            }
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow.Index >= 0)
            {
                HRLeave vo = list[grid.CurrentRow.Index];
                dao.Update(vo.Id, 3); // 通过

                initData();
            }
        }

        /// <summary>
        /// 输入转VO
        /// </summary>
        /// <returns></returns>
        private HRLeave InputToVo()
        {
            HRLeave vo = new HRLeave();
            vo.Id = txtId.Text;
            vo.EmpId = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? cboEmp.SelectedValue.ToString() : "";
            vo.EmpName = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? ((HREmployee)cboEmp.SelectedItem).Name : "";
            vo.Status = !EmptyUtils.EmptyObj(cboStatus.SelectedValue) ? int.Parse(cboStatus.SelectedValue.ToString()) : -1;
            return vo;
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            HRLeave vo = InputToVo();

            if (GlobalInfo.loginUser.UserType == GlobalInfo.ADMIN)
            {
                list = dao.FindByWhereForAdmin(vo);
                var bindingList = new BindingList<HRLeave>(list);
                listSource = new BindingSource(bindingList, null);
                grid.DataSource = listSource;
            }
            else if(GlobalInfo.loginUser.UserType == GlobalInfo.DEPT_MGR)
            {

                list = dao.FindByWhereForMgr(vo, GlobalInfo.loginEmp.DeptId, GlobalInfo.loginEmp.Id);
                var bindingList = new BindingList<HRLeave>(list);
                listSource = new BindingSource(bindingList, null);
                grid.DataSource = listSource;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initData();
        }
    }
}
