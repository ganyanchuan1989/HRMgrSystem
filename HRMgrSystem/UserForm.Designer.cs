namespace HRMgrSystem
{
    partial class UserForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.gridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girdUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboUserType);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.cboEmp);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(635, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "用户类型";
            // 
            // cboUserType
            // 
            this.cboUserType.DisplayMember = "label";
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Location = new System.Drawing.Point(286, 56);
            this.cboUserType.Margin = new System.Windows.Forms.Padding(2);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(126, 20);
            this.cboUserType.TabIndex = 6;
            this.cboUserType.ValueMember = "value";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(483, 20);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(126, 21);
            this.txtPwd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "密码";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(286, 20);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(126, 21);
            this.txtUserName.TabIndex = 2;
            // 
            // cboEmp
            // 
            this.cboEmp.DisplayMember = "Name";
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Location = new System.Drawing.Point(76, 56);
            this.cboEmp.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(133, 20);
            this.cboEmp.TabIndex = 4;
            this.cboEmp.ValueMember = "Id";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(28, 91);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(100, 91);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(176, 91);
            this.btnClean.Margin = new System.Windows.Forms.Padding(2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(56, 30);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "清除";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "用户名";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(76, 20);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 21);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "关联员工";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(20, 155);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(56, 30);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(96, 155);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(172, 155);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(248, 155);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridID,
            this.gridEmpName,
            this.girdUserName,
            this.gridPwd,
            this.gridUserType,
            this.gridEmpId});
            this.grid.Location = new System.Drawing.Point(20, 189);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 27;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(636, 223);
            this.grid.TabIndex = 15;
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
            this.gridEmpName.HeaderText = "关联员工";
            this.gridEmpName.Name = "gridEmpName";
            this.gridEmpName.ReadOnly = true;
            // 
            // girdUserName
            // 
            this.girdUserName.DataPropertyName = "UserName";
            this.girdUserName.HeaderText = "用户名";
            this.girdUserName.Name = "girdUserName";
            this.girdUserName.ReadOnly = true;
            // 
            // gridPwd
            // 
            this.gridPwd.DataPropertyName = "password";
            this.gridPwd.HeaderText = "密码";
            this.gridPwd.Name = "gridPwd";
            this.gridPwd.ReadOnly = true;
            // 
            // gridUserType
            // 
            this.gridUserType.DataPropertyName = "userType";
            this.gridUserType.HeaderText = "员工类型";
            this.gridUserType.Name = "gridUserType";
            this.gridUserType.ReadOnly = true;
            // 
            // gridEmpId
            // 
            this.gridEmpId.DataPropertyName = "empId";
            this.gridEmpId.HeaderText = "员工ID";
            this.gridEmpId.Name = "gridEmpId";
            this.gridEmpId.ReadOnly = true;
            this.gridEmpId.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 422);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn girdUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmpId;
    }
}