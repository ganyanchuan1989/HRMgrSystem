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
    public partial class EmployeeForm : Form
    {
        public const string PREFIX = "EMP-";

        public const int OP_FIND = 1;
        public const int OP_ADD = 2;
        public const int OP_UPDATE = 3;
        public const int OP_DELETE = 4;
        private int opration = -1; // 1: 查询；2：新增；3：修改；4：删除     

        private BindingSource listSource;
        private List<HREmployee> list = null;

        private EmployeeDao dao = new EmployeeDao();
        private DeptDao deptDao = new DeptDao();
        private JobDao jobDao = new JobDao();
        // private UserDao userDao = new UserDao();

        private List<HRDept> deptList = null;
        private List<HRJob> jobList = null;
        

        public EmployeeForm()
        {
            InitializeComponent();

            initData();
        }

        private void initData()
        {
            list = dao.FindAll();
            deptList = deptDao.FindAll();
            jobList = jobDao.FindAll();

            // datagrid
            var bindingList = new BindingList<HREmployee>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;

            // ccombobox
            cboJob.DataSource = jobList;
            cboJob.SelectedIndex = -1;
            cboDept.DataSource = deptList;
            cboDept.SelectedIndex = -1;

            // dict
            cboEdu.DataSource = DataDictionaryUtils.GetEducationDict();
            cboEdu.SelectedIndex = -1;
            cboSex.DataSource = DataDictionaryUtils.GetSexDict();
            cboSex.SelectedIndex = -1;
            cboStatus.DataSource = DataDictionaryUtils.GetStatusDict();
            cboStatus.SelectedIndex = -1;
            cboPo.DataSource = DataDictionaryUtils.GetPoliticalStatusDict();
            cboPo.SelectedIndex = -1;
        }


        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
            
            if (opration == OP_ADD)
            {
                HREmployee emp = new HREmployee();
                emp.Address = txtAddress.Text;
                emp.BankCard = txtBank.Text;
                emp.Email = txtEmail.Text;
                emp.Id = txtId.Text;
                emp.IdCard = txtIdCard.Text;
                emp.Name = txtName.Text;
                emp.Telephone = txtPhone.Text;
                emp.Profession = txtPro.Text;
                emp.School = txtSchool.Text;
                emp.Education = int.Parse(cboEdu.SelectedValue.ToString());
                emp.Sex = int.Parse(cboSex.SelectedValue.ToString());
                emp.Status = int.Parse(cboStatus.SelectedValue.ToString());
                emp.DeptId = cboDept.SelectedValue.ToString();
                emp.JobId = cboJob.SelectedValue.ToString();
                emp.GraduationTime = dtTime.Text;
                emp.PoliticalStatus = int.Parse(cboPo.SelectedValue.ToString());

                int ret = dao.Add(emp);

                if (ret > 0)
                {
                    listSource.Add(emp);
                }

            }
            else if (opration == OP_UPDATE)
            {
                HREmployee emp = list[grid.CurrentRow.Index];
                emp.Address = txtAddress.Text;
                emp.BankCard = txtBank.Text;
                emp.Email = txtEmail.Text;
                emp.IdCard = txtIdCard.Text;
                emp.Name = txtName.Text;
                emp.Telephone = txtPhone.Text;
                emp.Profession = txtPro.Text;
                emp.School = txtSchool.Text;
                emp.Education = int.Parse(cboEdu.SelectedValue.ToString());
                emp.Sex = int.Parse(cboSex.SelectedValue.ToString());
                emp.Status = int.Parse(cboStatus.SelectedValue.ToString());
                emp.DeptId = cboDept.SelectedValue.ToString();
                emp.JobId = cboJob.SelectedValue.ToString();
                emp.GraduationTime = dtTime.Text;
                emp.PoliticalStatus = int.Parse(cboPo.SelectedValue.ToString());
                dao.Update(emp);
                grid.Refresh();
            }

            cleanData();


        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
            cleanData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cleanData();

            opration = OP_ADD;

            txtId.Enabled = false;
            txtId.Text = UidUtils.GGuidPrefix(PREFIX);

            btnSaveEnbaled(true);
            
        }

        private void btnSaveEnbaled(bool enabled)
        {
            btnSave.Enabled = enabled;
            btnCancel.Enabled = enabled;
            txtId.Enabled = !enabled;
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
                HREmployee job = list[grid.CurrentRow.Index];
                dao.Delete(job.Id);
                list.RemoveAt(grid.CurrentRow.Index);
                initData();
            }
        }

        private void cleanData()
        {
            txtAddress.Text = "";
            txtBank.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
            txtIdCard.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtPro.Text = "";
            txtSchool.Text = "";
            cboDept.SelectedIndex = -1;
            cboJob.SelectedIndex = -1;
            cboPo.SelectedIndex = -1;
            cboSex.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboEdu.SelectedIndex = -1;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            grid.ClearSelection();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            HREmployee emp = list[e.RowIndex];
            txtAddress.Text = emp.Address;
            txtBank.Text = emp.BankCard;
            txtEmail.Text = emp.Email;
            txtId.Text = emp.Id;
            txtIdCard.Text = emp.IdCard;
            txtName.Text = emp.Name;
            txtPhone.Text = emp.Telephone;
            txtPro.Text = emp.Profession;
            txtSchool.Text = emp.School;
            cboEdu.SelectedValue = emp.Education;
            cboSex.SelectedValue = emp.Sex;
            cboStatus.SelectedValue = emp.Status;
            cboDept.SelectedValue = emp.DeptId;
            cboJob.SelectedValue = emp.JobId;
            dtTime.Text = emp.GraduationTime;
            cboPo.SelectedValue = emp.PoliticalStatus;
        }
    }
}
