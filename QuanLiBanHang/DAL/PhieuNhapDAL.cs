using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAL
{
    class PhieuNhapDAL
    {
        QLBHEntities db = null;

        public PhieuNhapDAL()
        {
            db = new QLBHEntities();
        }

        public PhieuNhapDAL(QLBHEntities context)
        {
            db = context;
        }

        public List<PhieuNhap> GetPhieuNhaps()
        {
            return db.PhieuNhaps.ToList();
        }

        public void Insert(PhieuNhap phieuNhap)
        {
            //using (QLBHEntities db = new QLBHEntities())
            {
                db.PhieuNhaps.Add(phieuNhap);
                db.SaveChanges();
            }
        }

        public void Delete(PhieuNhap phieuNhap)
        {
            foreach(ChiTietPN chiTietPN in phieuNhap.ChiTietPNs)
            {
                db.ChiTietPNs.Remove(chiTietPN);
            }    
            db.PhieuNhaps.Remove(phieuNhap);
            db.SaveChanges();
        }
    }
}
