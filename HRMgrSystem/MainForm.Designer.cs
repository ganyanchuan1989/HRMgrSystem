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
            this.menuItemDept = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeptJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeptEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeptContract = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeptUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeptWorkLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDeptJob,
            this.menuItemDeptEmployee,
            this.menuItemDeptContract,
            this.menuItemDeptUser,
            this.menuItemDept,
            this.menuItemDeptWorkLog});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemDept
            // 
            this.menuItemDept.Name = "menuItemDept";
            this.menuItemDept.Size = new System.Drawing.Size(81, 24);
            this.menuItemDept.Text = "部门管理";
            this.menuItemDept.Click += new System.EventHandler(this.menuItemDept_Click);
            // 
            // menuItemDeptJob
            // 
            this.menuItemDeptJob.Name = "menuItemDeptJob";
            this.menuItemDeptJob.Size = new System.Drawing.Size(81, 24);
            this.menuItemDeptJob.Text = "职位管理";
            this.menuItemDeptJob.Click += new System.EventHandler(this.menuItemDeptJob_Click);
            // 
            // menuItemDeptEmployee
            // 
            this.menuItemDeptEmployee.Name = "menuItemDeptEmployee";
            this.menuItemDeptEmployee.Size = new System.Drawing.Size(81, 24);
            this.menuItemDeptEmployee.Text = "员工管理";
            this.menuItemDeptEmployee.Click += new System.EventHandler(this.menuItemDeptEmployee_Click);
            // 
            // menuItemDeptContract
            // 
            this.menuItemDeptContract.Name = "menuItemDeptContract";
            this.menuItemDeptContract.Size = new System.Drawing.Size(81, 24);
            this.menuItemDeptContract.Text = "合同管理";
            this.menuItemDeptContract.Click += new System.EventHandler(this.menuItemDeptContract_Click);
            // 
            // menuItemDeptUser
            // 
            this.menuItemDeptUser.Name = "menuItemDeptUser";
            this.menuItemDeptUser.Size = new System.Drawing.Size(81, 24);
            this.menuItemDeptUser.Text = "用户管理";
            this.menuItemDeptUser.Click += new System.EventHandler(this.menuItemDeptUser_Click);
            // 
            // menuItemDeptWorkLog
            // 
            this.menuItemDeptWorkLog.Name = "menuItemDeptWorkLog";
            this.menuItemDeptWorkLog.Size = new System.Drawing.Size(81, 24);
            this.menuItemDeptWorkLog.Text = "工作日志";
            this.menuItemDeptWorkLog.Click += new System.EventHandler(this.menuItemDeptWorkLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 655);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeptJob;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeptEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeptContract;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeptUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemDept;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeptWorkLog;
    }
}

