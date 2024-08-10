using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonRepositories
    {
        Da1quanLyCuaHangContext _context;
        public HoaDonRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<HoaDon> GetAll()
        {
            return _context.HoaDons.ToList();
        }
        public HoaDon Get(string ma)
        {
            return _context.HoaDons.Find(ma);
        }
        public bool Create(HoaDon hoaDon)
        {
            try
            {
                _context.HoaDons.Add(hoaDon);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool UpdateHD(Guid id, byte statuc, decimal? totalMoney,string?httt,string magg)
        {
            try
            {
                var hd = _context.HoaDons.Find(id);
                hd.TrangThai = statuc;
                hd.HinhThucThanhToan = httt;
                hd.NgayLap = DateTime.Now;
                hd.GiamGiaId = magg;
                if (totalMoney != null)
                {
                    hd.TongTien = totalMoney;
                }
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
