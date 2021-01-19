using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace QuanLiBanHang.DAL
{
    class NhanVienDAL
    {
        QLBHEntities db = null;

        public NhanVienDAL()
        {
            db = new QLBHEntities();
        }

        public void Insert(NhanVien nhanVien)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
            }
        }

        public List<NhanVien> GetNhanViens()
        {
           // return db.NhanViens.Select(p => p).ToList();
            return db.NhanViens.ToList();
        }

        //public NhanVien GetNhanVienByMaNV(string maNV)
        //{
        //    return db.NhanViens.Where(p => p.ma_nv == maNV).SingleOrDefault();
        //}

        public void Update(NhanVien nhanVien)
        {
            NhanVien nv = db.NhanViens.Find(nhanVien.ma_nv);
            nv.ten_nv = nhanVien.ten_nv;
            nv.ngay_sinh = nhanVien.ngay_sinh;
            nv.sdt_nv = nhanVien.sdt_nv;
            nv.dia_chi_nv = nhanVien.dia_chi_nv;
            nv.gioi_tinh = nhanVien.gioi_tinh;
            nv.ma_cv = nhanVien.ma_cv;
            db.SaveChanges();
        }

        public void Delete(NhanVien nhanVien)
        {
            db.NhanViens.Remove(nhanVien);
            db.SaveChanges();
        }
    }
}
