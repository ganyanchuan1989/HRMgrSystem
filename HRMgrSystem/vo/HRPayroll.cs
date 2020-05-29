using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.vo
{
    public class HRPayroll : BaseVo
    {
        public string EmpId { get; set; }
        public string PayrollDate { get; set; }
        public int ProbationStatus { get; set; }
        public int SickLeaveDay { get; set; }
        public int LeaveDay { get; set; }
        public float RealSalary { get; set; }

        public string EmpName { get; set; }
    }
}
