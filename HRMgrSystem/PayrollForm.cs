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
using HRMgrSystem.utils;
using HRMgrSystem.db;

namespace HRMgrSystem
{
    public partial class PayrollForm : Form
    {
        private PayrollDao dao = new PayrollDao();
        private BindingSource listSource;
        private List<HRPayroll> list = null;

        private ContractDao contractDao = new ContractDao();
        private LeaveDao leaveDao = new LeaveDao();

        

        public PayrollForm()
        {
            InitializeComponent();

            showDesc();
        }
        private void showDesc()
        {
            string startDate = string.Format("{0}-{1}-01", dtTime.Value.Year, dtTime.Value.Month);
            string endDate = string.Format("{0}-{1}-31", dtTime.Value.Year, dtTime.Value.Month);
            string str = "工资计算方式：试用期80%，工作日按30天算；事假扣除当天工资；病假当天工资80%";
            lblDesc.Text = string.Format("只能生成合同开始时间在【{0}】之前，结束时间在【{1}】之后的员工工资单。\n\n{2}", startDate, endDate, str);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int cYear = DateTime.Now.Year;
            int cMonth = DateTime.Now.Month;
            if(dtTime.Value.Year > cYear)
            {
                MessageBoxEx.Show(this, string.Format("日期选择错误，不能超过：{0}年",cYear));
                return;
            }

            if(dtTime.Value.Month  >= cMonth)
            {
                MessageBoxEx.Show(this, string.Format("日期选择错误，生成的日期必须是{0}月份之前的", cMonth));
                return;
            }

            if(dao.FindByDateInterval(dtTime.Value.Year, dtTime.Value.Month).Count > 0)
            {
                MessageBoxEx.Show(this, string.Format("{0}年{1}月的工资单已经生成过了", dtTime.Value.Year, dtTime.Value.Month));
                return;
            }

            string startDate = string.Format("{0}-{1}-01", dtTime.Value.Year, dtTime.Value.Month);
            string endDate = string.Format("{0}-{1}-31", dtTime.Value.Year, dtTime.Value.Month);
            // 请假
            List<HRLeave> leaveList = leaveDao.FindByInterval(startDate, endDate);
            Dictionary<string, HRPayroll> hashMap = CalcLeaveDay(leaveList);

            // 合同
            List<HRContract> contractList = contractDao.FindByDate(endDate);

            list = new List<HRPayroll>();
            int index = 1;
            foreach (var contractVo in contractList)
            {
                HRPayroll vo = new HRPayroll();
                vo.Id = UidUtils.GGuidPrefix(index);
                vo.EmpId = contractVo.EmpId;
                vo.EmpName = contractVo.EmpName;
                vo.PayrollDate = dtTime.Text;
                vo.LeaveDay = hashMap.ContainsKey(contractVo.EmpId) ? hashMap[contractVo.EmpId].LeaveDay : 0;
                vo.SickLeaveDay = hashMap.ContainsKey(contractVo.EmpId) ? hashMap[contractVo.EmpId].SickLeaveDay : 0;
                // 是否在试用期（1:是，0：否）
                vo.ProbationStatus = JudgeIsProbationStatus(contractVo);
                vo.RealSalary = CalcSalary(contractVo.Salary, vo);
                list.Add(vo);

                index++;
            }

            var bindingList = new BindingList<HRPayroll>(list);
            listSource = new BindingSource(bindingList, null);
            grid.DataSource = null;
            grid.DataSource = listSource;

            if(list != null && list.Count > 0)
            {
                btnCommit.Enabled = true;
            }
        }

        /// <summary>
        /// 计算逻辑：
        /// 1. 试用期工资80%
        /// 2. 按30天工作日计算，病假每天工资扣除20%，事假扣除100%
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="vo"></param>
        /// <returns></returns>
        private float CalcSalary(float salary, HRPayroll vo)
        {
            if(vo.ProbationStatus == 1)
            {
                salary = (float)(salary * 0.8);
            }
            float daySalary = salary / 30;

            float ret = daySalary * (30 - vo.SickLeaveDay - vo.LeaveDay);
            ret += (float)(daySalary * vo.SickLeaveDay * 0.8);
            return ret;
        }
        
        /// <summary>
        /// 判断是否在试用期
        /// </summary>
        /// <returns></returns>
        private int JudgeIsProbationStatus(HRContract vo)
        {
            DateTime dt = Convert.ToDateTime(vo.StartTime);
            if(dt.Year < dtTime.Value.Year)
            {
                return 0;
            }
            if(dt.Year == dtTime.Value.Year && (dtTime.Value.Month - dt.Month) > vo.Probation)
            {
                return 1;
            }
            // vo.StartTime
            return 0;
        }

        private Dictionary<string, HRPayroll> CalcLeaveDay(List<HRLeave> leaveList)
        {
            Dictionary<string, HRPayroll> hashMap = new Dictionary<string, HRPayroll>();
            foreach (HRLeave leaveVo in leaveList)
            {
                HRPayroll vo = null;
                if (hashMap.ContainsKey(leaveVo.EmpId))
                {
                    vo = hashMap[leaveVo.EmpId];
                }
                else
                {
                    vo = new HRPayroll();
                    hashMap[leaveVo.EmpId] = vo;
                }
                // vo.LeaveDay += leaveVo.Type
                // 请假类型（1：年假，2：病假，3：婚假，4：产假，5：事假）
                if(leaveVo.Type == 2)
                {
                    vo.SickLeaveDay += leaveVo.LeaveDay;
                }
                else if(leaveVo.Type == 5)
                {
                    vo.LeaveDay += leaveVo.LeaveDay;
                }
            }

            return hashMap;
        }
        

        private void btnCommit_Click(object sender, EventArgs e)
        {
            foreach (HRPayroll vo in list)
            {
                dao.Add(vo);
            }

            MessageBoxEx.Show(this, "工资单提交成功");

            btnCommit.Enabled = false ;
        }

        private void dtTime_ValueChanged(object sender, EventArgs e)
        {
            showDesc();
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grid.Columns[e.ColumnIndex].Name.Equals("gridProbationStatus"))
            {
                if (int.Parse(e.Value.ToString()) == 0)
                {
                    e.Value = "否";
                }
                else if (int.Parse(e.Value.ToString()) == 1)
                {
                    e.Value = "是";
                }
            }
        }
    }
}
