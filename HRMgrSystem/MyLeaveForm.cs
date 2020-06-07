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
    public partial class MyLeaveForm : Form
    {
        LeaveDao dao = new LeaveDao();
        private BindingSource listSource;
        private List<HRLeave> list = null;

        public MyLeaveForm()
        {
            InitializeComponent();

            initData();
        }

        private void initData()
        {
            list = dao.FindByEmpId(GlobalInfo.loginEmp.Id);

            var bindingList = new BindingList<HRLeave>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = null;
            grid.DataSource = listSource;
            
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataRow[] rows = null;

            if (grid.Columns[e.ColumnIndex].Name.Equals("gridLeaveType"))
            {
                rows = DataDictionaryUtils.GetLeaveTypeDict().Select("value=" + e.Value);
            }

            if (grid.Columns[e.ColumnIndex].Name.Equals("gridStatus"))
            {
                rows = DataDictionaryUtils.GetLeaveStatusDict().Select("value=" + e.Value);
            }

            if (rows != null)
            {
                e.Value = rows[0]["label"];
            }
        }
    }
}
