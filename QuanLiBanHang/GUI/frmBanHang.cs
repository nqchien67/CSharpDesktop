using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiBanHang.BUS;

namespace QuanLiBanHang.GUI
{
    public partial class frmBanHang : Form
    {
        static QLBHEntities context = new QLBHEntities();
        SanPhamBUS sanPhamBUS = new SanPhamBUS(context);
        HoaDonBUS hoaDonBUS = new HoaDonBUS(context);
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        NhanVien nhanVien;
        HoaDon hoaDon = new HoaDon()
        {
            tong_gia_tri = 0,
        };
        List<SanPham> sanPhams;

        public string maNV;

        public frmBanHang()
        {
            InitializeComponent();
            sanPhams = sanPhamBUS.GetSanPhams();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            nhanVien = nhanVienBUS.GetNhanVienByMaNV(maNV);
            LoadfrmHoaDon();
            LoadfrmKhachHang();
            BindSanPhamFromDgvToTbx();
        }

        #region Khach hang
        private void LoadfrmKhachHang()
        {
            cbxTimKhachHang.SelectedIndex = 0;
            BindDgvKhachHang(khachHangBUS.GetKhachHangs());
        }

        private void BindDgvKhachHang(List<KhachHang> khachHangs)
        {
            dgvKhachHang.DataSource = khachHangs;
            dgvKhachHang.Columns[2].Visible = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTimKhachHang.SelectedIndex == 0)
                lblKhachHang.Text = "Nhập tên khách hàng:";
            if (cbxTimKhachHang.SelectedIndex == 1)
                lblKhachHang.Text = "Số điện thoại:";
        }

        private void txtTimKhachHang_TextChanged(object sender, EventArgs e)
        {
            string searchStr = txtTimKhachHang.Text;
            List<KhachHang> result = null;
            if (cbxTimKhachHang.SelectedIndex == 0)
            {
                result = khachHangBUS.SearchKhachHangByTenKH(searchStr);

            }
            else if (cbxTimKhachHang.SelectedIndex == 1)
            {
                result = khachHangBUS.SearchKhachHangByTenKH(searchStr);
            }
            BindDgvKhachHang(result);
        }

        #endregion

        #region Hóa đơn
        public void LoadfrmHoaDon()
        {
            dtpNgayLap.Value = DateTime.Now;
            BindDgvSanPham(sanPhams);
            cbxTimSP.SelectedIndex = 0;
            txtNhanVien.Text = nhanVien.ten_nv;
        }

        private void BindSanPhamFromDgvToTbx()
        {
            string maSP = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            if (txtMaSP.Text != maSP)
            {
                txtMaSP.Text = maSP;
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                lblDonViTinh.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtDonGia.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtHangSanXuat.Text = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
                int conLai = Convert.ToInt32(dgvSanPham.CurrentRow.Cells[6].Value);
                SetTextBox(conLai);
            }
        }

        private void BindDgvSanPham(List<SanPham> sanPhams)
        { 
            dgvSanPham.DataSource = sanPhams;
            dgvSanPham.Columns["ChiTietHDs"].Visible = false;
            dgvSanPham.Columns["ChiTietPNs"].Visible = false;
            dgvSanPham.Columns["ma_loai"].Visible = false;
            dgvSanPham.Refresh();
        }

        private void BindDgvChiTietHD()
        { 
            dgvChiTietHoaDon.DataSource = hoaDon.ChiTietHDs.ToList();
            //foreach(DataGridViewRow row in dgvChiTietHoaDon.Rows)
            //{
            //    row.Cells["clmTenSanPham"].Value = sanPhamBUS.GetSanPhamsByMaSP(row.Cells["clmMaSanPham"].Value.ToString()).ten_sp;
            //}
            dgvChiTietHoaDon.Columns["HoaDon"].Visible = false;
            dgvChiTietHoaDon.Columns["id"].Visible = false;
            dgvChiTietHoaDon.Refresh();
        }

        private void SetTextBox(int conLai)
        {
            txtThanhTien.Text = txtDonGia.Text;
            txtConLai.Text = conLai.ToString();
            if (conLai > 0)
            {
                numSoLuong.Minimum = 1;
            }
            else
            {
                numSoLuong.Minimum = 0;
            }
            numSoLuong.Maximum = conLai;
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (numSoLuong.Value != 0)
            {
                decimal thanhTien = decimal.Parse(txtDonGia.Text) * numSoLuong.Value;
                txtThanhTien.Text = thanhTien.ToString();
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindSanPhamFromDgvToTbx();
        }

        private void btnThemChiTietHD_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuong = Convert.ToInt32(numSoLuong.Value);
                int conLai = int.Parse(txtConLai.Text);
                string maSP = txtMaSP.Text;
                if (soLuong > 0)
                {
                    ChiTietHD check = hoaDon.ChiTietHDs.Where(p => p.ma_sp == maSP).SingleOrDefault();
                    if (check != null)
                    {
                        check.so_luong += soLuong;
                        check.thanh_tien += int.Parse(txtThanhTien.Text);
                    }
                    else
                    {
                        check = new ChiTietHD()
                        {
                            ma_hd = hoaDon.ma_hd,
                            ma_sp = maSP,
                            gia_sp = int.Parse(txtDonGia.Text),
                            SanPham = sanPhamBUS.GetSanPhamsByMaSP(maSP),
                            so_luong = soLuong,
                            thanh_tien = decimal.Parse(txtThanhTien.Text)
                        };
                        hoaDon.ChiTietHDs.Add(check);
                    }
                    conLai -= soLuong;
                    hoaDon.tong_gia_tri += check.thanh_tien;
                    txtTongThanhToan.Text = hoaDon.tong_gia_tri.ToString();
                    SetTextBox(conLai);
                    sanPhams.Find(p => p.ma_sp == maSP).so_luong = conLai;
                    BindDgvChiTietHD();
                    dgvSanPham.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = dgvChiTietHoaDon.CurrentRow.Cells["clmMaSanPham"].Value.ToString();
                ChiTietHD chiTietHD = hoaDon.ChiTietHDs.Where(p => p.ma_sp == maSP).FirstOrDefault();
                hoaDon.ChiTietHDs.Remove(chiTietHD);
                hoaDon.tong_gia_tri -= chiTietHD.thanh_tien;
                txtTongThanhToan.Text = hoaDon.tong_gia_tri.ToString();
                sanPhams.Find(p => p.ma_sp == maSP).so_luong += Convert.ToInt32(dgvChiTietHoaDon.CurrentRow.Cells["clmSoLuongCTHD"].Value);
                LoadfrmHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_HD_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtTimSP_TextChanged(object sender, EventArgs e)
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

        private void btnIn_HD_Click(object sender, EventArgs e)
        {
            string sdtKH = txtSdtKH_HD.Text;
            if (sdtKH == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hoaDon.ngay_lap = dtpNgayLap.Value;
                hoaDon.sdt_kh = sdtKH;
                hoaDon.ma_nv = nhanVien.ma_nv;
                KhachHang khachHang = new KhachHang()
                {
                    sdt_kh = txtSdtKH_HD.Text,
                    ten_kh = txtTenKhachHang.Text
                };
                khachHangBUS.ThemKhachHang(khachHang);
                hoaDonBUS.ThemHoaDon(hoaDon);
                printPreviewDialog1.Document = printDocument2;
                printDocument2.DocumentName = hoaDon.ma_hd + dtpNgayLap.Text;
                printPreviewDialog1.ShowDialog();
                hoaDon = new HoaDon();
                BindDgvChiTietHD();
            }
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
            taiKhoanBUS.DangXuat(maNV);
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

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int y = 10;
                e.Graphics.DrawString("HÓA ĐƠN - " + hoaDon.ma_hd, new Font("Times New Roman", 22), Brushes.Black, new Point(270, y));
                e.Graphics.DrawString("Tên nhân viên: " + txtNhanVien.Text, new Font("Times New Roman", 15), Brushes.Black, new Point(30, y += 50));
                e.Graphics.DrawString("Tên khách hàng:" + txtTenKhachHang_HD.Text, new Font("Times New Roman", 15), Brushes.Black, new Point(30, y += 30));
                e.Graphics.DrawString("Ngày lập: " + dtpNgayLap.Value.ToShortTimeString() + " - " + DateTime.Now.ToShortDateString(), new Font("Times New Roman", 15), Brushes.Black, new Point(30, y += 30));
                e.Graphics.DrawString("Mã sản phẩm", new Font("Times New Roman", 15), Brushes.Red, new Point(30, y += 50));
                e.Graphics.DrawString("| Tên sản phẩm", new Font("Times New Roman", 15), Brushes.Red, new Point(150, y));
                e.Graphics.DrawString("| Số lượng", new Font("Times New Roman", 15), Brushes.Red, new Point(400, y));
                e.Graphics.DrawString("| Giá", new Font("Times New Roman", 15), Brushes.Red, new Point(500, y));
                e.Graphics.DrawString("| Thành tiền", new Font("Times New Roman", 15), Brushes.Red, new Point(670, y));
                foreach (DataGridViewRow row in dgvChiTietHoaDon.Rows)
                {
                    e.Graphics.DrawString("| " + row.Cells["clmMaSanPham"].Value.ToString(), new Font("Times New Roman", 13), Brushes.Black, new Point(30, y += 30));
                    e.Graphics.DrawString("| " + row.Cells["clmTenSanPham"].Value.ToString(), new Font("Times New Roman", 13), Brushes.Black, new Point(150, y));
                    e.Graphics.DrawString("| " + row.Cells["clmGiaSP"].Value.ToString(), new Font("Times New Roman", 13), Brushes.Black, new Point(400, y));
                    e.Graphics.DrawString("| " + row.Cells["clmSoLuongCTHD"].Value.ToString(), new Font("Times New Roman", 13), Brushes.Black, new Point(500, y));
                    e.Graphics.DrawString("| " + row.Cells["clmThanhTien"].Value.ToString(), new Font("Times New Roman", 13), Brushes.Black, new Point(670, y));
                }
                e.Graphics.DrawString("Tổng: " + txtTongThanhToan.Text, new Font("Times New Roman", 13), Brushes.Black, new Point(670, y += 50));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSdtKH_HD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thoat();
        }
    }
}
#endregion