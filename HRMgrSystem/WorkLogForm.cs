using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMgrSystem.db;
using HRMgrSystem.vo;
using HRMgrSystem.utils;

namespace HRMgrSystem
{
    public partial class WorkLogForm : Form
    {
        private WorkLogDao dao = new WorkLogDao();
        private EmployeeDao empDao = new EmployeeDao();

        public const string PREFIX = "WORKLOG-";

        public const int OP_FIND = 1;
        public const int OP_ADD = 2;
        public const int OP_UPDATE = 3;
        public const int OP_DELETE = 4;
        private int opration = -1; // 1: 查询；2：新增；3：修改；4：删除     


        private BindingSource listSource;
        private List<HRWorkLog> list = null;
        private List<HREmployee> empList = null;


        public WorkLogForm()
        {
            InitializeComponent();

            initData();
        }

        private void initData()
        {
            empList = empDao.FindAll();

            if (GlobalInfo.IS_ADMIN)
                list = dao.FindAll();
            else
                list = dao.FindEmpId(GlobalInfo.loginUser.EmpId);


            var bindingList = new BindingList<HRWorkLog>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = null;
            grid.DataSource = listSource;

            cboEmp.DataSource = empList;

            if (GlobalInfo.IS_ADMIN)
                cboEmp.SelectedIndex = -1;
            else
            {
                cboEmp.Enabled = false;
                cboEmp.SelectedValue = GlobalInfo.loginUser.EmpId;
            }    
        }

        private void cleanData()
        {
            txtId.Text = "";
            txtContent.Text = "";

            if(GlobalInfo.IS_ADMIN)
            {
                cboEmp.Text = "";
                cboEmp.SelectedIndex = -1;
            }

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSaveEnbaled(bool enabled)
        {
            btnSave.Enabled = enabled;
            btnCancel.Enabled = enabled;
            txtId.Enabled = !enabled;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);

            if (opration == OP_ADD)
            {

                HRWorkLog vo = InputToVo();

                int ret = dao.Add(vo);

                if (ret > 0)
                {
                    listSource.Add(vo);
                }

            }
            else if (opration == OP_UPDATE)
            {
                HRWorkLog vo = list[grid.CurrentRow.Index];
                vo.Content = txtContent.Text;
                vo.LogDate = dtTime.Text;
                vo.EmpId = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? cboEmp.SelectedValue.ToString() : "";
                vo.EmpName = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? ((HREmployee)cboEmp.SelectedItem).Name : "";
                dao.Update(vo);
                grid.Refresh();
            }

            cleanData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
            cleanData();

            initData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cleanData();

            opration = OP_ADD;

            txtId.Enabled = false;
            txtId.Text = UidUtils.GGuidPrefix(PREFIX);

            btnSaveEnbaled(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            opration = OP_UPDATE;
            btnSaveEnbaled(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow.Index < 0)
            {
                MessageBox.Show("请选择一条数据,在进行操作");
                return;
            }
            DialogResult result = MessageBox.Show(this, "确认要删除吗?", "", MessageBoxButtons.YesNo);

            //如果点击的是"YES"按钮,将form关闭.
            if (result == DialogResult.Yes)
            {
                HRWorkLog vo = list[grid.CurrentRow.Index];
                dao.Delete(vo.Id);
                list.RemoveAt(grid.CurrentRow.Index);
                initData();
            }
        }

        /// <summary>
        /// 输入转VO
        /// </summary>
        /// <returns></returns>
        private HRWorkLog InputToVo()
        {
            HRWorkLog vo = new HRWorkLog();
            vo.Id = txtId.Text;
            vo.EmpId = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? cboEmp.SelectedValue.ToString() : "";
            vo.EmpName = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? ((HREmployee)cboEmp.SelectedItem).Name : "";
            vo.LogDate = dtTime.Text;
            vo.Content = txtContent.Text;

            return vo;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            HRWorkLog vo = list[e.RowIndex];
            txtId.Text = vo.Id;
            txtContent.Text = vo.Content.ToString();
            cboEmp.SelectedValue = vo.EmpId;
            dtTime.Text = vo.LogDate;
        }
    }
}
