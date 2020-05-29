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
    public partial class MyContractForm : Form
    {
        ContractDao dao = new ContractDao();

        public MyContractForm()
        {
            InitializeComponent();

            InitData();
        }

        private void InitData()
        {
            if(GlobalInfo.loginEmp != null)
            {
                HRContract vo = dao.FindByEmpId(GlobalInfo.loginEmp.Id);
                if(vo != null)
                {
                    txtId.Text = vo.Id;
                    txtProbation.Text = vo.Probation.ToString();
                    txtSalary.Text = vo.Salary.ToString();

                    cboEmp.SelectedValue = vo.EmpId;
                    cboContractType.SelectedValue = vo.ContractType;

                    dtETime.Text = vo.EndTime;
                    dtSTime.Text = vo.StartTime;
                }
            }
        }
    }
}
