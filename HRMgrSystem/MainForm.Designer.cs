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
            this.menuItemPayroll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.我的主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuItemPayroll,
            this.menuItemPersonal});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
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
            // menuItemPayroll
            // 
            this.menuItemPayroll.Name = "menuItemPayroll";
            this.menuItemPayroll.Size = new System.Drawing.Size(80, 21);
            this.menuItemPayroll.Text = "批量工资单";
            this.menuItemPayroll.Click += new System.EventHandler(this.薪资管理ToolStripMenuItem_Click);
            // 
            // menuItemPersonal
            // 
            this.menuItemPersonal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的主页ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuItemPersonal.Name = "menuItemPersonal";
            this.menuItemPersonal.Size = new System.Drawing.Size(68, 21);
            this.menuItemPersonal.Text = "个人中心";
            // 
            // 我的主页ToolStripMenuItem
            // 
            this.我的主页ToolStripMenuItem.Name = "我的主页ToolStripMenuItem";
            this.我的主页ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.我的主页ToolStripMenuItem.Text = "我的主页";
            this.我的主页ToolStripMenuItem.Click += new System.EventHandler(this.我的主页ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
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
        private System.Windows.Forms.ToolStripMenuItem menuItemPayroll;
        private System.Windows.Forms.ToolStripMenuItem menuItemPersonal;
        private System.Windows.Forms.ToolStripMenuItem 我的主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

