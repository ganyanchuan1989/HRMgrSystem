using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMgrSystem.db;
using HRMgrSystem.vo;

namespace HRMgrSystem
{
    public partial class ChangePwdForm : Form
    {

        private UserDao dao = new UserDao();

        public ChangePwdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HRUser user = dao.Login(GlobalInfo.loginUser.UserName, txtOldPwd.Text);
            if(user == null)
            {
                lblError.Text = "原始密码输入不正确。";
            }
            else
            {
                if(txtNewPwd.Text != txtNewPwdS.Text)
                {
                    lblError.Text = "两次密码输入不一致，请重新输入";
                }
                else
                {
                    user.Password = txtNewPwd.Text;
                    dao.Update(user);
                }
            }
        }

        private void ChangePwdForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
