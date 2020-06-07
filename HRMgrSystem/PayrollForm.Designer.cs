namespace HRMgrSystem
{
    partial class PayrollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.gridEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPayrollDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridProbationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSickLeaveDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridReadSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridEmpId,
            this.gridEmpName,
            this.gridPayrollDate,
            this.gridProbationStatus,
            this.gridSickLeaveDay,
            this.gridLeaveDate,
            this.gridReadSalary});
            this.grid.Location = new System.Drawing.Point(12, 143);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 23;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(745, 226);
            this.grid.TabIndex = 0;
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            // 
            // gridEmpId
            // 
            this.gridEmpId.DataPropertyName = "EmpId";
            this.gridEmpId.HeaderText = "员工ID";
            this.gridEmpId.Name = "gridEmpId";
            this.gridEmpId.ReadOnly = true;
            // 
            // gridEmpName
            // 
            this.gridEmpName.DataPropertyName = "EmpName";
            this.gridEmpName.HeaderText = "员工名称";
            this.gridEmpName.Name = "gridEmpName";
            this.gridEmpName.ReadOnly = true;
            // 
            // gridPayrollDate
            // 
            this.gridPayrollDate.DataPropertyName = "PayrollDate";
            this.gridPayrollDate.HeaderText = "工资单日期";
            this.gridPayrollDate.Name = "gridPayrollDate";
            this.gridPayrollDate.ReadOnly = true;
            // 
            // gridProbationStatus
            // 
            this.gridProbationStatus.DataPropertyName = "ProbationStatus";
            this.gridProbationStatus.HeaderText = "是否试用期";
            this.gridProbationStatus.Name = "gridProbationStatus";
            this.gridProbationStatus.ReadOnly = true;
            // 
            // gridSickLeaveDay
            // 
            this.gridSickLeaveDay.DataPropertyName = "SickLeaveDay";
            this.gridSickLeaveDay.HeaderText = "病假天数";
            this.gridSickLeaveDay.Name = "gridSickLeaveDay";
            this.gridSickLeaveDay.ReadOnly = true;
            // 
            // gridLeaveDate
            // 
            this.gridLeaveDate.DataPropertyName = "LeaveDay";
            this.gridLeaveDate.HeaderText = "事件天数";
            this.gridLeaveDate.Name = "gridLeaveDate";
            this.gridLeaveDate.ReadOnly = true;
            // 
            // gridReadSalary
            // 
            this.gridReadSalary.DataPropertyName = "RealSalary";
            this.gridReadSalary.HeaderText = "实际工资";
            this.gridReadSalary.Name = "gridReadSalary";
            this.gridReadSalary.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.dtTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工资单";
            // 
            // lblDesc
            // 
            this.lblDesc.ForeColor = System.Drawing.Color.Maroon;
            this.lblDesc.Location = new System.Drawing.Point(273, 26);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(447, 60);
            this.lblDesc.TabIndex = 37;
            this.lblDesc.Text = "111";
            // 
            // btnCommit
            // 
            this.btnCommit.Enabled = false;
            this.btnCommit.Location = new System.Drawing.Point(161, 81);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(73, 30);
            this.btnCommit.TabIndex = 36;
            this.btnCommit.Text = "确认提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(69, 81);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(73, 30);
            this.btnCreate.TabIndex = 35;
            this.btnCreate.Text = "批量生成";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "yyyy-MM-dd";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(69, 36);
            this.dtTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(165, 21);
            this.dtTime.TabIndex = 11;
            this.dtTime.ValueChanged += new System.EventHandler(this.dtTime_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "时间：";
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Name = "PayrollForm";
            this.Text = "批量工资单";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPayrollDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridProbationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSickLeaveDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridReadSalary;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label lblDesc;
    }
}