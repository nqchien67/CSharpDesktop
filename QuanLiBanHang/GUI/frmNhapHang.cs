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
    public partial class frmNhapHang : Form
    {
        static QLBHEntities context = new QLBHEntities();
        SanPhamBUS sanPhamBUS = new SanPhamBUS(context);
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS(context);
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        PhieuNhap phieuNhap = new PhieuNhap();
        NhanVien nhanVien;
        List<SanPham> sanPhams = new List<SanPham>();
        public string maNV;
        public float heSo;

        public frmNhapHang()
        {
            InitializeComponent();
            sanPhams = sanPhamBUS.GetSanPhams();
        }

        #region function
        private void BindDgvSanPham(List<SanPham> sanPhams)
        {
            dgvSanPham_PN.DataSource = sanPhams;
            dgvSanPham_PN.Columns["ChiTietHDs"].Visible = false;
            dgvSanPham_PN.Columns["ChiTietPNs"].Visible = false;
            dgvSanPham_PN.Columns["ma_loai"].Visible = false;
        }
        #endregion
        private void Thoat()
        {
            frnMessage message = new frnMessage("", "Đăng xuất", "Thoát");
            message.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = message.ShowDialog();
            //taiKhoanBUS.DangXuat(maNV);
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


        private void LoadfrmPhieuNhap()
        {
            txtNhanVien.Text = nhanVien.ten_nv;
            dtpNgayLap.Value = DateTime.Now;
            BindDgvSanPham(sanPhams);
            BindSanPhamFromDgvToTbx();
        }

        private void BindSanPhamFromDgvToTbx()
        {
            string maSP = dgvSanPham_PN.CurrentRow.Cells["ma_sp"].Value.ToString();
            if (txtMaSP_PN.Text != maSP)
            {
                txtMaSP_PN.Text = maSP;
                txtTenSP_PN.Text = dgvSanPham_PN.CurrentRow.Cells["ten_sp"].Value.ToString();
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            //try
            //{
            int soLuong = int.Parse(txtSoLuongNhapVao.Text);
            decimal giaNhap = decimal.Parse(txtGiaNhap.Text);
            string maSP = txtMaSP_PN.Text;
            if (checkBox1.Checked)
            {
                NhaCungCap nhaCungCap = new NhaCungCap()
                {
                    ma_ncc = txtMaNCC.Text,
                    ten_ncc = txtTenNCC.Text,
                    sdt_ncc = txtSDTNCC.Text,
                };
                nhaCungCapBUS.ThemNhaCungCap(nhaCungCap);
                phieuNhap.ma_ncc = txtMaNCC.Text;
            }
            else
            {
                string maNCC = cbxNhaCungCap.SelectedValue.ToString();
                if (maNCC != "")
                {
                    phieuNhap.ma_ncc = maNCC;
                }
            }
            ChiTietPN chiTietPN = new ChiTietPN()
            {
                ma_sp = maSP,
                so_luong = soLuong,
                gia_nhap = giaNhap,
                SanPham = sanPhamBUS.GetSanPhamsByMaSP(maSP)
            };
            chiTietPN.tong = soLuong * giaNhap;
            phieuNhap.tong_tien += chiTietPN.tong;
            phieuNhap.ChiTietPNs.Add(chiTietPN);
            txtTongThanhToan.Text = phieuNhap.tong_tien.ToString();
            BindDgvChiTietPN();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void BindDgvChiTietPN()
        {
            dgvChitietPN.DataSource = phieuNhap.ChiTietPNs.ToList();
            dgvChitietPN.Columns["PhieuNhap"].Visible = false;
            dgvChitietPN.Columns["id"].Visible = false;
            dgvChitietPN.Refresh();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            nhanVien = nhanVienBUS.GetNhanVienByMaNV(maNV);
            cbxNhaCungCap.DataSource = nhaCungCapBUS.GetNhaCungCaps();
            cbxNhaCungCap.DisplayMember = "ten_ncc";
            cbxNhaCungCap.ValueMember = "ma_ncc";
            LoadfrmPhieuNhap();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbxNhaCungCap.Enabled = false;
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                cbxNhaCungCap.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Thoat();
        }

        private void btn_xoaspn_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = dgvChitietPN.CurrentRow.Cells["clmMasp"].Value.ToString();
                ChiTietPN chiTietPN = phieuNhap.ChiTietPNs.Where(p => p.ma_sp == maSP).FirstOrDefault();
                phieuNhap.ChiTietPNs.Remove(chiTietPN);
                phieuNhap.tong_tien -= chiTietPN.tong;
                txtTongThanhToan.Text = phieuNhap.tong_tien.ToString();
                LoadfrmPhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phieuNhap.ma_nv = maNV;
            phieuNhap.ngay_lap_pn = dtpNgayLap.Value;
            phieuNhapBUS.ThemPhieuNhap(phieuNhap);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DocumentName = txtMaSP_PN.Text + dtpNgayLap.Text;
            printPreviewDialog1.ShowDialog();
            phieuNhap = new PhieuNhap();
            BindDgvChiTietPN();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                string nhaCungCap;
                if (checkBox1.Checked)
                {
                    nhaCungCap = txtTenNCC.Text;
                }
                else
                {
                    nhaCungCap = cbxNhaCungCap.SelectedText;
                }
                int y = 10;
                e.Graphics.DrawString("PHIẾU ĐẶT HÀNG", new Font("Times New Roman", 20), Brushes.Black, new Point(250, y));
                e.Graphics.DrawString("Mã phiếu:" + phieuNhap.ma_phieu_nhap, new Font("Times New Roman", 13), Brushes.Black, new Point(30, y += 20));
                e.Graphics.DrawString("Tên nhân viên:" + txtNhanVien.Text, new Font("Times New Roman", 13), Brushes.Black, new Point(30, y += 20));
                e.Graphics.DrawString("Tên nhà cung cấp:" + nhaCungCap, new Font("Times New Roman", 13), Brushes.Black, new Point(30, y += 20));
                e.Graphics.DrawString("Ngày lập: " + dtpNgayLap.Value.ToShortTimeString() + " - " + DateTime.Now.ToShortDateString(), new Font("Times New Roman", 15), Brushes.Black, new Point(30, y += 30));
                e.Graphics.DrawString("Mã sản phẩm", new Font("Times New Roman", 15), Brushes.Red, new Point(30, y += 50));
                e.Graphics.DrawString("| Tên sản phẩm", new Font("Times New Roman", 15), Brushes.Red, new Point(150, y));
                e.Graphics.DrawString("| Số lượng", new Font("Times New Roman", 15), Brushes.Red, new Point(400, y));
                e.Graphics.DrawString("| Giá", new Font("Times New Roman", 15), Brushes.Red, new Point(500, y));
                e.Graphics.DrawString("| Thành tiền", new Font("Times New Roman", 15), Brushes.Red, new Point(670, y));
                foreach (DataGridViewRow row in dgvChitietPN.Rows)
                {
                    e.Graphics.DrawString(row.Cells["MaPN"].Value.ToString() + " | ", new Font("Times New Roman", 13), Brushes.Black, new Point(30, y += 30));
                    e.Graphics.DrawString(row.Cells["TSP"].Value.ToString() + " | ", new Font("Times New Roman", 13), Brushes.Black, new Point(150, y));
                    e.Graphics.DrawString(row.Cells["SoLuong"].Value.ToString() + " | ", new Font("Times New Roman", 13), Brushes.Black, new Point(400, y));
                    e.Graphics.DrawString(row.Cells["GiaNhap"].Value.ToString() + " | ", new Font("Times New Roman", 13), Brushes.Black, new Point(500, y));
                    e.Graphics.DrawString(row.Cells["Tong"].Value.ToString(), new Font("Times New Roman", 13), Brushes.Black, new Point(670, y));
                }
                e.Graphics.DrawString("Tổng: " + txtTongThanhToan.Text, new Font("Times New Roman", 13), Brushes.Black, new Point(670, y += 20));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thoat();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbxTimKiem_PN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTimKiem_PN.SelectedIndex == 0)
                lblTimKiem.Text = "Nhập mã sản phẩm:";
            if (cbxTimKiem_PN.SelectedIndex == 1)
                lblTimKiem.Text = "Nhập loại sản phẩm:";
            if (cbxTimKiem_PN.SelectedIndex == 2)
                lblTimKiem.Text = "Nhập tên sản phẩm:";
            if (cbxTimKiem_PN.SelectedIndex == 3)
                lblTimKiem.Text = "Nhập hãng sản xuất:";
        }

        private void txtTimKiem_PN_TextChanged(object sender, EventArgs e)
        {
            string searchStr = txtTimKiem_PN.Text;
            List<SanPham> result = null;
            if (cbxTimKiem_PN.SelectedIndex == 0)
            {
                result = sanPhamBUS.SearchByMaSP(searchStr);
            }
            else if (cbxTimKiem_PN.SelectedIndex == 1)
            {
                result = sanPhamBUS.SearchByLoaiSP(searchStr);
            }
            else if (cbxTimKiem_PN.SelectedIndex == 2)
            {
                result = sanPhamBUS.SearchByTenSP(searchStr);
            }
            else if (cbxTimKiem_PN.SelectedIndex == 3)
            {
                result = sanPhamBUS.SearchByHang(searchStr);
            }
            BindDgvSanPham(result);
        }

        private void dgvSanPham_PN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindSanPhamFromDgvToTbx();
            txtGiaNhap.Clear();
            txtSoLuongNhapVao.Clear();
        }

        private void txtSoLuongNhapVao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
