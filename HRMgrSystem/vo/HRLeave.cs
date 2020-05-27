using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.vo
{
    public class HRLeave : BaseVo
    {
        public string EmpId { get; set; }
        public int Type { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public string Cause { get; set; }
        public int Status { get; set; }

        public string EmpName { get; set; }
    }
}
