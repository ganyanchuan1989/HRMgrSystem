namespace HRMgrSystem
{
    partial class ContractForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProSalary = new System.Windows.Forms.TextBox();
            this.txtCorSalary = new System.Windows.Forms.TextBox();
            this.txtProbation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtETime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtSTime = new System.Windows.Forms.DateTimePicker();
            this.cboContractType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.gridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridProbation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridProbationSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCorrectedSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtProSalary);
            this.groupBox1.Controls.Add(this.txtCorSalary);
            this.groupBox1.Controls.Add(this.txtProbation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtETime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtSTime);
            this.groupBox1.Controls.Add(this.cboContractType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboEmp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "合同信息";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(137, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(243, 173);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 15;
            this.btnClean.Text = "清除";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(32, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProSalary
            // 
            this.txtProSalary.Location = new System.Drawing.Point(97, 131);
            this.txtProSalary.Name = "txtProSalary";
            this.txtProSalary.Size = new System.Drawing.Size(168, 25);
            this.txtProSalary.TabIndex = 13;
            // 
            // txtCorSalary
            // 
            this.txtCorSalary.Location = new System.Drawing.Point(379, 131);
            this.txtCorSalary.Name = "txtCorSalary";
            this.txtCorSalary.Size = new System.Drawing.Size(168, 25);
            this.txtCorSalary.TabIndex = 12;
            // 
            // txtProbation
            // 
            this.txtProbation.Location = new System.Drawing.Point(639, 81);
            this.txtProbation.Name = "txtProbation";
            this.txtProbation.Size = new System.Drawing.Size(160, 25);
            this.txtProbation.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "试用期工资";
            // 
            // dtETime
            // 
            this.dtETime.CustomFormat = "yyyy-MM-dd";
            this.dtETime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtETime.Location = new System.Drawing.Point(379, 81);
            this.dtETime.Name = "dtETime";
            this.dtETime.Size = new System.Drawing.Size(168, 25);
            this.dtETime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "试用期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "转正后工资";
            // 
            // dtSTime
            // 
            this.dtSTime.CustomFormat = "yyyy-MM-dd";
            this.dtSTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSTime.Location = new System.Drawing.Point(97, 81);
            this.dtSTime.Name = "dtSTime";
            this.dtSTime.Size = new System.Drawing.Size(168, 25);
            this.dtSTime.TabIndex = 9;
            // 
            // cboContractType
            // 
            this.cboContractType.DisplayMember = "label";
            this.cboContractType.FormattingEnabled = true;
            this.cboContractType.Location = new System.Drawing.Point(639, 36);
            this.cboContractType.Name = "cboContractType";
            this.cboContractType.Size = new System.Drawing.Size(160, 23);
            this.cboContractType.TabIndex = 8;
            this.cboContractType.ValueMember = "value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "合同类型";
            // 
            // cboEmp
            // 
            this.cboEmp.DisplayMember = "Name";
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Location = new System.Drawing.Point(379, 36);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(168, 23);
            this.cboEmp.TabIndex = 6;
            this.cboEmp.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "开始时间";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(168, 25);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "结束时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "关联员工";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(292, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(196, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 242);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridID,
            this.gridEmpName,
            this.gridStartTime,
            this.gridEndTime,
            this.gridProbation,
            this.gridProbationSalary,
            this.gridCorrectedSalary,
            this.gridContractType,
            this.gridEmpID});
            this.grid.Location = new System.Drawing.Point(13, 272);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 27;
            this.grid.Size = new System.Drawing.Size(845, 196);
            this.grid.TabIndex = 21;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            // 
            // gridID
            // 
            this.gridID.DataPropertyName = "id";
            this.gridID.HeaderText = "ID";
            this.gridID.Name = "gridID";
            this.gridID.ReadOnly = true;
            // 
            // gridEmpName
            // 
            this.gridEmpName.DataPropertyName = "EmpName";
            this.gridEmpName.HeaderText = "员工";
            this.gridEmpName.Name = "gridEmpName";
            this.gridEmpName.ReadOnly = true;
            // 
            // gridStartTime
            // 
            this.gridStartTime.DataPropertyName = "StartTime";
            this.gridStartTime.HeaderText = "开始时间";
            this.gridStartTime.Name = "gridStartTime";
            this.gridStartTime.ReadOnly = true;
            // 
            // gridEndTime
            // 
            this.gridEndTime.DataPropertyName = "EndTime";
            this.gridEndTime.HeaderText = "结束时间";
            this.gridEndTime.Name = "gridEndTime";
            this.gridEndTime.ReadOnly = true;
            // 
            // gridProbation
            // 
            this.gridProbation.DataPropertyName = "Probation";
            this.gridProbation.HeaderText = "试用期";
            this.gridProbation.Name = "gridProbation";
            this.gridProbation.ReadOnly = true;
            // 
            // gridProbationSalary
            // 
            this.gridProbationSalary.DataPropertyName = "ProbationSalary";
            this.gridProbationSalary.HeaderText = "试用期工资";
            this.gridProbationSalary.Name = "gridProbationSalary";
            this.gridProbationSalary.ReadOnly = true;
            // 
            // gridCorrectedSalary
            // 
            this.gridCorrectedSalary.DataPropertyName = "CorrectedSalary";
            this.gridCorrectedSalary.HeaderText = "转正后工资";
            this.gridCorrectedSalary.Name = "gridCorrectedSalary";
            this.gridCorrectedSalary.ReadOnly = true;
            // 
            // gridContractType
            // 
            this.gridContractType.DataPropertyName = "ContractType";
            this.gridContractType.HeaderText = "合同类型";
            this.gridContractType.Name = "gridContractType";
            this.gridContractType.ReadOnly = true;
            // 
            // gridEmpID
            // 
            this.gridEmpID.DataPropertyName = "EmployeeId";
            this.gridEmpID.HeaderText = "员工ID";
            this.gridEmpID.Name = "gridEmpID";
            this.gridEmpID.ReadOnly = true;
            this.gridEmpID.Visible = false;
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 480);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox1);
            this.Name = "ContractForm";
            this.Text = "合同管理";
            this.Load += new System.EventHandler(this.ContractForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProSalary;
        private System.Windows.Forms.TextBox txtCorSalary;
        private System.Windows.Forms.TextBox txtProbation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtETime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtSTime;
        private System.Windows.Forms.ComboBox cboContractType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridProbation;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridProbationSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCorrectedSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridContractType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmpID;
    }
}