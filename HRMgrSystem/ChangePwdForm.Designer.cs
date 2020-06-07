namespace HRMgrSystem
{
    partial class ChangePwdForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwdS = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "确认密码";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(76, 31);
            this.txtOldPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(141, 21);
            this.txtOldPwd.TabIndex = 1;
            // 
            // txtNewPwdS
            // 
            this.txtNewPwdS.Location = new System.Drawing.Point(76, 112);
            this.txtNewPwdS.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPwdS.Name = "txtNewPwdS";
            this.txtNewPwdS.PasswordChar = '*';
            this.txtNewPwdS.Size = new System.Drawing.Size(141, 21);
            this.txtNewPwdS.TabIndex = 3;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(76, 71);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(141, 21);
            this.txtNewPwd.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(76, 147);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 35);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "确认修改";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(21, 189);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(195, 38);
            this.lblError.TabIndex = 8;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChangePwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 232);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtNewPwdS);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePwdForm";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.ChangePwdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtNewPwdS;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblError;
    }
}