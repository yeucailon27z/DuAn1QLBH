using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HDCTRepositories
    {
        Da1quanLyCuaHangContext _context;
        public HDCTRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<HoaDonChiTiet> GetHDCTbyIDHD(Guid id)
        {
            return _context.HoaDonChiTiets.Where(p => p.HoaDonId == id).ToList();
        }
        public bool UpdateSL(int soluong, string idHDCT)
        {
            try
            {
                var hdct = _context.HoaDonChiTiets.Find(idHDCT);
                hdct.SoLuong = soluong + hdct.SoLuong;

                var sp = _context.SanPhams.Find(hdct.SanPhamId);
                hdct.SoLuong = hdct.SoLuong - soluong;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CreateHDCT(int soluong, Guid MaHD, string maSP)
        {
            SanPham sp = _context.SanPhams.Find(maSP);
            HoaDonChiTiet hdct = new HoaDonChiTiet()
            {
                HoaDonChiTietId="HDCT001",
                SoLuong = soluong,
                SanPhamId = maSP,
                HoaDonId = MaHD,
                DonGia = sp.Gia
            };
            try
            {
                _context.HoaDonChiTiets.Add(hdct);

                sp.SoLuong = sp.SoLuong - soluong;
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
