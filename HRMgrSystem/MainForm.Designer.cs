namespace HRMgrSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContract = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDept = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemJob = new System.Windows.Forms.ToolStripMenuItem();
            this.我的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假申请ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假审批ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的请假ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的合同ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的工资单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.薪资管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUser,
            this.menuItemEmployee,
            this.menuItemContract,
            this.menuItemDept,
            this.menuItemJob,
            this.薪资管理ToolStripMenuItem,
            this.我的ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(924, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemUser
            // 
            this.menuItemUser.Name = "menuItemUser";
            this.menuItemUser.Size = new System.Drawing.Size(68, 21);
            this.menuItemUser.Text = "用户管理";
            this.menuItemUser.Click += new System.EventHandler(this.menuItemUser_Click);
            // 
            // menuItemEmployee
            // 
            this.menuItemEmployee.Name = "menuItemEmployee";
            this.menuItemEmployee.Size = new System.Drawing.Size(68, 21);
            this.menuItemEmployee.Text = "员工管理";
            this.menuItemEmployee.Click += new System.EventHandler(this.menuItemDeptEmployee_Click);
            // 
            // menuItemContract
            // 
            this.menuItemContract.Name = "menuItemContract";
            this.menuItemContract.Size = new System.Drawing.Size(68, 21);
            this.menuItemContract.Text = "合同管理";
            this.menuItemContract.Click += new System.EventHandler(this.menuItemDeptContract_Click);
            // 
            // menuItemDept
            // 
            this.menuItemDept.Name = "menuItemDept";
            this.menuItemDept.Size = new System.Drawing.Size(68, 21);
            this.menuItemDept.Text = "部门管理";
            this.menuItemDept.Click += new System.EventHandler(this.menuItemDept_Click);
            // 
            // menuItemJob
            // 
            this.menuItemJob.Name = "menuItemJob";
            this.menuItemJob.Size = new System.Drawing.Size(68, 21);
            this.menuItemJob.Text = "职位管理";
            this.menuItemJob.Click += new System.EventHandler(this.menuItemDeptJob_Click);
            // 
            // 我的ToolStripMenuItem
            // 
            this.我的ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请假申请ToolStripMenuItem,
            this.我的请假ToolStripMenuItem,
            this.请假审批ToolStripMenuItem,
            this.我的合同ToolStripMenuItem,
            this.我的工资单ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.我的ToolStripMenuItem.Name = "我的ToolStripMenuItem";
            this.我的ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.我的ToolStripMenuItem.Text = "个人中心";
            // 
            // 请假申请ToolStripMenuItem
            // 
            this.请假申请ToolStripMenuItem.Name = "请假申请ToolStripMenuItem";
            this.请假申请ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.请假申请ToolStripMenuItem.Text = "请假申请";
            this.请假申请ToolStripMenuItem.Click += new System.EventHandler(this.请假申请ToolStripMenuItem_Click);
            // 
            // 请假审批ToolStripMenuItem
            // 
            this.请假审批ToolStripMenuItem.Name = "请假审批ToolStripMenuItem";
            this.请假审批ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.请假审批ToolStripMenuItem.Text = "我的审批";
            this.请假审批ToolStripMenuItem.Click += new System.EventHandler(this.请假审批ToolStripMenuItem_Click);
            // 
            // 我的请假ToolStripMenuItem
            // 
            this.我的请假ToolStripMenuItem.Name = "我的请假ToolStripMenuItem";
            this.我的请假ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.我的请假ToolStripMenuItem.Text = "我的请假";
            this.我的请假ToolStripMenuItem.Click += new System.EventHandler(this.我的请假ToolStripMenuItem_Click);
            // 
            // 我的合同ToolStripMenuItem
            // 
            this.我的合同ToolStripMenuItem.Name = "我的合同ToolStripMenuItem";
            this.我的合同ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.我的合同ToolStripMenuItem.Text = "我的合同";
            this.我的合同ToolStripMenuItem.Click += new System.EventHandler(this.我的合同ToolStripMenuItem_Click);
            // 
            // 我的工资单ToolStripMenuItem
            // 
            this.我的工资单ToolStripMenuItem.Name = "我的工资单ToolStripMenuItem";
            this.我的工资单ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.我的工资单ToolStripMenuItem.Text = "我的工资单";
            this.我的工资单ToolStripMenuItem.Click += new System.EventHandler(this.我的工资单ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 薪资管理ToolStripMenuItem
            // 
            this.薪资管理ToolStripMenuItem.Name = "薪资管理ToolStripMenuItem";
            this.薪资管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.薪资管理ToolStripMenuItem.Text = "批量工资单";
            this.薪资管理ToolStripMenuItem.Click += new System.EventHandler(this.薪资管理ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 524);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "人力资源管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemJob;
        private System.Windows.Forms.ToolStripMenuItem menuItemEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuItemContract;
        private System.Windows.Forms.ToolStripMenuItem menuItemUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemDept;
        private System.Windows.Forms.ToolStripMenuItem 我的ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请假申请ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请假审批ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的请假ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的合同ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的工资单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 薪资管理ToolStripMenuItem;
    }
}

