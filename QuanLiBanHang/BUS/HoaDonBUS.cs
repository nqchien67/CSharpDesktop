using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;

namespace QuanLiBanHang.BUS
{
    class HoaDonBUS
    {
        HoaDonDAL DAL = null;

        public HoaDonBUS()
        {
            DAL = new HoaDonDAL();
        }

        public HoaDonBUS(QLBHEntities context)
        {
            DAL = new HoaDonDAL(context);
        }

        public void ThemHoaDon(HoaDon hoaDon)
        {
            DAL.Insert(hoaDon);
        }

        public List<HoaDon> GetHoaDons()
        {
            return DAL.GetHoaDons();
        }

        public List<ChiTietHD> GetChiTietHDs(int maHD)
        {
            return GetHoaDons().Find(p => p.ma_hd == maHD).ChiTietHDs.ToList();
        }

        public List<HoaDon> TimHoaDon(DateTime dateFrom, DateTime dateTo)
        {
            return GetHoaDons().FindAll(p => p.ngay_lap >= dateFrom.Date && p.ngay_lap < dateTo.Date.AddDays(1));
        }

        public void XoaHoaDon(int maHD)
        {
            DAL.Delete(GetHoaDons().Find(p => p.ma_hd == maHD));
        }
    }
}
