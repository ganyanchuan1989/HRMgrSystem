using HRMgrSystem.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRMgrSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 数据库字段映射
            VoMapping.Mapping();

            // Application.Run(new MainForm());
            Application.Run(new LoginForm());
        }
    }
}
