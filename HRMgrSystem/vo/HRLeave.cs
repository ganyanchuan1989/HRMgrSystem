﻿using System;
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
        public string LeaveDate { get; set; }
        public int LeaveDay { get; set; }
        public string Cause { get; set; }
        public int Status { get; set; }

        public string EmpName { get; set; }
    }
}
