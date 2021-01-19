using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;

namespace QuanLiBanHang.BUS
{
    class PhieuNhapBUS
    {
        PhieuNhapDAL DAL = null;

        public PhieuNhapBUS()
        {
            DAL = new PhieuNhapDAL();
        }

        public PhieuNhapBUS(QLBHEntities context)
        {
            DAL = new PhieuNhapDAL(context);
        }

        public void ThemPhieuNhap(PhieuNhap phieuNhap)
        {
            DAL.Insert(phieuNhap);
        }

        public List<PhieuNhap> GetPhieuNhaps()
        {
            return DAL.GetPhieuNhaps();
        }

        public List<ChiTietPN> GetChiTietPNs(int maPN)
        {
            return GetPhieuNhaps().Find(p => p.ma_phieu_nhap == maPN).ChiTietPNs.ToList();
        }

        public List<PhieuNhap> TimPhieuNhap(DateTime dateFrom, DateTime dateTo)
        {
            return GetPhieuNhaps().FindAll(p => p.ngay_lap_pn >= dateFrom.Date && p.ngay_lap_pn < dateTo.Date.AddDays(1));
        }

        public void XoaPhieuNhap(int maPN)
        {
            DAL.Delete(GetPhieuNhaps().Find(p => p.ma_phieu_nhap == maPN));
        }
    }
}
