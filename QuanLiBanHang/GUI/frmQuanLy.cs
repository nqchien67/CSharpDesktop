using QuanLiBanHang.BUS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLiBanHang.GUI
{
    public partial class frmQuanLy : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        ChucVuBUS chucVuBUS = new ChucVuBUS();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        SanPhamBUS sanPhamBUS = new SanPhamBUS();
        LoaiSanPhamBUS loaiSanPhamBUS = new LoaiSanPhamBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();

        public string maNV;
        private bool nhapMoi = true;
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }

        private void LoadData()
        {
            LoadNhanVien();
            LoadfrmSanPham();
            LoadfrmKhachHang();
            LoadfrmNCC();
        }

        private void LoadNhanVien()
        {
            BindDgvNhanVien(nhanVienBUS.GetNhanViens());
            BindCbxChucVu();

            void BindCbxChucVu()
            {
                cbxChucVu.DataSource = chucVuBUS.GetChucVus();
                cbxChucVu.DisplayMember = "ten_cv";
                cbxChucVu.ValueMember = "ma_cv";
            }
        }

        private void LoadfrmSanPham()
        {
            BindDgvSanPham(sanPhamBUS.GetSanPhams());
            BindCbxLoaiSP();

            void BindCbxLoaiSP()
            {
                cbxLoaiSP.DataSource = loaiSanPhamBUS.GetLoaiSPhams();
                cbxLoaiSP.DisplayMember = "ten_loai_sp";
                cbxLoaiSP.ValueMember = "ma_loai";
            }
        }

        #region Nhân viên
        private void BindDgvNhanVien(List<NhanVien> nhanViens)
        {
            dgvNhanVien.DataSource = nhanViens;
            dgvNhanVien.Columns["ma_cv"].Visible = false;
            dgvNhanVien.Columns["PhieuNhaps"].Visible = false;
            dgvNhanVien.Columns["HoaDons"].Visible = false;
            dgvNhanVien.Columns["TaiKhoans"].Visible = false;
        }


        private string GetGioiTinhFromRdb()
        {
            return rdbNam.Checked ? "Nam" : "Nữ";
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BindNhanVienFromDgvToTbx();
                txtMaNV.Enabled = false;
                nhapMoi = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            void BindNhanVienFromDgvToTbx()
            {
                string maNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                NhanVien nhanVien = nhanVienBUS.GetNhanVienByMaNV(maNV);
                txtMaNV.Text = nhanVien.ma_nv.ToString();
                txtTenNV.Text = nhanVien.ten_nv.ToString();
                dateNgaySinh.Text = nhanVien.ngay_sinh.ToString();
                string gioiTinh = nhanVien.gioi_tinh.ToString();
                txtSdtNV.Text = nhanVien.sdt_nv.ToString();
                txtDiaChiNV.Text = nhanVien.dia_chi_nv.ToString();
                cbxChucVu.SelectedValue = nhanVien.ma_cv.ToString();
                BindGioiTinhToRdb(gioiTinh);
            }

            void BindGioiTinhToRdb(string gioiTinh)
            {
                if (gioiTinh == "Nam")
                {
                    rdbNam.Checked = true;
                    rdbNu.Checked = false;
                }
                else
                {
                    rdbNam.Checked = false;
                    rdbNu.Checked = true;
                }
            }
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreAllNhanVienTbxFull())
                {
                    string gioiTinh = GetGioiTinhFromRdb();
                    NhanVien nhanVien = new NhanVien()
                    {
                        ten_nv = txtTenNV.Text,
                        ma_nv = txtMaNV.Text,
                        ngay_sinh = dateNgaySinh.Value,
                        gioi_tinh = gioiTinh,
                        dia_chi_nv = txtDiaChiNV.Text,
                        ma_cv = cbxChucVu.SelectedValue.ToString(),
                        sdt_nv = txtSdtNV.Text
                    };
                    {
                        if (nhapMoi)
                        {
                            nhanVienBUS.ThemNhanVien(nhanVien);
                            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            nhanVienBUS.SuaNhanVien(nhanVien);
                            MessageBox.Show("Update dữ liệu thành công!", "Thông báo", MessageBoxButtons.OKCancel);
                        }
                        LoadNhanVien();
                    }
                }

                bool AreAllNhanVienTbxFull()
                {
                    if (txtMaNV.Text == "")
                    {
                        txtMaNV.Focus();
                        errorProvider1.SetError(txtMaNV, "Erorr!");
                    }
                    else if (txtTenNV.Text == "")
                    {
                        txtTenNV.Focus();
                        errorProvider1.SetError(txtTenNV, "Erorr!");
                    }
                    else if (txtSdtNV.Text == "")
                    {
                        txtSdtNV.Focus();
                        errorProvider1.SetError(txtSdtNV, "Erorr!");
                    }
                    else
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    List<DataGridViewRow> rows = new List<DataGridViewRow>();
                    foreach (DataGridViewCell cell in dgvNhanVien.SelectedCells)
                    {
                        DataGridViewRow row = cell.OwningRow;
                        if (!rows.Contains(row))
                        {
                            string maNV = row.Cells[0].Value.ToString();
                            nhanVienBUS.XoaNhanVien(maNV);
                            rows.Add(row);
                        }
                    }
                }
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtDiaChiNV.Clear();
            txtSdtNV.Clear();
            txtTenNV.Clear();
            txtMaNV.Focus();
            rdbNu.Checked = false;
            rdbNam.Checked = false;

            txtMaNV.Enabled = true;
            nhapMoi = true;
        }

        private void cbxTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTimkiem.SelectedIndex == 0)
            {
                label11.Text = "Nhập họ và tên nhân viên:";
            }
            if (cbxTimkiem.SelectedIndex == 1)
            {
                label11.Text = "Nhập chức vụ nhân viên:";
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchStr = txtTimkiem.Text;
                List<NhanVien> result = null;
                if (cbxTimkiem.SelectedIndex == 0)
                {
                    result = nhanVienBUS.SearchNhanVienByTenNV(searchStr);

                }
                else if (cbxTimkiem.SelectedIndex == 1)
                {
                    result = nhanVienBUS.SearchNhanVienByChucVu(searchStr);
                }
                BindDgvNhanVien(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DangKiTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.Show();
        }

        #endregion

        #region Sản phẩm

        private void BindDgvSanPham(List<SanPham> sanPhams)
        {
            dgvSanPham.DataSource = sanPhams;
            dgvSanPham.Columns["ChiTietHDs"].Visible = false;
            dgvSanPham.Columns["ChiTietPNs"].Visible = false;
            dgvSanPham.Columns["ma_loai"].Visible = false;
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreAllSanPhamTbxFull())
                {
                    SanPham sanPham = new SanPham()
                    {
                        ma_sp = txtMaSP.Text,
                        ten_sp = txtTenSP.Text,
                        so_luong = int.Parse(txtSoLuongHienCo.Text),
                        ma_loai = cbxLoaiSP.SelectedValue.ToString(),
                        thoi_gian_bh = int.Parse(txtThoiGianBaoHanh.Text),
                        gia_sp = decimal.Parse(txtGiaSP.Text),
                        don_vi_tinh = txtDonViTinh.Text,
                        hang_san_xuat = txtHangSanXuat.Text
                    };
                    if (nhapMoi)
                    {
                        sanPhamBUS.ThemSanPham(sanPham);
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        sanPhamBUS.SuaSanPham(sanPham);
                    }
                    LoadfrmSanPham();
                }

                bool AreAllSanPhamTbxFull()
                {
                    if (txtMaSP.Text == "")
                    {
                        txtMaSP.Focus();
                        errorProvider1.SetError(txtMaSP, "Error");
                    }
                    else if (txtTenSP.Text == "")
                    {
                        txtTenSP.Focus();
                        errorProvider1.SetError(txtTenSP, "Error");
                    }
                    else if (txtGiaSP.Text == "")
                    {
                        txtGiaSP.Focus();
                        errorProvider1.SetError(txtGiaSP, "Error");
                    }
                    else
                    {
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK);
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindSanPhamFromDgvToTbx();
            txtMaSP.Enabled = false;
            nhapMoi = false;
            void BindSanPhamFromDgvToTbx()
            {
                txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                cbxLoaiSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                txtDonViTinh.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtGiaSP.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtThoiGianBaoHanh.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                txtSoLuongHienCo.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
                txtHangSanXuat.Text = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
            }
        }


        private void btnNhapMoiSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaSP.Clear();
            txtHangSanXuat.Clear();
            cbxLoaiSP.SelectedIndex = 0;
            txtThoiGianBaoHanh.Clear();
            txtDonViTinh.Clear();
            txtSoLuongHienCo.Clear();

            txtMaSP.Focus();
            txtMaSP.Enabled = true;
            nhapMoi = true;
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    List<DataGridViewRow> rows = new List<DataGridViewRow>();
                    foreach (DataGridViewCell cell in dgvSanPham.SelectedCells)
                    {
                        DataGridViewRow row = cell.OwningRow;
                        if (!rows.Contains(row))
                        {
                            string maSP = row.Cells[0].Value.ToString();
                            sanPhamBUS.XoaSanPham(maSP);
                            rows.Add(row);
                        }
                    }
                    LoadfrmSanPham();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK);
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxTimTheoSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTimSP.SelectedIndex == 0)
                lblTimSP.Text = "Nhập mã sản phẩm:";
            if (cbxTimSP.SelectedIndex == 1)
                lblTimSP.Text = "Nhập loại sản phẩm:";
            if (cbxTimSP.SelectedIndex == 2)
                lblTimSP.Text = "Nhập tên sản phẩm:";
            if (cbxTimSP.SelectedIndex == 3)
                lblTimSP.Text = "Nhập hãng sản xuất:";
        }

        private void txtTimTheoSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchStr = txtTimSP.Text;
                List<SanPham> result = null;
                if (cbxTimSP.SelectedIndex == 0)
                {
                    result = sanPhamBUS.SearchByMaSP(searchStr);
                }
                else if (cbxTimSP.SelectedIndex == 1)
                {
                    result = sanPhamBUS.SearchByLoaiSP(searchStr);
                }
                else if (cbxTimSP.SelectedIndex == 2)
                {
                    result = sanPhamBUS.SearchByTenSP(searchStr);
                }
                else if (cbxTimSP.SelectedIndex == 3)
                {
                    result = sanPhamBUS.SearchByHang(searchStr);
                }
                BindDgvSanPham(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Loại sản phẩm

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    string maLoaiSP = cbxLoaiSP.SelectedValue.ToString();
                    loaiSanPhamBUS.XoaLoaiSanPham(maLoaiSP);
                    LoadfrmSanPham();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuuLoaisp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoaiSP.Text == null)
                {
                    txtMaLoaiSP.Focus();
                    errorProvider1.SetError(txtMaLoaiSP, "Error!");
                }
                else
                {
                    LoaiSP loaiSP = new LoaiSP()
                    {
                        ma_loai = txtMaLoaiSP.Text,
                        ten_loai_sp = txtTenLoaiSP.Text
                    };
                    loaiSanPhamBUS.ThemLoaiSanPham(loaiSP);
                    LoadfrmSanPham();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Khách hàng
        private void LoadfrmKhachHang()
        {
            cbxTimKH.SelectedIndex = 0;
            BindDgvKhachHang(khachHangBUS.GetKhachHangs());
        }

        private void BindDgvKhachHang(List<KhachHang> khachHangs)
        {
            dgvKhachHang.DataSource = khachHangs;
            if (khachHangs != null)
            {
                dgvKhachHang.Columns["HoaDons"].Visible = false;
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    khachHangBUS.XoaKhachHang(txtSdt.Text);
                    LoadfrmKhachHang();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang khachHang = new KhachHang()
                {
                    ten_kh = txtTenKH.Text,
                    sdt_kh = txtSdt.Text
                };
                khachHangBUS.SuaKhachHang(khachHang);
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK);
                LoadfrmKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSdt.Text = dgvKhachHang.CurrentRow.Cells["clmsdt"].Value.ToString();
                txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["clmTenKH"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxTimKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTimKH.SelectedIndex == 0)
            {
                lblTimKH.Text = "Nhập số điện thoại:";
            }
            if (cbxTimKH.SelectedIndex == 1)
            {
                lblTimKH.Text = "Nhập tên:";
            }
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            string searchStr = txtTimKH.Text;
            List<KhachHang> result = null;
            if (cbxTimKH.SelectedIndex == 0)
            {
                result = khachHangBUS.SearchKhachHangBySdt(searchStr);

            }
            else if (cbxTimKH.SelectedIndex == 1)
            {
                result = khachHangBUS.SearchKhachHangByTenKH(searchStr);
            }
            BindDgvKhachHang(result);
        }
        #endregion

        #region Phiếu nhập
        private void TimPN_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFromPN.Value;
            DateTime dateTo = dtpToPN.Value;
            dgvPhieuNhap.DataSource = phieuNhapBUS.TimPhieuNhap(dateFrom, dateTo);
            dgvPhieuNhap.Columns["ChiTietPNs"].Visible = false;
            dgvPhieuNhap.Columns["ma_nv"].Visible = false;
            dgvPhieuNhap.Columns["ma_ncc"].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int maPN = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["clmMaPN"].Value);
                dgvChitietPN.DataSource = phieuNhapBUS.GetChiTietPNs(maPN);
                dgvChitietPN.Columns["PhieuNhap"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        #region Hóa đơn
        private void btnTimHD_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFromHD.Value;
            DateTime dateTo = dtpToHD.Value;
            dgvHoaDon.DataSource = hoaDonBUS.TimHoaDon(dateFrom, dateTo);
            dgvHoaDon.Columns["ChiTietHDs"].Visible = false;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int maHD = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["clmMaHD"].Value);
                dgvChitietPN.DataSource = phieuNhapBUS.GetChiTietPNs(maHD);
                dgvChitietPN.Columns["HoaDon"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void btnXoaHD_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int maHD = Convert.ToInt32(dgvPhieuNhap.CurrentRow.Cells["clmMaHD"].Value);
        //        hoaDonBUS.XoaHoaDon(maHD);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        #endregion
        #region Thống kê
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateFrom = dtpDT1.Value;
                DateTime dateTo = dtpDT2.Value;
                List<PhieuNhap> phieuNhaps = phieuNhapBUS.TimPhieuNhap(dateFrom, dateTo);
                List<HoaDon> hoaDons = hoaDonBUS.TimHoaDon(dateFrom, dateTo);
                dgvNhap.DataSource = phieuNhaps;
                //dgvPhieuNhap.Columns["ChiTietPNs"].Visible = false;
                dgvXuat.DataSource = hoaDons;
                //dgvHoaDon.Columns["ChiTietHDs"].Visible = false;

                decimal thu = 0;
                decimal chi = 0;
                foreach (HoaDon hoaDon in hoaDons)
                {
                    thu += hoaDon.tong_gia_tri;
                }
                txtTongThu.Text = thu.ToString();
                foreach (PhieuNhap phieuNhap in phieuNhaps)
                {
                    chi += phieuNhap.tong_tien;
                }
                txtTongChi.Text = chi.ToString();
                decimal loiNhuan = thu - chi;
                txtLoiNhuan.Text = loiNhuan.ToString();
                decimal thue = loiNhuan / 10;
                txtThue.Text = thue.ToString();
                txtLoiNhuan2.Text = (loiNhuan - thue).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        private void LoadfrmNCC()
        {
            dgvNCC.DataSource = nhaCungCapBUS.GetNhaCungCaps();
        }

        private void btnNhapMoiNCC_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSdtNCC.Clear();
            txtMaNCC.Focus();
            txtMaNCC.Enabled = true;
            nhapMoi = true;
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    List<DataGridViewRow> rows = new List<DataGridViewRow>();
                    foreach (DataGridViewCell cell in dgvNhanVien.SelectedCells)
                    {
                        DataGridViewRow row = cell.OwningRow;
                        if (!rows.Contains(row))
                        {
                            string maNV = row.Cells[0].Value.ToString();
                            nhaCungCapBUS.XoaNhaCungCap(maNV);
                            rows.Add(row);
                        }
                    }
                }
                LoadfrmKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuuNCC_click(object sender, EventArgs e)
        {
            if (AreAllNCCTbxFull())
            {
                NhaCungCap nhaCungCap = new NhaCungCap()
                {
                    ten_ncc = txtTenNCC.Text,
                    ma_ncc = txtMaNCC.Text,
                    sdt_ncc = txtSdtNCC.Text
                };
                if (nhapMoi)
                {

                    nhaCungCapBUS.ThemNhaCungCap(nhaCungCap);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    nhaCungCapBUS.SuaNhaCungCap(nhaCungCap);
                    MessageBox.Show("Update dữ liệu thành công!", "Thông báo", MessageBoxButtons.OKCancel);
                }
                LoadfrmNCC();

            }

            bool AreAllNCCTbxFull()
            {
                if (txtMaNCC.Text == "")
                {
                    txtMaNCC.Focus();
                    errorProvider1.SetError(txtMaNCC, "Erorr!");
                }
                else if (txtTenNCC.Text == "")
                {
                    txtTenNCC.Focus();
                    errorProvider1.SetError(txtTenNCC, "Erorr!");
                }
                else if (txtSdtNCC.Text == "")
                {
                    txtSdtNCC.Focus();
                    errorProvider1.SetError(txtSdtNCC, "Erorr!");
                }
                else
                {
                    return true;
                }
                return false;
            }
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNCC.Text = dgvNCC.CurrentRow.Cells["Column12"].Value.ToString();
                txtTenNCC.Text = dgvNCC.CurrentRow.Cells["Column13"].Value.ToString();
                txtSdtNCC.Text = dgvNCC.CurrentRow.Cells["Column15"].Value.ToString();
                nhapMoi = false;
                txtMaNCC.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            cbxTimkiem.SelectedIndex = 0;
            cbxTimSP.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void Thoat()
        {
            frnMessage message = new frnMessage("", "Đăng xuất", "Thoát");
            message.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = message.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
            }
            if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
