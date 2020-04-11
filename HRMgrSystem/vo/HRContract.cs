    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.vo
{
    public class HRContract : BaseVo
    {
        public string EmpId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Probation { get; set; }
        public float ProbationSalary { get; set; }
        public float CorrectedSalary { get; set; }
        public int ContractType { get; set; }

        public string EmpName { get; set; }

    }
}
