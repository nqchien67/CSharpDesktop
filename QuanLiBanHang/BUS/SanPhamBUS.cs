using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;

namespace QuanLiBanHang.BUS
{
    class SanPhamBUS
    {
        SanPhamDAL DAL = null;

        public SanPhamBUS()
        {
            DAL = new SanPhamDAL();
        }

        public SanPhamBUS(QLBHEntities context)
        {
            DAL = new SanPhamDAL(context);
        }

        private bool Contains(string source, string toCheck)
        {
            return source?.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public List<SanPham> GetSanPhams()
        {
            return DAL.GetSanPhams();
        }

        public SanPham GetSanPhamsByMaSP(string maSP)
        {
            return GetSanPhams().Find(p => p.ma_sp == maSP);
        }

        public List<SanPham> SearchByMaSP(string maSP)
        {
            return GetSanPhams().FindAll(p => Contains(p.ma_sp, maSP));
        }

        public List<SanPham> SearchByTenSP(string tenSP)
        {
            return GetSanPhams().FindAll(p => Contains(p.ten_sp, tenSP));
        }

        public List<SanPham> SearchByLoaiSP(string loaiSP)
        {
            return GetSanPhams().FindAll(p => Contains(p.LoaiSP.ToString(), loaiSP));
        }

        public List<SanPham> SearchByHang(string hang)
        {
            return GetSanPhams().FindAll(p => Contains(p.hang_san_xuat, hang));
        }

        public void ThemSanPham(SanPham sanPham)
        {
            SanPham check = GetSanPhams().Find(p => p.ma_sp == sanPham.ma_sp);
            if (check == null)
            {
                DAL.Insert(sanPham);
            }
            else
            {
                throw new Exception("Mã sản phẩm đã tồn tại.");
            }
        }

        public void SuaSanPham(SanPham sanPham)
        {
            if (sanPham != null)
            {
                DAL.Update(sanPham);
            }
            else
            {
                throw new ArgumentNullException("Sản phẩm null");
            }
        }

        public void XoaSanPham(string maSP)
        {
            SanPham sanPham = GetSanPhamsByMaSP(maSP);
            if (sanPham == null)
            {
                throw new Exception("Sản phẩm chọn để xóa không tồn tại.");
            }
            else
            {
                DAL.Delete(sanPham);
            }
        }
    }
}
