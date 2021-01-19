using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;

namespace QuanLiBanHang.BUS
{
    class LoaiSanPhamBUS
    {
        LoaiSanPhamDAL DAL = null;

        public LoaiSanPhamBUS()
        {
            DAL = new LoaiSanPhamDAL();
        }

        public List<LoaiSP> GetLoaiSPhams()
        {
            return DAL.GetLoaiSPhams();
        }

        public void ThemLoaiSanPham(LoaiSP loaiSP)
        {
            DAL.Insert(loaiSP);
        }
    
        public void XoaLoaiSanPham(string maLoaiSP)
        {
            LoaiSP loaiSP = GetLoaiSPhams().Find(p => p.ma_loai == maLoaiSP);
            DAL.Delete(loaiSP);
        }
    
        public void SuaLoaiSanPham(LoaiSP loaiSP)
        {
            if (loaiSP != null)
            {
                DAL.Update(loaiSP);
            }
            else
            {
                throw new ArgumentNullException("Sản phẩm null");
            }
        }
    }
}
