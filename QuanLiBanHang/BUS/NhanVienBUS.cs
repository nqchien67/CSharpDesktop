using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;

namespace QuanLiBanHang.BUS
{
    class NhanVienBUS
    {
        NhanVienDAL DAL = null;

        public NhanVienBUS()
        {
            DAL = new NhanVienDAL();
        }

        //Nếu source chứa toCheck return true
        private bool Contains(string source, string toCheck)
        {
            return source?.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {

            NhanVien check = GetNhanViens().Find(p => p.ma_nv == nhanVien.ma_nv);
            if (check == null)
            {
                DAL.Insert(nhanVien);
            }
            else
            {
                throw new Exception("Mã nhân viên đã tồn tại.");
            }
        }

        public List<NhanVien> GetNhanViens()
        {
            return DAL.GetNhanViens();
        }

        public NhanVien GetNhanVienByMaNV(string maNV)
        {
            return GetNhanViens().Find(p => p.ma_nv == maNV);
        }

        public List<NhanVien> SearchNhanVienByTenNV(string tenNV)
        {
            return GetNhanViens().FindAll(p => Contains(p.ten_nv, tenNV));
        }

        public List<NhanVien> SearchNhanVienByChucVu(string chucVu)
        {
            return GetNhanViens().FindAll(p => Contains(p.ChucVu.ToString(),chucVu));
        }

        public void SuaNhanVien(NhanVien nhanVien)
        {
            if (nhanVien != null)
            {
                DAL.Update(nhanVien);
            }
            else
            {
                throw new ArgumentNullException("Nhân viên null");
            }
        }

        public void XoaNhanVien(string maNV)
        {
            NhanVien nhanVien = GetNhanVienByMaNV(maNV);
            if (nhanVien == null)
            {
                throw new Exception("Nhân viên chọn để xóa không tồn tại.");
            }
            else
            {
                DAL.Delete(nhanVien);
            }
        }
    }
}
