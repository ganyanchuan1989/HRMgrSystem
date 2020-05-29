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

            jobList = dao.FindAll();
            initData();
        }

        private void initData()
        {
            var bindingList = new BindingList<HRJob>(jobList);
            jobListSource = new BindingSource(bindingList, null);
            grid.DataSource = jobListSource;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //string str = string.Format("Id = '{0}'", txtId.Text);
            //(dataGridJob.DataSource as DataTable).DefaultView.RowFilter = str;
            List<HRJob> tempJob = jobList.Where(x => x.Id == txtId.Text).ToList();
            grid.DataSource = tempJob;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            opration = OP_ADD;

            txtId.Enabled = false;
            txtId.Text = UidUtils.GGuidPrefix(PREFIX);
            txtName.Text = "";

            btnSaveEnbaled(true);


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
            if(grid.CurrentRow.Index < 0)
            {
                MessageBox.Show("请选择一条数据,在进行操作");
                return;
            }
            DialogResult result = MessageBox.Show(this, "确认要删除吗?", "", MessageBoxButtons.YesNo);

            //如果点击的是"YES"按钮,将form关闭.
            if (result == DialogResult.Yes)
            {
                HRJob job = jobList[grid.CurrentRow.Index];
                dao.Delete(job.Id);
                jobList.RemoveAt(grid.CurrentRow.Index);
                initData();
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
            initData();
            opration = -1;
        }

        private void btnSaveEnbaled(bool enabled)
        {
            btnSave.Enabled = enabled;
            btnCancel.Enabled = enabled;
            txtId.Enabled = !enabled;
        }

        private void dataGridJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            HRJob job = jobList[e.RowIndex];
            Console.WriteLine(job.Id);
            txtId.Text = job.Id;
            txtName.Text = job.Name;
            // dataGridJob.dat;
        }

        private void JobForm_Load(object sender, EventArgs e)
        {
            grid.ClearSelection();
        }
    }
}
