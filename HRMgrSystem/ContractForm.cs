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
    public partial class ContractForm : Form
    {
        private ContractDao dao = new ContractDao();
        private EmployeeDao empDao = new EmployeeDao();

        public const string PREFIX = "CONTRACT-";

        public const int OP_FIND = 1;
        public const int OP_ADD = 2;
        public const int OP_UPDATE = 3;
        public const int OP_DELETE = 4;
        private int opration = -1; // 1: 查询；2：新增；3：修改；4：删除     

        private BindingSource listSource;
        private List<HRContract> list = null;
        private List<HREmployee> empList = null;

        public ContractForm()
        {
            InitializeComponent();

            CleanData();

            InitData();
        }

        private void InitData()
        {
            list = dao.FindAll();
            empList = empDao.FindAll();

            var bindingList = new BindingList<HRContract>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = null;
            grid.DataSource = listSource;

            cboEmp.DataSource = empList;
            cboEmp.SelectedIndex = -1;
        }

        private void CleanData()
        {
            txtId.Text = "";
            txtProbation.Text = "";
            txtSalary.Text = "";
            
            cboEmp.SelectedIndex = -1;
            dtETime.Text = "";
            dtSTime.Text = "";

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            dtSTime.CustomFormat = " ";
            dtETime.CustomFormat = " ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateInput()) return;

            btnSaveEnbaled(false);

            if (opration == OP_ADD)
            {

                HRContract vo = InputToVo();

                int ret = dao.Add(vo);

                if (ret > 0)
                {
                    listSource.Add(vo);
                }

            }
            else if (opration == OP_UPDATE)
            {
                HRContract vo = list[grid.CurrentRow.Index];
                vo.Probation = !EmptyUtils.EmptyStr(txtProbation.Text) ? int.Parse(txtProbation.Text) : -1;
                vo.Salary = !EmptyUtils.EmptyStr(txtSalary.Text) ? float.Parse(txtSalary.Text) : -1;
                vo.EmpId = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? cboEmp.SelectedValue.ToString() : "";
                vo.EmpName = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? ((HREmployee)cboEmp.SelectedItem).Name : "";
                vo.EndTime = dtETime.Text;
                vo.StartTime = dtSTime.Text;

                dao.Update(vo);
                grid.Refresh();
            }

            CleanData();
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
            HRContract vo = InputToVo();

            list = dao.FindByWhere(vo);
            var bindingList = new BindingList<HRContract>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = null;
            grid.DataSource = listSource;
        }

        /// <summary>
        /// 输入转VO
        /// </summary>
        /// <returns></returns>
        private HRContract InputToVo()
        {
            HRContract vo = new HRContract();
            vo.Id = txtId.Text;
            vo.Probation = !EmptyUtils.EmptyStr(txtProbation.Text) ? int.Parse(txtProbation.Text) : -1;
            vo.Salary = !EmptyUtils.EmptyStr(txtSalary.Text) ? float.Parse(txtSalary.Text) : -1;
            vo.EmpId = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? cboEmp.SelectedValue.ToString() : "";
            vo.EmpName = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? ((HREmployee)cboEmp.SelectedItem).Name : "";
            vo.EndTime = dtETime.Text;
            vo.StartTime = dtSTime.Text;

            return vo;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CleanData();

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
                HRContract vo = list[grid.CurrentRow.Index];
                dao.Delete(vo.Id);
                list.RemoveAt(grid.CurrentRow.Index);

                CleanData();
                InitData();
            }
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            grid.ClearSelection();
            // grid.Columns["gridEmpID"].Visible = false;
            grid.AutoGenerateColumns = false;
            this.gridID.DisplayIndex = 0;
            this.gridEmpName.DisplayIndex = 1;
            this.gridStartTime.DisplayIndex = 2;
            this.gridEndTime.DisplayIndex = 3;
            this.gridProbation.DisplayIndex = 4;
            this.gridContractType.DisplayIndex = 7;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            HRContract vo = list[e.RowIndex];
            txtId.Text = vo.Id;
            txtProbation.Text = vo.Probation.ToString();
            txtSalary.Text = vo.Salary.ToString();

            cboEmp.SelectedValue = vo.EmpId;

            dtETime.Text = vo.EndTime;
            dtSTime.Text = vo.StartTime;
            
            
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataRow[] rows = null;

            if (grid.Columns[e.ColumnIndex].Name.Equals("gridContractType"))
            {
                rows = DataDictionaryUtils.GetContractTypeDict().Select("value=" + e.Value);
            }

            if (rows != null)
            {
                e.Value = rows[0]["label"];
            }
        }

        /// <summary>
        /// 验证输入
        /// </summary>
        /// <returns></returns>
        private bool validateInput()
        {
            if (EmptyUtils.EmptyObj(cboEmp.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择员工");
                cboEmp.Focus();
                return false;
            }

            if (EmptyUtils.EmptyStr(dtSTime.Text))
            {
                MessageBoxEx.Show(this, "请选择合同开始时间。");
                txtSalary.Focus();
                return false;
            }

            if (EmptyUtils.EmptyStr(txtProbation.Text))
            {
                MessageBoxEx.Show(this, "请输入试用期");
                txtProbation.Focus();
                return false;
            }
            if (EmptyUtils.IsNaN(txtProbation.Text))
            {
                MessageBoxEx.Show(this, "试用期格式不正确，请重新输入。");
                txtProbation.Focus();
                return false;
            }
            if (EmptyUtils.EmptyStr(txtSalary.Text))
            {
                MessageBoxEx.Show(this, "请输入工资");
                txtSalary.Focus();
                return false;
            }
            if (EmptyUtils.IsNaN(txtSalary.Text))
            {
                MessageBoxEx.Show(this, "试用期格式不正确，请重新输入。");
                txtSalary.Focus();
                return false;
            }

           
            if (EmptyUtils.EmptyStr(dtETime.Text))
            {
                MessageBoxEx.Show(this, "请选择合同结束时间。");
                txtSalary.Focus();
                return false;
            }

            DateTime sDt = Convert.ToDateTime(dtSTime.Text);
            DateTime eDt = Convert.ToDateTime(dtETime.Text);

            if (DateTime.Compare(sDt, eDt) > 0)
            {
                MessageBoxEx.Show(this, "合同开始时间不能大于合同结束时间。");
                dtSTime.Focus();
                return false;
            }
            return true;
        }

        private void dtSTime_ValueChanged(object sender, EventArgs e)
        {
            dtSTime.CustomFormat = "yyyy-MM-dd";
        }

        private void dtETime_ValueChanged(object sender, EventArgs e)
        {
            dtETime.CustomFormat = "yyyy-MM-dd";
        }
    }
}
