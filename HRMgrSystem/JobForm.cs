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
    public partial class JobForm : Form
    {
        public const string PREFIX = "JOB-";

        public const int OP_FIND = 1;
        public const int OP_ADD = 2;
        public const int OP_UPDATE = 3;
        public const int OP_DELETE = 4;
        private int opration = -1; // 1: 查询；2：新增；3：修改；4：删除     

        private BindingSource jobListSource;
        private List<HRJob> jobList = null;

        private JobDao dao = new JobDao();
           

        public JobForm()
        {
            InitializeComponent();

            
            InitData();
        }

        private void InitData()
        {
            jobList = dao.FindAll();
            var bindingList = new BindingList<HRJob>(jobList);
            jobListSource = new BindingSource(bindingList, null);
            grid.DataSource = jobListSource;
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            //string str = string.Format("Id = '{0}'", txtId.Text);
            //(dataGridJob.DataSource as DataTable).DefaultView.RowFilter = str;
            List<HRJob> tempJob = jobList.Where(x => x.Id == txtId.Text).ToList();
            grid.DataSource = tempJob;
        }

        /// <summary>
        /// 验证输入
        /// </summary>
        /// <returns></returns>
        private bool validateInput()
        {
            if (EmptyUtils.EmptyStr(txtName.Text))
            {
                MessageBoxEx.Show(this, "请输入职位名称");
                txtName.Focus();
                return false;
            }
            return true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CleanData();

            opration = OP_ADD;

            txtId.Enabled = false;
            txtId.Text = UidUtils.GGuidPrefix();
            txtName.Text = "";

            btnSaveEnbaled(true);


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
            if(grid.CurrentRow.Index < 0)
            {
                MessageBoxEx.Show("请选择一条数据,在进行操作");
                return;
            }
            DialogResult result = MessageBoxEx.Show(this, "确认要删除吗?", "操作提示", MessageBoxButtons.YesNo);

            //如果点击的是"YES"按钮,将form关闭.
            if (result == DialogResult.Yes)
            {
                HRJob job = jobList[grid.CurrentRow.Index];
                try
                {
                    dao.Delete(job.Id);
                }
                catch (Exception ex)
                {
                    MessageBoxEx.Show(this, "删除失败！"+ex.StackTrace, "报错提示", MessageBoxButtons.YesNo);
                    return;
                }
               
                jobList.RemoveAt(grid.CurrentRow.Index);
                InitData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSaveEnbaled(false);

            if (opration == OP_ADD)
            {
                HRJob job = new HRJob();
                job.Id = txtId.Text;
                job.Name = txtName.Text;
                int ret = dao.Add(job);
                if(ret>0)
                {
                    jobListSource.Add(job);
                }
                
            }
            else if(opration == OP_UPDATE)
            {
                HRJob job = jobList[grid.CurrentRow.Index];
                job.Name = txtName.Text;
                dao.Update(job);
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
            txtId.Text = "";
            txtName.Text = "";
            grid.ClearSelection();
            grid.CurrentCell = null;
            InitData();
            opration = -1;
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

        private void dataGridJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            HRJob job = jobList[e.RowIndex];
            Console.WriteLine(job.Id);
            txtId.Text = job.Id;
            txtName.Text = job.Name;

            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            grid.ClearSelection();
        }
    }
}
