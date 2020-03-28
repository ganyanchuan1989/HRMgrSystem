using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.vo
{
    public class HRWorkLog : BaseVo
    {
        public string EmpId { get; set; }
        public string LogDate { get; set; }
        public string Content { get; set; }

    }
}
