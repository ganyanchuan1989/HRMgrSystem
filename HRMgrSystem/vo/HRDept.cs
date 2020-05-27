using Dapper.Contrib.Extensions;
using HRMgrSystem.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.vo
{
    public class HRDept : BaseVo
    {
        public string Name { get; set; }

        // 部门主管
        public string HeaderId { get; set; }
        // 部门主管名称
        public string EmpName { get; set; }
    }

    
}
