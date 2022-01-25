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
                    throw new Exception("Mã sinh viên hoặc mật khẩu không chính xác.");
                }
                else
                {
                    NhanVien nhanVien = nhanVienBUS.GetNhanVienByMaNV(taiKhoan.ma_nv);
                    return nhanVien.ma_cv;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
