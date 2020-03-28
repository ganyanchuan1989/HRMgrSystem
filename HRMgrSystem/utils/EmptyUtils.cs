using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMgrSystem.vo;

namespace HRMgrSystem.utils
{
    public class EmptyUtils
    {
        public static bool EmptyList<T>(List<T> list)
        {
            if (list != null && list.Count > 0)
                return false;
            return true;
        }
    }
}
