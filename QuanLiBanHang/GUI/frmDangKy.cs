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
using System.Data.Entity.Infrastructure;

namespace QuanLiBanHang.GUI
{
    public partial class frmDangKy : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();        

        public frmDangKy()
        {
            InitializeComponent();
        }

        private Boolean KiemTraDangKy()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa điền Username!", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Bạn chưa điền Password!", "Thông báo", MessageBoxButtons.OK);
                txtpass.Focus();
            }
            else if (txtpass.Text != txtconfirm.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu chưa chính xác!", "Thông báo", MessageBoxButtons.OK);
                txtpass.Focus();
            }
            else
            {
                return true;
            }
            return false;
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraDangKy())
                {
                    TaiKhoan tk = new TaiKhoan()
                    {
                        ma_nv = txtMaNV.Text,
                        password = txtpass.Text
                    };
                    taiKhoanBUS.DangKy(tk);
                    MessageBox.Show("Đăng ký thành công !", "Thông báo", MessageBoxButtons.OK);
                    txtMaNV.Text = "";
                    txtpass.Text = "";
                    txtconfirm.Text = "";
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Focus();
            }
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void frmDangky_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBUS.GetNhanViens();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Chắc chắn bạn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtpass.Clear();
            txtconfirm.Clear();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien> result = nhanVienBUS.SearchNhanVienByTenNV(txtTimKiem.Text);
            dgvNhanVien.DataSource = result;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["clmMaNV"].Value.ToString();
        }
    }
}
