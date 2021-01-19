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
    public partial class frmDangNhap : Form
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtusername.Text;
                string pass = txtpassword.Text;
                string chucVu = taiKhoanBUS.DangNhap(maNV, pass);
                HienThiFormTheoChucVu(chucVu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            void HienThiFormTheoChucVu(string chucVu)
            {
                switch (chucVu)
                {
                    case "BH":
                        this.Hide();
                        frmBanHang bh = new frmBanHang();
                        bh.maNV = txtusername.Text;
                        bh.Show();
                        break;
                    case "NH":
                        this.Hide();
                        frmNhapHang nh = new frmNhapHang();
                        nh.maNV = txtusername.Text;
                        nh.Show();
                        break;
                    case "QL":
                        this.Hide();
                        frmQuanLy ql = new frmQuanLy();
                        ql.maNV = txtusername.Text;
                        ql.Show();
                        break;
                    default:
                        MessageBox.Show(chucVu);
                        break;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Chắc chắn bạn muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDangnhap_click(sender, e);
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDangnhap_click(sender, e);
            }
        }
    }
}
