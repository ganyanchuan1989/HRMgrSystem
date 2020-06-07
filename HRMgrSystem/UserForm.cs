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
    public partial class UserForm : Form
    {
        private UserDao dao = new UserDao();
        private EmployeeDao empDao = new EmployeeDao();

        public const string PREFIX = "USER-";

        public const int OP_FIND = 1;
        public const int OP_ADD = 2;
        public const int OP_UPDATE = 3;
        public const int OP_DELETE = 4;
        private int opration = -1; // 1: 查询；2：新增；3：修改；4：删除     

        private BindingSource listSource;
        private List<HRUser> list = null;
        private List<HREmployee> empList = null;


        public UserForm()
        {
            InitializeComponent();

            CleanData();

            InitData();
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            list = dao.FindAll();
            empList = empDao.FindAll();

            var bindingList = new BindingList<HRUser>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;

            cboUserType.DataSource = DataDictionaryUtils.GetUserTypeDict();
            cboUserType.SelectedIndex = -1;

            cboEmp.DataSource = empList;
            cboEmp.SelectedIndex = -1;
        }

        /// <summary>
        /// 清除数据
        /// </summary>
        private void CleanData()
        {
            txtId.Text = "";
            txtUserName.Text = "";
            txtPwd.Text = "";
            cboUserType.SelectedIndex = -1;
            cboEmp.SelectedIndex = -1;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            grid.ClearSelection();
        }

        /// <summary>
        /// 输入转VO
        /// </summary>
        /// <returns></returns>
        private HRUser InputToVo(HRUser vo)
        {
            if (vo == null)
            {
                vo = new HRUser();
                vo.Id = txtId.Text;
            }
            if (!EmptyUtils.EmptyObj(cboEmp.SelectedItem))
            {
                HREmployee empVo = cboEmp.SelectedItem as HREmployee;

                vo.EmpId = empVo.Id;
                vo.EmpName = empVo.Name;
            }
            vo.UserName = txtUserName.Text;
            vo.Password = txtPwd.Text;
            vo.UserType = !EmptyUtils.EmptyObj(cboUserType.SelectedValue) ? int.Parse(cboUserType.SelectedValue.ToString()) : -1;

            return vo;
        }

        /// <summary>
        /// 验证输入
        /// </summary>
        /// <returns></returns>
        private bool validateInput()
        {
            if (EmptyUtils.EmptyStr(txtUserName.Text))
            {
                MessageBoxEx.Show(this, "请输入用户名");
                txtUserName.Focus();
                return false;
            }

            if (EmptyUtils.EmptyStr(txtPwd.Text))
            {
                MessageBoxEx.Show(this, "请输入密码");
                txtPwd.Focus();
                return false;
            }

            if (EmptyUtils.EmptyObj(cboEmp.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择员工");
                cboEmp.Focus();
                return false;
            }

            if (EmptyUtils.EmptyObj(cboUserType.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择用户类型");
                cboUserType.Focus();
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
                HRUser vo = InputToVo(null);

                int ret = dao.Add(vo);
                if (ret > 0)
                {
                    listSource.Add(vo);
                }

            }
            else if (opration == OP_UPDATE)
            {
                HRUser vo = list[grid.CurrentRow.Index];
                vo = InputToVo(vo);
                dao.Update(vo);
                grid.Refresh();
            }

            CleanData();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
            CleanData();

            InitData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            HRUser vo = InputToVo(null);
            list = dao.FindByWhere(vo);

            var bindingList = new BindingList<HRUser>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CleanData();

            opration = OP_ADD;

            txtId.Enabled = false;
            txtId.Text = UidUtils.GGuidPrefix();

            cboUserType.SelectedIndex = 0;

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
                HRUser vo = list[grid.CurrentRow.Index];
                dao.Delete(vo.Id);
                list.RemoveAt(grid.CurrentRow.Index);
                InitData();
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            HRUser vo = list[e.RowIndex];
            txtId.Text = vo.Id;
            txtUserName.Text = vo.UserName;
            txtPwd.Text = vo.Password;
            cboEmp.SelectedValue = vo.EmpId;
            cboUserType.SelectedValue = vo.UserType;
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataRow[] rows = null;

            if (grid.Columns[e.ColumnIndex].Name.Equals("gridUserType"))
            {
                rows = DataDictionaryUtils.GetUserTypeDict().Select("value=" + e.Value);
            }

            if (rows != null)
            {
                e.Value = rows[0]["label"];
            }
        }
    }
}
