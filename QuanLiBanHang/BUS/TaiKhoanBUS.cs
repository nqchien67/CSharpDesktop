using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;
using System.Data.Entity.Infrastructure;

namespace QuanLiBanHang.BUS
{
    class TaiKhoanBUS
    {
        TaiKhoanDAL taiKhoanDAL = null;
        NhanVienBUS nhanVienBUS = null;

        public TaiKhoanBUS()
        {
            taiKhoanDAL = new TaiKhoanDAL();
            nhanVienBUS = new NhanVienBUS();
        }

        public void DangKy(TaiKhoan tk)
        {
            try
            {
                taiKhoanDAL.Insert(tk);
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }

        public string DangNhap(string maNV, string pass)
        {
            try
            {
                TaiKhoan taiKhoan = taiKhoanDAL.GetTaiKhoan(maNV);
                if (taiKhoan == null || taiKhoan.password != pass)
                {
                    throw new Exception("Tên tài khoản hoặc mật khẩu không chính xác.");
                }
                else if (taiKhoan.trang_thai == true)
                {
                    taiKhoanDAL = new TaiKhoanDAL();
                    throw new Exception("Tài khoản đã có người đăng nhập.");
                }
                else
                {
                    taiKhoan.trang_thai = true;
                    taiKhoanDAL.Update(taiKhoan);
                    NhanVien nhanVien = nhanVienBUS.GetNhanVienByMaNV(taiKhoan.ma_nv);
                    return nhanVien.ma_cv;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DangXuat(string maNV)
        {
            TaiKhoan taiKhoan = taiKhoanDAL.GetTaiKhoan(maNV);
            taiKhoan.trang_thai = false;
            taiKhoanDAL.Update(taiKhoan);
        }
    }
}
