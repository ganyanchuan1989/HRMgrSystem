using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMgrSystem.vo;

namespace HRMgrSystem
{
    public class GlobalInfo
    {
        public static HRUser loginUser;
        public static HREmployee loginEmp;

        public const int EMP = 1;// 普通员工
        public const int DEPT_MGR = 2; // 部门经理
        public const int ADMIN = 3; // 管理员

    }
}
