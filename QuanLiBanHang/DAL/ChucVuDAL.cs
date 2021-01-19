using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAL
{
    class ChucVuDAL
    {
        QLBHEntities db = null;
        public ChucVuDAL()
        {
            db = new QLBHEntities();
        }

        public List<ChucVu> GetChucVus()
        {
            return db.ChucVus.ToList();
        }
    }
}
