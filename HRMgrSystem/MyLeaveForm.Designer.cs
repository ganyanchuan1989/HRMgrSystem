namespace HRMgrSystem
{
    partial class MyLeaveForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLeaveType = new System.Windows.Forms.ComboBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gridLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLeaveDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLeaveStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLeaveCause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLeaveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridLeaveType,
            this.gridLeaveDay,
            this.gridLeaveStartDate,
            this.gridLeaveCause,
            this.gridLeaveStatus});
            this.grid.Location = new System.Drawing.Point(12, 156);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 23;
            this.grid.Size = new System.Drawing.Size(550, 238);
            this.grid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboLeaveType);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请假查询";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(37, 91);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 30);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(104, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(151, 21);
            this.txtId.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "请假ID:";
            // 
            // cboLeaveType
            // 
            this.cboLeaveType.FormattingEnabled = true;
            this.cboLeaveType.Location = new System.Drawing.Point(104, 56);
            this.cboLeaveType.Margin = new System.Windows.Forms.Padding(2);
            this.cboLeaveType.Name = "cboLeaveType";
            this.cboLeaveType.Size = new System.Drawing.Size(151, 20);
            this.cboLeaveType.TabIndex = 15;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(340, 58);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(151, 21);
            this.dtStartDate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "请假类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "开始日期：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gridLeaveType
            // 
            this.gridLeaveType.DataPropertyName = "type";
            this.gridLeaveType.HeaderText = "请假类型";
            this.gridLeaveType.Name = "gridLeaveType";
            this.gridLeaveType.ReadOnly = true;
            // 
            // gridLeaveDay
            // 
            this.gridLeaveDay.DataPropertyName = "LeaveDay";
            this.gridLeaveDay.HeaderText = "请假天数";
            this.gridLeaveDay.Name = "gridLeaveDay";
            this.gridLeaveDay.ReadOnly = true;
            // 
            // gridLeaveStartDate
            // 
            this.gridLeaveStartDate.DataPropertyName = "LeaveDate";
            this.gridLeaveStartDate.HeaderText = "请假开始时间";
            this.gridLeaveStartDate.Name = "gridLeaveStartDate";
            this.gridLeaveStartDate.ReadOnly = true;
            // 
            // gridLeaveCause
            // 
            this.gridLeaveCause.DataPropertyName = "cause";
            this.gridLeaveCause.HeaderText = "请假原因";
            this.gridLeaveCause.Name = "gridLeaveCause";
            this.gridLeaveCause.ReadOnly = true;
            // 
            // gridLeaveStatus
            // 
            this.gridLeaveStatus.DataPropertyName = "status";
            this.gridLeaveStatus.HeaderText = "请假状态";
            this.gridLeaveStatus.Name = "gridLeaveStatus";
            this.gridLeaveStatus.ReadOnly = true;
            // 
            // LeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Name = "LeaveForm";
            this.Text = "我的请假";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLeaveType;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveCause;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveStatus;
    }
}