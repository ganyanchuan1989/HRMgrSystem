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
using HRMgrSystem.utils;


namespace HRMgrSystem
{
    public partial class ChangePwdForm : Form
    {

        private UserDao dao = new UserDao();

        public ChangePwdForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 验证输入
        /// </summary>
        /// <returns></returns>
        private bool validateInput()
        {
            if (EmptyUtils.EmptyStr(txtOldPwd.Text))
            {
                lblError.Text = "请输入原始密码";
                txtOldPwd.Focus();
                return false;
            }

            if (EmptyUtils.EmptyStr(txtNewPwd.Text))
            {
                lblError.Text = "请输入新密码";
                txtNewPwd.Focus();
                return false;
            }

            if (txtNewPwd.Text.Length < 5)
            {
                lblError.Text = "密码长度最低5位数";
                txtNewPwd.Focus();
                return false;
            }
            if (txtNewPwd.Text != txtNewPwdS.Text)
            {
                lblError.Text = "两次密码输入不一致，请重新输入";
                txtNewPwdS.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validateInput()) return;
            HRUser user = dao.Login(GlobalInfo.loginUser.UserName, txtOldPwd.Text);
            if(user == null)
            {
                lblError.Text = "原始密码输入不正确。";
            }
            else
            {
                user.Password = txtNewPwd.Text;
                dao.Update(user);
                MessageBoxEx.Show(this, "密码修改成功");
                Close();
            }
        }

        private void ChangePwdForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
