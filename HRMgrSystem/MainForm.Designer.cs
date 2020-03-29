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
            this.menuItemMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContract = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDept = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWorkLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemJC = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuItemWorkLog,
            this.menuItemJC});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemUser
            // 
            this.menuItemUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMgr,
            this.menuItemChangePwd});
            this.menuItemUser.Name = "menuItemUser";
            this.menuItemUser.Size = new System.Drawing.Size(81, 24);
            this.menuItemUser.Text = "用户管理";
            // 
            // menuItemMgr
            // 
            this.menuItemMgr.Name = "menuItemMgr";
            this.menuItemMgr.Size = new System.Drawing.Size(144, 26);
            this.menuItemMgr.Text = "管理员";
            this.menuItemMgr.Click += new System.EventHandler(this.管理员ToolStripMenuItem_Click);
            // 
            // menuItemChangePwd
            // 
            this.menuItemChangePwd.Name = "menuItemChangePwd";
            this.menuItemChangePwd.Size = new System.Drawing.Size(144, 26);
            this.menuItemChangePwd.Text = "修改密码";
            this.menuItemChangePwd.Click += new System.EventHandler(this.menuItemChangePwd_Click);
            // 
            // menuItemEmployee
            // 
            this.menuItemEmployee.Name = "menuItemEmployee";
            this.menuItemEmployee.Size = new System.Drawing.Size(81, 24);
            this.menuItemEmployee.Text = "员工管理";
            this.menuItemEmployee.Click += new System.EventHandler(this.menuItemDeptEmployee_Click);
            // 
            // menuItemContract
            // 
            this.menuItemContract.Name = "menuItemContract";
            this.menuItemContract.Size = new System.Drawing.Size(81, 24);
            this.menuItemContract.Text = "合同管理";
            this.menuItemContract.Click += new System.EventHandler(this.menuItemDeptContract_Click);
            // 
            // menuItemDept
            // 
            this.menuItemDept.Name = "menuItemDept";
            this.menuItemDept.Size = new System.Drawing.Size(81, 24);
            this.menuItemDept.Text = "部门管理";
            this.menuItemDept.Click += new System.EventHandler(this.menuItemDept_Click);
            // 
            // menuItemJob
            // 
            this.menuItemJob.Name = "menuItemJob";
            this.menuItemJob.Size = new System.Drawing.Size(81, 24);
            this.menuItemJob.Text = "职位管理";
            this.menuItemJob.Click += new System.EventHandler(this.menuItemDeptJob_Click);
            // 
            // menuItemWorkLog
            // 
            this.menuItemWorkLog.Name = "menuItemWorkLog";
            this.menuItemWorkLog.Size = new System.Drawing.Size(81, 24);
            this.menuItemWorkLog.Text = "工作日志";
            this.menuItemWorkLog.Click += new System.EventHandler(this.menuItemDeptWorkLog_Click);
            // 
            // menuItemJC
            // 
            this.menuItemJC.Name = "menuItemJC";
            this.menuItemJC.Size = new System.Drawing.Size(81, 24);
            this.menuItemJC.Text = "奖惩管理";
            this.menuItemJC.Click += new System.EventHandler(this.奖惩管理ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 655);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem menuItemWorkLog;
        private System.Windows.Forms.ToolStripMenuItem menuItemJC;
        private System.Windows.Forms.ToolStripMenuItem menuItemMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemChangePwd;
    }
}

