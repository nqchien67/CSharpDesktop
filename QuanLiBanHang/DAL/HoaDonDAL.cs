using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAL
{
    class HoaDonDAL
    {
        QLBHEntities db = null;

        public HoaDonDAL()
        {
            db = new QLBHEntities();
        }

        public HoaDonDAL(QLBHEntities context)
        {
            db = context;
        }

        public List<HoaDon> GetHoaDons()
        {
            return db.HoaDons.ToList();
        }

        public void Insert(HoaDon hoaDon)
        {
            //using (QLBHEntities db = new QLBHEntities())
            {
                db.HoaDons.Add(hoaDon);
                db.SaveChanges();
            }
        }

        public void Delete(HoaDon hoaDon)
        {
            db.HoaDons.Remove(hoaDon);
            db.SaveChanges();
        }

        public int GetMaHD()
        {
            List<HoaDon> ls = GetHoaDons();
            int maHD = ls[0].ma_hd;
            foreach(var n in ls)
            {
                if (n.ma_hd > maHD)
                    maHD = n.ma_hd;
            }
            return maHD;
        }
    }
}
