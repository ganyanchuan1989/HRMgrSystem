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

        public static bool EmptyStr(string str)
        {
            if (str == null || str.Trim() == "")
                return true;

            return false;
        }

        public static bool EmptyObj(object obj)
        {
            return obj == null;
        }

        public static bool EmptyFloat(float num)
        {
            if (float.IsNaN(num))
                return true;

            return false;
        }

        
    }
}
