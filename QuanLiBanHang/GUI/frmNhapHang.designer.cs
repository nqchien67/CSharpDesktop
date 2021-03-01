namespace QuanLiBanHang.GUI
{
    partial class frmNhapHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_xoaspn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTongThanhToan = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvChitietPN = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbxNhaCungCap = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem_PN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTimKiem_PN = new System.Windows.Forms.ComboBox();
            this.dgvSanPham_PN = new System.Windows.Forms.DataGridView();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.don_vi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hang_san_xuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bao_hanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuongNhapVao = new System.Windows.Forms.TextBox();
            this.txtTenSP_PN = new System.Windows.Forms.TextBox();
            this.txtMaSP_PN = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnThemsp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label90 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietPN)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham_PN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(959, 13);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_xoaspn);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtTongThanhToan);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dgvChitietPN);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1165, 799);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lập phiếu nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_xoaspn
            // 
            this.btn_xoaspn.Location = new System.Drawing.Point(8, 768);
            this.btn_xoaspn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoaspn.Name = "btn_xoaspn";
            this.btn_xoaspn.Size = new System.Drawing.Size(177, 28);
            this.btn_xoaspn.TabIndex = 9;
            this.btn_xoaspn.Text = "Xóa sản phẩm vừa nhập";
            this.btn_xoaspn.UseVisualStyleBackColor = true;
            this.btn_xoaspn.Click += new System.EventHandler(this.btn_xoaspn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(865, 774);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Tổng thanh toán:";
            // 
            // txtTongThanhToan
            // 
            this.txtTongThanhToan.Location = new System.Drawing.Point(992, 770);
            this.txtTongThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongThanhToan.Name = "txtTongThanhToan";
            this.txtTongThanhToan.Size = new System.Drawing.Size(132, 22);
            this.txtTongThanhToan.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(693, 769);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "In phiếu nhập";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvChitietPN
            // 
            this.dgvChitietPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitietPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.MSP,
            this.TSP,
            this.SoLuong,
            this.GiaNhap,
            this.Tong});
            this.dgvChitietPN.Location = new System.Drawing.Point(4, 428);
            this.dgvChitietPN.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChitietPN.Name = "dgvChitietPN";
            this.dgvChitietPN.RowHeadersWidth = 51;
            this.dgvChitietPN.Size = new System.Drawing.Size(1156, 333);
            this.dgvChitietPN.TabIndex = 5;
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "ma_phieu_nhap";
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.MinimumWidth = 6;
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            this.MaPN.Width = 130;
            // 
            // MSP
            // 
            this.MSP.DataPropertyName = "ma_sp";
            this.MSP.HeaderText = "Mã sản phẩm";
            this.MSP.MinimumWidth = 6;
            this.MSP.Name = "MSP";
            this.MSP.Width = 130;
            // 
            // TSP
            // 
            this.TSP.DataPropertyName = "SanPham";
            this.TSP.HeaderText = "Tên sản phẩm";
            this.TSP.MinimumWidth = 6;
            this.TSP.Name = "TSP";
            this.TSP.ReadOnly = true;
            this.TSP.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "so_luong";
            this.SoLuong.HeaderText = "Số lượng cần nhập";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 130;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "gia_nhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 130;
            // 
            // Tong
            // 
            this.Tong.DataPropertyName = "tong";
            this.Tong.HeaderText = "Tổng tiền";
            this.Tong.MinimumWidth = 6;
            this.Tong.Name = "Tong";
            this.Tong.ReadOnly = true;
            this.Tong.Width = 130;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNhanVien);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.cbxNhaCungCap);
            this.groupBox4.Controls.Add(this.dtpNgayLap);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Location = new System.Drawing.Point(833, 54);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(324, 200);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin phiếu nhập";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(159, 127);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(132, 22);
            this.txtNhanVien.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 159);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 21);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Thêm nhà cung cấp mới";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxNhaCungCap
            // 
            this.cbxNhaCungCap.FormattingEnabled = true;
            this.cbxNhaCungCap.Location = new System.Drawing.Point(159, 26);
            this.cbxNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNhaCungCap.Name = "cbxNhaCungCap";
            this.cbxNhaCungCap.Size = new System.Drawing.Size(132, 24);
            this.cbxNhaCungCap.TabIndex = 13;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(159, 76);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(132, 22);
            this.dtpNgayLap.TabIndex = 11;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 34);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(96, 17);
            this.label46.TabIndex = 7;
            this.label46.Text = "Nhà cung cấp";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(32, 77);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(68, 17);
            this.label47.TabIndex = 6;
            this.label47.Text = "Ngày lập:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(8, 127);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(99, 17);
            this.label48.TabIndex = 5;
            this.label48.Text = "Nhân viên lập:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGiaNhap);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem_PN);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbxTimKiem_PN);
            this.groupBox3.Controls.Add(this.dgvSanPham_PN);
            this.groupBox3.Controls.Add(this.txtSoLuongNhapVao);
            this.groupBox3.Controls.Add(this.txtTenSP_PN);
            this.groupBox3.Controls.Add(this.txtMaSP_PN);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.btnThemsp);
            this.groupBox3.Location = new System.Drawing.Point(4, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(821, 366);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(480, 60);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(160, 22);
            this.txtGiaNhap.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(341, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Giá nhập:";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(663, 114);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(0, 17);
            this.lblTimKiem.TabIndex = 36;
            // 
            // txtTimKiem_PN
            // 
            this.txtTimKiem_PN.Location = new System.Drawing.Point(663, 140);
            this.txtTimKiem_PN.Name = "txtTimKiem_PN";
            this.txtTimKiem_PN.Size = new System.Drawing.Size(151, 22);
            this.txtTimKiem_PN.TabIndex = 35;
            this.txtTimKiem_PN.TextChanged += new System.EventHandler(this.txtTimKiem_PN_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(663, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Tìm theo:";
            // 
            // cbxTimKiem_PN
            // 
            this.cbxTimKiem_PN.FormattingEnabled = true;
            this.cbxTimKiem_PN.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Loại sản phẩm",
            "Tên sản phẩm",
            "Hãng sản xuất"});
            this.cbxTimKiem_PN.Location = new System.Drawing.Point(663, 74);
            this.cbxTimKiem_PN.Name = "cbxTimKiem_PN";
            this.cbxTimKiem_PN.Size = new System.Drawing.Size(151, 24);
            this.cbxTimKiem_PN.TabIndex = 33;
            this.cbxTimKiem_PN.SelectedIndexChanged += new System.EventHandler(this.cbxTimKiem_PN_SelectedIndexChanged);
            // 
            // dgvSanPham_PN
            // 
            this.dgvSanPham_PN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham_PN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sp,
            this.ten_sp,
            this.gia_sp,
            this.don_vi_tinh,
            this.hang_san_xuat,
            this.bao_hanh,
            this.so_luong,
            this.loai_sp});
            this.dgvSanPham_PN.Location = new System.Drawing.Point(3, 89);
            this.dgvSanPham_PN.Name = "dgvSanPham_PN";
            this.dgvSanPham_PN.RowHeadersWidth = 51;
            this.dgvSanPham_PN.RowTemplate.Height = 24;
            this.dgvSanPham_PN.Size = new System.Drawing.Size(654, 270);
            this.dgvSanPham_PN.TabIndex = 32;
            this.dgvSanPham_PN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_PN_CellClick);
            // 
            // ma_sp
            // 
            this.ma_sp.DataPropertyName = "ma_sp";
            this.ma_sp.HeaderText = "Mã sản phẩm";
            this.ma_sp.MinimumWidth = 6;
            this.ma_sp.Name = "ma_sp";
            this.ma_sp.ReadOnly = true;
            this.ma_sp.Width = 125;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "ten_sp";
            this.ten_sp.HeaderText = "Tên sản phẩm";
            this.ten_sp.MinimumWidth = 6;
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.ReadOnly = true;
            this.ten_sp.Width = 125;
            // 
            // gia_sp
            // 
            this.gia_sp.DataPropertyName = "gia_sp";
            this.gia_sp.HeaderText = "Giá sản phẩm";
            this.gia_sp.MinimumWidth = 6;
            this.gia_sp.Name = "gia_sp";
            this.gia_sp.ReadOnly = true;
            this.gia_sp.Width = 125;
            // 
            // don_vi_tinh
            // 
            this.don_vi_tinh.DataPropertyName = "don_vi_tinh";
            this.don_vi_tinh.HeaderText = "Đơn vị tính";
            this.don_vi_tinh.MinimumWidth = 6;
            this.don_vi_tinh.Name = "don_vi_tinh";
            this.don_vi_tinh.ReadOnly = true;
            this.don_vi_tinh.Width = 125;
            // 
            // hang_san_xuat
            // 
            this.hang_san_xuat.DataPropertyName = "hang_san_xuat";
            this.hang_san_xuat.HeaderText = "Hãng sản xuất";
            this.hang_san_xuat.MinimumWidth = 6;
            this.hang_san_xuat.Name = "hang_san_xuat";
            this.hang_san_xuat.ReadOnly = true;
            this.hang_san_xuat.Width = 125;
            // 
            // bao_hanh
            // 
            this.bao_hanh.DataPropertyName = "thoi_gian_bh";
            this.bao_hanh.HeaderText = "Thời gian bảo hành (tháng)";
            this.bao_hanh.MinimumWidth = 6;
            this.bao_hanh.Name = "bao_hanh";
            this.bao_hanh.ReadOnly = true;
            this.bao_hanh.Width = 125;
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "so_luong";
            this.so_luong.HeaderText = "Số lượng còn lại";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            this.so_luong.ReadOnly = true;
            this.so_luong.Width = 125;
            // 
            // loai_sp
            // 
            this.loai_sp.DataPropertyName = "LoaiSP";
            this.loai_sp.HeaderText = "Loại sản phẩm";
            this.loai_sp.MinimumWidth = 6;
            this.loai_sp.Name = "loai_sp";
            this.loai_sp.ReadOnly = true;
            this.loai_sp.Width = 125;
            // 
            // txtSoLuongNhapVao
            // 
            this.txtSoLuongNhapVao.Location = new System.Drawing.Point(480, 23);
            this.txtSoLuongNhapVao.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongNhapVao.Name = "txtSoLuongNhapVao";
            this.txtSoLuongNhapVao.Size = new System.Drawing.Size(160, 22);
            this.txtSoLuongNhapVao.TabIndex = 31;
            this.txtSoLuongNhapVao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongNhapVao_KeyPress);
            // 
            // txtTenSP_PN
            // 
            this.txtTenSP_PN.Location = new System.Drawing.Point(147, 58);
            this.txtTenSP_PN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP_PN.Name = "txtTenSP_PN";
            this.txtTenSP_PN.Size = new System.Drawing.Size(160, 22);
            this.txtTenSP_PN.TabIndex = 25;
            // 
            // txtMaSP_PN
            // 
            this.txtMaSP_PN.Location = new System.Drawing.Point(147, 22);
            this.txtMaSP_PN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP_PN.Name = "txtMaSP_PN";
            this.txtMaSP_PN.Size = new System.Drawing.Size(160, 22);
            this.txtMaSP_PN.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(341, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Số lượng nhập vào:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 62);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 17);
            this.label22.TabIndex = 20;
            this.label22.Text = "Tên sản phẩm:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 26);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 17);
            this.label23.TabIndex = 15;
            this.label23.Text = "Mã sản phẩm:";
            // 
            // btnThemsp
            // 
            this.btnThemsp.Location = new System.Drawing.Point(667, 330);
            this.btnThemsp.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemsp.Name = "btnThemsp";
            this.btnThemsp.Size = new System.Drawing.Size(147, 28);
            this.btnThemsp.TabIndex = 6;
            this.btnThemsp.Text = "Thêm sản phẩm";
            this.btnThemsp.UseVisualStyleBackColor = true;
            this.btnThemsp.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label90);
            this.groupBox2.Controls.Add(this.label87);
            this.groupBox2.Controls.Add(this.txtMaNCC);
            this.groupBox2.Controls.Add(this.label88);
            this.groupBox2.Controls.Add(this.txtTenNCC);
            this.groupBox2.Controls.Add(this.txtSDTNCC);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(833, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(324, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhà cung cấp";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(26, 114);
            this.label90.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(95, 17);
            this.label90.TabIndex = 9;
            this.label90.Text = "Số điện thoại:";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(26, 42);
            this.label87.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(121, 17);
            this.label87.TabIndex = 12;
            this.label87.Text = "Mã nhà cung cấp:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(159, 42);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(132, 22);
            this.txtMaNCC.TabIndex = 8;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(26, 74);
            this.label88.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(123, 17);
            this.label88.TabIndex = 11;
            this.label88.Text = "Tên nhà cung cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(159, 74);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(132, 22);
            this.txtTenNCC.TabIndex = 7;
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Location = new System.Drawing.Point(159, 111);
            this.txtSDTNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(132, 22);
            this.txtSDTNCC.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(493, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lập phiếu nhập";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 49);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 828);
            this.tabControl1.TabIndex = 36;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1187, 875);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapHang";
            this.Text = "Nhập hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NhapHang_FormClosed);
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietPN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham_PN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnThoat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_xoaspn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTongThanhToan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvChitietPN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbxNhaCungCap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem_PN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxTimKiem_PN;
        private System.Windows.Forms.DataGridView dgvSanPham_PN;
        private System.Windows.Forms.TextBox txtSoLuongNhapVao;
        private System.Windows.Forms.TextBox txtTenSP_PN;
        private System.Windows.Forms.TextBox txtMaSP_PN;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnThemsp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn don_vi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hang_san_xuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn bao_hanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_sp;
    }
}