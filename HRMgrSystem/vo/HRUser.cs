using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.vo
{
    public class HRUser : BaseVo
    {
        public string EmpId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int Status { get; set; }
        public int UserType { get; set; }

        public string EmpName { get; set; }
    }
}
