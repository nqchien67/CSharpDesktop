using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;
namespace QuanLiBanHang.BUS
{
    class ChucVuBUS
    {
        ChucVuDAL DAL = null;
        public ChucVuBUS()
        {
            DAL = new ChucVuDAL();
        }

        public List<ChucVu> GetChucVus()
        {
            return DAL.GetChucVus();
        }
    }
}
