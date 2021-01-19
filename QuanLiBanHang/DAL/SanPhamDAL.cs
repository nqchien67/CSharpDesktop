using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAL
{
    class SanPhamDAL
    {
        QLBHEntities db = null;

        public SanPhamDAL()
        {
            db = new QLBHEntities();
        }

        public SanPhamDAL(QLBHEntities context)
        {
            db = context;
        }

        public List<SanPham> GetSanPhams()
        {
            return db.SanPhams.ToList();
        }

        public void Insert(SanPham sanPham)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.SanPhams.Add(sanPham);
                db.SaveChanges();
            }
        }

        public void Update(SanPham sanPham)
        {
            SanPham sp = db.SanPhams.Find(sanPham.ma_sp);
            sp.ten_sp = sanPham.ten_sp;
            sp.so_luong = sanPham.so_luong;
            sp.hang_san_xuat = sanPham.hang_san_xuat;
            sp.don_vi_tinh = sanPham.don_vi_tinh;
            sp.gia_sp = sanPham.gia_sp;
            sp.thoi_gian_bh = sanPham.thoi_gian_bh;
            sp.ma_loai = sanPham.ma_loai;
            db.SaveChanges();
        }

        public void Delete(SanPham sanPham)
        {
            db.SanPhams.Remove(sanPham);
            db.SaveChanges();
        }
    }
}
