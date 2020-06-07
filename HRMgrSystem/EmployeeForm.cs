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

            CleanData();

            InitData();
        }

        private void InitData()
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

        private void CleanData()
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
            dtTime.CustomFormat = " ";

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            HREmployee vo = InputToVo();
            list = dao.FindByWhere(vo);
            // datagrid
            var bindingList = new BindingList<HREmployee>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = listSource;
        }

        private HREmployee InputToVo(HREmployee empVo = null)
        {
            if(empVo == null)
            {
                empVo = new HREmployee();
                empVo.Id = txtId.Text;
            }
            empVo.Address = txtAddress.Text;
            empVo.BankCard = txtBank.Text;
            empVo.Email = txtEmail.Text;
            empVo.IdCard = txtIdCard.Text;
            empVo.Name = txtName.Text;
            empVo.Telephone = txtPhone.Text;
            empVo.Profession = txtPro.Text;
            empVo.School = txtSchool.Text;
            empVo.Education = !EmptyUtils.EmptyObj(cboEdu.SelectedValue) ? int.Parse(cboEdu.SelectedValue.ToString()) : -1;
            empVo.Sex = !EmptyUtils.EmptyObj(cboSex.SelectedValue)? int.Parse(cboSex.SelectedValue.ToString()): -1;
            empVo.Status = !EmptyUtils.EmptyObj(cboStatus.SelectedValue) ? int.Parse(cboStatus.SelectedValue.ToString()) : -1;
            empVo.DeptId = !EmptyUtils.EmptyObj(cboDept.SelectedValue) ? cboDept.SelectedValue.ToString() : "";
            empVo.JobId = !EmptyUtils.EmptyObj(cboJob.SelectedValue) ? cboJob.SelectedValue.ToString() : "";
            empVo.GraduationTime = dtTime.Text;
            empVo.PoliticalStatus = !EmptyUtils.EmptyObj(cboPo.SelectedValue) ? int.Parse(cboPo.SelectedValue.ToString()) : -1;

            return empVo;
        }

        /// <summary>
        /// 验证输入
        /// </summary>
        /// <returns></returns>
        private bool validateInput()
        {
            if(EmptyUtils.EmptyStr(txtName.Text))
            {
                MessageBoxEx.Show(this, "请输入姓名");
                txtName.Focus();
                return false;
            }
            if(EmptyUtils.EmptyObj(cboSex.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择性别");
                cboSex.Focus();
                return false;
            }
            if (EmptyUtils.EmptyObj(cboPo.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择政治面貌");
                cboPo.Focus();
                return false;
            }
            if (EmptyUtils.EmptyObj(cboEdu.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择学历");
                cboEdu.Focus();
                return false;
            }
            if (EmptyUtils.EmptyObj(cboEdu.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择学历");
                cboEdu.Focus();
                return false;
            }

            if (EmptyUtils.EmptyStr(dtTime.Text))
            {
                MessageBoxEx.Show(this, "请选择毕业时间");
                dtTime.Focus();
                return false;
            }
            if (EmptyUtils.EmptyStr(txtPhone.Text))
            {
                MessageBoxEx.Show(this, "请输入电话号码");
                txtPhone.Focus();
                return false;
            }
            if (EmptyUtils.IsNaN(txtPhone.Text))
            {
                MessageBoxEx.Show(this, "电话号码格式不正确");
                txtPhone.Focus();
                return false;
            }

            if (EmptyUtils.EmptyStr(txtIdCard.Text))
            {
                MessageBoxEx.Show(this, "请输入身份证号码");
                txtIdCard.Focus();
                return false;
            }
            if (txtIdCard.Text.Length != 18)
            {
                MessageBoxEx.Show(this, "身份证号码长度不正确，请输入18位身份证号码。");
                txtIdCard.Focus();
                return false;
            }
            if (EmptyUtils.EmptyObj(cboDept.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择部门");
                cboDept.Focus();
                return false;
            }
            if (EmptyUtils.EmptyObj(cboJob.SelectedValue))
            {
                MessageBoxEx.Show(this, "请选择职位");
                cboJob.Focus();
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
                HREmployee emp = InputToVo();
                //    new HREmployee();
                //emp.Address = txtAddress.Text;
                //emp.BankCard = txtBank.Text;
                //emp.Email = txtEmail.Text;
                //emp.Id = txtId.Text;
                //emp.IdCard = txtIdCard.Text;
                //emp.Name = txtName.Text;
                //emp.Telephone = txtPhone.Text;
                //emp.Profession = txtPro.Text;
                //emp.School = txtSchool.Text;
                //emp.Education = int.Parse(cboEdu.SelectedValue.ToString());
                //emp.Sex = int.Parse(cboSex.SelectedValue.ToString());
                //emp.Status = int.Parse(cboStatus.SelectedValue.ToString());
                //emp.DeptId = cboDept.SelectedValue != null ? cboDept.SelectedValue.ToString(): "";
                //emp.JobId = cboJob.SelectedValue.ToString();
                //emp.GraduationTime = dtTime.Text;
                //emp.PoliticalStatus = int.Parse(cboPo.SelectedValue.ToString());

                int ret = dao.Add(emp);

                if (ret > 0)
                {
                    listSource.Add(emp);
                }

            }
            else if (opration == OP_UPDATE)
            {
                HREmployee empVo = list[grid.CurrentRow.Index];
                empVo = InputToVo(empVo);
                //emp.Address = txtAddress.Text;
                //emp.BankCard = txtBank.Text;
                //emp.Email = txtEmail.Text;
                //emp.IdCard = txtIdCard.Text;
                //emp.Name = txtName.Text;
                //emp.Telephone = txtPhone.Text;
                //emp.Profession = txtPro.Text;
                //emp.School = txtSchool.Text;
                //emp.Education = int.Parse(cboEdu.SelectedValue.ToString());
                //emp.Sex = int.Parse(cboSex.SelectedValue.ToString());
                //emp.Status = int.Parse(cboStatus.SelectedValue.ToString());
                //emp.DeptId = cboDept.SelectedValue.ToString();
                //emp.JobId = cboJob.SelectedValue.ToString();
                //emp.GraduationTime = dtTime.Text;
                //emp.PoliticalStatus = int.Parse(cboPo.SelectedValue.ToString());
                dao.Update(empVo);
                grid.Refresh();
            }

            CleanData();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);
            CleanData();

            InitData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CleanData();

            opration = OP_ADD;

            txtId.Enabled = false;
            txtId.Text = UidUtils.GGuidPrefix();

            cboStatus.SelectedIndex = 0;

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
                MessageBoxEx.Show("请选择一条数据,在进行操作");
                return;
            }
            DialogResult result = MessageBoxEx.Show(this, "删除后将不可找回，推荐改成离职状态，确认要删除吗?", "", MessageBoxButtons.YesNo);

            //如果点击的是"YES"按钮,将form关闭.
            if (result == DialogResult.Yes)
            {
                HREmployee job = list[grid.CurrentRow.Index];
                dao.Delete(job.Id);
                list.RemoveAt(grid.CurrentRow.Index);
                InitData();
            }
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

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataRow[] rows = null;

            if (grid.Columns[e.ColumnIndex].Name.Equals("gridStatus"))
            {
                rows = DataDictionaryUtils.GetStatusDict().Select("value=" + e.Value);
            }
            else if (grid.Columns[e.ColumnIndex].Name.Equals("gridSex"))
            {
                rows = DataDictionaryUtils.GetSexDict().Select("value=" + e.Value);
            }
            else if (grid.Columns[e.ColumnIndex].Name.Equals("gridPoliticalStatus"))
            {
                rows = DataDictionaryUtils.GetPoliticalStatusDict().Select("value=" + e.Value);
            }
            else if (grid.Columns[e.ColumnIndex].Name.Equals("gridEducation"))
            {
                rows = DataDictionaryUtils.GetEducationDict().Select("value=" + e.Value);
            }
            
            if (rows != null)
            {
                e.Value = rows[0]["label"];
            }
        }

        private void dtTime_ValueChanged(object sender, EventArgs e)
        {
            dtTime.CustomFormat = "yyyy-MM-dd";
        }
    }
}
