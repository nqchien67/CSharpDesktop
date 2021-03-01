using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;

namespace QuanLiBanHang.BUS
{
    class KhachHangBUS
    {
        KhachHangDAL DAL = null;

        public KhachHangBUS()
        {
            DAL = new KhachHangDAL();
        }

        //Nếu source chứa toCheck return true
        private bool Contains(string source, string toCheck)
        {
            return source?.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public void ThemKhachHang(KhachHang khachHang)
        {
            KhachHang check = GetKhachHangs().Find(p => p.sdt_kh == khachHang.sdt_kh);
            if (check == null)
            {
                DAL.Insert(khachHang);
            }
            else
            {
                new Exception("đã tồn tại.");
            }
        }

        public List<KhachHang> GetKhachHangs()
        {
            return DAL.GetKhachHangs();
        }

        public List<KhachHang> SearchKhachHangByTenKH(string tenKH)
        {
            return GetKhachHangs().FindAll(p => Contains(p.ten_kh, tenKH));
        }

        public List<KhachHang> SearchKhachHangBySdt(string sdt)
        {
            return GetKhachHangs().FindAll(p => Contains(p.sdt_kh, sdt));
        }

        public void SuaKhachHang(KhachHang khachHang)
        {
            if (khachHang != null)
            {
                DAL.Update(khachHang);
            }
            else
            {
                throw new ArgumentNullException("Khách hàng null");
            }
        }

        public void XoaKhachHang(string sdtKH)
        {
            KhachHang khachHang = GetKhachHangs().Find(p => p.sdt_kh == sdtKH);
            if (khachHang == null)
            {
                throw new Exception("Khách hàng chọn để xóa không tồn tại.");
            }
            else
            {
                DAL.Delete(khachHang);
            }
        }
    }
}
