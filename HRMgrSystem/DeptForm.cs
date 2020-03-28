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

namespace HRMgrSystem
{
    public partial class DeptForm : Form
    {
        private DeptDao dao = new DeptDao();

        private List<HRDept> list = null;
        
        public DeptForm()
        {
            InitializeComponent();

            list = dao.FindAll();

            dataGridDept.DataSource = list;
        }
    }
}
