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

            initData();
        }

        private void initData()
        {
            list = dao.FindAll();
            empList = empDao.FindAll();

            var bindingList = new BindingList<HRContract>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = null;
            grid.DataSource = listSource;
            // 合同类型
            cboContractType.DataSource = DataDictionaryUtils.GetContractTypeDict();
            cboContractType.SelectedIndex = -1;

            cboEmp.DataSource = empList;
            cboEmp.SelectedIndex = -1;
        }

        private void cleanData()
        {
            txtId.Text = "";
            txtCorSalary.Text = "";
            txtProbation.Text = "";
            txtProSalary.Text = "";

            cboContractType.SelectedIndex = -1;
            cboEmp.SelectedIndex = -1;
            dtETime.Text = "";
            dtSTime.Text = "";

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                vo.CorrectedSalary = !EmptyUtils.EmptyStr(txtCorSalary.Text) ? float.Parse(txtCorSalary.Text) : float.NaN;
                vo.Probation = !EmptyUtils.EmptyStr(txtProbation.Text) ? int.Parse(txtProbation.Text) : -1;
                vo.ProbationSalary = !EmptyUtils.EmptyStr(txtProSalary.Text) ? float.Parse(txtProSalary.Text) : float.NaN;
                vo.EmployeeId = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? cboEmp.SelectedValue.ToString() : "";
                vo.EmpName = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? ((HREmployee)cboEmp.SelectedItem).Name : "";
                vo.ContractType = !EmptyUtils.EmptyObj(cboContractType.SelectedValue) ? int.Parse(cboContractType.SelectedValue.ToString()) : -1;
                vo.EndTime = dtETime.Text;
                vo.StartTime = dtSTime.Text;

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
            vo.CorrectedSalary = !EmptyUtils.EmptyStr(txtCorSalary.Text) ? float.Parse(txtCorSalary.Text) : float.NaN;
            vo.Probation = !EmptyUtils.EmptyStr(txtProbation.Text) ? int.Parse(txtProbation.Text) : -1;
            vo.ProbationSalary = !EmptyUtils.EmptyStr(txtProSalary.Text) ? float.Parse(txtProSalary.Text) : float.NaN;
            vo.EmployeeId = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? cboEmp.SelectedValue.ToString() : "";
            vo.EmpName = !EmptyUtils.EmptyObj(cboEmp.SelectedValue) ? ((HREmployee)cboEmp.SelectedItem).Name : "";
            vo.ContractType = !EmptyUtils.EmptyObj(cboContractType.SelectedValue) ? int.Parse(cboContractType.SelectedValue.ToString()) : -1;
            vo.EndTime = dtETime.Text;
            vo.StartTime = dtSTime.Text;

            return vo;
        }

        private void btnSaveEnbaled(bool enabled)
        {
            btnSave.Enabled = enabled;
            btnCancel.Enabled = enabled;
            txtId.Enabled = !enabled;
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
                HRContract vo = list[grid.CurrentRow.Index];
                dao.Delete(vo.Id);
                list.RemoveAt(grid.CurrentRow.Index);
                initData();
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
            this.gridProbationSalary.DisplayIndex = 5;
            this.gridCorrectedSalary.DisplayIndex = 6;
            this.gridContractType.DisplayIndex = 7;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            HRContract vo = list[e.RowIndex];
            txtId.Text = vo.Id;
            txtCorSalary.Text = vo.CorrectedSalary.ToString();
            txtProbation.Text = vo.Probation.ToString();
            txtProSalary.Text = vo.ProbationSalary.ToString();

            cboEmp.SelectedValue = vo.EmployeeId;
            cboContractType.SelectedValue = vo.ContractType;

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
    }
}
