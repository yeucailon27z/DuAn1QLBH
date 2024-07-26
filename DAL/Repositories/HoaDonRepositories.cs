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
    }
}
