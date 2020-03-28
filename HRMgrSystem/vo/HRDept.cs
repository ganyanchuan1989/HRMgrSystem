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
        public string HeaderId { get; set; }
    }

    
}
