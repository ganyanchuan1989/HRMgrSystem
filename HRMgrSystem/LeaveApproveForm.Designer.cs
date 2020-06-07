namespace HRMgrSystem
{
    partial class LeaveApproveForm
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
            this.gridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLeaveDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFail = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.gridId,
            this.gridEmpId,
            this.gridEmpName,
            this.gridLeaveType,
            this.gridLeaveDate,
            this.gridLeaveDay,
            this.gridCause,
            this.gridStatus});
            this.grid.Location = new System.Drawing.Point(12, 176);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 23;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(765, 263);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            // 
            // gridId
            // 
            this.gridId.DataPropertyName = "id";
            this.gridId.HeaderText = "ID";
            this.gridId.Name = "gridId";
            this.gridId.ReadOnly = true;
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
            // gridLeaveType
            // 
            this.gridLeaveType.DataPropertyName = "type";
            this.gridLeaveType.HeaderText = "请假类型";
            this.gridLeaveType.Name = "gridLeaveType";
            this.gridLeaveType.ReadOnly = true;
            // 
            // gridLeaveDate
            // 
            this.gridLeaveDate.DataPropertyName = "leaveDate";
            this.gridLeaveDate.HeaderText = "请假时间";
            this.gridLeaveDate.Name = "gridLeaveDate";
            this.gridLeaveDate.ReadOnly = true;
            // 
            // gridLeaveDay
            // 
            this.gridLeaveDay.DataPropertyName = "leaveDay";
            this.gridLeaveDay.HeaderText = "请假天数";
            this.gridLeaveDay.Name = "gridLeaveDay";
            this.gridLeaveDay.ReadOnly = true;
            // 
            // gridCause
            // 
            this.gridCause.DataPropertyName = "cause";
            this.gridCause.HeaderText = "请假原因";
            this.gridCause.Name = "gridCause";
            this.gridCause.ReadOnly = true;
            // 
            // gridStatus
            // 
            this.gridStatus.DataPropertyName = "status";
            this.gridStatus.HeaderText = "请假状态";
            this.gridStatus.Name = "gridStatus";
            this.gridStatus.ReadOnly = true;
            // 
            // btnFail
            // 
            this.btnFail.Enabled = false;
            this.btnFail.Location = new System.Drawing.Point(91, 141);
            this.btnFail.Margin = new System.Windows.Forms.Padding(2);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(56, 30);
            this.btnFail.TabIndex = 37;
            this.btnFail.Text = "不通过";
            this.btnFail.UseVisualStyleBackColor = true;
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);
            // 
            // btnPass
            // 
            this.btnPass.Enabled = false;
            this.btnPass.Location = new System.Drawing.Point(12, 141);
            this.btnPass.Margin = new System.Windows.Forms.Padding(2);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(56, 30);
            this.btnPass.TabIndex = 36;
            this.btnPass.Text = "通过";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboEmp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 106);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表单区";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(62, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(167, 21);
            this.txtId.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 30);
            this.button1.TabIndex = 43;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(42, 62);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 30);
            this.btnFind.TabIndex = 42;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DisplayMember = "label";
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(496, 19);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(127, 20);
            this.cboStatus.TabIndex = 41;
            this.cboStatus.ValueMember = "value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "状态：";
            // 
            // cboEmp
            // 
            this.cboEmp.DisplayMember = "Name";
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Location = new System.Drawing.Point(281, 19);
            this.cboEmp.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(127, 20);
            this.cboEmp.TabIndex = 39;
            this.cboEmp.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "员工";
            // 
            // LeaveApproveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.btnPass);
            this.Name = "LeaveApproveForm";
            this.Text = "我的审批";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnFail;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLeaveDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCause;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridStatus;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}