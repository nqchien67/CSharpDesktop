using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAL
{
    class KhachHangDAL
    {
        QLBHEntities db = null;

        public KhachHangDAL()
        {
            db = new QLBHEntities();
        }

        public List<KhachHang> GetKhachHangs()
        {
            return db.KhachHangs.ToList();
        }

        public void Insert(KhachHang khachHang)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
            }
        }

        public void Update(KhachHang khachHang)
        {
            KhachHang kh = db.KhachHangs.Find(khachHang.sdt_kh);
            kh.sdt_kh = khachHang.sdt_kh;
            kh.ten_kh = khachHang.ten_kh;
            db.SaveChanges();
        }

        public void Delete(KhachHang khachHang)
        {
            db.KhachHangs.Remove(khachHang);
            db.SaveChanges();
        }
    }
}
