using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAL
{
    class LoaiSanPhamDAL
    {
        QLBHEntities db = null;

        public LoaiSanPhamDAL()
        {
            db = new QLBHEntities();
        }

        public List<LoaiSP> GetLoaiSPhams()
        {
            return db.LoaiSPs.ToList();
        }

        public void Insert(LoaiSP loaiSP)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.LoaiSPs.Add(loaiSP);
                db.SaveChanges();
            }
        }

        public void Delete(LoaiSP loaiSP)
        {
            db.LoaiSPs.Remove(loaiSP);
            db.SaveChanges();
        }

        public void Update(LoaiSP loaiSP)
        {
            LoaiSP lsp = db.LoaiSPs.Find(loaiSP.ma_loai);
            lsp.ma_loai = loaiSP.ma_loai;
            lsp.ten_loai_sp = loaiSP.ten_loai_sp;
            db.SaveChanges();
        }
    }
}
