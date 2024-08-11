using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL.Repositories
{
    public class DoanhThuRepositories
    {
        Da1quanLyCuaHangContext _context;
        public DoanhThuRepositories()
        {
            _context = new Da1quanLyCuaHangContext();
        }
        public List<DoanhThu> GetAll()
        {
            return _context.DoanhThus.ToList();
        }
        public bool AddDoanhThu(Guid idhd, decimal gia)
        {
            try
            {
DoanhThu doanhThu = new DoanhThu()
            {
                HoaDonId = idhd,
                TongDoanhThu = gia,
                Ngay = DateOnly.FromDateTime(DateTime.Now)
            };
            _context.DoanhThus.Add(doanhThu);
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
