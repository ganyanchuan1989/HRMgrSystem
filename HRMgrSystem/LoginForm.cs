using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMgrSystem.vo;
using HRMgrSystem.db;
using HRMgrSystem.utils;

namespace HRMgrSystem
{
    public partial class LoginForm : Form
    {
        private UserDao dao = new UserDao();
        private EmployeeDao empDao = new EmployeeDao();

        public LoginForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            HRUser user = dao.Login(txtUserName.Text, txtPwd.Text);
            if(user == null)
            {
                lblError.Text = "用户名或者密码不正确，请重新输入。";
            }
            else
            {
                if(user.Status == 2)
                {
                    lblError.Text = "用户已经被停用，请联系管理员。";
                }
                else
                {
                    this.Hide();

                    GlobalInfo.loginUser = user;
                    GlobalInfo.loginEmp = empDao.FindById(user.EmpId);

                    MainForm main = new MainForm();
                    main.Show();
                    // HomeForm home = new HomeForm();
                    // home.Show();
                }
            }
        }
    }
}
