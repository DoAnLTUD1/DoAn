namespace DoAn
{
    partial class SanPham
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
            this.btnSP_Dong = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.btnSP_Xoa = new System.Windows.Forms.Button();
            this.btnSP_Sua = new System.Windows.Forms.Button();
            this.btnSP_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxGiaTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNSX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDonViTinh = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSP_Dong
            // 
            this.btnSP_Dong.Location = new System.Drawing.Point(889, 587);
            this.btnSP_Dong.Name = "btnSP_Dong";
            this.btnSP_Dong.Size = new System.Drawing.Size(157, 28);
            this.btnSP_Dong.TabIndex = 8;
            this.btnSP_Dong.Text = "Đóng";
            this.btnSP_Dong.UseVisualStyleBackColor = true;
            this.btnSP_Dong.Click += new System.EventHandler(this.btnSP_Dong_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.GiaTien,
            this.SoLuong,
            this.NSX,
            this.DonViTinh});
            this.dgvSanPham.Location = new System.Drawing.Point(401, 76);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(688, 443);
            this.dgvSanPham.TabIndex = 9;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // tbxID
            // 
            this.tbxID.Enabled = false;
            this.tbxID.Location = new System.Drawing.Point(126, 76);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(254, 22);
            this.tbxID.TabIndex = 10;
            // 
            // btnSP_Xoa
            // 
            this.btnSP_Xoa.Location = new System.Drawing.Point(296, 491);
            this.btnSP_Xoa.Name = "btnSP_Xoa";
            this.btnSP_Xoa.Size = new System.Drawing.Size(84, 28);
            this.btnSP_Xoa.TabIndex = 11;
            this.btnSP_Xoa.Text = "Xóa";
            this.btnSP_Xoa.UseVisualStyleBackColor = true;
            this.btnSP_Xoa.Click += new System.EventHandler(this.btnSP_Xoa_Click);
            // 
            // btnSP_Sua
            // 
            this.btnSP_Sua.Location = new System.Drawing.Point(156, 491);
            this.btnSP_Sua.Name = "btnSP_Sua";
            this.btnSP_Sua.Size = new System.Drawing.Size(84, 28);
            this.btnSP_Sua.TabIndex = 12;
            this.btnSP_Sua.Text = "Sửa";
            this.btnSP_Sua.UseVisualStyleBackColor = true;
            this.btnSP_Sua.Click += new System.EventHandler(this.btnSP_Sua_Click);
            // 
            // btnSP_Them
            // 
            this.btnSP_Them.Location = new System.Drawing.Point(24, 491);
            this.btnSP_Them.Name = "btnSP_Them";
            this.btnSP_Them.Size = new System.Drawing.Size(84, 28);
            this.btnSP_Them.TabIndex = 13;
            this.btnSP_Them.Text = "Thêm";
            this.btnSP_Them.UseVisualStyleBackColor = true;
            this.btnSP_Them.Click += new System.EventHandler(this.btnSP_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // tbxTenSP
            // 
            this.tbxTenSP.Location = new System.Drawing.Point(126, 125);
            this.tbxTenSP.Name = "tbxTenSP";
            this.tbxTenSP.Size = new System.Drawing.Size(254, 22);
            this.tbxTenSP.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giá Tiền";
            // 
            // tbxGiaTien
            // 
            this.tbxGiaTien.Location = new System.Drawing.Point(126, 179);
            this.tbxGiaTien.Name = "tbxGiaTien";
            this.tbxGiaTien.Size = new System.Drawing.Size(254, 22);
            this.tbxGiaTien.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số Lượng";
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Location = new System.Drawing.Point(126, 233);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(254, 22);
            this.tbxSoLuong.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nhà Sản Xuất";
            // 
            // tbxNSX
            // 
            this.tbxNSX.Location = new System.Drawing.Point(126, 290);
            this.tbxNSX.Name = "tbxNSX";
            this.tbxNSX.Size = new System.Drawing.Size(254, 22);
            this.tbxNSX.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Đơn Vị Tính";
            // 
            // tbxDonViTinh
            // 
            this.tbxDonViTinh.Location = new System.Drawing.Point(126, 348);
            this.tbxDonViTinh.Name = "tbxDonViTinh";
            this.tbxDonViTinh.Size = new System.Drawing.Size(254, 22);
            this.tbxDonViTinh.TabIndex = 23;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 532);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(334, 17);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vui Lòng bấm vào đây trước khi thêm sản phẩm mới";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "Nhà Sản Xuất";
            this.NSX.MinimumWidth = 6;
            this.NSX.Name = "NSX";
            this.NSX.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 627);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxDonViTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNSX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxGiaTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSP_Them);
            this.Controls.Add(this.btnSP_Sua);
            this.Controls.Add(this.btnSP_Xoa);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnSP_Dong);
            this.Name = "SanPham";
            this.Text = "Thông Tin Hàng Hóa";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSP_Dong;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Button btnSP_Xoa;
        private System.Windows.Forms.Button btnSP_Sua;
        private System.Windows.Forms.Button btnSP_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxGiaTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNSX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDonViTinh;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
    }
}