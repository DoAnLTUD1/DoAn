namespace DoAn
{
    partial class UsersForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnSP_Them = new System.Windows.Forms.Button();
            this.btnSP_Sua = new System.Windows.Forms.Button();
            this.btnSP_Xoa = new System.Windows.Forms.Button();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPer = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.Password,
            this.Permission});
            this.dgvUsers.Location = new System.Drawing.Point(425, 99);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(572, 469);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnSP_Them
            // 
            this.btnSP_Them.Location = new System.Drawing.Point(31, 540);
            this.btnSP_Them.Name = "btnSP_Them";
            this.btnSP_Them.Size = new System.Drawing.Size(84, 28);
            this.btnSP_Them.TabIndex = 16;
            this.btnSP_Them.Text = "Thêm";
            this.btnSP_Them.UseVisualStyleBackColor = true;
            // 
            // btnSP_Sua
            // 
            this.btnSP_Sua.Location = new System.Drawing.Point(171, 540);
            this.btnSP_Sua.Name = "btnSP_Sua";
            this.btnSP_Sua.Size = new System.Drawing.Size(84, 28);
            this.btnSP_Sua.TabIndex = 15;
            this.btnSP_Sua.Text = "Sửa";
            this.btnSP_Sua.UseVisualStyleBackColor = true;
            // 
            // btnSP_Xoa
            // 
            this.btnSP_Xoa.Location = new System.Drawing.Point(311, 540);
            this.btnSP_Xoa.Name = "btnSP_Xoa";
            this.btnSP_Xoa.Size = new System.Drawing.Size(84, 28);
            this.btnSP_Xoa.TabIndex = 14;
            this.btnSP_Xoa.Text = "Xóa";
            this.btnSP_Xoa.UseVisualStyleBackColor = true;
            // 
            // tbxID
            // 
            this.tbxID.Enabled = false;
            this.tbxID.Location = new System.Drawing.Point(162, 99);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(233, 22);
            this.tbxID.TabIndex = 17;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(162, 160);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(233, 22);
            this.tbxUserName.TabIndex = 18;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(162, 221);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(233, 22);
            this.tbxPassword.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên Người Dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phân Quyền";
            // 
            // cbxPer
            // 
            this.cbxPer.FormattingEnabled = true;
            this.cbxPer.Location = new System.Drawing.Point(162, 282);
            this.cbxPer.Name = "cbxPer";
            this.cbxPer.Size = new System.Drawing.Size(233, 24);
            this.cbxPer.TabIndex = 25;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Username";
            this.UserName.HeaderText = "Tên Người Dùng";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật Khẩu";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Permission
            // 
            this.Permission.DataPropertyName = "Permission";
            this.Permission.HeaderText = "Phân Quyền";
            this.Permission.MinimumWidth = 6;
            this.Permission.Name = "Permission";
            this.Permission.ReadOnly = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 604);
            this.Controls.Add(this.cbxPer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.btnSP_Them);
            this.Controls.Add(this.btnSP_Sua);
            this.Controls.Add(this.btnSP_Xoa);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnSP_Them;
        private System.Windows.Forms.Button btnSP_Sua;
        private System.Windows.Forms.Button btnSP_Xoa;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permission;
    }
}