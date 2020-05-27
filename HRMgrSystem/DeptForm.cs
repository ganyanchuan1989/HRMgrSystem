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
    public partial class DeptForm1 : Form
    {
        private DeptDao dao = new DeptDao();

        private EmployeeDao empDao = new EmployeeDao();

        public const string PREFIX = "DEPT-";

        public const int OP_FIND = 1;
        public const int OP_ADD = 2;
        public const int OP_UPDATE = 3;
        public const int OP_DELETE = 4;
        private int opration = -1; // 1: 查询；2：新增；3：修改；4：删除     

        private BindingSource listSource;
        private List<HRDept> list = null;
        private List<HREmployee> empList = null;

        public DeptForm1()
        {
            InitializeComponent();

            initData();
        }

        private void initData()
        {
            list = dao.FindAll();
            empList = empDao.FindAll();

            var bindingList = new BindingList<HRDept>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;

            cboEmp.DataSource = empList;
            cboEmp.SelectedIndex = -1;
        }

        private void cleanData()
        {
            txtId.Text = "";
            txtName.Text = "";

            cboEmp.SelectedIndex = -1;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void DeptForm_Load(object sender, EventArgs e)
        {
            grid.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            opration = OP_ADD;

            txtId.Enabled = false;
            txtId.Text = UidUtils.GGuidPrefix(PREFIX);

            txtName.Text = "";

            btnSaveEnbaled(true);
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
                HRDept dept = new HRDept();
                dept.Id = txtId.Text;
                dept.Name = txtName.Text;
                int ret = dao.Add(dept);
                if (ret > 0)
                {
                    listSource.Add(dept);
                }

            }
            else if (opration == OP_UPDATE)
            {
                HRDept dept = list[grid.CurrentRow.Index];
                dept.Name = txtName.Text;
                dao.Update(dept);
                grid.Refresh();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            HRDept dept = new HRDept();
            dept.Id = txtId.Text;
            dept.Name = txtName.Text;
            
            list = dao.FindByWhere(dept);

            var bindingList = new BindingList<HRDept>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            HRDept dept = list[e.RowIndex];
            txtId.Text = dept.Id;
            txtName.Text = dept.Name;
            cboEmp.SelectedValue = dept.HeaderId;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {

            initData();
            opration = -1;

            txtId.Text = "";
            txtName.Text = "";

            grid.ClearSelection();
            grid.CurrentCell = null;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow.Index < 0)
            {
                MessageBox.Show("请选择一条数据,在进行操作");
                return;
            }

            opration = OP_UPDATE;

            txtId.Enabled = false;
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
                HRDept job = list[grid.CurrentRow.Index];
                dao.Delete(job.Id);
                list.RemoveAt(grid.CurrentRow.Index);
                initData();
            }
        }
    }
}
