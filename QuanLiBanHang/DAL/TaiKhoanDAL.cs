using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;

namespace QuanLiBanHang.DAL
{
    class TaiKhoanDAL
    {
        QLBHEntities db = null;
        public TaiKhoanDAL()
        {
            db = new QLBHEntities();
        }

        public void Insert(TaiKhoan tk)
        {
            using (QLBHEntities db = new QLBHEntities())
            {
                try
                {
                    db.TaiKhoans.Add(tk);
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    throw ex;
                }
            }
        }

        public void Update(TaiKhoan taiKhoan)
        {
            taiKhoan.trang_thai = taiKhoan.trang_thai;
            db.SaveChanges();
        }

        public TaiKhoan GetTaiKhoan(string maNV)
        {
            return db.TaiKhoans.Where(p => p.ma_nv == maNV).SingleOrDefault(); 
        }
    }
}
