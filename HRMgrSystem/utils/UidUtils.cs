using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMgrSystem.utils
{
    public class UidUtils
    {
        private static char[] constant = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        /// <summary>
        /// 生成0-z的随机字符串
        /// </summary>
        /// <param name="length">字符串长度</param>
        /// <returns>随机字符串</returns>
        public static string GUID(int length)
        {
            string checkCode = String.Empty;
            Random rd = new Random();
            for (int i = 0; i < length; i++)
            {
                checkCode += constant[rd.Next(36)].ToString();
            }
            return checkCode;
        }

        /// <summary>
        /// 四位长度的前缀
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static string GGuidPrefix(int index = 0)
        {
            if(index <= 0)
            {
                return DateTime.Now.ToString("yyyyMMddHHmmssffffff");
            }
            if(index >0 && index < 10)
            {
                return DateTime.Now.ToString("yyyyMMddHHmmssfffff")+index;
            }
            if (index > 10 && index < 100)
            {
                return DateTime.Now.ToString("yyyyMMddHHmmssffff") + index;
            }
            if (index > 100 && index < 1000)
            {
                return DateTime.Now.ToString("yyyyMMddHHmmssfff") + index;
            }
            if (index > 1000 && index < 10000)
            {
                return DateTime.Now.ToString("yyyyMMddHHmmssff") + index;
            }
            return DateTime.Now.ToString("yyyyMMddHHmmssffffff"); 
        }
    }
}
