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
    public partial class MyPayrollForm : Form
    {
        private EmployeeDao empDao = new EmployeeDao();
        private List<HREmployee> empList = null;

        private PayrollDao dao = new PayrollDao();
        private BindingSource listSource;
        private List<HRPayroll> list = null;

        public MyPayrollForm()
        {
            InitializeComponent();

            initData();
        }

        private void initData()
        {
            this.dtTime.CustomFormat = " ";

            if (GlobalInfo.loginUser.UserType == GlobalInfo.ADMIN)
            {
                empList = empDao.FindAll();
                cboEmp.Enabled = true;
            }
            else if (GlobalInfo.loginUser.UserType == GlobalInfo.DEPT_MGR)
            {
                empList = empDao.FindByDeptId(GlobalInfo.loginEmp.DeptId);
                cboEmp.Enabled = true;
            }
            else
            {
                empList = new List<HREmployee>();
                empList.Add(GlobalInfo.loginEmp);
                cboEmp.Enabled = false;
                cboEmp.SelectedIndex = 0;
            }

            cboEmp.DataSource = empList;


            HRPayroll vo = new HRPayroll();
            vo.EmpId = GlobalInfo.loginEmp.Id;
            list = dao.FindByWhere(vo);

            var bindingList = new BindingList<HRPayroll>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;
        }

        /// <summary>
        /// 输入转VO
        /// </summary>
        /// <returns></returns>
        private HRPayroll InputToVo()
        {
            HRPayroll vo = new HRPayroll();
            vo.EmpId = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? cboEmp.SelectedValue.ToString() : "";
            vo.PayrollDate = dtTime.Text;
            return vo;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            list = dao.FindByWhere(InputToVo());

            var bindingList = new BindingList<HRPayroll>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;
        }

        private void dtTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtTime_DropDown(object sender, EventArgs e)
        {
            this.dtTime.CustomFormat = "yyyy-MM-dd";
        }
    }
}
