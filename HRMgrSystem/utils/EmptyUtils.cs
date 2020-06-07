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


        public static bool IsNaN(string str)
        {
            double num = 0;
            if (!Double.TryParse(str, out num))
            {
                return true;
            }
            return false;
        }

        public static bool IsEmail(string str)
        {
            if(str.IndexOf("@")<0 || str.IndexOf(".") < 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 字符串不为空情况下，是否是有效字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool NotNullIsNaN(string str)
        {
            if (EmptyStr(str)) return true;
            return IsNaN(str);
        }
    }
}
