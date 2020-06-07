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
    public partial class DeptForm : Form
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

        public DeptForm()
        {
            InitializeComponent();

            CleanData();

            InitData();
        }

        private void InitData()
        {
            list = dao.FindAll();
            empList = empDao.FindAll();

            var bindingList = new BindingList<HRDept>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;
        }

        private void CleanData()
        {
            txtId.Text = "";
            txtName.Text = "";
            grid.ClearSelection();
            grid.CurrentCell = null;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void DeptForm_Load(object sender, EventArgs e)
        {
            grid.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CleanData();
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
            btnFind.Enabled = !enabled;
            btnAdd.Enabled = !enabled;
            btnClean.Enabled = !enabled;
            grid.Enabled = !enabled;
        }

        /// <summary>
        /// 验证输入
        /// </summary>
        /// <returns></returns>
        private bool validateInput()
        {
            if (EmptyUtils.EmptyStr(txtName.Text))
            {
                MessageBoxEx.Show(this, "请输入部门名称");
                txtName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateInput()) return;

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


            CleanData();
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

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            opration = -1;

            btnSaveEnbaled(false);
            CleanData();

            InitData();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow.Index < 0)
            {
                MessageBoxEx.Show("请选择一条数据,在进行操作");
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
                MessageBoxEx.Show("请选择一条数据,在进行操作");
                return;
            }
            DialogResult result = MessageBoxEx.Show(this, "确认要删除吗?", "", MessageBoxButtons.YesNo);

            //如果点击的是"YES"按钮,将form关闭.
            if (result == DialogResult.Yes)
            {
                HRDept dept = list[grid.CurrentRow.Index];
                try
                {
                    dao.Delete(dept.Id);
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(this, "删除失败！" + ex.StackTrace, "报错提示", MessageBoxButtons.YesNo);
                    return;
                }
                list.RemoveAt(grid.CurrentRow.Index);
                InitData();
            }
        }
    }
}
