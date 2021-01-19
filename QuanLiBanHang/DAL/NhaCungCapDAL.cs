using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAL
{
    class NhaCungCapDAL
    {
        QLBHEntities db = null;

        public NhaCungCapDAL()
        {
            db = new QLBHEntities();
        }

        public List<NhaCungCap> GetNhaCungCaps()
        {
            return db.NhaCungCaps.ToList();
        }

        public void Insert(NhaCungCap nhaCungCap)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.NhaCungCaps.Add(nhaCungCap);
                db.SaveChanges();
            }
        }

        public void Update(NhaCungCap nhaCungCap)
        {
            NhaCungCap ncc = db.NhaCungCaps.Find(nhaCungCap.ma_ncc);
            ncc.ten_ncc = nhaCungCap.ten_ncc;
            ncc.sdt_ncc = nhaCungCap.sdt_ncc;
            db.SaveChanges();
        }

        public void Delete(NhaCungCap nhaCungCap)
        {
            db.NhaCungCaps.Remove(nhaCungCap);
            db.SaveChanges();
        }
    }
}
