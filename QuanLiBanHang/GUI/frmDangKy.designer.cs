namespace QuanLiBanHang.GUI{
    partial class frmDangKy
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.clmMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập xác nhận mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tìm nhân viên: ";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(193, 178);
            this.txtconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.Size = new System.Drawing.Size(172, 22);
            this.txtconfirm.TabIndex = 2;
            this.txtconfirm.UseSystemPasswordChar = true;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(196, 130);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(172, 22);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // btnDangky
            // 
            this.btnDangky.Location = new System.Drawing.Point(88, 252);
            this.btnDangky.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(100, 28);
            this.btnDangky.TabIndex = 3;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(196, 252);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(304, 252);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đăng ký tài khoản mới";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaNV,
            this.clmTenNV,
            this.clmGioiTinh,
            this.clmNgaySinh,
            this.clmSdt,
            this.clmDiaChi,
            this.clmChucVu});
            this.dgvNhanVien.Location = new System.Drawing.Point(423, 130);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(339, 175);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // clmMaNV
            // 
            this.clmMaNV.DataPropertyName = "ma_nv";
            this.clmMaNV.HeaderText = "Mã nhân viên";
            this.clmMaNV.MinimumWidth = 6;
            this.clmMaNV.Name = "clmMaNV";
            this.clmMaNV.ReadOnly = true;
            this.clmMaNV.Width = 125;
            // 
            // clmTenNV
            // 
            this.clmTenNV.DataPropertyName = "ten_nv";
            this.clmTenNV.HeaderText = "Tên nhân viên";
            this.clmTenNV.MinimumWidth = 6;
            this.clmTenNV.Name = "clmTenNV";
            this.clmTenNV.ReadOnly = true;
            this.clmTenNV.Width = 125;
            // 
            // clmGioiTinh
            // 
            this.clmGioiTinh.DataPropertyName = "gioi_tinh";
            this.clmGioiTinh.HeaderText = "Giới tính";
            this.clmGioiTinh.MinimumWidth = 6;
            this.clmGioiTinh.Name = "clmGioiTinh";
            this.clmGioiTinh.ReadOnly = true;
            this.clmGioiTinh.Width = 125;
            // 
            // clmNgaySinh
            // 
            this.clmNgaySinh.DataPropertyName = "ngay_sinh";
            this.clmNgaySinh.HeaderText = "Ngày sinh";
            this.clmNgaySinh.MinimumWidth = 6;
            this.clmNgaySinh.Name = "clmNgaySinh";
            this.clmNgaySinh.ReadOnly = true;
            this.clmNgaySinh.Width = 125;
            // 
            // clmSdt
            // 
            this.clmSdt.DataPropertyName = "sdt_nv";
            this.clmSdt.HeaderText = "Số điện thoại";
            this.clmSdt.MinimumWidth = 6;
            this.clmSdt.Name = "clmSdt";
            this.clmSdt.ReadOnly = true;
            this.clmSdt.Width = 125;
            // 
            // clmDiaChi
            // 
            this.clmDiaChi.DataPropertyName = "dia_chi_nv";
            this.clmDiaChi.HeaderText = "Địa chỉ";
            this.clmDiaChi.MinimumWidth = 6;
            this.clmDiaChi.Name = "clmDiaChi";
            this.clmDiaChi.ReadOnly = true;
            this.clmDiaChi.Width = 125;
            // 
            // clmChucVu
            // 
            this.clmChucVu.DataPropertyName = "ChucVu";
            this.clmChucVu.HeaderText = "Chức vụ";
            this.clmChucVu.MinimumWidth = 6;
            this.clmChucVu.Name = "clmChucVu";
            this.clmChucVu.ReadOnly = true;
            this.clmChucVu.Width = 125;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(527, 86);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 22);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(196, 86);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(172, 22);
            this.txtMaNV.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã nhân viên:";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 317);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKy";
            this.Text = "Đăng ký tài khoản mới";
            this.Load += new System.EventHandler(this.frmDangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChucVu;
    }
}