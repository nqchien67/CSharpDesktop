using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanHang.DAL;

namespace QuanLiBanHang.BUS
{
    class NhaCungCapBUS
    {
        NhaCungCapDAL nhaCungCapDAL = null;
        public NhaCungCapBUS()
        {
            nhaCungCapDAL = new NhaCungCapDAL();
        }

        public void ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            NhaCungCap check = GetNhaCungCaps().Find(p => p.ma_ncc == nhaCungCap.ma_ncc);
            if (check == null)
            {
                nhaCungCapDAL.Insert(nhaCungCap);
            }
            else
            {
                throw new Exception("Mã nhà cung cấp đã tồn tại.");
            }
        }

        public void XoaNhaCungCap(string maNCC)
        {
            NhaCungCap nhaCungCap = GetNhaCungCaps().Find(p => p.ma_ncc == maNCC);
        }

        public List<NhaCungCap> GetNhaCungCaps()
        {
            return nhaCungCapDAL.GetNhaCungCaps();
        }

        public void SuaNhaCungCap(string maNCC)
        {
            nhaCungCapDAL.Update(GetNhaCungCaps().Find(p => p.ma_ncc == maNCC));
        }
    }
}
